using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.FirmwareDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ObisTableDataSetTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AmiOperationManagement.Main
{
    public partial class Firmware : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        public event RecieveMessageEventHandle PublishMessageEvent;

        private FirmwareDataSet.FirmwareDataTable firmwareDataTable = new FirmwareDataSet.FirmwareDataTable();
        private FirmwareTableAdapter firmwareTableAdapter = new FirmwareTableAdapter();

        private ObisTableDataSet.ObisTableDataTable obisTableDataTable = new ObisTableDataSet.ObisTableDataTable();
        private ObisTableTableAdapter obisTableTableAdapter = new ObisTableTableAdapter();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private int commandId = -1;
        private string firmwareUpdateTopic = string.Empty;

        public bool isOK = false;

        public Firmware(string modemCode)
        {
            InitializeComponent();
            LoadObisTable();
            LoadPublicMessage();
            LoadFirmWare();
            this.lblModemCode.Text = modemCode;
        }

        private void LoadPublicMessage()
        {
            try
            {
                this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.PublicMessage);

                // get commandId
                this.commandId = this.commandLineDataTable.Where(r => r.CommandCode.Equals(Constant.REQUEST_FIRMWARE)).First().CommandId;
                this.firmwareUpdateTopic = this.commandLineDataTable.Where(r => r.CommandCode.Equals(Constant.REQUEST_FIRMWARE)).First().Topic;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load bảng Commandline. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu bản tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load bảng OBISTABLE. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu obis.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFirmWare()
        {
            try
            {
                this.firmwareTableAdapter.Fill(this.firmwareDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load bảng Firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu phần mềm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cboFirwareVersion.DataSource = this.firmwareDataTable;
            cboFirwareVersion.DisplayMember = this.firmwareDataTable.FirmwareNameColumn.ToString();
            cboFirwareVersion.ValueMember = this.firmwareDataTable.FirmwareIdColumn.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.isOK = false;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateFirmware();
        }

        private void UpdateFirmware()
        {
            if (cboFirwareVersion.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn phiên bản phần mềm để cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var firmware = this.firmwareDataTable.Where(r => r.FirmwareId == int.Parse(cboFirwareVersion.SelectedValue.ToString()));
            if (firmware.Count() < 1)
            {
                MessageBox.Show("Không tìm thấy phiên bản phần mềm nào.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (firmware.First().IsPathNull())
            {
                MessageBox.Show("Không tìm thấy đường dẫn thư mục trong cơ sở dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rst = MessageBox.Show("Bạn đang cập nhật phiên bản phần mềm: " + cboFirwareVersion.Text + " cho modem: " + lblModemCode.Text + " \nChú ý: Nếu cập nhật sai phiên bản phần mềm, modem sẽ không đọc được dữ liệu. Chọn YES để tiếp tục  - NO để huỷ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rst == DialogResult.No)
                return;

            // Lấy về đường dẫn firmware
            string path = firmware.First().Path;

            // Get playload format
            var obisPlayLoad = this.obisTableDataTable.Where(r => r.CommandId == commandId).ToList();

            byte[] playLoad = null;
            string topic = string.Empty;

            // Sô phần tử Obis
            int count = 0;

            string valueInput = string.Empty;

            // Create topic foreach dcu
            topic = String.Format(this.firmwareUpdateTopic, lblModemCode.Text);

            // Reset data 
            playLoad = null;

            count = 0;
            try
            {
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
                        valueInput = path;
                    }
                    else if (item.ObisCode.Equals(Constant.OBIS_FIRMWARE_FILE_NAME))
                    {
                        valueInput = firmware.First().FirmwareName;
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

                }

                if (this.PublishMessageEvent != null)
                    this.PublishMessageEvent(topic, playLoad);

                // Log system histories                  
                UserSession.Action = SystemResource.User_Action_Send;
                UserSession.Notes = "Cập nhật firmware: " + cboFirwareVersion.Text + " cho modem: " + lblModemCode.Text;
                this.controlBase.InsertHistories();

                this.isOK = true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi gửi bản tin PUBLISH FIRMWARE. Chi tiết lỗi: ", ex);
                MessageBox.Show("Không thể gửi lệnh cập nhật phần mềm cho modem. Chi tiết lỗi:\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}