using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using AmiOperationLib;
using AmiOperationManagement.Resources;
using System.Text;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.Systems
{
    public partial class DatabaseConfig : DevComponents.DotNetBar.Metro.MetroForm
    {
        private DataBaseConnection connection = new DataBaseConnection();
        private UserControlBase controlBase = new UserControlBase();

        public DatabaseConfig()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            if (tabItem1.IsSelected)
            {
                txtIpAdmin.TabIndex = 0;
                txtUserAdmin.TabIndex = 1;
                txtPasswordAdmin.TabIndex = 2;
                txtDatabaseAdmin.TabIndex = 3;
            }
            else if (tabItem2.IsSelected)
            {
                txtIpClient.TabIndex = 0;
                txtUserClient.TabIndex = 1;
                txtPasswordClient.TabIndex = 2;
                txtDatabaseClient.TabIndex = 3;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckSqlConnection();
        }

        private void CheckSqlConnection()
        {
            if (string.IsNullOrEmpty(txtIpAdmin.Text))
            {
                tabControl1.SelectedTabIndex = 0;
                txtIpAdmin.Focus();
                MessageBox.Show("Địa chỉ máy chủ Cơ sở dữ liệu quản trị không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtUserAdmin.Text))
            {
                tabControl1.SelectedTabIndex = 0;
                txtUserAdmin.Focus();
                MessageBox.Show("User name Cơ sở dữ liệu quản trị không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPasswordAdmin.Text))
            {
                tabControl1.SelectedTabIndex = 0;
                txtPasswordAdmin.Focus();
                MessageBox.Show("Password Cơ sở dữ liệu quản trị không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDatabaseAdmin.Text))
            {
                tabControl1.SelectedTabIndex = 0;
                txtDatabaseAdmin.Focus();
                MessageBox.Show("Database Cơ sở dữ liệu quản trị không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!connection.CheckConnection(Constant.ADMIN_CONNECTION, txtIpAdmin.Text, txtDatabaseAdmin.Text, txtUserAdmin.Text, txtPasswordAdmin.Text, chkConfirmAdmin.Checked))
            {
                tabControl1.SelectedTabIndex = 0;
                MessageBox.Show("Kết nối đến cơ sở dữ liệu quản trị không thành công. Bạn hãy kiểm tra lại thông tin kết nối.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check khách hàng
            if (string.IsNullOrEmpty(txtIpClient.Text))
            {
                tabControl1.SelectedTabIndex = 1;
                txtIpClient.Focus();
                MessageBox.Show("Địa chỉ máy chủ Cơ sở dữ liệu khách hàng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtUserClient.Text))
            {
                tabControl1.SelectedTabIndex = 1;
                txtUserClient.Focus();
                MessageBox.Show("User name Cơ sở dữ liệu khách hàng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPasswordClient.Text))
            {
                tabControl1.SelectedTabIndex = 1;
                txtPasswordClient.Focus();
                MessageBox.Show("Password Cơ sở dữ liệu khách hàng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDatabaseClient.Text))
            {
                tabControl1.SelectedTabIndex = 1;
                txtDatabaseClient.Focus();
                MessageBox.Show("Database Cơ sở dữ liệu khách hàng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!connection.CheckConnection(Constant.CLIENT_CONNECTION, txtIpClient.Text, txtDatabaseClient.Text, txtUserClient.Text, txtPasswordClient.Text, chkConfirmClient.Checked))
            {
                tabControl1.SelectedTabIndex = 1;
                MessageBox.Show("Kết nối đến cơ sở dữ liệu khách hàng không thành công. Bạn hãy kiểm tra lại thông tin kết nối.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Log người dùng
            UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ServerConnect);
            UserSession.Action = SystemResource.User_Action_Update;

            StringBuilder str = new StringBuilder();
            str.Append("Đổi thông tin cấu hình cơ sở dữ liệu - ");
            str.Append("Cơ sở dữ liệu quản trị - ServerIP: " + txtIpAdmin.Text);
            str.Append(" UserName: " + txtUserAdmin.Text);
            str.Append(" Password: " + txtPasswordAdmin.Text);
            str.Append(" Security: " + chkConfirmAdmin.Checked);

            str.Append("Cơ sở dữ liệu khách hàng - ServerIP: " + txtIpClient.Text);
            str.Append(" UserName: " + txtUserClient.Text);
            str.Append(" Password: " + txtPasswordClient.Text);
            str.Append(" Security: " + chkConfirmClient.Checked);

            UserSession.Notes = str.ToString();

            this.controlBase.InsertHistories();

            MessageBox.Show("Lưu thông tin kết nối thành công. Bạn hãy khởi động lại để sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LoadDefaultValue()
        {
            // Server saoviet
            txtDatabaseAdmin.Text = "AmiSystemOperationManagement";
            txtIpAdmin.Text = "124.158.5.154";
            txtUserAdmin.Text = "sa";
            txtPasswordAdmin.Text = "@dmin123";
            chkConfirmAdmin.Checked = true;

            // Server client
            txtDatabaseClient.Text = "AmiSystem";
            txtIpClient.Text = "124.158.5.154";
            txtUserClient.Text = "sa";
            txtPasswordClient.Text = "@dmin123";
            chkConfirmClient.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDefaultValue_Click(object sender, EventArgs e)
        {
            this.LoadDefaultValue();
        }

        private void DatabaseConfig_Load(object sender, EventArgs e)
        {
            try
            {
                string amisystem = Sercurity.Decrypt(FileUtil.GetSqlConnectionString("sqlconnectionStrings", Constant.CLIENT_CONNECTION));
                txtIpClient.Text = amisystem.Split(';')[0].Split('=')[1];
                txtDatabaseClient.Text = amisystem.Split(';')[1].Split('=')[1];
                txtPasswordClient.Text = amisystem.Split(';')[4].Split('=')[1];
                txtUserClient.Text = amisystem.Split(';')[3].Split('=')[1];
                chkConfirmClient.Checked = bool.Parse(amisystem.Split(';')[2].Split('=')[1]);

                string amioperation = Sercurity.Decrypt(FileUtil.GetSqlConnectionString("sqlconnectionStrings", Constant.ADMIN_CONNECTION));

                txtIpAdmin.Text = amioperation.Split(';')[0].Split('=')[1];
                txtDatabaseAdmin.Text = amioperation.Split(';')[1].Split('=')[1];
                txtPasswordAdmin.Text = amioperation.Split(';')[4].Split('=')[1];
                txtUserAdmin.Text = amioperation.Split(';')[3].Split('=')[1];
                chkConfirmAdmin.Checked = bool.Parse(amioperation.Split(';')[2].Split('=')[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong việc tải dữ liệu cấu hình.\nChi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}