namespace CSSD.Client.UI.ManagerBench
{
    partial class FrmStation
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
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.comStationType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCan = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.txtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtSpellCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtStationName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.txtStationID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvStation = new System.Windows.Forms.DataGridView();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel5.SuspendLayout();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel5
            // 
            this.groupPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.labelX10);
            this.groupPanel5.Controls.Add(this.txtIP);
            this.groupPanel5.Controls.Add(this.labelX13);
            this.groupPanel5.Controls.Add(this.comStationType);
            this.groupPanel5.Controls.Add(this.btnAdd);
            this.groupPanel5.Controls.Add(this.btnCan);
            this.groupPanel5.Controls.Add(this.btnUpdate);
            this.groupPanel5.Controls.Add(this.btnSave);
            this.groupPanel5.Controls.Add(this.labelX14);
            this.groupPanel5.Controls.Add(this.txtDesc);
            this.groupPanel5.Controls.Add(this.labelX15);
            this.groupPanel5.Controls.Add(this.txtSpellCode);
            this.groupPanel5.Controls.Add(this.labelX16);
            this.groupPanel5.Controls.Add(this.txtStationName);
            this.groupPanel5.Controls.Add(this.labelX17);
            this.groupPanel5.Controls.Add(this.txtStationID);
            this.groupPanel5.Location = new System.Drawing.Point(522, 4);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(426, 475);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.Class = "";
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.Class = "";
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.Class = "";
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 7;
            this.groupPanel5.Text = "编辑";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(19, 199);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(132, 26);
            this.labelX10.TabIndex = 29;
            this.labelX10.Text = "IP地址：";
            // 
            // txtIP
            // 
            // 
            // 
            // 
            this.txtIP.Border.Class = "TextBoxBorder";
            this.txtIP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIP.Enabled = false;
            this.txtIP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(157, 199);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(239, 26);
            this.txtIP.TabIndex = 28;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.Class = "";
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX13.Location = new System.Drawing.Point(19, 64);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(111, 26);
            this.labelX13.TabIndex = 27;
            this.labelX13.Text = "工作台类型：";
            // 
            // comStationType
            // 
            this.comStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStationType.Enabled = false;
            this.comStationType.Font = new System.Drawing.Font("宋体", 12F);
            this.comStationType.FormattingEnabled = true;
            this.comStationType.Location = new System.Drawing.Point(157, 64);
            this.comStationType.Name = "comStationType";
            this.comStationType.Size = new System.Drawing.Size(239, 24);
            this.comStationType.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(12, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新 增(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCan
            // 
            this.btnCan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCan.Enabled = false;
            this.btnCan.Location = new System.Drawing.Point(308, 404);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(88, 35);
            this.btnCan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCan.TabIndex = 10;
            this.btnCan.Text = "取 消(&C)";
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(112, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修 改(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(211, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保 存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX14.Location = new System.Drawing.Point(19, 259);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(111, 26);
            this.labelX14.TabIndex = 7;
            this.labelX14.Text = "机器描述";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.Border.Class = "TextBoxBorder";
            this.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesc.Location = new System.Drawing.Point(157, 259);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(239, 126);
            this.txtDesc.TabIndex = 6;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX15.Location = new System.Drawing.Point(19, 157);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(111, 26);
            this.labelX15.TabIndex = 5;
            this.labelX15.Text = "助记码：";
            // 
            // txtSpellCode
            // 
            // 
            // 
            // 
            this.txtSpellCode.Border.Class = "TextBoxBorder";
            this.txtSpellCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSpellCode.Enabled = false;
            this.txtSpellCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSpellCode.Location = new System.Drawing.Point(157, 157);
            this.txtSpellCode.Name = "txtSpellCode";
            this.txtSpellCode.Size = new System.Drawing.Size(239, 26);
            this.txtSpellCode.TabIndex = 4;
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX16.Location = new System.Drawing.Point(18, 112);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(111, 26);
            this.labelX16.TabIndex = 3;
            this.labelX16.Text = "工作台名称:";
            // 
            // txtStationName
            // 
            // 
            // 
            // 
            this.txtStationName.Border.Class = "TextBoxBorder";
            this.txtStationName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStationName.Enabled = false;
            this.txtStationName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStationName.Location = new System.Drawing.Point(157, 112);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(239, 26);
            this.txtStationName.TabIndex = 2;
            this.txtStationName.TextChanged += new System.EventHandler(this.txtStationName_TextChanged);
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX17.Location = new System.Drawing.Point(19, 18);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(111, 26);
            this.labelX17.TabIndex = 1;
            this.labelX17.Text = "工作台编码：";
            // 
            // txtStationID
            // 
            // 
            // 
            // 
            this.txtStationID.Border.Class = "TextBoxBorder";
            this.txtStationID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStationID.Enabled = false;
            this.txtStationID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStationID.Location = new System.Drawing.Point(157, 18);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(239, 26);
            this.txtStationID.TabIndex = 0;
            // 
            // groupPanel6
            // 
            this.groupPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel6.Controls.Add(this.dgvStation);
            this.groupPanel6.Location = new System.Drawing.Point(12, 4);
            this.groupPanel6.Name = "groupPanel6";
            this.groupPanel6.Size = new System.Drawing.Size(504, 475);
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.Class = "";
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseDown.Class = "";
            this.groupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseOver.Class = "";
            this.groupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel6.TabIndex = 6;
            this.groupPanel6.Text = "详细信息";
            // 
            // dgvStation
            // 
            this.dgvStation.AllowUserToAddRows = false;
            this.dgvStation.AllowUserToResizeRows = false;
            this.dgvStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationID,
            this.StationName,
            this.StationGroupID,
            this.LogonID,
            this.IPAddress,
            this.PrinterID,
            this.AccountCode,
            this.SpellCode,
            this.StationGroupName,
            this.StationDesc});
            this.dgvStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStation.Location = new System.Drawing.Point(0, 0);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.ReadOnly = true;
            this.dgvStation.RowHeadersVisible = false;
            this.dgvStation.RowTemplate.Height = 23;
            this.dgvStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStation.Size = new System.Drawing.Size(498, 451);
            this.dgvStation.TabIndex = 0;
            this.dgvStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStation_CellClick);
            this.dgvStation.SelectionChanged += new System.EventHandler(this.dgvStation_SelectionChanged);
            // 
            // StationID
            // 
            this.StationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StationID.DataPropertyName = "StationID";
            this.StationID.HeaderText = "工作台编码";
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            this.StationID.Visible = false;
            this.StationID.Width = 71;
            // 
            // StationName
            // 
            this.StationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationName.DataPropertyName = "StationName";
            this.StationName.HeaderText = "工作台名称";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // StationGroupID
            // 
            this.StationGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationGroupID.DataPropertyName = "StationGroupID";
            this.StationGroupID.HeaderText = "工作组ID";
            this.StationGroupID.Name = "StationGroupID";
            this.StationGroupID.ReadOnly = true;
            this.StationGroupID.Visible = false;
            // 
            // LogonID
            // 
            this.LogonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LogonID.DataPropertyName = "LogonID";
            this.LogonID.HeaderText = "当前登录人";
            this.LogonID.Name = "LogonID";
            this.LogonID.ReadOnly = true;
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IPAddress.DataPropertyName = "IPAddress";
            this.IPAddress.HeaderText = "IP地址";
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.ReadOnly = true;
            // 
            // PrinterID
            // 
            this.PrinterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrinterID.DataPropertyName = "PrinterID";
            this.PrinterID.HeaderText = "打印机编码";
            this.PrinterID.Name = "PrinterID";
            this.PrinterID.ReadOnly = true;
            this.PrinterID.Visible = false;
            // 
            // AccountCode
            // 
            this.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "账套";
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.ReadOnly = true;
            this.AccountCode.Visible = false;
            // 
            // SpellCode
            // 
            this.SpellCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpellCode.DataPropertyName = "SpellCode";
            this.SpellCode.HeaderText = "助记码";
            this.SpellCode.Name = "SpellCode";
            this.SpellCode.ReadOnly = true;
            // 
            // StationGroupName
            // 
            this.StationGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationGroupName.DataPropertyName = "StationGroupName";
            this.StationGroupName.HeaderText = "工作组";
            this.StationGroupName.Name = "StationGroupName";
            this.StationGroupName.ReadOnly = true;
            // 
            // StationDesc
            // 
            this.StationDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationDesc.DataPropertyName = "StationDesc";
            this.StationDesc.HeaderText = "描述";
            this.StationDesc.Name = "StationDesc";
            this.StationDesc.ReadOnly = true;
            // 
            // FrmStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(960, 491);
            this.Controls.Add(this.groupPanel5);
            this.Controls.Add(this.groupPanel6);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmStation";
            this.Text = "工作台管理";
            this.Load += new System.EventHandler(this.FrmStation_Load);
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIP;
        private DevComponents.DotNetBar.LabelX labelX13;
        private System.Windows.Forms.ComboBox comStationType;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCan;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDesc;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSpellCode;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStationName;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStationID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private System.Windows.Forms.DataGridView dgvStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationDesc;
    }
}