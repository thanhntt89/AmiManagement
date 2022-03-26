namespace DeployManagement.Deployment
{
    partial class UCDcuManagement
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
            this.dtSearchDcu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DcuEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DcuDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btCleanDcu = new DevComponents.DotNetBar.ButtonX();
            this.btCreateDcu = new DevComponents.DotNetBar.ButtonX();
            this.btsearchDcu = new DevComponents.DotNetBar.ButtonX();
            this.tbDcuIdSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchDcu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSearchDcu
            // 
            this.dtSearchDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSearchDcu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSearchDcu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtSearchDcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSearchDcu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcuEdit,
            this.DcuDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSearchDcu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtSearchDcu.EnableHeadersVisualStyles = false;
            this.dtSearchDcu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtSearchDcu.Location = new System.Drawing.Point(3, 44);
            this.dtSearchDcu.Name = "dtSearchDcu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSearchDcu.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtSearchDcu.Size = new System.Drawing.Size(778, 369);
            this.dtSearchDcu.TabIndex = 12;
            // 
            // DcuEdit
            // 
            this.DcuEdit.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.DcuEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.DcuEdit.HeaderText = "Sửa";
            this.DcuEdit.Name = "DcuEdit";
            // 
            // DcuDelete
            // 
            this.DcuDelete.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.DcuDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.DcuDelete.HeaderText = "Xoá";
            this.DcuDelete.Name = "DcuDelete";
            // 
            // btCleanDcu
            // 
            this.btCleanDcu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCleanDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCleanDcu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCleanDcu.Location = new System.Drawing.Point(706, 419);
            this.btCleanDcu.Name = "btCleanDcu";
            this.btCleanDcu.Size = new System.Drawing.Size(75, 23);
            this.btCleanDcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCleanDcu.TabIndex = 11;
            this.btCleanDcu.Text = "Clean";
            // 
            // btCreateDcu
            // 
            this.btCreateDcu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCreateDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateDcu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCreateDcu.Location = new System.Drawing.Point(706, 8);
            this.btCreateDcu.Name = "btCreateDcu";
            this.btCreateDcu.Size = new System.Drawing.Size(75, 23);
            this.btCreateDcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCreateDcu.TabIndex = 10;
            this.btCreateDcu.Text = "Tạo mới";
            // 
            // btsearchDcu
            // 
            this.btsearchDcu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsearchDcu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btsearchDcu.Location = new System.Drawing.Point(186, 8);
            this.btsearchDcu.Name = "btsearchDcu";
            this.btsearchDcu.Size = new System.Drawing.Size(75, 23);
            this.btsearchDcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btsearchDcu.TabIndex = 9;
            this.btsearchDcu.Text = "Tìm";
            // 
            // tbDcuIdSearch
            // 
            this.tbDcuIdSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbDcuIdSearch.Border.Class = "TextBoxBorder";
            this.tbDcuIdSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDcuIdSearch.ForeColor = System.Drawing.Color.Black;
            this.tbDcuIdSearch.Location = new System.Drawing.Point(80, 8);
            this.tbDcuIdSearch.Multiline = true;
            this.tbDcuIdSearch.Name = "tbDcuIdSearch";
            this.tbDcuIdSearch.Size = new System.Drawing.Size(100, 23);
            this.tbDcuIdSearch.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Nhập DCU";
            // 
            // UCDcuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtSearchDcu);
            this.Controls.Add(this.btCleanDcu);
            this.Controls.Add(this.btCreateDcu);
            this.Controls.Add(this.btsearchDcu);
            this.Controls.Add(this.tbDcuIdSearch);
            this.Controls.Add(this.labelX1);
            this.Name = "UCDcuManagement";
            this.Size = new System.Drawing.Size(784, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dtSearchDcu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtSearchDcu;
        private System.Windows.Forms.DataGridViewButtonColumn DcuEdit;
        private System.Windows.Forms.DataGridViewButtonColumn DcuDelete;
        private DevComponents.DotNetBar.ButtonX btCleanDcu;
        private DevComponents.DotNetBar.ButtonX btCreateDcu;
        private DevComponents.DotNetBar.ButtonX btsearchDcu;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDcuIdSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
