using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AmiOperationLib;
using DevComponents.DotNetBar;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System.Linq;
using AmiOperationManagement.Resources;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.Systems
{
    public partial class UpdateServer : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();
        private ServerDataSet.StatusServerDataTable statusServerDataTable = new ServerDataSet.StatusServerDataTable();
        private int idServer;
        public UpdateServer(int idServer)
        {
            InitializeComponent();
            this.idServer = idServer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text == Constant.HeaderCreateNew)
                this.CreateNewServer();
            else if (this.Text == Constant.HeaderEdit)
                this.EditServerInfo();
        }

        private void EditServerInfo()
        {

            try
            {
                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Server);
                UserSession.Action = SystemResource.User_Action_Update;
                StringBuilder str = new StringBuilder();
                str.Append("Thông tin cũ - Server: " + serverDataTable.First().ServerName);
                str.Append(" - User name: " + serverDataTable.First().UserName);
                str.Append(" - Pass: " + serverDataTable.First().Password);
                str.Append(" - IP name: " + serverDataTable.First().ServerIP);
                str.Append(" - Port: " + serverDataTable.First().Port);
                str.Append(" - Status: " + serverDataTable.First().Status);
                str.Append(" - Type: " + serverDataTable.First().Type);

                str.Append("\nThông tin mới - Server: " + txtServerName.Text);
                str.Append(" - User name: " + txtUser.Text);
                str.Append(" - Pass: " + txtPass.Text);
                str.Append(" - IP name: " + txtServerIp.Text);
                str.Append(" - Port: " + txtPort.Text);
                str.Append(" - Status: " + cboStatusServer.Text);
                str.Append(" - Type: " + cboType.Text);

                UserSession.Notes = str.ToString();

                serverTableAdapter.UpdateServerById(txtServerName.Text, txtServerIp.Text, txtPort.Text, txtUser.Text, txtPass.Text, cboStatusServer.SelectedIndex == 0 ? true : false, cboType.SelectedItem.ToString(), idServer);

                this.controlBase.InsertHistories();

                MessageBox.Show("Sửa thông tin Server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Lỗi sửa thông tin Server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewServer()
        {
            try
            {
                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Server);
                UserSession.Action = SystemResource.User_Action_Add;
                StringBuilder str = new StringBuilder();

                str.Append("\nThông tin - Server: " + txtServerName.Text);
                str.Append(" - User name: " + txtUser.Text);
                str.Append(" - Pass: " + txtPass.Text);
                str.Append(" - IP name: " + txtServerIp.Text);
                str.Append(" - Port: " + txtPort.Text);
                str.Append(" - Status: " + cboStatusServer.Text);
                str.Append(" - Type: " + cboType.Text);

                serverTableAdapter.Insert(txtServerName.Text, txtServerIp.Text, txtPort.Text, txtUser.Text, txtPass.Text, cboStatusServer.SelectedIndex == 0 ? true : false, cboType.SelectedItem.ToString());

                this.controlBase.InsertHistories();

                MessageBox.Show("Tạo Server mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi tạo Server mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateServer_Load(object sender, EventArgs e)
        {
            this.LoadStatusServer();
            this.Display();

        }

        private void Display()
        {
            try
            {
                if (idServer != -1)
                {

                    serverTableAdapter.FillById(serverDataTable, idServer);
                    txtServerName.Text = serverDataTable.First().ServerName;
                    txtServerIp.Text = serverDataTable.First().ServerIP;
                    txtPort.Text = serverDataTable.First().Port;
                    txtUser.Text = serverDataTable.First().UserName;
                    txtPass.Text = serverDataTable.First().Password;
                    cboStatusServer.SelectedIndex = serverDataTable.First().Status == true ? 0 : 1;
                    cboType.SelectedIndex = serverDataTable.First().Type.ToString().Equals(Constant.Gateway) ? 0 : 1;
                    this.Text = Constant.HeaderEdit;
                }
                else
                    this.Text = Constant.HeaderCreateNew;
            }
            catch
            {
                MessageBox.Show("Không lấy được thông tin từ cơ sở dữ liệu. Thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadStatusServer()
        {
            //statusServerDataTable.Rows.Clear();
            //statusServerDataTable.AddStatusServerRow(0, Constant.ActiveStatus);
            //statusServerDataTable.AddStatusServerRow(1, Constant.DeactiveStatus);
            //cboStatusServer.DataSource = statusServerDataTable;
            //cboStatusServer.DisplayMember = statusServerDataTable.NameColumn.ToString();
            //cboStatusServer.ValueMember = statusServerDataTable.IdColumn.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}