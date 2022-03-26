using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.FirmwareDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace AmiOperationManagement.Ftp
{
    public partial class UCSystemFirmware : UserControlBase
    {
        private FirmwareTableAdapter firmwareTableAdapter = new FirmwareTableAdapter();

        private FirmwareDataSet.GetFirmwareDataTable getFirmwareDataTable = new FirmwareDataSet.GetFirmwareDataTable();
        private GetFirmwareTableAdapter getFirmwareTableAdapter = new GetFirmwareTableAdapter();

        public UCSystemFirmware()
        {
            InitializeComponent();
        }

        public void LoadFirmware()
        {
            dtgSoftwareVersion.Rows.Clear();

            try
            {
                this.getFirmwareTableAdapter.Fill(getFirmwareDataTable);

                foreach (FirmwareDataSet.GetFirmwareRow item in this.getFirmwareDataTable.Rows)
                {
                    dtgSoftwareVersion.Rows.Add(item.FirmwareId, item.MeterTypeName, item.FirmwareName, item.VersionFirmware, item.IsCreatedDateNull() ? string.Empty : item.CreatedDate.ToString("ddMM-yyyy HH:mm:ss"), item.Status, null, null, item.Path);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCSystemFirmware - Load danh sách firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công. Chi tiết lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, System.EventArgs e)
        {
            AddFirmware addFirmware = new AddFirmware();
            addFirmware.ReloadData += LoadFirmware;
            addFirmware.ShowDialog();
        }

        private void dtgSoftwareVersion_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == DeletedCol.Index)
            {
                DeleteFirmware(e);
            }
            else if (e.ColumnIndex == UpdateCol.Index)
            {
                UpdateFirmware(e);
            }
        }

        private void DeleteFirmware(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            string versionName = dtgSoftwareVersion.Rows[e.RowIndex].Cells[FirmwareNameCol.Index].Value.ToString();
            var rst = MessageBox.Show("Bạn có muốn xoá phiên bản phần mềm " + versionName + " này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rst != DialogResult.Yes)
                return;
            int firmwareId = int.Parse(dtgSoftwareVersion.Rows[e.RowIndex].Cells[FirmwareIdCol.Index].Value.ToString());
            try
            {
                FirmwareDataSet.FirmwareDataTable firmwareDataTable = new FirmwareDataSet.FirmwareDataTable();
                this.firmwareTableAdapter.FillByFirmwareId(firmwareDataTable, firmwareId);
                if (firmwareDataTable.Rows.Count > 0)
                {
                    firmwareDataTable[0].Delete();
                    firmwareTableAdapter.Update(firmwareDataTable);
                }
                if (dtgSoftwareVersion.Rows[e.RowIndex].Cells[FilePathCol.Index].Value != null)
                {
                    UploadFile uploadFile = new UploadFile();

                    uploadFile.DeleteFirmawre(dtgSoftwareVersion.Rows[e.RowIndex].Cells[FilePathCol.Index].Value.ToString());
                }
                LoadFirmware();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCSystemFirmware - Xoá firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi xoá dữ liệu không thành công. Chi tiết lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFirmware(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                int firmwareId = int.Parse(dtgSoftwareVersion.Rows[e.RowIndex].Cells[FirmwareIdCol.Index].Value.ToString());
                UpdateFirmware updateFirmware = new UpdateFirmware(firmwareId);
                updateFirmware.ReloadData += LoadFirmware;
                updateFirmware.ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCSystemFirmware - Cập nhật firmware. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi xoá dữ liệu không thành công. Chi tiết lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSystemFirmware_Load(object sender, EventArgs e)
        {
            LoadFirmware();
        }
    }
}
