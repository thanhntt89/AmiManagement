namespace AmiOperationManagement.Ftp
{
    partial class UCSystemFirmware
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSystemFirmware));
            this.dtgSoftwareVersion = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.FirmwareIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterTypeIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmwareNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionFirmwareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.UpdateCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DeletedCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.FilePathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoftwareVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSoftwareVersion
            // 
            this.dtgSoftwareVersion.AllowUserToAddRows = false;
            this.dtgSoftwareVersion.AllowUserToDeleteRows = false;
            this.dtgSoftwareVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSoftwareVersion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSoftwareVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSoftwareVersion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirmwareIdCol,
            this.MeterTypeIdCol,
            this.FirmwareNameCol,
            this.VersionFirmwareCol,
            this.CreatedDateCol,
            this.StatusCol,
            this.UpdateCol,
            this.DeletedCol,
            this.FilePathCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSoftwareVersion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSoftwareVersion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgSoftwareVersion.Location = new System.Drawing.Point(3, 3);
            this.dtgSoftwareVersion.Name = "dtgSoftwareVersion";
            this.dtgSoftwareVersion.ReadOnly = true;
            this.dtgSoftwareVersion.Size = new System.Drawing.Size(849, 350);
            this.dtgSoftwareVersion.TabIndex = 0;
            this.dtgSoftwareVersion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSoftwareVersion_CellClick);
            // 
            // FirmwareIdCol
            // 
            this.FirmwareIdCol.DataPropertyName = "FirmwareId";
            this.FirmwareIdCol.HeaderText = "FirmwareId";
            this.FirmwareIdCol.Name = "FirmwareIdCol";
            this.FirmwareIdCol.ReadOnly = true;
            this.FirmwareIdCol.Visible = false;
            // 
            // MeterTypeIdCol
            // 
            this.MeterTypeIdCol.DataPropertyName = "MeterTypeId";
            this.MeterTypeIdCol.HeaderText = "Loại công tơ";
            this.MeterTypeIdCol.Name = "MeterTypeIdCol";
            this.MeterTypeIdCol.ReadOnly = true;
            this.MeterTypeIdCol.Width = 200;
            // 
            // FirmwareNameCol
            // 
            this.FirmwareNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirmwareNameCol.DataPropertyName = "FirmwareName";
            this.FirmwareNameCol.HeaderText = "Tên phiên bản";
            this.FirmwareNameCol.Name = "FirmwareNameCol";
            this.FirmwareNameCol.ReadOnly = true;
            // 
            // VersionFirmwareCol
            // 
            this.VersionFirmwareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VersionFirmwareCol.DataPropertyName = "VersionFirmware";
            this.VersionFirmwareCol.HeaderText = "Phiên bản";
            this.VersionFirmwareCol.Name = "VersionFirmwareCol";
            this.VersionFirmwareCol.ReadOnly = true;
            // 
            // CreatedDateCol
            // 
            this.CreatedDateCol.DataPropertyName = "CreatedDate";
            this.CreatedDateCol.HeaderText = "Ngày tạo";
            this.CreatedDateCol.Name = "CreatedDateCol";
            this.CreatedDateCol.ReadOnly = true;
            this.CreatedDateCol.Width = 130;
            // 
            // StatusCol
            // 
            this.StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StatusCol.Checked = true;
            this.StatusCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.StatusCol.CheckValue = null;
            this.StatusCol.DataPropertyName = "Status";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatusCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.StatusCol.HeaderText = "Sử dụng";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            this.StatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StatusCol.Width = 80;
            // 
            // UpdateCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Cập nhật";
            this.UpdateCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.UpdateCol.HeaderText = "";
            this.UpdateCol.Name = "UpdateCol";
            this.UpdateCol.ReadOnly = true;
            this.UpdateCol.Text = null;
            this.UpdateCol.Width = 75;
            // 
            // DeletedCol
            // 
            this.DeletedCol.DataPropertyName = "DeletedCol";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.DeletedCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeletedCol.HeaderText = "";
            this.DeletedCol.Name = "DeletedCol";
            this.DeletedCol.ReadOnly = true;
            this.DeletedCol.Text = null;
            this.DeletedCol.Width = 75;
            // 
            // FilePathCol
            // 
            this.FilePathCol.HeaderText = "Đường dẫn server";
            this.FilePathCol.Name = "FilePathCol";
            this.FilePathCol.ReadOnly = true;
            this.FilePathCol.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(770, 359);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(82, 23);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // UCSystemFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dtgSoftwareVersion);
            this.Name = "UCSystemFirmware";
            this.Size = new System.Drawing.Size(855, 385);
            this.Load += new System.EventHandler(this.UCSystemFirmware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoftwareVersion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSoftwareVersion;
        private DevComponents.DotNetBar.ButtonX btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmwareIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterTypeIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmwareNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionFirmwareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn StatusCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn UpdateCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DeletedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathCol;
    }
}
