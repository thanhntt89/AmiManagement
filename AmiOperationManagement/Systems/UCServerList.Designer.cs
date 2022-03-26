namespace AmiOperationManagement.Systems
{
    partial class UCServerList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCServerList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateNew = new DevComponents.DotNetBar.ButtonX();
            this.dtgServer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clServerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clDeleteServer = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNew.Image")));
            this.btnCreateNew.Location = new System.Drawing.Point(637, 489);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(85, 23);
            this.btnCreateNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Tạo mới";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // dtgServer
            // 
            this.dtgServer.AllowUserToAddRows = false;
            this.dtgServer.AllowUserToDeleteRows = false;
            this.dtgServer.AllowUserToResizeRows = false;
            this.dtgServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgServer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clServerId,
            this.clServerName,
            this.clServerIp,
            this.clPort,
            this.clUser,
            this.clPass,
            this.clType,
            this.clEdit,
            this.clDeleteServer});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgServer.EnableHeadersVisualStyles = false;
            this.dtgServer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgServer.Location = new System.Drawing.Point(0, 0);
            this.dtgServer.Name = "dtgServer";
            this.dtgServer.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServer.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgServer.Size = new System.Drawing.Size(722, 483);
            this.dtgServer.TabIndex = 6;
            this.dtgServer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgServer_CellClick);
            this.dtgServer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgServer_RowPostPaint);
            // 
            // clServerId
            // 
            this.clServerId.HeaderText = "Mã Server";
            this.clServerId.Name = "clServerId";
            this.clServerId.ReadOnly = true;
            this.clServerId.Visible = false;
            // 
            // clServerName
            // 
            this.clServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clServerName.HeaderText = "Tên Server";
            this.clServerName.Name = "clServerName";
            this.clServerName.ReadOnly = true;
            // 
            // clServerIp
            // 
            this.clServerIp.HeaderText = "Địa chỉ";
            this.clServerIp.Name = "clServerIp";
            this.clServerIp.ReadOnly = true;
            this.clServerIp.Width = 150;
            // 
            // clPort
            // 
            this.clPort.HeaderText = "Cổng";
            this.clPort.Name = "clPort";
            this.clPort.ReadOnly = true;
            // 
            // clUser
            // 
            this.clUser.HeaderText = "Tên đăng nhập";
            this.clUser.Name = "clUser";
            this.clUser.ReadOnly = true;
            this.clUser.Width = 120;
            // 
            // clPass
            // 
            this.clPass.HeaderText = "Mật khẩu";
            this.clPass.Name = "clPass";
            this.clPass.ReadOnly = true;
            this.clPass.Width = 120;
            // 
            // clType
            // 
            this.clType.HeaderText = "Loại";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // clEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.clEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clEdit.HeaderText = "";
            this.clEdit.Name = "clEdit";
            this.clEdit.ReadOnly = true;
            this.clEdit.Text = null;
            this.clEdit.Width = 75;
            // 
            // clDeleteServer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.clDeleteServer.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDeleteServer.HeaderText = "";
            this.clDeleteServer.Name = "clDeleteServer";
            this.clDeleteServer.ReadOnly = true;
            this.clDeleteServer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDeleteServer.Text = null;
            this.clDeleteServer.Width = 75;
            // 
            // UCServerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.dtgServer);
            this.Name = "UCServerList";
            this.Size = new System.Drawing.Size(725, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCreateNew;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgServer;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btDeleteServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clServerIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clDeleteServer;
    }
}
