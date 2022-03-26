namespace AmiOperationManagement.Deployment
{
    partial class AddMeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMeter));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btSave = new DevComponents.DotNetBar.ButtonX();
            this.btCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtMeterId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMeterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboHistype = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.selectHistory = new DevComponents.Editors.ComboItem();
            this.selectCurrent = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMultiplier = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã công tơ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(5, 37);
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
            this.labelX3.Location = new System.Drawing.Point(5, 62);
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
            this.labelX4.Location = new System.Drawing.Point(5, 112);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Loại chốt";
            // 
            // btSave
            // 
            this.btSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(180, 147);
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
            this.btCancel.Location = new System.Drawing.Point(261, 147);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Đóng";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtMeterId
            // 
            this.txtMeterId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeterId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtMeterId.Border.Class = "TextBoxBorder";
            this.txtMeterId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMeterId.ForeColor = System.Drawing.Color.Black;
            this.txtMeterId.Location = new System.Drawing.Point(79, 12);
            this.txtMeterId.Name = "txtMeterId";
            this.txtMeterId.Size = new System.Drawing.Size(257, 22);
            this.txtMeterId.TabIndex = 0;
            this.txtMeterId.WatermarkText = "Mã công tơ";
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
            this.txtSerial.ForeColor = System.Drawing.Color.Black;
            this.txtSerial.Location = new System.Drawing.Point(79, 38);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(257, 22);
            this.txtSerial.TabIndex = 1;
            this.txtSerial.WatermarkText = "Serial công tơ";
            // 
            // cbMeterType
            // 
            this.cbMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeterType.DisplayMember = "Text";
            this.cbMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeterType.ForeColor = System.Drawing.Color.Black;
            this.cbMeterType.FormattingEnabled = true;
            this.cbMeterType.ItemHeight = 16;
            this.cbMeterType.Location = new System.Drawing.Point(79, 64);
            this.cbMeterType.Name = "cbMeterType";
            this.cbMeterType.Size = new System.Drawing.Size(257, 22);
            this.cbMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMeterType.TabIndex = 2;
            this.cbMeterType.WatermarkText = "Loại đồng hồ";
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
            this.cboHistype.Location = new System.Drawing.Point(79, 116);
            this.cboHistype.Name = "cboHistype";
            this.cboHistype.Size = new System.Drawing.Size(257, 22);
            this.cboHistype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHistype.TabIndex = 4;
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
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(5, 87);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Hệ số nhân";
            // 
            // txtMultiplier
            // 
            // 
            // 
            // 
            this.txtMultiplier.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtMultiplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMultiplier.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtMultiplier.Increment = 1D;
            this.txtMultiplier.Location = new System.Drawing.Point(79, 91);
            this.txtMultiplier.MinValue = 1D;
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.ShowUpDown = true;
            this.txtMultiplier.Size = new System.Drawing.Size(257, 22);
            this.txtMultiplier.TabIndex = 7;
            this.txtMultiplier.Value = 1D;
            this.txtMultiplier.WatermarkText = "Hệ số nhân";
            // 
            // AddMeter
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(338, 172);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.cboHistype);
            this.Controls.Add(this.cbMeterType);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtMeterId);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO MỚI";
            this.Load += new System.EventHandler(this.UpdateMeter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btSave;
        private DevComponents.DotNetBar.ButtonX btCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMeterId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerial;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMeterType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHistype;
        private DevComponents.Editors.ComboItem selectCurrent;
        private DevComponents.Editors.ComboItem selectHistory;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DoubleInput txtMultiplier;
    }
}