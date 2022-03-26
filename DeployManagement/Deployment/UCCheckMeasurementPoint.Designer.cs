namespace DeployManagement.Deployment
{
    partial class UCCheckMeasurementPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtCheckDcu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmSearchBy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMpId = new DevComponents.Editors.ComboItem();
            this.cbDcuId = new DevComponents.Editors.ComboItem();
            this.cmMeterId = new DevComponents.Editors.ComboItem();
            this.lbSearchBy = new DevComponents.DotNetBar.LabelX();
            this.btClean = new DevComponents.DotNetBar.ButtonX();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.tbSearchDcuId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btSupport = new DevComponents.DotNetBar.ButtonX();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtCheckDcu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCheckDcu
            // 
            this.dtCheckDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCheckDcu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCheckDcu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCheckDcu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtCheckDcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCheckDcu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Change});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCheckDcu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtCheckDcu.EnableHeadersVisualStyles = false;
            this.dtCheckDcu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtCheckDcu.Location = new System.Drawing.Point(10, 32);
            this.dtCheckDcu.Name = "dtCheckDcu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCheckDcu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtCheckDcu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtCheckDcu.Size = new System.Drawing.Size(781, 403);
            this.dtCheckDcu.TabIndex = 26;
            // 
            // cmSearchBy
            // 
            this.cmSearchBy.DisplayMember = "Text";
            this.cmSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmSearchBy.FormattingEnabled = true;
            this.cmSearchBy.ItemHeight = 14;
            this.cmSearchBy.Items.AddRange(new object[] {
            this.cbMpId,
            this.cbDcuId,
            this.cmMeterId});
            this.cmSearchBy.Location = new System.Drawing.Point(69, 3);
            this.cmSearchBy.Name = "cmSearchBy";
            this.cmSearchBy.Size = new System.Drawing.Size(128, 20);
            this.cmSearchBy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmSearchBy.TabIndex = 25;
            // 
            // cbMpId
            // 
            this.cbMpId.Text = "Mã điểm đo";
            // 
            // cbDcuId
            // 
            this.cbDcuId.Text = "Mã modem";
            // 
            // cmMeterId
            // 
            this.cmMeterId.Text = "Mã công tơ";
            // 
            // lbSearchBy
            // 
            this.lbSearchBy.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbSearchBy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSearchBy.Location = new System.Drawing.Point(14, 2);
            this.lbSearchBy.Name = "lbSearchBy";
            this.lbSearchBy.Size = new System.Drawing.Size(54, 23);
            this.lbSearchBy.TabIndex = 24;
            this.lbSearchBy.Text = "Tìm theo";
            // 
            // btClean
            // 
            this.btClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClean.Location = new System.Drawing.Point(716, 443);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClean.TabIndex = 23;
            this.btClean.Text = "Clean";
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Location = new System.Drawing.Point(349, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(60, 20);
            this.btSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSearch.TabIndex = 21;
            this.btSearch.Text = "Search";
            // 
            // tbSearchDcuId
            // 
            this.tbSearchDcuId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbSearchDcuId.Border.Class = "TextBoxBorder";
            this.tbSearchDcuId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSearchDcuId.ForeColor = System.Drawing.Color.Black;
            this.tbSearchDcuId.Location = new System.Drawing.Point(203, 3);
            this.tbSearchDcuId.Multiline = true;
            this.tbSearchDcuId.Name = "tbSearchDcuId";
            this.tbSearchDcuId.Size = new System.Drawing.Size(140, 20);
            this.tbSearchDcuId.TabIndex = 20;
            // 
            // btSupport
            // 
            this.btSupport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSupport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSupport.Location = new System.Drawing.Point(716, 3);
            this.btSupport.Name = "btSupport";
            this.btSupport.Size = new System.Drawing.Size(75, 23);
            this.btSupport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSupport.TabIndex = 22;
            this.btSupport.Text = "Hỗ trợ";
            // 
            // Change
            // 
            this.Change.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Change.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Thay thế";
            this.Change.DefaultCellStyle = dataGridViewCellStyle2;
            this.Change.HeaderText = "Thay thế";
            this.Change.MinimumWidth = 75;
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.Width = 75;
            // 
            // UCCheckMeasurementPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtCheckDcu);
            this.Controls.Add(this.cmSearchBy);
            this.Controls.Add(this.lbSearchBy);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearchDcuId);
            this.Controls.Add(this.btSupport);
            this.Name = "UCCheckMeasurementPoint";
            this.Size = new System.Drawing.Size(801, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dtCheckDcu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtCheckDcu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmSearchBy;
        private DevComponents.Editors.ComboItem cbMpId;
        private DevComponents.Editors.ComboItem cbDcuId;
        private DevComponents.Editors.ComboItem cmMeterId;
        private DevComponents.DotNetBar.LabelX lbSearchBy;
        private DevComponents.DotNetBar.ButtonX btClean;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSearchDcuId;
        private DevComponents.DotNetBar.ButtonX btSupport;
        private System.Windows.Forms.DataGridViewButtonColumn Change;

    }
}
