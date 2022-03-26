namespace AmiOperationManagement.CustomeUserControl
{
    partial class UCProgressBarStop
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
            this.prgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // prgBar
            // 
            this.prgBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBar.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.prgBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgBar.Location = new System.Drawing.Point(3, 3);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(618, 34);
            this.prgBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.prgBar.TabIndex = 0;
            this.prgBar.Text = "Đang xử lý yêu cầu ...";
            this.prgBar.TextVisible = true;
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Location = new System.Drawing.Point(627, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnStop.Size = new System.Drawing.Size(62, 34);
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Dừng gửi";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // UCProgressBarStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnStop);
            this.Name = "UCProgressBarStop";
            this.Size = new System.Drawing.Size(691, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX prgBar;
        private DevComponents.DotNetBar.ButtonX btnStop;
    }
}
