namespace AmiOperationManagement.Connection
{
    partial class UCClientConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClientConnection));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelConnectionStatus = new System.Windows.Forms.Panel();
            this.tvServerList = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle4 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle5 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle6 = new DevComponents.DotNetBar.ElementStyle();
            this.btnDisconnect = new DevComponents.DotNetBar.ButtonX();
            this.btnConnect = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tvServerList)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "server_network.png");
            this.imageList.Images.SetKeyName(1, "stock_connect.png");
            this.imageList.Images.SetKeyName(2, "gtk_disconnect.png");
            this.imageList.Images.SetKeyName(3, "computer-blue-server1.png");
            this.imageList.Images.SetKeyName(4, "computer-red-server1.png");
            this.imageList.Images.SetKeyName(5, "home.png");
            // 
            // panelConnectionStatus
            // 
            this.panelConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.panelConnectionStatus.Location = new System.Drawing.Point(4, 399);
            this.panelConnectionStatus.Name = "panelConnectionStatus";
            this.panelConnectionStatus.Size = new System.Drawing.Size(290, 24);
            this.panelConnectionStatus.TabIndex = 13;
            // 
            // tvServerList
            // 
            this.tvServerList.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvServerList.AllowDrop = true;
            this.tvServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvServerList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.tvServerList.BackgroundStyle.Class = "TreeBorderKey";
            this.tvServerList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvServerList.ColumnsVisible = false;
            this.tvServerList.DragDropEnabled = false;
            this.tvServerList.DragDropNodeCopyEnabled = false;
            this.tvServerList.FullRowSelect = false;
            this.tvServerList.GridColumnLines = false;
            this.tvServerList.ImageIndex = 0;
            this.tvServerList.ImageList = this.imageList;
            this.tvServerList.Location = new System.Drawing.Point(5, 3);
            this.tvServerList.MultiNodeDragCountVisible = false;
            this.tvServerList.MultiNodeDragDropAllowed = false;
            this.tvServerList.Name = "tvServerList";
            this.tvServerList.NodesConnector = this.nodeConnector1;
            this.tvServerList.NodeStyle = this.elementStyle1;
            this.tvServerList.PathSeparator = ";";
            this.tvServerList.Size = new System.Drawing.Size(290, 390);
            this.tvServerList.Styles.Add(this.elementStyle1);
            this.tvServerList.Styles.Add(this.elementStyle2);
            this.tvServerList.Styles.Add(this.elementStyle3);
            this.tvServerList.Styles.Add(this.elementStyle4);
            this.tvServerList.Styles.Add(this.elementStyle5);
            this.tvServerList.Styles.Add(this.elementStyle6);
            this.tvServerList.TabIndex = 0;
            this.tvServerList.TouchEnabled = false;
            this.tvServerList.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.tvServerList_NodeClick);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.Navy;
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.Navy;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "BlueNight";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.White;
            // 
            // elementStyle3
            // 
            this.elementStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle3.BackColorGradientAngle = 90;
            this.elementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderBottomWidth = 1;
            this.elementStyle3.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderLeftWidth = 1;
            this.elementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderRightWidth = 1;
            this.elementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderTopWidth = 1;
            this.elementStyle3.CornerDiameter = 4;
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle3.Description = "Blue";
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.PaddingBottom = 1;
            this.elementStyle3.PaddingLeft = 1;
            this.elementStyle3.PaddingRight = 1;
            this.elementStyle3.PaddingTop = 1;
            this.elementStyle3.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle4
            // 
            this.elementStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle4.BackColorGradientAngle = 90;
            this.elementStyle4.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderBottomWidth = 1;
            this.elementStyle4.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle4.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderLeftWidth = 1;
            this.elementStyle4.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderRightWidth = 1;
            this.elementStyle4.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle4.BorderTopWidth = 1;
            this.elementStyle4.CornerDiameter = 4;
            this.elementStyle4.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle4.Description = "Blue";
            this.elementStyle4.Name = "elementStyle4";
            this.elementStyle4.PaddingBottom = 1;
            this.elementStyle4.PaddingLeft = 1;
            this.elementStyle4.PaddingRight = 1;
            this.elementStyle4.PaddingTop = 1;
            this.elementStyle4.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle5
            // 
            this.elementStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.elementStyle5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.elementStyle5.BackColorGradientAngle = 90;
            this.elementStyle5.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle5.BorderBottomWidth = 1;
            this.elementStyle5.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle5.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle5.BorderLeftWidth = 1;
            this.elementStyle5.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle5.BorderRightWidth = 1;
            this.elementStyle5.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle5.BorderTopWidth = 1;
            this.elementStyle5.CornerDiameter = 4;
            this.elementStyle5.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle5.Description = "Yellow";
            this.elementStyle5.Name = "elementStyle5";
            this.elementStyle5.PaddingBottom = 1;
            this.elementStyle5.PaddingLeft = 1;
            this.elementStyle5.PaddingRight = 1;
            this.elementStyle5.PaddingTop = 1;
            this.elementStyle5.TextColor = System.Drawing.Color.Black;
            // 
            // elementStyle6
            // 
            this.elementStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.elementStyle6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.elementStyle6.BackColorGradientAngle = 90;
            this.elementStyle6.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle6.BorderBottomWidth = 1;
            this.elementStyle6.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle6.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle6.BorderLeftWidth = 1;
            this.elementStyle6.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle6.BorderRightWidth = 1;
            this.elementStyle6.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle6.BorderTopWidth = 1;
            this.elementStyle6.CornerDiameter = 4;
            this.elementStyle6.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle6.Description = "Red";
            this.elementStyle6.Name = "elementStyle6";
            this.elementStyle6.PaddingBottom = 1;
            this.elementStyle6.PaddingLeft = 1;
            this.elementStyle6.PaddingRight = 1;
            this.elementStyle6.PaddingTop = 1;
            this.elementStyle6.TextColor = System.Drawing.Color.Black;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.Location = new System.Drawing.Point(206, 429);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(88, 23);
            this.btnDisconnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Ngắt kết nối";
            this.btnDisconnect.TextColor = System.Drawing.Color.Red;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(125, 429);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // UCClientConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelConnectionStatus);
            this.Controls.Add(this.tvServerList);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "UCClientConnection";
            this.Size = new System.Drawing.Size(298, 458);
            this.Load += new System.EventHandler(this.UCClientConnection_Load);
            this.SizeChanged += new System.EventHandler(this.UCClientConnection_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tvServerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDisconnect;
        private DevComponents.DotNetBar.ButtonX btnConnect;
        private DevComponents.AdvTree.AdvTree tvServerList;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private DevComponents.DotNetBar.ElementStyle elementStyle4;
        private DevComponents.DotNetBar.ElementStyle elementStyle5;
        private DevComponents.DotNetBar.ElementStyle elementStyle6;
        private System.Windows.Forms.Panel panelConnectionStatus;
    }
}
