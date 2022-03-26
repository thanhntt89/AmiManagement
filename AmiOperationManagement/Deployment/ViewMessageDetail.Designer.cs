namespace AmiOperationManagement.Deployment
{
    partial class ViewMessageDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMessageDetail));
            this.dtgMessage = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clMessageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReceiveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtCommandText = new System.Windows.Forms.RichTextBox();
            this.chkIsHex = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMessage
            // 
            this.dtgMessage.AllowUserToAddRows = false;
            this.dtgMessage.AllowUserToDeleteRows = false;
            this.dtgMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgMessage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMessageTime,
            this.clReceiveTime,
            this.IndexCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMessage.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMessage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgMessage.Location = new System.Drawing.Point(5, 23);
            this.dtgMessage.Name = "dtgMessage";
            this.dtgMessage.ReadOnly = true;
            this.dtgMessage.Size = new System.Drawing.Size(348, 440);
            this.dtgMessage.TabIndex = 0;
            this.dtgMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMessage_CellClick);
            // 
            // clMessageTime
            // 
            this.clMessageTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMessageTime.HeaderText = "Thời gian bản tin";
            this.clMessageTime.Name = "clMessageTime";
            this.clMessageTime.ReadOnly = true;
            // 
            // clReceiveTime
            // 
            this.clReceiveTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clReceiveTime.HeaderText = "Thời gian nhận";
            this.clReceiveTime.Name = "clReceiveTime";
            this.clReceiveTime.ReadOnly = true;
            // 
            // IndexCol
            // 
            this.IndexCol.HeaderText = "IndexCol";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            this.IndexCol.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(784, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Topic:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.White;
            this.lblTopic.ForeColor = System.Drawing.Color.Black;
            this.lblTopic.Location = new System.Drawing.Point(41, 7);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(16, 13);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "...";
            // 
            // txtCommandText
            // 
            this.txtCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandText.BackColor = System.Drawing.Color.Black;
            this.txtCommandText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCommandText.Location = new System.Drawing.Point(359, 23);
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.ReadOnly = true;
            this.txtCommandText.Size = new System.Drawing.Size(500, 411);
            this.txtCommandText.TabIndex = 1;
            this.txtCommandText.Text = "";
            // 
            // chkIsHex
            // 
            this.chkIsHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsHex.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkIsHex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsHex.Checked = true;
            this.chkIsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsHex.CheckValue = "Y";
            this.chkIsHex.ForeColor = System.Drawing.Color.Black;
            this.chkIsHex.Location = new System.Drawing.Point(357, 440);
            this.chkIsHex.Name = "chkIsHex";
            this.chkIsHex.Size = new System.Drawing.Size(421, 23);
            this.chkIsHex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsHex.TabIndex = 2;
            this.chkIsHex.Text = "Xem dạng HEX";
            // 
            // ViewMessageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.chkIsHex);
            this.Controls.Add(this.txtCommandText);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewMessageDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách bản tin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewMessageDetail_FormClosing);
            this.Load += new System.EventHandler(this.ViewDetailMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgMessage;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.RichTextBox txtCommandText;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMessageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReceiveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexCol;
    }
}