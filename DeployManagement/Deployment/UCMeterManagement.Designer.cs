namespace DeployManagement.Deployment
{
    partial class UCMeterManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSearchMeter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnCleanMeter = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateMeter = new DevComponents.DotNetBar.ButtonX();
            this.btnsearchMeter = new DevComponents.DotNetBar.ButtonX();
            this.txtMeterSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblhapDcu = new DevComponents.DotNetBar.LabelX();
            this.MeterEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MeterDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMeter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchMeter
            // 
            this.dgvSearchMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchMeter.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchMeter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeterEdit,
            this.MeterDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchMeter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearchMeter.EnableHeadersVisualStyles = false;
            this.dgvSearchMeter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSearchMeter.Location = new System.Drawing.Point(5, 44);
            this.dgvSearchMeter.Name = "dgvSearchMeter";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchMeter.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearchMeter.Size = new System.Drawing.Size(778, 369);
            this.dgvSearchMeter.TabIndex = 18;
            // 
            // btnCleanMeter
            // 
            this.btnCleanMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCleanMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCleanMeter.Location = new System.Drawing.Point(708, 419);
            this.btnCleanMeter.Name = "btnCleanMeter";
            this.btnCleanMeter.Size = new System.Drawing.Size(75, 23);
            this.btnCleanMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCleanMeter.TabIndex = 17;
            this.btnCleanMeter.Text = "Clean";
            // 
            // btnCreateMeter
            // 
            this.btnCreateMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateMeter.Location = new System.Drawing.Point(708, 8);
            this.btnCreateMeter.Name = "btnCreateMeter";
            this.btnCreateMeter.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateMeter.TabIndex = 16;
            this.btnCreateMeter.Text = "Tạo mới";
            // 
            // btnsearchMeter
            // 
            this.btnsearchMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchMeter.Location = new System.Drawing.Point(199, 8);
            this.btnsearchMeter.Name = "btnsearchMeter";
            this.btnsearchMeter.Size = new System.Drawing.Size(75, 23);
            this.btnsearchMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchMeter.TabIndex = 15;
            this.btnsearchMeter.Text = "Tìm";
            // 
            // txtMeterSearch
            // 
            this.txtMeterSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMeterSearch.Border.Class = "TextBoxBorder";
            this.txtMeterSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMeterSearch.ForeColor = System.Drawing.Color.Black;
            this.txtMeterSearch.Location = new System.Drawing.Point(93, 8);
            this.txtMeterSearch.Multiline = true;
            this.txtMeterSearch.Name = "txtMeterSearch";
            this.txtMeterSearch.Size = new System.Drawing.Size(100, 23);
            this.txtMeterSearch.TabIndex = 14;
            // 
            // lblhapDcu
            // 
            this.lblhapDcu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblhapDcu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblhapDcu.Location = new System.Drawing.Point(14, 8);
            this.lblhapDcu.Name = "lblhapDcu";
            this.lblhapDcu.Size = new System.Drawing.Size(89, 23);
            this.lblhapDcu.TabIndex = 13;
            this.lblhapDcu.Text = "Nhập công tơ";
            // 
            // MeterEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.MeterEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.MeterEdit.HeaderText = "Sửa";
            this.MeterEdit.Name = "MeterEdit";
            // 
            // MeterDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.MeterDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.MeterDelete.HeaderText = "Xoá";
            this.MeterDelete.Name = "MeterDelete";
            // 
            // UCMeterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSearchMeter);
            this.Controls.Add(this.btnCleanMeter);
            this.Controls.Add(this.btnCreateMeter);
            this.Controls.Add(this.btnsearchMeter);
            this.Controls.Add(this.txtMeterSearch);
            this.Controls.Add(this.lblhapDcu);
            this.Name = "UCMeterManagement";
            this.Size = new System.Drawing.Size(789, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMeter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSearchMeter;
        private DevComponents.DotNetBar.ButtonX btnCleanMeter;
        private DevComponents.DotNetBar.ButtonX btnCreateMeter;
        private DevComponents.DotNetBar.ButtonX btnsearchMeter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMeterSearch;
        private DevComponents.DotNetBar.LabelX lblhapDcu;
        private System.Windows.Forms.DataGridViewButtonColumn MeterEdit;
        private System.Windows.Forms.DataGridViewButtonColumn MeterDelete;

    }
}
