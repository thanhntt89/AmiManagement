namespace ErrorManagement
{
    partial class FixbugeStep
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixbugeStep));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtgFixStep = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.FixStepIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixGroupIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixStepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnUp = new DevComponents.DotNetBar.ButtonX();
            this.btnDown = new DevComponents.DotNetBar.ButtonX();
            this.errorCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorCodeTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.ErrorCodeTableAdapter();
            this.fixGroupTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.FixGroupTableAdapter();
            this.fixStepTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.FixStepTableAdapter();
            this.cboErrorCode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixStepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Error Name";
            // 
            // dtgFixStep
            // 
            this.dtgFixStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFixStep.AutoGenerateColumns = false;
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
            this.FixStepIdColumn,
            this.StepIndexColumn,
            this.FixGroupIdColumn,
            this.ErrorCodeColumn,
            this.FixStepNameColumn});
            this.dtgFixStep.DataSource = this.fixStepBindingSource;
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
            this.dtgFixStep.Location = new System.Drawing.Point(5, 89);
            this.dtgFixStep.Name = "dtgFixStep";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFixStep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFixStep.Size = new System.Drawing.Size(617, 273);
            this.dtgFixStep.TabIndex = 2;
            this.dtgFixStep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFixStep_CellClick);
            this.dtgFixStep.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgFixStep_RowPostPaint);
            this.dtgFixStep.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgFixStep_UserAddedRow);
            // 
            // FixStepIdColumn
            // 
            this.FixStepIdColumn.DataPropertyName = "FixStepId";
            this.FixStepIdColumn.HeaderText = "FixStepId";
            this.FixStepIdColumn.Name = "FixStepIdColumn";
            this.FixStepIdColumn.ReadOnly = true;
            this.FixStepIdColumn.Visible = false;
            // 
            // StepIndexColumn
            // 
            this.StepIndexColumn.DataPropertyName = "StepIndex";
            this.StepIndexColumn.HeaderText = "StepIndex";
            this.StepIndexColumn.Name = "StepIndexColumn";
            this.StepIndexColumn.Visible = false;
            // 
            // FixGroupIdColumn
            // 
            this.FixGroupIdColumn.DataPropertyName = "FixGroupId";
            this.FixGroupIdColumn.HeaderText = "FixGroupId";
            this.FixGroupIdColumn.Name = "FixGroupIdColumn";
            this.FixGroupIdColumn.Visible = false;
            // 
            // ErrorCodeColumn
            // 
            this.ErrorCodeColumn.DataPropertyName = "ErrorCode";
            this.ErrorCodeColumn.HeaderText = "ErrorCode";
            this.ErrorCodeColumn.Name = "ErrorCodeColumn";
            this.ErrorCodeColumn.Visible = false;
            // 
            // FixStepNameColumn
            // 
            this.FixStepNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FixStepNameColumn.DataPropertyName = "FixStepName";
            this.FixStepNameColumn.HeaderText = "FixStepName";
            this.FixStepNameColumn.Name = "FixStepNameColumn";
            // 
            // fixStepBindingSource
            // 
            this.fixStepBindingSource.DataMember = "FixStep";
            this.fixStepBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(5, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Fix error step";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(547, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
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
            this.labelX3.Location = new System.Drawing.Point(5, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "To";
            // 
            // btnUp
            // 
            this.btnUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUp.Location = new System.Drawing.Point(9, 368);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDown.Location = new System.Drawing.Point(90, 368);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // errorCodeBindingSource
            // 
            this.errorCodeBindingSource.DataMember = "ErrorCode";
            this.errorCodeBindingSource.DataSource = this.amiReportDataSet;
            // 
            // fixGroupBindingSource
            // 
            this.fixGroupBindingSource.DataMember = "FixGroup";
            this.fixGroupBindingSource.DataSource = this.amiReportDataSet;
            // 
            // errorCodeTableAdapter
            // 
            this.errorCodeTableAdapter.ClearBeforeFill = true;
            // 
            // fixGroupTableAdapter
            // 
            this.fixGroupTableAdapter.ClearBeforeFill = true;
            // 
            // fixStepTableAdapter
            // 
            this.fixStepTableAdapter.ClearBeforeFill = true;
            // 
            // cboErrorCode
            // 
            this.cboErrorCode.DataSource = this.errorCodeBindingSource;
            this.cboErrorCode.DisplayMember = "ErrorName";
            this.cboErrorCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboErrorCode.ForeColor = System.Drawing.Color.Black;
            this.cboErrorCode.FormattingEnabled = true;
            this.cboErrorCode.ItemHeight = 16;
            this.cboErrorCode.Location = new System.Drawing.Point(75, 1);
            this.cboErrorCode.Name = "cboErrorCode";
            this.cboErrorCode.Size = new System.Drawing.Size(496, 22);
            this.cboErrorCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboErrorCode.TabIndex = 7;
            this.cboErrorCode.ValueMember = "ErrorCode";
            this.cboErrorCode.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.DataSource = this.fixGroupBindingSource;
            this.cboForwardTo.DisplayMember = "FixGroupName";
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.ForeColor = System.Drawing.Color.Black;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(75, 30);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(496, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboForwardTo.TabIndex = 8;
            this.cboForwardTo.ValueMember = "FixGroupId";
            this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            // 
            // FixbugeStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.cboErrorCode);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dtgFixStep);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FixbugeStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fix Error Step";
            this.Load += new System.EventHandler(this.FixbugeStep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFixStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixStepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgFixStep;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private AmiReportDataSet amiReportDataSet;
        private System.Windows.Forms.BindingSource errorCodeBindingSource;
        private AmiReportDataSetTableAdapters.ErrorCodeTableAdapter errorCodeTableAdapter;
        private System.Windows.Forms.BindingSource fixGroupBindingSource;
        private AmiReportDataSetTableAdapters.FixGroupTableAdapter fixGroupTableAdapter;
        private System.Windows.Forms.BindingSource fixStepBindingSource;
        private AmiReportDataSetTableAdapters.FixStepTableAdapter fixStepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixGroupIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepNameColumn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboErrorCode;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
    }
}