namespace AmiOperationManagement.Systems
{
    partial class ObisDefine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObisDefine));
            this.cboCommandLine = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopics = new System.Windows.Forms.Label();
            this.dtgObis = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ObisCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsHexCol = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.NotesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObisIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObisIndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgObis)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCommandLine
            // 
            this.cboCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCommandLine.DisplayMember = "Text";
            this.cboCommandLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCommandLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommandLine.ForeColor = System.Drawing.Color.Black;
            this.cboCommandLine.FormattingEnabled = true;
            this.cboCommandLine.ItemHeight = 14;
            this.cboCommandLine.Location = new System.Drawing.Point(73, 12);
            this.cboCommandLine.Name = "cboCommandLine";
            this.cboCommandLine.Size = new System.Drawing.Size(566, 20);
            this.cboCommandLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCommandLine.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại bản tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topics";
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTopics.ForeColor = System.Drawing.Color.Black;
            this.lblTopics.Location = new System.Drawing.Point(70, 38);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(16, 13);
            this.lblTopics.TabIndex = 1;
            this.lblTopics.Text = "...";
            // 
            // dtgObis
            // 
            this.dtgObis.AllowUserToResizeRows = false;
            this.dtgObis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgObis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgObis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgObis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgObis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgObis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObisCodeCol,
            this.ValueCol,
            this.IsHexCol,
            this.NotesCol,
            this.ObisIdCol,
            this.CommandIdCol,
            this.ObisIndexCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgObis.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgObis.EnableHeadersVisualStyles = false;
            this.dtgObis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgObis.Location = new System.Drawing.Point(5, 59);
            this.dtgObis.MultiSelect = false;
            this.dtgObis.Name = "dtgObis";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgObis.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgObis.Size = new System.Drawing.Size(634, 323);
            this.dtgObis.TabIndex = 2;
            this.dtgObis.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgObis_RowPostPaint);
            // 
            // ObisCodeCol
            // 
            this.ObisCodeCol.DataPropertyName = "ObisCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ObisCodeCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ObisCodeCol.HeaderText = "OBIS(HEX)";
            this.ObisCodeCol.Name = "ObisCodeCol";
            this.ObisCodeCol.Width = 80;
            // 
            // ValueCol
            // 
            this.ValueCol.DataPropertyName = "Value";
            this.ValueCol.HeaderText = "Giá trị mặc định";
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.Width = 110;
            // 
            // IsHexCol
            // 
            this.IsHexCol.Checked = true;
            this.IsHexCol.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsHexCol.CheckValue = null;
            this.IsHexCol.DataPropertyName = "IsHex";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsHexCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.IsHexCol.HeaderText = "Giá trị HEX";
            this.IsHexCol.Name = "IsHexCol";
            this.IsHexCol.Width = 80;
            // 
            // NotesCol
            // 
            this.NotesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NotesCol.DataPropertyName = "Notes";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.NotesCol.HeaderText = "Ghi chú";
            this.NotesCol.Name = "NotesCol";
            // 
            // ObisIdCol
            // 
            this.ObisIdCol.DataPropertyName = "ObisId";
            this.ObisIdCol.HeaderText = "ObisIdCol";
            this.ObisIdCol.Name = "ObisIdCol";
            this.ObisIdCol.Visible = false;
            // 
            // CommandIdCol
            // 
            this.CommandIdCol.DataPropertyName = "CommandId";
            this.CommandIdCol.HeaderText = "CommandId";
            this.CommandIdCol.Name = "CommandIdCol";
            this.CommandIdCol.Visible = false;
            // 
            // ObisIndexCol
            // 
            this.ObisIndexCol.DataPropertyName = "ObisIndex";
            this.ObisIndexCol.HeaderText = "ObisIndex";
            this.ObisIndexCol.Name = "ObisIndexCol";
            this.ObisIndexCol.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(564, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(483, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ObisDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgObis);
            this.Controls.Add(this.lblTopics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCommandLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ObisDefine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa OBIS cho từng bản tin PUBLISH/SUBSCRIBE";
            this.Load += new System.EventHandler(this.ObisDefine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgObis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboCommandLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopics;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgObis;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObisCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsHexCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObisIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObisIndexCol;
    }
}