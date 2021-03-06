
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ErrorManagement.Entity;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Threading;
using AmiOperationLib;

namespace ErrorManagement
{
    public delegate void ReloadDataHandle();

    public partial class Solution : DevComponents.DotNetBar.Metro.MetroForm
    {
        public event ReloadDataHandle ReloadDataEvent;
        public List<ErrorEntity> errorList = new List<ErrorEntity>();
        public string currentErrorId = string.Empty;
        private int currentIndex = -1;
        public string dataSend = null;
        private ClientConnection errorManagement;
        private string dcuCode = null;
        private string meterType = null;
        private byte[] temp = null;
        private string topic = null;
        private string[] topicSubscribe = null;
        private DateTime? serverTime;
        private DateTime? meterTime;
        private string dataPayload = null;
        private int? statusDcu = null;
        private string gatewayip = null;

        public Solution(ClientConnection errormanagement)
        {
            InitializeComponent();
            this.errorManagement = errormanagement;
          
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveFixError();

            if (ReloadDataEvent != null)
                ReloadDataEvent();
        }

        private void SaveFixError()
        {
            // Delete error not in HN
            this.fixErrorTableAdapter.DeleteByErrorId(int.Parse(currentErrorId));
            AmiReportDataSet.FixErrorDataTable fixErrorDataTable = new AmiReportDataSet.FixErrorDataTable();
            for (int i = 0; i < dtgStepList.Rows.Count; i++)
            {
                int errorId = int.Parse(dtgStepList.Rows[i].Cells[ErrorIdColumn.Index].Value.ToString());
                int fixStepId = int.Parse(dtgStepList.Rows[i].Cells[FixStepIdColumn.Index].Value.ToString());
                int isUsed = int.Parse(dtgStepList.Rows[i].Cells[IsUsedColumn.Index].Value.ToString());
                var row = fixErrorDataTable.NewFixErrorRow();
                row.ErrorId = errorId;
                row.FixStepId = fixStepId;
                row.IsUsed = int.Parse(dtgStepList.Rows[i].Cells[IsUsedColumn.Index].Value.ToString());
                row.FixIndex = i + 1;
                fixErrorDataTable.AddFixErrorRow(row);
            }

            var query1 = this.amiReportDataSet.ErrorList.Where(r => r.ErrorId == int.Parse(currentErrorId));
            if (query1.Count() > 0)
            {
                query1.First().IsFixed = chkFixed.Checked ? 1 : 0;
                query1.First().FixContentSuggestion = txtNotes.Text;
                query1.First().FixDate = DateTime.Now;
                query1.First().FixGroupId = int.Parse(cboForwardTo.SelectedValue.ToString());
            }

            try
            {
                this.fixErrorBindingSource.EndEdit();
                // Update
                this.fixErrorTableAdapter.Update(fixErrorDataTable);
                // Update error list
                this.errorListTableAdapter.Update(this.amiReportDataSet.ErrorList);

                MessageBox.Show("Save Successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Solution_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.fixErrorTableAdapter.Fill(this.amiReportDataSet.FixError);

                this.fixGroupTableAdapter.Fill(this.amiReportDataSet.FixGroup);

                cboForwardTo.DataSource = this.amiReportDataSet.FixGroup;
                cboForwardTo.DisplayMember = this.amiReportDataSet.FixGroup.FixGroupNameColumn.ColumnName;
                cboForwardTo.ValueMember = this.amiReportDataSet.FixGroup.FixGroupIdColumn.ColumnName;

                this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);

                this.errorListTableAdapter.FillBy(this.amiReportDataSet.ErrorList, int.Parse(currentErrorId));

                if (!this.amiReportDataSet.ErrorList.First().IsFixGroupIdNull())
                    cboForwardTo.SelectedValue = this.amiReportDataSet.ErrorList.First().FixGroupId;

                // Current rowid
                var query = this.errorList.Where(r => r.ErrorId.Equals(currentErrorId));
                int first = 0;
                if (query.Count() > 0)
                    currentIndex = first = this.errorList.IndexOf(query.First());
                LoadError(first);

                //get status
                dcuCode = txtDcu.Text;
                meterType = this.getMeterTypeByDcucode(dcuCode);
                if (statusDcu == 1)
                {
                    lbConnectionDcu.Text = "Đang kết nối";
                    lbConnectionDcu.ForeColor = Color.Green;
                }
                else lbConnectionDcu.ForeColor = Color.Red;
                lbGatewayip.Text = gatewayip;

                //Connect & Suscribe MQTT
                errorManagement.UnSubscribeMessage();
                Thread.Sleep(1000); // wait 2s unsuscribe
                topicSubscribe = String.Format(Constant.topicSubcribeForDcu, meterType, dcuCode).Split(';');
                //errorManagement.mpttSusbcribe(false, topicSubscribe);
                tbmessageview.AppendText("Bắt đầu nhận dữ liệu......" + Environment.NewLine);
                this.errorManagement.receiveMessageEvent += errorManagement_receiveMessageEvent;
                errorManagement.receive1Dcu = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadError(int index)
        {
            if (errorList.Count == 0 || index < 0 || index > errorList.Count - 1)
            {
                return;
            }
            currentErrorId = errorList[index].ErrorId;
            txtDcu.Text = errorList[index].DcuCode;
            txtErrorCode.Text = errorList[index].ErrorCode;
            lblErrorName.Text = errorList[index].ErrorName;
            lblCurrent.Text = (currentIndex + 1).ToString();
            lblTotal.Text = errorList.Count.ToString();

            cboForwardTo_SelectedIndexChanged(null, null);
        }

        private void btnPreError_Click(object sender, System.EventArgs e)
        {
            currentIndex--;
            btnNextError.Enabled = true;
            if (currentIndex <= 0)
            {
                btnPreError.Enabled = false;
            }
            LoadError(currentIndex);
        }

        private void btnNextError_Click(object sender, System.EventArgs e)
        {
            currentIndex++;
            btnPreError.Enabled = true;
            if (currentIndex == errorList.Count - 1)
            {
                btnNextError.Enabled = false;
            }

            LoadError(currentIndex);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void MoveUp()
        {
            try
            {
                if (selectIndex == 0 || selectIndex == dtgStepList.Rows.Count)
                    return;

                object curretnIndex = dtgStepList.Rows[selectIndex].Cells[FixStepIdColumn.Index].Value;
                object curretnValue = dtgStepList.Rows[selectIndex].Cells[FixStepNameColumn.Index].Value;

                object preIndex = dtgStepList.Rows[selectIndex - 1].Cells[FixStepIdColumn.Index].Value;
                object preValue = dtgStepList.Rows[selectIndex - 1].Cells[FixStepNameColumn.Index].Value;

                dtgStepList.Rows[selectIndex - 1].Cells[FixStepIdColumn.Index].Value = curretnIndex;
                dtgStepList.Rows[selectIndex - 1].Cells[FixStepNameColumn.Index].Value = curretnValue;

                dtgStepList.Rows[selectIndex].Cells[FixStepIdColumn.Index].Value = preIndex;
                dtgStepList.Rows[selectIndex].Cells[FixStepNameColumn.Index].Value = preValue;

                dtgStepList.ClearSelection();

                dtgStepList.Rows[selectIndex - 1].Selected = true;
                selectIndex = selectIndex - 1;
            }
            catch { }
        }

        private void MoveDown()
        {
            try
            {
                if (selectIndex >= dtgStepList.Rows.Count - 1)
                    return;

                object curretnIndex = dtgStepList.Rows[selectIndex].Cells[FixStepIdColumn.Index].Value;
                object curretnValue = dtgStepList.Rows[selectIndex].Cells[FixStepNameColumn.Index].Value;

                object preIndex = dtgStepList.Rows[selectIndex + 1].Cells[FixStepIdColumn.Index].Value;
                object preValue = dtgStepList.Rows[selectIndex + 1].Cells[FixStepNameColumn.Index].Value;

                dtgStepList.Rows[selectIndex + 1].Cells[FixStepIdColumn.Index].Value = curretnIndex;
                dtgStepList.Rows[selectIndex + 1].Cells[FixStepNameColumn.Index].Value = curretnValue;

                dtgStepList.Rows[selectIndex].Cells[FixStepIdColumn.Index].Value = preIndex;
                dtgStepList.Rows[selectIndex].Cells[FixStepNameColumn.Index].Value = preValue;

                dtgStepList.ClearSelection();

                dtgStepList.Rows[selectIndex + 1].Selected = true;
                selectIndex = selectIndex + 1;
            }
            catch { }
        }
        int selectIndex = -1;

        private void dtgStepList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectIndex = e.RowIndex;
            //if (e.ColumnIndex != ChooseColumn.Index)
            //    return;
            //int check = int.Parse(dtgStepList.Rows[e.RowIndex].Cells[IsUsedColumn.Index].Value.ToString()) == 1 ? 0 : 1;

            //dtgStepList.Rows[e.RowIndex].Cells[IsUsedColumn.Index].Value = check;
            //if (check == 1)
            //    txtNotes.AppendText("-" + dtgStepList.Rows[e.RowIndex].Cells[FixStepNameColumn.Index].Value.ToString() + "\n");
        }

        private void LoadStepFixErrorByErrorCodeAndGroupId(string errorCode, int groupId, int errorId)
        {
            try
            {
                txtNotes.Text = string.Empty;
                chkFixed.Checked = false;

                this.fixErrorTableAdapter.FillBy(this.amiReportDataSet.FixError, errorId);

                this.getFixErrorTableAdapter.FillByGroupIdAndErrorCode(this.amiReportDataSet.GetFixError, groupId, errorCode, errorId);
                for (int i = 0; i < dtgStepList.Rows.Count; i++)
                {
                    dtgStepList.Rows[i].Cells[ErrorIdColumn.Index].Value = errorId;
                }

                this.errorListTableAdapter.FillBy(this.amiReportDataSet.ErrorList, errorId);


                if (cboForwardTo.SelectedValue != null)
                    if (!this.amiReportDataSet.ErrorList.First().IsFixGroupIdNull() && int.Parse(cboForwardTo.SelectedValue.ToString()) == this.amiReportDataSet.ErrorList.First().FixGroupId)
                    {
                        txtNotes.Text = this.amiReportDataSet.ErrorList.First().IsFixContentSuggestionNull() ? string.Empty : this.amiReportDataSet.ErrorList.First().FixContentSuggestion;
                        chkFixed.Checked = this.amiReportDataSet.ErrorList.First().IsFixed == 1 ? true : false;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboForwardTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboForwardTo.Text == null)
                return;
            int groupId = int.Parse(cboForwardTo.SelectedValue.ToString());
            LoadStepFixErrorByErrorCodeAndGroupId(txtErrorCode.Text, groupId, int.Parse(currentErrorId));
        }

        private void dtgStepList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgStepList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private bool isValueChanged = false;
        private bool stopSelectAll = false;

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isValueChanged)
                return;

            for (int j = 0; j < this.dtgStepList.Rows.Count; j++)
            {
                if (chkAll.Checked && !stopSelectAll)
                    this.dtgStepList[IsUsedColumn.DisplayIndex, j].Value = this.chkAll.Checked;
                else if (!chkAll.Checked && !stopSelectAll)
                    this.dtgStepList[IsUsedColumn.DisplayIndex, j].Value = this.chkAll.Checked;

            }
            stopSelectAll = false;
            this.dtgStepList.EndEdit();
            this.isValueChanged = false;
        }

        private void CheckAll()
        {
            for (int i = 0; i < dtgStepList.Rows.Count; i++)
            {              
                if (!(bool)dtgStepList.Rows[i].Cells[IsUsedColumn.Index].Value)
                {
                    stopSelectAll = false;
                    return;
                }
            }
            stopSelectAll = true;
            chkAll.Checked = true;
        }

        private void dtgStepList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IsUsedColumn.Index)
            {
                int check = int.Parse(dtgStepList.Rows[e.RowIndex].Cells[IsUsedColumn.Index].Value.ToString());

                if (check == 0)
                {
                    isValueChanged = true;
                    chkAll.Checked = false;
                }
                else
                {
                    txtNotes.AppendText("-" + dtgStepList.Rows[e.RowIndex].Cells[FixStepNameColumn.Index].Value.ToString() + "\n");
                }

                isValueChanged = false;
                CheckAll();
            }
        }

