namespace AmiOperationManagement.ErrorManagement
{
    partial class UCModemFixbugHistories
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
            this.lblModemCode = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtgFixbugHistories = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PECol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PENameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupFixCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixbugHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModemCode
            // 
            this.lblModemCode.AutoSize = true;
            this.lblModemCode.Location = new System.Drawing.Point(95, 8);
            this.lblModemCode.Name = "lblModemCode";
            this.lblModemCode.Size = new System.Drawing.Size(19, 13);
            this.lblModemCode.TabIndex = 2;
            this.lblModemCode.Text = "....";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Location = new System.Drawing.Point(95, 30);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(19, 13);
            this.lblErrorName.TabIndex = 2;
            this.lblErrorName.Text = "....";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã thiết bị";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Lịch sử sửa: Lỗi -";
            // 
            // dtgFixbugHistories
            // 
            this.dtgFixbugHistories.AllowUserToAddRows = false;
            this.dtgFixbugHistories.AllowUserToDeleteRows = false;
            this.dtgFixbugHistories.AllowUserToResizeRows = false;
            this.dtgFixbugHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFixbugHistories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgFixbugHistories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgFixbugHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFixbugHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PECol,
            this.PENameCol,
            this.MeterTypeCol,
            this.CreatedCol,
            this.GroupFixCol,
            this.NotesCol,
            this.FixDateCol,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFixbugHistories.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgFixbugHistories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgFixbugHistories.Location = new System.Drawing.Point(3, 48);
            this.dtgFixbugHistories.Name = "dtgFixbugHistories";
            this.dtgFixbugHistories.ReadOnly = true;
            this.dtgFixbugHistories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgFixbugHistories.Size = new System.Drawing.Size(631, 336);
            this.dtgFixbugHistories.TabIndex = 0;
            this.dtgFixbugHistories.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgFixbugHistories_RowPostPaint);
            // 
            // PECol
            // 
            this.PECol.HeaderText = "Mã điểm đo";
            this.PECol.Name = "PECol";
            this.PECol.ReadOnly = true;
            this.PECol.Width = 120;
            // 
            // PENameCol
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PENameCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.PENameCol.HeaderText = "Tên điểm đo";
            this.PENameCol.MinimumWidth = 150;
            this.PENameCol.Name = "PENameCol";
            this.PENameCol.ReadOnly = true;
            this.PENameCol.Width = 200;
            // 
            // MeterTypeCol
            // 
            this.MeterTypeCol.HeaderText = "Công tơ";
            this.MeterTypeCol.Name = "MeterTypeCol";
            this.MeterTypeCol.ReadOnly = true;
            // 
            // CreatedCol
            // 
            this.CreatedCol.HeaderText = "Ngày lỗi";
            this.CreatedCol.Name = "CreatedCol";
            this.CreatedCol.ReadOnly = true;
            this.CreatedCol.Width = 120;
            // 
            // GroupFixCol
            // 
            this.GroupFixCol.HeaderText = "Đơn vị sửa";
            this.GroupFixCol.Name = "GroupFixCol";
            this.GroupFixCol.ReadOnly = true;
            this.GroupFixCol.Width = 120;
            // 
            // NotesCol
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NotesCol.HeaderText = "Nội dung sửa";
            this.NotesCol.Name = "NotesCol";
            this.NotesCol.ReadOnly = true;
            this.NotesCol.Width = 250;
            // 
            // FixDateCol
            // 
            this.FixDateCol.HeaderText = "Ngày thay đổi";
            this.FixDateCol.Name = "FixDateCol";
            this.FixDateCol.ReadOnly = true;
            this.FixDateCol.Width = 120;
            // 
            // Column4
            // 
            this.Column4.Checked = true;
            this.Column4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column4.CheckValue = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Đã sửa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 75;
            // 
            // UCModemFixbugHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblModemCode);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgFixbugHistories);
            this.Name = "UCModemFixbugHistories";
            this.Size = new System.Drawing.Size(637, 387);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixbugHistories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgFixbugHistories;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label lblErrorName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label lblModemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PECol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PENameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupFixCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixDateCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column4;
    }
}
