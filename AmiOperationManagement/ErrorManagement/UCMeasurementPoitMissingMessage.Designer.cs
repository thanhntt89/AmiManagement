namespace AmiOperationManagement.ErrorManagement
{
    partial class UCMeasurementPoitMissingMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMeasurementPoitMissingMessage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMeterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.dtErrorTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTotalCount = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtgErrorList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ChooseCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.CreatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementPointCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForwardToCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFixedStatusCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.SolutionCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.ErrorIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboAll = new DevComponents.Editors.ComboItem();
            this.itemError = new DevComponents.Editors.ComboItem();
            this.itemFixed = new DevComponents.Editors.ComboItem();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboGroupName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.chkAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cboErrorList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnClean = new DevComponents.DotNetBar.ButtonX();
            this.prgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(723, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Tạo phiếu sửa lỗi";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(613, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thời gian tính từ: 0->59 phút";
            // 
            // cboMeterType
            // 
            this.cboMeterType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMeterType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMeterType.DisplayMember = "MeterType";
            this.cboMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeterType.FormattingEnabled = true;
            this.cboMeterType.ItemHeight = 14;
            this.cboMeterType.Location = new System.Drawing.Point(369, 30);
            this.cboMeterType.Name = "cboMeterType";
            this.cboMeterType.Size = new System.Drawing.Size(238, 20);
            this.cboMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMeterType.TabIndex = 4;
            this.cboMeterType.ValueMember = "DcuType";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(306, 30);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Loại công tơ";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(613, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtErrorTime
            // 
            this.dtErrorTime.AutoOffFreeTextEntry = true;
            // 
            // 
            // 
            this.dtErrorTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtErrorTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.ButtonClear.Visible = true;
            this.dtErrorTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtErrorTime.ButtonDropDown.Visible = true;
            this.dtErrorTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtErrorTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtErrorTime.IsPopupCalendarOpen = false;
            this.dtErrorTime.Location = new System.Drawing.Point(369, 3);
            // 
            // 
            // 
            this.dtErrorTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtErrorTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtErrorTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtErrorTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.MonthCalendar.DisplayMonth = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            this.dtErrorTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtErrorTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtErrorTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtErrorTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtErrorTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtErrorTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.MonthCalendar.TodayButtonVisible = true;
            this.dtErrorTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtErrorTime.Name = "dtErrorTime";
            this.dtErrorTime.Size = new System.Drawing.Size(238, 20);
            this.dtErrorTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtErrorTime.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lblTotalCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalCount.Location = new System.Drawing.Point(54, 445);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(49, 23);
            this.lblTotalCount.TabIndex = 10;
            this.lblTotalCount.Text = "....";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 445);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(45, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Tổng số:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(306, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Thời gian";
            // 
            // dtgErrorList
            // 
            this.dtgErrorList.AllowUserToAddRows = false;
            this.dtgErrorList.AllowUserToDeleteRows = false;
            this.dtgErrorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgErrorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgErrorList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgErrorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseCol,
            this.CreatedDateCol,
            this.DcuCodeCol,
            this.MeterTypeCol,
            this.MeasurementPointCol,
            this.LocationCol,
            this.GroupNameCol,
            this.ErrorCodeCol,
            this.ErrorNameCol,
            this.ForwardToCol,
            this.FixDateCol,
            this.FixContentCol,
            this.IsFixedStatusCol,
            this.SolutionCol,
            this.ErrorIdCol});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgErrorList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgErrorList.EnableHeadersVisualStyles = false;
            this.dtgErrorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgErrorList.Location = new System.Drawing.Point(3, 82);
            this.dtgErrorList.Name = "dtgErrorList";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgErrorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgErrorList.Size = new System.Drawing.Size(835, 357);
            this.dtgErrorList.TabIndex = 8;
            this.dtgErrorList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgErrorList_RowPostPaint);
            // 
            // ChooseCol
            // 
            this.ChooseCol.Checked = true;
            this.ChooseCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ChooseCol.CheckValue = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ChooseCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChooseCol.Frozen = true;
            this.ChooseCol.HeaderText = "";
            this.ChooseCol.Name = "ChooseCol";
            this.ChooseCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChooseCol.Width = 50;
            // 
            // CreatedDateCol
            // 
            this.CreatedDateCol.DataPropertyName = "CreatedDateCol";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.CreatedDateCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreatedDateCol.Frozen = true;
            this.CreatedDateCol.HeaderText = "Ngày tạo";
            this.CreatedDateCol.Name = "CreatedDateCol";
            this.CreatedDateCol.ReadOnly = true;
            this.CreatedDateCol.Width = 120;
            // 
            // DcuCodeCol
            // 
            this.DcuCodeCol.DataPropertyName = "DcuCodeCol";
            this.DcuCodeCol.Frozen = true;
            this.DcuCodeCol.HeaderText = "Mã thiết bị";
            this.DcuCodeCol.Name = "DcuCodeCol";
            this.DcuCodeCol.ReadOnly = true;
            this.DcuCodeCol.Width = 120;
            // 
            // MeterTypeCol
            // 
            this.MeterTypeCol.DataPropertyName = "MeterTypeCol";
            this.MeterTypeCol.HeaderText = "Loại công tơ";
            this.MeterTypeCol.Name = "MeterTypeCol";
            this.MeterTypeCol.ReadOnly = true;
            this.MeterTypeCol.Width = 120;
            // 
            // MeasurementPointCol
            // 
            this.MeasurementPointCol.HeaderText = "Mã điểm đo";
            this.MeasurementPointCol.Name = "MeasurementPointCol";
            this.MeasurementPointCol.ReadOnly = true;
            this.MeasurementPointCol.Width = 120;
            // 
            // LocationCol
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocationCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.LocationCol.HeaderText = "Tên điểm đo";
            this.LocationCol.MinimumWidth = 150;
            this.LocationCol.Name = "LocationCol";
            this.LocationCol.ReadOnly = true;
            this.LocationCol.Width = 200;
            // 
            // GroupNameCol
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupNameCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.GroupNameCol.HeaderText = "Điện lực";
            this.GroupNameCol.Name = "GroupNameCol";
            this.GroupNameCol.ReadOnly = true;
            this.GroupNameCol.Width = 160;
            // 
            // ErrorCodeCol
            // 
            this.ErrorCodeCol.DataPropertyName = "ErrorCodeCol";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ErrorCodeCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.ErrorCodeCol.HeaderText = "Mã lỗi";
            this.ErrorCodeCol.Name = "ErrorCodeCol";
            this.ErrorCodeCol.ReadOnly = true;
            this.ErrorCodeCol.Width = 70;
            // 
            // ErrorNameCol
            // 
            this.ErrorNameCol.DataPropertyName = "ErrorNameCol";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorNameCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.ErrorNameCol.HeaderText = "Tên lỗi";
            this.ErrorNameCol.Name = "ErrorNameCol";
            this.ErrorNameCol.ReadOnly = true;
            this.ErrorNameCol.Width = 250;
            // 
            // ForwardToCol
            // 
            this.ForwardToCol.DataPropertyName = "ForwardToCol";
            this.ForwardToCol.HeaderText = "Đơn vị xử lý";
            this.ForwardToCol.Name = "ForwardToCol";
            this.ForwardToCol.ReadOnly = true;
            // 
            // FixDateCol
            // 
            this.FixDateCol.DataPropertyName = "FixDateCol";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FixDateCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.FixDateCol.HeaderText = "Thời gian sửa";
            this.FixDateCol.Name = "FixDateCol";
            this.FixDateCol.ReadOnly = true;
            this.FixDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FixDateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FixContentCol
            // 
            this.FixContentCol.HeaderText = "Hướng dẫn xử lý";
            this.FixContentCol.Name = "FixContentCol";
            this.FixContentCol.ReadOnly = true;
            this.FixContentCol.Width = 250;
            // 
            // IsFixedStatusCol
            // 
            this.IsFixedStatusCol.Checked = true;
            this.IsFixedStatusCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsFixedStatusCol.CheckValue = "N";
            this.IsFixedStatusCol.DataPropertyName = "IsFixedStatusCol";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsFixedStatusCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.IsFixedStatusCol.HeaderText = "Đã sửa";
            this.IsFixedStatusCol.Name = "IsFixedStatusCol";
            this.IsFixedStatusCol.ReadOnly = true;
            this.IsFixedStatusCol.Width = 50;
            // 
            // SolutionCol
            // 
            this.SolutionCol.DataPropertyName = "SolutionCol";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "Xử lý";
            this.SolutionCol.DefaultCellStyle = dataGridViewCellStyle10;
            this.SolutionCol.HeaderText = "";
            this.SolutionCol.Name = "SolutionCol";
            this.SolutionCol.ReadOnly = true;
            this.SolutionCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SolutionCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SolutionCol.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.SolutionCol.Text = null;
            this.SolutionCol.Visible = false;
            this.SolutionCol.Width = 75;
            // 
            // ErrorIdCol
            // 
            this.ErrorIdCol.HeaderText = "ErrorIdCol";
            this.ErrorIdCol.Name = "ErrorIdCol";
            this.ErrorIdCol.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 14;
            this.cboStatus.Items.AddRange(new object[] {
            this.cboAll,
            this.itemError,
            this.itemFixed});
            this.cboStatus.Location = new System.Drawing.Point(72, 3);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(228, 20);
            this.cboStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboStatus.TabIndex = 0;
            // 
            // cboAll
            // 
            this.cboAll.Text = "Tất cả";
            // 
            // itemError
            // 
            this.itemError.Text = "Lỗi";
            // 
            // itemFixed
            // 
            this.itemFixed.Text = "Đã sửa lỗi";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(63, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Trạng thái";
            // 
            // cboGroupName
            // 
            this.cboGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGroupName.DisplayMember = "MeterType";
            this.cboGroupName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupName.FormattingEnabled = true;
            this.cboGroupName.ItemHeight = 14;
            this.cboGroupName.Location = new System.Drawing.Point(72, 56);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Size = new System.Drawing.Size(228, 20);
            this.cboGroupName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGroupName.TabIndex = 2;
            this.cboGroupName.ValueMember = "DcuType";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(3, 55);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(63, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Điện lực";
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboForwardTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(72, 29);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(228, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.cboForwardTo.TabIndex = 1;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 27);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(67, 23);
            this.labelX6.TabIndex = 45;
            this.labelX6.Text = "Đơn vị xử lý";
            // 
            // chkAll
            // 
            this.chkAll.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(61, 88);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(16, 15);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 46;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(306, 55);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(57, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Loại lỗi";
            // 
            // cboErrorList
            // 
            this.cboErrorList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboErrorList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboErrorList.DisplayMember = "MeterType";
            this.cboErrorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboErrorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorList.FormattingEnabled = true;
            this.cboErrorList.ItemHeight = 14;
            this.cboErrorList.Location = new System.Drawing.Point(369, 55);
            this.cboErrorList.Name = "cboErrorList";
            this.cboErrorList.Size = new System.Drawing.Size(238, 20);
            this.cboErrorList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboErrorList.TabIndex = 5;
            this.cboErrorList.ValueMember = "DcuType";
            // 
            // btnClean
            // 
            this.btnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(613, 25);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 25);
            this.btnClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Làm mới";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // prgBar
            // 
            this.prgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.prgBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgBar.Location = new System.Drawing.Point(3, 445);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(714, 23);
            this.prgBar.TabIndex = 47;
            this.prgBar.Text = "progressBarX1";
            this.prgBar.Visible = false;
            // 
            // UCMeasurementPoitMissingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboErrorList);
            this.Controls.Add(this.cboGroupName);
            this.Controls.Add(this.cboMeterType);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtErrorTime);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgErrorList);
            this.Name = "UCMeasurementPoitMissingMessage";
            this.Size = new System.Drawing.Size(841, 471);
            this.Load += new System.EventHandler(this.UCMeasurementPoitMissingMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgErrorList;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMeterType;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtErrorTime;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblTotalCount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboStatus;
        private DevComponents.Editors.ComboItem cboAll;
        private DevComponents.Editors.ComboItem itemError;
        private DevComponents.Editors.ComboItem itemFixed;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGroupName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAll;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboErrorList;
        private DevComponents.DotNetBar.ButtonX btnClean;
        private DevComponents.DotNetBar.Controls.ProgressBarX prgBar;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn ChooseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementPointCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForwardToCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixContentCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsFixedStatusCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn SolutionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorIdCol;
    }
}
