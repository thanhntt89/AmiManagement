namespace DeployManagement.Operation
{
    partial class UCFirmware
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
            this.dtGridFirmware = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btSaveFirmware = new DevComponents.DotNetBar.ButtonX();
            this.btDeleteFirmware = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFirmware)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridFirmware
            // 
            this.dtGridFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridFirmware.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFirmware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridFirmware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFirmware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btDeleteFirmware});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridFirmware.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridFirmware.EnableHeadersVisualStyles = false;
            this.dtGridFirmware.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGridFirmware.Location = new System.Drawing.Point(3, 3);
            this.dtGridFirmware.Name = "dtGridFirmware";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridFirmware.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridFirmware.Size = new System.Drawing.Size(533, 355);
            this.dtGridFirmware.TabIndex = 3;
            // 
            // btSaveFirmware
            // 
            this.btSaveFirmware.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSaveFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveFirmware.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSaveFirmware.Location = new System.Drawing.Point(461, 364);
            this.btSaveFirmware.Name = "btSaveFirmware";
            this.btSaveFirmware.Size = new System.Drawing.Size(75, 23);
            this.btSaveFirmware.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSaveFirmware.TabIndex = 4;
            this.btSaveFirmware.Text = "Lưu";
            // 
            // btDeleteFirmware
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Xoá";
            this.btDeleteFirmware.DefaultCellStyle = dataGridViewCellStyle2;
            this.btDeleteFirmware.HeaderText = "";
            this.btDeleteFirmware.Name = "btDeleteFirmware";
            this.btDeleteFirmware.Width = 75;
            // 
            // UCFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSaveFirmware);
            this.Controls.Add(this.dtGridFirmware);
            this.Name = "UCFirmware";
            this.Size = new System.Drawing.Size(539, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFirmware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridFirmware;
        private DevComponents.DotNetBar.ButtonX btSaveFirmware;
        private System.Windows.Forms.DataGridViewButtonColumn btDeleteFirmware;
    }
}
