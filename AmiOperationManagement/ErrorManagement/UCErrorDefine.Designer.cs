namespace AmiOperationManagement.ErrorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCErrorDefine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.dtgErrorDefine = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ErrorCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFixErrorStep = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorDefine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(576, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgErrorDefine
            // 
            this.dtgErrorDefine.AllowUserToOrderColumns = true;
            this.dtgErrorDefine.AllowUserToResizeColumns = false;
            this.dtgErrorDefine.AllowUserToResizeRows = false;
            this.dtgErrorDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgErrorDefine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgErrorDefine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgErrorDefine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgErrorDefine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorCodeCol,
            this.ErrorNameCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgErrorDefine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgErrorDefine.EnableHeadersVisualStyles = false;
            this.dtgErrorDefine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgErrorDefine.Location = new System.Drawing.Point(3, 3);
            this.dtgErrorDefine.Name = "dtgErrorDefine";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgErrorDefine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgErrorDefine.Size = new System.Drawing.Size(657, 393);
            this.dtgErrorDefine.TabIndex = 2;
            this.dtgErrorDefine.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgErrorDefine_RowPostPaint);
            // 
            // ErrorCodeCol
            // 
            this.ErrorCodeCol.DataPropertyName = "ErrorCode";
            this.ErrorCodeCol.HeaderText = "Mã lỗi";
            this.ErrorCodeCol.Name = "ErrorCodeCol";
            // 
            // ErrorNameCol
            // 
            this.ErrorNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ErrorNameCol.DataPropertyName = "ErrorName";
            this.ErrorNameCol.HeaderText = "Tên lỗi";
            this.ErrorNameCol.Name = "ErrorNameCol";
            // 
            // btnFixErrorStep
            // 
            this.btnFixErrorStep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFixErrorStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixErrorStep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFixErrorStep.Image = ((System.Drawing.Image)(resources.GetObject("btnFixErrorStep.Image")));
            this.btnFixErrorStep.Location = new System.Drawing.Point(453, 402);
            this.btnFixErrorStep.Name = "btnFixErrorStep";
            this.btnFixErrorStep.Size = new System.Drawing.Size(117, 23);
            this.btnFixErrorStep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFixErrorStep.TabIndex = 3;
            this.btnFixErrorStep.Text = "Các bước sửa lỗi";
            this.btnFixErrorStep.Click += new System.EventHandler(this.btnFixErrorStep_Click);
            // 
            // UCErrorDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnFixErrorStep);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgErrorDefine);
            this.Name = "UCErrorDefine";
            this.Size = new System.Drawing.Size(663, 428);
            this.Load += new System.EventHandler(this.UCErrorDefine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgErrorDefine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgErrorDefine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorNameCol;
        private DevComponents.DotNetBar.ButtonX btnFixErrorStep;
    }
}
