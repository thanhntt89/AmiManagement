namespace ErrorManagement
{
    partial class UCReporting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgReport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ErrorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboOrg = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.DcuCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementPointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getReportingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.getReportingTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetReportingTableAdapter();
            this.getOrgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrgTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetOrgTableAdapter();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReport
            // 
            this.dtgReport.AllowUserToAddRows = false;
            this.dtgReport.AllowUserToDeleteRows = false;
            this.dtgReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReport.AutoGenerateColumns = false;
            this.dtgReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcuCodeColumn,
            this.DcuTypeColumn,
            this.MeasurementPointColumn,
            this.GroupNameColumn,
            this.ErrorNameColumn,
            this.StartDateColumn,
            this.TotalColumn});
            this.dtgReport.DataSource = this.getReportingBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReport.DefaultCellStyle = dataGridViewCellStyle23;
            this.dtgReport.EnableHeadersVisualStyles = false;
            this.dtgReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgReport.Location = new System.Drawing.Point(3, 59);
            this.dtgReport.Name = "dtgReport";
            this.dtgReport.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgReport.Size = new System.Drawing.Size(961, 376);
            this.dtgReport.TabIndex = 0;
            this.dtgReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgReport_RowPostPaint);
            // 
            // ErrorNameColumn
            // 
            this.ErrorNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ErrorNameColumn.DataPropertyName = "ErrorName";
            this.ErrorNameColumn.HeaderText = "ErrorName";
            this.ErrorNameColumn.Name = "ErrorNameColumn";
            this.ErrorNameColumn.ReadOnly = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(49, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Thời gian";
            // 
            // dtToDate
            // 
            // 
            // 
            // 
            this.dtToDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtToDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtToDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtToDate.ButtonDropDown.Visible = true;
            this.dtToDate.CustomFormat = "dd/MM/yyyy";
            this.dtToDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtToDate.IsPopupCalendarOpen = false;
            this.dtToDate.Location = new System.Drawing.Point(60, 29);
            // 
            // 
            // 
            this.dtToDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtToDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtToDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtToDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtToDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtToDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            this.dtToDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtToDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtToDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtToDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtToDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtToDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtToDate.MonthCalendar.TodayButtonVisible = true;
            this.dtToDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(239, 20);
            this.dtToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtToDate.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(5, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Điện lực";
            // 
            // cboOrg
            // 
            this.cboOrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.ItemHeight = 14;
            this.cboOrg.Location = new System.Drawing.Point(60, 3);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(321, 20);
            this.cboOrg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOrg.TabIndex = 5;
            this.cboOrg.SelectedIndexChanged += new System.EventHandler(this.cboOrg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(387, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chú ý: Báo cáo chỉ được tạo vào thời điểm 15:00 hàng ngày";
            // 
            // DcuCodeColumn
            // 
            this.DcuCodeColumn.DataPropertyName = "DcuCode";
            this.DcuCodeColumn.HeaderText = "DcuCode";
            this.DcuCodeColumn.Name = "DcuCodeColumn";
            this.DcuCodeColumn.ReadOnly = true;
            // 
            // DcuTypeColumn
            // 
            this.DcuTypeColumn.DataPropertyName = "DcuType";
            this.DcuTypeColumn.HeaderText = "DcuType";
            this.DcuTypeColumn.Name = "DcuTypeColumn";
            this.DcuTypeColumn.ReadOnly = true;
            // 
            // MeasurementPointColumn
            // 
            this.MeasurementPointColumn.DataPropertyName = "MeasurementPoint";
            this.MeasurementPointColumn.HeaderText = "MeasurementPoint";
            this.MeasurementPointColumn.Name = "MeasurementPointColumn";
            this.MeasurementPointColumn.ReadOnly = true;
            this.MeasurementPointColumn.Width = 120;
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.DataPropertyName = "GroupName";
            this.GroupNameColumn.HeaderText = "GroupName";
            this.GroupNameColumn.Name = "GroupNameColumn";
            this.GroupNameColumn.ReadOnly = true;
            this.GroupNameColumn.Visible = false;
            this.GroupNameColumn.Width = 120;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "dd/MM/yyyy";
            dataGridViewCellStyle22.NullValue = null;
            this.StartDateColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.StartDateColumn.HeaderText = "StartDate";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.DataPropertyName = "Total";
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            this.TotalColumn.Width = 60;
            // 
            // getReportingBindingSource
            // 
            this.getReportingBindingSource.DataMember = "GetReporting";
            this.getReportingBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getReportingTableAdapter
            // 
            this.getReportingTableAdapter.ClearBeforeFill = true;
            // 
            // getOrgBindingSource
            // 
            this.getOrgBindingSource.DataMember = "GetOrg";
            this.getOrgBindingSource.DataSource = this.amiReportDataSet;
            // 
            // getOrgTableAdapter
            // 
            this.getOrgTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(305, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // UCReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrg);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgReport);
            this.Name = "UCReporting";
            this.Size = new System.Drawing.Size(967, 438);
            this.Load += new System.EventHandler(this.UCReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgReport;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtToDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.BindingSource getReportingBindingSource;
        private AmiReportDataSet amiReportDataSet;
        private AmiReportDataSetTableAdapters.GetReportingTableAdapter getReportingTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboOrg;
        private System.Windows.Forms.BindingSource getOrgBindingSource;
        private AmiReportDataSetTableAdapters.GetOrgTableAdapter getOrgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementPointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
    }
}
