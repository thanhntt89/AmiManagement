namespace DeployManagement.Operation
{
    partial class UCMeterType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSaveMeterType = new DevComponents.DotNetBar.ButtonX();
            this.dtGridMeterType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clDeleteMeterType = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMeterType)).BeginInit();
            this.SuspendLayout();
            // 
            // btSaveMeterType
            // 
            this.btSaveMeterType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSaveMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveMeterType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSaveMeterType.Location = new System.Drawing.Point(458, 368);
            this.btSaveMeterType.Name = "btSaveMeterType";
            this.btSaveMeterType.Size = new System.Drawing.Size(75, 23);
            this.btSaveMeterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSaveMeterType.TabIndex = 3;
            this.btSaveMeterType.Text = "Lưu";
            // 
            // dtGridMeterType
            // 
            this.dtGridMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridMeterType.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridMeterType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridMeterType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMeterType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDeleteMeterType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridMeterType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridMeterType.EnableHeadersVisualStyles = false;
            this.dtGridMeterType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGridMeterType.Location = new System.Drawing.Point(0, 3);
            this.dtGridMeterType.Name = "dtGridMeterType";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridMeterType.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridMeterType.Size = new System.Drawing.Size(533, 359);
            this.dtGridMeterType.TabIndex = 2;
            // 
            // clDeleteMeterType
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Xoá";
            this.clDeleteMeterType.DefaultCellStyle = dataGridViewCellStyle2;
            this.clDeleteMeterType.HeaderText = "";
            this.clDeleteMeterType.Name = "clDeleteMeterType";
            // 
            // UCMeterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSaveMeterType);
            this.Controls.Add(this.dtGridMeterType);
            this.Name = "UCMeterType";
            this.Size = new System.Drawing.Size(537, 399);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMeterType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btSaveMeterType;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridMeterType;
        private System.Windows.Forms.DataGridViewButtonColumn clDeleteMeterType;
    }
}
