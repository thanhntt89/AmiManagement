namespace AmiOperationManagement.Systems
{
    partial class UCUserPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserPermission));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.dtgFunction = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.GroupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActiveCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.tvGroupFunction = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvGroupFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            this.imageList.Images.SetKeyName(1, "Accenture-icon_01_rapid.png");
            this.imageList.Images.SetKeyName(2, "admin.png");
            this.imageList.Images.SetKeyName(3, "gnome_system_config.png");
            this.imageList.Images.SetKeyName(4, "distributions-kubuntu-linux.png");
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(786, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgFunction
            // 
            this.dtgFunction.AllowUserToAddRows = false;
            this.dtgFunction.AllowUserToDeleteRows = false;
            this.dtgFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFunction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFunction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupIdCol,
            this.FunctionIdCol,
            this.FunctionNameCol,
            this.IsActiveCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFunction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFunction.EnableHeadersVisualStyles = false;
            this.dtgFunction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgFunction.Location = new System.Drawing.Point(274, 3);
            this.dtgFunction.Name = "dtgFunction";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFunction.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgFunction.Size = new System.Drawing.Size(587, 429);
            this.dtgFunction.TabIndex = 0;
            this.dtgFunction.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgFunction_RowPostPaint);
            // 
            // GroupIdCol
            // 
            this.GroupIdCol.HeaderText = "GroupIdCol";
            this.GroupIdCol.Name = "GroupIdCol";
            this.GroupIdCol.Visible = false;
            // 
            // FunctionIdCol
            // 
            this.FunctionIdCol.HeaderText = "FunctionIdCol";
            this.FunctionIdCol.Name = "FunctionIdCol";
            this.FunctionIdCol.Visible = false;
            // 
            // FunctionNameCol
            // 
            this.FunctionNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FunctionNameCol.HeaderText = "Tên chức năng";
            this.FunctionNameCol.Name = "FunctionNameCol";
            this.FunctionNameCol.ReadOnly = true;
            // 
            // IsActiveCol
            // 
            this.IsActiveCol.Checked = true;
            this.IsActiveCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsActiveCol.CheckValue = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsActiveCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsActiveCol.HeaderText = "Sử dụng";
            this.IsActiveCol.Name = "IsActiveCol";
            this.IsActiveCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActiveCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsActiveCol.Width = 80;
            // 
            // tvGroupFunction
            // 
            this.tvGroupFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvGroupFunction.AllowDrop = true;
            this.tvGroupFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvGroupFunction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.tvGroupFunction.BackgroundStyle.Class = "TreeBorderKey";
            this.tvGroupFunction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvGroupFunction.ColumnsVisible = false;
            this.tvGroupFunction.DoubleClickTogglesNode = false;
            this.tvGroupFunction.DragDropEnabled = false;
            this.tvGroupFunction.DragDropNodeCopyEnabled = false;
            this.tvGroupFunction.FullRowSelect = false;
            this.tvGroupFunction.GridColumnLines = false;
            this.tvGroupFunction.ImageList = this.imageList;
            this.tvGroupFunction.Location = new System.Drawing.Point(3, 3);
            this.tvGroupFunction.Name = "tvGroupFunction";
            this.tvGroupFunction.NodesConnector = this.nodeConnector1;
            this.tvGroupFunction.NodeStyle = this.elementStyle1;
            this.tvGroupFunction.PathSeparator = ";";
            this.tvGroupFunction.Size = new System.Drawing.Size(264, 460);
            this.tvGroupFunction.Styles.Add(this.elementStyle1);
            this.tvGroupFunction.TabIndex = 0;
            this.tvGroupFunction.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.tvGroupFunction_AfterNodeSelect);
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
            // UCUserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgFunction);
            this.Controls.Add(this.tvGroupFunction);
            this.Name = "UCUserPermission";
            this.Size = new System.Drawing.Size(864, 466);
            this.Load += new System.EventHandler(this.UCUserPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvGroupFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree tvGroupFunction;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgFunction;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionNameCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsActiveCol;
    }
}
