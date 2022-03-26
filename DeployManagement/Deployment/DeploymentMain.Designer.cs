namespace DeployManagement
{
    partial class DeploymentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeploymentMain));
            this.superTabDeployment = new DevComponents.DotNetBar.SuperTabControl();
            this.pnMessageReceive = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabMessageReceive = new DevComponents.DotNetBar.SuperTabItem();
            this.pnMpManagement = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabMpManagement = new DevComponents.DotNetBar.SuperTabItem();
            this.pnDcuManagement = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabDcuManagement = new DevComponents.DotNetBar.SuperTabItem();
            this.pnMeterManagement = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabMeterManagement = new DevComponents.DotNetBar.SuperTabItem();
            this.pnCheckMeasurementPoint = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabCheckMeasurementPoint = new DevComponents.DotNetBar.SuperTabItem();
            this.pnCustomerManagement = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabCustomerManagement = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabDeployment)).BeginInit();
            this.superTabDeployment.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabDeployment
            // 
            this.superTabDeployment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabDeployment.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabDeployment.ControlBox.MenuBox.Name = "";
            this.superTabDeployment.ControlBox.Name = "";
            this.superTabDeployment.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabDeployment.ControlBox.MenuBox,
            this.superTabDeployment.ControlBox.CloseBox});
            this.superTabDeployment.Controls.Add(this.pnDcuManagement);
            this.superTabDeployment.Controls.Add(this.pnCheckMeasurementPoint);
            this.superTabDeployment.Controls.Add(this.pnMessageReceive);
            this.superTabDeployment.Controls.Add(this.pnMpManagement);
            this.superTabDeployment.Controls.Add(this.pnMeterManagement);
            this.superTabDeployment.Controls.Add(this.pnCustomerManagement);
            this.superTabDeployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabDeployment.ForeColor = System.Drawing.Color.Black;
            this.superTabDeployment.Location = new System.Drawing.Point(0, 0);
            this.superTabDeployment.Name = "superTabDeployment";
            this.superTabDeployment.ReorderTabsEnabled = true;
            this.superTabDeployment.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabDeployment.SelectedTabIndex = 5;
            this.superTabDeployment.Size = new System.Drawing.Size(805, 483);
            this.superTabDeployment.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabDeployment.TabIndex = 0;
            this.superTabDeployment.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabCheckMeasurementPoint,
            this.tabMessageReceive,
            this.tabMpManagement,
            this.tabDcuManagement,
            this.tabMeterManagement,
            this.tabCustomerManagement});
            this.superTabDeployment.Text = "superTabControl1";
            // 
            // pnMessageReceive
            // 
            this.pnMessageReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMessageReceive.Location = new System.Drawing.Point(0, 0);
            this.pnMessageReceive.Name = "pnMessageReceive";
            this.pnMessageReceive.Size = new System.Drawing.Size(805, 483);
            this.pnMessageReceive.TabIndex = 0;
            this.pnMessageReceive.TabItem = this.tabMessageReceive;
            // 
            // tabMessageReceive
            // 
            this.tabMessageReceive.AttachedControl = this.pnMessageReceive;
            this.tabMessageReceive.GlobalItem = false;
            this.tabMessageReceive.Name = "tabMessageReceive";
            this.tabMessageReceive.Text = "Nhận bản tin";
            this.tabMessageReceive.Click += new System.EventHandler(this.tabMessageReceive_Click);
            // 
            // pnMpManagement
            // 
            this.pnMpManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMpManagement.Location = new System.Drawing.Point(0, 0);
            this.pnMpManagement.Name = "pnMpManagement";
            this.pnMpManagement.Size = new System.Drawing.Size(805, 483);
            this.pnMpManagement.TabIndex = 0;
            this.pnMpManagement.TabItem = this.tabMpManagement;
            // 
            // tabMpManagement
            // 
            this.tabMpManagement.AttachedControl = this.pnMpManagement;
            this.tabMpManagement.GlobalItem = false;
            this.tabMpManagement.Name = "tabMpManagement";
            this.tabMpManagement.Text = "Quản lý điểm đo";
            this.tabMpManagement.Click += new System.EventHandler(this.tabMpManagement_Click);
            // 
            // pnDcuManagement
            // 
            this.pnDcuManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDcuManagement.Location = new System.Drawing.Point(0, 25);
            this.pnDcuManagement.Name = "pnDcuManagement";
            this.pnDcuManagement.Size = new System.Drawing.Size(805, 458);
            this.pnDcuManagement.TabIndex = 0;
            this.pnDcuManagement.TabItem = this.tabDcuManagement;
            // 
            // tabDcuManagement
            // 
            this.tabDcuManagement.AttachedControl = this.pnDcuManagement;
            this.tabDcuManagement.GlobalItem = false;
            this.tabDcuManagement.Name = "tabDcuManagement";
            this.tabDcuManagement.Text = "Quản lý modem";
            this.tabDcuManagement.Click += new System.EventHandler(this.tabDcuManagement_Click);
            // 
            // pnMeterManagement
            // 
            this.pnMeterManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMeterManagement.Location = new System.Drawing.Point(0, 0);
            this.pnMeterManagement.Name = "pnMeterManagement";
            this.pnMeterManagement.Size = new System.Drawing.Size(805, 483);
            this.pnMeterManagement.TabIndex = 0;
            this.pnMeterManagement.TabItem = this.tabMeterManagement;
            // 
            // tabMeterManagement
            // 
            this.tabMeterManagement.AttachedControl = this.pnMeterManagement;
            this.tabMeterManagement.GlobalItem = false;
            this.tabMeterManagement.Name = "tabMeterManagement";
            this.tabMeterManagement.Text = "Quản lý công tơ";
            this.tabMeterManagement.Click += new System.EventHandler(this.tabMeterManagement_Click);
            // 
            // pnCheckMeasurementPoint
            // 
            this.pnCheckMeasurementPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCheckMeasurementPoint.Location = new System.Drawing.Point(0, 25);
            this.pnCheckMeasurementPoint.Name = "pnCheckMeasurementPoint";
            this.pnCheckMeasurementPoint.Size = new System.Drawing.Size(805, 458);
            this.pnCheckMeasurementPoint.TabIndex = 1;
            this.pnCheckMeasurementPoint.TabItem = this.tabCheckMeasurementPoint;
            // 
            // tabCheckMeasurementPoint
            // 
            this.tabCheckMeasurementPoint.AttachedControl = this.pnCheckMeasurementPoint;
            this.tabCheckMeasurementPoint.GlobalItem = false;
            this.tabCheckMeasurementPoint.Name = "tabCheckMeasurementPoint";
            this.tabCheckMeasurementPoint.Text = "Triển khai";
            this.tabCheckMeasurementPoint.Click += new System.EventHandler(this.tabCheckMeasurementPoint_Click);
            // 
            // pnCustomerManagement
            // 
            this.pnCustomerManagement.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.pnCustomerManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCustomerManagement.Location = new System.Drawing.Point(0, 0);
            this.pnCustomerManagement.Name = "pnCustomerManagement";
            this.pnCustomerManagement.Size = new System.Drawing.Size(805, 483);
            this.pnCustomerManagement.TabIndex = 0;
            this.pnCustomerManagement.TabItem = this.tabCustomerManagement;
            // 
            // tabCustomerManagement
            // 
            this.tabCustomerManagement.AttachedControl = this.pnCustomerManagement;
            this.tabCustomerManagement.GlobalItem = false;
            this.tabCustomerManagement.Name = "tabCustomerManagement";
            this.tabCustomerManagement.Text = "Quản lý khách hàng";
            this.tabCustomerManagement.Click += new System.EventHandler(this.tabCustomerManagement_Click);
            // 
            // DeploymentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageUnderCaption = true;
            this.ClientSize = new System.Drawing.Size(805, 483);
            this.Controls.Add(this.superTabDeployment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeploymentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deploy Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Deploy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabDeployment)).EndInit();
            this.superTabDeployment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabDeployment;
        private DevComponents.DotNetBar.SuperTabControlPanel pnCheckMeasurementPoint;
        private DevComponents.DotNetBar.SuperTabItem tabCheckMeasurementPoint;
        private DevComponents.DotNetBar.SuperTabControlPanel pnCustomerManagement;
        private DevComponents.DotNetBar.SuperTabItem tabCustomerManagement;
        private DevComponents.DotNetBar.SuperTabControlPanel pnMeterManagement;
        private DevComponents.DotNetBar.SuperTabItem tabMeterManagement;
        private DevComponents.DotNetBar.SuperTabControlPanel pnDcuManagement;
        private DevComponents.DotNetBar.SuperTabItem tabDcuManagement;
        private DevComponents.DotNetBar.SuperTabControlPanel pnMpManagement;
        private DevComponents.DotNetBar.SuperTabItem tabMpManagement;
        private DevComponents.DotNetBar.SuperTabControlPanel pnMessageReceive;
        private DevComponents.DotNetBar.SuperTabItem tabMessageReceive;


    }
}

