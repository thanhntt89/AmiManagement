namespace ErrorManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel4 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel3 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.mnFile = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.mnErrorDefine = new DevComponents.DotNetBar.ButtonItem();
            this.mnFixbugeErrorStep = new DevComponents.DotNetBar.ButtonItem();
            this.mnError = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.mnRerpoting = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.ErrorDCU = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.LostMessage = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.metroShell1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Controls.Add(this.metroTabPanel3);
            this.metroShell1.Controls.Add(this.metroTabPanel4);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnFile,
            this.mnError,
            this.mnRerpoting,
            this.ErrorDCU,
            this.LostMessage});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.Size = new System.Drawing.Size(818, 52);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 0;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // metroTabPanel4
            // 
            this.metroTabPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel4.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel4.Name = "metroTabPanel4";
            this.metroTabPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel4.Size = new System.Drawing.Size(818, 1);
            // 
            // 
            // 
            this.metroTabPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel4.TabIndex = 4;
            this.metroTabPanel4.Visible = false;
            // 
            // metroTabPanel3
            // 
            this.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel3.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel3.Name = "metroTabPanel3";
            this.metroTabPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel3.Size = new System.Drawing.Size(818, 1);
            // 
            // 
            // 
            this.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel3.TabIndex = 3;
            this.metroTabPanel3.Visible = false;
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(818, 1);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(818, 1);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // mnFile
            // 
            this.mnFile.AutoExpandOnClick = true;
            this.mnFile.CanCustomize = false;
            this.mnFile.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.mnFile.ImagePaddingHorizontal = 0;
            this.mnFile.ImagePaddingVertical = 0;
            this.mnFile.Name = "mnFile";
            this.mnFile.ShowSubItems = false;
            this.mnFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnErrorDefine,
            this.mnFixbugeErrorStep});
            this.mnFile.Text = "&System";
            // 
            // mnErrorDefine
            // 
            this.mnErrorDefine.Name = "mnErrorDefine";
            this.mnErrorDefine.Text = "Error define";
            this.mnErrorDefine.Click += new System.EventHandler(this.mnErrorDefine_Click);
            // 
            // mnFixbugeErrorStep
            // 
            this.mnFixbugeErrorStep.Name = "mnFixbugeErrorStep";
            this.mnFixbugeErrorStep.Text = "FixBuge Error step";
            this.mnFixbugeErrorStep.Click += new System.EventHandler(this.mnFixbugeErrorStep_Click);
            // 
            // mnError
            // 
            this.mnError.Checked = true;
            this.mnError.Name = "mnError";
            this.mnError.Panel = this.metroTabPanel1;
            this.mnError.Text = "&ERROR";
            this.mnError.Click += new System.EventHandler(this.mnError_Click);
            // 
            // mnRerpoting
            // 
            this.mnRerpoting.Name = "mnRerpoting";
            this.mnRerpoting.Panel = this.metroTabPanel2;
            this.mnRerpoting.Text = "&REPORTING";
            this.mnRerpoting.Click += new System.EventHandler(this.mnRerpoting_Click);
            // 
            // ErrorDCU
            // 
            this.ErrorDCU.Name = "ErrorDCU";
            this.ErrorDCU.Panel = this.metroTabPanel3;
            this.ErrorDCU.Text = "ErrorDCU";
            this.ErrorDCU.Click += new System.EventHandler(this.ErrorDCU_Click);
            // 
            // LostMessage
            // 
            this.LostMessage.Name = "LostMessage";
            this.LostMessage.Panel = this.metroTabPanel4;
            this.LostMessage.Text = "Lost Message";
            this.LostMessage.Click += new System.EventHandler(this.LostMessage_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 415);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(818, 21);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "READY";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(1, 53);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(818, 362);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 437);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroShell1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroAppButton mnFile;
        private DevComponents.DotNetBar.Metro.MetroTabItem mnError;
        private DevComponents.DotNetBar.Metro.MetroTabItem mnRerpoting;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonItem mnErrorDefine;
        private DevComponents.DotNetBar.ButtonItem mnFixbugeErrorStep;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel3;
        private DevComponents.DotNetBar.Metro.MetroTabItem ErrorDCU;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel4;
        private DevComponents.DotNetBar.Metro.MetroTabItem LostMessage;

    }
}