        private void btReset_Click(string dcuId)
        {
            try
            {

                // Message type
                this.temp = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray("01"));
                this.temp = ByteUltil.Combine(temp, ConvertUtil.HexStringToHexByteArray("05"));
                this.temp = ByteUltil.Combine(temp, ConvertUtil.HexStringToHexByteArray("7265736574"));//reset
                this.topic = "AMI/" + dcuId + "/Reset";

            }
            catch (Exception ex)
            { }
        }

        private void btUpdate_Click(string dcuId)
        {
            try
            {
                //if (meterType == null) return;
                //this.temp = errorManagement.CheckDataUpdateFirmware(meterType);
                //this.topic = "AMI/" + dcuId + "/rFirm";
            }
            catch (Exception ex)
            {
 
            }
        }

        private string getMeterTypeByDcucode(string dcuId)
        {
            try
            {
                //meterType = errorManagement.GetMeterType(dcuId, ref this.statusDcu, ref this.gatewayip);
                switch (meterType)
                {
                    case "GELEX":
                        meterType = "GEL1";
                        break;
                    case "ELSTER":
                        meterType = "ELS1";
                        break;
                    case "DTS27":
                        meterType = "DTS1";
                        break;
                    case "GENIUS_TT":
                        meterType = "GEN1";
                        break;
                    case "LANDIS3PHASE_TT":
                        meterType = "LAN1";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { }
            return meterType;
        }
        private void btErase_Click(string dcuId)
        {
            try
            {
                this.temp = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray("0106557064617465"));
                this.topic = "AMI/" + dcuId + "/Erase";
            }
            catch (Exception ex) { }
        }

        private void btSendAction_Click(object sender, EventArgs e)
        {

            byte[] lengthOp = null;
            byte[] tempref = null;
            if (tbEa.Text != "" && tbEb.Text != "" && cbAction.Text.Equals(itOpe.Text))
            {
                this.temp = ConvertUtil.HexStringToHexByteArray(tbEa.Text);
                lengthOp = ConvertUtil.HexStringToHexByteArray(temp.Length.ToString());
                this.temp = ByteUltil.Combine(lengthOp, temp);
                this.temp = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray("EA"), temp);

                tempref = ConvertUtil.HexStringToHexByteArray(tbEb.Text);
                lengthOp = ConvertUtil.HexStringToHexByteArray(tempref.Length.ToString());
                tempref = ByteUltil.Combine(lengthOp, tempref);
                tempref = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray("EB"), tempref);
                this.temp = ByteUltil.Combine(temp, tempref);
                this.topic = "AMI/" + dcuCode + "/Opera";
            }
            if ((temp == null) || (topic == null))
            {
                MessageBox.Show("Action Fail! Check action again!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorManagement.PublishMessage(topic, temp);
                MessageBox.Show("Send OK", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbAction.Text == null)
                return;
            temp = null;
            topic = null;
            dcuCode = txtDcu.Text;
            if (cbAction.Text.Equals(itReset.Text)) btReset_Click(dcuCode);
            else if (cbAction.Text.Equals(itUpdate.Text)) btUpdate_Click(dcuCode);
            else if (cbAction.Text.Equals(itErase.Text)) btErase_Click(dcuCode);
            else if (cbAction.Text.Equals(itInstan.Text)) this.readInstan(dcuCode);
        }


        private void readInstan(string dcuCode)
        {
            this.temp = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray("0106556464617465"));
            this.topic = "AMI/" + dcuCode + "/Instan";
        }

        private void errorManagement_receiveMessageEvent(string topic, byte[] message)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate()
                {

                    string messagePayload = ConvertUtil.BytesToHexString(message);
                    tbmessageview.AppendText(Environment.NewLine + "Topic: " + topic +
                        Environment.NewLine);
                    dataPayload = null;
                    try
                    {
                        if (topic.Split('/')[3].Equals("Intan") || topic.Split('/')[3].Equals("Opera"))
                        {
                            serverTime = null;
                            meterTime = null;
                            switch (meterType)
                            {
                                case "GEL1":
                                    serverTime = ConvertUtil.convertDateTime(messagePayload.Substring(8, 12));
                                    meterTime = ConvertUtil.convertMeterTimeGelex(messagePayload.Substring(24, 24));
                                    break;
                                case "ELS1":
                                    serverTime = ConvertUtil.convertDateTime(messagePayload.Substring(8, 12));
                                    meterTime = ConvertUtil.convertMeterTimeElster(messagePayload.Substring(messagePayload.Length - 16, 14));
                                    break;
                                case "DTS1":
                                    serverTime = ConvertUtil.convertDateTime(messagePayload.Substring(8, 12));
                                    meterTime = ConvertUtil.convertMeterTimeStar(messagePayload.Substring(24, 14));
                                    break;
                                case "GEN1":
                                    serverTime = ConvertUtil.convertDateTime(messagePayload.Substring(8, 12));

                                    break;
                                case "LAN1":
                                    serverTime = ConvertUtil.convertDateTime(messagePayload.Substring(8, 12));
                                    meterTime = ConvertUtil.convertMeterTimeLandis(messagePayload.Substring(messagePayload.Length - 26, 24));
                                    break;
                                default:
                                    break;
                            }
                            dataPayload = Environment.NewLine + "               " + "ServerTime: " + serverTime.ToString() +
                                Environment.NewLine + "               " + "MeterTime: " + meterTime.ToString();
                        }
                        if (topic.Split('/')[3].Equals("TEST1"))
                        {
                            string flashFail = null, firmwareFail = null, wrongPending = null, otherFail = null;

                            byte[] data = message;
                            if (data[1] == 1) flashFail = "Lỗi Flash";
                            else if (data[1] > 1) firmwareFail = "Lỗi Firmware";
                            if (data[2] > 0)
                                wrongPending = "Lỗi Pendding";
                            if (data[4] > data[3]) otherFail = "Lỗi so sánh byte3 và byte4";
                            if ((flashFail != null) || (firmwareFail != null) || (wrongPending != null) || (otherFail != null))
                            {
                                dataPayload = "LỖI: " + flashFail + " - " + firmwareFail + " - " + wrongPending + " - " + otherFail;
                            }
                            else dataPayload = "OK";

                            dataPayload = Environment.NewLine + "               " + dataPayload + Environment.NewLine + "               "
                                + "BufferA: " + (data[3].ToString("X2")) +
                                Environment.NewLine + "               " + "BufferB: " + (data[4].ToString("X2"))
                                + Environment.NewLine + "               " + "FirmwareVersion: " + data[5].ToString();
                        }

                        if (topic.Split('/')[3].Equals("rFirm"))
                        {
                            byte[] dataFirm = new byte[20];
                            Array.Copy(message, message.Length - 20, dataFirm, 0, 20);
                            dataPayload = ConvertUtil.ToHexStringToString(dataFirm);
                        }


                    }
                    catch (Exception ex) { }
                    tbmessageview.AppendText("Payload: " + dataPayload + Environment.NewLine);

                };
                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch (Exception ex) { }

            MemoryManagement.MinimizeMemory();
        }

        private void Solution_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorManagement.receive1Dcu = false;
            errorManagement.UnSubscribeMessage(topicSubscribe);
            //errorManagement.mpttSusbcribe(true);
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            tbmessageview.Clear();
        }
    }
}