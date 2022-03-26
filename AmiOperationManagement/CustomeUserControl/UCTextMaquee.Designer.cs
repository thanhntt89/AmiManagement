namespace AmiOperationManagement.UserControlCustom
{
    partial class UCTextMaquee
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
            this.MarqueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MarqueLabel
            // 
            this.MarqueLabel.AutoSize = true;
            this.MarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarqueLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MarqueLabel.Location = new System.Drawing.Point(3, 12);
            this.MarqueLabel.Name = "MarqueLabel";
            this.MarqueLabel.Size = new System.Drawing.Size(963, 46);
            this.MarqueLabel.TabIndex = 0;
            this.MarqueLabel.Text = "Phần mềm quản lý vận hành hệ thống đo xa Sao Việt";
            // 
            // UCTextMaquee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.MarqueLabel);
            this.Name = "UCTextMaquee";
            this.Size = new System.Drawing.Size(726, 73);
            this.SizeChanged += new System.EventHandler(this.UCTextMaquee_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MarqueLabel;


    }
}
