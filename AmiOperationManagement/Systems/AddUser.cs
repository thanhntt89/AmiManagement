using System;
using System.Windows.Forms;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.UserGroupDataSetTableAdapters;
using AmiOperationLib;
using AmiOperationManagement.Resources;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.Systems
{
    public partial class AddUser : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        public event OperationEventHandle ReloadData;

        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private UserGroupDataSet.UserGroupDataTable userGroupDataTable = new UserGroupDataSet.UserGroupDataTable();
        private UserGroupTableAdapter userGroupTableAdapter = new UserGroupTableAdapter();

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadGroupUser()
        {
            try
            {
                this.userGroupTableAdapter.Fill(this.userGroupDataTable);

                if (!UserSession.UserName.Equals(Constant.SUPPER_USER))
                {
                    this.userGroupDataTable.FindByGroupId(1).Delete();
                }

                cboUserGroup.DataSource = this.userGroupDataTable;
                cboUserGroup.DisplayMember = this.userGroupDataTable.GroupNameColumn.ToString();
                cboUserGroup.ValueMember = this.userGroupDataTable.GroupIdColumn.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveUser();
        }

        private void SaveUser()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                MessageBox.Show("Tài khoản người dùng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.Focus();
                MessageBox.Show("Tên người dùng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboUserGroup.SelectedIndex == -1)
            {
                cboUserGroup.Focus();
                MessageBox.Show("Bạn chưa chọn nhóm người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newRow = this.usersDataTable.NewUsersRow();

                newRow.GroupId = int.Parse(cboUserGroup.SelectedValue.ToString());
                newRow.UserName = txtUserName.Text;
                newRow.FullName = txtFullName.Text;
                newRow.Email = txtEmail.Text;
                newRow.Password = Constant.USER_PASSWORD_DEFAULT;
                newRow.Active = true;
                this.usersDataTable.AddUsersRow(newRow);

                this.usersTableAdapter.Update(this.usersDataTable);
                MessageBox.Show("Thêm người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserManagement);
                UserSession.Action = SystemResource.User_Action_Add;
                UserSession.Notes = "Thêm mới người dùng: " + txtUserName.Text + " - Tên người dùng: " + txtFullName.Text + " - Email: " + txtEmail.Text;

                controlBase.InsertHistories();

                txtUserName.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtEmail.Text = string.Empty;

                if (this.ReloadData != null)
                    this.ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            this.LoadGroupUser();
        }
    }
}