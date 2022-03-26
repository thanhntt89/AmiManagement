namespace DeployManagement.Deployment
{
    partial class UCMeasurementPointManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbMpId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbSearchMp = new DevComponents.DotNetBar.LabelX();
            this.btCleanMp = new DevComponents.DotNetBar.ButtonX();
            this.btCreateMp = new DevComponents.DotNetBar.ButtonX();
            this.btSearchMp = new DevComponents.DotNetBar.ButtonX();
            this.dtMeasurementpoint = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MpEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MpDisable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MpDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtMeasurementpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMpId
            // 
            this.tbMpId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbMpId.Border.Class = "TextBoxBorder";
            this.tbMpId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMpId.ForeColor = System.Drawing.Color.Black;
            this.tbMpId.Location = new System.Drawing.Point(74, 11);
            this.tbMpId.Name = "tbMpId";
            this.tbMpId.Size = new System.Drawing.Size(175, 20);
            this.tbMpId.TabIndex = 11;
            // 
            // lbSearchMp
            // 
            this.lbSearchMp.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbSearchMp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSearchMp.Location = new System.Drawing.Point(1, 11);
            this.lbSearchMp.Name = "lbSearchMp";
            this.lbSearchMp.Size = new System.Drawing.Size(75, 23);
            this.lbSearchMp.TabIndex = 10;
            this.lbSearchMp.Text = "Tìm điểm đo";
            // 
            // btCleanMp
            // 
            this.btCleanMp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCleanMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCleanMp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCleanMp.Location = new System.Drawing.Point(624, 457);
            this.btCleanMp.Name = "btCleanMp";
            this.btCleanMp.Size = new System.Drawing.Size(75, 23);
            this.btCleanMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCleanMp.TabIndex = 9;
            this.btCleanMp.Text = "Clean";
            // 
            // btCreateMp
            // 
            this.btCreateMp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCreateMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateMp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCreateMp.Location = new System.Drawing.Point(624, 10);
            this.btCreateMp.Name = "btCreateMp";
            this.btCreateMp.Size = new System.Drawing.Size(75, 23);
            this.btCreateMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCreateMp.TabIndex = 8;
            this.btCreateMp.Text = "Tạo mới";
            // 
            // btSearchMp
            // 
            this.btSearchMp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearchMp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearchMp.Location = new System.Drawing.Point(255, 10);
            this.btSearchMp.Name = "btSearchMp";
            this.btSearchMp.Size = new System.Drawing.Size(75, 23);
            this.btSearchMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSearchMp.TabIndex = 7;
            this.btSearchMp.Text = "Tìm";
            // 
            // dtMeasurementpoint
            // 
            this.dtMeasurementpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMeasurementpoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMeasurementpoint.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMeasurementpoint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMeasurementpoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMeasurementpoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MpEdit,
            this.MpDisable,
            this.MpDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMeasurementpoint.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtMeasurementpoint.EnableHeadersVisualStyles = false;
            this.dtMeasurementpoint.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtMeasurementpoint.Location = new System.Drawing.Point(1, 40);
            this.dtMeasurementpoint.Name = "dtMeasurementpoint";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMeasurementpoint.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtMeasurementpoint.Size = new System.Drawing.Size(698, 411);
            this.dtMeasurementpoint.TabIndex = 6;
            // 
            // MpEdit
            // 
            this.MpEdit.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.MpEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.MpEdit.HeaderText = "Sửa";
            this.MpEdit.Name = "MpEdit";
            // 
            // MpDisable
            // 
            this.MpDisable.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Disable";
            this.MpDisable.DefaultCellStyle = dataGridViewCellStyle3;
            this.MpDisable.HeaderText = "Disable";
            this.MpDisable.Name = "MpDisable";
            // 
            // MpDelete
            // 
            this.MpDelete.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Xoá";
            this.MpDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.MpDelete.HeaderText = "Xoá";
            this.MpDelete.Name = "MpDelete";
            // 
            // UCMeasurementPointManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbMpId);
            this.Controls.Add(this.lbSearchMp);
            this.Controls.Add(this.btCleanMp);
            this.Controls.Add(this.btCreateMp);
            this.Controls.Add(this.btSearchMp);
            this.Controls.Add(this.dtMeasurementpoint);
            this.Name = "UCMeasurementPointManagement";
            this.Size = new System.Drawing.Size(700, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dtMeasurementpoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbMpId;
        private DevComponents.DotNetBar.LabelX lbSearchMp;
        private DevComponents.DotNetBar.ButtonX btCleanMp;
        private DevComponents.DotNetBar.ButtonX btCreateMp;
        private DevComponents.DotNetBar.ButtonX btSearchMp;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtMeasurementpoint;
        private System.Windows.Forms.DataGridViewButtonColumn MpEdit;
        private System.Windows.Forms.DataGridViewButtonColumn MpDisable;
        private System.Windows.Forms.DataGridViewButtonColumn MpDelete;
    }
}
