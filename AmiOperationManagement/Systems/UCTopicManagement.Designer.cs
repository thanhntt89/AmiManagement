namespace AmiOperationManagement.Systems
{
    partial class UCTopicManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTopicManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSaveTopic = new DevComponents.DotNetBar.ButtonX();
            this.dtGridTopicInfor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CommandNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObisDefine = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTopicInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // btSaveTopic
            // 
            this.btSaveTopic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSaveTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveTopic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSaveTopic.Image = ((System.Drawing.Image)(resources.GetObject("btSaveTopic.Image")));
            this.btSaveTopic.Location = new System.Drawing.Point(817, 375);
            this.btSaveTopic.Name = "btSaveTopic";
            this.btSaveTopic.Size = new System.Drawing.Size(85, 23);
            this.btSaveTopic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSaveTopic.TabIndex = 5;
            this.btSaveTopic.Text = "Lưu";
            this.btSaveTopic.Click += new System.EventHandler(this.btSaveTopic_Click);
            // 
            // dtGridTopicInfor
            // 
            this.dtGridTopicInfor.AllowUserToResizeRows = false;
            this.dtGridTopicInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridTopicInfor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridTopicInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridTopicInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTopicInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommandNameCol,
            this.TopicCol,
            this.NotesCol,
            this.CommandIdCol,
            this.CommandCodeCol,
            this.CommandTypeCol,
            this.StatusCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridTopicInfor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridTopicInfor.EnableHeadersVisualStyles = false;
            this.dtGridTopicInfor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGridTopicInfor.Location = new System.Drawing.Point(3, 3);
            this.dtGridTopicInfor.Name = "dtGridTopicInfor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridTopicInfor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridTopicInfor.Size = new System.Drawing.Size(899, 366);
            this.dtGridTopicInfor.TabIndex = 4;
            this.dtGridTopicInfor.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGridTopicInfor_RowPostPaint);
            // 
            // CommandNameCol
            // 
            this.CommandNameCol.DataPropertyName = "CommandName";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CommandNameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.CommandNameCol.HeaderText = "Tên chức năng";
            this.CommandNameCol.Name = "CommandNameCol";
            this.CommandNameCol.Width = 250;
            // 
            // TopicCol
            // 
            this.TopicCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TopicCol.DataPropertyName = "Topic";
            this.TopicCol.HeaderText = "Định dạng bản tin";
            this.TopicCol.Name = "TopicCol";
            // 
            // NotesCol
            // 
            this.NotesCol.DataPropertyName = "Notes";
            this.NotesCol.HeaderText = "Ghi chú";
            this.NotesCol.Name = "NotesCol";
            this.NotesCol.Width = 250;
            // 
            // CommandIdCol
            // 
            this.CommandIdCol.DataPropertyName = "CommandId";
            this.CommandIdCol.HeaderText = "CommandIdCol";
            this.CommandIdCol.Name = "CommandIdCol";
            this.CommandIdCol.Visible = false;
            // 
            // CommandCodeCol
            // 
            this.CommandCodeCol.DataPropertyName = "CommandCode";
            this.CommandCodeCol.HeaderText = "CommandCodeCol";
            this.CommandCodeCol.Name = "CommandCodeCol";
            this.CommandCodeCol.Visible = false;
            // 
            // CommandTypeCol
            // 
            this.CommandTypeCol.DataPropertyName = "CommandType";
            this.CommandTypeCol.HeaderText = "Loại bản tin";
            this.CommandTypeCol.Name = "CommandTypeCol";
            this.CommandTypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CommandTypeCol.Width = 120;
            // 
            // StatusCol
            // 
            this.StatusCol.DataPropertyName = "Status";
            this.StatusCol.HeaderText = "StatusCol";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.Visible = false;
            // 
            // btnObisDefine
            // 
            this.btnObisDefine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnObisDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObisDefine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnObisDefine.Image = ((System.Drawing.Image)(resources.GetObject("btnObisDefine.Image")));
            this.btnObisDefine.Location = new System.Drawing.Point(640, 375);
            this.btnObisDefine.Name = "btnObisDefine";
            this.btnObisDefine.Size = new System.Drawing.Size(171, 23);
            this.btnObisDefine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnObisDefine.TabIndex = 5;
            this.btnObisDefine.Text = "Định nghĩa OBIS cho bản tin";
            this.btnObisDefine.Click += new System.EventHandler(this.btnObisDefine_Click);
            // 
            // UCTopicManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnObisDefine);
            this.Controls.Add(this.btSaveTopic);
            this.Controls.Add(this.dtGridTopicInfor);
            this.Name = "UCTopicManagement";
            this.Size = new System.Drawing.Size(906, 404);
            this.Load += new System.EventHandler(this.UCTopicManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTopicInfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btSaveTopic;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGridTopicInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCol;
        private DevComponents.DotNetBar.ButtonX btnObisDefine;
    }
}
