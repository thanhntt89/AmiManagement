using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.FirmwareDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ObisTableDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.OperationTimeConfigDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DcuTempDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using AmiOperationManagement.Resources;
using System.ComponentModel;
using System.Threading;
using AmiOperationManagement.Deployment;

namespace AmiOperationManagement.Main
{
    public partial class UCDcuController : UserControlBase
    {
        private MessageCollection messageCollection = new MessageCollection();

        private bool IsDisconnected;
        public event RecieveMessageEventHandle PublishMessageEvent;

        // Current text search
        private string currentSearh = string.Empty;
        // List index search
        private List<int> lisIndex = new List<int>();

        private int numberRequestCount = 0;

        // Idtopic do người dùng chọn
        private int commandId = -1;

        // Topic do người dùng chọn
        private string topicSelected = string.Empty;

        // Danh sách dcu do người dùng nhập vào
        private List<string> dcuList = new List<string>();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        private DcuTempDataSet.DcuTempDataTable dcuTempDataTable = new DcuTempDataSet.DcuTempDataTable();
        private DcuTempTableAdapter dcuTempTableAdapter = new DcuTempTableAdapter();

        private FirmwareDataSet.FirmwareDataTable firmwareDataTable = new FirmwareDataSet.FirmwareDataTable();
        private FirmwareTableAdapter firmwareTableAdapter = new FirmwareTableAdapter();

        private ObisTableDataSet.ObisTableDataTable obisTableDataTable = new ObisTableDataSet.ObisTableDataTable();
        private ObisTableTableAdapter obisTableTableAdapter = new ObisTableTableAdapter();

        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();

        private string functionSelected = string.Empty;
        private int firmWareId = -1;
        private BackgroundWorker bgwWaiting;

        private string serverID1 = string.Empty;
        private string serverID2 = string.Empty;
        private string firmWareVersionText = string.Empty;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
                btnSearch_Click(null, null);
            else if (keyData == Keys.Escape)
                btnHidePanel_Click(null, null);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCDcuController()
        {
            InitializeComponent();

            panelSearch.Location = new System.Drawing.Point(95, 55);
            panelSearch.Size = new System.Drawing.Size(600, 238);
            panelOption.Location = new System.Drawing.Point(342, 0);
            grpOption.Location = new System.Drawing.Point(342, 3);
            grpServerConfig.Location = new System.Drawing.Point(342, 3);
            plTimeReadOperation.Location = new Point(342, 3);
            plHistories.Location = new Point(342, 3);
            dtFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dtHistoriesOfMonth.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ucProgressBarStop.StopSendingEvent += StopSending;
        }

        /// <summary>
        /// Dừng gửi nhận dữ liệu do người dùng thao tác
        /// </summary>
        public void StopSending()
        {
            if (bgwWaiting.IsBusy)
                this.bgwWaiting.CancelAsync();
        }

