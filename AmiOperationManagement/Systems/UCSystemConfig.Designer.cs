namespace AmiOperationManagement.Systems
{
    partial class UCSystemConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSystemConfig));
            this.dtgSystemInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ConfigCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSystemInfo
            // 
            this.dtgSystemInfo.AllowUserToAddRows = false;
            this.dtgSystemInfo.AllowUserToDeleteRows = false;
            this.dtgSystemInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSystemInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSystemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSystemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConfigCodeCol,
            this.NoteCol,
            this.ValueCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSystemInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSystemInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgSystemInfo.Location = new System.Drawing.Point(3, 21);
            this.dtgSystemInfo.Name = "dtgSystemInfo";
            this.dtgSystemInfo.Size = new System.Drawing.Size(712, 399);
            this.dtgSystemInfo.TabIndex = 0;
            this.dtgSystemInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgSystemInfo_RowPostPaint);
            // 
            // ConfigCodeCol
            // 
            this.ConfigCodeCol.DataPropertyName = "ConfigCode";
            this.ConfigCodeCol.HeaderText = "ConfigCodeCol";
            this.ConfigCodeCol.Name = "ConfigCodeCol";
            this.ConfigCodeCol.Visible = false;
            // 
            // NoteCol
            // 
            this.NoteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoteCol.DataPropertyName = "Notes";
            this.NoteCol.HeaderText = "Thông số cấu hình";
            this.NoteCol.Name = "NoteCol";
            this.NoteCol.ReadOnly = true;
            // 
            // ValueCol
            // 
            this.ValueCol.DataPropertyName = "Value";
            this.ValueCol.HeaderText = "Giá trị";
            this.ValueCol.Name = "ValueCol";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(640, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông số cấu hình hệ thống";
            // 
            // UCSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgSystemInfo);
            this.Name = "UCSystemConfig";
            this.Size = new System.Drawing.Size(718, 452);
            this.Load += new System.EventHandler(this.UCSystemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSystemInfo;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
    }
}
