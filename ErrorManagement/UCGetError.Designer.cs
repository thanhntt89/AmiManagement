namespace ErrorManagement
{
    partial class UCGetError
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgErrorList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CreatedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixContentSuggestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementPointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionColumn = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.FixGroupIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFixedColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.FixDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.getErrorListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtErrorTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnGetError = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.chkFixed = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dcuTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dcuTypeTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.DcuTypeTableAdapter();
            this.cboDcuType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.getErrorListTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetErrorListTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new DevComponents.DotNetBar.ButtonX();
            this.btDisconnect = new DevComponents.DotNetBar.ButtonX();
            this.lbStatus = new DevComponents.DotNetBar.LabelX();
            this.lbGateway = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getErrorListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcuTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgErrorList
            // 
            this.dtgErrorList.AllowUserToAddRows = false;
            this.dtgErrorList.AllowUserToDeleteRows = false;
            this.dtgErrorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgErrorList.AutoGenerateColumns = false;
            this.dtgErrorList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedDateColumn,
            this.GroupNameColumn,
            this.LocationColumn,
            this.DcuTypeColumn,
            this.FixContentSuggestionColumn,
            this.ErrorIdColumn,
            this.DcuCodeColumn,
            this.MeasurementPointColumn,
            this.ErrorDateColumn,
            this.ErrorCodeColumn,
            this.ErrorNameColumn,
            this.SolutionColumn,
            this.FixGroupIdColumn,
            this.IsFixedColumn,
            this.FixDateColumn,
            this.ChooseColumn});
            this.dtgErrorList.DataSource = this.getErrorListBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgErrorList.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgErrorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgErrorList.Location = new System.Drawing.Point(3, 32);
            this.dtgErrorList.Name = "dtgErrorList";
            this.dtgErrorList.Size = new System.Drawing.Size(996, 367);
            this.dtgErrorList.TabIndex = 3;
            this.dtgErrorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgErrorList_CellClick);
            this.dtgErrorList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgErrorList_RowPostPaint);
            // 
            // CreatedDateColumn
            // 
            this.CreatedDateColumn.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm";
            this.CreatedDateColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.CreatedDateColumn.HeaderText = "CreatedDate";
            this.CreatedDateColumn.Name = "CreatedDateColumn";
            this.CreatedDateColumn.ReadOnly = true;
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.DataPropertyName = "GroupName";
            this.GroupNameColumn.HeaderText = "GroupName";
            this.GroupNameColumn.Name = "GroupNameColumn";
            this.GroupNameColumn.Visible = false;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.Visible = false;
            // 
            // DcuTypeColumn
            // 
            this.DcuTypeColumn.DataPropertyName = "DcuType";
            this.DcuTypeColumn.HeaderText = "DcuType";
            this.DcuTypeColumn.Name = "DcuTypeColumn";
            this.DcuTypeColumn.Visible = false;
            // 
            // FixContentSuggestionColumn
            // 
            this.FixContentSuggestionColumn.DataPropertyName = "FixContentSuggestion";
            this.FixContentSuggestionColumn.HeaderText = "FixContentSuggestion";
            this.FixContentSuggestionColumn.Name = "FixContentSuggestionColumn";
            this.FixContentSuggestionColumn.Visible = false;
            // 
            // ErrorIdColumn
            // 
            this.ErrorIdColumn.DataPropertyName = "ErrorId";
            this.ErrorIdColumn.HeaderText = "ErrorId";
            this.ErrorIdColumn.Name = "ErrorIdColumn";
            this.ErrorIdColumn.ReadOnly = true;
            this.ErrorIdColumn.Width = 50;
            // 
            // DcuCodeColumn
            // 
            this.DcuCodeColumn.DataPropertyName = "DcuCode";
            this.DcuCodeColumn.HeaderText = "DcuCode";
            this.DcuCodeColumn.Name = "DcuCodeColumn";
            this.DcuCodeColumn.ReadOnly = true;
            // 
            // MeasurementPointColumn
            // 
            this.MeasurementPointColumn.DataPropertyName = "MeasurementPoint";
            this.MeasurementPointColumn.HeaderText = "MeasurementPoint";
            this.MeasurementPointColumn.Name = "MeasurementPointColumn";
            this.MeasurementPointColumn.ReadOnly = true;
            // 
            // ErrorDateColumn
            // 
            this.ErrorDateColumn.DataPropertyName = "ErrorDate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle9.NullValue = null;
            this.ErrorDateColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.ErrorDateColumn.FillWeight = 125F;
            this.ErrorDateColumn.HeaderText = "ErrorDate";
            this.ErrorDateColumn.Name = "ErrorDateColumn";
            this.ErrorDateColumn.ReadOnly = true;
            // 
            // ErrorCodeColumn
            // 
            this.ErrorCodeColumn.DataPropertyName = "ErrorCode";
            this.ErrorCodeColumn.HeaderText = "ErrorCodeColumn";
            this.ErrorCodeColumn.Name = "ErrorCodeColumn";
            // 
            // ErrorNameColumn
            // 
            this.ErrorNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ErrorNameColumn.DataPropertyName = "ErrorName";
            this.ErrorNameColumn.HeaderText = "ErrorName";
            this.ErrorNameColumn.Name = "ErrorNameColumn";
            this.ErrorNameColumn.ReadOnly = true;
            // 
            // SolutionColumn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "Solution";
            this.SolutionColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.SolutionColumn.HeaderText = "Solution";
            this.SolutionColumn.Name = "SolutionColumn";
            this.SolutionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SolutionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SolutionColumn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.SolutionColumn.Text = null;
            this.SolutionColumn.Width = 75;
            // 
            // FixGroupIdColumn
            // 
            this.FixGroupIdColumn.DataPropertyName = "FixGroupName";
            this.FixGroupIdColumn.HeaderText = "Forward To";
            this.FixGroupIdColumn.Name = "FixGroupIdColumn";
            this.FixGroupIdColumn.ReadOnly = true;
            // 
            // IsFixedColumn
            // 
            this.IsFixedColumn.Checked = true;
            this.IsFixedColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsFixedColumn.CheckValue = "N";
            this.IsFixedColumn.DataPropertyName = "IsFixed";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsFixedColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.IsFixedColumn.FillWeight = 50F;
            this.IsFixedColumn.HeaderText = "IsFixed";
            this.IsFixedColumn.Name = "IsFixedColumn";
            this.IsFixedColumn.ReadOnly = true;
            this.IsFixedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsFixedColumn.Width = 50;
            // 
            // FixDateColumn
            // 
            this.FixDateColumn.DataPropertyName = "FixDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "dd/MM/yyyy HH:mm";
            this.FixDateColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.FixDateColumn.HeaderText = "FixDate";
            this.FixDateColumn.Name = "FixDateColumn";
            this.FixDateColumn.ReadOnly = true;
            this.FixDateColumn.Width = 120;
            // 
            // ChooseColumn
            // 
            this.ChooseColumn.Checked = true;
            this.ChooseColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ChooseColumn.CheckValue = null;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ChooseColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.ChooseColumn.HeaderText = "";
            this.ChooseColumn.Name = "ChooseColumn";
            this.ChooseColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChooseColumn.Visible = false;
            this.ChooseColumn.Width = 50;
            // 
            // getErrorListBindingSource
            // 
            this.getErrorListBindingSource.DataMember = "GetErrorList";
            this.getErrorListBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(34, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Date";
            // 
            // dtErrorTime
            // 
            // 
            // 
            // 
            this.dtErrorTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtErrorTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.ButtonClear.Visible = true;
            this.dtErrorTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtErrorTime.ButtonDropDown.Visible = true;
            this.dtErrorTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtErrorTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtErrorTime.IsPopupCalendarOpen = false;
            this.dtErrorTime.Location = new System.Drawing.Point(43, 6);
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
            this.dtErrorTime.Size = new System.Drawing.Size(170, 20);
            this.dtErrorTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtErrorTime.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Location = new System.Drawing.Point(924, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Printing";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGetError
            // 
            this.btnGetError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGetError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGetError.Location = new System.Drawing.Point(570, 3);
            this.btnGetError.Name = "btnGetError";
            this.btnGetError.Size = new System.Drawing.Size(75, 25);
            this.btnGetError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGetError.TabIndex = 2;
            this.btnGetError.Text = "Get Error";
            this.btnGetError.Click += new System.EventHandler(this.btnGetError_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(220, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "DCU Type";
            // 
            // chkFixed
            // 
            // 
            // 
            // 
            this.chkFixed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFixed.Location = new System.Drawing.Point(516, 5);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(48, 23);
            this.chkFixed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFixed.TabIndex = 6;
            this.chkFixed.Text = "Fixed";
            // 
            // dcuTypeBindingSource
            // 
            this.dcuTypeBindingSource.DataMember = "DcuType";
            this.dcuTypeBindingSource.DataSource = this.amiReportDataSet;
            // 
            // dcuTypeTableAdapter
            // 
            this.dcuTypeTableAdapter.ClearBeforeFill = true;
            // 
            // cboDcuType
            // 
            this.cboDcuType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDcuType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDcuType.DataSource = this.dcuTypeBindingSource;
            this.cboDcuType.DisplayMember = "DcuTypeName";
            this.cboDcuType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDcuType.FormattingEnabled = true;
            this.cboDcuType.ItemHeight = 14;
            this.cboDcuType.Location = new System.Drawing.Point(282, 6);
            this.cboDcuType.Name = "cboDcuType";
            this.cboDcuType.Size = new System.Drawing.Size(228, 20);
            this.cboDcuType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDcuType.TabIndex = 7;
            this.cboDcuType.ValueMember = "DcuType";
            // 
            // getErrorListTableAdapter
            // 
            this.getErrorListTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(651, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Detal: 0->59 minutes";
            // 
            // btConnect
            // 
            this.btConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btConnect.Location = new System.Drawing.Point(43, 405);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btConnect.TabIndex = 9;
            this.btConnect.Text = "Connect";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDisconnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDisconnect.Location = new System.Drawing.Point(124, 405);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btDisconnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btDisconnect.TabIndex = 10;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lbStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(205, 405);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 23);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Disconnect";
            // 
            // lbGateway
            // 
            this.lbGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lbGateway.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGateway.Location = new System.Drawing.Point(417, 403);
            this.lbGateway.Name = "lbGateway";
            this.lbGateway.Size = new System.Drawing.Size(180, 23);
            this.lbGateway.TabIndex = 12;
            // 
            // UCGetError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbGateway);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDcuType);
            this.Controls.Add(this.chkFixed);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnGetError);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtErrorTime);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgErrorList);
            this.Name = "UCGetError";
            this.Size = new System.Drawing.Size(1002, 433);
            this.Load += new System.EventHandler(this.UCGetError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getErrorListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcuTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgErrorList;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtErrorTime;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnGetError;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFixed;
        private AmiReportDataSet amiReportDataSet;
        private System.Windows.Forms.BindingSource dcuTypeBindingSource;
        private AmiReportDataSetTableAdapters.DcuTypeTableAdapter dcuTypeTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDcuType;
        private System.Windows.Forms.BindingSource getErrorListBindingSource;
        private AmiReportDataSetTableAdapters.GetErrorListTableAdapter getErrorListTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixContentSuggestionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementPointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNameColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn SolutionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixGroupIdColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsFixedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixDateColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn ChooseColumn;
        private DevComponents.DotNetBar.ButtonX btConnect;
        private DevComponents.DotNetBar.ButtonX btDisconnect;
        private DevComponents.DotNetBar.LabelX lbStatus;
        private DevComponents.DotNetBar.LabelX lbGateway;
    }
}
