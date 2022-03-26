namespace AmiOperationManagement.Deployment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDcuManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtCreateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtCreateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cboGateways = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboAll = new DevComponents.Editors.ComboItem();
            this.cboActive = new DevComponents.Editors.ComboItem();
            this.cboDisable = new DevComponents.Editors.ComboItem();
            this.cboConnectionStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemSelectAll = new DevComponents.Editors.ComboItem();
            this.itemConnected = new DevComponents.Editors.ComboItem();
            this.itemDisconnected = new DevComponents.Editors.ComboItem();
            this.dtgSearchDcu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btClear = new DevComponents.DotNetBar.ButtonX();
            this.btCreateDcu = new DevComponents.DotNetBar.ButtonX();
            this.btsearchDcu = new DevComponents.DotNetBar.ButtonX();
            this.txtSerialSim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDcuId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            this.clDcuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGatewayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLanchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clConnectionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLastTimeConnectionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProtocoVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSingal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSimTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMcuTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRtcPinVoltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCellIdConnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSimNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSimSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSvnVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clDeleted = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchDcu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCreateTo
            // 
            // 
            // 
            // 
            this.dtCreateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtCreateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateTo.ButtonClear.Visible = true;
            this.dtCreateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtCreateTo.ButtonDropDown.Visible = true;
            this.dtCreateTo.IsPopupCalendarOpen = false;
            this.dtCreateTo.Location = new System.Drawing.Point(326, 80);
            // 
            // 
            // 
            this.dtCreateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtCreateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtCreateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateTo.MonthCalendar.DisplayMonth = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dtCreateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtCreateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtCreateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtCreateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateTo.MonthCalendar.TodayButtonVisible = true;
            this.dtCreateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtCreateTo.Name = "dtCreateTo";
            this.dtCreateTo.Size = new System.Drawing.Size(181, 20);
            this.dtCreateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateTo.TabIndex = 7;
            // 
            // dtCreateFrom
            // 
            // 
            // 
            // 
            this.dtCreateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtCreateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateFrom.ButtonClear.Visible = true;
            this.dtCreateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtCreateFrom.ButtonDropDown.Visible = true;
            this.dtCreateFrom.IsPopupCalendarOpen = false;
            this.dtCreateFrom.Location = new System.Drawing.Point(75, 81);
            // 
            // 
            // 
            this.dtCreateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtCreateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtCreateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dtCreateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtCreateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtCreateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtCreateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtCreateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtCreateFrom.Name = "dtCreateFrom";
            this.dtCreateFrom.Size = new System.Drawing.Size(181, 20);
            this.dtCreateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateFrom.TabIndex = 6;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(262, 80);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(58, 23);
            this.labelX5.TabIndex = 34;
            this.labelX5.Text = "Đến";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(4, 80);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(68, 23);
            this.labelX6.TabIndex = 35;
            this.labelX6.Text = "Ngày tạo từ";
            // 
            // cboGateways
            // 
            this.cboGateways.DisplayMember = "Text";
            this.cboGateways.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGateways.ForeColor = System.Drawing.Color.Black;
            this.cboGateways.FormattingEnabled = true;
            this.cboGateways.ItemHeight = 16;
            this.cboGateways.Location = new System.Drawing.Point(75, 55);
            this.cboGateways.Name = "cboGateways";
            this.cboGateways.Size = new System.Drawing.Size(181, 22);
            this.cboGateways.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGateways.TabIndex = 2;
            this.cboGateways.WatermarkText = "Địa chỉ máy chủ";
            // 
            // cboStatus
            // 
            this.cboStatus.DisplayMember = "Text";
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 16;
            this.cboStatus.Items.AddRange(new object[] {
            this.cboAll,
            this.cboActive,
            this.cboDisable});
            this.cboStatus.Location = new System.Drawing.Point(326, 54);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(181, 22);
            this.cboStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboStatus.TabIndex = 5;
            this.cboStatus.WatermarkText = "Tình trạng sử dụng";
            // 
            // cboAll
            // 
            this.cboAll.Image = ((System.Drawing.Image)(resources.GetObject("cboAll.Image")));
            this.cboAll.Text = "Tất cả";
            this.cboAll.Value = "all";
            // 
            // cboActive
            // 
            this.cboActive.Image = ((System.Drawing.Image)(resources.GetObject("cboActive.Image")));
            this.cboActive.Text = "Hoạt động";
            this.cboActive.Value = "Actived";
            // 
            // cboDisable
            // 
            this.cboDisable.Image = ((System.Drawing.Image)(resources.GetObject("cboDisable.Image")));
            this.cboDisable.Text = "Đã xoá";
            // 
            // cboConnectionStatus
            // 
            this.cboConnectionStatus.DisplayMember = "Text";
            this.cboConnectionStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboConnectionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnectionStatus.ForeColor = System.Drawing.Color.Black;
            this.cboConnectionStatus.FormattingEnabled = true;
            this.cboConnectionStatus.ItemHeight = 16;
            this.cboConnectionStatus.Items.AddRange(new object[] {
            this.itemSelectAll,
            this.itemConnected,
            this.itemDisconnected});
            this.cboConnectionStatus.Location = new System.Drawing.Point(75, 29);
            this.cboConnectionStatus.Name = "cboConnectionStatus";
            this.cboConnectionStatus.Size = new System.Drawing.Size(181, 22);
            this.cboConnectionStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboConnectionStatus.TabIndex = 1;
            this.cboConnectionStatus.WatermarkText = "Trạng thái kết nối";
            // 
            // itemSelectAll
            // 
            this.itemSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("itemSelectAll.Image")));
            this.itemSelectAll.Text = "Tất cả";
            this.itemSelectAll.Value = "all";
            // 
            // itemConnected
            // 
            this.itemConnected.Image = ((System.Drawing.Image)(resources.GetObject("itemConnected.Image")));
            this.itemConnected.Text = "Kết nối";
            this.itemConnected.Value = "Actived";
            // 
            // itemDisconnected
            // 
            this.itemDisconnected.Image = ((System.Drawing.Image)(resources.GetObject("itemDisconnected.Image")));
            this.itemDisconnected.Text = "Mất kết nối";
            // 
            // dtgSearchDcu
            // 
            this.dtgSearchDcu.AllowUserToAddRows = false;
            this.dtgSearchDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSearchDcu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchDcu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSearchDcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchDcu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDcuId,
            this.clGatewayId,
            this.clLanchDate,
            this.clConnectionStatus,
            this.clLastTimeConnectionStatus,
            this.clStatus,
            this.clProtocoVersion,
            this.clSingal,
            this.clSimTemperature,
            this.clMcuTemperature,
            this.clRtcPinVoltage,
            this.clCellIdConnect,
            this.clSimNumber,
            this.clSimSerial,
            this.clSvnVersion,
            this.clEdit,
            this.clDeleted,
            this.clId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSearchDcu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgSearchDcu.EnableHeadersVisualStyles = false;
            this.dtgSearchDcu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgSearchDcu.Location = new System.Drawing.Point(3, 107);
            this.dtgSearchDcu.Name = "dtgSearchDcu";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchDcu.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgSearchDcu.Size = new System.Drawing.Size(723, 309);
            this.dtgSearchDcu.TabIndex = 9;
            this.dtgSearchDcu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchDcu_CellClick);
            this.dtgSearchDcu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchDcu_CellDoubleClick);
            this.dtgSearchDcu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgSearchDcu_RowPostPaint);
            // 
            // btClear
            // 
            this.btClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.Location = new System.Drawing.Point(513, 49);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(69, 23);
            this.btClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Xoá";
            this.btClear.Click += new System.EventHandler(this.btCleanDcu_Click);
            // 
            // btCreateDcu
            // 
            this.btCreateDcu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCreateDcu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateDcu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCreateDcu.Image = ((System.Drawing.Image)(resources.GetObject("btCreateDcu.Image")));
            this.btCreateDcu.Location = new System.Drawing.Point(651, 422);
            this.btCreateDcu.Name = "btCreateDcu";
            this.btCreateDcu.Size = new System.Drawing.Size(75, 23);
            this.btCreateDcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCreateDcu.TabIndex = 11;
            this.btCreateDcu.Text = "Tạo mới";
            this.btCreateDcu.Click += new System.EventHandler(this.btCreateDcu_Click);
            // 
            // btsearchDcu
            // 
            this.btsearchDcu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsearchDcu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btsearchDcu.Image = ((System.Drawing.Image)(resources.GetObject("btsearchDcu.Image")));
            this.btsearchDcu.Location = new System.Drawing.Point(513, 78);
            this.btsearchDcu.Name = "btsearchDcu";
            this.btsearchDcu.Size = new System.Drawing.Size(69, 23);
            this.btsearchDcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btsearchDcu.TabIndex = 8;
            this.btsearchDcu.Text = "Tìm";
            this.btsearchDcu.Click += new System.EventHandler(this.btsearchDcu_Click);
            // 
            // txtSerialSim
            // 
            this.txtSerialSim.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSerialSim.Border.Class = "TextBoxBorder";
            this.txtSerialSim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerialSim.ForeColor = System.Drawing.Color.Black;
            this.txtSerialSim.Location = new System.Drawing.Point(326, 30);
            this.txtSerialSim.Name = "txtSerialSim";
            this.txtSerialSim.Size = new System.Drawing.Size(181, 20);
            this.txtSerialSim.TabIndex = 4;
            this.txtSerialSim.WatermarkText = "Nhập serialSim";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMobile.ForeColor = System.Drawing.Color.Black;
            this.txtMobile.Location = new System.Drawing.Point(326, 6);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(181, 20);
            this.txtMobile.TabIndex = 3;
            this.txtMobile.WatermarkText = "Nhập số điện thoại";
            // 
            // txtDcuId
            // 
            this.txtDcuId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDcuId.Border.Class = "TextBoxBorder";
            this.txtDcuId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDcuId.ForeColor = System.Drawing.Color.Black;
            this.txtDcuId.Location = new System.Drawing.Point(75, 6);
            this.txtDcuId.Name = "txtDcuId";
            this.txtDcuId.Size = new System.Drawing.Size(181, 20);
            this.txtDcuId.TabIndex = 0;
            this.txtDcuId.WatermarkText = "Nhập mã thiết bị";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(4, 55);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(58, 23);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "GatewayIP";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(4, 29);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(58, 23);
            this.labelX8.TabIndex = 7;
            this.labelX8.Text = "Trạng thái";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(262, 55);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Tình trạng";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(262, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Serial Sim";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(259, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Điện thoại";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Mã thiết bị";
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(0, 422);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(645, 27);
            this.ucBreakPage.TabIndex = 10;
            // 
            // clDcuId
            // 
            this.clDcuId.HeaderText = "Mã thiết bị";
            this.clDcuId.Name = "clDcuId";
            this.clDcuId.ReadOnly = true;
            this.clDcuId.Width = 120;
            // 
            // clGatewayId
            // 
            this.clGatewayId.HeaderText = "Gateway";
            this.clGatewayId.Name = "clGatewayId";
            this.clGatewayId.ReadOnly = true;
            // 
            // clLanchDate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clLanchDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clLanchDate.HeaderText = "Ngày hoạt động";
            this.clLanchDate.Name = "clLanchDate";
            this.clLanchDate.ReadOnly = true;
            this.clLanchDate.Width = 120;
            // 
            // clConnectionStatus
            // 
            this.clConnectionStatus.HeaderText = "Trạng thái kết nối";
            this.clConnectionStatus.Name = "clConnectionStatus";
            this.clConnectionStatus.ReadOnly = true;
            this.clConnectionStatus.Width = 125;
            // 
            // clLastTimeConnectionStatus
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clLastTimeConnectionStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.clLastTimeConnectionStatus.HeaderText = "Thời gian TT cuối";
            this.clLastTimeConnectionStatus.Name = "clLastTimeConnectionStatus";
            this.clLastTimeConnectionStatus.ReadOnly = true;
            this.clLastTimeConnectionStatus.Width = 120;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Tình trạng ";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            // 
            // clProtocoVersion
            // 
            this.clProtocoVersion.HeaderText = "Phiên bản";
            this.clProtocoVersion.Name = "clProtocoVersion";
            this.clProtocoVersion.ReadOnly = true;
            // 
            // clSingal
            // 
            this.clSingal.HeaderText = "Tín hiệu";
            this.clSingal.Name = "clSingal";
            this.clSingal.ReadOnly = true;
            // 
            // clSimTemperature
            // 
            this.clSimTemperature.HeaderText = "Nhiệt độ SIM";
            this.clSimTemperature.Name = "clSimTemperature";
            this.clSimTemperature.ReadOnly = true;
            // 
            // clMcuTemperature
            // 
            this.clMcuTemperature.HeaderText = "Nhiệt độ MCU";
            this.clMcuTemperature.Name = "clMcuTemperature";
            this.clMcuTemperature.ReadOnly = true;
            this.clMcuTemperature.Width = 120;
            // 
            // clRtcPinVoltage
            // 
            this.clRtcPinVoltage.HeaderText = "Điện áp PIN";
            this.clRtcPinVoltage.Name = "clRtcPinVoltage";
            this.clRtcPinVoltage.ReadOnly = true;
            // 
            // clCellIdConnect
            // 
            this.clCellIdConnect.HeaderText = "CellIdConnect";
            this.clCellIdConnect.Name = "clCellIdConnect";
            this.clCellIdConnect.ReadOnly = true;
            // 
            // clSimNumber
            // 
            this.clSimNumber.HeaderText = "Số điện thoại";
            this.clSimNumber.Name = "clSimNumber";
            this.clSimNumber.ReadOnly = true;
            this.clSimNumber.Width = 150;
            // 
            // clSimSerial
            // 
            this.clSimSerial.HeaderText = "Số Serial Sim";
            this.clSimSerial.Name = "clSimSerial";
            this.clSimSerial.ReadOnly = true;
            this.clSimSerial.Width = 150;
            // 
            // clSvnVersion
            // 
            this.clSvnVersion.HeaderText = "Phiên bản SVN";
            this.clSvnVersion.Name = "clSvnVersion";
            this.clSvnVersion.ReadOnly = true;
            this.clSvnVersion.Width = 120;
            // 
            // clEdit
            // 
            this.clEdit.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Sửa";
            this.clEdit.DefaultCellStyle = dataGridViewCellStyle4;
            this.clEdit.HeaderText = "";
            this.clEdit.Name = "clEdit";
            this.clEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clEdit.Text = null;
            this.clEdit.Width = 75;
            // 
            // clDeleted
            // 
            this.clDeleted.DataPropertyName = "Mã DCU";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "Xoá";
            this.clDeleted.DefaultCellStyle = dataGridViewCellStyle5;
            this.clDeleted.HeaderText = "";
            this.clDeleted.Name = "clDeleted";
            this.clDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDeleted.Text = null;
            this.clDeleted.Width = 75;
            // 
            // clId
            // 
            this.clId.HeaderText = "clId";
            this.clId.Name = "clId";
            this.clId.Visible = false;
            // 
            // UCDcuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dtCreateTo);
            this.Controls.Add(this.dtCreateFrom);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.ucBreakPage);
            this.Controls.Add(this.cboGateways);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboConnectionStatus);
            this.Controls.Add(this.dtgSearchDcu);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCreateDcu);
            this.Controls.Add(this.btsearchDcu);
            this.Controls.Add(this.txtSerialSim);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtDcuId);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "UCDcuManagement";
            this.Size = new System.Drawing.Size(729, 451);
            this.Load += new System.EventHandler(this.UCDcuManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchDcu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSearchDcu;
        private DevComponents.DotNetBar.ButtonX btClear;
        private DevComponents.DotNetBar.ButtonX btCreateDcu;
        private DevComponents.DotNetBar.ButtonX btsearchDcu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDcuId;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerialSim;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboConnectionStatus;
        private DevComponents.Editors.ComboItem itemSelectAll;
        private DevComponents.Editors.ComboItem itemConnected;
        private DevComponents.Editors.ComboItem itemDisconnected;
        private CustomeUserControl.UCBreakPage ucBreakPage;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateFrom;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGateways;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboStatus;
        private DevComponents.Editors.ComboItem cboAll;
        private DevComponents.Editors.ComboItem cboActive;
        private DevComponents.Editors.ComboItem cboDisable;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDcuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGatewayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLanchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clConnectionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLastTimeConnectionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProtocoVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSingal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSimTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMcuTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRtcPinVoltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCellIdConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSimNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSimSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSvnVersion;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    }
}
