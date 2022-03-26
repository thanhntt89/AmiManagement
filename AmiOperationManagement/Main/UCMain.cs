using System;
using DevComponents.DotNetBar;
using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Deployment;
using AmiOperationManagement.ErrorManagement;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using System.Windows.Forms;
using OperationDTO.AmiOperationDataSet.SystemConfigDataSetTableAdapters;
using System.Data;

namespace AmiOperationManagement.Main
{
    public partial class UCMain : UserControlBase
    {
        private FunctionCollection functionList = new FunctionCollection();
        private UCStartPanel ucStartPanel;
        private UCCommander uCCommander;
        private UCMeasurementPointManagement uCMeasurementPointManagement;
        private UCDcuManagement uCDcuManagement;
        private UCMeterManagement uCMeterManagement;
        private UCCustomerManagement uCCustomerManagement;
        private UCMeasurementPoitMissingMessage uCMeasurementPoitMissingMessage;
        private UCReporting uCReporting;
        private UCErrorDCU uCErrorDCU;
        private UCFixError uCFixError;
        private UCMeasurementPointLostMessage uCMeasurementPointLostMessage;
        private UCDeployHistories uCDeployHistories;

        private UCMeasurementPointManagementTree uCMeasurementPointManagementTree;

        public UCMain()
        {
            InitializeComponent();
            InitEvent();
        }

        public void ApplicationExit()
        {
            FreeUC();
            if (ucClientConnection != null)
            {
                ucClientConnection.ApplicationExit();
            }
        }

        private void FreeUC()
        {
            // Giải phóng sự kiện nhận bản tin trước khi thoát khỏi chương trình
            if (uCErrorDCU != null && ucClientConnection != null)
            {
                ucClientConnection.RecieveMessageEvent -= uCErrorDCU.GetMessage;
            }

            // Sửa lỗi cho điểm đo
            if (uCMeasurementPointLostMessage != null)
            {
                uCMeasurementPointLostMessage.PublishMessageEvent -= PublisgMessage;
            }

            // Enable chức năng subscribe
            if (uCCommander != null && ucClientConnection != null)
            {
                ucClientConnection.ConnectionStatusEvent -= uCCommander.clientConnection_ConnectStatusEvent;
                ucClientConnection.RecieveMessageEvent -= uCCommander.GetMessage;
                uCCommander.SubscribeMessageEvent -= ucClientConnection.SubscribeMessage;
                uCCommander.UnSubscribeMessageEvent -= ucClientConnection.UnSubcribeMessage;
                uCCommander.PublishMessageEvent -= PublisgMessage;
            }

            uCCommander = null;
            uCMeasurementPointManagement = null;
            uCDcuManagement = null;
            uCMeterManagement = null;
            uCCustomerManagement = null;
            uCMeasurementPoitMissingMessage = null;
            uCReporting = null;
            uCErrorDCU = null;
            uCFixError = null;
            uCMeasurementPointLostMessage = null;
        }

        /// <summary>
        /// Khởi tạo các sự kiện sử dụng chức năng tương tác với modem
        /// </summary>
        private void InitEvent()
        {
            // Enable chức năng subscribe
            if (uCCommander == null)
            {
                uCCommander = new UCCommander();
                ucClientConnection.ConnectionStatusEvent += uCCommander.clientConnection_ConnectStatusEvent;
                ucClientConnection.RecieveMessageEvent += uCCommander.GetMessage;
                uCCommander.SubscribeMessageEvent += ucClientConnection.SubscribeMessage;
                uCCommander.UnSubscribeMessageEvent += ucClientConnection.UnSubcribeMessage;
                uCCommander.PublishMessageEvent += PublisgMessage;
            }

            // Sửa lỗi cho điểm đo
            if (uCMeasurementPointLostMessage == null)
            {
                uCMeasurementPointLostMessage = new UCMeasurementPointLostMessage();
                uCMeasurementPointLostMessage.PublishMessageEvent += PublisgMessage;
            }
        }

