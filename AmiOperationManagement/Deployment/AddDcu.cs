using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class AddDcu : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();

        public AddDcu()
        {
            InitializeComponent();
        }

        private void btSaveEditDcu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDcuCode.Text))
            {
                MessageBox.Show("Mã thiết bị không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tồn tại của điểm đo mới nhập xem đã tồn tại hay chưa?
            DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();

            try
            {
                this.dataConcentratorUnitTableAdapter.FillByDcuCode(dataConcentratorUnitDataTable, txtDcuCode.Text);
                if (dataConcentratorUnitDataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Mã thiết bị: " + txtDcuCode.Text + " đã tồn tại. Bạn phải nhập vào mã khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDcuCode.SelectAll();
                    txtDcuCode.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddDcu.btSaveEditDcu_Click - Lỗi kiểm tra modem tồn tại. Chi tiết lỗi: ", ex);
                MessageBox.Show("Không tải được dữ liệu từ cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            this.CreateNewModem();
        }

        private void CreateNewModem()
        {
            try
            {
                DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
                var newRow = dataConcentratorUnitDataTable.NewDataConcentratorUnitRow();

                newRow.DcuId = txtDcuCode.Text;
                newRow.Sim = txtPhone.Text;
                newRow.SimSerial = txtSerialSim.Text;
                newRow.Note = txtNotes.Text;
                newRow.Status = 2;// Status =0: offline
                newRow.IsDeleted = false;
                newRow.CreatedDate = DateTime.Now;
                newRow.CreatedUserId = UserSession.UserName;

                dataConcentratorUnitDataTable.AddDataConcentratorUnitRow(newRow);

                this.dataConcentratorUnitTableAdapter.Update(dataConcentratorUnitDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CreateDcu);
                UserSession.Action = SystemResource.User_Action_Add;
                UserSession.Notes = "Thêm mới mã thiết bị: " + txtDcuCode.Text + "\nSerial Sim: " + txtSerialSim.Text
                    + "\nSố điện thoại: " + txtPhone.Text;

                controlBase.InsertHistories();

                MessageBox.Show("Tạo thiết bị mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDcuCode.Text = string.Empty;
                txtNotes.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtSerialSim.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddDcu.CreateNewModem - Lỗi tạo modem mới. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tạo modem mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCacelEditDcu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}