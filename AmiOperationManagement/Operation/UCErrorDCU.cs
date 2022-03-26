using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Main;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ObisTableDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCErrorDCU : UserControlBase
    {
        public event RecieveMessageEventHandle PublishMessageEvent;

        // Current text search
        private string currentSearh = string.Empty;
        // List index search
        private List<int> lisIndex = new List<int>();

        private ObisTableDataSet.ObisTableDataTable obisTableDataTable = new ObisTableDataSet.ObisTableDataTable();
        private ObisTableTableAdapter obisTableTableAdapter = new ObisTableTableAdapter();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private int commandId = -1;
        private string firmwareUpdateTopic = string.Empty;

        public UCErrorDCU()
        {
            InitializeComponent();
            LoadObisTable();
        }

        private bool LoadPublicMessage(string messageType)
        {
            try
            {
                this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.PublicMessage);

                // get commandId
                this.commandId = this.commandLineDataTable.Where(r => r.CommandCode.Equals(messageType)).First().CommandId;
                this.firmwareUpdateTopic = this.commandLineDataTable.Where(r => r.CommandCode.Equals(messageType)).First().Topic;
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu bản tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void LoadObisTable()
        {
            try
            {
                this.obisTableTableAdapter.Fill(this.obisTableDataTable);
            }
            catch
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu obis.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GetMessage(string topic, byte[] playLoad)
        {
            if (!this.IsReceiveData)
                return;
            MethodInvoker methodInvokerDelegate = delegate()
            {
                string dcuCode = topic.Split('/')[4];
                string flashFail = null;
                string firmwareVersion = null;
                string wrongPending = null;
                string otherFail = null;
                string metertype = topic.Split('/')[2];

                string statusRepair = string.Empty;
                try
                {
                    if (playLoad[1] != 0)
                        flashFail = Constant.ErorText;
                    else if (playLoad[5] != 0)
                        firmwareVersion = playLoad[5].ToString();

                    if (playLoad[2] > 0)
                        wrongPending = Constant.ErorText;

                    if (playLoad[4] > playLoad[3])
                        otherFail = Constant.ErorText;

                    // Get dcu repair
                    var query = (from r in dtgRepairModem.Rows.Cast<DataGridViewRow>()
                                 where r.Cells[clDcuCode.Index].Value.ToString().Equals(dcuCode)
                                 select r
                                     );

                    if (query.Count() > 0)
                    {
                        if (firmwareVersion.Equals(Constant.ErorText))
                            statusRepair = Constant.FirmwareErrorText;
                        if (flashFail.Equals(Constant.ErorText))
                            statusRepair = string.Concat(statusRepair, Constant.FlashErorText);
                        if (wrongPending.Equals(Constant.ErorText))
                            statusRepair = string.Concat(statusRepair, Constant.PendingErorText);
                        if (otherFail.Equals(Constant.ErorText))
                            statusRepair = string.Concat(statusRepair, Constant.CompareByteErorText);
                        else if (string.IsNullOrEmpty(flashFail) && string.IsNullOrEmpty(wrongPending) && string.IsNullOrEmpty(otherFail))
                            statusRepair = Constant.OkText;
                        this.UpdateStatusRepair(statusRepair, query.First().Index);
                        return;
                    }

                    // get dcu
                    var querydcu = (from r in dtGridFailDcu.Rows.Cast<DataGridViewRow>()
                                 where r.Cells[clDcuCode.Index].Value.ToString().Equals(dcuCode)
                                 select r
                                    );

                    // Neu dcu da len roi thi bo qua không cho add vào nữa
                    if (querydcu.Count() > 0)
                        return;                                       

                    if ((flashFail != null) || (firmwareVersion != null) || (wrongPending != null) || (otherFail != null))
                    {
                        dtGridFailDcu.Rows.Add(dcuCode, firmwareVersion, metertype, flashFail, wrongPending, otherFail);
                    }

                    lblTotal.Text = this.dtGridFailDcu.Rows.Count.ToString();
                }
                catch { }

            };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void UpdateStatusRepair(string statusRepair, int i)
        {
            dtgRepairModem.Rows[i].Cells[clStatus.Index].Value = statusRepair;
            dtgRepairModem.Rows[i].Cells[clEndtime.Index].Value = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void btnSearchModem_Click(object sender, EventArgs e)
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

            dtGridFailDcu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dtGridFailDcu.Rows)
            {
                dtGridFailDcu.Rows[row.Index].Selected = false;
            }
            try
            {
                bool hasValue = false;

                foreach (DataGridViewRow row in dtGridFailDcu.Rows)
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
                        dtGridFailDcu.Rows[row.Index].Selected = true;
                        dtGridFailDcu.FirstDisplayedScrollingRowIndex = rowIndex;
                        dtGridFailDcu.Focus();
                        break;
                    }
                }
                int count = 0;
                foreach (DataGridViewRow row in dtGridFailDcu.Rows)
                {
                    if (row.Selected)
                    {
                        count++;
                        break;
                    }
                }
                if (!hasValue)
                {
                    MessageBox.Show("Không có kết quả nào được tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (count == 0 && lisIndex.Count > 0)
                {
                    int index = lisIndex[0];
                    dtGridFailDcu.Rows[index].Selected = true;
                    dtGridFailDcu.FirstDisplayedScrollingRowIndex = index;
                    dtGridFailDcu.Focus();
                    lisIndex.Clear();
                    lisIndex.Add(index);
                }

            }
            catch (Exception exc)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorDCU - SearchTopics Lỗi tìm kiếm", exc);

                MessageBox.Show(exc.Message);
            }
        }

        private void dtGridFailDcu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btClean_Click(object sender, EventArgs e)
        {
            dtGridFailDcu.Rows.Clear();
            lblTotal.Text = this.dtGridFailDcu.Rows.Count.ToString();
        }

        private void btnDeleteModem_Click(object sender, EventArgs e)
        {
            dtgRepairModem.Rows.Clear();
        }

        private void dtGridFailDcu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UserAction(e);
        }

        private void UserAction(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            string modem = dtGridFailDcu.Rows[e.RowIndex].Cells[clDcuCode.Index].Value.ToString();
            string actionName = string.Empty;
            string errorName = string.Empty;

            if ((dtGridFailDcu.Rows[e.RowIndex].Cells[clFirmwareVersion.Index].Value as string) == "Lỗi")
                errorName = "Lỗi Firmware,";
            if ((dtGridFailDcu.Rows[e.RowIndex].Cells[clFlashFail.Index].Value as string) == "Lỗi")
                errorName = string.Concat(errorName, " Lỗi Flash,");
            if ((dtGridFailDcu.Rows[e.RowIndex].Cells[clPenddingFail.Index].Value as string) == "Lỗi")
                errorName = string.Concat(errorName, " Lỗi Pendding,");
            if ((dtGridFailDcu.Rows[e.RowIndex].Cells[clCompareByteFail.Index].Value as string) == "Lỗi")
                errorName = string.Concat(errorName, " Lỗi so byte,");

            // Cột cập nhật firmware
            if (e.ColumnIndex == clUpdateFirmware.Index)
            {
                Firmware firmware = new Firmware(modem);
                firmware.ShowDialog();
                if (firmware.isOK)
                    actionName = Constant.ACTION_UPDATE_FIRMWARE;
            }
            // Cột xoá flash
            else if (e.ColumnIndex == clEraseFlash.Index)
            {
                var rst = MessageBox.Show("Bạn muốn xoá dữ liệu lưu trữ trong modem: " + modem + " này đúng không?\nChú ý: Việc xoá dữ liệu sẽ làm mất tất cả thông tin modem đã lưu trữ và không thể khôi phục lại được.\nChọn Yes để xoá - No để huỷ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rst != DialogResult.Yes)
                    return;
                RequestMessageType(modem, Constant.REQUEST_ERASE_FLASH);
                actionName = Constant.ACTION_ERASE_FLASH;

            }
            // Cột reset modem
            else if (e.ColumnIndex == clReset.Index)
            {
                var rst = MessageBox.Show("Bạn muốn khởi động lại modem: " + modem + " này đúng không?\nChú ý: Để tránh mất bản tin hoạt động (Operation), việc khởi động lại modem nên tránh vào thời điểm modem đang đọc bản tin này.\nChọn Yes để tiếp tục - No để huỷ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rst != DialogResult.Yes)
                    return;
                actionName = Constant.ACTION_RESET;
                RequestMessageType(modem, Constant.REQUEST_RESET);
            }

            this.AddAction(modem, actionName, errorName);
        }

        private void RequestMessageType(string modem, string messageType)
        {
            if (!this.LoadPublicMessage(messageType))
                return;

            byte[] playLoad = null;
            string topic = string.Empty;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            // Sô phần tử Obis
            int count = 0;

            // Create topic foreach dcu
            topic = String.Format(this.firmwareUpdateTopic, modem);

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
            }

            if (this.PublishMessageEvent != null)
                this.PublishMessageEvent(topic, playLoad);
        }

        private void AddAction(string modemCode, string actionName, string errorName)
        {
            if (string.IsNullOrEmpty(actionName))
                return;

            for (int i = 0; i < dtgRepairModem.Rows.Count; i++)
            {
                if (dtgRepairModem.Rows[i].Cells[ActionModemCodeCol.Index].Value.ToString().Equals(modemCode) && dtgRepairModem.Rows[i].Cells[ActionCol.Index].Value.ToString().Equals(actionName))
                {
                    if (dtgRepairModem.Rows[i].Cells[clEndtime.Index].Value == null)
                        dtgRepairModem.Rows[i].Cells[ActionStartTimeCol.Index].Value = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    return;
                }
            }

            dtgRepairModem.Rows.Add(modemCode, errorName, actionName, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), null, null);
        }
    }
}
