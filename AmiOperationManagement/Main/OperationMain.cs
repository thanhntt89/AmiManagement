using AmiOperationLib;
using AmiOperationManagement.About;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.ErrorManagement;
using AmiOperationManagement.Ftp;
using AmiOperationManagement.Resources;
using AmiOperationManagement.Systems;
using System;
using System.Windows.Forms;

namespace AmiOperationManagement
{
    public partial class OperationMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private UCErrorDefine uCErrorDefine;
        private UCSystemFirmware uCSystemFirmware;
        private UCServerList uCServer;
        private UCMeterType uCMeterType;
        private UCSystemConfig uCSystemConfig;
        private UCUserList uCUserList;
        private UCTopicManagement uCTopicManagement;
        private UCUserPermission uCUserPermission;
        private UCSystemHistories uCSystemHistories;

        public OperationMain()
        {
            InitializeComponent();
            this.lblUserName.Text = UserSession.UserName;
        }

        private void LoadFunction()
        {
            tabChangePassword.Visible = UserSession.UserFunctionList.CheckExist(tabChangePassword.Name);
            tabSystemHistories.Visible = UserSession.UserFunctionList.CheckExist(tabSystemHistories.Name);
            tabUserManagement.Visible = UserSession.UserFunctionList.CheckExist(tabUserManagement.Name);
            tabUserFunction.Visible = UserSession.UserFunctionList.CheckExist(tabUserFunction.Name);
            tabTopics.Visible = UserSession.UserFunctionList.CheckExist(tabTopics.Name);
            tabErrorDefine.Visible = UserSession.UserFunctionList.CheckExist(tabErrorDefine.Name);
            tabMeterType.Visible = UserSession.UserFunctionList.CheckExist(tabMeterType.Name);
            tabServer.Visible = UserSession.UserFunctionList.CheckExist(tabServer.Name);
            tabSoftwareVersion.Visible = UserSession.UserFunctionList.CheckExist(tabSoftwareVersion.Name);
            tabSystemConfig.Visible = UserSession.UserFunctionList.CheckExist(tabSystemConfig.Name);
            mnDcuController.Visible = UserSession.UserFunctionList.CheckExist(mnDcuController.Name);
            mnDeployment.Visible = UserSession.UserFunctionList.CheckExist(mnDeployment.Name);
            mnOperation.Visible = UserSession.UserFunctionList.CheckExist(mnOperation.Name);
            mnTopMenu.SettingsButtonVisible = UserSession.UserFunctionList.CheckExist(mnTopMenu.Name);
        }

        private void OperationMain_Load(object sender, EventArgs e)
        {
            this.LoadFunction();
            mnDeployment.Checked = true;
            mnDeployment_Click(null, null);
        }

        private void OperationMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Log người dùng
            UserSession.CurrentFunction = SystemResource.User_Action_LogOut;
            UserSession.Action = SystemResource.User_Action_LogOut;
            UserSession.Notes = SystemResource.User_Action_LogOut;

            controlBase.InsertHistories();

