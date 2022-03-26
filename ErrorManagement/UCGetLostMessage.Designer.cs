namespace ErrorManagement
{
    partial class UCGetLostMessage
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbTimes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btGetList = new DevComponents.DotNetBar.ButtonX();
            this.tbDcuName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtGetLost = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.GroupMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClean = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtGetLost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "DcuName";
            // 
            // tbTimes
            // 
            this.tbTimes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTimes.Border.Class = "TextBoxBorder";
            this.tbTimes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTimes.ForeColor = System.Drawing.Color.Black;
            this.tbTimes.Location = new System.Drawing.Point(360, 32);
            this.tbTimes.Name = "tbTimes";
            this.tbTimes.Size = new System.Drawing.Size(67, 20);
            this.tbTimes.TabIndex = 2;
            this.tbTimes.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(254, 30);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Timescheck(times)";
            // 
            // btGetList
            // 
            this.btGetList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btGetList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btGetList.Location = new System.Drawing.Point(454, 30);
            this.btGetList.Name = "btGetList";
            this.btGetList.Size = new System.Drawing.Size(75, 23);
            this.btGetList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btGetList.TabIndex = 4;
            this.btGetList.Text = "Get List";
            this.btGetList.Click += new System.EventHandler(this.btGetList_Click);
            // 
            // tbDcuName
            // 
            this.tbDcuName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbDcuName.Border.Class = "TextBoxBorder";
            this.tbDcuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDcuName.ForeColor = System.Drawing.Color.Black;
            this.tbDcuName.Location = new System.Drawing.Point(102, 32);
            this.tbDcuName.Name = "tbDcuName";
            this.tbDcuName.Size = new System.Drawing.Size(132, 20);
            this.tbDcuName.TabIndex = 5;
            // 
            // dtGetLost
            // 
            this.dtGetLost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGetLost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGetLost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupMp,
            this.DcuName,
            this.TimeLost,
            this.Status,
            this.MeterType,
            this.StatusMp});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGetLost.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGetLost.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtGetLost.Location = new System.Drawing.Point(3, 68);
            this.dtGetLost.Name = "dtGetLost";
            this.dtGetLost.Size = new System.Drawing.Size(990, 428);
            this.dtGetLost.TabIndex = 6;
            this.dtGetLost.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGetLost_RowPostPaint);
            // 
            // GroupMp
            // 
            this.GroupMp.HeaderText = "Điện Lực";
            this.GroupMp.Name = "GroupMp";
            this.GroupMp.Width = 150;
            // 
            // DcuName
            // 
            this.DcuName.HeaderText = "Dcu Code";
            this.DcuName.Name = "DcuName";
            this.DcuName.Width = 150;
            // 
            // TimeLost
            // 
            this.TimeLost.HeaderText = "Time Lost";
            this.TimeLost.Name = "TimeLost";
            this.TimeLost.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // MeterType
            // 
            this.MeterType.HeaderText = "MeterType";
            this.MeterType.Name = "MeterType";
            this.MeterType.Width = 150;
            // 
            // StatusMp
            // 
            this.StatusMp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusMp.HeaderText = "Trạng thái điểm đo";
            this.StatusMp.Name = "StatusMp";
            // 
            // btClean
            // 
            this.btClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClean.Location = new System.Drawing.Point(900, 502);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClean.TabIndex = 7;
            this.btClean.Text = "Clean";
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // UCGetLostMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.dtGetLost);
            this.Controls.Add(this.tbDcuName);
            this.Controls.Add(this.btGetList);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbTimes);
            this.Controls.Add(this.labelX1);
            this.Name = "UCGetLostMessage";
            this.Size = new System.Drawing.Size(996, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dtGetLost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTimes;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btGetList;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDcuName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGetLost;
        private DevComponents.DotNetBar.ButtonX btClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupMp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusMp;
    }
}
