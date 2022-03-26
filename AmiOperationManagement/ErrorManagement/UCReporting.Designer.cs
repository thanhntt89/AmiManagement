namespace AmiOperationManagement.ErrorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReporting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrg = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtgReport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DcuCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementPoitCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuarementPoitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(373, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tạo báo cáo";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(370, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chú ý: Báo cáo chỉ được tạo vào thời điểm 15:00 hàng ngày";
            // 
            // cboOrg
            // 
            this.cboOrg.DisplayMember = "GroupCode";
            this.cboOrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.ItemHeight = 14;
            this.cboOrg.Location = new System.Drawing.Point(53, 28);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(311, 20);
            this.cboOrg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOrg.TabIndex = 5;
            this.cboOrg.ValueMember = "GroupCode";
            this.cboOrg.SelectedIndexChanged += new System.EventHandler(this.cboOrg_SelectedIndexChanged);
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
            this.dtToDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtToDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtToDate.IsPopupCalendarOpen = false;
            this.dtToDate.Location = new System.Drawing.Point(53, 3);
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
            this.dtToDate.Size = new System.Drawing.Size(311, 20);
            this.dtToDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtToDate.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Điện lực";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(49, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tới ngày";
            // 
            // dtgReport
            // 
            this.dtgReport.AllowUserToAddRows = false;
            this.dtgReport.AllowUserToDeleteRows = false;
            this.dtgReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcuCodeCol,
            this.DcuTypeCol,
            this.MeasurementPoitCodeCol,
            this.MeasuarementPoitCol,
            this.ErrorNameColumn,
            this.StartDateCol,
            this.ErrorTotalCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgReport.EnableHeadersVisualStyles = false;
            this.dtgReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgReport.Location = new System.Drawing.Point(3, 54);
            this.dtgReport.Name = "dtgReport";
            this.dtgReport.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgReport.Size = new System.Drawing.Size(993, 381);
            this.dtgReport.TabIndex = 0;
            this.dtgReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgReport_RowPostPaint);
            // 
            // DcuCodeCol
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DcuCodeCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.DcuCodeCol.HeaderText = "Mã thiết bị";
            this.DcuCodeCol.Name = "DcuCodeCol";
            this.DcuCodeCol.ReadOnly = true;
            // 
            // DcuTypeCol
            // 
            this.DcuTypeCol.HeaderText = "Loại công tơ";
            this.DcuTypeCol.Name = "DcuTypeCol";
            this.DcuTypeCol.ReadOnly = true;
            // 
            // MeasurementPoitCodeCol
            // 
            this.MeasurementPoitCodeCol.HeaderText = "Mã điểm đo";
            this.MeasurementPoitCodeCol.Name = "MeasurementPoitCodeCol";
            this.MeasurementPoitCodeCol.ReadOnly = true;
            this.MeasurementPoitCodeCol.Width = 120;
            // 
            // MeasuarementPoitCol
            // 
            this.MeasuarementPoitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MeasuarementPoitCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.MeasuarementPoitCol.HeaderText = "Tên điểm đo";
            this.MeasuarementPoitCol.Name = "MeasuarementPoitCol";
            this.MeasuarementPoitCol.ReadOnly = true;
            // 
            // ErrorNameColumn
            // 
            this.ErrorNameColumn.HeaderText = "Tên lỗi";
            this.ErrorNameColumn.Name = "ErrorNameColumn";
            this.ErrorNameColumn.ReadOnly = true;
            this.ErrorNameColumn.Width = 250;
            // 
            // StartDateCol
            // 
            this.StartDateCol.HeaderText = "Ngày bắt đầu";
            this.StartDateCol.Name = "StartDateCol";
            this.StartDateCol.ReadOnly = true;
            this.StartDateCol.Width = 150;
            // 
            // ErrorTotalCol
            // 
            this.ErrorTotalCol.HeaderText = "Tổng lỗi";
            this.ErrorTotalCol.Name = "ErrorTotalCol";
            this.ErrorTotalCol.ReadOnly = true;
            this.ErrorTotalCol.Width = 80;
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
            this.Size = new System.Drawing.Size(999, 438);
            this.Load += new System.EventHandler(this.UCReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgReport;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtToDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboOrg;      
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementPointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementPoitCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuarementPoitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorTotalCol;
    }
}
