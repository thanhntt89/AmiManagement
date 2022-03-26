namespace AmiOperationManagement.Systems
{
    partial class UCSystemHistories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSystemHistories));
            this.dtgHistories = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteAll = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.dtTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboUser = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboAction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.All = new DevComponents.Editors.ComboItem();
            this.Send = new DevComponents.Editors.ComboItem();
            this.View = new DevComponents.Editors.ComboItem();
            this.Created = new DevComponents.Editors.ComboItem();
            this.Updated = new DevComponents.Editors.ComboItem();
            this.Deleted = new DevComponents.Editors.ComboItem();
            this.Printed = new DevComponents.Editors.ComboItem();
            this.Export = new DevComponents.Editors.ComboItem();
            this.Gatewayconnect = new DevComponents.Editors.ComboItem();
            this.Gatewaydisconnect = new DevComponents.Editors.ComboItem();
            this.Login = new DevComponents.Editors.ComboItem();
            this.Logout = new DevComponents.Editors.ComboItem();
            this.cboFunction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistories
            // 
            this.dtgHistories.AllowUserToAddRows = false;
            this.dtgHistories.AllowUserToDeleteRows = false;
            this.dtgHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHistories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgHistories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHistories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdCol,
            this.FunctionNameCol,
            this.ActionNameCol,
            this.NotesCol,
            this.CreatedDateCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHistories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHistories.EnableHeadersVisualStyles = false;
            this.dtgHistories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgHistories.Location = new System.Drawing.Point(3, 57);
            this.dtgHistories.Name = "dtgHistories";
            this.dtgHistories.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHistories.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHistories.Size = new System.Drawing.Size(776, 272);
            this.dtgHistories.TabIndex = 18;
            this.dtgHistories.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgHistories_RowPostPaint);
            // 
            // UserIdCol
            // 
            this.UserIdCol.HeaderText = "Người dùng";
            this.UserIdCol.Name = "UserIdCol";
            this.UserIdCol.ReadOnly = true;
            // 
            // FunctionNameCol
            // 
            this.FunctionNameCol.HeaderText = "Chức năng";
            this.FunctionNameCol.Name = "FunctionNameCol";
            this.FunctionNameCol.ReadOnly = true;
            this.FunctionNameCol.Width = 200;
            // 
            // ActionNameCol
            // 
            this.ActionNameCol.HeaderText = "Hành động";
            this.ActionNameCol.Name = "ActionNameCol";
            this.ActionNameCol.ReadOnly = true;
            this.ActionNameCol.Width = 150;
            // 
            // NotesCol
            // 
            this.NotesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NotesCol.HeaderText = "Ghi chú";
            this.NotesCol.Name = "NotesCol";
            this.NotesCol.ReadOnly = true;
            // 
            // CreatedDateCol
            // 
            this.CreatedDateCol.HeaderText = "Thời gian";
            this.CreatedDateCol.Name = "CreatedDateCol";
            this.CreatedDateCol.ReadOnly = true;
            this.CreatedDateCol.Width = 130;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(663, 335);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteAll.TabIndex = 17;
            this.btnDeleteAll.Text = "Xóa tất cả dữ liệu";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(590, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            // 
            // 
            // 
            this.dtTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTo.ButtonDropDown.Visible = true;
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.IsPopupCalendarOpen = false;
            this.dtTo.Location = new System.Drawing.Point(467, 3);
            // 
            // 
            // 
            this.dtTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.dtTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(117, 20);
            this.dtTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTo.TabIndex = 14;
            // 
            // dtFrom
            // 
            // 
            // 
            // 
            this.dtFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFrom.ButtonDropDown.Visible = true;
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.IsPopupCalendarOpen = false;
            this.dtFrom.Location = new System.Drawing.Point(285, 4);
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.dtFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(117, 20);
            this.dtFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFrom.TabIndex = 13;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "Text";
            this.cboUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.ItemHeight = 14;
            this.cboUser.Location = new System.Drawing.Point(2, 3);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(212, 20);
            this.cboUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUser.TabIndex = 8;
            this.cboUser.WatermarkText = "Chọn người dùng";
            // 
            // cboAction
            // 
            this.cboAction.DisplayMember = "Text";
            this.cboAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.ItemHeight = 14;
            this.cboAction.Items.AddRange(new object[] {
            this.All,
            this.Send,
            this.View,
            this.Created,
            this.Updated,
            this.Deleted,
            this.Printed,
            this.Export,
            this.Gatewayconnect,
            this.Gatewaydisconnect,
            this.Login,
            this.Logout});
            this.cboAction.Location = new System.Drawing.Point(2, 29);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(212, 20);
            this.cboAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboAction.TabIndex = 12;
            // 
            // All
            // 
            this.All.Text = "Tất cả";
            // 
            // Send
            // 
            this.Send.Text = "Gửi lệnh";
            // 
            // View
            // 
            this.View.Text = "Xem";
            // 
            // Created
            // 
            this.Created.Text = "Tạo mới";
            // 
            // Updated
            // 
            this.Updated.Text = "Cập nhật";
            // 
            // Deleted
            // 
            this.Deleted.Text = "Xoá";
            // 
            // Printed
            // 
            this.Printed.Text = "In";
            // 
            // Export
            // 
            this.Export.Text = "Export";
            // 
            // Gatewayconnect
            // 
            this.Gatewayconnect.Text = "Kết nối gateway";
            // 
            // Gatewaydisconnect
            // 
            this.Gatewaydisconnect.Text = "Ngắt kết nối gateway";
            // 
            // Login
            // 
            this.Login.Text = "Đăng nhập";
            // 
            // Logout
            // 
            this.Logout.Text = "Thoát khỏi chương trình";
            // 
            // cboFunction
            // 
            this.cboFunction.DisplayMember = "Text";
            this.cboFunction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunction.FormattingEnabled = true;
            this.cboFunction.ItemHeight = 14;
            this.cboFunction.Location = new System.Drawing.Point(285, 29);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(299, 20);
            this.cboFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFunction.TabIndex = 15;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(226, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Chức năng";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(408, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(55, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Đến ngày";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(226, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Từ ngày";
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(3, 335);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(654, 26);
            this.ucBreakPage.TabIndex = 19;
            // 
            // UCSystemHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ucBreakPage);
            this.Controls.Add(this.dtgHistories);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.cboFunction);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Name = "UCSystemHistories";
            this.Size = new System.Drawing.Size(782, 361);
            this.Load += new System.EventHandler(this.UCSystemHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgHistories;
        private DevComponents.DotNetBar.ButtonX btnDeleteAll;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFrom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUser;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboAction;
        private DevComponents.Editors.ComboItem All;
        private DevComponents.Editors.ComboItem View;
        private DevComponents.Editors.ComboItem Created;
        private DevComponents.Editors.ComboItem Updated;
        private DevComponents.Editors.ComboItem Deleted;
        private DevComponents.Editors.ComboItem Printed;
        private DevComponents.Editors.ComboItem Export;
        private DevComponents.Editors.ComboItem Login;
        private DevComponents.Editors.ComboItem Logout;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboFunction;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateCol;
        private DevComponents.Editors.ComboItem Send;
        private DevComponents.Editors.ComboItem Gatewayconnect;
        private DevComponents.Editors.ComboItem Gatewaydisconnect;
        private CustomeUserControl.UCBreakPage ucBreakPage;
    }
}
