using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using System.Linq;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class UpdateDcu : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();
        private DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
        private long dcuId = -1;
        private string dcuCode = string.Empty;

        private MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();
             
        public UpdateDcu(OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSet.DataConcentratorUnitRow dataConcentratorUnitInfor)
        {
            InitializeComponent();
            this.dcuId = dataConcentratorUnitInfor.Id;
            this.dcuCode = dataConcentratorUnitInfor.DcuId;
            this.LoadDcuInfo(dataConcentratorUnitInfor.Id);
        }

        private void LoadDcuInfo(long dcuId)
        {
            try
            {
                this.dataConcentratorUnitTableAdapter.FillByDcuId(this.dataConcentratorUnitDataTable, dcuId);
                if (dataConcentratorUnitDataTable.Rows.Count > 0)
                {
                    lblDcuCode.Text = dataConcentratorUnitDataTable.First().DcuId;
                    txtSerialSim.Text = dataConcentratorUnitDataTable.First().IsSimSerialNull() ? string.Empty : dataConcentratorUnitDataTable.First().SimSerial;
                    txtPhone.Text = dataConcentratorUnitDataTable.First().IsSimNull() ? string.Empty : dataConcentratorUnitDataTable.First().Sim;
                    txtNotes.Text = dataConcentratorUnitDataTable.First().IsNoteNull() ? string.Empty : dataConcentratorUnitDataTable.First().Note;

                    cboStatus.SelectedIndex = dataConcentratorUnitDataTable.First().IsDeleted ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddDcu.btSaveEditDcu_Click - Lỗi kiểm tra modem tồn tại. Chi tiết lỗi: ", ex);
                MessageBox.Show("Không tải được dữ liệu từ cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void btSaveEditDcu_Click(object sender, EventArgs e)
        {
            this.EditModemInfo();
        }

        private void EditModemInfo()
        {
            try
            {
                // Kiểm tra mã thiết bị được gắn với điểm đo ở trạng thái nào/
                // Nếu trạng thái điểm đo gắn với thiết bị đang hoạt động thì không cho chuyển trạng thái DCU sang xoá
                MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
                if (cboStatus.SelectedIndex == 1)
                {
                    this.measurementPointInfoTableAdapter.FillByDcuId(measurementPointInfoDataTable, dcuId);
                    if (measurementPointInfoDataTable.Rows.Count > 0)
                    {
                        string measurementPointCode = measurementPointInfoDataTable.First().MeasurementPointCode;
                        // Nếu điểm đo không bị xoá thì không cho phép xoá dcu
                        if (!measurementPointInfoDataTable.First().IsDeleted)
                        {
                            MessageBox.Show("Không thể chuyển trạng thái xoá ở thiết bị này. Mã thiết bị: " + this.dcuCode + " đang được liên kết với điểm đo " + measurementPointCode + " ở trạng thái hoạt động. ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                this.dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
                // Kiểm tra trong db còn tồn tại dữ liệu không
                this.dataConcentratorUnitTableAdapter.FillByDcuId(this.dataConcentratorUnitDataTable, this.dcuId);

                this.dataConcentratorUnitDataTable.First().Sim = txtPhone.Text;
                this.dataConcentratorUnitDataTable.First().SimSerial = txtSerialSim.Text;
                this.dataConcentratorUnitDataTable.First().Note = txtNotes.Text;
                this.dataConcentratorUnitDataTable.First().IsDeleted = cboStatus.SelectedIndex == 0 ? false : true;
                this.dataConcentratorUnitDataTable.First().EditedDate = DateTime.Now;
                this.dataConcentratorUnitDataTable.First().EditedUserId = UserSession.UserName;
                
                this.dataConcentratorUnitTableAdapter.Update(this.dataConcentratorUnitDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UpdateDcu);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Sửa mã thiết bị: " + lblDcuCode.Text + "\nSerial Sim: " + txtSerialSim.Text
                    + "\nSố điện thoại: " + txtPhone.Text;

                controlBase.InsertHistories();

                MessageBox.Show("Sửa thông tin modem thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateDcu.EditModemInfo - Lỗi cập nhật lại thông tin cho modem: " + lblDcuCode.Text + " . Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi sửa thông tin modem", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCacelEditDcu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}