namespace DeployManagement.Operation
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.superTabOperation = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabSystemInfor = new DevComponents.DotNetBar.SuperTabControl();
            this.pnServer = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.subtabServer = new DevComponents.DotNetBar.SuperTabItem();
            this.pnTopic = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.subtabTopicManangement = new DevComponents.DotNetBar.SuperTabItem();
            this.pnFirmware = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.subtabFirmware = new DevComponents.DotNetBar.SuperTabItem();
            this.pnMeterType = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.subtabMeterType = new DevComponents.DotNetBar.SuperTabItem();
            this.tabSystemInfor = new DevComponents.DotNetBar.SuperTabItem();
            this.pnErrorDCU = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabFailModem = new DevComponents.DotNetBar.SuperTabItem();
            this.pnControlDCU = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabControlDCU = new DevComponents.DotNetBar.SuperTabItem();
            this.pnGetLostMessage = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabGetLostMessage = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.superTabOperation)).BeginInit();
            this.superTabOperation.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabSystemInfor)).BeginInit();
            this.superTabSystemInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            // 
            // superTabOperation
            // 
            this.superTabOperation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabOperation.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabOperation.ControlBox.MenuBox.Name = "";
            this.superTabOperation.ControlBox.Name = "";
            this.superTabOperation.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabOperation.ControlBox.MenuBox,
            this.superTabOperation.ControlBox.CloseBox});
            this.superTabOperation.Controls.Add(this.superTabControlPanel2);
            this.superTabOperation.Controls.Add(this.pnErrorDCU);
            this.superTabOperation.Controls.Add(this.pnControlDCU);
            this.superTabOperation.Controls.Add(this.pnGetLostMessage);
            this.superTabOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabOperation.ForeColor = System.Drawing.Color.Black;
            this.superTabOperation.Location = new System.Drawing.Point(0, 0);
            this.superTabOperation.Name = "superTabOperation";
            this.superTabOperation.ReorderTabsEnabled = true;
            this.superTabOperation.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabOperation.SelectedTabIndex = 2;
            this.superTabOperation.Size = new System.Drawing.Size(635, 420);
            this.superTabOperation.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabOperation.TabIndex = 0;
            this.superTabOperation.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabFailModem,
            this.tabGetLostMessage,
            this.tabControlDCU,
            this.tabSystemInfor});
            this.superTabOperation.Text = "superTabControl1";
            this.superTabOperation.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.superTabOperation_SelectedTabChanged);
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.superTabSystemInfor);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 27);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(635, 393);
            this.superTabControlPanel2.TabIndex = 1;
            this.superTabControlPanel2.TabItem = this.tabSystemInfor;
            // 
            // superTabSystemInfor
            // 
            this.superTabSystemInfor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabSystemInfor.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabSystemInfor.ControlBox.MenuBox.Name = "";
            this.superTabSystemInfor.ControlBox.Name = "";
            this.superTabSystemInfor.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabSystemInfor.ControlBox.MenuBox,
            this.superTabSystemInfor.ControlBox.CloseBox});
            this.superTabSystemInfor.Controls.Add(this.pnServer);
            this.superTabSystemInfor.Controls.Add(this.pnTopic);
            this.superTabSystemInfor.Controls.Add(this.pnFirmware);
            this.superTabSystemInfor.Controls.Add(this.pnMeterType);
            this.superTabSystemInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabSystemInfor.ForeColor = System.Drawing.Color.Black;
            this.superTabSystemInfor.Location = new System.Drawing.Point(0, 0);
            this.superTabSystemInfor.Name = "superTabSystemInfor";
            this.superTabSystemInfor.ReorderTabsEnabled = true;
            this.superTabSystemInfor.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabSystemInfor.SelectedTabIndex = 1;
            this.superTabSystemInfor.Size = new System.Drawing.Size(635, 393);
            this.superTabSystemInfor.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabSystemInfor.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabSystemInfor.TabIndex = 0;
            this.superTabSystemInfor.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.subtabMeterType,
            this.subtabFirmware,
            this.subtabTopicManangement,
            this.subtabServer});
            this.superTabSystemInfor.Text = "superTabControl1";
            // 
            // pnServer
            // 
            this.pnServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnServer.Location = new System.Drawing.Point(85, 0);
            this.pnServer.Name = "pnServer";
            this.pnServer.Size = new System.Drawing.Size(550, 393);
            this.pnServer.TabIndex = 4;
            this.pnServer.TabItem = this.subtabServer;
            // 
            // subtabServer
            // 
            this.subtabServer.AttachedControl = this.pnServer;
            this.subtabServer.GlobalItem = false;
            this.subtabServer.Name = "subtabServer";
            this.subtabServer.Text = "Server";
            this.subtabServer.Click += new System.EventHandler(this.subtabServer_Click);
            // 
            // pnTopic
            // 
            this.pnTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTopic.Location = new System.Drawing.Point(89, 0);
            this.pnTopic.Name = "pnTopic";
            this.pnTopic.Size = new System.Drawing.Size(546, 393);
            this.pnTopic.TabIndex = 3;
            this.pnTopic.TabItem = this.subtabTopicManangement;
            // 
            // subtabTopicManangement
            // 
            this.subtabTopicManangement.AttachedControl = this.pnTopic;
            this.subtabTopicManangement.GlobalItem = false;
            this.subtabTopicManangement.Name = "subtabTopicManangement";
            this.subtabTopicManangement.Text = "Quản lý topic";
            this.subtabTopicManangement.Click += new System.EventHandler(this.subtabTopicManangement_Click);
            // 
            // pnFirmware
            // 
            this.pnFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFirmware.Location = new System.Drawing.Point(85, 0);
            this.pnFirmware.Name = "pnFirmware";
            this.pnFirmware.Size = new System.Drawing.Size(550, 393);
            this.pnFirmware.TabIndex = 2;
            this.pnFirmware.TabItem = this.subtabFirmware;
            // 
            // subtabFirmware
            // 
            this.subtabFirmware.AttachedControl = this.pnFirmware;
            this.subtabFirmware.GlobalItem = false;
            this.subtabFirmware.Name = "subtabFirmware";
            this.subtabFirmware.Text = "Firmware";
            this.subtabFirmware.Click += new System.EventHandler(this.subtabFirmware_Click);
            // 
            // pnMeterType
            // 
            this.pnMeterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMeterType.Location = new System.Drawing.Point(85, 0);
            this.pnMeterType.Name = "pnMeterType";
            this.pnMeterType.Size = new System.Drawing.Size(550, 393);
            this.pnMeterType.TabIndex = 1;
            this.pnMeterType.TabItem = this.subtabMeterType;
            // 
            // subtabMeterType
            // 
            this.subtabMeterType.AttachedControl = this.pnMeterType;
            this.subtabMeterType.GlobalItem = false;
            this.subtabMeterType.Name = "subtabMeterType";
            this.subtabMeterType.Text = "Loại công tơ";
            this.subtabMeterType.Click += new System.EventHandler(this.subtabMeterType_Click);
            // 
            // tabSystemInfor
            // 
            this.tabSystemInfor.AttachedControl = this.superTabControlPanel2;
            this.tabSystemInfor.GlobalItem = false;
            this.tabSystemInfor.Name = "tabSystemInfor";
            this.tabSystemInfor.Text = "Thông tin hệ thống";
            // 
            // pnErrorDCU
            // 
            this.pnErrorDCU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnErrorDCU.Location = new System.Drawing.Point(0, 27);
            this.pnErrorDCU.Name = "pnErrorDCU";
            this.pnErrorDCU.Size = new System.Drawing.Size(635, 393);
            this.pnErrorDCU.TabIndex = 0;
            this.pnErrorDCU.TabItem = this.tabFailModem;
            // 
            // tabFailModem
            // 
            this.tabFailModem.AttachedControl = this.pnErrorDCU;
            this.tabFailModem.GlobalItem = false;
            this.tabFailModem.Name = "tabFailModem";
            this.tabFailModem.Text = "Thiết bị lỗi";
            this.tabFailModem.Click += new System.EventHandler(this.tabFailModem_Click_1);
            // 
            // pnControlDCU
            // 
            this.pnControlDCU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlDCU.Location = new System.Drawing.Point(0, 0);
            this.pnControlDCU.Name = "pnControlDCU";
            this.pnControlDCU.Size = new System.Drawing.Size(635, 420);
            this.pnControlDCU.TabIndex = 0;
            this.pnControlDCU.TabItem = this.tabControlDCU;
            // 
            // tabControlDCU
            // 
            this.tabControlDCU.AttachedControl = this.pnControlDCU;
            this.tabControlDCU.GlobalItem = false;
            this.tabControlDCU.Name = "tabControlDCU";
            this.tabControlDCU.Text = "Điều khiển DCU";
            this.tabControlDCU.Click += new System.EventHandler(this.tabControlDCU_Click);
            // 
            // pnGetLostMessage
            // 
            this.pnGetLostMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGetLostMessage.Location = new System.Drawing.Point(0, 0);
            this.pnGetLostMessage.Name = "pnGetLostMessage";
            this.pnGetLostMessage.Size = new System.Drawing.Size(635, 420);
            this.pnGetLostMessage.TabIndex = 0;
            this.pnGetLostMessage.TabItem = this.tabGetLostMessage;
            // 
            // tabGetLostMessage
            // 
            this.tabGetLostMessage.AttachedControl = this.pnGetLostMessage;
            this.tabGetLostMessage.GlobalItem = false;
            this.tabGetLostMessage.Name = "tabGetLostMessage";
            this.tabGetLostMessage.Text = "Lấy bản tin";
            this.tabGetLostMessage.Click += new System.EventHandler(this.tabGetLostMessage_Click);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "superTabItem1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(635, 393);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // OperationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 420);
            this.Controls.Add(this.superTabOperation);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.superTabOperation)).EndInit();
            this.superTabOperation.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabSystemInfor)).EndInit();
            this.superTabSystemInfor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.SuperTabControl superTabOperation;
        private DevComponents.DotNetBar.SuperTabControlPanel pnGetLostMessage;
        private DevComponents.DotNetBar.SuperTabItem tabGetLostMessage;
        private DevComponents.DotNetBar.SuperTabControlPanel pnErrorDCU;
        private DevComponents.DotNetBar.SuperTabItem tabFailModem;
        private DevComponents.DotNetBar.SuperTabControlPanel pnControlDCU;
        private DevComponents.DotNetBar.SuperTabItem tabControlDCU;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabSystemInfor;
        private DevComponents.DotNetBar.SuperTabControl superTabSystemInfor;
        private DevComponents.DotNetBar.SuperTabControlPanel pnMeterType;
        private DevComponents.DotNetBar.SuperTabItem subtabMeterType;
        private DevComponents.DotNetBar.SuperTabControlPanel pnServer;
        private DevComponents.DotNetBar.SuperTabItem subtabServer;
        private DevComponents.DotNetBar.SuperTabControlPanel pnTopic;
        private DevComponents.DotNetBar.SuperTabItem subtabTopicManangement;
        private DevComponents.DotNetBar.SuperTabControlPanel pnFirmware;
        private DevComponents.DotNetBar.SuperTabItem subtabFirmware;
    }
}