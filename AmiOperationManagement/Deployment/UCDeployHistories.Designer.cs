namespace AmiOperationManagement.Deployment
{
    partial class UCDeployHistories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDeployHistories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMpCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtCreatedFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtCreatedTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDeployUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDcuCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMeterCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearching = new DevComponents.DotNetBar.ButtonX();
            this.btnClean = new DevComponents.DotNetBar.ButtonX();
            this.dtgDeployHistories = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNewDcuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNewMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOldDcuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOldMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeployUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucBreakPage = new AmiOperationManagement.CustomeUserControl.UCBreakPage();
            this.cboUser = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreatedFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreatedTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeployHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã điểm đo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người cập nhật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Người báo";
            // 
            // txtMpCode
            // 
            this.txtMpCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMpCode.Border.Class = "TextBoxBorder";
            this.txtMpCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMpCode.ForeColor = System.Drawing.Color.Black;
            this.txtMpCode.Location = new System.Drawing.Point(73, 3);
            this.txtMpCode.Name = "txtMpCode";
            this.txtMpCode.Size = new System.Drawing.Size(219, 20);
            this.txtMpCode.TabIndex = 0;
            // 
            // dtCreatedFrom
            // 
            // 
            // 
            // 
            this.dtCreatedFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtCreatedFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedFrom.ButtonClear.Visible = true;
            this.dtCreatedFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtCreatedFrom.ButtonDropDown.Visible = true;
            this.dtCreatedFrom.IsPopupCalendarOpen = false;
            this.dtCreatedFrom.Location = new System.Drawing.Point(384, 56);
            // 
            // 
            // 
            this.dtCreatedFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreatedFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedFrom.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtCreatedFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtCreatedFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedFrom.MonthCalendar.DisplayMonth = new System.DateTime(2017, 4, 1, 0, 0, 0, 0);
            this.dtCreatedFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtCreatedFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreatedFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtCreatedFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreatedFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtCreatedFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtCreatedFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtCreatedFrom.Name = "dtCreatedFrom";
            this.dtCreatedFrom.Size = new System.Drawing.Size(95, 20);
            this.dtCreatedFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreatedFrom.TabIndex = 5;
            // 
            // dtCreatedTo
            // 
            // 
            // 
            // 
            this.dtCreatedTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtCreatedTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedTo.ButtonClear.Visible = true;
            this.dtCreatedTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtCreatedTo.ButtonDropDown.Visible = true;
            this.dtCreatedTo.IsPopupCalendarOpen = false;
            this.dtCreatedTo.Location = new System.Drawing.Point(523, 56);
            // 
            // 
            // 
            this.dtCreatedTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreatedTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedTo.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtCreatedTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtCreatedTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedTo.MonthCalendar.DisplayMonth = new System.DateTime(2017, 4, 1, 0, 0, 0, 0);
            this.dtCreatedTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtCreatedTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtCreatedTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtCreatedTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtCreatedTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtCreatedTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtCreatedTo.MonthCalendar.TodayButtonVisible = true;
            this.dtCreatedTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtCreatedTo.Name = "dtCreatedTo";
            this.dtCreatedTo.Size = new System.Drawing.Size(98, 20);
            this.dtCreatedTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtCreatedTo.TabIndex = 6;
            // 
            // txtDeployUser
            // 
            this.txtDeployUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDeployUser.Border.Class = "TextBoxBorder";
            this.txtDeployUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeployUser.ForeColor = System.Drawing.Color.Black;
            this.txtDeployUser.Location = new System.Drawing.Point(384, 30);
            this.txtDeployUser.Name = "txtDeployUser";
            this.txtDeployUser.Size = new System.Drawing.Size(237, 20);
            this.txtDeployUser.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã thiết bị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã công tơ";
            // 
            // txtDcuCode
            // 
            this.txtDcuCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDcuCode.Border.Class = "TextBoxBorder";
            this.txtDcuCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDcuCode.ForeColor = System.Drawing.Color.Black;
            this.txtDcuCode.Location = new System.Drawing.Point(73, 30);
            this.txtDcuCode.Name = "txtDcuCode";
            this.txtDcuCode.Size = new System.Drawing.Size(219, 20);
            this.txtDcuCode.TabIndex = 1;
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
            this.txtMeterCode.Location = new System.Drawing.Point(73, 56);
            this.txtMeterCode.Name = "txtMeterCode";
            this.txtMeterCode.Size = new System.Drawing.Size(219, 20);
            this.txtMeterCode.TabIndex = 2;
            // 
            // btnSearching
            // 
            this.btnSearching.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearching.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearching.Image = ((System.Drawing.Image)(resources.GetObject("btnSearching.Image")));
            this.btnSearching.Location = new System.Drawing.Point(625, 54);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(75, 23);
            this.btnSearching.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearching.TabIndex = 8;
            this.btnSearching.Text = "Tìm";
            this.btnSearching.Click += new System.EventHandler(this.btnSearching_Click);
            // 
            // btnClean
            // 
            this.btnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(625, 25);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Xoá";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dtgDeployHistories
            // 
            this.dtgDeployHistories.AllowUserToAddRows = false;
            this.dtgDeployHistories.AllowUserToDeleteRows = false;
            this.dtgDeployHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDeployHistories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgDeployHistories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDeployHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeployHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAction,
            this.clMpCode,
            this.clMpName,
            this.clNewDcuCode,
            this.clNewMeter,
            this.clOldDcuCode,
            this.clOldMeter,
            this.clDeployUser,
            this.clPhone,
            this.clStatus,
            this.clNote,
            this.clCreatedDate,
            this.clUser,
            this.clId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDeployHistories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDeployHistories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgDeployHistories.Location = new System.Drawing.Point(6, 82);
            this.dtgDeployHistories.Name = "dtgDeployHistories";
            this.dtgDeployHistories.ReadOnly = true;
            this.dtgDeployHistories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgDeployHistories.Size = new System.Drawing.Size(755, 294);
            this.dtgDeployHistories.TabIndex = 9;
            this.dtgDeployHistories.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgDeployHistories_RowPostPaint);
            // 
            // clAction
            // 
            this.clAction.HeaderText = "Hành động";
            this.clAction.Name = "clAction";
            this.clAction.ReadOnly = true;
            // 
            // clMpCode
            // 
            this.clMpCode.HeaderText = "Mã điểm đo";
            this.clMpCode.Name = "clMpCode";
            this.clMpCode.ReadOnly = true;
            this.clMpCode.Width = 110;
            // 
            // clMpName
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clMpName.DefaultCellStyle = dataGridViewCellStyle1;
            this.clMpName.FillWeight = 250F;
            this.clMpName.HeaderText = "Tên điểm đo";
            this.clMpName.Name = "clMpName";
            this.clMpName.ReadOnly = true;
            this.clMpName.Width = 250;
            // 
            // clNewDcuCode
            // 
            this.clNewDcuCode.HeaderText = "Mã thiết bị";
            this.clNewDcuCode.Name = "clNewDcuCode";
            this.clNewDcuCode.ReadOnly = true;
            // 
            // clNewMeter
            // 
            this.clNewMeter.HeaderText = "Mã công tơ";
            this.clNewMeter.Name = "clNewMeter";
            this.clNewMeter.ReadOnly = true;
            // 
            // clOldDcuCode
            // 
            this.clOldDcuCode.HeaderText = "Mã thiết bị cũ";
            this.clOldDcuCode.Name = "clOldDcuCode";
            this.clOldDcuCode.ReadOnly = true;
            this.clOldDcuCode.Width = 110;
            // 
            // clOldMeter
            // 
            this.clOldMeter.HeaderText = "Mã công tơ cũ";
            this.clOldMeter.Name = "clOldMeter";
            this.clOldMeter.ReadOnly = true;
            this.clOldMeter.Width = 110;
            // 
            // clDeployUser
            // 
            this.clDeployUser.HeaderText = "Người triển khai";
            this.clDeployUser.Name = "clDeployUser";
            this.clDeployUser.ReadOnly = true;
            this.clDeployUser.Width = 120;
            // 
            // clPhone
            // 
            this.clPhone.HeaderText = "Số điện thoại";
            this.clPhone.Name = "clPhone";
            this.clPhone.ReadOnly = true;
            this.clPhone.Width = 110;
            // 
            // clStatus
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.clStatus.HeaderText = "Tình trạng lỗi";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            this.clStatus.Width = 250;
            // 
            // clNote
            // 
            this.clNote.HeaderText = "Ghi chú";
            this.clNote.Name = "clNote";
            this.clNote.ReadOnly = true;
            this.clNote.Width = 120;
            // 
            // clCreatedDate
            // 
            this.clCreatedDate.HeaderText = "Ngày tạo";
            this.clCreatedDate.Name = "clCreatedDate";
            this.clCreatedDate.ReadOnly = true;
            this.clCreatedDate.Width = 110;
            // 
            // clUser
            // 
            this.clUser.HeaderText = "Người cập nhật";
            this.clUser.Name = "clUser";
            this.clUser.ReadOnly = true;
            this.clUser.Width = 120;
            // 
            // clId
            // 
            this.clId.HeaderText = "clId";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // ucBreakPage
            // 
            this.ucBreakPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBreakPage.Location = new System.Drawing.Point(6, 382);
            this.ucBreakPage.Name = "ucBreakPage";
            this.ucBreakPage.Size = new System.Drawing.Size(755, 27);
            this.ucBreakPage.TabIndex = 10;
            // 
            // cboUser
            // 
            this.cboUser.DisplayMember = "Text";
            this.cboUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.ForeColor = System.Drawing.Color.Black;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.ItemHeight = 16;
            this.cboUser.Location = new System.Drawing.Point(384, 2);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(237, 22);
            this.cboUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUser.TabIndex = 3;
            // 
            // UCDeployHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.ucBreakPage);
            this.Controls.Add(this.dtgDeployHistories);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearching);
            this.Controls.Add(this.dtCreatedTo);
            this.Controls.Add(this.dtCreatedFrom);
            this.Controls.Add(this.txtDeployUser);
            this.Controls.Add(this.txtMeterCode);
            this.Controls.Add(this.txtDcuCode);
            this.Controls.Add(this.txtMpCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDeployHistories";
            this.Size = new System.Drawing.Size(764, 412);
            this.Load += new System.EventHandler(this.UCDeployHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCreatedFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreatedTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeployHistories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMpCode;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreatedFrom;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtCreatedTo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDeployUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDcuCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMeterCode;
        private DevComponents.DotNetBar.ButtonX btnSearching;
        private DevComponents.DotNetBar.ButtonX btnClean;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgDeployHistories;
        private CustomeUserControl.UCBreakPage ucBreakPage;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNewDcuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNewMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOldDcuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOldMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeployUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    }
}
