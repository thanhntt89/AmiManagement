using System;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using System.Linq;
using AmiOperationManagement.CustomeUserControl;
using System.Drawing;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System.Data;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationManagement.Resources;

namespace AmiOperationManagement.Deployment
{
    public partial class UCDcuManagement : UserControlBase
    {
        private DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
        DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();
        private MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btsearchDcu_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCDcuManagement()
        {
            InitializeComponent();
            //dtCreateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtCreateTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
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
            waitting.ShowDialog();
        }

        void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            DisplayData();
        }

        void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
                dtgSearchDcu.Rows.Clear();
                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.dataConcentratorUnitDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.dataConcentratorUnitDataTable.Rows.Count)
                        break;
                    var item = this.dataConcentratorUnitDataTable[index - 1];
                    try
                    {
                        int connectionStatus = -1;
                        connectionStatus = item.IsConnectionStatusNull() ? -1 : item.ConnectionStatus;

                        dtgSearchDcu.Rows.Add(
                            item.DcuId,
                            item.IsGatewayIpNull() ? string.Empty : item.GatewayIp,
                            item.IsLaunchDateNull() ? string.Empty : item.LaunchDate.ToString("dd/MM/yyyy HH:mm:ss"),
                            connectionStatus == Constant.DcuConnected ? Constant.DcuConnectedText : Constant.DcuDisconnectedText,
                            item.IsConnectionTimeNull() ? string.Empty : item.ConnectionTime.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.IsDeleted ? Constant.DeletedText : Constant.ActiveText,
                            item.IsProtocolVersionNull() ? string.Empty : item.ProtocolVersion,
                            item.IsSingalNull() ? string.Empty : item.Singal,
                            item.IsSimTemperatureNull() ? string.Empty : item.SimTemperature,
                            item.IsMcuTemperatureNull() ? string.Empty : item.McuTemperature,
                            item.IsRtcPinVotageNull() ? string.Empty : item.RtcPinVotage,
                            item.IsCellIdConnectNull() ? string.Empty : item.CellIdConnect,
                            item.IsSimNull() ? string.Empty : item.Sim,
                            item.IsSimSerialNull() ? string.Empty : item.SimSerial,
                            item.IsSvnVersionNull() ? string.Empty : item.SvnVersion,
                            null,
                            null,
                            item.Id
                            );

                        if (!item.IsConnectionStatusNull())
                            dtgSearchDcu.Rows[rowIndex].Cells[clConnectionStatus.Index].Style.ForeColor = item.ConnectionStatus == Constant.DcuConnected ? Color.Green : Color.Red;

                        dtgSearchDcu.Rows[rowIndex].Cells[clStatus.Index].Style.ForeColor = item.IsDeleted ? Color.Red : Color.Green;

                        rowIndex++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                }
            }));
        }
        
        private void btCreateDcu_Click(object sender, EventArgs e)
        {
            AddDcu addDcu = new AddDcu();
            addDcu.ShowDialog();
        }

        private void btsearchDcu_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void Search()
        {
            try
            {
                dtgSearchDcu.Rows.Clear();
                int? connectionStatus = null;
                string gatewayIp = null;
                bool? deleted = null;
                string createdDateFrom = null;
                string createdDateTo = null;

                if (cboConnectionStatus.SelectedIndex == 1)
                    connectionStatus = 1;
                else if (cboConnectionStatus.SelectedIndex == 2)
                    connectionStatus = 0;

                if (cboStatus.SelectedIndex == 1)
                    deleted = false;
                else if (cboStatus.SelectedIndex == 2)
                    deleted = true;

                if (dtCreateFrom.Value != DateTime.MinValue)
                    createdDateFrom = dtCreateFrom.Value.ToString();
                if (dtCreateTo.Value != DateTime.MinValue)
                    createdDateTo = dtCreateTo.Value.ToString();

                if (cboGateways.SelectedIndex > 0)
                    gatewayIp = cboGateways.Text;

                this.dataConcentratorUnitTableAdapter.FillByCondition(this.dataConcentratorUnitDataTable,
                    txtDcuId.Text == string.Empty ? null : txtDcuId.Text,
                    connectionStatus,
                    gatewayIp,
                    txtMobile.Text == string.Empty ? null : txtMobile.Text,
                    txtSerialSim.Text == string.Empty ? null : txtSerialSim.Text,
                    deleted,
                    createdDateFrom,
                    createdDateTo
                    );

                ucBreakPage.CreatePage(this.dataConcentratorUnitDataTable.Rows.Count);
                //if (this.dataConcentratorUnitDataTable.Rows.Count == 0)
                //{
                //    MessageBox.Show("Không tìm thấy kết quả nào thoả mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch
            {
                MessageBox.Show("Lỗi tìm thông tin modem từ cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dtgSearchDcu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == clEdit.Index)
                this.EditDataConcentratorUnit();
            else if (e.ColumnIndex == clDeleted.Index)
                this.DeletedDataConcentratorUnit();
        }

        private void DeletedDataConcentratorUnit()
        {
            DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
            string dcuCode = string.Empty;

            try
            {
                long dcuId = int.Parse(dtgSearchDcu.Rows[dtgSearchDcu.CurrentRow.Index].Cells[clId.Index].Value.ToString());
                dcuCode = dtgSearchDcu.Rows[dtgSearchDcu.CurrentRow.Index].Cells[clDcuId.Index].Value.ToString();

                MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();

                // Kiểm tra xem thiết bị có sử dụng ở bảng Measurementpoit 
                this.measurementPointInfoTableAdapter.FillByDcuId(measurementPointInfoDataTable, dcuId);
                if (measurementPointInfoDataTable.Rows.Count > 0)
                {
                    string measurementPointCode = measurementPointInfoDataTable.First().MeasurementPointCode;
                    // Nếu điểm đo không bị xoá thì không cho phép xoá dcu
                    if (!measurementPointInfoDataTable.First().IsDeleted)
                    {
                        MessageBox.Show("Không thể xoá được thiết bị này. Mã thiết bị: " + dcuCode + " đang được liên kết với điểm đo " + measurementPointCode + " đang hoạt động. ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Nếu điểm đo ở trạng thái xoá, chuyển dcu sang trạng thái xoá
                    else
                    {
                        this.dataConcentratorUnitTableAdapter.FillByDcuId(dataConcentratorUnitDataTable, dcuId);

                        // Cuyển trạng thái thiết bị sang đã xoá
                        dataConcentratorUnitDataTable.First().IsDeleted = true;
                        dataConcentratorUnitDataTable.First().EditedDate = DateTime.Now;
                        dataConcentratorUnitDataTable.First().EditedUserId = UserSession.UserName;

                        this.dataConcentratorUnitTableAdapter.Update(dataConcentratorUnitDataTable);

                        // Log người dùng
                        UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuList);
                        UserSession.Action = SystemResource.User_Action_Update;
                        UserSession.Notes = "Cập nhật trạng thái mã thiết bị: " + dcuCode + " sang Xoá";

                        this.InsertHistories();

                        MessageBox.Show("Thiết bị: " + dcuCode + " được chuyến sang trạng thái xoá. Đo điểm đo: " + measurementPointCode + " gắn với thiết bị đó ở trạng thái xoá.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        this.Search();
                        return;
                    }
                }

                var rst = MessageBox.Show("Bạn có muốn xoá thiết bị có mã: " + dcuCode, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != System.Windows.Forms.DialogResult.Yes)
                    return;

                this.dataConcentratorUnitTableAdapter.FillByDcuId(dataConcentratorUnitDataTable, dcuId);

                if (dataConcentratorUnitDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Thiết bị đã bị xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Search();
                    return;
                }

                int indexDelete = 0;
                foreach (DataConcentratorUnitDataSet.DataConcentratorUnitRow item in dataConcentratorUnitDataTable.Rows)
                {
                    dataConcentratorUnitDataTable[indexDelete].Delete();
                    indexDelete++;
                }

                this.dataConcentratorUnitTableAdapter.Update(dataConcentratorUnitDataTable);
                
                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DcuList);
                UserSession.Action = SystemResource.User_Action_Delete;
                UserSession.Notes = "Xoá thiết bị mã: " + dcuCode;

                this.InsertHistories();

                this.Search();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCDcuManagement.DeleteDCU -  lỗi xử lý this.dataConcentratorUnitTableAdapter.Update(dataConcentratorUnitDataTable) chi tiết: ", ex);
                MessageBox.Show("Không thể xoá thiết bị này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDataConcentratorUnit()
        {
            if (dtgSearchDcu.Rows.Count == 0)
                return;
            string dcuId = dtgSearchDcu.Rows[dtgSearchDcu.CurrentRow.Index].Cells[clDcuId.Index].Value.ToString();
            var item = dataConcentratorUnitDataTable.Where(r => r.DcuId.Equals(dcuId));
            this.UpdateModem(item.First());
        }

        private void UpdateModem(DataConcentratorUnitDataSet.DataConcentratorUnitRow dataConcentratorUnitRow)
        {
            UpdateDcu updateDcu = new UpdateDcu(dataConcentratorUnitRow);
            updateDcu.ShowDialog();
        }

        private void dtgSearchDcu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditDataConcentratorUnit();
        }

        private void dtgSearchDcu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btCleanDcu_Click(object sender, EventArgs e)
        {
            txtDcuId.Text = string.Empty;
            txtMobile.Text = string.Empty;
            cboStatus.SelectedIndex = 0;
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
            cboGateways.SelectedIndex = 0;
            cboConnectionStatus.SelectedIndex = 0;
            txtSerialSim.Text = string.Empty;
            dataConcentratorUnitDataTable.Clear();
            dtgSearchDcu.Rows.Clear();
            MemoryManagement.MinimizeMemory();
        }

        private void UCDcuManagement_Load(object sender, EventArgs e)
        {
            this.LoadGateway();            
        }
    }
}
