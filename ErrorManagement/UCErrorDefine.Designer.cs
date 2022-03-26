namespace ErrorManagement
{
    partial class UCErrorDefine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCErrorDefine));
            this.dtgErrorDefine = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.errorCodeIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorNameIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.errorCodeTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.ErrorCodeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorDefine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgErrorDefine
            // 
            this.dtgErrorDefine.AllowUserToOrderColumns = true;
            this.dtgErrorDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgErrorDefine.AutoGenerateColumns = false;
            this.dtgErrorDefine.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgErrorDefine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrorDefine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errorCodeIndex,
            this.errorNameIndex});
            this.dtgErrorDefine.DataSource = this.errorCodeBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgErrorDefine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgErrorDefine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgErrorDefine.Location = new System.Drawing.Point(3, 32);
            this.dtgErrorDefine.Name = "dtgErrorDefine";
            this.dtgErrorDefine.Size = new System.Drawing.Size(592, 394);
            this.dtgErrorDefine.TabIndex = 0;
            this.dtgErrorDefine.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgErrorDefine_DataError);
            this.dtgErrorDefine.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgErrorDefine_RowPostPaint);
            // 
            // errorCodeIndex
            // 
            this.errorCodeIndex.DataPropertyName = "ErrorCode";
            this.errorCodeIndex.HeaderText = "ErrorCode";
            this.errorCodeIndex.Name = "errorCodeIndex";
            // 
            // errorNameIndex
            // 
            this.errorNameIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errorNameIndex.DataPropertyName = "ErrorName";
            this.errorNameIndex.HeaderText = "ErrorName";
            this.errorNameIndex.Name = "errorNameIndex";
            // 
            // errorCodeBindingSource
            // 
            this.errorCodeBindingSource.DataMember = "ErrorCode";
            this.errorCodeBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(520, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Error define";
            // 
            // errorCodeTableAdapter
            // 
            this.errorCodeTableAdapter.ClearBeforeFill = true;
            // 
            // UCErrorDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(597, 458);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgErrorDefine);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UCErrorDefine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UCErrorDefine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorDefine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgErrorDefine;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX1;
        private AmiReportDataSet amiReportDataSet;
        private System.Windows.Forms.BindingSource errorCodeBindingSource;
        private AmiReportDataSetTableAdapters.ErrorCodeTableAdapter errorCodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorCodeIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorNameIndex;
    }
}
