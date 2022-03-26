namespace AmiOperationManagement.Deployment
{
    partial class UpdateMeter
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMeter));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lbMeterName = new DevComponents.DotNetBar.LabelX();
            this.lbMeterId = new DevComponents.DotNetBar.LabelX();
            this.btSave = new DevComponents.DotNetBar.ButtonX();
            this.btCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboIsUsed = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.selectActive = new DevComponents.Editors.ComboItem();
            this.selectDisable = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboMeterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMultiplier = new DevComponents.Editors.DoubleInput();
            this.cboHistype = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.selectHistory = new DevComponents.Editors.ComboItem();
            this.selectCurrent = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(5, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Serial công tơ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(5, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Loại đồng hồ";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(5, 109);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Loại chốt";
            // 
            // lbMeterName
            // 
            this.lbMeterName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.lbMeterName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMeterName.ForeColor = System.Drawing.Color.Black;
            this.lbMeterName.Location = new System.Drawing.Point(5, 1);
            this.lbMeterName.Name = "lbMeterName";
            this.lbMeterName.Size = new System.Drawing.Size(68, 23);
            this.lbMeterName.TabIndex = 4;
            this.lbMeterName.Text = "Mã công tơ:";
            // 
            // lbMeterId
            // 
            this.lbMeterId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.lbMeterId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMeterId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeterId.ForeColor = System.Drawing.Color.Black;
            this.lbMeterId.Location = new System.Drawing.Point(92, 1);
            this.lbMeterId.Name = "lbMeterId";
            this.lbMeterId.Size = new System.Drawing.Size(243, 23);
            this.lbMeterId.TabIndex = 5;
            this.lbMeterId.Text = "...";
            // 
            // btSave
            // 
            this.btSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(197, 170);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(278, 170);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Đóng";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtSerial.Border.Class = "TextBoxBorder";
            this.txtSerial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerial.Enabled = false;
            this.txtSerial.ForeColor = System.Drawing.Color.Black;
            this.txtSerial.Location = new System.Drawing.Point(92, 31);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(261, 22);
            this.txtSerial.TabIndex = 0;
            // 
            // cboIsUsed
            // 
            this.cboIsUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIsUsed.DisplayMember = "Text";
            this.cboIsUsed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIsUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsUsed.Enabled = false;
            this.cboIsUsed.ForeColor = System.Drawing.Color.Black;
            this.cboIsUsed.FormattingEnabled = true;
            this.cboIsUsed.ItemHeight = 16;
            this.cboIsUsed.Items.AddRange(new object[] {
            this.selectActive,
            this.selectDisable});
            this.cboIsUsed.Location = new System.Drawing.Point(92, 139);
            this.cboIsUsed.Name = "cboIsUsed";
            this.cboIsUsed.Size = new System.Drawing.Size(261, 22);
            this.cboIsUsed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIsUsed.TabIndex = 4;
            this.cboIsUsed.WatermarkText = "Trạng thái sử dụng";
            // 
            // selectActive
            // 
            this.selectActive.Image = ((System.Drawing.Image)(resources.GetObject("selectActive.Image")));
            this.selectActive.Text = "Sử dụng";
            this.selectActive.Value = "Actived";
            // 
            // selectDisable
            // 
            this.selectDisable.Image = ((System.Drawing.Image)(resources.GetObject("selectDisable.Image")));
            this.selectDisable.Text = "Không sử dụng";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(5, 136);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(61, 23);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "Trạng thái";
            // 
            // cboMeterType
            // 
            this.cboMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMeterType.DisplayMember = "Text";
            this.cboMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeterType.ForeColor = System.Drawing.Color.Black;
            this.cboMeterType.FormattingEnabled = true;
            this.cboMeterType.ItemHeight = 16;
            this.cboMeterType.Location = new System.Drawing.Point(92, 58);
            this.cboMeterType.Name = "cboMeterType";
            this.cboMeterType.Size = new System.Drawing.Size(261, 22);
            this.cboMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMeterType.TabIndex = 1;
            this.cboMeterType.WatermarkText = "Điện lực";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 82);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 38;
            this.labelX1.Text = "Hệ số nhân";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMultiplier.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtMultiplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMultiplier.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtMultiplier.Increment = 1D;
            this.txtMultiplier.Location = new System.Drawing.Point(92, 85);
            this.txtMultiplier.MinValue = 0D;
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.ShowUpDown = true;
            this.txtMultiplier.Size = new System.Drawing.Size(261, 22);
            this.txtMultiplier.TabIndex = 2;
            this.txtMultiplier.WatermarkText = "Hệ số nhân";
            // 
            // cboHistype
            // 
            this.cboHistype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHistype.DisplayMember = "Text";
            this.cboHistype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHistype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHistype.ForeColor = System.Drawing.Color.Black;
            this.cboHistype.FormattingEnabled = true;
            this.cboHistype.ItemHeight = 16;
            this.cboHistype.Items.AddRange(new object[] {
            this.selectHistory,
            this.selectCurrent});
            this.cboHistype.Location = new System.Drawing.Point(92, 112);
            this.cboHistype.Name = "cboHistype";
            this.cboHistype.Size = new System.Drawing.Size(261, 22);
            this.cboHistype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHistype.TabIndex = 39;
            this.cboHistype.WatermarkText = "Loại chốt";
            // 
            // selectHistory
            // 
            this.selectHistory.Image = ((System.Drawing.Image)(resources.GetObject("selectHistory.Image")));
            this.selectHistory.Text = "0: Chốt theo chỉ số tích luỹ thời điểm chốt";
            // 
            // selectCurrent
            // 
            this.selectCurrent.Image = ((System.Drawing.Image)(resources.GetObject("selectCurrent.Image")));
            this.selectCurrent.Text = "1: Chốt theo chỉ số tiêu dùng chu kỳ";
            this.selectCurrent.Value = "Actived";
            // 
            // UpdateMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(356, 194);
            this.Controls.Add(this.cboHistype);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cboMeterType);
            this.Controls.Add(this.cboIsUsed);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbMeterId);
            this.Controls.Add(this.lbMeterName);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA THÔNG TIN";
            this.Load += new System.EventHandler(this.UpdateMeter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lbMeterName;
        private DevComponents.DotNetBar.LabelX lbMeterId;
        private DevComponents.DotNetBar.ButtonX btSave;
        private DevComponents.DotNetBar.ButtonX btCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIsUsed;
        private DevComponents.Editors.ComboItem selectActive;
        private DevComponents.Editors.ComboItem selectDisable;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMeterType;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DoubleInput txtMultiplier;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHistype;
        private DevComponents.Editors.ComboItem selectHistory;
        private DevComponents.Editors.ComboItem selectCurrent;
    }
}