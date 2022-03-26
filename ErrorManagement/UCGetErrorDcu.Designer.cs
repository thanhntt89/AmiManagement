namespace ErrorManagement
{
    partial class UCGetErrorDcu
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
            this.dtErrorDcuFlash = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btCleanUC = new DevComponents.DotNetBar.ButtonX();
            this.tbSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.lbSearch = new DevComponents.DotNetBar.LabelX();
            this.clDcuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFlashFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWarningError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clComparebyte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReset = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btErase = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btUpdate = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorDcuFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // dtErrorDcuFlash
            // 
            this.dtErrorDcuFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtErrorDcuFlash.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtErrorDcuFlash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtErrorDcuFlash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtErrorDcuFlash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDcuCode,
            this.clmtType,
            this.clFlashFail,
            this.clWarningError,
            this.clComparebyte,
            this.Pendding,
            this.btReset,
            this.btErase,
            this.btUpdate});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtErrorDcuFlash.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtErrorDcuFlash.EnableHeadersVisualStyles = false;
            this.dtErrorDcuFlash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtErrorDcuFlash.Location = new System.Drawing.Point(3, 67);
            this.dtErrorDcuFlash.Name = "dtErrorDcuFlash";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtErrorDcuFlash.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtErrorDcuFlash.Size = new System.Drawing.Size(1002, 428);
            this.dtErrorDcuFlash.TabIndex = 0;
            this.dtErrorDcuFlash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtErrorDcuFlash_CellClick);
            this.dtErrorDcuFlash.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtErrorDcuFlash_RowPostPaint);
            // 
            // btCleanUC
            // 
            this.btCleanUC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btCleanUC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCleanUC.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btCleanUC.Location = new System.Drawing.Point(900, 516);
            this.btCleanUC.Name = "btCleanUC";
            this.btCleanUC.Size = new System.Drawing.Size(75, 23);
            this.btCleanUC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btCleanUC.TabIndex = 1;
            this.btCleanUC.Text = "Clean";
            this.btCleanUC.Click += new System.EventHandler(this.btCleanUC_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbSearch.Border.Class = "TextBoxBorder";
            this.tbSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(121, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Location = new System.Drawing.Point(276, 30);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 20);
            this.btSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbSearch
            // 
            // 
            // 
            // 
            this.lbSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSearch.Location = new System.Drawing.Point(40, 30);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(75, 23);
            this.lbSearch.TabIndex = 4;
            this.lbSearch.Text = "Tìm mã DCU";
            // 
            // clDcuCode
            // 
            this.clDcuCode.FillWeight = 92.02082F;
            this.clDcuCode.HeaderText = "DcuCode";
            this.clDcuCode.Name = "clDcuCode";
            this.clDcuCode.Width = 150;
            // 
            // clmtType
            // 
            this.clmtType.FillWeight = 1.749773F;
            this.clmtType.HeaderText = "Meter Type";
            this.clmtType.Name = "clmtType";
            // 
            // clFlashFail
            // 
            this.clFlashFail.FillWeight = 14.65858F;
            this.clFlashFail.HeaderText = "FlashFail";
            this.clFlashFail.Name = "clFlashFail";
            // 
            // clWarningError
            // 
            this.clWarningError.FillWeight = 10.86017F;
            this.clWarningError.HeaderText = "WarningError";
            this.clWarningError.Name = "clWarningError";
            this.clWarningError.Width = 150;
            // 
            // clComparebyte
            // 
            this.clComparebyte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clComparebyte.FillWeight = 150F;
            this.clComparebyte.HeaderText = "Lỗi so sánh 2 byte( 3 và 4)";
            this.clComparebyte.Name = "clComparebyte";
            // 
            // Pendding
            // 
            this.Pendding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pendding.FillWeight = 150F;
            this.Pendding.HeaderText = "Lỗi Pendding";
            this.Pendding.Name = "Pendding";
            // 
            // btReset
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Reset";
            this.btReset.DefaultCellStyle = dataGridViewCellStyle2;
            this.btReset.HeaderText = "Reset";
            this.btReset.Name = "btReset";
            this.btReset.Text = "Reset";
            this.btReset.Width = 45;
            // 
            // btErase
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Erase";
            this.btErase.DefaultCellStyle = dataGridViewCellStyle3;
            this.btErase.HeaderText = "Erase";
            this.btErase.Name = "btErase";
            this.btErase.Text = null;
            this.btErase.Width = 45;
            // 
            // btUpdate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Update Firm";
            this.btUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.btUpdate.HeaderText = "Update Firm";
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Text = null;
            this.btUpdate.Width = 70;
            // 
            // UCGetErrorDcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btCleanUC);
            this.Controls.Add(this.dtErrorDcuFlash);
            this.Name = "UCGetErrorDcu";
            this.Size = new System.Drawing.Size(1008, 542);
            ((System.ComponentModel.ISupportInitialize)(this.dtErrorDcuFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtErrorDcuFlash;
        private DevComponents.DotNetBar.ButtonX btCleanUC;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSearch;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.LabelX lbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDcuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFlashFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWarningError;
        private System.Windows.Forms.DataGridViewTextBoxColumn clComparebyte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendding;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btReset;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btErase;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btUpdate;
    }
}
