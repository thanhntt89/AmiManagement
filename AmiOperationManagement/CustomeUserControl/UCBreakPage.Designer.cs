namespace AmiOperationManagement.CustomeUserControl  
{
    partial class UCBreakPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNumRowPerPage = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.All = new DevComponents.Editors.ComboItem();
            this.Ten = new DevComponents.Editors.ComboItem();
            this.Twenty = new DevComponents.Editors.ComboItem();
            this.Forty = new DevComponents.Editors.ComboItem();
            this.Fifty = new DevComponents.Editors.ComboItem();
            this.Hundereds = new DevComponents.Editors.ComboItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboPages = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.btnFirst = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboNumRowPerPage);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.cboPages);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 32);
            this.panel1.TabIndex = 0;
            // 
            // cboNumRowPerPage
            // 
            this.cboNumRowPerPage.DisplayMember = "Text";
            this.cboNumRowPerPage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNumRowPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumRowPerPage.FormattingEnabled = true;
            this.cboNumRowPerPage.ItemHeight = 14;
            this.cboNumRowPerPage.Items.AddRange(new object[] {
            this.All,
            this.Ten,
            this.Twenty,
            this.Forty,
            this.Fifty,
            this.Hundereds});
            this.cboNumRowPerPage.Location = new System.Drawing.Point(157, 4);
            this.cboNumRowPerPage.Name = "cboNumRowPerPage";
            this.cboNumRowPerPage.Size = new System.Drawing.Size(57, 20);
            this.cboNumRowPerPage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNumRowPerPage.TabIndex = 0;
            this.cboNumRowPerPage.SelectionChangeCommitted += new System.EventHandler(this.cboNumRowPerPage_SelectionChangeCommitted);
            // 
            // All
            // 
            this.All.Text = "Tất cả";
            // 
            // Ten
            // 
            this.Ten.Text = "10";
            // 
            // Twenty
            // 
            this.Twenty.Text = "20";
            // 
            // Forty
            // 
            this.Forty.Text = "40";
            // 
            // Fifty
            // 
            this.Fifty.Text = "50";
            // 
            // Hundereds
            // 
            this.Hundereds.Text = "100";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(65, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "...";
            // 
            // cboPages
            // 
            this.cboPages.DisplayMember = "Text";
            this.cboPages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPages.FormattingEnabled = true;
            this.cboPages.ItemHeight = 14;
            this.cboPages.Location = new System.Drawing.Point(384, 4);
            this.cboPages.Name = "cboPages";
            this.cboPages.Size = new System.Drawing.Size(78, 20);
            this.cboPages.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPages.TabIndex = 3;
            this.cboPages.SelectedIndexChanged += new System.EventHandler(this.cboPages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số bản ghi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số hàng:";
            // 
            // btnLast
            // 
            this.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLast.Location = new System.Drawing.Point(552, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>|";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.Location = new System.Drawing.Point(468, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">|";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPre.Location = new System.Drawing.Point(303, 3);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "|<";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFirst.Location = new System.Drawing.Point(219, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // UCBreakPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCBreakPage";
            this.Size = new System.Drawing.Size(648, 35);
            this.SizeChanged += new System.EventHandler(this.UCBreakPage_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private DevComponents.DotNetBar.ButtonX btnFirst;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNumRowPerPage;
        private DevComponents.Editors.ComboItem All;
        private DevComponents.Editors.ComboItem Ten;
        private DevComponents.Editors.ComboItem Twenty;
        private DevComponents.Editors.ComboItem Forty;
        private DevComponents.Editors.ComboItem Fifty;
        private DevComponents.Editors.ComboItem Hundereds;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPages;
        private System.Windows.Forms.Label label2;

    }
}
