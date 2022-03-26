using System;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using System.Windows.Forms;
using System.Linq;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;

namespace AmiOperationManagement.Systems
{
    public partial class ChangePassword : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Save()
        {
            try
            {
                this.usersTableAdapter.FillByUserName(this.usersDataTable, UserSession.UserName);

                if (string.IsNullOrEmpty(txtCurrentPassowrd.Text))
                {
                    txtCurrentPassowrd.Focus();

                    MessageBox.Show("Mật khẩu hiện tại không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                if (!this.usersDataTable.First().Password.Equals(txtCurrentPassowrd.Text))
                {
                    txtCurrentPassowrd.Focus();
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    txtNewPassword.Focus();

                    MessageBox.Show("Mật khẩu mới không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    txtConfirmPassword.Focus();

                    MessageBox.Show("Mật khẩu xác nhận không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
                {
                    txtConfirmPassword.Focus();
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.usersDataTable.First().Password = txtNewPassword.Text;
                this.usersTableAdapter.Update(this.usersDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ChangePassword);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = SystemResource.UserFunction_ChangePassword;

                controlBase.InsertHistories();

                MessageBox.Show("Đổi mật khẩu người dùng thành công. Bạn hãy khởi động lại chương trình để thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}