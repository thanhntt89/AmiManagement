using System;
using System.Windows.Forms;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using System.Linq;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class UpdateCustomer : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();
        private long customerId;
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
        private CustomerDataSet.CustomerDataTable customerDataTable = new CustomerDataSet.CustomerDataTable();

        public UpdateCustomer(OperationDTO.AmiSystemDataSet.CustomerDataSet.CustomerRow customerInfor)
        {
            InitializeComponent();
            this.customerId = customerInfor.Id;
            this.LoadUserInfo(customerInfor.Id);
        }

        private void LoadUserInfo(long customerId)
        {
            try
            {
                this.customerTableAdapter.FillById(this.customerDataTable, customerId);
                if (this.customerDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Khách hàng không còn tồn tại trong hệ thống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lbCustomerIdEdit.Text = this.customerDataTable.First().CustomerId;
                txtCustomerId.Text = this.customerDataTable.First().CustomerId;
                txtName.Text = this.customerDataTable.First().Name;
                txtAddress.Text = this.customerDataTable.First().IsAddressNull() ? string.Empty : this.customerDataTable.First().Address;
                txtPhone.Text = this.customerDataTable.First().IsMobileNull() ? string.Empty : this.customerDataTable.First().Mobile.ToString();
                chkDisable.Checked = this.customerDataTable.First().IsDeleted;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateCustomer.LoadUserInfo - Tải thông tin khách hàng không thành công: " + txtCustomerId.Text + " . Chi tiết lỗi: ", ex);
                MessageBox.Show("Tải thông tin khách hàng không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            // Trường hợp nếu mã khách hàng không thay đổi thì thực hiện cập nhật
            if (lbCustomerIdEdit.Text.Equals(txtCustomerId.Text))
                return true;

            // Kiểm tra mã khách hàng này đã được tạo chưa? Nếu được tạo rồi không cho tạo nữa
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
                    // Mã đã tồn tại kiểm tra xem nếu là mã cũ thì bỏ qua, mã có Id <> Id ban đầu cảnh báo đã tồn tại
                    if (customerDataTableSearch.First().Id != this.customerDataTable.First().Id)
                    {
                        MessageBox.Show("Mã khách hàng: " + txtCustomerId.Text + " đã tồn tại. Bạn phải nhập vào mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCustomerId.Focus();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình xử lý dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateCustomer.Validation - Lỗi tạo khách hàng lỗi. Chi tiết lỗi: ", ex);
                return false;
            }

            return true;
        }

        private void Save()
        {
            if (!this.Validation())
                return;
            this.EditCustomerInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void EditCustomerInfo()
        {
            // Trạng thái không sử dụng
            // Nếu khách hàng đang được gắn với điểm đo ở trạng thái hoạt động thì không cho phép xoá khách hàng hoặc đổi trạng thái không sử dụng
            if (chkDisable.Checked)
            {
                try
                {
                    MeasurementPointDataSet.MeasurementPointInfoDataTable masurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
                    MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

                    measurementPointInfoTableAdapter.FillByCustomerId(masurementPointInfoDataTable, this.customerId);

                    if (masurementPointInfoDataTable.Rows.Count > 0)
                    {
                        string measurementPointCode = masurementPointInfoDataTable.First().MeasurementPointCode;

                        // Nếu điểm đo không ở trạng thái xoá thì không cho phép chuyển trạng thái khách hàng sang xoá 
                        if (!masurementPointInfoDataTable.First().IsDeleted)
                        {
                            MessageBox.Show("Không thể chuyển trạng thái xoá ở khách hàng này. Mã khách hàng: " + lbCustomerIdEdit.Text + " đang được liên kết với điểm đo " + measurementPointCode + " ở trạng thái hoạt động. ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            return;
                        }
                    }                    
                }
                catch
                {
                    return;
                }
            }
            try
            {
                this.customerDataTable.First().CustomerId = txtCustomerId.Text;
                this.customerDataTable.First().Name = txtName.Text;
                this.customerDataTable.First().Mobile = txtPhone.Text;
                this.customerDataTable.First().Address = txtAddress.Text;
                this.customerDataTable.First().IsDeleted = chkDisable.Checked;

                this.customerTableAdapter.Update(this.customerDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UpdateCustomer);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Sửa mã khách hàng: " + lbCustomerIdEdit.Text + "\nTên: " + txtName.Text
                    + "\nĐịa chỉ: " + txtAddress.Text
                    + "\nSố điện thoại: " + txtPhone.Text;

                controlBase.InsertHistories();
                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateCustomer.EditCustomerInfo - Lỗi cập nhật lại thông tin cho điểm đo: " + txtCustomerId.Text + " . Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi sửa thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}