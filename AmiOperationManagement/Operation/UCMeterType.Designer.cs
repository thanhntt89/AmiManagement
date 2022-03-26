namespace AmiOperationManagement.ErrorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMeterType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateNew = new DevComponents.DotNetBar.ButtonX();
            this.dtgMeterType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clDeleteMeterType = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeterType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNew.Image")));
            this.btnCreateNew.Location = new System.Drawing.Point(550, 312);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateNew.TabIndex = 3;
            this.btnCreateNew.Text = "Tạo mới";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // dtgMeterType
            // 
            this.dtgMeterType.AllowUserToAddRows = false;
            this.dtgMeterType.AllowUserToDeleteRows = false;
            this.dtgMeterType.AllowUserToResizeRows = false;
            this.dtgMeterType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMeterType.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMeterType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMeterType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMeterType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIndex,
            this.clMeterId,
            this.clSymbol,
            this.clMeterType,
            this.clEdit,
            this.clDeleteMeterType});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMeterType.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgMeterType.EnableHeadersVisualStyles = false;
            this.dtgMeterType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgMeterType.Location = new System.Drawing.Point(0, 3);
            this.dtgMeterType.Name = "dtgMeterType";
            this.dtgMeterType.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMeterType.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgMeterType.RowHeadersVisible = false;
            this.dtgMeterType.Size = new System.Drawing.Size(625, 303);
            this.dtgMeterType.TabIndex = 2;
            this.dtgMeterType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMeterType_CellClick);
            // 
            // clIndex
            // 
            this.clIndex.HeaderText = "STT";
            this.clIndex.Name = "clIndex";
            this.clIndex.ReadOnly = true;
            this.clIndex.Width = 40;
            // 
            // clMeterId
            // 
            this.clMeterId.HeaderText = "Mã loại công tơ";
            this.clMeterId.Name = "clMeterId";
            this.clMeterId.ReadOnly = true;
            this.clMeterId.Visible = false;
            this.clMeterId.Width = 150;
            // 
            // clSymbol
            // 
            this.clSymbol.HeaderText = "Ký hiệu";
            this.clSymbol.Name = "clSymbol";
            this.clSymbol.ReadOnly = true;
            // 
            // clMeterType
            // 
            this.clMeterType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMeterType.HeaderText = "Tên loại công tơ";
            this.clMeterType.Name = "clMeterType";
            this.clMeterType.ReadOnly = true;
            // 
            // clEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Sửa";
            this.clEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clEdit.HeaderText = "";
            this.clEdit.Name = "clEdit";
            this.clEdit.ReadOnly = true;
            this.clEdit.Text = null;
            this.clEdit.Width = 75;
            // 
            // clDeleteMeterType
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Xoá";
            this.clDeleteMeterType.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDeleteMeterType.HeaderText = "";
            this.clDeleteMeterType.Name = "clDeleteMeterType";
            this.clDeleteMeterType.ReadOnly = true;
            this.clDeleteMeterType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDeleteMeterType.Text = null;
            this.clDeleteMeterType.Width = 75;
            // 
            // UCMeterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.dtgMeterType);
            this.Name = "UCMeterType";
            this.Size = new System.Drawing.Size(629, 343);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeterType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCreateNew;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgMeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMeterType;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clDeleteMeterType;
    }
}
