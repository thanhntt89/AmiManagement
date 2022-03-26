using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using System.Linq;

namespace AmiOperationManagement.Deployment
{
    public partial class UpdateMeter : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private long meterId;
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();
        private MeterTableAdapter meterTableAdapter = new MeterTableAdapter();
        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterDataSet.MeterDataTable meterDataTable = new MeterDataSet.MeterDataTable();

        public UpdateMeter(long meterId)
        {
            InitializeComponent();
            this.meterId = meterId;
        }

        private void LoadMeterInfo()
        {
            try
            {
                this.meterTableAdapter.FillByMeterId(this.meterDataTable, this.meterId);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeter.LoadMeterInfo -  lỗi xử lý LoadMeterInfo chi tiết: ", ex);

                MessageBox.Show("Lỗi lấy thông tin công tơ từ cơ sở dữ liệu không thành công. Chi tiết xem log", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.meterDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Công tơ không còn tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lbMeterId.Text = this.meterDataTable.First().MeterId;
            txtSerial.Text = this.meterDataTable.First().Serial;
            txtMultiplier.Text = this.meterDataTable.First().IsMultiplierNull() ? string.Empty : this.meterDataTable.First().Multiplier.ToString();
            cboMeterType.SelectedValue = this.meterDataTable.First().MeterTypeId;
            cboHistype.SelectedIndex = this.meterDataTable.First().HisType;
            cboIsUsed.SelectedIndex = this.meterDataTable.First().Status == 1 ? 0 : 1;// Status = 1 đã sử dụng
        }

        private void UpdateMeter_Load(object sender, EventArgs e)
        {
            this.LoadMeterType();
            this.LoadMeterInfo();
        }

        private void LoadMeterType()
        {
            try
            {
                this.meterTypeAmiSysTableAdapter.Fill(meterTypeDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeter.LoadMeterType -  lỗi xử lý LoadMeterType chi tiết: ", ex);

                MessageBox.Show("Lỗi lấy thông tin loại công tơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cboMeterType.DataSource = this.meterTypeDataTable;
            cboMeterType.DisplayMember = this.meterTypeDataTable.NameColumn.ToString();
            cboMeterType.ValueMember = this.meterTypeDataTable.IdColumn.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSerial.Text))
            {
                MessageBox.Show("Mã Serial không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerial.Focus();
                return;
            }
            if (cboMeterType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn một loại công tơ để sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMeterType.Focus();
                return;
            }
            if (txtMultiplier.Value < 0)
            {
                MessageBox.Show("Hệ số nhân phải lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMeterType.Focus();
                return;
            }
            if (cboHistype.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn một loại chốt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMeterType.Focus();
                return;
            }
            this.EditMeter();
        }

        private void EditMeter()
        {
            try
            {
                this.meterDataTable.First().Multiplier = (decimal)txtMultiplier.Value;
                this.meterDataTable.First().MeterTypeId = long.Parse(cboMeterType.SelectedValue.ToString());
                this.meterDataTable.First().HisType = cboHistype.SelectedIndex;
                this.meterDataTable.First().EditedDate = DateTime.Now;
                this.meterDataTable.First().EditedUserId = UserSession.UserName;

                this.meterTableAdapter.Update(this.meterDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UpdateMeter);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Cập nhật công tơ mã: " + lbMeterId.Text
                     + "\nSerial: " + txtSerial.Text
                + "\nLoại chốt: " + cboHistype.Text
                + "\nHệ số nhân: " + txtMultiplier.Text
                + "\nLoại đồng hồ: " + cboMeterType.Text;

                controlBase.InsertHistories();

                MessageBox.Show("Sửa thông tin công tơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeter.EditMeter - Lỗi cập nhật lại thông tin cho công tơ: " + lbMeterId.Text + " . Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi sửa thông tin công tơ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}