        private void LoadFunction()
        {
            btnMeasurementPoitManagement.Enabled = UserSession.UserFunctionList.CheckExist(btnMeasurementPoitManagement.Name);
            btnModemManagement.Enabled = UserSession.UserFunctionList.CheckExist(btnModemManagement.Name);
            btnMeterManagement.Enabled = UserSession.UserFunctionList.CheckExist(btnMeterManagement.Name);
            btnCustomerList.Enabled = UserSession.UserFunctionList.CheckExist(btnCustomerList.Name);

            btnErrorModem.Enabled = UserSession.UserFunctionList.CheckExist(btnErrorModem.Name);
            btnMeasurementPoitMessageError.Enabled = UserSession.UserFunctionList.CheckExist(btnMeasurementPoitMessageError.Name);

            // Menu quản lý lỗi
            btnMissingPE.Enabled = UserSession.UserFunctionList.CheckExist(btnMissingPE.Name);
            btnMissingMessageList.Enabled = UserSession.UserFunctionList.CheckExist(btnMissingMessageList.Name);
            btnMissingMessage.Enabled = UserSession.UserFunctionList.CheckExist(btnMissingMessage.Name);
            btnDeployHistories.Enabled = UserSession.UserFunctionList.CheckExist(btnDeployHistories.Name);

            // Kết nối server
            if (!UserSession.UserFunctionList.CheckExist(mnServerConnect.Name))
                mnServerConnect.Hide();
        }

        private void StartPanel()
        {
            if (ucStartPanel == null)
                ucStartPanel = new UCStartPanel();           
            this.CreateTab(ucStartPanel.Name, ucStartPanel.TitlePage, ucStartPanel);
        }

        private void CreateTab(string fucntionCode, string functionName, UserControlBase userControl)
        {
            var exist = functionList.GetFunctionInfoByFunctionCode(fucntionCode);
            if (exist == null)
            {
                functionList.AddFunction(fucntionCode, functionName, userControl);
            }
            else if (userControl != ucStartPanel)
            {
                Bar b = GetFirstDocumentBar();

                if (b == null)
                    return;

                b.SelectedDockTab = b.Items.IndexOf(fucntionCode);
                ucStartPanel = null;
                return;
            }

            userControl.IsReceiveData = true;

            DockContainerItem document = new DockContainerItem(fucntionCode, functionName);
            // Create control to host inside of new document
            document.Control = userControl;

            if (ucStartPanel != null)
            {
                document.CanClose = document.Name.Equals(ucStartPanel.Name) ? eDockContainerClose.No : eDockContainerClose.Yes;
                if (document.Name.Equals(ucStartPanel.Name))
                    ucStartPanel.Start();
            }

            Bar bar = GetFirstDocumentBar();
            if (bar == null)
                return;

            bar.Items.Add(document);
            if (!bar.Visible)
                bar.Visible = true;

            bar.SelectedDockTab = bar.Items.IndexOf(document);
            bar.RecalcLayout();

            //Close Trang chủ
            if (ucStartPanel != null)
            {
                if (!document.Name.Equals(ucStartPanel.Name))
                {
                    ucStartPanel.Stop();
                    int index = bar.Items.IndexOf(ucStartPanel.Name);
                    if (index != -1)
                        bar.Items.RemoveAt(index);
                    this.functionList.RemoveItem(ucStartPanel.Name);

                    ucStartPanel = null;
                }               
            }
        }

        private Bar GetFirstDocumentBar()
        {
            foreach (Bar b in dotNetBarManager.Bars)
            {
                if (b.DockSide == eDockSide.Document && b.Visible)
                {
                    return b;
                }
            }

            if (dockDisplayMain == null)
                return null;

            Bar bar = BarUtilities.CreateDocumentBar();
            bar.TabNavigation = true;
            dockDisplayMain.GetDocumentUIManager().Dock(bar);

            return bar;
        }

        public void DisplayModemController()
        {
            if (uCCommander != null)
            {
                CreateTab(Constant.MENU_MODEM_COMMANDER_CODE, Constant.MENU_MODEM_COMMANDER_TEXT, uCCommander);
            }

            uCCommander.LoadSubScribeTopics();
        }

        public void ShowMenuByMenuIndex(int menuIndex)
        {
            switch (menuIndex)
            {
                case Constant.MENU_DEPLOY_INDEX:
                    btnDeploy.Checked = true;
                    break;
                case Constant.MENU_OPERATION_INDEX:
                    btnOperation.Checked = true;
                    break;
                case Constant.MENU_ERROR_INDEX:
                    btnErrorManagement.Checked = true;
                    break;
                case Constant.MENU_REPORT_INDEX:
                    btnReport.Checked = true;
                    break;
                default:
                    break;
            }

        }

        private void PublisgMessage(string topic, byte[] payload)
        {
            this.ucClientConnection.PublishMessage(topic, payload);
        }

        private void btnMeasurementPoitManagement_Click(object sender, EventArgs e)
        {
            if (uCMeasurementPointManagementTree == null)
            {
                uCMeasurementPointManagementTree = new UCMeasurementPointManagementTree();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UpdateMeasurementPoitInfo);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_UpdateMeasurementPoitInfo);
                this.InsertHistories();
            }

