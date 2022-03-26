namespace AmiOperationManagement.ErrorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCErrorDCU));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridFailDcu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clDcuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFirmwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFlashFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPenddingFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCompareByteFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReset = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clUpdateFirmware = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clEraseFlash = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btnSearchModem = new DevComponents.DotNetBar.ButtonX();
            this.btClean = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteModem = new DevComponents.DotNetBar.ButtonX();
            this.dtgRepairModem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ActionModemCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clErrorList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionStartTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEndtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFailDcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepairModem)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtGridFailDcu);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchModem);
            this.splitContainer1.Panel1.Controls.Add(this.btClean);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteModem);
            this.splitContainer1.Panel2.Controls.Add(this.dtgRepairModem);
            this.splitContainer1.Size = new System.Drawing.Size(846, 465);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(54, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modem trên mạng";
            // 
            // dtGridFailDcu
            // 
            this.dtGridFailDcu.AllowUserToAddRows = false;
            this.dtGridFailDcu.AllowUserToDeleteRows = false;
            this.dtGridFailDcu.AllowUserToResizeRows = false;
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
            this.clFirmwareVersion,
            this.clMeterType,
            this.clFlashFail,
            this.clPenddingFail,
            this.clCompareByteFail,
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
            this.dtGridFailDcu.Location = new System.Drawing.Point(3, 21);
            this.dtGridFailDcu.Name = "dtGridFailDcu";
            this.dtGridFailDcu.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFailDcu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridFailDcu.Size = new System.Drawing.Size(840, 179);
            this.dtGridFailDcu.TabIndex = 0;
            this.dtGridFailDcu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridFailDcu_CellClick);
            this.dtGridFailDcu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGridFailDcu_RowPostPaint);
            // 
            // clDcuCode
            // 
            this.clDcuCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDcuCode.HeaderText = "Mã modem";
            this.clDcuCode.MinimumWidth = 120;
            this.clDcuCode.Name = "clDcuCode";
            this.clDcuCode.ReadOnly = true;
            // 
            // clFirmwareVersion
            // 
            this.clFirmwareVersion.HeaderText = "Phiên bản";
            this.clFirmwareVersion.Name = "clFirmwareVersion";
            this.clFirmwareVersion.ReadOnly = true;
            // 
            // clMeterType
            // 
            this.clMeterType.HeaderText = "Công tơ";
            this.clMeterType.Name = "clMeterType";
            this.clMeterType.ReadOnly = true;
            // 
            // clFlashFail
            // 
            this.clFlashFail.HeaderText = "Lỗi Flash";
            this.clFlashFail.Name = "clFlashFail";
            this.clFlashFail.ReadOnly = true;
            // 
            // clPenddingFail
            // 
            this.clPenddingFail.HeaderText = "Lỗi Pendding";
            this.clPenddingFail.Name = "clPenddingFail";
            this.clPenddingFail.ReadOnly = true;
            // 
            // clCompareByteFail
            // 
            this.clCompareByteFail.HeaderText = "Lỗi so byte";
            this.clCompareByteFail.Name = "clCompareByteFail";
            this.clCompareByteFail.ReadOnly = true;
            // 
            // clReset
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Reset";
            this.clReset.DefaultCellStyle = dataGridViewCellStyle2;
            this.clReset.HeaderText = "";
            this.clReset.Name = "clReset";
            this.clReset.ReadOnly = true;
            this.clReset.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clReset.Text = null;
            this.clReset.Width = 75;
            // 
            // clUpdateFirmware
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "UpdateFirmware";
            this.clUpdateFirmware.DefaultCellStyle = dataGridViewCellStyle3;
            this.clUpdateFirmware.HeaderText = "";
            this.clUpdateFirmware.Name = "clUpdateFirmware";
            this.clUpdateFirmware.ReadOnly = true;
            this.clUpdateFirmware.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clUpdateFirmware.Text = null;
            this.clUpdateFirmware.Width = 130;
            // 
            // clEraseFlash
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Xoá Flash";
            this.clEraseFlash.DefaultCellStyle = dataGridViewCellStyle4;
            this.clEraseFlash.HeaderText = "";
            this.clEraseFlash.Name = "clEraseFlash";
            this.clEraseFlash.ReadOnly = true;
            this.clEraseFlash.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clEraseFlash.Text = null;
            // 
            // btnSearchModem
            // 
            this.btnSearchModem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchModem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchModem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchModem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchModem.Image")));
            this.btnSearchModem.Location = new System.Drawing.Point(687, 206);
            this.btnSearchModem.Name = "btnSearchModem";
            this.btnSearchModem.Size = new System.Drawing.Size(75, 23);
            this.btnSearchModem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchModem.TabIndex = 1;
            this.btnSearchModem.Text = "Tìm kiếm";
            this.btnSearchModem.Click += new System.EventHandler(this.btnSearchModem_Click);
            // 
            // btClean
            // 
            this.btClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClean.Image = ((System.Drawing.Image)(resources.GetObject("btClean.Image")));
            this.btClean.Location = new System.Drawing.Point(768, 206);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClean.TabIndex = 2;
            this.btClean.Text = "Xoá";
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modem đã xử lý";
            // 
            // btnDeleteModem
            // 
            this.btnDeleteModem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteModem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteModem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteModem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteModem.Image")));
            this.btnDeleteModem.Location = new System.Drawing.Point(771, 202);
            this.btnDeleteModem.Name = "btnDeleteModem";
            this.btnDeleteModem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteModem.TabIndex = 4;
            this.btnDeleteModem.Text = "Xoá";
            this.btnDeleteModem.Click += new System.EventHandler(this.btnDeleteModem_Click);
            // 
            // dtgRepairModem
            // 
            this.dtgRepairModem.AllowUserToAddRows = false;
            this.dtgRepairModem.AllowUserToDeleteRows = false;
            this.dtgRepairModem.AllowUserToResizeRows = false;
            this.dtgRepairModem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRepairModem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRepairModem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgRepairModem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepairModem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionModemCodeCol,
            this.clErrorList,
            this.ActionCol,
            this.ActionStartTimeCol,
            this.clEndtime,
            this.clStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRepairModem.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgRepairModem.EnableHeadersVisualStyles = false;
            this.dtgRepairModem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgRepairModem.Location = new System.Drawing.Point(3, 24);
            this.dtgRepairModem.Name = "dtgRepairModem";
            this.dtgRepairModem.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRepairModem.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgRepairModem.RowHeadersVisible = false;
            this.dtgRepairModem.Size = new System.Drawing.Size(840, 172);
            this.dtgRepairModem.TabIndex = 3;
            // 
            // ActionModemCodeCol
            // 
            this.ActionModemCodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionModemCodeCol.HeaderText = "Mã modem";
            this.ActionModemCodeCol.MinimumWidth = 120;
            this.ActionModemCodeCol.Name = "ActionModemCodeCol";
            this.ActionModemCodeCol.ReadOnly = true;
            // 
            // clErrorList
            // 
            this.clErrorList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clErrorList.HeaderText = "Danh sách lỗi";
            this.clErrorList.Name = "clErrorList";
            this.clErrorList.ReadOnly = true;
            // 
            // ActionCol
            // 
            this.ActionCol.HeaderText = "Mô tả hành động";
            this.ActionCol.Name = "ActionCol";
            this.ActionCol.ReadOnly = true;
            this.ActionCol.Width = 152;
            // 
            // ActionStartTimeCol
            // 
            this.ActionStartTimeCol.HeaderText = "Thời gian bắt đầu";
            this.ActionStartTimeCol.Name = "ActionStartTimeCol";
            this.ActionStartTimeCol.ReadOnly = true;
            this.ActionStartTimeCol.Width = 130;
            // 
            // clEndtime
            // 
            this.clEndtime.HeaderText = "Thời gian kết thúc";
            this.clEndtime.Name = "clEndtime";
            this.clEndtime.ReadOnly = true;
            this.clEndtime.Width = 130;
            // 
            // clStatus
            // 
            this.clStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clStatus.HeaderText = "Trạng thái";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            // 
            // UCErrorDCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCErrorDCU";
            this.Size = new System.Drawing.Size(846, 465);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFailDcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepairModem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btClean;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridFailDcu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnDeleteModem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgRepairModem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDcuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFirmwareVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFlashFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPenddingFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCompareByteFail;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clReset;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clUpdateFirmware;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEraseFlash;
        private DevComponents.DotNetBar.ButtonX btnSearchModem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionModemCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clErrorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionStartTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEndtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
    }
}