            ucMain.ApplicationExit();
            Application.ExitThread();
        }

        private void mnDeployment_Click(object sender, EventArgs e)
        {
            ucMain.ShowMenuByMenuIndex(Constant.MENU_DEPLOY_INDEX);
        }

        private void mnOperation_Click(object sender, EventArgs e)
        {
            ucMain.ShowMenuByMenuIndex(Constant.MENU_OPERATION_INDEX);
        }

        private void mnDcuController_Click(object sender, EventArgs e)
        {
            ucMain.DisplayModemController();
        }

        private void mnErrorManagement_Click(object sender, EventArgs e)
        {
            ucMain.ShowMenuByMenuIndex(Constant.MENU_ERROR_INDEX);
        }

        private void mnReporting_Click(object sender, EventArgs e)
        {
            ucMain.ShowMenuByMenuIndex(Constant.MENU_REPORT_INDEX);
        }

        private void tabErrorDefine_Click(object sender, EventArgs e)
        {
            if (uCErrorDefine == null)
            {
                panErrorDefine.Controls.Clear();
                uCErrorDefine = new UCErrorDefine();
                uCErrorDefine.Dock = DockStyle.Fill;
                panErrorDefine.Controls.Add(uCErrorDefine);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);

                controlBase.InsertHistories();
            }
        }

        private void tabSystemHistories_Click(object sender, EventArgs e)
        {
            if (uCSystemHistories == null)
            {
                panelSystemHistories.Controls.Clear();
                uCSystemHistories = new UCSystemHistories();
                uCSystemHistories.Dock = DockStyle.Fill;
                panelSystemHistories.Controls.Add(uCSystemHistories);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemHistories);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemHistories);

                controlBase.InsertHistories();
            }
        }

        private void tabSystemConfig_Click(object sender, EventArgs e)
        {
            if (uCSystemConfig == null)
            {
                uCSystemConfig = new UCSystemConfig();
                uCSystemConfig.Dock = DockStyle.Fill;
                panelSystemConfig.Controls.Add(uCSystemConfig);


                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemConfig);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemConfig);

                controlBase.InsertHistories();
            }
        }

        private void tabUserManagement_Click(object sender, EventArgs e)
        {
            if (uCUserList == null)
            {
                uCUserList = new UCUserList();
                uCUserList.Dock = DockStyle.Fill;
                panelUserManagement.Controls.Add(uCUserList);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserManagement);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserManagement);

                controlBase.InsertHistories();
            }
            uCUserList.LoadUser();
        }

        private void tabSoftwareVersion_Click(object sender, EventArgs e)
        {
            if (uCSystemFirmware == null)
            {
                uCSystemFirmware = new UCSystemFirmware();

                uCSystemFirmware.Dock = DockStyle.Fill;
                panelSoftwareVersion.Controls.Add(uCSystemFirmware);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SoftwareVersion);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SoftwareVersion);

                controlBase.InsertHistories();
            }
            uCSystemFirmware.LoadFirmware();
        }

        private void tabServer_Click(object sender, EventArgs e)
        {
            if (uCServer == null)
            {
                uCServer = new UCServerList();
                uCServer.Dock = DockStyle.Fill;
                panelServer.Controls.Add(uCServer);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Server);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Server);

                controlBase.InsertHistories();
            }
        }

        private void tabMeterType_Click(object sender, EventArgs e)
        {
            if (uCMeterType == null)
            {
                uCMeterType = new UCMeterType();
                uCMeterType.Dock = DockStyle.Fill;
                panelMeterType.Controls.Add(uCMeterType);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeterType);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeterType);

                controlBase.InsertHistories();
            }
        }

        private void tabTopics_Click(object sender, EventArgs e)
        {
            if (uCTopicManagement == null)
            {
                uCTopicManagement = new UCTopicManagement();
                uCTopicManagement.Dock = DockStyle.Fill;
                panelTopics.Controls.Add(uCTopicManagement);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Topics);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Topics);

                controlBase.InsertHistories();
            }
            uCTopicManagement.LoadTopics();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void tabUserFunction_Click(object sender, EventArgs e)
        {
            if (uCUserPermission == null)
            {
                uCUserPermission = new UCUserPermission();
                uCUserPermission.Dock = DockStyle.Fill;
                panelUserFunctions.Controls.Add(uCUserPermission);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserFunction);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UserFunction);

                controlBase.InsertHistories();
            }
            uCUserPermission.LoadFunctionGroup();
        }

        private void mnChangeDatabaseConnection_SettingsButtonClick(object sender, EventArgs e)
        {
            DatabaseConfig databaseConfig = new DatabaseConfig();
            databaseConfig.ShowDialog();
        }

        private void mnTopMenu_HelpButtonClick(object sender, EventArgs e)
        {
            SoftwareAbout about = new SoftwareAbout();
            about.ShowDialog();
        }
    }
}