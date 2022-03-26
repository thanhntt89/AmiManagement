namespace AmiOperationManagement.CustomeUserControl
{
    partial class UCStartPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStartPanel));
            this.lblInfo = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.ucTextMaquee1 = new AmiOperationManagement.UserControlCustom.UCTextMaquee();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.lblInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1015, 98);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "<b><font size=\"+6\"><i><font color=\"HotTrack\">Phần mềm quản lý </font></i><font co" +
    "lor=\"#B02B2C\">& vận hành hệ thống đo xa SAO VIỆT</font></font></b>";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(0, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(1015, 515);
            this.reflectionImage1.TabIndex = 0;
            // 
            // ucTextMaquee1
            // 
            this.ucTextMaquee1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTextMaquee1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTextMaquee1.Location = new System.Drawing.Point(0, 0);
            this.ucTextMaquee1.Name = "ucTextMaquee1";
            this.ucTextMaquee1.Size = new System.Drawing.Size(1015, 72);
            this.ucTextMaquee1.TabIndex = 2;
            this.ucTextMaquee1.TextMarquee = null;
            // 
            // UCStartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTextMaquee1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.reflectionImage1);
            this.Name = "UCStartPanel";
            this.Size = new System.Drawing.Size(1015, 515);
            this.Load += new System.EventHandler(this.UCStartPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblInfo;
        private UserControlCustom.UCTextMaquee ucTextMaquee1;
    }
}
