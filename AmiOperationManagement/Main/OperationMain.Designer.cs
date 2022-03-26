namespace AmiOperationManagement
{
    partial class OperationMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationMain));
            this.mnTopMenu = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel5 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.mnSystem = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.superTabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.panelServer = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabServer = new DevComponents.DotNetBar.SuperTabItem();
            this.panelMeterType = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabMeterType = new DevComponents.DotNetBar.SuperTabItem();
            this.panErrorDefine = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabErrorDefine = new DevComponents.DotNetBar.SuperTabItem();
            this.panelTopics = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabTopics = new DevComponents.DotNetBar.SuperTabItem();
            this.panelSystemConfig = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabSystemConfig = new DevComponents.DotNetBar.SuperTabItem();
            this.panelUserManagement = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabUserManagement = new DevComponents.DotNetBar.SuperTabItem();
            this.panelSystemHistories = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabSystemHistories = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.tabChangePassword = new DevComponents.DotNetBar.SuperTabItem();
            this.panelUserFunctions = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabUserFunction = new DevComponents.DotNetBar.SuperTabItem();
            this.panelSoftwareVersion = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabSoftwareVersion = new DevComponents.DotNetBar.SuperTabItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.mnDcuController = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mnDeployment = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mnOperation = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.lblUserName = new DevComponents.DotNetBar.LabelItem();
            this.ucMain = new AmiOperationManagement.Main.UCMain();
            this.mnTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).BeginInit();
            this.superTabControl.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnTopMenu
            // 
            this.mnTopMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.mnTopMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mnTopMenu.CaptionVisible = true;
            this.mnTopMenu.Controls.Add(this.metroTabPanel5);
            this.mnTopMenu.Controls.Add(this.metroTabPanel1);
            this.mnTopMenu.Controls.Add(this.metroTabPanel2);
            this.mnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnTopMenu.ForeColor = System.Drawing.Color.Black;
            this.mnTopMenu.HelpButtonText = "Trợ giúp";
            this.mnTopMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnSystem,
            this.mnDcuController,
            this.mnDeployment,
            this.mnOperation});
            this.mnTopMenu.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.mnTopMenu.Location = new System.Drawing.Point(1, 1);
            this.mnTopMenu.Name = "mnTopMenu";
            this.mnTopMenu.SettingsButtonText = "Cấu hình";
            this.mnTopMenu.Size = new System.Drawing.Size(1015, 53);
            this.mnTopMenu.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.mnTopMenu.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.mnTopMenu.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.mnTopMenu.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.mnTopMenu.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.mnTopMenu.SystemText.QatDialogAddButton = "&Add >>";
            this.mnTopMenu.SystemText.QatDialogCancelButton = "Cancel";
            this.mnTopMenu.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.mnTopMenu.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.mnTopMenu.SystemText.QatDialogOkButton = "OK";
            this.mnTopMenu.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.mnTopMenu.SystemText.QatDialogRemoveButton = "&Remove";
            this.mnTopMenu.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.mnTopMenu.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.mnTopMenu.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.mnTopMenu.TabIndex = 0;
            this.mnTopMenu.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnTopMenu.SettingsButtonClick += new System.EventHandler(this.mnChangeDatabaseConnection_SettingsButtonClick);
            this.mnTopMenu.HelpButtonClick += new System.EventHandler(this.mnTopMenu_HelpButtonClick);
            // 
            // metroTabPanel5
            // 
            this.metroTabPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel5.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel5.Name = "metroTabPanel5";
            this.metroTabPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel5.Size = new System.Drawing.Size(1015, 2);
            // 
            // 
            // 
            this.metroTabPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel5.TabIndex = 5;
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(1015, 2);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(1015, 2);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            this.metroTabPanel1.Visible = false;
            // 
            // mnSystem
            // 
            this.mnSystem.AutoExpandOnClick = true;
            this.mnSystem.BackstageTab = this.superTabControl;
            this.mnSystem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.TextOnlyAlways;
            this.mnSystem.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.mnSystem.ImagePaddingHorizontal = 0;
            this.mnSystem.ImagePaddingVertical = 0;
            this.mnSystem.Name = "mnSystem";
            this.mnSystem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.mnSystem.ShowSubItems = false;
            this.mnSystem.Text = "HỆ THỐNG";
            // 
            // superTabControl
            // 
            this.superTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl.ControlBox.MenuBox.Name = "";
            this.superTabControl.ControlBox.Name = "";
            this.superTabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl.ControlBox.MenuBox,
            this.superTabControl.ControlBox.CloseBox});
            this.superTabControl.ControlBox.Visible = false;
            this.superTabControl.Controls.Add(this.superTabControlPanel1);
            this.superTabControl.Controls.Add(this.panelServer);
            this.superTabControl.Controls.Add(this.panelMeterType);
            this.superTabControl.Controls.Add(this.panErrorDefine);
            this.superTabControl.Controls.Add(this.panelTopics);
            this.superTabControl.Controls.Add(this.panelSystemConfig);
            this.superTabControl.Controls.Add(this.panelUserManagement);
            this.superTabControl.Controls.Add(this.panelSystemHistories);
            this.superTabControl.Controls.Add(this.panelUserFunctions);
            this.superTabControl.Controls.Add(this.panelSoftwareVersion);
            this.superTabControl.ForeColor = System.Drawing.Color.Black;
            this.superTabControl.ItemPadding.Left = 6;
            this.superTabControl.ItemPadding.Right = 4;
            this.superTabControl.ItemPadding.Top = 4;
            this.superTabControl.Location = new System.Drawing.Point(1, 52);
            this.superTabControl.Name = "superTabControl";
            this.superTabControl.ReorderTabsEnabled = false;
            this.superTabControl.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.superTabControl.SelectedTabIndex = -1;
            this.superTabControl.Size = new System.Drawing.Size(1015, 477);
            this.superTabControl.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl.TabHorizontalSpacing = 16;
            this.superTabControl.TabIndex = 3;
            this.superTabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabChangePassword,
            this.tabSystemHistories,
            this.tabUserManagement,
            this.tabUserFunction,
            this.tabSystemConfig,
            this.tabTopics,
            this.tabErrorDefine,
            this.tabMeterType,
            this.tabServer,
            this.tabSoftwareVersion,
            this.btnExit});
            this.superTabControl.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl.TabVerticalSpacing = 8;
            // 
            // panelServer
            // 
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServer.Location = new System.Drawing.Point(236, 0);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(779, 477);
            this.panelServer.TabIndex = 0;
            this.panelServer.TabItem = this.tabServer;
            // 
            // tabServer
            // 
            this.tabServer.AttachedControl = this.panelServer;
            this.tabServer.GlobalItem = false;
            this.tabServer.Image = ((System.Drawing.Image)(resources.GetObject("tabServer.Image")));
            this.tabServer.Name = "tabServer";
            this.tabServer.Text = "Quản lý server";
            this.tabServer.Click += new System.EventHandler(this.tabServer_Click);
            // 
            // panelMeterType
            // 
            this.panelMeterType.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMeterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMeterType.Location = new System.Drawing.Point(236, 0);
            this.panelMeterType.Name = "panelMeterType";
            this.panelMeterType.Size = new System.Drawing.Size(779, 477);
            this.panelMeterType.TabIndex = 0;
            this.panelMeterType.TabItem = this.tabMeterType;
            // 
            // tabMeterType
            // 
            this.tabMeterType.AttachedControl = this.panelMeterType;
            this.tabMeterType.GlobalItem = false;
            this.tabMeterType.Image = ((System.Drawing.Image)(resources.GetObject("tabMeterType.Image")));
            this.tabMeterType.Name = "tabMeterType";
            this.tabMeterType.Text = "Loại công tơ";
            this.tabMeterType.Click += new System.EventHandler(this.tabMeterType_Click);
            // 
            // panErrorDefine
            // 
            this.panErrorDefine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panErrorDefine.Location = new System.Drawing.Point(236, 0);
            this.panErrorDefine.Name = "panErrorDefine";
            this.panErrorDefine.Size = new System.Drawing.Size(779, 477);
            this.panErrorDefine.TabIndex = 0;
            this.panErrorDefine.TabItem = this.tabErrorDefine;
            // 
            // tabErrorDefine
            // 
            this.tabErrorDefine.AttachedControl = this.panErrorDefine;
            this.tabErrorDefine.GlobalItem = false;
            this.tabErrorDefine.Image = ((System.Drawing.Image)(resources.GetObject("tabErrorDefine.Image")));
            this.tabErrorDefine.Name = "tabErrorDefine";
            this.tabErrorDefine.Text = "Định nghĩa lỗi";
            this.tabErrorDefine.Click += new System.EventHandler(this.tabErrorDefine_Click);
            // 
            // panelTopics
            // 
            this.panelTopics.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopics.Location = new System.Drawing.Point(236, 0);
            this.panelTopics.Name = "panelTopics";
            this.panelTopics.Size = new System.Drawing.Size(779, 477);
            this.panelTopics.TabIndex = 0;
            this.panelTopics.TabItem = this.tabTopics;
            // 
            // tabTopics
            // 
            this.tabTopics.AttachedControl = this.panelTopics;
            this.tabTopics.GlobalItem = false;
            this.tabTopics.Image = ((System.Drawing.Image)(resources.GetObject("tabTopics.Image")));
            this.tabTopics.Name = "tabTopics";
            this.tabTopics.Text = "Quản lý bản tin";
            this.tabTopics.Click += new System.EventHandler(this.tabTopics_Click);
            // 
            // panelSystemConfig
            // 
            this.panelSystemConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSystemConfig.Location = new System.Drawing.Point(236, 0);
            this.panelSystemConfig.Name = "panelSystemConfig";
            this.panelSystemConfig.Size = new System.Drawing.Size(779, 477);
            this.panelSystemConfig.TabIndex = 0;
            this.panelSystemConfig.TabItem = this.tabSystemConfig;
            // 
            // tabSystemConfig
            // 
            this.tabSystemConfig.AttachedControl = this.panelSystemConfig;
            this.tabSystemConfig.GlobalItem = false;
            this.tabSystemConfig.Image = ((System.Drawing.Image)(resources.GetObject("tabSystemConfig.Image")));
            this.tabSystemConfig.Name = "tabSystemConfig";
            this.tabSystemConfig.Text = "Cấu hình hệ thống";
            this.tabSystemConfig.Click += new System.EventHandler(this.tabSystemConfig_Click);
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserManagement.Location = new System.Drawing.Point(236, 0);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(779, 477);
            this.panelUserManagement.TabIndex = 0;
            this.panelUserManagement.TabItem = this.tabUserManagement;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.AttachedControl = this.panelUserManagement;
            this.tabUserManagement.GlobalItem = false;
            this.tabUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("tabUserManagement.Image")));
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Text = "Quản lý người dùng";
            this.tabUserManagement.Click += new System.EventHandler(this.tabUserManagement_Click);
            // 
            // panelSystemHistories
            // 
            this.panelSystemHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSystemHistories.Location = new System.Drawing.Point(236, 0);
            this.panelSystemHistories.Name = "panelSystemHistories";
            this.panelSystemHistories.Size = new System.Drawing.Size(779, 477);
            this.panelSystemHistories.TabIndex = 0;
            this.panelSystemHistories.TabItem = this.tabSystemHistories;
            // 
            // tabSystemHistories
            // 
            this.tabSystemHistories.AttachedControl = this.panelSystemHistories;
            this.tabSystemHistories.GlobalItem = false;
            this.tabSystemHistories.Image = ((System.Drawing.Image)(resources.GetObject("tabSystemHistories.Image")));
            this.tabSystemHistories.Name = "tabSystemHistories";
            this.tabSystemHistories.Text = "Lịch sử hệ thống";
            this.tabSystemHistories.Click += new System.EventHandler(this.tabSystemHistories_Click);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.superTabControlPanel1.Controls.Add(this.reflectionImage1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(236, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(779, 477);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.tabChangePassword;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(0, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(779, 477);
            this.reflectionImage1.TabIndex = 0;
            // 
            // tabChangePassword
            // 
            this.tabChangePassword.AttachedControl = this.superTabControlPanel1;
            this.tabChangePassword.GlobalItem = false;
            this.tabChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tabChangePassword.Image")));
            this.tabChangePassword.Name = "tabChangePassword";
            this.tabChangePassword.Text = "Đổi mật khẩu";
            this.tabChangePassword.Click += new System.EventHandler(this.tabChangePassword_Click);
            // 
            // panelUserFunctions
            // 
            this.panelUserFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserFunctions.Location = new System.Drawing.Point(236, 0);
            this.panelUserFunctions.Name = "panelUserFunctions";
            this.panelUserFunctions.Size = new System.Drawing.Size(779, 477);
            this.panelUserFunctions.TabIndex = 0;
            this.panelUserFunctions.TabItem = this.tabUserFunction;
            // 
            // tabUserFunction
            // 
            this.tabUserFunction.AttachedControl = this.panelUserFunctions;
            this.tabUserFunction.GlobalItem = false;
            this.tabUserFunction.Image = ((System.Drawing.Image)(resources.GetObject("tabUserFunction.Image")));
            this.tabUserFunction.Name = "tabUserFunction";
            this.tabUserFunction.Text = "Quản lý phân quyền";
            this.tabUserFunction.Click += new System.EventHandler(this.tabUserFunction_Click);
            // 
            // panelSoftwareVersion
            // 
            this.panelSoftwareVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoftwareVersion.Location = new System.Drawing.Point(236, 0);
            this.panelSoftwareVersion.Name = "panelSoftwareVersion";
            this.panelSoftwareVersion.Size = new System.Drawing.Size(779, 477);
            this.panelSoftwareVersion.TabIndex = 0;
            this.panelSoftwareVersion.TabItem = this.tabSoftwareVersion;
            // 
            // tabSoftwareVersion
            // 
            this.tabSoftwareVersion.AttachedControl = this.panelSoftwareVersion;
            this.tabSoftwareVersion.GlobalItem = false;
            this.tabSoftwareVersion.Image = ((System.Drawing.Image)(resources.GetObject("tabSoftwareVersion.Image")));
            this.tabSoftwareVersion.Name = "tabSoftwareVersion";
            this.tabSoftwareVersion.Text = "Phiên bản phần mềm";
            this.tabSoftwareVersion.Click += new System.EventHandler(this.tabSoftwareVersion_Click);
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImagePaddingHorizontal = 18;
            this.btnExit.ImagePaddingVertical = 10;
            this.btnExit.KeyTips = "X";
            this.btnExit.Name = "btnExit";
            this.btnExit.Stretch = true;
            this.btnExit.Text = "Thoát chương trình";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnDcuController
            // 
            this.mnDcuController.Checked = true;
            this.mnDcuController.Name = "mnDcuController";
            this.mnDcuController.Panel = this.metroTabPanel5;
            this.mnDcuController.Text = "ĐIỀU KHIỂN MODEM";
            this.mnDcuController.Click += new System.EventHandler(this.mnDcuController_Click);
            // 
            // mnDeployment
            // 
            this.mnDeployment.Name = "mnDeployment";
            this.mnDeployment.Panel = this.metroTabPanel1;
            this.mnDeployment.Text = "&TRIỂN KHAI";
            this.mnDeployment.Click += new System.EventHandler(this.mnDeployment_Click);
            // 
            // mnOperation
            // 
            this.mnOperation.Name = "mnOperation";
            this.mnOperation.Panel = this.metroTabPanel2;
            this.mnOperation.Text = "&VẬN HÀNH";
            this.mnOperation.Click += new System.EventHandler(this.mnOperation_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.SystemColors.ControlLightLight, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.lblUserName});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 504);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(1015, 25);
            this.metroStatusBar1.TabIndex = 1;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Người dùng:";
            // 
            // lblUserName
            // 
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Text = "...";
            // 
            // ucMain
            // 
            this.ucMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMain.ForeColor = System.Drawing.Color.Black;
            this.ucMain.Location = new System.Drawing.Point(1, 54);
            this.ucMain.Name = "ucMain";
            this.ucMain.Size = new System.Drawing.Size(1015, 450);
            this.ucMain.TabIndex = 4;
            // 
            // OperationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1017, 530);
            this.Controls.Add(this.superTabControl);
            this.Controls.Add(this.ucMain);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.mnTopMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ VẬN HÀNH HỆ THỐNG ĐO XA SAO VIỆT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationMain_FormClosing);
            this.Load += new System.EventHandler(this.OperationMain_Load);
            this.mnTopMenu.ResumeLayout(false);
            this.mnTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).EndInit();
            this.superTabControl.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell mnTopMenu;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabItem mnDeployment;
        private DevComponents.DotNetBar.Metro.MetroTabItem mnOperation;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Metro.MetroAppButton mnSystem;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel5;
        private DevComponents.DotNetBar.Metro.MetroTabItem mnDcuController;
        private DevComponents.DotNetBar.SuperTabControl superTabControl;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private Main.UCMain ucMain;
        private DevComponents.DotNetBar.SuperTabControlPanel panelUserManagement;
        private DevComponents.DotNetBar.SuperTabItem tabUserManagement;
        private DevComponents.DotNetBar.SuperTabControlPanel panelUserFunctions;
        private DevComponents.DotNetBar.SuperTabItem tabUserFunction;
        private DevComponents.DotNetBar.SuperTabControlPanel panelSystemConfig;
        private DevComponents.DotNetBar.SuperTabItem tabSystemConfig;
        private DevComponents.DotNetBar.SuperTabControlPanel panelSystemHistories;
        private DevComponents.DotNetBar.SuperTabItem tabSystemHistories;
        private DevComponents.DotNetBar.SuperTabControlPanel panErrorDefine;
        private DevComponents.DotNetBar.SuperTabItem tabErrorDefine;
        private DevComponents.DotNetBar.SuperTabControlPanel panelSoftwareVersion;
        private DevComponents.DotNetBar.SuperTabItem tabSoftwareVersion;
        private DevComponents.DotNetBar.SuperTabControlPanel panelServer;
        private DevComponents.DotNetBar.SuperTabItem tabServer;
        private DevComponents.DotNetBar.SuperTabControlPanel panelMeterType;
        private DevComponents.DotNetBar.SuperTabItem tabMeterType;
        private DevComponents.DotNetBar.SuperTabControlPanel panelTopics;
        private DevComponents.DotNetBar.SuperTabItem tabTopics;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabChangePassword;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelItem lblUserName;

    }
}

