namespace AmiOperationManagement.Deployment
{
    partial class UpdateMeasurementPointMeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMeasurementPointMeter));
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btCacelMp = new DevComponents.DotNetBar.ButtonX();
            this.btSaveMp = new DevComponents.DotNetBar.ButtonX();
            this.cboTypeMeter = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtCustomerAdrress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMpName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMpCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGroupMp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboContract = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboStation = new AmiOperationManagement.CustomeUserControl.EasyCompletionComboBox();
            this.cboMeterCode = new AmiOperationManagement.CustomeUserControl.EasyCompletionComboBox();
            this.cboDcuCode = new AmiOperationManagement.CustomeUserControl.EasyCompletionComboBox();
            this.cboCustomerCode = new AmiOperationManagement.CustomeUserControl.EasyCompletionComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(10, 166);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 292;
            this.labelX12.Text = "Mã công tơ";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(8, 222);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 291;
            this.labelX11.Text = "Mã khách hàng";
            // 
            // btCacelMp
            // 
            this.btCacelMp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCacelMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCacelMp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCacelMp.Image = ((System.Drawing.Image)(resources.GetObject("btCacelMp.Image")));
            this.btCacelMp.Location = new System.Drawing.Point(394, 324);
            this.btCacelMp.Name = "btCacelMp";
            this.btCacelMp.Size = new System.Drawing.Size(68, 23);
            this.btCacelMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCacelMp.TabIndex = 11;
            this.btCacelMp.Text = "Đóng";
            this.btCacelMp.Click += new System.EventHandler(this.btCacelMp_Click);
            // 
            // btSaveMp
            // 
            this.btSaveMp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSaveMp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveMp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSaveMp.Image = ((System.Drawing.Image)(resources.GetObject("btSaveMp.Image")));
            this.btSaveMp.Location = new System.Drawing.Point(314, 324);
            this.btSaveMp.Name = "btSaveMp";
            this.btSaveMp.Size = new System.Drawing.Size(75, 23);
            this.btSaveMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSaveMp.TabIndex = 10;
            this.btSaveMp.Text = "Lưu";
            this.btSaveMp.Click += new System.EventHandler(this.btSaveMp_Click);
            // 
            // cboTypeMeter
            // 
            this.cboTypeMeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTypeMeter.DisplayMember = "Text";
            this.cboTypeMeter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTypeMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeMeter.FormattingEnabled = true;
            this.cboTypeMeter.ItemHeight = 16;
            this.cboTypeMeter.Location = new System.Drawing.Point(330, 168);
            this.cboTypeMeter.Name = "cboTypeMeter";
            this.cboTypeMeter.Size = new System.Drawing.Size(132, 22);
            this.cboTypeMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTypeMeter.TabIndex = 6;
            // 
            // txtCustomerAdrress
            // 
            this.txtCustomerAdrress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerAdrress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCustomerAdrress.Border.Class = "TextBoxBorder";
            this.txtCustomerAdrress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerAdrress.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerAdrress.Location = new System.Drawing.Point(89, 249);
            this.txtCustomerAdrress.Multiline = true;
            this.txtCustomerAdrress.Name = "txtCustomerAdrress";
            this.txtCustomerAdrress.ReadOnly = true;
            this.txtCustomerAdrress.Size = new System.Drawing.Size(373, 63);
            this.txtCustomerAdrress.TabIndex = 9;
            // 
            // txtMpName
            // 
            this.txtMpName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMpName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMpName.Border.Class = "TextBoxBorder";
            this.txtMpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMpName.Enabled = false;
            this.txtMpName.ForeColor = System.Drawing.Color.Black;
            this.txtMpName.Location = new System.Drawing.Point(84, 45);
            this.txtMpName.Name = "txtMpName";
            this.txtMpName.ReadOnly = true;
            this.txtMpName.Size = new System.Drawing.Size(369, 20);
            this.txtMpName.TabIndex = 1;
            // 
            // txtMpCode
            // 
            this.txtMpCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMpCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMpCode.Border.Class = "TextBoxBorder";
            this.txtMpCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMpCode.Enabled = false;
            this.txtMpCode.ForeColor = System.Drawing.Color.Black;
            this.txtMpCode.Location = new System.Drawing.Point(84, 19);
            this.txtMpCode.Name = "txtMpCode";
            this.txtMpCode.ReadOnly = true;
            this.txtMpCode.Size = new System.Drawing.Size(369, 20);
            this.txtMpCode.TabIndex = 0;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(8, 251);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(86, 40);
            this.labelX9.TabIndex = 289;
            this.labelX9.Text = "Địa chỉ khách hàng";
            this.labelX9.WordWrap = true;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(10, 139);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 20);
            this.labelX8.TabIndex = 288;
            this.labelX8.Text = "Mã Modem";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(265, 169);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 20);
            this.labelX7.TabIndex = 287;
            this.labelX7.Text = "Loại công tơ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(7, 44);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 20);
            this.labelX4.TabIndex = 285;
            this.labelX4.Text = "Tên điểm đo";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(7, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 20);
            this.labelX3.TabIndex = 284;
            this.labelX3.Text = "Mã điểm đo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboGroupMp);
            this.groupBox1.Controls.Add(this.cboContract);
            this.groupBox1.Controls.Add(this.txtMpCode);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txtMpName);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 129);
            this.groupBox1.TabIndex = 293;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm đo";
            // 
            // cboGroupMp
            // 
            this.cboGroupMp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGroupMp.DisplayMember = "Text";
            this.cboGroupMp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGroupMp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupMp.Enabled = false;
            this.cboGroupMp.FormattingEnabled = true;
            this.cboGroupMp.ItemHeight = 16;
            this.cboGroupMp.Location = new System.Drawing.Point(84, 71);
            this.cboGroupMp.Name = "cboGroupMp";
            this.cboGroupMp.Size = new System.Drawing.Size(369, 22);
            this.cboGroupMp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGroupMp.TabIndex = 2;
            // 
            // cboContract
            // 
            this.cboContract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboContract.DisplayMember = "Text";
            this.cboContract.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContract.Enabled = false;
            this.cboContract.FormattingEnabled = true;
            this.cboContract.ItemHeight = 16;
            this.cboContract.Location = new System.Drawing.Point(84, 99);
            this.cboContract.Name = "cboContract";
            this.cboContract.Size = new System.Drawing.Size(369, 22);
            this.cboContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboContract.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(7, 96);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 20);
            this.labelX2.TabIndex = 285;
            this.labelX2.Text = "Hợp đồng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(7, 70);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 20);
            this.labelX1.TabIndex = 285;
            this.labelX1.Text = "Điện lực";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(8, 195);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 291;
            this.labelX5.Text = "Trạm điện";
            // 
            // cboStation
            // 
            this.cboStation.FormattingEnabled = true;
            this.cboStation.Location = new System.Drawing.Point(89, 195);
            this.cboStation.Name = "cboStation";
            this.cboStation.Size = new System.Drawing.Size(373, 21);
            this.cboStation.TabIndex = 7;
            // 
            // cboMeterCode
            // 
            this.cboMeterCode.FormattingEnabled = true;
            this.cboMeterCode.Location = new System.Drawing.Point(89, 169);
            this.cboMeterCode.Name = "cboMeterCode";
            this.cboMeterCode.Size = new System.Drawing.Size(170, 21);
            this.cboMeterCode.TabIndex = 5;
            this.cboMeterCode.SelectedIndexChanged += new System.EventHandler(this.cboMeterCode_SelectedIndexChanged);
            // 
            // cboDcuCode
            // 
            this.cboDcuCode.FormattingEnabled = true;
            this.cboDcuCode.Location = new System.Drawing.Point(89, 138);
            this.cboDcuCode.Name = "cboDcuCode";
            this.cboDcuCode.Size = new System.Drawing.Size(373, 21);
            this.cboDcuCode.TabIndex = 4;
            // 
            // cboCustomerCode
            // 
            this.cboCustomerCode.FormattingEnabled = true;
            this.cboCustomerCode.Location = new System.Drawing.Point(89, 222);
            this.cboCustomerCode.Name = "cboCustomerCode";
            this.cboCustomerCode.Size = new System.Drawing.Size(373, 21);
            this.cboCustomerCode.TabIndex = 8;
            this.cboCustomerCode.SelectedIndexChanged += new System.EventHandler(this.cboCustomerCode_SelectedIndexChanged);
            // 
            // UpdateMeasurementPointMeter
            // 
            this.AcceptButton = this.btSaveMp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 350);
            this.Controls.Add(this.cboCustomerCode);
            this.Controls.Add(this.cboStation);
            this.Controls.Add(this.cboMeterCode);
            this.Controls.Add(this.cboDcuCode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.btCacelMp);
            this.Controls.Add(this.btSaveMp);
            this.Controls.Add(this.cboTypeMeter);
            this.Controls.Add(this.txtCustomerAdrress);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateMeasurementPointMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật công tơ và khách hàng cho điểm đo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateMeasurementPointMeter_FormClosing);
            this.Load += new System.EventHandler(this.UpdateMeasurementPointMeter_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btCacelMp;
        private DevComponents.DotNetBar.ButtonX btSaveMp;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTypeMeter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustomerAdrress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMpName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMpCode;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGroupMp;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboContract;
        private DevComponents.DotNetBar.LabelX labelX5;
        private CustomeUserControl.EasyCompletionComboBox cboDcuCode;
        private CustomeUserControl.EasyCompletionComboBox cboMeterCode;
        private CustomeUserControl.EasyCompletionComboBox cboStation;
        private CustomeUserControl.EasyCompletionComboBox cboCustomerCode;
    }
}