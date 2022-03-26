namespace DeployManagement.Operation
{
    partial class UCServer
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
            this.btSaveServer = new DevComponents.DotNetBar.ButtonX();
            this.dtGridServer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btDeleteServer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridServer)).BeginInit();
            this.SuspendLayout();
            // 
            // btSaveServer
            // 
            this.btSaveServer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSaveServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveServer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSaveServer.Location = new System.Drawing.Point(588, 487);
            this.btSaveServer.Name = "btSaveServer";
            this.btSaveServer.Size = new System.Drawing.Size(85, 23);
            this.btSaveServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSaveServer.TabIndex = 7;
            this.btSaveServer.Text = "Lưu";
            // 
            // dtGridServer
            // 
            this.dtGridServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridServer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridServer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridServer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btDeleteServer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridServer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridServer.EnableHeadersVisualStyles = false;
            this.dtGridServer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGridServer.Location = new System.Drawing.Point(0, 0);
            this.dtGridServer.Name = "dtGridServer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridServer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridServer.Size = new System.Drawing.Size(670, 483);
            this.dtGridServer.TabIndex = 6;
            // 
            // btDeleteServer
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Xoá";
            this.btDeleteServer.DefaultCellStyle = dataGridViewCellStyle2;
            this.btDeleteServer.HeaderText = "";
            this.btDeleteServer.Name = "btDeleteServer";
            // 
            // UCServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSaveServer);
            this.Controls.Add(this.dtGridServer);
            this.Name = "UCServer";
            this.Size = new System.Drawing.Size(673, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btSaveServer;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridServer;
        private System.Windows.Forms.DataGridViewButtonColumn btDeleteServer;
    }
}
