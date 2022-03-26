namespace DeployManagement.Deployment
{
    partial class UCMessageRevecive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbAction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbReset = new DevComponents.Editors.ComboItem();
            this.cbUpdate = new DevComponents.Editors.ComboItem();
            this.cbReadOperation = new DevComponents.Editors.ComboItem();
            this.cbReadHistorical = new DevComponents.Editors.ComboItem();
            this.cbLoadProfile = new DevComponents.Editors.ComboItem();
            this.cbConfigServer = new DevComponents.Editors.ComboItem();
            this.dtAction = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tbReceiveMes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btPublish = new DevComponents.DotNetBar.ButtonX();
            this.btCleanttbReceive = new DevComponents.DotNetBar.ButtonX();
            this.btCacelReceive = new DevComponents.DotNetBar.ButtonX();
            this.btSubcribe = new DevComponents.DotNetBar.ButtonX();
            this.tbDcuId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbAddDcu = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtAction)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAction.DisplayMember = "Text";
            this.cbAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.ItemHeight = 14;
            this.cbAction.Items.AddRange(new object[] {
            this.cbReset,
            this.cbUpdate,
            this.cbReadOperation,
            this.cbReadHistorical,
            this.cbLoadProfile,
            this.cbConfigServer});
            this.cbAction.Location = new System.Drawing.Point(578, 15);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(204, 20);
            this.cbAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAction.TabIndex = 27;
            // 
            // cbReset
            // 
            this.cbReset.Text = "Reset";
            // 
            // cbUpdate
            // 
            this.cbUpdate.Text = "UpdateFirmware";
            // 
            // cbReadOperation
            // 
            this.cbReadOperation.Text = "Đọc Operation";
            // 
            // cbReadHistorical
            // 
            this.cbReadHistorical.Text = "Đọc Historical";
            // 
            // cbLoadProfile
            // 
            this.cbLoadProfile.Text = "Đọc LoadProfile";
            // 
            // cbConfigServer
            // 
            this.cbConfigServer.Text = "Cấu hình Server";
            // 
            // dtAction
            // 
            this.dtAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAction.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtAction.EnableHeadersVisualStyles = false;
            this.dtAction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtAction.Location = new System.Drawing.Point(578, 52);
            this.dtAction.Name = "dtAction";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAction.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtAction.Size = new System.Drawing.Size(204, 342);
            this.dtAction.TabIndex = 26;
            // 
            // tbReceiveMes
            // 
            this.tbReceiveMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReceiveMes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReceiveMes.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.tbReceiveMes.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.tbReceiveMes.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.tbReceiveMes.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.tbReceiveMes.Border.Class = "TextBoxBorder";
            this.tbReceiveMes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReceiveMes.ForeColor = System.Drawing.Color.Black;
            this.tbReceiveMes.Location = new System.Drawing.Point(2, 52);
            this.tbReceiveMes.Multiline = true;
            this.tbReceiveMes.Name = "tbReceiveMes";
            this.tbReceiveMes.Size = new System.Drawing.Size(570, 342);
            this.tbReceiveMes.TabIndex = 25;
            // 
            // btPublish
            // 
            this.btPublish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPublish.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btPublish.Location = new System.Drawing.Point(707, 411);
            this.btPublish.Name = "btPublish";
            this.btPublish.Size = new System.Drawing.Size(75, 23);
            this.btPublish.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btPublish.TabIndex = 24;
            this.btPublish.Text = "Gửi";
            // 
            // btCleanttbReceive
            // 
            this.btCleanttbReceive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCleanttbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCleanttbReceive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCleanttbReceive.Location = new System.Drawing.Point(497, 411);
            this.btCleanttbReceive.Name = "btCleanttbReceive";
            this.btCleanttbReceive.Size = new System.Drawing.Size(75, 23);
            this.btCleanttbReceive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCleanttbReceive.TabIndex = 23;
            this.btCleanttbReceive.Text = "Clean";
            // 
            // btCacelReceive
            // 
            this.btCacelReceive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCacelReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCacelReceive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCacelReceive.Location = new System.Drawing.Point(484, 12);
            this.btCacelReceive.Name = "btCacelReceive";
            this.btCacelReceive.Size = new System.Drawing.Size(75, 23);
            this.btCacelReceive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCacelReceive.TabIndex = 22;
            this.btCacelReceive.Text = "Huỷ nhận";
            // 
            // btSubcribe
            // 
            this.btSubcribe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSubcribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubcribe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSubcribe.Location = new System.Drawing.Point(403, 12);
            this.btSubcribe.Name = "btSubcribe";
            this.btSubcribe.Size = new System.Drawing.Size(75, 23);
            this.btSubcribe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSubcribe.TabIndex = 21;
            this.btSubcribe.Text = "Nhận bản tin";
            // 
            // tbDcuId
            // 
            this.tbDcuId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDcuId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbDcuId.Border.Class = "TextBoxBorder";
            this.tbDcuId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDcuId.ForeColor = System.Drawing.Color.Black;
            this.tbDcuId.Location = new System.Drawing.Point(87, 12);
            this.tbDcuId.Multiline = true;
            this.tbDcuId.Name = "tbDcuId";
            this.tbDcuId.Size = new System.Drawing.Size(290, 23);
            this.tbDcuId.TabIndex = 20;
            // 
            // lbAddDcu
            // 
            this.lbAddDcu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbAddDcu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbAddDcu.Location = new System.Drawing.Point(16, 12);
            this.lbAddDcu.Name = "lbAddDcu";
            this.lbAddDcu.SingleLineColor = System.Drawing.Color.White;
            this.lbAddDcu.Size = new System.Drawing.Size(75, 23);
            this.lbAddDcu.TabIndex = 19;
            this.lbAddDcu.Text = "Nhập DCU";
            // 
            // UCMessageRevecive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.dtAction);
            this.Controls.Add(this.tbReceiveMes);
            this.Controls.Add(this.btPublish);
            this.Controls.Add(this.btCleanttbReceive);
            this.Controls.Add(this.btCacelReceive);
            this.Controls.Add(this.btSubcribe);
            this.Controls.Add(this.tbDcuId);
            this.Controls.Add(this.lbAddDcu);
            this.Name = "UCMessageRevecive";
            this.Size = new System.Drawing.Size(784, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dtAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAction;
        private DevComponents.Editors.ComboItem cbReset;
        private DevComponents.Editors.ComboItem cbUpdate;
        private DevComponents.Editors.ComboItem cbReadOperation;
        private DevComponents.Editors.ComboItem cbReadHistorical;
        private DevComponents.Editors.ComboItem cbLoadProfile;
        private DevComponents.Editors.ComboItem cbConfigServer;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtAction;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReceiveMes;
        private DevComponents.DotNetBar.ButtonX btPublish;
        private DevComponents.DotNetBar.ButtonX btCleanttbReceive;
        private DevComponents.DotNetBar.ButtonX btCacelReceive;
        private DevComponents.DotNetBar.ButtonX btSubcribe;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDcuId;
        private DevComponents.DotNetBar.LabelX lbAddDcu;

    }
}
