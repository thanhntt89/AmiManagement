namespace AmiOperationManagement.ErrorManagement
{
    partial class UCErrorSolution
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCErrorSolution));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkSelectedAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDown = new DevComponents.DotNetBar.ButtonX();
            this.btnUp = new DevComponents.DotNetBar.ButtonX();
            this.chkFixed = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtNotes = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtgStepList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ErrorIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsUsedCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.ChooseCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblPEName = new System.Windows.Forms.Label();
            this.lblMeterType = new System.Windows.Forms.Label();
            this.lblPe = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtDcu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtErrorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStepList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSelectedAll
            // 
            this.chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectedAll.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.chkSelectedAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSelectedAll.Location = new System.Drawing.Point(726, 134);
            this.chkSelectedAll.Name = "chkSelectedAll";
            this.chkSelectedAll.Size = new System.Drawing.Size(18, 17);
            this.chkSelectedAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSelectedAll.TabIndex = 56;
            this.chkSelectedAll.CheckedChanged += new System.EventHandler(this.chkSelectedAll_CheckedChanged);
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboForwardTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(72, 104);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(241, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.cboForwardTo.TabIndex = 36;
            // 
            // btnDown
            // 
            this.btnDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(734, 310);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 22);
            this.btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDown.TabIndex = 42;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(708, 310);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(22, 22);
            this.btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUp.TabIndex = 40;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // chkFixed
            // 
            this.chkFixed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chkFixed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFixed.Location = new System.Drawing.Point(618, 507);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(60, 23);
            this.chkFixed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFixed.TabIndex = 47;
            this.chkFixed.Text = "Đã xử lý";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(684, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNotes.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtNotes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNotes.Location = new System.Drawing.Point(3, 338);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(758, 165);
            this.txtNotes.TabIndex = 44;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(75, 358);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(110, 23);
            this.labelX5.TabIndex = 48;
            this.labelX5.Text = "Ghi chú";
            // 
            // dtgStepList
            // 
            this.dtgStepList.AllowUserToAddRows = false;
            this.dtgStepList.AllowUserToDeleteRows = false;
            this.dtgStepList.AllowUserToResizeRows = false;
            this.dtgStepList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStepList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgStepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgStepList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorIdCol,
            this.FixStepIdCol,
            this.FixStepNameCol,
            this.IsUsedCol,
            this.ChooseCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgStepList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgStepList.EnableHeadersVisualStyles = false;
            this.dtgStepList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgStepList.Location = new System.Drawing.Point(3, 131);
            this.dtgStepList.MultiSelect = false;
            this.dtgStepList.Name = "dtgStepList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStepList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgStepList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgStepList.Size = new System.Drawing.Size(757, 173);
            this.dtgStepList.TabIndex = 38;
            this.dtgStepList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStepList_CellClick);
            this.dtgStepList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStepList_CellValueChanged);
            this.dtgStepList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgStepList_RowPostPaint);
            // 
            // ErrorIdCol
            // 
            this.ErrorIdCol.DataPropertyName = "ErrorIdCol";
            this.ErrorIdCol.HeaderText = "ErrorId";
            this.ErrorIdCol.Name = "ErrorIdCol";
            this.ErrorIdCol.ReadOnly = true;
            this.ErrorIdCol.Visible = false;
            // 
            // FixStepIdCol
            // 
            this.FixStepIdCol.DataPropertyName = "FixStepIdCol";
            this.FixStepIdCol.HeaderText = "FixStepIdCol";
            this.FixStepIdCol.Name = "FixStepIdCol";
            this.FixStepIdCol.ReadOnly = true;
            this.FixStepIdCol.Visible = false;
            // 
            // FixStepNameCol
            // 
            this.FixStepNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FixStepNameCol.DataPropertyName = "FixStepNameCol";
            this.FixStepNameCol.HeaderText = "Các bước sửa lỗi";
            this.FixStepNameCol.Name = "FixStepNameCol";
            this.FixStepNameCol.ReadOnly = true;
            this.FixStepNameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsUsedCol
            // 
            this.IsUsedCol.Checked = true;
            this.IsUsedCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsUsedCol.CheckValue = null;
            this.IsUsedCol.DataPropertyName = "IsUsed";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsUsedCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsUsedCol.HeaderText = "";
            this.IsUsedCol.Name = "IsUsedCol";
            this.IsUsedCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsUsedCol.Width = 50;
            // 
            // ChooseCol
            // 
            this.ChooseCol.DataPropertyName = "ChooseCol";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Select";
            this.ChooseCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChooseCol.HeaderText = "";
            this.ChooseCol.Name = "ChooseCol";
            this.ChooseCol.Visible = false;
            this.ChooseCol.Width = 75;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 102);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 23);
            this.labelX4.TabIndex = 43;
            this.labelX4.Text = "Đơn vị xử lý";
            // 
            // lblPEName
            // 
            this.lblPEName.AutoSize = true;
            this.lblPEName.Location = new System.Drawing.Point(72, 58);
            this.lblPEName.Name = "lblPEName";
            this.lblPEName.Size = new System.Drawing.Size(13, 13);
            this.lblPEName.TabIndex = 41;
            this.lblPEName.Text = "..";
            // 
            // lblMeterType
            // 
            this.lblMeterType.AutoSize = true;
            this.lblMeterType.Location = new System.Drawing.Point(271, 9);
            this.lblMeterType.Name = "lblMeterType";
            this.lblMeterType.Size = new System.Drawing.Size(13, 13);
            this.lblMeterType.TabIndex = 41;
            this.lblMeterType.Text = "..";
            // 
            // lblPe
            // 
            this.lblPe.AutoSize = true;
            this.lblPe.Location = new System.Drawing.Point(72, 35);
            this.lblPe.Name = "lblPe";
            this.lblPe.Size = new System.Drawing.Size(13, 13);
            this.lblPe.TabIndex = 41;
            this.lblPe.Text = "..";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Location = new System.Drawing.Point(140, 83);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(13, 13);
            this.lblErrorName.TabIndex = 41;
            this.lblErrorName.Text = "..";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(129, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(16, 23);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "-";
            // 
            // txtDcu
            // 
            this.txtDcu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtDcu.Border.Class = "TextBoxBorder";
            this.txtDcu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDcu.ForeColor = System.Drawing.Color.Black;
            this.txtDcu.Location = new System.Drawing.Point(72, 3);
            this.txtDcu.Name = "txtDcu";
            this.txtDcu.ReadOnly = true;
            this.txtDcu.Size = new System.Drawing.Size(125, 22);
            this.txtDcu.TabIndex = 52;
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.txtErrorCode.Border.Class = "TextBoxBorder";
            this.txtErrorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtErrorCode.ForeColor = System.Drawing.Color.Black;
            this.txtErrorCode.Location = new System.Drawing.Point(72, 78);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.ReadOnly = true;
            this.txtErrorCode.Size = new System.Drawing.Size(51, 22);
            this.txtErrorCode.TabIndex = 54;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(203, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(62, 23);
            this.labelX8.TabIndex = 37;
            this.labelX8.Text = "Loại công tơ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(4, 1);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(109, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "Mã modem";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(4, 54);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(66, 23);
            this.labelX7.TabIndex = 35;
            this.labelX7.Text = "Tên điểm đo";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 30);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 23);
            this.labelX6.TabIndex = 35;
            this.labelX6.Text = "Mã điểm đo";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(4, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 23);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "Mã lối";
            // 
            // UCErrorSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.chkSelectedAll);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.chkFixed);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtgStepList);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblPEName);
            this.Controls.Add(this.lblMeterType);
            this.Controls.Add(this.lblPe);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDcu);
            this.Controls.Add(this.txtErrorCode);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCErrorSolution";
            this.Size = new System.Drawing.Size(762, 533);
            this.Load += new System.EventHandler(this.ErrorSolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStepList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFixed;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtNotes;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgStepList;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Label lblErrorName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDcu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtErrorCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSelectedAll;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Label lblPe;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Label lblPEName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Label lblMeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepNameCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsUsedCol;
        private System.Windows.Forms.DataGridViewButtonColumn ChooseCol;
    }
}