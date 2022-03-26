using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;

namespace AmiOperationManagement.Deployment
{
    public partial class AddCustomer : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
        private QueryCustomerIdByMpIdTableAdapter queryCustomerIdByMpIdTableAdapter = new QueryCustomerIdByMpIdTableAdapter();
             
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerId.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Kiểm tra xem mã khách hàng đã tồn tại chưa? Nếu tồn tại thì bắt nhập lại          
            try
            {
                CustomerDataSet.CustomerDataTable customerDataTableSearch = new CustomerDataSet.CustomerDataTable();
                this.customerTableAdapter.FillByCustomerCode(customerDataTableSearch, txtCustomerId.Text);
                // Mã chưa tồn tại trong hệ thống có thể thêm mới
                if (customerDataTableSearch.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã khách hàng: " + txtCustomerId.Text + " đã tồn tại. Bạn phải nhập vào mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCustomerId.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.WriteLog(LogLevelL4N.ERROR, "AddCustomer.Validation - Lỗi tạo khách hàng lỗi. Chi tiết lỗi: ", ex);
                return false;
            }
        }
        private void Save()
        {
            if (!this.Validation())
                return;
            this.CreateNewCustomer();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void CreateNewCustomer()
        {
            try
            {
                CustomerDataSet.CustomerDataTable customerDataTable = new CustomerDataSet.CustomerDataTable();

                var newRows = customerDataTable.NewCustomerRow();

                newRows.CustomerId = txtCustomerId.Text;
                newRows.Name = txtName.Text;
                newRows.Address = txtAddress.Text;
                newRows.CreatedDate = DateTime.Now;
                newRows.Mobile = txtPhone.Text;
                newRows.IsDeleted = false;

                customerDataTable.AddCustomerRow(newRows);

                this.customerTableAdapter.Update(customerDataTable);
                
                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CreateCustomer);
                UserSession.Action = SystemResource.User_Action_Add;
                UserSession.Notes = "Thêm mới mã khách hàng: " + txtCustomerId.Text + "\nTên: " + txtName.Text
                    + "\nĐịa chỉ: " + txtAddress.Text
                    + "\nSố điện thoại: " + txtPhone.Text;

                controlBase.InsertHistories();

                MessageBox.Show("Tạo khách hàng mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustomerId.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtName.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddCustomer.CreateNewCustomer - Lỗi tạo khách hàng lỗi. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tạo khách hàng mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}