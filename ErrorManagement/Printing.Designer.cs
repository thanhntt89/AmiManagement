namespace ErrorManagement
{
    partial class Printing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printing));
            this.dtgData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dcuCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixContentSuggestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFixedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getErrorExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.cboOrg = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.getOrgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnExport = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.fixGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getErrorExportTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetErrorExportTableAdapter();
            this.fixGroupTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.FixGroupTableAdapter();
            this.getOrgTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetOrgTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getErrorExportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgData.AutoGenerateColumns = false;
            this.dtgData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcuCodeDataGridViewTextBoxColumn,
            this.measurementPointDataGridViewTextBoxColumn,
            this.LocationColumn,
            this.errorDateDataGridViewTextBoxColumn,
            this.fixContentSuggestionDataGridViewTextBoxColumn,
            this.isFixedDataGridViewTextBoxColumn,
            this.fixGroupIdDataGridViewTextBoxColumn,
            this.groupCodeDataGridViewTextBoxColumn});
            this.dtgData.DataSource = this.getErrorExportBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgData.Location = new System.Drawing.Point(2, 58);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.Size = new System.Drawing.Size(811, 374);
            this.dtgData.TabIndex = 0;
            // 
            // dcuCodeDataGridViewTextBoxColumn
            // 
            this.dcuCodeDataGridViewTextBoxColumn.DataPropertyName = "DcuCode";
            this.dcuCodeDataGridViewTextBoxColumn.HeaderText = "DcuCode";
            this.dcuCodeDataGridViewTextBoxColumn.Name = "dcuCodeDataGridViewTextBoxColumn";
            this.dcuCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementPointDataGridViewTextBoxColumn
            // 
            this.measurementPointDataGridViewTextBoxColumn.DataPropertyName = "MeasurementPoint";
            this.measurementPointDataGridViewTextBoxColumn.HeaderText = "MeasurementPoint";
            this.measurementPointDataGridViewTextBoxColumn.Name = "measurementPointDataGridViewTextBoxColumn";
            this.measurementPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LocationColumn
            // 
            this.LocationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // errorDateDataGridViewTextBoxColumn
            // 
            this.errorDateDataGridViewTextBoxColumn.DataPropertyName = "ErrorDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.errorDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.errorDateDataGridViewTextBoxColumn.HeaderText = "ErrorDate";
            this.errorDateDataGridViewTextBoxColumn.Name = "errorDateDataGridViewTextBoxColumn";
            this.errorDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fixContentSuggestionDataGridViewTextBoxColumn
            // 
            this.fixContentSuggestionDataGridViewTextBoxColumn.DataPropertyName = "FixContentSuggestion";
            this.fixContentSuggestionDataGridViewTextBoxColumn.HeaderText = "FixContentSuggestion";
            this.fixContentSuggestionDataGridViewTextBoxColumn.Name = "fixContentSuggestionDataGridViewTextBoxColumn";
            this.fixContentSuggestionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fixContentSuggestionDataGridViewTextBoxColumn.Width = 200;
            // 
            // isFixedDataGridViewTextBoxColumn
            // 
            this.isFixedDataGridViewTextBoxColumn.DataPropertyName = "IsFixed";
            this.isFixedDataGridViewTextBoxColumn.HeaderText = "IsFixed";
            this.isFixedDataGridViewTextBoxColumn.Name = "isFixedDataGridViewTextBoxColumn";
            this.isFixedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isFixedDataGridViewTextBoxColumn.Visible = false;
            // 
            // fixGroupIdDataGridViewTextBoxColumn
            // 
            this.fixGroupIdDataGridViewTextBoxColumn.DataPropertyName = "FixGroupId";
            this.fixGroupIdDataGridViewTextBoxColumn.HeaderText = "FixGroupId";
            this.fixGroupIdDataGridViewTextBoxColumn.Name = "fixGroupIdDataGridViewTextBoxColumn";
            this.fixGroupIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fixGroupIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupCodeDataGridViewTextBoxColumn
            // 
            this.groupCodeDataGridViewTextBoxColumn.DataPropertyName = "GroupCode";
            this.groupCodeDataGridViewTextBoxColumn.HeaderText = "GroupCode";
            this.groupCodeDataGridViewTextBoxColumn.Name = "groupCodeDataGridViewTextBoxColumn";
            this.groupCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // getErrorExportBindingSource
            // 
            this.getErrorExportBindingSource.DataMember = "GetErrorExport";
            this.getErrorExportBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboOrg
            // 
            this.cboOrg.DataSource = this.getOrgBindingSource;
            this.cboOrg.DisplayMember = "GroupName";
            this.cboOrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.ItemHeight = 16;
            this.cboOrg.Location = new System.Drawing.Point(64, 30);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(378, 22);
            this.cboOrg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOrg.TabIndex = 1;
            this.cboOrg.ValueMember = "GroupCode";
            // 
            // getOrgBindingSource
            // 
            this.getOrgBindingSource.DataMember = "GetOrg";
            this.getOrgBindingSource.DataSource = this.amiReportDataSet;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(0, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(35, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Team";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExport.Location = new System.Drawing.Point(738, 438);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(1, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Forward to";
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(64, 2);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(378, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboForwardTo.TabIndex = 1;
            this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            // 
            // fixGroupBindingSource
            // 
            this.fixGroupBindingSource.DataMember = "FixGroup";
            this.fixGroupBindingSource.DataSource = this.amiReportDataSet;
            // 
            // getErrorExportTableAdapter
            // 
            this.getErrorExportTableAdapter.ClearBeforeFill = true;
            // 
            // fixGroupTableAdapter
            // 
            this.fixGroupTableAdapter.ClearBeforeFill = true;
            // 
            // getOrgTableAdapter
            // 
            this.getOrgTableAdapter.ClearBeforeFill = true;
            // 
            // Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.cboOrg);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtgData);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Printing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export data";
            this.Load += new System.EventHandler(this.Printing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getErrorExportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgData;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboOrg;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnExport;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
        private System.Windows.Forms.BindingSource getErrorExportBindingSource;
        private AmiReportDataSet amiReportDataSet;
        private AmiReportDataSetTableAdapters.GetErrorExportTableAdapter getErrorExportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcuCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixContentSuggestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFixedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fixGroupBindingSource;
        private AmiReportDataSetTableAdapters.FixGroupTableAdapter fixGroupTableAdapter;
        private System.Windows.Forms.BindingSource getOrgBindingSource;
        private AmiReportDataSetTableAdapters.GetOrgTableAdapter getOrgTableAdapter;
    }
}