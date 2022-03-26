namespace AmiOperationManagement.Deployment
{
    partial class UCMeterManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMeterManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtCreateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtCreateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboMeterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboHistype = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.selectHisCurAll = new DevComponents.Editors.ComboItem();
            this.selectHistory = new DevComponents.Editors.ComboItem();
            this.selectCurrent = new DevComponents.Editors.ComboItem();
            this.cboIsUsed = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.selectAll = new DevComponents.Editors.ComboItem();
            this.selectActive = new DevComponents.Editors.ComboItem();
            this.selectDisable = new DevComponents.Editors.ComboItem();
            this.cboIsDeleted = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboAll = new DevComponents.Editors.ComboItem();
            this.cboActive = new DevComponents.Editors.ComboItem();
            this.cboDisable = new DevComponents.Editors.ComboItem();
            this.dtgSearchMeter = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clMeterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTypeBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCleanMeter = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateMeter = new DevComponents.DotNetBar.ButtonX();
            this.btnsearchMeter = new DevComponents.DotNetBar.ButtonX();
            this.txtMultiplier = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMeterCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblhapDcu = new DevComponents.DotNetBar.LabelX();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchMeter)).BeginInit();
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
            this.dtCreateTo.Location = new System.Drawing.Point(503, 84);
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
            this.dtCreateTo.Size = new System.Drawing.Size(92, 20);
            this.dtCreateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateTo.TabIndex = 8;
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
            this.dtCreateFrom.Location = new System.Drawing.Point(377, 84);
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
            this.dtCreateFrom.Size = new System.Drawing.Size(92, 20);
            this.dtCreateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateFrom.TabIndex = 7;
            // 
            // cboMeterType
            // 
            this.cboMeterType.DisplayMember = "Text";
            this.cboMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeterType.ForeColor = System.Drawing.Color.Black;
            this.cboMeterType.FormattingEnabled = true;
            this.cboMeterType.ItemHeight = 16;
            this.cboMeterType.Location = new System.Drawing.Point(377, 5);
            this.cboMeterType.Name = "cboMeterType";
            this.cboMeterType.Size = new System.Drawing.Size(218, 22);
            this.cboMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMeterType.TabIndex = 4;
            this.cboMeterType.WatermarkText = "Loại công tơ";
            // 
            // cboHistype
            // 
            this.cboHistype.DisplayMember = "Text";
            this.cboHistype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHistype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHistype.ForeColor = System.Drawing.Color.Black;
            this.cboHistype.FormattingEnabled = true;
            this.cboHistype.ItemHeight = 16;
            this.cboHistype.Items.AddRange(new object[] {
            this.selectHisCurAll,
            this.selectHistory,
            this.selectCurrent});
            this.cboHistype.Location = new System.Drawing.Point(377, 31);
            this.cboHistype.Name = "cboHistype";
            this.cboHistype.Size = new System.Drawing.Size(218, 22);
            this.cboHistype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHistype.TabIndex = 5;
            this.cboHistype.WatermarkText = "Loại chốt";
            // 
            // selectHisCurAll
            // 
            this.selectHisCurAll.Image = ((System.Drawing.Image)(resources.GetObject("selectHisCurAll.Image")));
            this.selectHisCurAll.Text = "Tất cả";
            this.selectHisCurAll.Value = "all";
            // 
            // selectHistory
            // 
            this.selectHistory.Image = ((System.Drawing.Image)(resources.GetObject("selectHistory.Image")));
            this.selectHistory.Text = "Chốt theo chỉ số tích luỹ";
            // 
            // selectCurrent
            // 
            this.selectCurrent.Image = ((System.Drawing.Image)(resources.GetObject("selectCurrent.Image")));
            this.selectCurrent.Text = "Chốt theo chỉ số tiêu dùng";
            this.selectCurrent.Value = "Actived";
            // 
            // cboIsUsed
            // 
            this.cboIsUsed.DisplayMember = "Text";
            this.cboIsUsed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIsUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsUsed.ForeColor = System.Drawing.Color.Black;
            this.cboIsUsed.FormattingEnabled = true;
            this.cboIsUsed.ItemHeight = 16;
            this.cboIsUsed.Items.AddRange(new object[] {
            this.selectAll,
            this.selectActive,
            this.selectDisable});
            this.cboIsUsed.Location = new System.Drawing.Point(65, 57);
            this.cboIsUsed.Name = "cboIsUsed";
            this.cboIsUsed.Size = new System.Drawing.Size(218, 22);
            this.cboIsUsed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIsUsed.TabIndex = 2;
            this.cboIsUsed.WatermarkText = "Trạng thái sử dụng";
            // 
            // selectAll
            // 
            this.selectAll.Image = ((System.Drawing.Image)(resources.GetObject("selectAll.Image")));
            this.selectAll.Text = "Tất cả";
            this.selectAll.Value = "all";
            // 
            // selectActive
            // 
            this.selectActive.Image = ((System.Drawing.Image)(resources.GetObject("selectActive.Image")));
            this.selectActive.Text = "Sử dụng";
            this.selectActive.Value = "Actived";
            // 
            // selectDisable
            // 
            this.selectDisable.Image = ((System.Drawing.Image)(resources.GetObject("selectDisable.Image")));
            this.selectDisable.Text = "Không sử dụng";
            // 
            // cboIsDeleted
            // 
            this.cboIsDeleted.DisplayMember = "Text";
            this.cboIsDeleted.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIsDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsDeleted.ForeColor = System.Drawing.Color.Black;
            this.cboIsDeleted.FormattingEnabled = true;
            this.cboIsDeleted.ItemHeight = 16;
            this.cboIsDeleted.Items.AddRange(new object[] {
            this.cboAll,
            this.cboActive,
            this.cboDisable});
            this.cboIsDeleted.Location = new System.Drawing.Point(65, 84);
            this.cboIsDeleted.Name = "cboIsDeleted";
            this.cboIsDeleted.Size = new System.Drawing.Size(218, 22);
            this.cboIsDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIsDeleted.TabIndex = 3;
            this.cboIsDeleted.WatermarkText = "Tình trạng sử dụng";
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
            // dtgSearchMeter
            // 
            this.dtgSearchMeter.AllowUserToAddRows = false;
            this.dtgSearchMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSearchMeter.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchMeter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSearchMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMeterId,
            this.clSerial,
            this.clMeterType,
            this.clTypeBilling,
            this.clMultiplier,
            this.clImax,
            this.clIsUsed,
            this.clIsDeleted,
            this.clCreatedDate,
            this.clEdit,
            this.clDelete,
            this.clId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSearchMeter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSearchMeter.EnableHeadersVisualStyles = false;
            this.dtgSearchMeter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgSearchMeter.Location = new System.Drawing.Point(5, 110);
            this.dtgSearchMeter.Name = "dtgSearchMeter";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchMeter.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSearchMeter.Size = new System.Drawing.Size(731, 346);
            this.dtgSearchMeter.TabIndex = 11;
            this.dtgSearchMeter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchMeter_CellClick);
            this.dtgSearchMeter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchMeter_CellDoubleClick);
            this.dtgSearchMeter.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgSearchMeter_RowPostPaint);
            // 
            // clMeterId
            // 
            this.clMeterId.HeaderText = "Mã công tơ";
            this.clMeterId.Name = "clMeterId";
            this.clMeterId.ReadOnly = true;
            this.clMeterId.Width = 130;
            // 
            // clSerial
            // 
            this.clSerial.HeaderText = "Serial";
            this.clSerial.Name = "clSerial";
            this.clSerial.ReadOnly = true;
            this.clSerial.Width = 150;
            // 
            // clMeterType
            // 
            this.clMeterType.HeaderText = "Loại ";
            this.clMeterType.Name = "clMeterType";
            this.clMeterType.ReadOnly = true;
            this.clMeterType.Width = 120;
            // 
            // clTypeBilling
            // 
            this.clTypeBilling.HeaderText = "Loại chốt";
            this.clTypeBilling.Name = "clTypeBilling";
            this.clTypeBilling.ReadOnly = true;
            this.clTypeBilling.Width = 150;
            // 
            // clMultiplier
            // 
            this.clMultiplier.HeaderText = "Hệ số nhân";
            this.clMultiplier.Name = "clMultiplier";
            // 
            // clImax
            // 
            this.clImax.HeaderText = "Imax";
            this.clImax.Name = "clImax";
            this.clImax.Width = 80;
            // 
            // clIsUsed
            // 
            this.clIsUsed.HeaderText = "Trạng thái";
            this.clIsUsed.Name = "clIsUsed";
            this.clIsUsed.ReadOnly = true;
            // 
            // clIsDeleted
            // 
            this.clIsDeleted.HeaderText = "Tình trạng";
            this.clIsDeleted.Name = "clIsDeleted";
            // 
            // clCreatedDate
            // 
            this.clCreatedDate.HeaderText = "Ngày tạo";
            this.clCreatedDate.Name = "clCreatedDate";
            this.clCreatedDate.Width = 120;
            // 
            // clEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.clEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clEdit.HeaderText = "";
            this.clEdit.Name = "clEdit";
            this.clEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clEdit.Text = null;
            this.clEdit.Width = 75;
            // 
            // clDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.clDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDelete.HeaderText = "";
            this.clDelete.Name = "clDelete";
            this.clDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDelete.Text = null;
            this.clDelete.Width = 75;
            // 
            // clId
            // 
            this.clId.HeaderText = "clId";
            this.clId.Name = "clId";
            this.clId.Visible = false;
            // 
            // btnCleanMeter
            // 
            this.btnCleanMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCleanMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCleanMeter.Image = ((System.Drawing.Image)(resources.GetObject("btnCleanMeter.Image")));
            this.btnCleanMeter.Location = new System.Drawing.Point(603, 57);
            this.btnCleanMeter.Name = "btnCleanMeter";
            this.btnCleanMeter.Size = new System.Drawing.Size(75, 23);
            this.btnCleanMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCleanMeter.TabIndex = 9;
            this.btnCleanMeter.Text = "Làm mới";
            this.btnCleanMeter.Click += new System.EventHandler(this.btnCleanMeter_Click);
            // 
            // btnCreateMeter
            // 
            this.btnCreateMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateMeter.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMeter.Image")));
            this.btnCreateMeter.Location = new System.Drawing.Point(661, 462);
            this.btnCreateMeter.Name = "btnCreateMeter";
            this.btnCreateMeter.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateMeter.TabIndex = 13;
            this.btnCreateMeter.Text = "Tạo mới";
            this.btnCreateMeter.Click += new System.EventHandler(this.btnCreateMeter_Click);
            // 
            // btnsearchMeter
            // 
            this.btnsearchMeter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchMeter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchMeter.Image = ((System.Drawing.Image)(resources.GetObject("btnsearchMeter.Image")));
            this.btnsearchMeter.Location = new System.Drawing.Point(603, 83);
            this.btnsearchMeter.Name = "btnsearchMeter";
            this.btnsearchMeter.Size = new System.Drawing.Size(75, 23);
            this.btnsearchMeter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchMeter.TabIndex = 10;
            this.btnsearchMeter.Text = "Tìm";
            this.btnsearchMeter.Click += new System.EventHandler(this.btnsearchMeter_Click);
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMultiplier.Border.Class = "TextBoxBorder";
            this.txtMultiplier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMultiplier.ForeColor = System.Drawing.Color.Black;
            this.txtMultiplier.Location = new System.Drawing.Point(377, 58);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(218, 20);
            this.txtMultiplier.TabIndex = 6;
            this.txtMultiplier.WatermarkText = "Hệ số nhân";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSerial.Border.Class = "TextBoxBorder";
            this.txtSerial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerial.ForeColor = System.Drawing.Color.Black;
            this.txtSerial.Location = new System.Drawing.Point(65, 32);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(218, 20);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.WatermarkText = "Serial công tơ";
            // 
            // txtMeterCode
            // 
            this.txtMeterCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMeterCode.Border.Class = "TextBoxBorder";
            this.txtMeterCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMeterCode.ForeColor = System.Drawing.Color.Black;
            this.txtMeterCode.Location = new System.Drawing.Point(65, 6);
            this.txtMeterCode.Name = "txtMeterCode";
            this.txtMeterCode.Size = new System.Drawing.Size(218, 20);
            this.txtMeterCode.TabIndex = 0;
            this.txtMeterCode.WatermarkText = "Nhập mã công tơ";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(292, 5);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(69, 23);
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "Loại công tơ";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(475, 83);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(24, 23);
            this.labelX7.TabIndex = 13;
            this.labelX7.Text = "Đến";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(292, 83);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(88, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "Thời gian tạo từ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(292, 57);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(61, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "Hệ số nhân";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(292, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(61, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Loại chốt";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 83);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(61, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Tình trạng";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Trạng thái";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Serial";
            // 
            // lblhapDcu
            // 
            this.lblhapDcu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblhapDcu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblhapDcu.Location = new System.Drawing.Point(3, 5);
            this.lblhapDcu.Name = "lblhapDcu";
            this.lblhapDcu.Size = new System.Drawing.Size(61, 23);
            this.lblhapDcu.TabIndex = 13;
            this.lblhapDcu.Text = "Mã công tơ";
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(3, 460);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(652, 26);
            this.ucBreakPage.TabIndex = 12;
            // 
            // UCMeterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ucBreakPage);
            this.Controls.Add(this.dtCreateTo);
            this.Controls.Add(this.dtCreateFrom);
            this.Controls.Add(this.cboMeterType);
            this.Controls.Add(this.cboHistype);
            this.Controls.Add(this.cboIsUsed);
            this.Controls.Add(this.cboIsDeleted);
            this.Controls.Add(this.dtgSearchMeter);
            this.Controls.Add(this.btnCleanMeter);
            this.Controls.Add(this.btnCreateMeter);
            this.Controls.Add(this.btnsearchMeter);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtMeterCode);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblhapDcu);
            this.Name = "UCMeterManagement";
            this.Size = new System.Drawing.Size(742, 488);
            this.Load += new System.EventHandler(this.UCMeterManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchMeter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSearchMeter;
        private DevComponents.DotNetBar.ButtonX btnCleanMeter;
        private DevComponents.DotNetBar.ButtonX btnCreateMeter;
        private DevComponents.DotNetBar.ButtonX btnsearchMeter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMeterCode;
        private DevComponents.DotNetBar.LabelX lblhapDcu;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMultiplier;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIsDeleted;
        private DevComponents.Editors.ComboItem cboAll;
        private DevComponents.Editors.ComboItem cboActive;
        private DevComponents.Editors.ComboItem cboDisable;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboIsUsed;
        private DevComponents.Editors.ComboItem selectAll;
        private DevComponents.Editors.ComboItem selectActive;
        private DevComponents.Editors.ComboItem selectDisable;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHistype;
        private DevComponents.Editors.ComboItem selectHisCurAll;
        private DevComponents.Editors.ComboItem selectCurrent;
        private DevComponents.Editors.ComboItem selectHistory;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMeterType;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateFrom;
        private CustomeUserControl.UCBreakPage ucBreakPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTypeBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedDate;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;

    }
}
