namespace AmiOperationManagement.Deployment
{
    partial class UCCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomerManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            this.dtCreateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtCreateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemSelectAll = new DevComponents.Editors.ComboItem();
            this.itemActived = new DevComponents.Editors.ComboItem();
            this.itemDeleted = new DevComponents.Editors.ComboItem();
            this.dtgSearchCustomer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateCustomer = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnsearchCustomer = new DevComponents.DotNetBar.ButtonX();
            this.txtCustomerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCustomerCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblhapKh = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(3, 455);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(723, 28);
            this.ucBreakPage.TabIndex = 33;
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
            this.dtCreateTo.Location = new System.Drawing.Point(508, 30);
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
            this.dtCreateTo.Size = new System.Drawing.Size(95, 20);
            this.dtCreateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateTo.TabIndex = 32;
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
            this.dtCreateFrom.Location = new System.Drawing.Point(380, 30);
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
            this.dtCreateFrom.Size = new System.Drawing.Size(95, 20);
            this.dtCreateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreateFrom.TabIndex = 32;
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
            this.itemSelectAll,
            this.itemActived,
            this.itemDeleted});
            this.cboStatus.Location = new System.Drawing.Point(86, 29);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(196, 22);
            this.cboStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboStatus.TabIndex = 31;
            // 
            // itemSelectAll
            // 
            this.itemSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("itemSelectAll.Image")));
            this.itemSelectAll.Text = "Tất cả";
            this.itemSelectAll.Value = "all";
            // 
            // itemActived
            // 
            this.itemActived.Image = ((System.Drawing.Image)(resources.GetObject("itemActived.Image")));
            this.itemActived.Text = "Sử dụng";
            this.itemActived.Value = "Actived";
            // 
            // itemDeleted
            // 
            this.itemDeleted.Image = ((System.Drawing.Image)(resources.GetObject("itemDeleted.Image")));
            this.itemDeleted.Text = "Đã xoá";
            // 
            // dtgSearchCustomer
            // 
            this.dtgSearchCustomer.AllowUserToAddRows = false;
            this.dtgSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSearchCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgSearchCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCustomerId,
            this.clName,
            this.clAddress,
            this.clMobilePhone,
            this.clCreatedDate,
            this.clIsDeleted,
            this.clEdit,
            this.clDelete,
            this.clId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSearchCustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgSearchCustomer.EnableHeadersVisualStyles = false;
            this.dtgSearchCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgSearchCustomer.Location = new System.Drawing.Point(5, 58);
            this.dtgSearchCustomer.Name = "dtgSearchCustomer";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSearchCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgSearchCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgSearchCustomer.Size = new System.Drawing.Size(802, 393);
            this.dtgSearchCustomer.TabIndex = 4;
            this.dtgSearchCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchCustomer_CellClick);
            this.dtgSearchCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSearchCustomer_CellDoubleClick);
            this.dtgSearchCustomer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgSearchCustomer_RowPostPaint);
            // 
            // clCustomerId
            // 
            this.clCustomerId.FillWeight = 150F;
            this.clCustomerId.HeaderText = "Mã khách hàng";
            this.clCustomerId.Name = "clCustomerId";
            this.clCustomerId.ReadOnly = true;
            this.clCustomerId.Width = 150;
            // 
            // clName
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clName.DefaultCellStyle = dataGridViewCellStyle2;
            this.clName.FillWeight = 200F;
            this.clName.HeaderText = "Tên khách hàng";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 250;
            // 
            // clAddress
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.clAddress.FillWeight = 200F;
            this.clAddress.HeaderText = "Địa chỉ";
            this.clAddress.Name = "clAddress";
            this.clAddress.ReadOnly = true;
            this.clAddress.Width = 250;
            // 
            // clMobilePhone
            // 
            this.clMobilePhone.HeaderText = "Điện thoại";
            this.clMobilePhone.Name = "clMobilePhone";
            this.clMobilePhone.ReadOnly = true;
            this.clMobilePhone.Width = 150;
            // 
            // clCreatedDate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clCreatedDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.clCreatedDate.HeaderText = "Ngày tạo";
            this.clCreatedDate.Name = "clCreatedDate";
            this.clCreatedDate.ReadOnly = true;
            // 
            // clIsDeleted
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clIsDeleted.DefaultCellStyle = dataGridViewCellStyle5;
            this.clIsDeleted.HeaderText = "Trạng thái";
            this.clIsDeleted.Name = "clIsDeleted";
            this.clIsDeleted.ReadOnly = true;
            this.clIsDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clIsDeleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clEdit
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "Sửa";
            this.clEdit.DefaultCellStyle = dataGridViewCellStyle6;
            this.clEdit.FillWeight = 75F;
            this.clEdit.HeaderText = "";
            this.clEdit.Name = "clEdit";
            this.clEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clEdit.Text = null;
            this.clEdit.Width = 75;
            // 
            // clDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "Xoá";
            this.clDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.clDelete.FillWeight = 75F;
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
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCustomer.Image")));
            this.btnCreateCustomer.Location = new System.Drawing.Point(732, 457);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateCustomer.TabIndex = 3;
            this.btnCreateCustomer.Text = "Tạo mới";
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(609, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Làm mới";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnsearchCustomer
            // 
            this.btnsearchCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsearchCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnsearchCustomer.Image")));
            this.btnsearchCustomer.Location = new System.Drawing.Point(609, 29);
            this.btnsearchCustomer.Name = "btnsearchCustomer";
            this.btnsearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnsearchCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsearchCustomer.TabIndex = 3;
            this.btnsearchCustomer.Text = "Tìm";
            this.btnsearchCustomer.Click += new System.EventHandler(this.btnsearchCustomer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCustomerName.Border.Class = "TextBoxBorder";
            this.txtCustomerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(380, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(223, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.WatermarkText = "Nhập tên khách hàng";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(481, 29);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(33, 23);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "Đến";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(290, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "Ngày tạo từ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Trạng thái";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(288, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Tên khách hàng";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCustomerCode.Border.Class = "TextBoxBorder";
            this.txtCustomerCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerCode.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerCode.Location = new System.Drawing.Point(86, 5);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(196, 20);
            this.txtCustomerCode.TabIndex = 0;
            this.txtCustomerCode.WatermarkText = "Nhập mã khách hàng";
            // 
            // lblhapKh
            // 
            this.lblhapKh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblhapKh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblhapKh.Location = new System.Drawing.Point(3, 3);
            this.lblhapKh.Name = "lblhapKh";
            this.lblhapKh.Size = new System.Drawing.Size(85, 23);
            this.lblhapKh.TabIndex = 19;
            this.lblhapKh.Text = "Mã khách hàng";
            // 
            // UCCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ucBreakPage);
            this.Controls.Add(this.dtCreateTo);
            this.Controls.Add(this.dtCreateFrom);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.dtgSearchCustomer);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnsearchCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.lblhapKh);
            this.Name = "UCCustomerManagement";
            this.Size = new System.Drawing.Size(812, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSearchCustomer;
        private DevComponents.DotNetBar.ButtonX btnCreateCustomer;
        private DevComponents.DotNetBar.ButtonX btnsearchCustomer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustomerCode;
        private DevComponents.DotNetBar.LabelX lblhapKh;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustomerName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboStatus;
        private DevComponents.Editors.ComboItem itemSelectAll;
        private DevComponents.Editors.ComboItem itemActived;
        private DevComponents.Editors.ComboItem itemDeleted;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateFrom;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreateTo;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private CustomeUserControl.UCBreakPage ucBreakPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsDeleted;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;

    }
}
