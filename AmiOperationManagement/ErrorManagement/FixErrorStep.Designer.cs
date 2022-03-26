namespace AmiOperationManagement.ErrorManagement
{
    partial class FixErrorStep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixErrorStep));
            this.dtgFixStep = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.FixStepIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixGroupIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepIndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboErrorCode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDown = new DevComponents.DotNetBar.ButtonX();
            this.btnUp = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnLocation = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixStep)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFixStep
            // 
            this.dtgFixStep.AllowUserToOrderColumns = true;
            this.dtgFixStep.AllowUserToResizeRows = false;
            this.dtgFixStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFixStep.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFixStep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFixStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFixStep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FixStepIdCol,
            this.FixGroupIdCol,
            this.StepIndexCol,
            this.ErrorCodeCol,
            this.FixStepNameCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFixStep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFixStep.EnableHeadersVisualStyles = false;
            this.dtgFixStep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgFixStep.Location = new System.Drawing.Point(3, 75);
            this.dtgFixStep.Name = "dtgFixStep";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFixStep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFixStep.Size = new System.Drawing.Size(709, 337);
            this.dtgFixStep.TabIndex = 2;
            this.dtgFixStep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFixStep_CellClick);
            this.dtgFixStep.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFixStep_CellEndEdit);
            this.dtgFixStep.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgFixStep_RowPostPaint);
            this.dtgFixStep.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dtgFixStep_UserDeletingRow);
            // 
            // FixStepIdCol
            // 
            this.FixStepIdCol.DataPropertyName = "FixStepId";
            this.FixStepIdCol.HeaderText = "FixStepIndex";
            this.FixStepIdCol.Name = "FixStepIdCol";
            this.FixStepIdCol.Visible = false;
            // 
            // FixGroupIdCol
            // 
            this.FixGroupIdCol.DataPropertyName = "FixGroupId";
            this.FixGroupIdCol.HeaderText = "FixGroupId";
            this.FixGroupIdCol.Name = "FixGroupIdCol";
            this.FixGroupIdCol.Visible = false;
            // 
            // StepIndexCol
            // 
            this.StepIndexCol.DataPropertyName = "StepIndex";
            this.StepIndexCol.HeaderText = "StepIndex";
            this.StepIndexCol.Name = "StepIndexCol";
            this.StepIndexCol.Visible = false;
            // 
            // ErrorCodeCol
            // 
            this.ErrorCodeCol.DataPropertyName = "ErrorCode";
            this.ErrorCodeCol.HeaderText = "ErrorCode";
            this.ErrorCodeCol.Name = "ErrorCodeCol";
            this.ErrorCodeCol.Visible = false;
            // 
            // FixStepNameCol
            // 
            this.FixStepNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FixStepNameCol.DataPropertyName = "FixStepName";
            this.FixStepNameCol.HeaderText = "Bước sửa lỗi";
            this.FixStepNameCol.Name = "FixStepNameCol";
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.DisplayMember = "FixGroupName";
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForwardTo.ForeColor = System.Drawing.Color.Black;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(52, 28);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(483, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboForwardTo.TabIndex = 1;
            this.cboForwardTo.ValueMember = "FixGroupId";
            // 
            // cboErrorCode
            // 
            this.cboErrorCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboErrorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorCode.ForeColor = System.Drawing.Color.Black;
            this.cboErrorCode.FormattingEnabled = true;
            this.cboErrorCode.ItemHeight = 16;
            this.cboErrorCode.Location = new System.Drawing.Point(52, 3);
            this.cboErrorCode.Name = "cboErrorCode";
            this.cboErrorCode.Size = new System.Drawing.Size(483, 22);
            this.cboErrorCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboErrorCode.TabIndex = 0;
            // 
            // btnDown
            // 
            this.btnDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(34, 420);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 23);
            this.btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDown.TabIndex = 4;
            this.btnDown.Tooltip = "Chuyển xuống";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(3, 420);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 23);
            this.btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUp.TabIndex = 3;
            this.btnUp.Tooltip = "Chuyển lên";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(556, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(3, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Nơi xử lý";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(3, 54);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Bước xử lý";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Tên lỗi";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(637, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLocation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLocation.Location = new System.Drawing.Point(541, 27);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(28, 23);
            this.btnLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLocation.TabIndex = 13;
            this.btnLocation.Text = "...";
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // FixErrorStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(713, 442);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.dtgFixStep);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.cboErrorCode);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixErrorStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UCErrorFixStep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboErrorCode;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgFixStep;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixGroupIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepIndexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepNameCol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnLocation;
    }
}
