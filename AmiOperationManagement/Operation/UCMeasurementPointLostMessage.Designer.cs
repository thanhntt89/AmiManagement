namespace AmiOperationManagement.ErrorManagement
{
    partial class UCMeasurementPointLostMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMeasurementPointLostMessage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDcuCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtLostDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            this.cboGateways = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbConnectionStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itDisplayAll = new DevComponents.Editors.ComboItem();
            this.itemConnected = new DevComponents.Editors.ComboItem();
            this.itemDisconnect = new DevComponents.Editors.ComboItem();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.chkCheckAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btSendRequest = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboMessageType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemOperation = new DevComponents.Editors.ComboItem();
            this.itemHistorical = new DevComponents.Editors.ComboItem();
            this.btnSearching = new DevComponents.DotNetBar.ButtonX();
            this.dtgLostMessage = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeasurementPointGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDcuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatusConnection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGatewayIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnCopyDcu = new System.Windows.Forms.ToolStripMenuItem();
            this.prgSend = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cboContract = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucEvnTreeView = new AmiOperationManagement.CustomeUserControl.UCEvnTreeView();
            this.lblMpGroup = new System.Windows.Forms.Label();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtLostDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLostMessage)).BeginInit();
            this.mnRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDcuCode
            // 
            this.txtDcuCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtDcuCode.Border.Class = "TextBoxBorder";
            this.txtDcuCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDcuCode.ForeColor = System.Drawing.Color.Black;
            this.txtDcuCode.Location = new System.Drawing.Point(87, 78);
            this.txtDcuCode.Name = "txtDcuCode";
            this.txtDcuCode.Size = new System.Drawing.Size(154, 20);
            this.txtDcuCode.TabIndex = 2;
            // 
            // dtLostDate
            // 
            this.dtLostDate.AutoAdvance = true;
            this.dtLostDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtLostDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtLostDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLostDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtLostDate.ButtonDropDown.Visible = true;
            this.dtLostDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtLostDate.ForeColor = System.Drawing.Color.Black;
            this.dtLostDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtLostDate.IsPopupCalendarOpen = false;
            this.dtLostDate.Location = new System.Drawing.Point(87, 54);
            // 
            // 
            // 
            this.dtLostDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtLostDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLostDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtLostDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtLostDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLostDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 10, 1, 0, 0, 0, 0);
            this.dtLostDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtLostDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtLostDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtLostDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLostDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtLostDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLostDate.MonthCalendar.TodayButtonVisible = true;
            this.dtLostDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtLostDate.Name = "dtLostDate";
            this.dtLostDate.Size = new System.Drawing.Size(154, 20);
            this.dtLostDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtLostDate.TabIndex = 1;
            this.dtLostDate.Value = new System.DateTime(2016, 11, 8, 17, 23, 30, 0);
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(3, 432);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(718, 28);
            this.ucBreakPage.TabIndex = 9;
            // 
            // cboGateways
            // 
            this.cboGateways.DisplayMember = "Text";
            this.cboGateways.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGateways.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGateways.FormattingEnabled = true;
            this.cboGateways.ItemHeight = 14;
            this.cboGateways.Location = new System.Drawing.Point(305, 55);
            this.cboGateways.Name = "cboGateways";
            this.cboGateways.Size = new System.Drawing.Size(259, 20);
            this.cboGateways.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGateways.TabIndex = 4;
            // 
            // cbConnectionStatus
            // 
            this.cbConnectionStatus.DisplayMember = "Text";
            this.cbConnectionStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbConnectionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnectionStatus.FormattingEnabled = true;
            this.cbConnectionStatus.ItemHeight = 14;
            this.cbConnectionStatus.Items.AddRange(new object[] {
            this.itDisplayAll,
            this.itemConnected,
            this.itemDisconnect});
            this.cbConnectionStatus.Location = new System.Drawing.Point(305, 31);
            this.cbConnectionStatus.Name = "cbConnectionStatus";
            this.cbConnectionStatus.Size = new System.Drawing.Size(259, 20);
            this.cbConnectionStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbConnectionStatus.TabIndex = 3;
            // 
            // itDisplayAll
            // 
            this.itDisplayAll.Image = ((System.Drawing.Image)(resources.GetObject("itDisplayAll.Image")));
            this.itDisplayAll.Text = "Tất cả";
            this.itDisplayAll.Value = "3";
            // 
            // itemConnected
            // 
            this.itemConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemConnected.Image = ((System.Drawing.Image)(resources.GetObject("itemConnected.Image")));
            this.itemConnected.Text = "Có kết nối";
            this.itemConnected.Value = "1";
            // 
            // itemDisconnect
            // 
            this.itemDisconnect.ForeColor = System.Drawing.Color.Red;
            this.itemDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("itemDisconnect.Image")));
            this.itemDisconnect.Text = "Mất kết nối";
            this.itemDisconnect.Value = "0";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(245, 53);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Server";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(5, 77);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(56, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Mã thiết bị";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(5, 53);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(77, 23);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "Thời điểm thiếu";
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.chkCheckAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkCheckAll.ForeColor = System.Drawing.Color.Black;
            this.chkCheckAll.Location = new System.Drawing.Point(60, 111);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(19, 16);
            this.chkCheckAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkCheckAll.TabIndex = 14;
            this.chkCheckAll.TextColor = System.Drawing.Color.Gray;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // btSendRequest
            // 
            this.btSendRequest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendRequest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSendRequest.Image = ((System.Drawing.Image)(resources.GetObject("btSendRequest.Image")));
            this.btSendRequest.Location = new System.Drawing.Point(649, 437);
            this.btSendRequest.Name = "btSendRequest";
            this.btSendRequest.Size = new System.Drawing.Size(72, 23);
            this.btSendRequest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSendRequest.TabIndex = 10;
            this.btSendRequest.Text = "Gửi lệnh";
            this.btSendRequest.Visible = false;
            this.btSendRequest.Click += new System.EventHandler(this.btSendRequest_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(245, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Trạng thái";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Loại bản tin";
            // 
            // cboMessageType
            // 
            this.cboMessageType.DisplayMember = "Text";
            this.cboMessageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMessageType.ForeColor = System.Drawing.Color.Black;
            this.cboMessageType.FormattingEnabled = true;
            this.cboMessageType.ItemHeight = 16;
            this.cboMessageType.Items.AddRange(new object[] {
            this.itemOperation,
            this.itemHistorical});
            this.cboMessageType.Location = new System.Drawing.Point(87, 29);
            this.cboMessageType.Name = "cboMessageType";
            this.cboMessageType.Size = new System.Drawing.Size(154, 22);
            this.cboMessageType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMessageType.TabIndex = 0;
            this.cboMessageType.WatermarkText = "Loại bản tin ";
            this.cboMessageType.SelectedIndexChanged += new System.EventHandler(this.cboMessageType_SelectedIndexChanged);
            // 
            // itemOperation
            // 
            this.itemOperation.Image = ((System.Drawing.Image)(resources.GetObject("itemOperation.Image")));
            this.itemOperation.Text = "Lấy bản tin vận hành";
            // 
            // itemHistorical
            // 
            this.itemHistorical.Image = ((System.Drawing.Image)(resources.GetObject("itemHistorical.Image")));
            this.itemHistorical.Text = "Lấy bản tin chốt";
            // 
            // btnSearching
            // 
            this.btnSearching.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearching.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearching.Image = ((System.Drawing.Image)(resources.GetObject("btnSearching.Image")));
            this.btnSearching.Location = new System.Drawing.Point(570, 76);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(75, 23);
            this.btnSearching.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearching.TabIndex = 7;
            this.btnSearching.Text = "Tìm";
            this.btnSearching.Click += new System.EventHandler(this.btSearchListDcuLost_Click);
            // 
            // dtgLostMessage
            // 
            this.dtgLostMessage.AllowUserToAddRows = false;
            this.dtgLostMessage.AllowUserToDeleteRows = false;
            this.dtgLostMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLostMessage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgLostMessage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLostMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLostMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.clContract,
            this.clMeasurementPointGroup,
            this.clDcuId,
            this.clName,
            this.clStatusConnection,
            this.clGatewayIp});
            this.dtgLostMessage.ContextMenuStrip = this.mnRightClick;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLostMessage.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgLostMessage.EnableHeadersVisualStyles = false;
            this.dtgLostMessage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgLostMessage.Location = new System.Drawing.Point(3, 106);
            this.dtgLostMessage.Name = "dtgLostMessage";
            this.dtgLostMessage.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLostMessage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgLostMessage.Size = new System.Drawing.Size(718, 320);
            this.dtgLostMessage.TabIndex = 8;
            this.dtgLostMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLostMessage_CellClick);
            this.dtgLostMessage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgLostMessage_RowPostPaint);
            this.dtgLostMessage.MouseCaptureChanged += new System.EventHandler(this.dtgLostMessage_MouseCaptureChanged);
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            this.clCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clCheckBox.Width = 50;
            // 
            // clContract
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clContract.DefaultCellStyle = dataGridViewCellStyle2;
            this.clContract.HeaderText = "Hợp đồng";
            this.clContract.Name = "clContract";
            this.clContract.ReadOnly = true;
            this.clContract.Width = 125;
            // 
            // clMeasurementPointGroup
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clMeasurementPointGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.clMeasurementPointGroup.HeaderText = "Điện lực";
            this.clMeasurementPointGroup.Name = "clMeasurementPointGroup";
            this.clMeasurementPointGroup.ReadOnly = true;
            this.clMeasurementPointGroup.Width = 150;
            // 
            // clDcuId
            // 
            this.clDcuId.HeaderText = "Mã modem";
            this.clDcuId.Name = "clDcuId";
            this.clDcuId.ReadOnly = true;
            this.clDcuId.Width = 120;
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clName.HeaderText = "Tên điểm đo";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // clStatusConnection
            // 
            this.clStatusConnection.HeaderText = "Trạng thái kết nối";
            this.clStatusConnection.Name = "clStatusConnection";
            this.clStatusConnection.ReadOnly = true;
            this.clStatusConnection.Width = 120;
            // 
            // clGatewayIp
            // 
            this.clGatewayIp.HeaderText = "Địa chỉ kết nối";
            this.clGatewayIp.Name = "clGatewayIp";
            this.clGatewayIp.ReadOnly = true;
            this.clGatewayIp.Width = 110;
            // 
            // mnRightClick
            // 
            this.mnRightClick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCopyDcu});
            this.mnRightClick.Name = "mnRightClick";
            this.mnRightClick.Size = new System.Drawing.Size(123, 26);
            // 
            // mnCopyDcu
            // 
            this.mnCopyDcu.Image = ((System.Drawing.Image)(resources.GetObject("mnCopyDcu.Image")));
            this.mnCopyDcu.Name = "mnCopyDcu";
            this.mnCopyDcu.Size = new System.Drawing.Size(122, 22);
            this.mnCopyDcu.Text = "Sao chép";
            this.mnCopyDcu.Click += new System.EventHandler(this.mnCopyDcu_Click);
            // 
            // prgSend
            // 
            this.prgSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.prgSend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgSend.Location = new System.Drawing.Point(7, 403);
            this.prgSend.Name = "prgSend";
            this.prgSend.Size = new System.Drawing.Size(714, 23);
            this.prgSend.TabIndex = 18;
            this.prgSend.Visible = false;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(245, 77);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(54, 23);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "Hợp đồng";
            // 
            // cboContract
            // 
            this.cboContract.DisplayMember = "Text";
            this.cboContract.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContract.FormattingEnabled = true;
            this.cboContract.ItemHeight = 14;
            this.cboContract.Location = new System.Drawing.Point(305, 78);
            this.cboContract.Name = "cboContract";
            this.cboContract.Size = new System.Drawing.Size(259, 20);
            this.cboContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboContract.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucEvnTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblMpGroup);
            this.splitContainer1.Panel2.Controls.Add(this.labelX9);
            this.splitContainer1.Panel2.Controls.Add(this.chkCheckAll);
            this.splitContainer1.Panel2.Controls.Add(this.prgSend);
            this.splitContainer1.Panel2.Controls.Add(this.dtgLostMessage);
            this.splitContainer1.Panel2.Controls.Add(this.txtDcuCode);
            this.splitContainer1.Panel2.Controls.Add(this.ucBreakPage);
            this.splitContainer1.Panel2.Controls.Add(this.dtLostDate);
            this.splitContainer1.Panel2.Controls.Add(this.cboContract);
            this.splitContainer1.Panel2.Controls.Add(this.btSendRequest);
            this.splitContainer1.Panel2.Controls.Add(this.cboMessageType);
            this.splitContainer1.Panel2.Controls.Add(this.cboGateways);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearching);
            this.splitContainer1.Panel2.Controls.Add(this.cbConnectionStatus);
            this.splitContainer1.Panel2.Controls.Add(this.labelX1);
            this.splitContainer1.Panel2.Controls.Add(this.labelX4);
            this.splitContainer1.Panel2.Controls.Add(this.labelX3);
            this.splitContainer1.Panel2.Controls.Add(this.labelX7);
            this.splitContainer1.Panel2.Controls.Add(this.labelX2);
            this.splitContainer1.Panel2.Controls.Add(this.labelX5);
            this.splitContainer1.Size = new System.Drawing.Size(941, 463);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 19;
            // 
            // ucEvnTreeView
            // 
            this.ucEvnTreeView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucEvnTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEvnTreeView.Location = new System.Drawing.Point(0, 0);
            this.ucEvnTreeView.Name = "ucEvnTreeView";
            this.ucEvnTreeView.Size = new System.Drawing.Size(213, 463);
            this.ucEvnTreeView.TabIndex = 0;
            // 
            // lblMpGroup
            // 
            this.lblMpGroup.AutoSize = true;
            this.lblMpGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMpGroup.Location = new System.Drawing.Point(117, 8);
            this.lblMpGroup.Name = "lblMpGroup";
            this.lblMpGroup.Size = new System.Drawing.Size(19, 13);
            this.lblMpGroup.TabIndex = 20;
            this.lblMpGroup.Text = "...";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(7, 3);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(104, 23);
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "Tìm kiếm dữ liệu tại:";
            // 
            // UCMeasurementPointLostMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCMeasurementPointLostMessage";
            this.Size = new System.Drawing.Size(941, 463);
            this.Load += new System.EventHandler(this.UCGetLostMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLostDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLostMessage)).EndInit();
            this.mnRightClick.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX chkCheckAll;
        private DevComponents.DotNetBar.ButtonX btSendRequest;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtLostDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMessageType;
        private DevComponents.Editors.ComboItem itemOperation;
        private DevComponents.Editors.ComboItem itemHistorical;
        private DevComponents.DotNetBar.ButtonX btnSearching;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgLostMessage;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbConnectionStatus;
        private DevComponents.Editors.ComboItem itemConnected;
        private DevComponents.Editors.ComboItem itemDisconnect;
        private DevComponents.Editors.ComboItem itDisplayAll;
        private CustomeUserControl.UCBreakPage ucBreakPage;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGateways;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDcuCode;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ProgressBarX prgSend;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboContract;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeasurementPointGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDcuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatusConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGatewayIp;
        private System.Windows.Forms.ContextMenuStrip mnRightClick;
        private System.Windows.Forms.ToolStripMenuItem mnCopyDcu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CustomeUserControl.UCEvnTreeView ucEvnTreeView;
        private System.Windows.Forms.Label lblMpGroup;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}
