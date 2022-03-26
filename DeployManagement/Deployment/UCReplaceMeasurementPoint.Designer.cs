namespace DeployManagement
{
    partial class ReplaceMeasurementPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbSearchMpReplace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.lbDcuReplace = new DevComponents.DotNetBar.LabelX();
            this.lbMeterIdReplace = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btCleanMpReplace = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm mã điểm đo";
            // 
            // tbSearchMpReplace
            // 
            this.tbSearchMpReplace.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbSearchMpReplace.Border.Class = "TextBoxBorder";
            this.tbSearchMpReplace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSearchMpReplace.ForeColor = System.Drawing.Color.Black;
            this.tbSearchMpReplace.Location = new System.Drawing.Point(104, 24);
            this.tbSearchMpReplace.Multiline = true;
            this.tbSearchMpReplace.Name = "tbSearchMpReplace";
            this.tbSearchMpReplace.Size = new System.Drawing.Size(139, 23);
            this.tbSearchMpReplace.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Location = new System.Drawing.Point(249, 24);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Tìm";
            // 
            // lbDcuReplace
            // 
            this.lbDcuReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbDcuReplace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDcuReplace.Location = new System.Drawing.Point(435, 24);
            this.lbDcuReplace.Name = "lbDcuReplace";
            this.lbDcuReplace.Size = new System.Drawing.Size(114, 23);
            this.lbDcuReplace.TabIndex = 3;
            // 
            // lbMeterIdReplace
            // 
            this.lbMeterIdReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbMeterIdReplace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMeterIdReplace.Location = new System.Drawing.Point(607, 24);
            this.lbMeterIdReplace.Name = "lbMeterIdReplace";
            this.lbMeterIdReplace.Size = new System.Drawing.Size(112, 23);
            this.lbMeterIdReplace.TabIndex = 4;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(15, 63);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(710, 298);
            this.dataGridViewX1.TabIndex = 5;
            // 
            // btCleanMpReplace
            // 
            this.btCleanMpReplace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCleanMpReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCleanMpReplace.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCleanMpReplace.Location = new System.Drawing.Point(636, 367);
            this.btCleanMpReplace.Name = "btCleanMpReplace";
            this.btCleanMpReplace.Size = new System.Drawing.Size(75, 23);
            this.btCleanMpReplace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCleanMpReplace.TabIndex = 6;
            this.btCleanMpReplace.Text = "Clean";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(391, 24);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(38, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "DcuId:";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(555, 24);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(10, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "-";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(563, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "MeterId:";
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Cập nhật điểm đo";
            this.Update.DefaultCellStyle = dataGridViewCellStyle1;
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            // 
            // ReplaceMeasurementPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btCleanMpReplace);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.lbMeterIdReplace);
            this.Controls.Add(this.lbDcuReplace);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearchMpReplace);
            this.Controls.Add(this.labelX1);
            this.Name = "ReplaceMeasurementPoint";
            this.Size = new System.Drawing.Size(741, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSearchMpReplace;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.LabelX lbDcuReplace;
        private DevComponents.DotNetBar.LabelX lbMeterIdReplace;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btCleanMpReplace;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}
