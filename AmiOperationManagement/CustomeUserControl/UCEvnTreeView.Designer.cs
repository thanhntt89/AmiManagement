namespace AmiOperationManagement.CustomeUserControl
{
    partial class UCEvnTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEvnTreeView));
            this.tvMeasurementPointGroup = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tvMeasurementPointGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // tvMeasurementPointGroup
            // 
            this.tvMeasurementPointGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvMeasurementPointGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMeasurementPointGroup.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tvMeasurementPointGroup.BackgroundStyle.Class = "TreeBorderKey";
            this.tvMeasurementPointGroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvMeasurementPointGroup.DragDropEnabled = false;
            this.tvMeasurementPointGroup.ImageList = this.imageList1;
            this.tvMeasurementPointGroup.Location = new System.Drawing.Point(3, 25);
            this.tvMeasurementPointGroup.MultiNodeDragCountVisible = false;
            this.tvMeasurementPointGroup.MultiNodeDragDropAllowed = false;
            this.tvMeasurementPointGroup.Name = "tvMeasurementPointGroup";
            this.tvMeasurementPointGroup.NodesConnector = this.nodeConnector1;
            this.tvMeasurementPointGroup.NodeStyle = this.elementStyle1;
            this.tvMeasurementPointGroup.PathSeparator = ";";
            this.tvMeasurementPointGroup.Size = new System.Drawing.Size(353, 520);
            this.tvMeasurementPointGroup.Styles.Add(this.elementStyle1);
            this.tvMeasurementPointGroup.Styles.Add(this.elementStyle2);
            this.tvMeasurementPointGroup.TabIndex = 1;
            this.tvMeasurementPointGroup.AfterExpand += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.tvMeasurementPointGroup_AfterExpand);
            this.tvMeasurementPointGroup.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.tvMeasurementPointGroup_AfterNodeSelect);
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
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(176)))), ((int)(((byte)(120)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "Orange";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(231, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Danh sách đơn vị điện lực và các đội";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Accenture-icon_01_rapid.png");
            this.imageList1.Images.SetKeyName(1, "parentGroup.png");
            this.imageList1.Images.SetKeyName(2, "mpgroup.png");
            this.imageList1.Images.SetKeyName(3, "team.png");
            // 
            // UCEvnTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tvMeasurementPointGroup);
            this.Name = "UCEvnTreeView";
            this.Size = new System.Drawing.Size(359, 548);
            this.Load += new System.EventHandler(this.UCEvnTreeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvMeasurementPointGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree tvMeasurementPointGroup;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
