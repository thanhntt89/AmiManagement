using System;
using System.Data;
using System.Windows.Forms;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using System.Linq;
using OperationDTO.AmiOperationDataSet.SystemFunctionDataSetTableAdapters;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using AmiOperationLib;

namespace AmiOperationManagement.Main
{
    public partial class LoginSystem : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private SystemFunctionDataSet.UserFunctionDataTable userFunctionDataTable = new SystemFunctionDataSet.UserFunctionDataTable();
        private UserFunctionTableAdapter userFunctionTableAdapter = new UserFunctionTableAdapter();

        public bool isLogined;

        public LoginSystem()
        {
            InitializeComponent();
            panel1.Focus();
            txtUserName.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                btnLogin_Click(null, null);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.isLogined = false;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                MessageBox.Show("Tài khoản người dùng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                MessageBox.Show("Mật khẩu người dùng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.usersTableAdapter.FillByUserName(this.usersDataTable, txtUserName.Text);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Login - Không lấy được thông tin người dùng: " + txtUserName.Text + ". Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu. Đăng nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.usersDataTable.Rows.Count == 0 || !this.usersDataTable.First().Password.Equals(txtPassword.Text))
            {
                txtUserName.Focus();
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.usersDataTable.First().Active)
            {
                txtUserName.Focus();
                MessageBox.Show("Tài khoản người dùng đã bị dừng hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (!this.usersDataTable.First().Password.Equals(txtPassword.Text))
            //{
            //    txtPassword.Focus();
            //    MessageBox.Show("Mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Load user function
            try
            {
                UserSession.UserName = this.usersDataTable.First().UserName;

                this.userFunctionTableAdapter.FillByGroupId(this.userFunctionDataTable, this.usersDataTable.First().GroupId);

                UserSession.UserFunctionList.SystemFunctionList = (from r in this.userFunctionDataTable.AsEnumerable()
                                                                   select new SystemFunctionEntity
                                                                   {
                                                                       FunctionId = r.Field<object>("FunctionId").ToString(),
                                                                       FunctionCode = r.Field<object>("FunctionCode").ToString(),
                                                                       FunctionName = r.Field<object>("FunctionName").ToString(),
                                                                       IsActive = r.Field<bool>("IsActive")
                                                                   }
                               ).ToList();

                // Log người dùng
                UserSession.CurrentFunction = SystemResource.User_Action_Login;
                UserSession.Action = SystemResource.User_Action_Login;
                UserSession.Notes = SystemResource.User_Action_Login;

                controlBase.InsertHistories();

                this.isLogined = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Login - Không lấy được quyền cho người dùng. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không lấy được quyền cho người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoginSystem_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }
    }
}