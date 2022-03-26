using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ObisTableDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using System.Linq;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using System.Text;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using System.Collections.Generic;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCMeasurementPointLostMessage : UserControlBase
    {
        public event RecieveMessageEventHandle PublishMessageEvent;

        private ObisTableDataSet.ObisTableDataTable obisTableDataTable = new ObisTableDataSet.ObisTableDataTable();
        private ObisTableTableAdapter obisTableTableAdapter = new ObisTableTableAdapter();
        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

        private MeasurementPointDataSet.MeasurementPointLostMessageDataTable measurementPointLostMessageDataTable = new MeasurementPointDataSet.MeasurementPointLostMessageDataTable();
        private MeasurementPointLostMessageTableAdapter measurementPointLostMessageTableAdapter = new MeasurementPointLostMessageTableAdapter();

        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private BackgroundWorker bgwSendRequest;
        private List<string> dcuList = new List<string>();
        private int firstMessageIndex = 0;
        private int currentMonth = 1;

        private BackgroundWorker bgwSearch;
        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        // Idtopic do người dùng chọn
        private int commandId = -1;

        // Topic do người dùng chọn
        private string topicSelected = string.Empty;

        private string dcuId = null;
        private string status = null;
        private string gatewayIp = null;
        private string contractId = null;
        private DateTime hisTime;

        private int messageTypeIndex = -1;

        private string mpGroupId = null;
        private string orgId = null;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btSearchListDcuLost_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCMeasurementPointLostMessage()
        {
            InitializeComponent();
            dtLostDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
            ucEvnTreeView.EvnTreeViewNodeSeletedEvent += ucEvnTreeView_EvnTreeViewNodeSeletedEvent;
        }

        private void ucEvnTreeView_EvnTreeViewNodeSeletedEvent(NodeCustom nodeSelected)
        {
            lblMpGroup.Text = nodeSelected.Text;
            mpGroupId = null;          
            orgId = null;

            if (nodeSelected.NodeType.Equals(Constant.NodeTypeOrg))
            {
                orgId = nodeSelected.NodeId.ToString();
            }
            else if (nodeSelected.NodeType.Equals(Constant.NodeTypeMpGroup))
            {
                mpGroupId = nodeSelected.NodeId.ToString();
            }
        }

        private void LoadObisTable()
        {
            try
            {
                this.obisTableTableAdapter.Fill(this.obisTableDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointLostMessage.LoadObisTable - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu obis.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPublicMessage()
        {
            try
            {
                this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.PublicMessage);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointLostMessage.LoadPublicMessage - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ucBreakPage_NextPageEvent(int pageNume, int numRow)
        {
            this.pageNume = pageNume;
            this.numRow = numRow;
            if (bgwWaiting == null)
            {
                bgwWaiting = new BackgroundWorker();
                bgwWaiting.RunWorkerCompleted += bgwWaiting_RunWorkerCompleted;
                bgwWaiting.DoWork += bgwWaiting_DoWork;
            }
            bgwWaiting.RunWorkerAsync();

            if (waitting == null)
                waitting = new Waitting();
            if (!waitting.Visible)
                waitting.ShowDialog();
        }

        private void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            this.DisplayData();
        }

        private void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwWaiting.Dispose();
            bgwWaiting = null;
            waitting.CloseWaiting();
            waitting.Dispose();
            waitting = null;
        }

        private void DisplayData()
        {
            Invoke(new Action(() =>
            {
                dtgLostMessage.Rows.Clear();

                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.measurementPointLostMessageDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.measurementPointLostMessageDataTable.Rows.Count)
                        break;
                    var item = this.measurementPointLostMessageDataTable[index - 1];
                    try
                    {
                        int status = 0;
                        if (!item.IsConnectionStatusNull())
                            status = item.ConnectionStatus;

                        dtgLostMessage.Rows.Add(
                            false,
                            item.IsContractNameNull() ? string.Empty : item.ContractName,
                            item.IsMeasurementPointGroupNull() ? string.Empty : item.MeasurementPointGroup,
                            item.IsDcuIdNull() ? string.Empty : item.DcuId,
                            item.MeasurementPointName,
                            status == 1 ? itemConnected.Text : itemDisconnect.Text,
                            item.IsGatewayIpNull() ? string.Empty : item.GatewayIp
                            );

                        dtgLostMessage.Rows[rowIndex].Cells[clStatusConnection.Index].Style.ForeColor = status == 1 ? Color.Green : Color.Red;

                        rowIndex++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                }
            }));
        }

        private void LoadContract()
        {
            try
            {
                contractTableAdapter.Fill(contractDataTable);

                var newRows = contractDataTable.NewContractRow();
                newRows.Id = -1;
                newRows.Note = Constant.SELECT_ALL_TEXT;
                newRows.ContractId = "1";

                contractDataTable.Rows.InsertAt(newRows, 0);

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadContract - Tải dữ liệu cho LoadContract không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin hợp đồng của điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboContract.DataSource = this.contractDataTable;
            cboContract.DisplayMember = this.contractDataTable.NoteColumn.ColumnName;
            cboContract.ValueMember = this.contractDataTable.IdColumn.ColumnName;
        }

        /// <summary>
        /// Tải thông tin máy chủ
        /// </summary>
        private void LoadGateway()
        {
            ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
            ServerTableAdapter serverTableAdapter = new ServerTableAdapter();

            try
            {
                serverTableAdapter.Fill(serverDataTable);

                cboGateways.Items.Add(Constant.SELECT_ALL_TEXT);

                foreach (ServerDataSet.ServerRow item in serverDataTable.Rows)
                {
                    if (!cboGateways.Items.Contains(item.ServerIP))
                        cboGateways.Items.Add(item.ServerIP);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCDcuManagement.LoadGateway - Tải dữ liệu cho combox gateway không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Tải thông tin máy chủ không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearchListDcuLost_Click(object sender, System.EventArgs e)
        {
            this.Search();
        }

        private void Search()
        {
            chkCheckAll.Checked = false;

            dtgLostMessage.Rows.Clear();

            status = null;
            contractId = null;
            dcuId = null;
            gatewayIp = null;

            if (cboContract.SelectedIndex > 0)
                contractId = cboContract.SelectedValue.ToString();

            if (!string.IsNullOrWhiteSpace(txtDcuCode.Text))
                dcuId = txtDcuCode.Text;

            if (cboGateways.SelectedIndex > 0)
                gatewayIp = cboGateways.Text;

            if (cbConnectionStatus.SelectedItem == itemConnected)
                status = "1";
            else if (cbConnectionStatus.SelectedItem == itemDisconnect)
            {
                status = "0";
            }

            hisTime = new DateTime(dtLostDate.Value.Year, dtLostDate.Value.Month, dtLostDate.Value.Day, 0, 0, 0);

            messageTypeIndex = cboMessageType.SelectedIndex;

            if (cboMessageType.SelectedItem == itemHistorical)
            {
                if (dtLostDate.Value.Day != 1)
                {
                    MessageBox.Show("Bản tin lịch sử thời gian là ngày đầu tiên của tháng. Bạn hãy chọn lại ngày cho chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtLostDate.Focus();
                    return;
                }
            }

            if (bgwSearch == null)
            {
                bgwSearch = new BackgroundWorker();
                bgwSearch.RunWorkerCompleted += bgwSearch_RunWorkerCompleted;
                bgwSearch.DoWork += bgwSearch_DoWork;
            }

            bgwSearch.RunWorkerAsync();
            if (waitting == null)
                waitting = new Waitting();
            waitting.ShowDialog();
        }

        private void bgwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Searching();
        }

        private void bgwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwSearch.Dispose();
            bgwSearch = null;
            waitting.CloseWaiting();
        }

        private void Searching()
        {
            if (messageTypeIndex == 0)
            {
                this.LoadOprationMessage();
            }
            else if (messageTypeIndex == 1)
            {
                this.LoadHistoricalMessage();
            }
        }

        private void LoadOprationMessage()
        {
            try
            {
                this.measurementPointLostMessageTableAdapter.GetOperationMessageLostByServerTime(
                    this.measurementPointLostMessageDataTable,
                    dcuId,
                    gatewayIp,
                    status,
                    contractId,
                    dtLostDate.Value,                  
                    orgId,
                    mpGroupId
                    );
                Invoke(new Action(() =>
                {
                    ucBreakPage.CreatePage(this.measurementPointLostMessageDataTable.Rows.Count);
                }));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.Searching - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tìm kiếm thông tin. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHistoricalMessage()
        {
            try
            {
                this.measurementPointLostMessageTableAdapter.GetHistoricalMessageLostByServerTime(
                    this.measurementPointLostMessageDataTable,
                    dcuId,
                    gatewayIp,
                    status,
                    contractId,
                    hisTime,                   
                    orgId,
                    mpGroupId
                    );
                Invoke(new Action(() =>
                {
                    ucBreakPage.CreatePage(this.measurementPointLostMessageDataTable.Rows.Count);
                }));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.Searching - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tìm kiếm thông tin. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheckAll.CheckState == CheckState.Indeterminate)
                return;
            if (chkCheckAll.CheckState == CheckState.Checked)
                for (int i = 0; i < dtgLostMessage.Rows.Count; i++)
                {
                    dtgLostMessage.Rows[i].Cells[clCheckBox.Index].Value = true;
                }
            else
            {
                for (int i = 0; i < dtgLostMessage.Rows.Count; i++)
                {
                    dtgLostMessage.Rows[i].Cells[clCheckBox.Index].Value = false;
                }
            }
        }

        private void btSendRequest_Click(object sender, EventArgs e)
        {
            if (dtgLostMessage.Rows.Count == 0)
                return;

            // Get GetwaysIP
            var query = (from r in dtgLostMessage.Rows.Cast<DataGridViewRow>()
                         where (bool)r.Cells[clCheckBox.Index].Value == true
                         select r.Cells[clGatewayIp.Index].Value.ToString()
                             ).Distinct();

            if (query.Count() == 0)
            {
                MessageBox.Show("Bạn chưa chọn điểm đo nào để xử lý", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in query)
            {
                if (!UserSession.GatewayList.GetewayConnectionStatus(item))
                {
                    MessageBox.Show("Gateway: " + item + " chưa kết nối. Bạn hãy kết nối trước khi thực hiện thao tác này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Lấy danh sách dcu request
            dcuList = (from r in dtgLostMessage.Rows.Cast<DataGridViewRow>()
                       where (bool)r.Cells[clCheckBox.Index].Value == true
                       select r.Cells[clDcuId.Index].Value.ToString()
                             ).Distinct().ToList();

            // Kiểm tra nếu có modem chưa kết nối không cho gửi lệnh
            var checkConnected = (from r in dtgLostMessage.Rows.Cast<DataGridViewRow>()
                                  where (bool)r.Cells[clCheckBox.Index].Value == true
                                  select r.Cells[clStatusConnection.Index].Value.ToString()
                             ).Distinct().ToList();
            if (checkConnected.Contains(itemDisconnect.Text))
            {
                MessageBox.Show("Không gửi được lệnh. Có điểm đo ở trạng thái Không kết nối. Bạn hãy chọn những điểm đo ở trạng thái Kết nối để thực hiện lệnh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Tính thứ tự bản tin cần lấy đầu tiên
            firstMessageIndex = (int)(DateTime.Now - dtLostDate.Value).TotalMinutes / UserSession.SystemConfig.NumerOfTimeConfigDcuReadOperation + 1;

            // Tháng lấy dữ liệu bản tin lịch sử
            currentMonth = (int)(DateTime.Now.Month - dtLostDate.Value.Month + (DateTime.Now.Year - dtLostDate.Value.Year) * 12 + 1);

            prgSend.Visible = true;
            prgSend.Value = 0;
            prgSend.Maximum = dcuList.Count;

            if (bgwSendRequest == null)
            {
                bgwSendRequest = new BackgroundWorker();
                bgwSendRequest.RunWorkerCompleted += bgwSendRequest_RunWorkerCompleted;
                bgwSendRequest.DoWork += bgwSendRequest_DoWork;
            }

            bgwSendRequest.RunWorkerAsync();
        }

        void bgwSendRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            if (messageTypeIndex == 0)
            {
                this.RequestOperationMessage();
            }
            else if (messageTypeIndex == 1)
            {
                this.RequestHistoriesMessage();
            }
        }

        void bgwSendRequest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwSendRequest.Dispose();
            bgwSendRequest = null;
            prgSend.Visible = false;
            MessageBox.Show("Gửi cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RequestOperationMessage()
        {
            byte[] playLoad = null;
            string topic = string.Empty;
            // Sô phần tử Obis trong playload của bản tin operation
            int count = 0;

            // Tổng số bản tin cần lấy: Mỗi tiếng 2 bản tin
            int numberOfMessage = 1;

            // Vị trí bản tin tiếp theo trong flash
            int nextMessageIndex = 0;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            int countTimeWait = 0;

            // Foreach message index
            for (int i = 0; i < numberOfMessage; i++)
            {
                countTimeWait++;

                // Foreach dcu
                foreach (var dcu in dcuList)
                {
                    nextMessageIndex = firstMessageIndex + i;

                    // Create topic foreach dcu
                    topic = String.Format(topicSelected, dcu);

                    // Reset data 
                    playLoad = null;

                    // Reset lại biến đếm số obis sau mỗi bản tin
                    count = 0;

                    // Get obis data from database
                    foreach (var item in obisPlayLoad)
                    {
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

                    // Log system histories
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeasurementPoitMessageError);
                    UserSession.Action = SystemResource.User_Action_Send;
                    UserSession.Notes = "Yêu cầu bản tin Operation - Modem: " + dcu + "- Thời điểm lấy: " + dtLostDate.Text;
                    this.InsertHistories();

                    Invoke(new Action(() =>
                    {
                        prgSend.Value = count;
                    }));
                }

                if (countTimeWait < numberOfMessage)
                    Thread.Sleep(UserSession.SystemConfig.NumerOfTimeConfigSendMessage);
            }
        }

        private void RequestHistoriesMessage()
        {
            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;

            // Foreach dcu
            foreach (var dcu in dcuList)
            {
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
                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeasurementPoitMessageError);
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Yêu cầu bản tin HISTORICAL - Modem: " + dcu + " - Topics: " + topic;
                this.InsertHistories();
            }

        }

        private void dtgLostMessage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dtgLostMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != clCheckBox.Index)
                return;

            if ((bool)dtgLostMessage.Rows[dtgLostMessage.CurrentRow.Index].Cells[clCheckBox.Index].Value == true)
            {
                dtgLostMessage.Rows[dtgLostMessage.CurrentRow.Index].Cells[clCheckBox.Index].Value = false;
                this.Check(false);
            }
            else
            {
                dtgLostMessage.Rows[dtgLostMessage.CurrentRow.Index].Cells[clCheckBox.Index].Value = true;
                this.Check(true);
            }
        }

        private void Check(bool isChecked)
        {
            if (!isChecked)
            {
                chkCheckAll.CheckState = CheckState.Indeterminate;
                return;
            }
            int countChecked = 0;
            for (int i = 0; i < dtgLostMessage.Rows.Count; i++)
            {
                if ((bool)dtgLostMessage.Rows[i].Cells[clCheckBox.Index].Value)
                    countChecked++;
            }

            if (countChecked == dtgLostMessage.Rows.Count)
                chkCheckAll.CheckState = CheckState.Checked;
            else
                chkCheckAll.CheckState = CheckState.Indeterminate;
        }

        private void UCGetLostMessage_Load(object sender, EventArgs e)
        {
            //this.LoadObisTable();
            //this.LoadPublicMessage();
            this.LoadContract();
            this.LoadGateway();
            cboMessageType.SelectedIndex = 0;
            // this.Search();
        }

        private void cboMessageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMessageType.SelectedItem == itemOperation)
            {
                dtLostDate.CustomFormat = "dd/MM/yyyy HH:mm";
                dtLostDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
                // Bản tin operation
                var query = this.commandLineDataTable.Where(r => r.CommandCode.Equals(Constant.REQUEST_OPERATION));
                if (query.Count() > 0)
                {
                    this.commandId = query.First().CommandId;
                    this.topicSelected = query.First().Topic;
                }
            }
            else if (cboMessageType.SelectedItem == itemHistorical)
            {
                dtLostDate.CustomFormat = "dd/MM/yyyy";
                dtLostDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                // Bản tin lịch sử
                var query = this.commandLineDataTable.Where(r => r.CommandCode.Equals(Constant.REQUEST_HISTORIES));
                if (query.Count() > 0)
                {
                    this.commandId = query.First().CommandId;
                    this.topicSelected = query.First().Topic;
                }
            }
        }

        private void mnCopyDcu_Click(object sender, EventArgs e)
        {
            // Lấy danh sách dcu request
            dcuList = (from r in dtgLostMessage.Rows.Cast<DataGridViewRow>()
                       where (bool)r.Cells[clCheckBox.Index].Value == true
                       select r.Cells[clDcuId.Index].Value.ToString()
                             ).Distinct().ToList();
            if (dcuList.Count > 0)
                Clipboard.SetText(String.Join(";", dcuList.ToArray()), TextDataFormat.Text);
        }

        private void CheckSelectedRow()
        {
            var queryRowSeleted = (from r in dtgLostMessage.Rows.Cast<DataGridViewRow>()
                                   where r.Selected
                                   select r
                                     );
            if (queryRowSeleted.Count() > 0)
                MessageBox.Show(queryRowSeleted.Count().ToString());

        }

        private void dtgLostMessage_MouseCaptureChanged(object sender, EventArgs e)
        {
            //CheckSelectedRow();
        }

    }
}
