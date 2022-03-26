namespace ErrorManagement
{
    partial class Solution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solution));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtErrorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDcu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtgStepList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ErrorIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixStepNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsUsedColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.ChooseColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.getFixErrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amiReportDataSet = new ErrorManagement.AmiReportDataSet();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtNotes = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.chkFixed = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnNextError = new DevComponents.DotNetBar.ButtonX();
            this.btnPreError = new DevComponents.DotNetBar.ButtonX();
            this.btnUp = new DevComponents.DotNetBar.ButtonX();
            this.btnDown = new DevComponents.DotNetBar.ButtonX();
            this.cboForwardTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btSendAction = new DevComponents.DotNetBar.ButtonX();
            this.btViewData = new DevComponents.DotNetBar.ButtonX();
            this.lbAction = new DevComponents.DotNetBar.LabelX();
            this.cbAction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itReset = new DevComponents.Editors.ComboItem();
            this.itUpdate = new DevComponents.Editors.ComboItem();
            this.itErase = new DevComponents.Editors.ComboItem();
            this.itInstan = new DevComponents.Editors.ComboItem();
            this.itOpe = new DevComponents.Editors.ComboItem();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.tbmessageview = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.btClean = new DevComponents.DotNetBar.ButtonX();
            this.lbEa = new DevComponents.DotNetBar.LabelX();
            this.lbEb = new DevComponents.DotNetBar.LabelX();
            this.tbEa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbEb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fixGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorListTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.ErrorListTableAdapter();
            this.fixErrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixGroupTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.FixGroupTableAdapter();
            this.fixErrorTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.FixErrorTableAdapter();
            this.getFixErrorTableAdapter = new ErrorManagement.AmiReportDataSetTableAdapters.GetFixErrorTableAdapter();
            this.lbConnectionDcu = new DevComponents.DotNetBar.LabelX();
            this.lbGatewayip = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStepList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFixErrorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixErrorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(2, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ErrorCode";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(2, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "DCU:";
            // 
            // txtErrorCode
            // 
            this.txtErrorCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtErrorCode.Border.Class = "TextBoxBorder";
            this.txtErrorCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtErrorCode.ForeColor = System.Drawing.Color.Black;
            this.txtErrorCode.Location = new System.Drawing.Point(58, 32);
            this.txtErrorCode.Name = "txtErrorCode";
            this.txtErrorCode.ReadOnly = true;
            this.txtErrorCode.Size = new System.Drawing.Size(51, 22);
            this.txtErrorCode.TabIndex = 12;
            // 
            // txtDcu
            // 
            this.txtDcu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDcu.Border.Class = "TextBoxBorder";
            this.txtDcu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDcu.ForeColor = System.Drawing.Color.Black;
            this.txtDcu.Location = new System.Drawing.Point(58, 2);
            this.txtDcu.Name = "txtDcu";
            this.txtDcu.ReadOnly = true;
            this.txtDcu.Size = new System.Drawing.Size(241, 22);
            this.txtDcu.TabIndex = 11;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(115, 32);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(16, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "-";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Location = new System.Drawing.Point(126, 37);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(13, 13);
            this.lblErrorName.TabIndex = 3;
            this.lblErrorName.Text = "..";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(2, 66);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Forward To:";
            // 
            // dtgStepList
            // 
            this.dtgStepList.AllowUserToAddRows = false;
            this.dtgStepList.AllowUserToDeleteRows = false;
            this.dtgStepList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStepList.AutoGenerateColumns = false;
            this.dtgStepList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgStepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStepList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorIdColumn,
            this.FixIndexColumn,
            this.FixStepIdColumn,
            this.FixStepNameColumn,
            this.IsUsedColumn,
            this.ChooseColumn});
            this.dtgStepList.DataSource = this.getFixErrorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgStepList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgStepList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgStepList.Location = new System.Drawing.Point(5, 104);
            this.dtgStepList.Name = "dtgStepList";
            this.dtgStepList.Size = new System.Drawing.Size(704, 296);
            this.dtgStepList.TabIndex = 1;
            this.dtgStepList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStepList_CellClick);
            this.dtgStepList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStepList_CellValueChanged);
            this.dtgStepList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgStepList_DataError);
            this.dtgStepList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgStepList_RowPostPaint);
            // 
            // ErrorIdColumn
            // 
            this.ErrorIdColumn.DataPropertyName = "ErrorId";
            this.ErrorIdColumn.HeaderText = "ErrorId";
            this.ErrorIdColumn.Name = "ErrorIdColumn";
            this.ErrorIdColumn.ReadOnly = true;
            // 
            // FixIndexColumn
            // 
            this.FixIndexColumn.DataPropertyName = "FixIndex";
            this.FixIndexColumn.HeaderText = "FixIndex";
            this.FixIndexColumn.Name = "FixIndexColumn";
            this.FixIndexColumn.ReadOnly = true;
            this.FixIndexColumn.Visible = false;
            // 
            // FixStepIdColumn
            // 
            this.FixStepIdColumn.DataPropertyName = "FixStepId";
            this.FixStepIdColumn.HeaderText = "FixStepId";
            this.FixStepIdColumn.Name = "FixStepIdColumn";
            this.FixStepIdColumn.ReadOnly = true;
            this.FixStepIdColumn.Visible = false;
            // 
            // FixStepNameColumn
            // 
            this.FixStepNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FixStepNameColumn.DataPropertyName = "FixStepName";
            this.FixStepNameColumn.HeaderText = "FixStepName";
            this.FixStepNameColumn.Name = "FixStepNameColumn";
            this.FixStepNameColumn.ReadOnly = true;
            // 
            // IsUsedColumn
            // 
            this.IsUsedColumn.Checked = true;
            this.IsUsedColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsUsedColumn.CheckValue = null;
            this.IsUsedColumn.DataPropertyName = "IsUsed";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsUsedColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.IsUsedColumn.HeaderText = "";
            this.IsUsedColumn.Name = "IsUsedColumn";
            this.IsUsedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsUsedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsUsedColumn.Width = 50;
            // 
            // ChooseColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Select";
            this.ChooseColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChooseColumn.HeaderText = "";
            this.ChooseColumn.Name = "ChooseColumn";
            this.ChooseColumn.Visible = false;
            this.ChooseColumn.Width = 75;
            // 
            // getFixErrorBindingSource
            // 
            this.getFixErrorBindingSource.DataMember = "GetFixError";
            this.getFixErrorBindingSource.DataSource = this.amiReportDataSet;
            // 
            // amiReportDataSet
            // 
            this.amiReportDataSet.DataSetName = "AmiReportDataSet";
            this.amiReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(5, 405);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(35, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNotes.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtNotes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNotes.Location = new System.Drawing.Point(5, 434);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(704, 119);
            this.txtNotes.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(552, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkFixed
            // 
            this.chkFixed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chkFixed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFixed.Location = new System.Drawing.Point(488, 559);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(60, 23);
            this.chkFixed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFixed.TabIndex = 7;
            this.chkFixed.Text = "Fixed";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(633, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNextError
            // 
            this.btnNextError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNextError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNextError.Location = new System.Drawing.Point(292, 559);
            this.btnNextError.Name = "btnNextError";
            this.btnNextError.Size = new System.Drawing.Size(75, 23);
            this.btnNextError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNextError.TabIndex = 6;
            this.btnNextError.Text = ">";
            this.btnNextError.Click += new System.EventHandler(this.btnNextError_Click);
            // 
            // btnPreError
            // 
            this.btnPreError.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPreError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreError.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPreError.Location = new System.Drawing.Point(211, 559);
            this.btnPreError.Name = "btnPreError";
            this.btnPreError.Size = new System.Drawing.Size(75, 23);
            this.btnPreError.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPreError.TabIndex = 5;
            this.btnPreError.Text = "<";
            this.btnPreError.Click += new System.EventHandler(this.btnPreError_Click);
            // 
            // btnUp
            // 
            this.btnUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUp.Location = new System.Drawing.Point(558, 406);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(69, 22);
            this.btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDown.Location = new System.Drawing.Point(640, 406);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(69, 22);
            this.btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cboForwardTo
            // 
            this.cboForwardTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboForwardTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboForwardTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboForwardTo.FormattingEnabled = true;
            this.cboForwardTo.ItemHeight = 16;
            this.cboForwardTo.Location = new System.Drawing.Point(64, 67);
            this.cboForwardTo.Name = "cboForwardTo";
            this.cboForwardTo.Size = new System.Drawing.Size(235, 22);
            this.cboForwardTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboForwardTo.TabIndex = 0;
            this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(12, 559);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(16, 13);
            this.lblCurrent.TabIndex = 11;
            this.lblCurrent.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "/";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(62, 559);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "...";
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAll.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(676, 106);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(18, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 14;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btSendAction
            // 
            this.btSendAction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSendAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendAction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSendAction.Location = new System.Drawing.Point(896, 27);
            this.btSendAction.Name = "btSendAction";
            this.btSendAction.Size = new System.Drawing.Size(42, 23);
            this.btSendAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSendAction.TabIndex = 16;
            this.btSendAction.Text = "Send";
            this.btSendAction.Click += new System.EventHandler(this.btSendAction_Click);
            // 
            // btViewData
            // 
            this.btViewData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btViewData.Location = new System.Drawing.Point(0, 0);
            this.btViewData.Name = "btViewData";
            this.btViewData.Size = new System.Drawing.Size(0, 0);
            this.btViewData.TabIndex = 28;
            // 
            // lbAction
            // 
            this.lbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbAction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbAction.Location = new System.Drawing.Point(735, 24);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(41, 23);
            this.lbAction.TabIndex = 18;
            this.lbAction.Text = "Action";
            // 
            // cbAction
            // 
            this.cbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAction.DisplayMember = "Text";
            this.cbAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.ItemHeight = 16;
            this.cbAction.Items.AddRange(new object[] {
            this.itReset,
            this.itUpdate,
            this.itErase,
            this.itInstan,
            this.itOpe});
            this.cbAction.Location = new System.Drawing.Point(803, 27);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(75, 22);
            this.cbAction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbAction.TabIndex = 20;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // itReset
            // 
            this.itReset.Text = "Reset";
            // 
            // itUpdate
            // 
            this.itUpdate.Text = "Update Firmware";
            // 
            // itErase
            // 
            this.itErase.Text = "Erase Flash";
            // 
            // itInstan
            // 
            this.itInstan.Text = "Instantaneous";
            // 
            // itOpe
            // 
            this.itOpe.Text = "Operation";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Column";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Column";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // tbmessageview
            // 
            this.tbmessageview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbmessageview.BackgroundStyle.Class = "RichTextBoxBorder";
            this.tbmessageview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbmessageview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmessageview.Location = new System.Drawing.Point(715, 104);
            this.tbmessageview.Name = "tbmessageview";
            this.tbmessageview.Size = new System.Drawing.Size(393, 449);
            this.tbmessageview.TabIndex = 21;
            // 
            // btClean
            // 
            this.btClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btClean.Location = new System.Drawing.Point(1033, 559);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btClean.TabIndex = 22;
            this.btClean.Text = "Clean";
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // lbEa
            // 
            this.lbEa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbEa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEa.Location = new System.Drawing.Point(967, 26);
            this.lbEa.Name = "lbEa";
            this.lbEa.Size = new System.Drawing.Size(20, 23);
            this.lbEa.TabIndex = 23;
            this.lbEa.Text = "EA";
            // 
            // lbEb
            // 
            this.lbEb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbEb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEb.Location = new System.Drawing.Point(967, 62);
            this.lbEb.Name = "lbEb";
            this.lbEb.Size = new System.Drawing.Size(22, 23);
            this.lbEb.TabIndex = 24;
            this.lbEb.Text = "EB";
            // 
            // tbEa
            // 
            this.tbEa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbEa.Border.Class = "TextBoxBorder";
            this.tbEa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEa.ForeColor = System.Drawing.Color.Black;
            this.tbEa.Location = new System.Drawing.Point(985, 26);
            this.tbEa.Name = "tbEa";
            this.tbEa.Size = new System.Drawing.Size(27, 22);
            this.tbEa.TabIndex = 25;
            // 
            // tbEb
            // 
            this.tbEb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEb.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbEb.Border.Class = "TextBoxBorder";
            this.tbEb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEb.ForeColor = System.Drawing.Color.Black;
            this.tbEb.Location = new System.Drawing.Point(985, 61);
            this.tbEb.Name = "tbEb";
            this.tbEb.Size = new System.Drawing.Size(27, 22);
            this.tbEb.TabIndex = 26;
            // 
            // fixGroupBindingSource
            // 
            this.fixGroupBindingSource.DataMember = "FixGroup";
            this.fixGroupBindingSource.DataSource = this.amiReportDataSet;
            // 
            // errorListTableAdapter
            // 
            this.errorListTableAdapter.ClearBeforeFill = true;
            // 
            // fixErrorBindingSource
            // 
            this.fixErrorBindingSource.DataMember = "FixError";
            this.fixErrorBindingSource.DataSource = this.amiReportDataSet;
            // 
            // fixGroupTableAdapter
            // 
            this.fixGroupTableAdapter.ClearBeforeFill = true;
            // 
            // fixErrorTableAdapter
            // 
            this.fixErrorTableAdapter.ClearBeforeFill = true;
            // 
            // getFixErrorTableAdapter
            // 
            this.getFixErrorTableAdapter.ClearBeforeFill = true;
            // 
            // lbConnectionDcu
            // 
            // 
            // 
            // 
            this.lbConnectionDcu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbConnectionDcu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionDcu.ForeColor = System.Drawing.Color.Red;
            this.lbConnectionDcu.Location = new System.Drawing.Point(614, 26);
            this.lbConnectionDcu.Name = "lbConnectionDcu";
            this.lbConnectionDcu.SingleLineColor = System.Drawing.Color.DarkGray;
            this.lbConnectionDcu.Size = new System.Drawing.Size(107, 23);
            this.lbConnectionDcu.TabIndex = 27;
            this.lbConnectionDcu.Text = "Mất kết nối";
            // 
            // lbGatewayip
            // 
            // 
            // 
            // 
            this.lbGatewayip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbGatewayip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGatewayip.Location = new System.Drawing.Point(614, 66);
            this.lbGatewayip.Name = "lbGatewayip";
            this.lbGatewayip.Size = new System.Drawing.Size(175, 23);
            this.lbGatewayip.TabIndex = 29;
            // 
            // Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 585);
            this.Controls.Add(this.lbGatewayip);
            this.Controls.Add(this.lbConnectionDcu);
            this.Controls.Add(this.tbEb);
            this.Controls.Add(this.tbEa);
            this.Controls.Add(this.lbEb);
            this.Controls.Add(this.lbEa);
            this.Controls.Add(this.tbmessageview);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.btViewData);
            this.Controls.Add(this.btSendAction);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.cboForwardTo);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnPreError);
            this.Controls.Add(this.btnNextError);
            this.Controls.Add(this.chkFixed);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtgStepList);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDcu);
            this.Controls.Add(this.txtErrorCode);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Solution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Solution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solution_FormClosing);
            this.Load += new System.EventHandler(this.Solution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStepList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFixErrorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amiReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixErrorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtErrorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDcu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Label lblErrorName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgStepList;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtNotes;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFixed;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnNextError;
        private DevComponents.DotNetBar.ButtonX btnPreError;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private AmiReportDataSet amiReportDataSet;
        private System.Windows.Forms.BindingSource fixGroupBindingSource;
        private AmiReportDataSetTableAdapters.FixGroupTableAdapter fixGroupTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboForwardTo;
        private System.Windows.Forms.BindingSource fixErrorBindingSource;
        private AmiReportDataSetTableAdapters.FixErrorTableAdapter fixErrorTableAdapter;
        private System.Windows.Forms.BindingSource getFixErrorBindingSource;
        private AmiReportDataSetTableAdapters.ErrorListTableAdapter errorListTableAdapter;
        private AmiReportDataSetTableAdapters.GetFixErrorTableAdapter getFixErrorTableAdapter;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixStepNameColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsUsedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ChooseColumn;
        private DevComponents.DotNetBar.ButtonX btSendAction;
        private DevComponents.DotNetBar.ButtonX btViewData;
        private DevComponents.DotNetBar.LabelX lbAction;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbAction;
        private DevComponents.Editors.ComboItem itReset;
        private DevComponents.Editors.ComboItem itUpdate;
        private DevComponents.Editors.ComboItem itErase;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx tbmessageview;
        private DevComponents.DotNetBar.ButtonX btClean;
        private DevComponents.Editors.ComboItem itInstan;
        private DevComponents.Editors.ComboItem itOpe;
        private DevComponents.DotNetBar.LabelX lbEa;
        private DevComponents.DotNetBar.LabelX lbEb;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEa;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEb;
        private DevComponents.DotNetBar.LabelX lbConnectionDcu;
        private DevComponents.DotNetBar.LabelX lbGatewayip;
    }
}