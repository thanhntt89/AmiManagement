using System;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointStatusDataSetTableAdapters;
using System.Windows.Forms;
using OperationDTO.AmiSystemDataSet.MeasurementPointMeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using AmiOperationManagement.Resources;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.Deployment
{
    public partial class AddMeasurementPoint : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private MeasurementPointStatusDataSet.MeasurementPointStatusDataTable measurementPointStatusDataTable = new MeasurementPointStatusDataSet.MeasurementPointStatusDataTable();
        private MeasurementPointStatusTableAdapter measurementPointStatusTableAdapter = new MeasurementPointStatusTableAdapter();
        private MeasurementPointTableAdapter measurementPointTableAdapter = new MeasurementPointTableAdapter();
        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable = new MeasurementPointDataSet.MeasurementPointDataTable();

        public AddMeasurementPoint()
        {
            InitializeComponent();
        }

        private void UpdateMeasurementPoint_Load(object sender, EventArgs e)
        {
            this.LoadMeasurementPointGroup();
            this.LoadContract();
            this.LoadStatus();
        }


        private void LoadStatus()
        {
            try
            {
                measurementPointStatusTableAdapter.Fill(measurementPointStatusDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadStatus - Tải dữ liệu cho LoadStatus không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin trạng thái điểm đo. Chi tiết lỗi xem file logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cboMpType.DataSource = measurementPointStatusDataTable;
            cboMpType.DisplayMember = measurementPointStatusDataTable.TypeNameColumn.ColumnName;
            cboMpType.ValueMember = measurementPointStatusDataTable.TypeIdColumn.ColumnName;
        }


        private void LoadContract()
        {
            try
            {
                contractTableAdapter.Fill(contractDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadContract - Tải dữ liệu cho LoadContract không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin hợp đồng của điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newRows = this.contractDataTable.NewContractRow();

            newRows.Id = -1;
            newRows.Note = Constant.SELECT_ALL_TEXT;
            newRows.ContractId = "-1";

            this.contractDataTable.Rows.InsertAt(newRows, 0);

            cboContract.DataSource = this.contractDataTable;
            cboContract.DisplayMember = this.contractDataTable.NoteColumn.ColumnName;
            cboContract.ValueMember = this.contractDataTable.IdColumn.ColumnName;
        }

        private void LoadMeasurementPointGroup()
        {
            try
            {
                measurementPointGroupTableAdapter.Fill(measurementPointGroupDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeasurementPointGroup - Tải dữ liệu cho LoadMeasurementPointGroup không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin điện lực quản lý điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cboGroupMp.DataSource = measurementPointGroupDataTable;
            cboGroupMp.DisplayMember = this.measurementPointGroupDataTable.NameColumn.ColumnName;
            cboGroupMp.ValueMember = this.measurementPointGroupDataTable.IdColumn.ColumnName;
        }

        private bool Validation()
        {
            if (cboGroupMp.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn điện lực.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboContract.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtMpCode.Text))
            {
                MessageBox.Show("Mã điểm đo không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMpCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMpName.Text))
            {
                MessageBox.Show("Tên điểm đo không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMpName.Focus();
                return false;
            }
            if (cboMpType.SelectedIndex == -1)
            {
                MessageBox.Show("Trạng thái điểm đo không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMpType.Focus();
                return false;
            }

            // Kiểm tra Mã điểm đo này đã tồn tại hay chưa? 
            // Nếu mã tồn tại rồi bắt nhập vào mã khác
            try
            {
                this.measurementPointTableAdapter.FillByMeasurementPointCode(this.measurementPointDataTable, txtMpCode.Text);

                if (this.measurementPointDataTable.Rows.Count > 0)
                {
                    txtMpCode.Focus();
                    MessageBox.Show("Mã điểm đo :" + txtMpCode.Text + " đã tồn tại. Bạn phải nhập vào mã khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.Validation - Lỗi kiểm tra tồn tại điểm đo. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi trong quá trình xử lý dữ liệu. Chi tiết kiểm tra logs", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Save()
        {
            if (!Validation())
                return;
            try
            {
                var newRows = this.measurementPointDataTable.NewMeasurementPointRow();
                newRows.MeasurementPointGroupId = long.Parse(cboGroupMp.SelectedValue.ToString());
                newRows.MeasurementPointId = txtMpCode.Text;
                
                if (cboContract.SelectedIndex > 0)
                    newRows.TakeOverBill = long.Parse(cboContract.SelectedValue.ToString());

                newRows.Name = txtMpName.Text;
                newRows.Type = int.Parse(cboMpType.SelectedValue.ToString());
                newRows.Note = txtNotes.Text;
                newRows.Address = txtMpAddress.Text;
                newRows.IsDeleted = false;
                newRows.CreatedDate = DateTime.Now;
                newRows.CreatedUserId = UserSession.UserName;
                newRows.PhaseType = 3;// 3 phase

                this.measurementPointDataTable.AddMeasurementPointRow(newRows);

                this.measurementPointTableAdapter.Update(this.measurementPointDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CreateMeasurementPoint);
                UserSession.Action = SystemResource.User_Action_Add;
                UserSession.Notes = "Thêm mới mã điểm đo: " + txtMpCode.Text + "\nTên điểm: " + txtMpName.Text
                    + "\nĐịa chỉ: " + txtMpAddress.Text;

                controlBase.InsertHistories();
                MessageBox.Show("Tạo điểm đo mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMpAddress.Text = string.Empty;
                txtMpCode.Text = string.Empty;
                txtMpName.Text = string.Empty;
                txtNotes.Text = string.Empty;
                txtMpCode.Focus();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.CreateNewMeasurementPoint - Lỗi tạo điểm đo mới. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tạo điểm đo mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveMp_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btCacelMp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}