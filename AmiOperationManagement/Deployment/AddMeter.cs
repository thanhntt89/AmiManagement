using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class AddMeter : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();
        private MeterTableAdapter meterTableAdapter = new MeterTableAdapter();
        private MeterDataSet.MeterDataTable meterDataTable = new MeterDataSet.MeterDataTable();
            

        public AddMeter()
        {
            InitializeComponent();
            cboHistype.SelectedIndex = 0;
        }

        private void UpdateMeter_Load(object sender, EventArgs e)
        {
            this.LoadMeterType();
        }

        private void LoadMeterType()
        {
            try
            {
                this.meterTypeAmiSysTableAdapter.Fill(meterTypeDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeter.LoadMeterType -  lỗi xử lý LoadMeterType chi tiết: ", ex);

                MessageBox.Show("Lỗi lấy thông tin loại công tơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbMeterType.DataSource = this.meterTypeDataTable;
            cbMeterType.DisplayMember = this.meterTypeDataTable.NameColumn.ToString();
            cbMeterType.ValueMember = this.meterTypeDataTable.IdColumn.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMeterId.Text))
            {
                MessageBox.Show("Mã công tơ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeterId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSerial.Text))
            {
                MessageBox.Show("Mã Serial không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerial.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbMeterType.Text))
            {
                MessageBox.Show("Loại công tơ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMeterType.Focus();
                return;
            }

            // Kiểm tra tồn tại của đồng hồ trong cơ sở dữ liệu
            try
            {
                this.meterTableAdapter.FillByMeterCode(this.meterDataTable, txtMeterId.Text);

                if (this.meterDataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Mã đồng hồ " + txtMeterId.Text + " đã được nhập. Bạn hãy kiểm tra và nhập vào mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMeterId.Focus();
                    txtMeterId.SelectAll();
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Kiểm tra tồn tại đồng hồ: this.meterTableAdapter.FillByMeterCode(this.meterDataTable," + txtMeterId.Text + ") Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi không tải được dữ liệu. Chi tiết kiểm tra logs", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.CreateNewMeter();
        }

        private void CreateNewMeter()
        {
            try
            {
                var newRows = this.meterDataTable.NewMeterRow();

                newRows.MeterId = txtMeterId.Text;
                newRows.MeterTypeId = int.Parse(cbMeterType.SelectedValue.ToString());
                newRows.Multiplier = decimal.Parse(txtMultiplier.Text);
                newRows.Serial = txtSerial.Text;
                newRows.HisType = cboHistype.SelectedIndex;
                newRows.IsDeleted = false;
                newRows.CreatedDate = DateTime.Now;
                newRows.CreatedUserId = UserSession.UserName;
                newRows.Status = 0; // Trạng thái không sử dụng
                this.meterDataTable.AddMeterRow(newRows);

                this.meterTableAdapter.Update(this.meterDataTable);

                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CreateMeter);
                UserSession.Action = SystemResource.User_Action_Add;
                UserSession.Notes = "Thêm mới mã công tơ: " + txtMeterId.Text
                    + "\nSerial: " + txtSerial.Text
                    + "\nLoại chốt: " + cboHistype.Text
                    + "\n Loại công tơ: " + cbMeterType.Text
                    + "\nHệ số nhân: " + txtMultiplier.Text;

                controlBase.InsertHistories();
                MessageBox.Show("Tạo mới công tơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSerial.Text = string.Empty;
                txtMultiplier.Text = string.Empty;
                txtMeterId.Text = string.Empty;                
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeter.CreateNewMeter - Lỗi tạo công tơ mới. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tạo mới công tơ. Chi tiết xem file log", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}