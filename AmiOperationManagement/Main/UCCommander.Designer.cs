namespace AmiOperationManagement
{
    partial class UCCommander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCommander));
            this.imageListTopics = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelModem = new DevComponents.DotNetBar.ExpandablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDcu = new System.Windows.Forms.RichTextBox();
            this.mnRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tvTopics = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle7 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle8 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle9 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle10 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle11 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle12 = new DevComponents.DotNetBar.ElementStyle();
            this.cboMeterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ucProgressBar = new AmiOperationManagement.CustomeUserControl.UCProgressBarStop();
            this.chkIsHex = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkEncryptionMessage = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSubscribe = new DevComponents.DotNetBar.ButtonX();
            this.panelConnectionStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommandText = new System.Windows.Forms.RichTextBox();
            this.ucDcuController = new AmiOperationManagement.Main.UCDcuController();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelModem.SuspendLayout();
            this.mnRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvTopics)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListTopics
            // 
            this.imageListTopics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTopics.ImageStream")));
            this.imageListTopics.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTopics.Images.SetKeyName(0, "subscribe_icon.png");
            this.imageListTopics.Images.SetKeyName(1, "message.png");
            this.imageListTopics.Images.SetKeyName(2, "message-outline.png");
            this.imageListTopics.Images.SetKeyName(3, "accept.png");
            this.imageListTopics.Images.SetKeyName(4, "disconnect.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelModem);
            this.splitContainer1.Panel1.Controls.Add(this.ucProgressBar);
            this.splitContainer1.Panel1.Controls.Add(this.chkIsHex);
            this.splitContainer1.Panel1.Controls.Add(this.chkEncryptionMessage);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubscribe);
            this.splitContainer1.Panel1.Controls.Add(this.panelConnectionStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtCommandText);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucDcuController);
            this.splitContainer1.Size = new System.Drawing.Size(915, 491);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelModem
            // 
            this.panelModem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelModem.ButtonImageCollapse = ((System.Drawing.Image)(resources.GetObject("panelModem.ButtonImageCollapse")));
            this.panelModem.ButtonImageExpand = ((System.Drawing.Image)(resources.GetObject("panelModem.ButtonImageExpand")));
            this.panelModem.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelModem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.panelModem.Controls.Add(this.label2);
            this.panelModem.Controls.Add(this.txtDcu);
            this.panelModem.Controls.Add(this.tvTopics);
            this.panelModem.Controls.Add(this.cboMeterType);
            this.panelModem.Location = new System.Drawing.Point(440, 3);
            this.panelModem.Name = "panelModem";
            this.panelModem.Size = new System.Drawing.Size(472, 203);
            this.panelModem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelModem.Style.BackColor1.Color = System.Drawing.SystemColors.ControlLightLight;
            this.panelModem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelModem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelModem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelModem.Style.GradientAngle = 90;
            this.panelModem.TabIndex = 19;
            this.panelModem.TitleStyle.Alignment = System.Drawing.StringAlignment.Far;
            this.panelModem.TitleStyle.BackColor1.Color = System.Drawing.SystemColors.ControlLightLight;
            this.panelModem.TitleStyle.BackColor2.Color = System.Drawing.SystemColors.ControlLightLight;
            this.panelModem.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panelModem.TitleStyle.BorderColor.Color = System.Drawing.SystemColors.ControlLightLight;
            this.panelModem.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelModem.TitleStyle.GradientAngle = 90;
            this.panelModem.TitleText = "Cấu hình nhận bản tin từ modem";
            this.panelModem.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.panelModem_ExpandedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-1, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách modem tương tác";
            // 
            // txtDcu
            // 
            this.txtDcu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDcu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDcu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDcu.ContextMenuStrip = this.mnRightClick;
            this.txtDcu.Location = new System.Drawing.Point(3, 54);
            this.txtDcu.Name = "txtDcu";
            this.txtDcu.Size = new System.Drawing.Size(150, 146);
            this.txtDcu.TabIndex = 1;
            this.txtDcu.Text = "";
            // 
            // mnRightClick
            // 
            this.mnRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPaste});
            this.mnRightClick.Name = "mnRightClick";
            this.mnRightClick.Size = new System.Drawing.Size(103, 26);
            // 
            // mnPaste
            // 
            this.mnPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnPaste.Image")));
            this.mnPaste.Name = "mnPaste";
            this.mnPaste.Size = new System.Drawing.Size(102, 22);
            this.mnPaste.Text = "Paste";
            this.mnPaste.Click += new System.EventHandler(this.mnPaste_Click);
            // 
            // tvTopics
            // 
            this.tvTopics.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvTopics.AllowDrop = true;
            this.tvTopics.AllowUserToResizeColumns = false;
            this.tvTopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTopics.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.tvTopics.BackgroundStyle.Class = "TreeBorderKey";
            this.tvTopics.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvTopics.ColumnsVisible = false;
            this.tvTopics.DragDropEnabled = false;
            this.tvTopics.DragDropNodeCopyEnabled = false;
            this.tvTopics.GridColumnLines = false;
            this.tvTopics.ImageIndex = 0;
            this.tvTopics.ImageList = this.imageListTopics;
            this.tvTopics.Location = new System.Drawing.Point(159, 54);
            this.tvTopics.MultiNodeDragCountVisible = false;
            this.tvTopics.MultiNodeDragDropAllowed = false;
            this.tvTopics.Name = "tvTopics";
            this.tvTopics.NodesConnector = this.nodeConnector2;
            this.tvTopics.NodeStyle = this.elementStyle7;
            this.tvTopics.PathSeparator = ";";
            this.tvTopics.Size = new System.Drawing.Size(310, 146);
            this.tvTopics.Styles.Add(this.elementStyle7);
            this.tvTopics.Styles.Add(this.elementStyle8);
            this.tvTopics.Styles.Add(this.elementStyle9);
            this.tvTopics.Styles.Add(this.elementStyle10);
            this.tvTopics.Styles.Add(this.elementStyle11);
            this.tvTopics.Styles.Add(this.elementStyle12);
            this.tvTopics.TabIndex = 18;
            this.tvTopics.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.tvTopics_NodeClick);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle7
            // 
            this.elementStyle7.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle7.Name = "elementStyle7";
            this.elementStyle7.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle8
            // 
            this.elementStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.elementStyle8.BackColor2 = System.Drawing.Color.Navy;
            this.elementStyle8.BackColorGradientAngle = 90;
            this.elementStyle8.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle8.BorderBottomWidth = 1;
            this.elementStyle8.BorderColor = System.Drawing.Color.Navy;
            this.elementStyle8.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle8.BorderLeftWidth = 1;
            this.elementStyle8.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle8.BorderRightWidth = 1;
            this.elementStyle8.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle8.BorderTopWidth = 1;
            this.elementStyle8.CornerDiameter = 4;
            this.elementStyle8.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle8.Description = "BlueNight";
            this.elementStyle8.Name = "elementStyle8";
            this.elementStyle8.PaddingBottom = 1;
            this.elementStyle8.PaddingLeft = 1;
            this.elementStyle8.PaddingRight = 1;
            this.elementStyle8.PaddingTop = 1;
            this.elementStyle8.TextColor = System.Drawing.Color.White;
            // 
            // elementStyle9
            // 
            this.elementStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle9.BackColorGradientAngle = 90;
            this.elementStyle9.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle9.BorderBottomWidth = 1;
            this.elementStyle9.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle9.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle9.BorderLeftWidth = 1;
            this.elementStyle9.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle9.BorderRightWidth = 1;
            this.elementStyle9.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle9.BorderTopWidth = 1;
            this.elementStyle9.CornerDiameter = 4;
            this.elementStyle9.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle9.Description = "Blue";
            this.elementStyle9.Name = "elementStyle9";
            this.elementStyle9.PaddingBottom = 1;
            this.elementStyle9.PaddingLeft = 1;
            this.elementStyle9.PaddingRight = 1;
            this.elementStyle9.PaddingTop = 1;
            this.elementStyle9.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle10
            // 
            this.elementStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle10.BackColorGradientAngle = 90;
            this.elementStyle10.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle10.BorderBottomWidth = 1;
            this.elementStyle10.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle10.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle10.BorderLeftWidth = 1;
            this.elementStyle10.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle10.BorderRightWidth = 1;
            this.elementStyle10.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle10.BorderTopWidth = 1;
            this.elementStyle10.CornerDiameter = 4;
            this.elementStyle10.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle10.Description = "Blue";
            this.elementStyle10.Name = "elementStyle10";
            this.elementStyle10.PaddingBottom = 1;
            this.elementStyle10.PaddingLeft = 1;
            this.elementStyle10.PaddingRight = 1;
            this.elementStyle10.PaddingTop = 1;
            this.elementStyle10.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle11
            // 
            this.elementStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.elementStyle11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.elementStyle11.BackColorGradientAngle = 90;
            this.elementStyle11.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle11.BorderBottomWidth = 1;
            this.elementStyle11.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle11.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle11.BorderLeftWidth = 1;
            this.elementStyle11.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle11.BorderRightWidth = 1;
            this.elementStyle11.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle11.BorderTopWidth = 1;
            this.elementStyle11.CornerDiameter = 4;
            this.elementStyle11.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle11.Description = "Yellow";
            this.elementStyle11.Name = "elementStyle11";
            this.elementStyle11.PaddingBottom = 1;
            this.elementStyle11.PaddingLeft = 1;
            this.elementStyle11.PaddingRight = 1;
            this.elementStyle11.PaddingTop = 1;
            this.elementStyle11.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle12
            // 
            this.elementStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.elementStyle12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.elementStyle12.BackColorGradientAngle = 90;
            this.elementStyle12.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle12.BorderBottomWidth = 1;
            this.elementStyle12.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle12.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle12.BorderLeftWidth = 1;
            this.elementStyle12.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle12.BorderRightWidth = 1;
            this.elementStyle12.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle12.BorderTopWidth = 1;
            this.elementStyle12.CornerDiameter = 4;
            this.elementStyle12.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle12.Description = "Red";
            this.elementStyle12.Name = "elementStyle12";
            this.elementStyle12.PaddingBottom = 1;
            this.elementStyle12.PaddingLeft = 1;
            this.elementStyle12.PaddingRight = 1;
            this.elementStyle12.PaddingTop = 1;
            this.elementStyle12.TextColor = System.Drawing.Color.Black;
            // 
            // cboMeterType
            // 
            this.cboMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMeterType.DisplayMember = "Text";
            this.cboMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeterType.FormattingEnabled = true;
            this.cboMeterType.ItemHeight = 14;
            this.cboMeterType.Location = new System.Drawing.Point(159, 27);
            this.cboMeterType.Name = "cboMeterType";
            this.cboMeterType.Size = new System.Drawing.Size(310, 20);
            this.cboMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMeterType.TabIndex = 16;
            this.cboMeterType.WatermarkText = "Chọn loại modem";
            // 
            // ucProgressBar
            // 
            this.ucProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProgressBar.Location = new System.Drawing.Point(3, 205);
            this.ucProgressBar.Name = "ucProgressBar";
            this.ucProgressBar.Size = new System.Drawing.Size(909, 23);
            this.ucProgressBar.TabIndex = 20;
            this.ucProgressBar.Visible = false;
            // 
            // chkIsHex
            // 
            this.chkIsHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.chkIsHex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsHex.Checked = true;
            this.chkIsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsHex.CheckValue = "Y";
            this.chkIsHex.Location = new System.Drawing.Point(34, 232);
            this.chkIsHex.Name = "chkIsHex";
            this.chkIsHex.Size = new System.Drawing.Size(122, 23);
            this.chkIsHex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsHex.TabIndex = 17;
            this.chkIsHex.Text = "Hiển thị giá trị HEX";
            // 
            // chkEncryptionMessage
            // 
            this.chkEncryptionMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.chkEncryptionMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkEncryptionMessage.Location = new System.Drawing.Point(34, 234);
            this.chkEncryptionMessage.Name = "chkEncryptionMessage";
            this.chkEncryptionMessage.Size = new System.Drawing.Size(100, 23);
            this.chkEncryptionMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkEncryptionMessage.TabIndex = 17;
            this.chkEncryptionMessage.Text = "Bản tin mã hoá";
            this.chkEncryptionMessage.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(690, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubscribe.Enabled = false;
            this.btnSubscribe.Image = global::AmiOperationManagement.Properties.Resources.message_outline16;
            this.btnSubscribe.Location = new System.Drawing.Point(771, 232);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(141, 23);
            this.btnSubscribe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubscribe.TabIndex = 9;
            this.btnSubscribe.Text = "Nhận dữ liệu";
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // panelConnectionStatus
            // 
            this.panelConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.panelConnectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelConnectionStatus.Location = new System.Drawing.Point(3, 232);
            this.panelConnectionStatus.Name = "panelConnectionStatus";
            this.panelConnectionStatus.Size = new System.Drawing.Size(25, 24);
            this.panelConnectionStatus.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dữ liệu truyền / nhận ";
            // 
            // txtCommandText
            // 
            this.txtCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandText.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCommandText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommandText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCommandText.Location = new System.Drawing.Point(3, 30);
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.ReadOnly = true;
            this.txtCommandText.Size = new System.Drawing.Size(909, 198);
            this.txtCommandText.TabIndex = 0;
            this.txtCommandText.Text = "";
            // 
            // ucDcuController
            // 
            this.ucDcuController.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucDcuController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDcuController.Location = new System.Drawing.Point(0, 0);
            this.ucDcuController.Name = "ucDcuController";
            this.ucDcuController.Size = new System.Drawing.Size(915, 229);
            this.ucDcuController.TabIndex = 0;
            this.ucDcuController.Load += new System.EventHandler(this.ucDcuController_Load);
            // 
            // UCCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCCommander";
            this.Size = new System.Drawing.Size(915, 491);
            this.Load += new System.EventHandler(this.UCCommander_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelModem.ResumeLayout(false);
            this.panelModem.PerformLayout();
            this.mnRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvTopics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCommandText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AmiOperationManagement.Main.UCDcuController ucDcuController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConnectionStatus;
        private DevComponents.DotNetBar.ButtonX btnSubscribe;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMeterType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkEncryptionMessage;
        private DevComponents.AdvTree.AdvTree tvTopics;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle7;
        private DevComponents.DotNetBar.ElementStyle elementStyle8;
        private DevComponents.DotNetBar.ElementStyle elementStyle9;
        private DevComponents.DotNetBar.ElementStyle elementStyle10;
        private DevComponents.DotNetBar.ElementStyle elementStyle11;
        private DevComponents.DotNetBar.ElementStyle elementStyle12;
        private System.Windows.Forms.ImageList imageListTopics;
        private DevComponents.DotNetBar.ExpandablePanel panelModem;
        private System.Windows.Forms.RichTextBox txtDcu;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsHex;
        private System.Windows.Forms.Label label2;
        private CustomeUserControl.UCProgressBarStop ucProgressBar;
        private System.Windows.Forms.ContextMenuStrip mnRightClick;
        private System.Windows.Forms.ToolStripMenuItem mnPaste;
    }
}
