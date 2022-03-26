namespace AmiOperationManagement.ErrorManagement
{
    partial class UCFixError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFixError));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucErrorSolution = new AmiOperationManagement.ErrorManagement.UCErrorSolution();
            this.tabFixBug = new DevComponents.DotNetBar.TabItem(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkFixed = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnGetError = new DevComponents.DotNetBar.ButtonX();
            this.dtErrorTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.tvErrorList = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucModemFixbugHistories = new AmiOperationManagement.ErrorManagement.UCModemFixbugHistories();
            this.tabHistories = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvErrorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            this.imageList.Images.SetKeyName(1, "file-warning.png");
            this.imageList.Images.SetKeyName(2, "check-mark-hi.png");
            this.imageList.Images.SetKeyName(3, "list-flat.png");
            this.imageList.Images.SetKeyName(4, "images.png");
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.ucErrorSolution);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(439, 407);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabFixBug;
            // 
            // ucErrorSolution
            // 
            this.ucErrorSolution.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucErrorSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucErrorSolution.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucErrorSolution.Location = new System.Drawing.Point(1, 1);
            this.ucErrorSolution.Name = "ucErrorSolution";
            this.ucErrorSolution.Size = new System.Drawing.Size(437, 405);
            this.ucErrorSolution.TabIndex = 0;
            // 
            // tabFixBug
            // 
            this.tabFixBug.AttachedControl = this.tabControlPanel1;
            this.tabFixBug.Name = "tabFixBug";
            this.tabFixBug.Text = "Xử lý lỗi";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.chkFixed);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetError);
            this.splitContainer1.Panel1.Controls.Add(this.dtErrorTime);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tvErrorList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(690, 434);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkFixed
            // 
            // 
            // 
            // 
            this.chkFixed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFixed.Location = new System.Drawing.Point(7, 43);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(124, 23);
            this.chkFixed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFixed.TabIndex = 14;
            this.chkFixed.Text = "Lỗi đã sửa";
            // 
            // btnGetError
            // 
            this.btnGetError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGetError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGetError.Image = ((System.Drawing.Image)(resources.GetObject("btnGetError.Image")));
            this.btnGetError.Location = new System.Drawing.Point(169, 19);
            this.btnGetError.Name = "btnGetError";
            this.btnGetError.Size = new System.Drawing.Size(75, 25);
            this.btnGetError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGetError.TabIndex = 12;
            this.btnGetError.Text = "Tìm lỗi";
            this.btnGetError.Click += new System.EventHandler(this.btnGetError_Click);
            // 
            // dtErrorTime
            // 
            this.dtErrorTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.dtErrorTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtErrorTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtErrorTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtErrorTime.ButtonDropDown.Visible = true;
            this.dtErrorTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtErrorTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtErrorTime.IsPopupCalendarOpen = false;
            this.dtErrorTime.Location = new System.Drawing.Point(9, 21);
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
            this.dtErrorTime.Size = new System.Drawing.Size(154, 20);
            this.dtErrorTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtErrorTime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian";
            // 
            // tvErrorList
            // 
            this.tvErrorList.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvErrorList.AllowDrop = true;
            this.tvErrorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvErrorList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.tvErrorList.BackgroundStyle.Class = "TreeBorderKey";
            this.tvErrorList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvErrorList.ColumnsVisible = false;
            this.tvErrorList.DoubleClickTogglesNode = false;
            this.tvErrorList.DragDropEnabled = false;
            this.tvErrorList.DragDropNodeCopyEnabled = false;
            this.tvErrorList.FullRowSelect = false;
            this.tvErrorList.GridColumnLines = false;
            this.tvErrorList.ImageList = this.imageList;
            this.tvErrorList.Location = new System.Drawing.Point(7, 70);
            this.tvErrorList.MultiNodeDragCountVisible = false;
            this.tvErrorList.MultiNodeDragDropAllowed = false;
            this.tvErrorList.Name = "tvErrorList";
            this.tvErrorList.NodesConnector = this.nodeConnector1;
            this.tvErrorList.NodeStyle = this.elementStyle1;
            this.tvErrorList.PathSeparator = ";";
            this.tvErrorList.Size = new System.Drawing.Size(237, 361);
            this.tvErrorList.Styles.Add(this.elementStyle1);
            this.tvErrorList.TabIndex = 0;
            this.tvErrorList.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.tvErrorList_AfterNodeSelect);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabControlPanel2);
            this.tabControl.Controls.Add(this.tabControlPanel1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ForeColor = System.Drawing.Color.Black;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(439, 434);
            this.tabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl.TabIndex = 1;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabFixBug);
            this.tabControl.Tabs.Add(this.tabHistories);
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.ucModemFixbugHistories);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(439, 407);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabHistories;
            // 
            // ucModemFixbugHistories
            // 
            this.ucModemFixbugHistories.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucModemFixbugHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModemFixbugHistories.Location = new System.Drawing.Point(1, 1);
            this.ucModemFixbugHistories.Name = "ucModemFixbugHistories";
            this.ucModemFixbugHistories.Size = new System.Drawing.Size(437, 405);
            this.ucModemFixbugHistories.TabIndex = 1;
            // 
            // tabHistories
            // 
            this.tabHistories.AttachedControl = this.tabControlPanel2;
            this.tabHistories.Name = "tabHistories";
            this.tabHistories.Text = "Lịch sử sửa lỗi";
            // 
            // UCFixError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCFixError";
            this.Size = new System.Drawing.Size(690, 434);
            this.Load += new System.EventHandler(this.UCFixError_Load);
            this.tabControlPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvErrorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.AdvTree.AdvTree tvErrorList;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtErrorTime;
        private DevComponents.DotNetBar.ButtonX btnGetError;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFixed;
        private UCErrorSolution ucErrorSolution;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabHistories;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabFixBug;
        private System.Windows.Forms.ImageList imageList;
        private UCModemFixbugHistories ucModemFixbugHistories;
    }
}
