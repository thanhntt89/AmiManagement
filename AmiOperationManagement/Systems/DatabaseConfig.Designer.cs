namespace AmiOperationManagement.Systems
{
    partial class DatabaseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfig));
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.chkConfirmAdmin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatabaseAdmin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPasswordAdmin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserAdmin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIpAdmin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.chkConfirmClient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabaseClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPasswordClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIpClient = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDefaultValue = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(167, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 174);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "Kết nối database 1";
            this.tabControl1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabControl1_SelectedTabChanged);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.chkConfirmAdmin);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label7);
            this.tabControlPanel1.Controls.Add(this.label8);
            this.tabControlPanel1.Controls.Add(this.txtDatabaseAdmin);
            this.tabControlPanel1.Controls.Add(this.txtPasswordAdmin);
            this.tabControlPanel1.Controls.Add(this.txtUserAdmin);
            this.tabControlPanel1.Controls.Add(this.txtIpAdmin);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(336, 147);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // chkConfirmAdmin
            // 
            this.chkConfirmAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkConfirmAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.chkConfirmAdmin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkConfirmAdmin.ForeColor = System.Drawing.Color.Black;
            this.chkConfirmAdmin.Location = new System.Drawing.Point(88, 119);
            this.chkConfirmAdmin.Name = "chkConfirmAdmin";
            this.chkConfirmAdmin.Size = new System.Drawing.Size(227, 23);
            this.chkConfirmAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkConfirmAdmin.TabIndex = 4;
            this.chkConfirmAdmin.Text = "Yêu cầu xác thực ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "User name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "IP Address";
            // 
            // txtDatabaseAdmin
            // 
            this.txtDatabaseAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtDatabaseAdmin.Border.Class = "TextBoxBorder";
            this.txtDatabaseAdmin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDatabaseAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtDatabaseAdmin.Location = new System.Drawing.Point(88, 92);
            this.txtDatabaseAdmin.Name = "txtDatabaseAdmin";
            this.txtDatabaseAdmin.Size = new System.Drawing.Size(224, 22);
            this.txtDatabaseAdmin.TabIndex = 3;
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtPasswordAdmin.Border.Class = "TextBoxBorder";
            this.txtPasswordAdmin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPasswordAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAdmin.Location = new System.Drawing.Point(88, 63);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.Size = new System.Drawing.Size(224, 22);
            this.txtPasswordAdmin.TabIndex = 2;
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtUserAdmin.Border.Class = "TextBoxBorder";
            this.txtUserAdmin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtUserAdmin.Location = new System.Drawing.Point(88, 34);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.Size = new System.Drawing.Size(224, 22);
            this.txtUserAdmin.TabIndex = 1;
            // 
            // txtIpAdmin
            // 
            this.txtIpAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIpAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtIpAdmin.Border.Class = "TextBoxBorder";
            this.txtIpAdmin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIpAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtIpAdmin.Location = new System.Drawing.Point(88, 6);
            this.txtIpAdmin.Name = "txtIpAdmin";
            this.txtIpAdmin.Size = new System.Drawing.Size(224, 22);
            this.txtIpAdmin.TabIndex = 0;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Cơ sở dữ liệu quản trị";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.chkConfirmClient);
            this.tabControlPanel2.Controls.Add(this.label4);
            this.tabControlPanel2.Controls.Add(this.label3);
            this.tabControlPanel2.Controls.Add(this.label2);
            this.tabControlPanel2.Controls.Add(this.label1);
            this.tabControlPanel2.Controls.Add(this.txtDatabaseClient);
            this.tabControlPanel2.Controls.Add(this.txtPasswordClient);
            this.tabControlPanel2.Controls.Add(this.txtUserClient);
            this.tabControlPanel2.Controls.Add(this.txtIpClient);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(336, 147);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // chkConfirmClient
            // 
            this.chkConfirmClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkConfirmClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.chkConfirmClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkConfirmClient.ForeColor = System.Drawing.Color.Black;
            this.chkConfirmClient.Location = new System.Drawing.Point(88, 119);
            this.chkConfirmClient.Name = "chkConfirmClient";
            this.chkConfirmClient.Size = new System.Drawing.Size(216, 23);
            this.chkConfirmClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkConfirmClient.TabIndex = 4;
            this.chkConfirmClient.Text = "Yêu cầu xác thực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // txtDatabaseClient
            // 
            this.txtDatabaseClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtDatabaseClient.Border.Class = "TextBoxBorder";
            this.txtDatabaseClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDatabaseClient.ForeColor = System.Drawing.Color.Black;
            this.txtDatabaseClient.Location = new System.Drawing.Point(88, 92);
            this.txtDatabaseClient.Name = "txtDatabaseClient";
            this.txtDatabaseClient.Size = new System.Drawing.Size(224, 22);
            this.txtDatabaseClient.TabIndex = 3;
            // 
            // txtPasswordClient
            // 
            this.txtPasswordClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtPasswordClient.Border.Class = "TextBoxBorder";
            this.txtPasswordClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPasswordClient.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordClient.Location = new System.Drawing.Point(88, 63);
            this.txtPasswordClient.Name = "txtPasswordClient";
            this.txtPasswordClient.PasswordChar = '*';
            this.txtPasswordClient.Size = new System.Drawing.Size(224, 22);
            this.txtPasswordClient.TabIndex = 2;
            // 
            // txtUserClient
            // 
            this.txtUserClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtUserClient.Border.Class = "TextBoxBorder";
            this.txtUserClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserClient.ForeColor = System.Drawing.Color.Black;
            this.txtUserClient.Location = new System.Drawing.Point(88, 34);
            this.txtUserClient.Name = "txtUserClient";
            this.txtUserClient.Size = new System.Drawing.Size(224, 22);
            this.txtUserClient.TabIndex = 1;
            // 
            // txtIpClient
            // 
            this.txtIpClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIpClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtIpClient.Border.Class = "TextBoxBorder";
            this.txtIpClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIpClient.ForeColor = System.Drawing.Color.Black;
            this.txtIpClient.Location = new System.Drawing.Point(88, 6);
            this.txtIpClient.Name = "txtIpClient";
            this.txtIpClient.Size = new System.Drawing.Size(224, 22);
            this.txtIpClient.TabIndex = 0;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Cơ sở dữ liệu khách hàng";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(428, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(347, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefaultValue
            // 
            this.btnDefaultValue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDefaultValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultValue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDefaultValue.Image = ((System.Drawing.Image)(resources.GetObject("btnDefaultValue.Image")));
            this.btnDefaultValue.Location = new System.Drawing.Point(266, 192);
            this.btnDefaultValue.Name = "btnDefaultValue";
            this.btnDefaultValue.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDefaultValue.TabIndex = 5;
            this.btnDefaultValue.Text = "Mặc định";
            this.btnDefaultValue.Click += new System.EventHandler(this.btnDefaultValue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 221);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDefaultValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatabaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.DatabaseConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIpClient;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkConfirmClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDatabaseClient;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPasswordClient;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserClient;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkConfirmAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDatabaseAdmin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPasswordAdmin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserAdmin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIpAdmin;
        private DevComponents.DotNetBar.ButtonX btnDefaultValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}