using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.FirmwareDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using System;
using System.Windows.Forms;
using System.Linq;
using AmiOperationLib;
using System.IO;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;

namespace AmiOperationManagement.Ftp
{
    public partial class UpdateFirmware : DevComponents.DotNetBar.Metro.MetroForm
    {
        public OperationEventHandle ReloadData;
        private UserControlBase controlBase = new UserControlBase();
        private FirmwareTableAdapter firmwareTableAdapter = new FirmwareTableAdapter();
        private FirmwareDataSet.FirmwareDataTable firmwareDataTable = new FirmwareDataSet.FirmwareDataTable();

        private FirmwareDataSet.GetFirmwareDataTable getFirmwareDataTable = new FirmwareDataSet.GetFirmwareDataTable();
        private GetFirmwareTableAdapter getFirmwareTableAdapter = new GetFirmwareTableAdapter();

        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        private int firmwareId = -1;
        private UploadFile uploadFile = new UploadFile();

        public UpdateFirmware(int firmwareId)
        {
            InitializeComponent();
            this.firmwareId = firmwareId;
        }

        private void LoadFirwareInfo()
        {
            LoadMeterType();

            try
            {
                this.firmwareTableAdapter.FillByFirmwareId(this.firmwareDataTable, firmwareId);

                cboMeterType.SelectedValue = this.firmwareDataTable.First().MeterTypeId;
                txtVersionName.Text = this.firmwareDataTable.First().FirmwareName;
                txtVersionNumber.Text = this.firmwareDataTable.First().VersionFirmware;
                chkUsed.Checked = this.firmwareDataTable.First().Status;
                txtFilePath.Text = this.firmwareDataTable.First().IsPathNull() ? string.Empty : Constant.SERVER_PATH_TEXT;

                UserSession.Notes = "Thông tin phiên bản cũ - Loại công tơ: " + cboMeterType.Text + " - Tên phiên bản: " + txtVersionName.Text + " - Phiên bản số: " + txtVersionNumber.Text;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateFirmware - Load thông tin Cập nhật firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Tải dữ liệu không thành công. Chi tiết\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMeterType()
        {
            try
            {
                this.meterTypeTableAdapter.Fill(this.meterTypeDataTable);

                cboMeterType.DataSource = this.meterTypeDataTable;
                cboMeterType.DisplayMember = this.meterTypeDataTable.NoteColumn.ToString();
                cboMeterType.ValueMember = this.meterTypeDataTable.MeterTypeIdColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateFirmware - Load LoadMeterType thông tin loại đồng hồ. Chi tiết lỗi: ", ex);
                MessageBox.Show("Tải dữ liệu không thành công. Chi tiết\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInfo()
        {
            if (cboMeterType.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại đồng hồ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMeterType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVersionName.Text))
            {
                MessageBox.Show("Tên phiên bản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVersionName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVersionNumber.Text))
            {
                MessageBox.Show("Số phiên bản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVersionNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Bạn chưa chọn tệp tin để tải lên máy chủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPath.Focus();
                return;
            }

            try
            {
                string path = string.Empty;

                if (!txtFilePath.Text.Equals(Constant.SERVER_PATH_TEXT))
                {
                    path = uploadFile.UploadFirmware(txtFilePath.Text);

                    if (string.IsNullOrEmpty(path))
                    {
                        MessageBox.Show("Thêm mới không thành công do không tải được phiên bản phần mềm lên máy chủ. Bạn hãy kiểm tra lại thông tin kết nối đến FTP", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                this.firmwareDataTable.First().CreatedDate = DateTime.Now;
                this.firmwareDataTable.First().CreateUser = UserSession.UserName;
                this.firmwareDataTable.First().MeterTypeId = short.Parse(cboMeterType.SelectedValue.ToString());
                if (!string.IsNullOrEmpty(path))
                {
                    this.firmwareDataTable.First().Path = path;
                    FileInfo fileInfo = new FileInfo(txtFilePath.Text);
                    this.firmwareDataTable.First().FileSize = (int)fileInfo.Length;
                }

                this.firmwareDataTable.First().VersionFirmware = txtVersionNumber.Text;
                this.firmwareDataTable.First().FirmwareName = txtVersionName.Text;
                this.firmwareDataTable.First().Status = chkUsed.Checked;

                this.firmwareTableAdapter.Update(this.firmwareDataTable);

                if (this.ReloadData != null)
                    this.ReloadData();

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SoftwareVersion);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = UserSession.Notes + " - Phiên bản phần mềm mới - Loại công tơ: " + cboMeterType.Text + " - Tên phiên bản: " + txtVersionName.Text + " - Phiên bản số: " + txtVersionNumber.Text;
                this.controlBase.InsertHistories();

                MessageBox.Show("Cập nhật phiên bản phần mềm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateFirmware - Cập nhật firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Cập nhật thông tin không thành công. Chi tiết\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdaeFirmware_Load(object sender, EventArgs e)
        {
            LoadFirwareInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp tin phiên bản phần mềm đúng định dạng";
            open.Filter = "Tệp tin Bin|*.bin";
            var rst = open.ShowDialog();
            if (rst == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePath.Text = open.FileName;
            }
        }
    }
}
