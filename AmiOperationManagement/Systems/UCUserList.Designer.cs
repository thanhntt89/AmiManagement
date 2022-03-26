namespace AmiOperationManagement.Systems
{
    partial class UCUserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserList));
            this.dtgUsers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroupNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetPasswordCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.EditCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DeleteCol = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AllowUserToDeleteRows = false;
            this.dtgUsers.AllowUserToResizeRows = false;
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdCol,
            this.UserGroupNameCol,
            this.UserNameCol,
            this.FullNameCol,
            this.EmailCol,
            this.ActiveStatusCol,
            this.ResetPasswordCol,
            this.EditCol,
            this.DeleteCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgUsers.EnableHeadersVisualStyles = false;
            this.dtgUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgUsers.Location = new System.Drawing.Point(3, 16);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgUsers.Size = new System.Drawing.Size(887, 339);
            this.dtgUsers.TabIndex = 0;
            this.dtgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellClick);
            this.dtgUsers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgUsers_RowPostPaint);
            // 
            // UserIdCol
            // 
            this.UserIdCol.HeaderText = "Mã người dùng";
            this.UserIdCol.Name = "UserIdCol";
            this.UserIdCol.ReadOnly = true;
            this.UserIdCol.Visible = false;
            // 
            // UserGroupNameCol
            // 
            this.UserGroupNameCol.HeaderText = "Nhóm người dùng";
            this.UserGroupNameCol.Name = "UserGroupNameCol";
            this.UserGroupNameCol.ReadOnly = true;
            this.UserGroupNameCol.Width = 150;
            // 
            // UserNameCol
            // 
            this.UserNameCol.HeaderText = "Tài khoản";
            this.UserNameCol.Name = "UserNameCol";
            this.UserNameCol.ReadOnly = true;
            this.UserNameCol.Width = 150;
            // 
            // FullNameCol
            // 
            this.FullNameCol.HeaderText = "Họ tên người dùng";
            this.FullNameCol.Name = "FullNameCol";
            this.FullNameCol.ReadOnly = true;
            this.FullNameCol.Width = 250;
            // 
            // EmailCol
            // 
            this.EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.MinimumWidth = 150;
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // ActiveStatusCol
            // 
            this.ActiveStatusCol.HeaderText = "Trạng thái";
            this.ActiveStatusCol.Name = "ActiveStatusCol";
            this.ActiveStatusCol.ReadOnly = true;
            // 
            // ResetPasswordCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Tạo lại mật khẩu";
            this.ResetPasswordCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResetPasswordCol.HeaderText = "";
            this.ResetPasswordCol.Name = "ResetPasswordCol";
            this.ResetPasswordCol.ReadOnly = true;
            this.ResetPasswordCol.Text = null;
            this.ResetPasswordCol.Width = 120;
            // 
            // EditCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Sửa";
            this.EditCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditCol.HeaderText = "";
            this.EditCol.Name = "EditCol";
            this.EditCol.ReadOnly = true;
            this.EditCol.Text = null;
            this.EditCol.Width = 75;
            // 
            // DeleteCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Xoá";
            this.DeleteCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeleteCol.HeaderText = "";
            this.DeleteCol.Name = "DeleteCol";
            this.DeleteCol.ReadOnly = true;
            this.DeleteCol.Text = null;
            this.DeleteCol.Width = 75;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(811, 361);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(79, 23);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách người dùng trong hệ thống";
            // 
            // UCUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dtgUsers);
            this.Name = "UCUserList";
            this.Size = new System.Drawing.Size(893, 387);
            this.Load += new System.EventHandler(this.UCUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgUsers;
        private DevComponents.DotNetBar.ButtonX btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroupNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveStatusCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn ResetPasswordCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn EditCol;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DeleteCol;
    }
}
