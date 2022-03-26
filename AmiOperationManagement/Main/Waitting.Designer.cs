namespace AmiOperationManagement.Main
{
    partial class Waitting
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
            this.components = new System.ComponentModel.Container();
            this.progress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.progress.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.progress.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.progress.BackgroundStyle.TextTrimming = DevComponents.DotNetBar.eStyleTextTrimming.None;
            this.progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress.Location = new System.Drawing.Point(0, 0);
            this.progress.Name = "progress";
            this.progress.PieBorderDark = System.Drawing.Color.Transparent;
            this.progress.PieBorderLight = System.Drawing.Color.Transparent;
            this.progress.ProgressColor = System.Drawing.Color.Navy;
            this.progress.Size = new System.Drawing.Size(87, 87);
            this.progress.SpokeBorderDark = System.Drawing.Color.Transparent;
            this.progress.SpokeBorderLight = System.Drawing.Color.Transparent;
            this.progress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progress.TabIndex = 0;
            this.progress.ValueChanged += new System.EventHandler(this.progress_ValueChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Waitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(87, 87);
            this.ControlBox = false;
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Waitting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waitting";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Waitting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress progress;
        private System.Windows.Forms.Timer timer;
    }
}