        private void LoadOperationReadingTime()
        {
            OperationTimeConfigDataSet.OperationTimeConfigDataTable operationTimeConfigDataTable = new OperationTimeConfigDataSet.OperationTimeConfigDataTable();
            OperationTimeConfigTableAdapter operationTimeConfigTableAdapter = new OperationTimeConfigTableAdapter();

            try
            {
                operationTimeConfigTableAdapter.Fill(operationTimeConfigDataTable);

                cboOperationReadingTime.DataSource = operationTimeConfigDataTable;
                cboOperationReadingTime.DisplayMember = operationTimeConfigDataTable.TimesColumn.ToString();
                cboOperationReadingTime.ValueMember = operationTimeConfigDataTable.TimesColumn.ToString();

                cboOperationReadingTime.SelectedValue = UserSession.SystemConfig != null ? UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation : 0;
                cboOperationReadingTime.Enabled = false;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCDCUCONTROLLER - Lỗi load bản tin đọc được cấu hình thời gian Operation. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu thời gian đọc bản tin hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadServer()
        {
            int rst = this.serverTableAdapter.FillByTypeAndStatus(this.serverDataTable, Constant.Gateway, true);
            if (rst == 0)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu thông tin bảng server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cboServer1.DataSource = this.serverDataTable;
            cboServer1.DisplayMember = this.serverDataTable.ServerNameColumn.ToString();
            cboServer1.ValueMember = this.serverDataTable.ServerIdColumn.ToString();

            cboServer2.DataSource = this.serverDataTable;
            cboServer2.BindingContext = new System.Windows.Forms.BindingContext();
            cboServer2.DisplayMember = this.serverDataTable.ServerNameColumn.ToString();
            cboServer2.ValueMember = this.serverDataTable.ServerIdColumn.ToString();
        }

        private void LoadObisTable()
        {
            int rst = this.obisTableTableAdapter.Fill(this.obisTableDataTable);
            if (rst == 0)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu obis.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFirmWare()
        {
            int rst = this.firmwareTableAdapter.FillByStatus(this.firmwareDataTable, Constant.IsUsed);
            if (rst == 0)
                return;
            cboFirmwareVersion.DataSource = this.firmwareDataTable;
            cboFirmwareVersion.DisplayMember = this.firmwareDataTable.FirmwareNameColumn.ToString();
            cboFirmwareVersion.ValueMember = this.firmwareDataTable.FirmwareIdColumn.ToString();
        }

        public void DisplayMessageSubscribe(string topic, byte[] playload)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    // Dcu
                    string dcu = topic.Split('/')[Constant.DCU_TOPIC_INDEX];

                    if (txtDcuInput.Text.Contains(topic))
                        return;
                }
                catch
                {
                    return;
                }

                this.DisPlayModemError(topic, playload);

                // Giải mã lấy trường thời gian trong từng bản tin
                byte[] serverTimeBye = new byte[6];
                DateTime dateTime = new DateTime();

                if (topic.Contains(Constant.OperationTopic) || topic.Contains(Constant.IntantanTopic) || topic.Contains(Constant.LoadProfileTopic) || topic.Contains(Constant.HistoriesTopic))
                {
                    Array.Copy(playload, 4, serverTimeBye, 0, serverTimeBye.Length);
                    try
                    {
                        dateTime = new DateTime(2000 + Convert.ToInt32(serverTimeBye[0]), Convert.ToInt32(serverTimeBye[1]), Convert.ToInt32(serverTimeBye[2]), Convert.ToInt32(serverTimeBye[3]), Convert.ToInt32(serverTimeBye[4]), Convert.ToInt32(serverTimeBye[5]));
                    }
                    catch (Exception ex)
                    {
                        dateTime = DateTime.MinValue;
                    }
                }

                this.messageCollection.Add(new MessageEntity
                {
                    Topic = topic,
                    ServerTime = dateTime,
                    ReceiveTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                    Data = playload
                });

                // Get dcu repair
                var query = (from r in dtgSubcribeTopic.Rows.Cast<DataGridViewRow>()
                             where r.Cells[TopicsCol.Index].Value.ToString().Equals(topic)
                             select r
                                 );

                if (query.Count() > 0)
                {
                    if (dateTime == DateTime.MinValue)
                    {
                        query.First().Cells[clOpError.Index].Value = true;
                    }
                    else if (dateTime > DateTime.Parse(query.First().Cells[clServerTime.Index].Value.ToString()))
                    {
                        query.First().Cells[clMessageTime.Index].Value = dateTime.ToString("dd-MM-yyyy HH:mm:ss");
                        query.First().Cells[clServerTime.Index].Value = dateTime;
                    }
                    query.First().Cells[DataCol.Index].Value = ConvertUtil.BytesToHexString(playload);
                    query.First().Cells[ReceiveTimeCol.Index].Value = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    query.First().Cells[clCount.Index].Value = int.Parse(query.First().Cells[clCount.Index].Value.ToString()) + 1;
                    return;
                }
                try
                {
                    dtgSubcribeTopic.Rows.Add(topic, 1, false, dateTime == DateTime.MinValue ? string.Empty : dateTime.ToString("dd-MM-yyyy HH:mm:ss"), DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), dateTime, ConvertUtil.BytesToHexString(playload));
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(LogLevelL4N.ERROR, "UCDCUCONTROLLER - Lỗi hiển thị bản tin lên giao diện. Chi tiết lỗi: ", ex);
                }
            }));
            MemoryManagement.MinimizeMemory();
        }

        private void DisPlayModemError(string topic, byte[] playload)
        {
            Invoke(new Action(() =>
            {
                // Không xử lý bản tin nếu ko phải bản tin warning
                if (!topic.Contains(Constant.WarningTopic))
                {
                    return;
                }

                byte obis = playload[2];
                string temp = null;

                string dcu = topic.Split('/')[4];

                var query = (from r in dtgDecuError.Rows.Cast<DataGridViewRow>()
                             where r.Cells[clDcuCode.Index].Value.ToString().Equals(dcu)
                             select r
                                );

                switch (obis)
                {
                    // Lỗi flash
                    case 0x01:
                        temp = Constant.FlashErorText;
                        if (query.Count() == 0)
                        {
                            dtgDecuError.Rows.Add(null, dcu, null, null, null, null, true);
                        }
                        else
                        {
                            query.First().Cells[clFlashError.Index].Value = true;
                        }
                        break;
                    // Thay cơng tơ
                    case 0x02:
                        temp = Constant.WarningChangeMeterText;
                        if (query.Count() == 0)
                        {
                            dtgDecuError.Rows.Add(null, dcu, null, null, true, null, null);
                        }
                        else
                        {
                            query.First().Cells[clChangeMeter.Index].Value = true;
                        }
                        break;
                    // Mất kết nối với công tơ
                    case 0x03:
                        temp = Constant.WarningDcuDisconnectMeter;
                        if (query.Count() == 0)
                        {
                            dtgDecuError.Rows.Add(null, dcu, null, null, null, true, null);
                        }
                        else
                        {
                            query.First().Cells[clDcuDisConnectMeter.Index].Value = true;
                        }
                        break;
                    // Đọc sai
                    case 0x04:
                        temp = Constant.WarningMeterDataWrongText;
                        if (query.Count() == 0)
                        {
                            dtgDecuError.Rows.Add(null, dcu, true, null, null, null, null);
                        }
                        else
                        {
                            query.First().Cells[clWrongData.Index].Value = true;
                        }
                        break;
                    // Lỗi dây
                    case 0x08:
                        temp = Constant.WarningErrorLineText;
                        if (query.Count() == 0)
                        {
                            dtgDecuError.Rows.Add(null, dcu, null, true, null, null, null);
                        }
                        else
                        {
                            query.First().Cells[clLineError.Index].Value = true;
                        }
                        break;
                    default:
                        break;
                }
            }));
        }

        private void SuggestDcu()
        {
            if (string.IsNullOrWhiteSpace(cboDcu.Text))
            {
                panelSearch.Visible = false;
                return;
            }
            try
            {
                int rst = this.dcuTempTableAdapter.Fill(this.dcuTempDataTable);
                if (rst == 0)
                    return;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCDCUCONTROLLER - Lỗi SuggestDcu - Load dữ liệu DCU. Chi tiết lỗi: ", ex);
                MessageBox.Show("Không tải được dữ liệu từ máy chủ. Chi tiết lỗi:\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panelSearch.BringToFront();
            panelSearch.Visible = true;

            var query = this.dcuTempDataTable.Where(r => r.DcuCode.ToLower().Contains(cboDcu.Text.ToLower()));

            dtgDcuSearch.Rows.Clear();

            int index = 0;

            foreach (var item in query)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                dtgDcuSearch.Rows.Add(item.DcuCode, item.CreatedTime, item.GetwayIp, item.ConnectionStatus == Constant.CONNECT_STATUS ? Constant.SERVER_CONNECT_STATUS_TEXT : Constant.SERVER_DISCONNECT_STATUS_TEXT, null);

                if (item.ConnectionStatus == Constant.CONNECT_STATUS)
                {
                    style.ForeColor = Color.Green;
                }
                else
                {
                    style.ForeColor = Color.Red;
                }
                dtgDcuSearch.Rows[index].Cells[ConnectionStatusCol.Index].Style = style;

                index++;
            }
        }

        public void SetDcuInputStatus(bool isEnable)
        {
            cboDcu.Enabled = btnDeleteDcu.Enabled = txtDcuInput.Enabled = isEnable;
        }

        public void SetPublishEnable(bool isEnable)
        {
            chkEncryption.Enabled = btnPublish.Enabled = isEnable;

            // Trạng thái mất kết nối
            if (!isEnable)
            {
                this.IsDisconnected = true;
                if (bgwWaiting != null && bgwWaiting.IsBusy)
                    this.bgwWaiting.CancelAsync();
            }
        }

        private void LoadPublicMessage()
        {
            int rst = this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.PublicMessage);
            if (rst == -1)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cboPublicMessage.DataSource = this.commandLineDataTable;
            cboPublicMessage.DisplayMember = this.commandLineDataTable.CommandNameColumn.ToString();
            cboPublicMessage.ValueMember = this.commandLineDataTable.CommandCodeColumn.ToString();
            this.cboOperationReadingTime.SelectedIndexChanged += new System.EventHandler(this.cboPublicMessage_SelectedIndexChanged);
        }

        private void cboPublicMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpOption.Visible = false;
            panelOption.Visible = false;
            grpServerConfig.Visible = false;
            plTimeReadOperation.Visible = false;
            plHistories.Visible = false;
            tabControlMain.Location = new Point(342, 7);
            tabControlMain.Height = this.txtDcuInput.Height + this.grpOption.Height + 15;

            if (cboPublicMessage.SelectedValue == null)
                return;

            functionSelected = cboPublicMessage.SelectedValue.ToString();

            switch (functionSelected)
            {
                case Constant.REQUEST_FIRMWARE:
                    panelOption.Visible = true;
                    tabControlMain.Location = new Point(342, 74);
                    tabControlMain.Height = this.txtDcuInput.Height;
                    break;
                case Constant.REQUEST_OPERATION:
                case Constant.REQUEST_LOADPROFILE:
                    tabControlMain.Location = new Point(342, 74);
                    tabControlMain.Height = this.txtDcuInput.Height;
                    grpOption.Visible = true;
                    break;
                case Constant.REQUEST_DCU_SERVER_CONFIG:
                    tabControlMain.Location = new Point(342, 74);
                    tabControlMain.Height = this.txtDcuInput.Height;
                    grpServerConfig.Visible = true;
                    break;
                case Constant.REQUEST_CONFIG_OPERATION_TIME:
                    plTimeReadOperation.Visible = true;
                    tabControlMain.Location = new Point(342, 74);
                    tabControlMain.Height = this.txtDcuInput.Height;
                    break;
                case Constant.REQUEST_HISTORIES:
                    plHistories.Visible = true;
                    tabControlMain.Location = new Point(342, 74);
                    tabControlMain.Height = this.txtDcuInput.Height;
                    break;
                default:
                    break;
            }

            // Get CommandId, topicselected
            var query = this.commandLineDataTable.Where(r => r.CommandCode.Equals(cboPublicMessage.SelectedValue));
            if (query.Count() > 0)
            {
                commandId = query.First().CommandId;
                topicSelected = query.First().Topic;
            }
        }

        private void btnDeleteDcu_Click(object sender, EventArgs e)
        {
            txtDcuInput.Text = string.Empty;
        }

        private void cboDcu_TextChanged(object sender, EventArgs e)
        {
            SuggestDcu();
        }

        private void btnHidePanel_Click(object sender, EventArgs e)
        {
            cboDcu.Text = string.Empty;
            panelSearch.Visible = false;
        }

        private void dtgDcuSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != ChooseCol.Index)
                return;
            this.AddModem(dtgDcuSearch.CurrentRow.Cells[SearchDcuCodeCol.Index].Value.ToString());
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            WaittingDisplay();
        }

        private void btnDeleteSubscribe_Click(object sender, EventArgs e)
        {
            dtgSubcribeTopic.Rows.Clear();
            dtgDecuError.Rows.Clear();
            this.messageCollection.Clear();
            MemoryManagement.MinimizeMemory();
        }

        private void WaittingDisplay()
        {
            txtDcuInput.Text = Regex.Replace(txtDcuInput.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            if (string.IsNullOrWhiteSpace(txtDcuInput.Text))
            {
                MessageBox.Show("Bạn chưa nhập thiết bị nào để thao tác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDcuInput.Focus();
                return;
            }

            // Lấy về danh sách dcu người dùng nhập vào
            dcuList = txtDcuInput.Text.Trim().Split('\n').ToList();

            if (dcuList.Count > UserSession.SystemConfig.NumberOfModemRequestOperation)
            {
                MessageBox.Show("Số lượng modem yêu cầu lấy dự liệu không được vượt quá " + UserSession.SystemConfig.NumberOfModemRequestOperation, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDcuInput.Focus();
                return;
            }

            var dcuId = dcuList.Distinct();
            foreach (var item in dcuId)
            {
                var count = dcuList.Where(r => r.Equals(item)).Count();
                if (count > 1)
                {
                    MessageBox.Show("Modem :" + item + " trùng nhau trong danh sách. Mỗi modem chỉ được sử dụng một dòng duy nhất", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            double time = -1;

            // Check điều kiện các lệnh tương ứng
            switch (functionSelected)
            {
                case Constant.REQUEST_INTAN:
                    break;
                case Constant.REQUEST_OPERATION:
                    if (dtFromDate.Value > dtToDate.Value)
                    {
                        MessageBox.Show("Thời điểm bắt đầu lấy bản tin: " + dtFromDate.Text + " không được lớn hơn thời điểm cuối: " + dtToDate.Text, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtFromDate.Focus();
                        return;
                    }

                    time = (dtToDate.Value - dtFromDate.Value).TotalHours;
                    if (time > UserSession.SystemConfig.NumberOfTimeRequestOperation)
                    {
                        MessageBox.Show("Khoảng thời gian lấy bản tin không được quá " + UserSession.SystemConfig.NumberOfTimeRequestOperation + " giờ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtFromDate.Focus();
                        return;
                    }

                    time = (DateTime.Now - dtFromDate.Value).TotalDays;

                    if (time > UserSession.SystemConfig.NumberOfDateRequesOperation)
                    {
                        MessageBox.Show("Thời gian bắt đầu lấy bản tin " + dtFromDate.Text + " đến thời điểm hiện tại: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " không vượt quá " + UserSession.SystemConfig.NumberOfDateRequesOperation + " ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtFromDate.Focus();
                        return;
                    }

                    break;
                case Constant.REQUEST_LOADPROFILE:

                    if (dtFromDate.Value > dtToDate.Value)
                    {
                        MessageBox.Show("Thời điểm bắt đầu lấy bản tin: " + dtFromDate.Text + " không được lớn hơn thời điểm cuối: " + dtToDate.Text, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtFromDate.Focus();
                        return;
                    }

                    time = (dtToDate.Value - dtFromDate.Value).TotalDays;
                    if (time > UserSession.SystemConfig.NumberOfDateRequestLoadProfile)
                    {
                        MessageBox.Show("Khoảng thời gian lấy bản tin không được quá " + UserSession.SystemConfig.NumberOfDateRequestLoadProfile + " ngày", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtFromDate.Focus();
                        return;
                    }
                    break;
                case Constant.REQUEST_HISTORIES:
                    if (DateTime.Now < dtHistoriesOfMonth.Value)
                    {
                        MessageBox.Show("Thời gian lấy bản tin lịch sử không được quá thời gian hiện tại. Thời gian lấy dữ liệu:" + dtHistoriesOfMonth.Value.ToString("MM/yyyy") + " > Thơi gian hiện tại: " + DateTime.Now.ToString("MM/yyyy"), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case Constant.REQUEST_FIRMWARE:
                    if (cboFirmwareVersion.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn phải chọn phiên bản phần mềm để cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy về đường dẫn firmware
                    string path = this.cboFirmwareVersion.SelectedValue.ToString();

                    var firmware = this.firmwareDataTable.Where(r => r.FirmwareId == int.Parse(cboFirmwareVersion.SelectedValue.ToString()));
                    if (firmware.Count() == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiên bản phần mềm nào.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var rst1 = MessageBox.Show("Bạn muốn cập nhật phiên bản phần mềm: " + cboFirmwareVersion.Text + " cho các modem này không?\nChú ý: Nếu cập nhật sai phiên bản phần mềm modem sẽ không đọc được dữ liệu. Bạn hãy kiểm tra kỹ trước khi thực hiện thao tác này. Để tiếp tục chọn Yes - No để huỷ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rst1 == DialogResult.No)
                        return;
                    break;
                case Constant.REQUEST_DCU_SERVER_CONFIG:
                    if (cboServer1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn server1", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cboServer2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn server2", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult rst = MessageBox.Show("Việc cấu hình lại server sẽ ảnh hướng đến hoạt động của modem trong một vài phút.\nĐể tránh việc mất bản tin không mong muốn bạn hãy thao tác tránh vào thời điểm modem đang đọc bản tin hoạt động.\nBạn có muốn tiếp tục thực hiện cấu hình lại thông tin server cho những modem này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rst == DialogResult.No)
                        return;
                    break;
                case Constant.REQUEST_RESET:

                    var rst2 = MessageBox.Show("Bạn có muốn khởi động lại các thiết bị trong danh sách?? Để tiếp tục chọn Yes - No để huỷ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rst2 == DialogResult.No)
                        return;
                    break;
                case Constant.REQUEST_ERASE_FLASH:

                    break;
                default:
                    break;
            }

            // Lấy giá trị cho các biến
            serverID1 = cboServer1.SelectedValue.ToString();
            serverID2 = cboServer2.SelectedValue.ToString();
            firmWareVersionText = cboFirmwareVersion.Text;
            firmWareId = int.Parse(cboFirmwareVersion.SelectedValue.ToString());
            this.numberRequestCount = 0;
            this.IsDisconnected = false;
            btnPublish.Enabled = false;
            btnDeleteDcu.Enabled = false;
            txtDcuInput.ReadOnly = true;
            cboPublicMessage.Enabled = false;
            panelOption.Enabled = false;
            plHistories.Enabled = false;
            plTimeReadOperation.Enabled = false;
            grpOption.Enabled = false;
            ucProgressBarStop.Visible = true;
            cboDcu.Enabled = false;
            this.IsDisconnected = false;
            ucProgressBarStop.SetTile(Constant.StopSendingText);

            if (bgwWaiting == null)
            {
                bgwWaiting = new BackgroundWorker();
                bgwWaiting.RunWorkerCompleted += bgwWaiting_RunWorkerCompleted;
                bgwWaiting.DoWork += bgwWaiting_DoWork;
                bgwWaiting.ProgressChanged += bgwWaiting_ProgressChanged;
                bgwWaiting.WorkerReportsProgress = true;
                bgwWaiting.WorkerSupportsCancellation = true;
            }
            if (!bgwWaiting.IsBusy)
                bgwWaiting.RunWorkerAsync();
        }

        void bgwWaiting_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ucProgressBarStop.SetValue(this.numberRequestCount, e.ProgressPercentage);
        }

        void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            PublishMessage(e);
        }

        void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (this.IsDisconnected)
                {
                    btnPublish.Enabled = false;
                    MessageBox.Show("Mất kết nối đến server, gửi yêu cầu đã bị dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnPublish.Enabled = true;
                    MessageBox.Show("Tiến trình đã ngừng xử lý, gửi yêu cầu đã bị dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (e.Error != null)
            {
                btnPublish.Enabled = true;
                MessageBox.Show("Lỗi trong quán trình xử lý, gửi yêu cầu đã dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnPublish.Enabled = true;
            }

            bgwWaiting.Dispose();

            plHistories.Enabled = true;
            btnDeleteDcu.Enabled = true;
            cboDcu.Enabled = true;
            cboPublicMessage.Enabled = true;
            txtDcuInput.ReadOnly = false;
            panelOption.Enabled = true;
            plTimeReadOperation.Enabled = true;
            grpOption.Enabled = true;
            ucProgressBarStop.Visible = false;
        }

        private void PublishMessage(DoWorkEventArgs e)
        {
            switch (functionSelected)
            {
                case Constant.REQUEST_INTAN:
                    this.RequestIntanMessage(e);
                    break;
                case Constant.REQUEST_OPERATION:
                    this.RequestOperationMessage(e);
                    break;
                case Constant.REQUEST_LOADPROFILE:
                    this.RequestLoadProfileMessage(e);
                    break;
                case Constant.REQUEST_HISTORIES:
                    this.RequestHistoriesMessage(e);
                    break;
                case Constant.REQUEST_FIRMWARE:
                    this.RequestUpdateFirmwareMessage(e);
                    break;
                case Constant.REQUEST_DCU_SERVER_CONFIG:
                    this.RequestDcuServerConfig(e);
                    break;
                case Constant.REQUEST_RESET:
                    this.RequestResetMessage(e);
                    break;
                case Constant.REQUEST_ERASE_FLASH:
                    this.RequestEraseFlash(e);
                    break;
                case Constant.REQUEST_CONFIG_OPERATION_TIME:
                    this.RequestOperationTimeConfigMessage(e);
                    break;
                default:
                    break;
            }
        }

        private void RequestResetMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;
            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {

                    count++;
                    // First item
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    // Nếu giá trị cấu hình không được nhập ko thực hiện
                    if (item.IsValueNull())
                    {
                        MessageBox.Show("Thông số yêu cầu bản tin reset ( reset ) chưa được cấu hình. Bạn hãy kiểm tra và cấu hình lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    // If data is hex
                    if (item.IsHex)
                    {
                        int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                        // Data HEX
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                    }
                    else
                    {
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                        // Data STRING
                        playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Yêu cầu bản tin khởi động lại thiết bị - Modem: " + dcu + " - Topics: " + topic;
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }
        }

        private void RequestHistoriesMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Tháng lấy dữ liệu bản tin lịch sử
            int currentMonth = (int)(DateTime.Now.Month - dtHistoriesOfMonth.Value.Month + (DateTime.Now.Year - dtHistoriesOfMonth.Value.Year) * 12 + 1);

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;

            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {

                    count++;
                    // First item
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    // Nếu giá trị cấu hình không được nhập ko thực hiện
                    if (item.IsValueNull())
                    {
                        byte[] data = ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(currentMonth));
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(data.Length)));

                        // Data HEX
                        playLoad = ByteUltil.Combine(playLoad, data);
                    }
                    else
                    {
                        // If data is hex
                        if (item.IsHex)
                        {
                            int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                        }
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                        }
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Yêu cầu bản tin lịch sử - Modem: " + dcu + " - Topics: " + topic;
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }

        }

        private void RequestLoadProfileMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Sô phần tử Obis trong playload của bản tin operation
            int count = 0;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Lấy về list thời gian lấy bản tin loadprofile
            var dateTime = Ultilities.GetDateRange(dtFromDate.Value, dtToDate.Value);

            this.numberRequestCount = dateTime.Count() * dcuList.Count;

            string valueInput = string.Empty;

            int progressIndex = 0;
            int countTimeWait = 0;

            foreach (var currentdate in dateTime)
            {
                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // Đặt thời gian nghỉ của mỗi lần
                countTimeWait++;

                // Foreach dcu
                foreach (var dcu in dcuList)
                {
                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    // Đã xử lý được số dcu
                    progressIndex++;

                    // Create topic foreach dcu
                    topic = String.Format(topicSelected, dcu);

                    // Reset data 
                    playLoad = null;

                    // Reset lại biến đếm số obis sau mỗi bản tin
                    count = 0;

                    // Get obis data from database
                    foreach (var item in obisPlayLoad)
                    {
                        // Dừng gửi dữ liệu do người dùng
                        if (bgwWaiting.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        count++;

                        if (count == 1)
                            playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                        else
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                        if (item.ObisCode.Equals(Constant.OBIS_LOADPROFILE_DAY))
                        {
                            valueInput = ConvertUtil.IntToHex(Convert.ToInt16(currentdate.Day)) + ConvertUtil.IntToHex(Convert.ToInt16(currentdate.Month)) + ConvertUtil.IntToHex(Convert.ToInt16(currentdate.Year.ToString().Substring(2, 2)));
                        }

                        // Dữ liệu do người dùng nhập vào là số
                        if (item.IsValueNull())
                        {
                            // Nếu giá trị là định dạng số
                            if (item.IsHex)
                            {
                                int length = valueInput.Length % 2 == 0 ? valueInput.Length / 2 : valueInput.Length / 2 + 1;
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                                // Data HEX
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(valueInput));
                            }
                            // Nếu giá trị định dạng string
                            else
                            {
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(valueInput.Length)));

                                // Data STRING
                                playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(valueInput));
                            }
                        }
                        // Nếu trường giá trị trong databse tồn tại giá trị
                        else
                        {
                            // Nếu giá trị là định dạng số
                            if (item.IsHex)
                            {
                                int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                                // Data HEX
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                            }
                            // Nếu giá trị định dạng string
                            else
                            {
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                                // Data STRING
                                playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                            }

                        }

                    }

                    // Gửi đến gateway
                    if (this.PublishMessageEvent != null)
                        this.PublishMessageEvent(topic, playLoad);

                    // Log system histories
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                    UserSession.Action = SystemResource.User_Action_Send;
                    UserSession.Notes = "Yêu cầu bản tin Loadprofile - Modem: " + dcu + " - Thời gian lấy bản tin Từ: " + dtFromDate.Text + " đến: " + dtToDate.Text + " - Bản tin ngày: " + currentdate.ToString();
                    this.InsertHistories();

                    // Gửi dữ liệu sang cho progress
                    bgwWaiting.ReportProgress(progressIndex);
                }

                if (countTimeWait < dateTime.Count())
                    Thread.Sleep(UserSession.SystemConfig.NumerOfTimeConfigSendMessage);
            }
        }

        private void RequestDcuServerConfig(DoWorkEventArgs e)
        {
            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            var server1 = this.serverDataTable.Where(r => r.ServerId == int.Parse(serverID1));
            var server2 = this.serverDataTable.Where(r => r.ServerId == int.Parse(serverID2));

            byte[] playLoad = null;
            string topic = string.Empty;

            // Sô phần tử Obis
            int count = 0;

            string valueInput = string.Empty;

            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {

                    count++;
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    if (item.ObisCode.Equals(Constant.OBIS_SERVER1))
                    {
                        valueInput = server1.First().ServerIP;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_PORT1))
                    {
                        valueInput = server1.First().Port;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_USER1))
                    {
                        valueInput = server1.First().UserName;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_PASS1))
                    {
                        valueInput = server1.First().Password;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_SERVER2))
                    {
                        valueInput = server2.First().ServerIP;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_PORT2))
                    {
                        valueInput = server2.First().Port;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_USER2))
                    {
                        valueInput = server2.First().UserName;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_PASS2))
                    {
                        valueInput = server2.First().Password;
                    }

                    // Dữ liệu do người dùng nhập vào
                    if (item.IsValueNull())
                    {
                        // Nếu giá trị là định dạng số
                        if (item.IsHex)
                        {
                            int length = valueInput.Length % 2 == 0 ? valueInput.Length / 2 : valueInput.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(valueInput));
                        }
                        // Nếu giá trị định dạng string
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(valueInput.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(valueInput));
                        }
                    }
                    // Nếu trường giá trị trong databse tồn tại giá trị
                    else
                    {
                        // Nếu giá trị là định dạng số
                        if (item.IsHex)
                        {
                            int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                        }
                        // Nếu giá trị định dạng string
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                        }
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Cấu hình chuyển Server cho - Modem: " + dcu + " - Server1: " + server1.First().ServerIP + " - Server2: " + server2.First().ServerIP;
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }
        }

        private void RequestUpdateFirmwareMessage(DoWorkEventArgs e)
        {
            var firmware = this.firmwareDataTable.Where(r => r.FirmwareId == firmWareId);

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            byte[] playLoad = null;
            string topic = string.Empty;

            // Sô phần tử Obis
            int count = 0;

            string valueInput = string.Empty;

            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                countDcuIndex++;

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {
                    count++;
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    if (item.ObisCode.Equals(Constant.OBIS_FIRMWARE_PATH))
                    {
                        valueInput = Path.GetDirectoryName(firmware.First().Path) + "/";
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_FIRMWARE_FILE_NAME))
                    {
                        valueInput = Path.GetFileName(firmware.First().Path);
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_FIRMWARE_FILE_SIZE))
                    {
                        valueInput = firmware.First().FileSize.ToString();
                    }

                    // Dữ liệu do người dùng nhập vào là số
                    if (item.IsValueNull())
                    {
                        // Nếu giá trị là định dạng số
                        if (item.IsHex)
                        {
                            int length = valueInput.Length % 2 == 0 ? valueInput.Length / 2 : valueInput.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(valueInput));
                        }
                        // Nếu giá trị định dạng string
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(valueInput.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(valueInput));
                        }
                    }
                    // Nếu trường giá trị trong databse tồn tại giá trị
                    else
                    {
                        // Nếu giá trị là định dạng số
                        if (item.IsHex)
                        {
                            int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                        }
                        // Nếu giá trị định dạng string
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                        }
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Cập nhật phần mềm cho - Modem: " + dcu + " - Tên phiên bản: " + firmWareVersionText;
                this.InsertHistories();
            }
        }

        private void RequestIntanMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;
            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {
                    count++;
                    // First item
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    // Nếu giá trị cấu hình không được nhập ko thực hiện
                    if (item.IsValueNull())
                    {
                        MessageBox.Show("Thông số yêu cầu bản tin tức thời (Intan) chưa được cấu hình. Bạn hãy kiểm tra và cấu hình lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    // If data is hex
                    if (item.IsHex)
                    {
                        int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                        // Data HEX
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                    }
                    else
                    {
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                        // Data STRING
                        playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Yêu cầu bản tin Intan - Modem: " + dcu + " - Topics: " + topic;
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }
        }

        private void RequestOperationMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;
            // Sô phần tử Obis trong playload của bản tin operation
            int count = 0;
            int messageCount = 0;

            // Tính thứ tự bản tin cần lấy đầu tiên
            int firstIndex = (int)(DateTime.Now - dtToDate.Value).TotalMinutes / UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation + 1;

            // Tổng số bản tin cần lấy: Mỗi tiếng 2 bản tin
            messageCount = (int)(dtToDate.Value - dtFromDate.Value).TotalMinutes / UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation + 1;

            // Vị trí bản tin tiếp theo trong flash
            int nextMessageIndex = 0;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            int progressIndex = 0;
            // Max progress
            this.numberRequestCount = messageCount * dcuList.Count;

            // Foreach message index
            for (int i = 0; i < messageCount; i++)
            {
                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // Foreach dcu
                foreach (var dcu in dcuList)
                {
                    progressIndex++;

                    nextMessageIndex = firstIndex + i;

                    // Create topic foreach dcu
                    topic = String.Format(topicSelected, dcu);

                    // Reset data 
                    playLoad = null;

                    // Reset lại biến đếm số obis sau mỗi bản tin
                    count = 0;

                    // Get obis data from database
                    foreach (var item in obisPlayLoad)
                    {
                        // Dừng gửi dữ liệu do người dùng
                        if (bgwWaiting.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        count++;
                        if (count == 1)
                            playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                        else
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                        // Dữ liệu do người dùng nhập vào là số
                        if (item.IsValueNull())
                        {
                            byte[] data = ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(nextMessageIndex));
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(data.Length)));

                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, data);
                        }
                        // Nếu trường giá trị trong databse tồn tại giá trị
                        else
                        {
                            // Nếu giá trị là định dạng số
                            if (item.IsHex)
                            {
                                int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                                // Data HEX
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                            }
                            // Nếu giá trị định dạng string
                            else
                            {
                                // Data Length
                                playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));
                                // Data STRING
                                playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                            }
                        }
                    }

                    // Gửi đến gateway
                    if (this.PublishMessageEvent != null)
                        this.PublishMessageEvent(topic, playLoad);

                    // Gửi dữ liệu sang cho progress
                    bgwWaiting.ReportProgress(progressIndex);

                    // Log system histories
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                    UserSession.Action = SystemResource.User_Action_Send;
                    UserSession.Notes = "Yêu cầu bản tin Operation - Modem: " + dcu + "- Thời gian lấy bản tin Từ: " + dtFromDate.Text + " đến: " + dtToDate.Text + " - Bản tin số: " + i;
                    this.InsertHistories();
                    Thread.Sleep(10);
                }

                if (i + 1 < messageCount)
                    Thread.Sleep(UserSession.SystemConfig.NumerOfTimeConfigSendMessage);
            }
        }

        private void RequestOperationTimeConfigMessage(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;

            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {
                    count++;
                    // First item
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    // Nếu giá trị cấu hình không được nhập ko thực hiện
                    if (item.IsValueNull())
                    {
                        // If data is hex
                        if (item.IsHex)
                        {
                            int length = UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation % 2 == 0 ? UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation / 2 : UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation)));
                        }
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation.ToString()));
                        }
                    }
                    else
                    {
                        // If data is hex
                        if (item.IsHex)
                        {
                            int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                            // Data HEX
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                        }
                        else
                        {
                            // Data Length
                            playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                            // Data STRING
                            playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                        }
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Cấu hình thời gian đọc bản tin Operation - Modem: " + dcu + " - Thời gian đọc: " + UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation + " phút";
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }
        }

        private void RequestEraseFlash(DoWorkEventArgs e)
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;

            int countDcuIndex = 0;
            this.numberRequestCount = dcuList.Count;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
                countDcuIndex++;

                // Create topic foreach dcu
                topic = String.Format(topicSelected, dcu);

                // Reset data 
                playLoad = null;

                count = 0;

                // Get obis data from database
                foreach (var item in obisPlayLoad)
                {
                    count++;
                    // First item
                    if (count == 1)
                        playLoad = ByteUltil.Combine(ConvertUtil.HexStringToHexByteArray(item.ObisCode));
                    else
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.ObisCode));

                    // Nếu giá trị cấu hình không được nhập ko thực hiện
                    if (item.IsValueNull())
                    {
                        MessageBox.Show("Thông số yêu cầu bản tin xoá flash chưa được cấu hình. Bạn hãy kiểm tra và cấu hình lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    // If data is hex
                    if (item.IsHex)
                    {
                        int length = item.Value.Length % 2 == 0 ? item.Value.Length / 2 : item.Value.Length / 2 + 1;
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(length)));
                        // Data HEX
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(item.Value));
                    }
                    else
                    {
                        // Data Length
                        playLoad = ByteUltil.Combine(playLoad, ConvertUtil.HexStringToHexByteArray(ConvertUtil.IntToHex(item.Value.Length)));

                        // Data STRING
                        playLoad = ByteUltil.Combine(playLoad, Encoding.ASCII.GetBytes(item.Value));
                    }

                    // Dừng gửi dữ liệu do người dùng
                    if (bgwWaiting.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                // Dừng gửi dữ liệu do người dùng
                if (bgwWaiting.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuController);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Xoá flash - Modem: " + dcu + " - Topics: " + topic;
                this.InsertHistories();

                // Gửi dữ liệu sang cho progress
                bgwWaiting.ReportProgress(countDcuIndex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TopicSearch search = new TopicSearch();
            search.SearchTopicEvent += SearchTopics;
            search.ShowDialog();
        }

        private void SearchTopics(string searchValue)
        {
            if (currentSearh.Equals(string.Empty))
                currentSearh = searchValue;

            if (!currentSearh.Equals(searchValue.Trim()))
            {
                currentSearh = searchValue;
                lisIndex.Clear();
            }
            int rowIndex = -1;

            if (tabControlMain.SelectedTab == tabMessage)
            {
                dtgSubcribeTopic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in dtgSubcribeTopic.Rows)
                {
                    dtgSubcribeTopic.Rows[row.Index].Selected = false;
                }

                try
                {
                    bool hasValue = false;

                    foreach (DataGridViewRow row in dtgSubcribeTopic.Rows)
                    {
                        if (row.Cells[TopicsCol.Index].Value != null && row.Cells[TopicsCol.Index].Value.ToString().ToLower().Contains(searchValue.ToLower().Trim()))
                        {
                            hasValue = true;
                            if (lisIndex.Contains(row.Index))
                            {
                                continue;
                            }

                            lisIndex.Add(row.Index);
                            rowIndex = row.Index;
                            dtgSubcribeTopic.Rows[row.Index].Selected = true;
                            dtgSubcribeTopic.FirstDisplayedScrollingRowIndex = rowIndex;
                            dtgSubcribeTopic.Focus();

                            break;
                        }
                    }

                    if (!hasValue)
                    {
                        MessageBox.Show("Không có kết quả nào được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var queryChecked = (from r in dtgSubcribeTopic.Rows.Cast<DataGridViewRow>()
                                        where r.Selected
                                        select r
                                   );

                    if (queryChecked.Count() == 0 && lisIndex.Count > 0)
                    {
                        int index = lisIndex[0];
                        dtgSubcribeTopic.Rows[index].Selected = true;
                        dtgSubcribeTopic.FirstDisplayedScrollingRowIndex = index;
                        dtgSubcribeTopic.Focus();
                        lisIndex.Clear();
                        lisIndex.Add(index);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (tabControlMain.SelectedTab == tabError)
            {
                dtgDecuError.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in dtgDecuError.Rows)
                {
                    dtgDecuError.Rows[row.Index].Selected = false;
                }

                try
                {
                    bool hasValue = false;

                    foreach (DataGridViewRow row in dtgDecuError.Rows)
                    {
                        if (row.Cells[clDcuCode.Index].Value != null && row.Cells[clDcuCode.Index].Value.ToString().ToLower().Contains(searchValue.ToLower().Trim()))
                        {
                            hasValue = true;
                            if (lisIndex.Contains(row.Index))
                            {
                                continue;
                            }

                            lisIndex.Add(row.Index);
                            rowIndex = row.Index;
                            dtgDecuError.Rows[row.Index].Selected = true;
                            dtgDecuError.FirstDisplayedScrollingRowIndex = rowIndex;
                            dtgDecuError.Focus();

                            break;
                        }
                    }

                    if (!hasValue)
                    {
                        MessageBox.Show("Không có kết quả nào được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var queryChecked = (from r in dtgDecuError.Rows.Cast<DataGridViewRow>()
                                        where r.Selected
                                        select r
                                   );

                    if (queryChecked.Count() == 0 && lisIndex.Count > 0)
                    {
                        int index = lisIndex[0];
                        dtgDecuError.Rows[index].Selected = true;
                        dtgDecuError.FirstDisplayedScrollingRowIndex = index;
                        dtgDecuError.Focus();
                        lisIndex.Clear();
                        lisIndex.Add(index);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void dtgSubcribeTopic_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dtgDcuSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            this.AddModem(dtgDcuSearch.CurrentRow.Cells[SearchDcuCodeCol.Index].Value.ToString());
        }

        private void AddModem(string txtModem)
        {
            // Lấy về danh sách dcu người dùng nhập vào
            dcuList = txtDcuInput.Text.Trim().Split('\n').ToList();

            var count = dcuList.Where(r => r.Equals(txtModem)).Count();
            if (count > 0)
            {
                MessageBox.Show("Modem: " + txtModem + " đã có trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dcuList.Count > UserSession.SystemConfig.NumberOfModemRequestOperation)
            {
                MessageBox.Show("Số lượng modem yêu cầu lấy dự liệu không được vượt quá " + UserSession.SystemConfig.NumberOfModemRequestOperation, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDcuInput.Focus();
                return;
            }

            txtDcuInput.AppendText(txtModem + "\n");
        }

        private void dtgDcuSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void UCDcuController_Load(object sender, EventArgs e)
        {
            LoadServer();
            LoadPublicMessage();
            LoadFirmWare();
            LoadObisTable();
            LoadOperationReadingTime();
        }

        private void txtDcuInput_SizeChanged(object sender, EventArgs e)
        {
            panelSearch.Size = new Size(panelSearch.Width, this.txtDcuInput.Height);
        }

        private void mnPaste_Click(object sender, EventArgs e)
        {
            string[] dcuList = Clipboard.GetText().Split(';');
            for (int i = 0; i < dcuList.Count(); i++)
            {
                txtDcuInput.AppendText(dcuList[i] + "\n");
            }
        }

        private void dtgSubcribeTopic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            string topic = dtgSubcribeTopic.Rows[e.RowIndex].Cells[TopicsCol.Index].Value.ToString();

            ViewMessageDetail viewMessageDetail = new ViewMessageDetail(this.messageCollection, topic);
            viewMessageDetail.ShowDialog();
        }
    }
}
