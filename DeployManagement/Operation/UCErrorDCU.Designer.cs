namespace DeployManagement.Operation
{
    partial class UCErrorDCU
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
            this.btClean = new DevComponents.DotNetBar.ButtonX();
            this.dtGridFailDcu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clDcuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFlashFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFirmwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPenddingFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCompareByteFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clUpdateFirmware = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clEraseFlash = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFailDcu)).BeginInit();
            this.SuspendLayout();
            // 
            // btClean
            // 
            this.btClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClean.Location = new System.Drawing.Point(849, 369);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClean.TabIndex = 3;
            this.btClean.Text = "Xoá";
            // 
            // dtGridFailDcu
            // 
            this.dtGridFailDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridFailDcu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFailDcu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridFailDcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFailDcu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDcuCode,
            this.clFlashFail,
            this.clFirmwareVersion,
            this.clPenddingFail,
            this.clCompareByteFail,
            this.clMeterType,
            this.clReset,
            this.clUpdateFirmware,
            this.clEraseFlash});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridFailDcu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridFailDcu.EnableHeadersVisualStyles = false;
            this.dtGridFailDcu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGridFailDcu.Location = new System.Drawing.Point(3, 3);
            this.dtGridFailDcu.Name = "dtGridFailDcu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFailDcu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridFailDcu.Size = new System.Drawing.Size(921, 360);
            this.dtGridFailDcu.TabIndex = 2;
            // 
            // clDcuCode
            // 
            this.clDcuCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDcuCode.HeaderText = "Mã thiết bị";
            this.clDcuCode.Name = "clDcuCode";
            // 
            // clFlashFail
            // 
            this.clFlashFail.HeaderText = "Lỗi Flash";
            this.clFlashFail.Name = "clFlashFail";
            // 
            // clFirmwareVersion
            // 
            this.clFirmwareVersion.HeaderText = "Phiên bản phần mềm";
            this.clFirmwareVersion.Name = "clFirmwareVersion";
            // 
            // clPenddingFail
            // 
            this.clPenddingFail.HeaderText = "Lỗi Pendding";
            this.clPenddingFail.Name = "clPenddingFail";
            // 
            // clCompareByteFail
            // 
            this.clCompareByteFail.HeaderText = "Lỗi so byte";
            this.clCompareByteFail.Name = "clCompareByteFail";
            // 
            // clMeterType
            // 
            this.clMeterType.HeaderText = "Loại công tơ";
            this.clMeterType.Name = "clMeterType";
            // 
            // clReset
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Reset";
            this.clReset.DefaultCellStyle = dataGridViewCellStyle2;
            this.clReset.HeaderText = "";
            this.clReset.Name = "clReset";
            this.clReset.Width = 75;
            // 
            // clUpdateFirmware
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "UpdateFirmware";
            this.clUpdateFirmware.DefaultCellStyle = dataGridViewCellStyle3;
            this.clUpdateFirmware.HeaderText = "";
            this.clUpdateFirmware.Name = "clUpdateFirmware";
            this.clUpdateFirmware.Width = 120;
            // 
            // clEraseFlash
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Xoá Flash";
            this.clEraseFlash.DefaultCellStyle = dataGridViewCellStyle4;
            this.clEraseFlash.HeaderText = "";
            this.clEraseFlash.Name = "clEraseFlash";
            this.clEraseFlash.Width = 80;
            // 
            // UCErrorDCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.dtGridFailDcu);
            this.Name = "UCErrorDCU";
            this.Size = new System.Drawing.Size(927, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFailDcu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btClean;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridFailDcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDcuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFlashFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFirmwareVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPenddingFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCompareByteFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterType;
        private System.Windows.Forms.DataGridViewButtonColumn clReset;
        private System.Windows.Forms.DataGridViewButtonColumn clUpdateFirmware;
        private System.Windows.Forms.DataGridViewButtonColumn clEraseFlash;
    }
}
