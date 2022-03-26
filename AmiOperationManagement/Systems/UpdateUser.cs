using System;
using System.Windows.Forms;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.UserGroupDataSetTableAdapters;
using AmiOperationLib;
using System.Linq;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;

namespace AmiOperationManagement.Systems
{
    public partial class UpdateUser : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private UserGroupDataSet.UserGroupDataTable userGroupDataTable = new UserGroupDataSet.UserGroupDataTable();
        private UserGroupTableAdapter userGroupTableAdapter = new UserGroupTableAdapter();

        private int userId = -1;

        public UpdateUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
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

        private void LoadUserInfo()
        {
            try
            {
                this.usersTableAdapter.FillByUserId(this.usersDataTable, this.userId);

                txtUserName.Text = this.usersDataTable.First().UserName;
                txtFullName.Text = this.usersDataTable.First().FullName;
                txtEmail.Text = this.usersDataTable.First().Email;

                cboUserGroup.SelectedValue = this.usersDataTable.First().GroupId;
                chkActive.Checked = this.usersDataTable.First().Active;

                if (UserSession.UserName.Equals(Constant.SUPPER_USER))
                    if (txtUserName.Text.Equals(Constant.SUPPER_USER) || UserSession.UserName.Equals(txtUserName.Text))
                        btnSave.Enabled = false;
                if (txtUserName.Text.Equals(UserSession.UserName))
                {
                    chkActive.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateUser - LoadUserInfo. Chi tiết:", ex);
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

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserManagement);
                UserSession.Action = SystemResource.User_Action_Update;
                string status = string.Empty;
                if (chkActive.Checked)
                    status = SystemResource.User_Action_Status_Enable;
                else
                    status = SystemResource.User_Action_Status_Disable;

                UserSession.Notes = "Cập nhật người dùng: " + txtUserName.Text + " - Tên người dùng cũ: " + this.usersDataTable.First().FullName + " - Tên người dùng mới:" + txtFullName.Text + " - Email: " + txtEmail.Text + " - Trạng thái: " + status + " - Nhóm người dùng: " + cboUserGroup.Text;

                this.usersDataTable.First().GroupId = int.Parse(cboUserGroup.SelectedValue.ToString());
                this.usersDataTable.First().FullName = txtFullName.Text;
                this.usersDataTable.First().Email = txtEmail.Text;
                this.usersDataTable.First().Active = chkActive.Checked;

                this.usersTableAdapter.Update(this.usersDataTable);

                controlBase.InsertHistories();

                MessageBox.Show("Cập nhật người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateUser - SaveUser. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            this.LoadGroupUser();
            this.LoadUserInfo();
        }
    }
}