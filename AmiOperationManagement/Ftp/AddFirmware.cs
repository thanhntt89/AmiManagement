using System;
using System.Windows.Forms;
using AmiOperationManagement.Main;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.FirmwareDataSetTableAdapters;
using System.IO;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using AmiOperationLib;

namespace AmiOperationManagement.Ftp
{
    public partial class AddFirmware : DevComponents.DotNetBar.Metro.MetroForm
    {
        public OperationEventHandle ReloadData;
        private UserControlBase controlBase = new UserControlBase();

        private FirmwareDataSet.FirmwareDataTable firmwareDataTable = new FirmwareDataSet.FirmwareDataTable();
        private FirmwareTableAdapter firmwareTableAdapter = new FirmwareTableAdapter();
        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();


        private UploadFile uploadFile = new UploadFile();

        public AddFirmware()
        {
            InitializeComponent();
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
                Logger.WriteLog(LogLevelL4N.ERROR, "ADDFIRMWARE - Load loại đồng hồ. Chi tiết lỗi: ", ex);
                
                MessageBox.Show("Tải dữ liệu không thành công. Chi tiết\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
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
                string path = uploadFile.UploadFirmware(txtFilePath.Text);
                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("Không tải được phiên bản phần mềm lên máy chủ. Bạn hãy kiểm tra lại thông tin kết nối đến FTP", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newRow = this.firmwareDataTable.NewFirmwareRow();

                newRow.CreatedDate = DateTime.Now;
                newRow.CreateUser = UserSession.UserName;
                newRow.MeterTypeId = short.Parse(cboMeterType.SelectedValue.ToString());
                newRow.Path = path;
                newRow.VersionFirmware = txtVersionName.Text;
                newRow.FirmwareName = txtVersionName.Text;
                newRow.Status = true;
                FileInfo fileInfo = new FileInfo(txtFilePath.Text);
                newRow.FileSize = (int)fileInfo.Length;

                this.firmwareDataTable.AddFirmwareRow(newRow);
                this.firmwareTableAdapter.Update(this.firmwareDataTable);

                if (this.ReloadData != null)
                    this.ReloadData();

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SoftwareVersion);
                UserSession.Action = SystemResource.User_Action_Add;

                UserSession.Notes = "Thêm mới phiên bản phần mềm - Loại công tơ: " + cboMeterType.Text + " - Tên phiên bản: " + txtVersionName.Text + " - Phiên bản số: " + txtVersionNumber.Text;
                this.controlBase.InsertHistories();

                MessageBox.Show("Thêm mới phiên bản phần mềm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtVersionNumber.Text = string.Empty;
                txtVersionName.Text = string.Empty;
                txtFilePath.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "ADDFIRMWARE - Lưu thông tin firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Thêm thông tin không thành công. Chi tiết\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFirmware_Load(object sender, EventArgs e)
        {
            LoadMeterType();
        }
    }
}