            CreateTab(btnMeasurementPoitManagement.Name, btnMeasurementPoitManagement.Text, uCMeasurementPointManagementTree);
        }

        private void btnModemManagement_Click(object sender, EventArgs e)
        {
            if (uCDcuManagement == null)
            {
                uCDcuManagement = new UCDcuManagement();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(btnModemManagement.Name);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(btnModemManagement.Name);
                this.InsertHistories();
            }

            CreateTab(btnModemManagement.Name, btnModemManagement.Text, uCDcuManagement);
        }

        private void btnMeterManagement_Click(object sender, EventArgs e)
        {
            if (uCMeterManagement == null)
            {
                uCMeterManagement = new UCMeterManagement();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeterType);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeterType);
                this.InsertHistories();
            }

            CreateTab(btnMeterManagement.Name, btnMeterManagement.Text, uCMeterManagement);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            if (uCCustomerManagement == null)
            {
                uCCustomerManagement = new UCCustomerManagement();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                this.InsertHistories();
            }

            CreateTab(btnCustomerList.Name, btnCustomerList.Text, uCCustomerManagement);
        }

        private void btnErrorModem_Click(object sender, EventArgs e)
        {
            if (uCErrorDCU == null)
            {
                uCErrorDCU = new UCErrorDCU();
                ucClientConnection.RecieveMessageEvent += uCErrorDCU.GetMessage;
                uCErrorDCU.PublishMessageEvent += PublisgMessage;

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorModem);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorModem);
                this.InsertHistories();
            }
            CreateTab(btnErrorModem.Name, btnErrorModem.Text, uCErrorDCU);
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            this.LoadFunction();
            this.StartPanel();
        }

        private void btnMeasurementPoitMessageError_Click(object sender, EventArgs e)
        {
            if (uCMeasurementPointLostMessage == null)
            {
                uCMeasurementPointLostMessage = new UCMeasurementPointLostMessage();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_GetLostMessage);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_GetLostMessage);
                this.InsertHistories();
            }

            CreateTab(btnMeasurementPoitMessageError.Name, btnMeasurementPoitMessageError.Text, uCMeasurementPointLostMessage);
        }

        private void btnMeasurementPoitMissingMessage_Click(object sender, EventArgs e)
        {
            if (uCReporting == null)
            {
                uCReporting = new UCReporting();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessage);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessage);
                this.InsertHistories();
            }

            CreateTab(btnMeasurementPoitMissingMessage.Name, btnMeasurementPoitMissingMessage.Text, uCReporting);
        }

        private void btnMissingPE_Click(object sender, EventArgs e)
        {
            if (uCFixError == null)
            {
                uCFixError = new UCFixError();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingPE);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingPE);
                this.InsertHistories();
            }

            CreateTab(btnMissingPE.Name, btnMissingPE.Text, uCFixError);
        }

        private void dotNetBarManager_BarClosing(object sender, BarClosingEventArgs e)
        {
            string item = ((Bar)sender).Name;

            foreach (Bar b in dotNetBarManager.Bars)
            {
                if (b.DockSide == eDockSide.Document && b.Visible)
                {
                    b.TabNavigation = true;
                }
            }

            MemoryManagement.MinimizeMemory();
        }

        private void dotNetBarManager_DockTabClosing(object sender, DockTabClosingEventArgs e)
        {
            this.functionList.RemoveItem(e.DockContainerItem.Name);
            if (this.functionList.FunctionList.Count == 0)
                this.StartPanel();
        }

        private void dotNetBarManager_BarDock(object sender, EventArgs e)
        {
            ((Bar)sender).TabNavigation = true;
        }

        private void btnMissingMessageList_Click(object sender, EventArgs e)
        {
            if (uCMeasurementPoitMissingMessage == null)
            {
                uCMeasurementPoitMissingMessage = new UCMeasurementPoitMissingMessage();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessageList);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessageList);
                this.InsertHistories();
            }
            CreateTab(btnMissingMessageList.Name, btnMissingMessageList.Text, uCMeasurementPoitMissingMessage);
        }

        private void btnMissingMessage_Click(object sender, EventArgs e)
        {
            if (uCReporting == null)
            {
                uCReporting = new UCReporting();
                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessage);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingMessage);
                this.InsertHistories();
            }

            CreateTab(btnMissingMessage.Name, btnMissingMessage.Text, uCReporting);
        }

        private void btnDeployHistories_Click(object sender, EventArgs e)
        {

            if (uCDeployHistories == null)
            {
                uCDeployHistories = new UCDeployHistories();
                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DeployHistories);
                UserSession.Action = SystemResource.User_Action_View;
                UserSession.Notes = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_DeployHistories);
                this.InsertHistories();
            }

            CreateTab(btnDeployHistories.Name, btnDeployHistories.Text, uCDeployHistories);
        }
    }
}
