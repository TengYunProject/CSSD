namespace CSSD.Client.UI.ManagerBench
{
    partial class FrmEquipment
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmMainType = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMachineCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.comMachineType = new System.Windows.Forms.ComboBox();
            this.btnMainAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnMainCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnMainUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnMainSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMachineDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMachineSpellCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMachineName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMachineID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.MachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineIDGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineOriginallyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineIDGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主设备维护 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 568);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.主设备维护);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.groupPanel2);
            this.tabControlPanel1.Controls.Add(this.groupPanel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1014, 542);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.主设备维护;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.cmMainType);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.txtMachineCode);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.comMachineType);
            this.groupPanel2.Controls.Add(this.btnMainAdd);
            this.groupPanel2.Controls.Add(this.btnMainCancel);
            this.groupPanel2.Controls.Add(this.btnMainUpdate);
            this.groupPanel2.Controls.Add(this.btnMainSave);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtMachineDesc);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtMachineSpellCode);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtMachineName);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtMachineID);
            this.groupPanel2.Location = new System.Drawing.Point(619, 5);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(395, 514);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "编辑";
            // 
            // cmMainType
            // 
            this.cmMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmMainType.Enabled = false;
            this.cmMainType.Font = new System.Drawing.Font("宋体", 12F);
            this.cmMainType.FormattingEnabled = true;
            this.cmMainType.Location = new System.Drawing.Point(142, 245);
            this.cmMainType.Name = "cmMainType";
            this.cmMainType.Size = new System.Drawing.Size(239, 24);
            this.cmMainType.TabIndex = 31;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(3, 245);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(111, 26);
            this.labelX6.TabIndex = 30;
            this.labelX6.Text = "状态类型:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(4, 200);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(132, 26);
            this.labelX5.TabIndex = 29;
            this.labelX5.Text = "实际机器编号：";
            // 
            // txtMachineCode
            // 
            // 
            // 
            // 
            this.txtMachineCode.Border.Class = "TextBoxBorder";
            this.txtMachineCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMachineCode.Enabled = false;
            this.txtMachineCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineCode.Location = new System.Drawing.Point(142, 200);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Size = new System.Drawing.Size(239, 26);
            this.txtMachineCode.TabIndex = 28;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(4, 65);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(111, 26);
            this.labelX9.TabIndex = 27;
            this.labelX9.Text = "机器类型：";
            // 
            // comMachineType
            // 
            this.comMachineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMachineType.Enabled = false;
            this.comMachineType.Font = new System.Drawing.Font("宋体", 12F);
            this.comMachineType.FormattingEnabled = true;
            this.comMachineType.Location = new System.Drawing.Point(142, 65);
            this.comMachineType.Name = "comMachineType";
            this.comMachineType.Size = new System.Drawing.Size(239, 24);
            this.comMachineType.TabIndex = 26;
            // 
            // btnMainAdd
            // 
            this.btnMainAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMainAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMainAdd.Location = new System.Drawing.Point(1, 447);
            this.btnMainAdd.Name = "btnMainAdd";
            this.btnMainAdd.Size = new System.Drawing.Size(88, 35);
            this.btnMainAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMainAdd.TabIndex = 11;
            this.btnMainAdd.Text = "新 增(&A)";
            this.btnMainAdd.Click += new System.EventHandler(this.btnMainAdd_Click);
            // 
            // btnMainCancel
            // 
            this.btnMainCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMainCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMainCancel.Enabled = false;
            this.btnMainCancel.Location = new System.Drawing.Point(297, 447);
            this.btnMainCancel.Name = "btnMainCancel";
            this.btnMainCancel.Size = new System.Drawing.Size(88, 35);
            this.btnMainCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMainCancel.TabIndex = 10;
            this.btnMainCancel.Text = "取 消(&C)";
            this.btnMainCancel.Click += new System.EventHandler(this.btnMainCancel_Click);
            // 
            // btnMainUpdate
            // 
            this.btnMainUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMainUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMainUpdate.Enabled = false;
            this.btnMainUpdate.Location = new System.Drawing.Point(101, 447);
            this.btnMainUpdate.Name = "btnMainUpdate";
            this.btnMainUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnMainUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMainUpdate.TabIndex = 9;
            this.btnMainUpdate.Text = "修 改(&U)";
            this.btnMainUpdate.Click += new System.EventHandler(this.btnMainUpdate_Click);
            // 
            // btnMainSave
            // 
            this.btnMainSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMainSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMainSave.Enabled = false;
            this.btnMainSave.Location = new System.Drawing.Point(200, 447);
            this.btnMainSave.Name = "btnMainSave";
            this.btnMainSave.Size = new System.Drawing.Size(88, 35);
            this.btnMainSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMainSave.TabIndex = 8;
            this.btnMainSave.Text = "保 存(&S)";
            this.btnMainSave.Click += new System.EventHandler(this.btnMainSave_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(4, 291);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(111, 26);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "机器描述";
            // 
            // txtMachineDesc
            // 
            // 
            // 
            // 
            this.txtMachineDesc.Border.Class = "TextBoxBorder";
            this.txtMachineDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMachineDesc.Enabled = false;
            this.txtMachineDesc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineDesc.Location = new System.Drawing.Point(144, 291);
            this.txtMachineDesc.Multiline = true;
            this.txtMachineDesc.Name = "txtMachineDesc";
            this.txtMachineDesc.Size = new System.Drawing.Size(239, 78);
            this.txtMachineDesc.TabIndex = 6;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(4, 158);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 26);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "助记码：";
            // 
            // txtMachineSpellCode
            // 
            // 
            // 
            // 
            this.txtMachineSpellCode.Border.Class = "TextBoxBorder";
            this.txtMachineSpellCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMachineSpellCode.Enabled = false;
            this.txtMachineSpellCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineSpellCode.Location = new System.Drawing.Point(142, 158);
            this.txtMachineSpellCode.Name = "txtMachineSpellCode";
            this.txtMachineSpellCode.Size = new System.Drawing.Size(239, 26);
            this.txtMachineSpellCode.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(3, 113);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(111, 26);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "机器名称:";
            // 
            // txtMachineName
            // 
            // 
            // 
            // 
            this.txtMachineName.Border.Class = "TextBoxBorder";
            this.txtMachineName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMachineName.Enabled = false;
            this.txtMachineName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineName.Location = new System.Drawing.Point(142, 113);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(239, 26);
            this.txtMachineName.TabIndex = 2;
            this.txtMachineName.TextChanged += new System.EventHandler(this.txtMachineName_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(4, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(111, 26);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "机器编码：";
            // 
            // txtMachineID
            // 
            // 
            // 
            // 
            this.txtMachineID.Border.Class = "TextBoxBorder";
            this.txtMachineID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMachineID.Enabled = false;
            this.txtMachineID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMachineID.Location = new System.Drawing.Point(142, 19);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(239, 26);
            this.txtMachineID.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvMain);
            this.groupPanel1.Location = new System.Drawing.Point(4, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(609, 514);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "详细信息";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineID,
            this.MachineIDGroupID,
            this.MachineStatusID,
            this.MachineName,
            this.MachineOriginallyID,
            this.MachineIDGroupName,
            this.MachineStatusName,
            this.MachineDesc,
            this.SpellCode,
            this.AccountCode});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(603, 490);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // MachineID
            // 
            this.MachineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineID.DataPropertyName = "MachineID";
            this.MachineID.HeaderText = "机器编码";
            this.MachineID.Name = "MachineID";
            this.MachineID.ReadOnly = true;
            this.MachineID.Visible = false;
            // 
            // MachineIDGroupID
            // 
            this.MachineIDGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineIDGroupID.DataPropertyName = "MachineIDGroupID";
            this.MachineIDGroupID.HeaderText = "机器组编码";
            this.MachineIDGroupID.Name = "MachineIDGroupID";
            this.MachineIDGroupID.ReadOnly = true;
            this.MachineIDGroupID.Visible = false;
            // 
            // MachineStatusID
            // 
            this.MachineStatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineStatusID.DataPropertyName = "MachineStatusID";
            this.MachineStatusID.HeaderText = "状态编码";
            this.MachineStatusID.Name = "MachineStatusID";
            this.MachineStatusID.ReadOnly = true;
            this.MachineStatusID.Visible = false;
            // 
            // MachineName
            // 
            this.MachineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineName.DataPropertyName = "MachineName";
            this.MachineName.HeaderText = "机器名称";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            // 
            // MachineOriginallyID
            // 
            this.MachineOriginallyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineOriginallyID.DataPropertyName = "MachineOriginallyID";
            this.MachineOriginallyID.HeaderText = "真实机器编码";
            this.MachineOriginallyID.Name = "MachineOriginallyID";
            this.MachineOriginallyID.ReadOnly = true;
            // 
            // MachineIDGroupName
            // 
            this.MachineIDGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineIDGroupName.DataPropertyName = "MachineIDGroupName";
            this.MachineIDGroupName.HeaderText = "机器组名称";
            this.MachineIDGroupName.Name = "MachineIDGroupName";
            this.MachineIDGroupName.ReadOnly = true;
            // 
            // MachineStatusName
            // 
            this.MachineStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineStatusName.DataPropertyName = "MachineStatusName";
            this.MachineStatusName.HeaderText = "机器状态";
            this.MachineStatusName.Name = "MachineStatusName";
            this.MachineStatusName.ReadOnly = true;
            // 
            // MachineDesc
            // 
            this.MachineDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineDesc.DataPropertyName = "MachineDesc";
            this.MachineDesc.HeaderText = "描述";
            this.MachineDesc.Name = "MachineDesc";
            this.MachineDesc.ReadOnly = true;
            // 
            // SpellCode
            // 
            this.SpellCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpellCode.DataPropertyName = "SpellCode";
            this.SpellCode.HeaderText = "助记码";
            this.SpellCode.Name = "SpellCode";
            this.SpellCode.ReadOnly = true;
            this.SpellCode.Visible = false;
            // 
            // AccountCode
            // 
            this.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "讨账编码";
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.ReadOnly = true;
            this.AccountCode.Visible = false;
            // 
            // 主设备维护
            // 
            this.主设备维护.AttachedControl = this.tabControlPanel1;
            this.主设备维护.Name = "主设备维护";
            this.主设备维护.Text = "主设备维护";
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "设备状态维护";
            this.tabItem1.Visible = false;
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "辅设备维护";
            // 
            // FrmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1014, 568);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmEquipment";
            this.Text = "设备设置";
            this.Load += new System.EventHandler(this.FrmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem 主设备维护;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnMainAdd;
        private DevComponents.DotNetBar.ButtonX btnMainCancel;
        private DevComponents.DotNetBar.ButtonX btnMainUpdate;
        private DevComponents.DotNetBar.ButtonX btnMainSave;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMachineDesc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMachineSpellCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMachineName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMachineID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dgvMain;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.ComboBox comMachineType;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMachineCode;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.ComboBox cmMainType;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineIDGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineOriginallyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineIDGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
    }
}