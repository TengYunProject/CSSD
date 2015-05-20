namespace CSSD.Client.UI.ManagerBench
{
    partial class FrmCustTable
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ckIsStop = new System.Windows.Forms.CheckBox();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtContactID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTaxGroup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtInvoiceAccoutID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.comLocationID = new System.Windows.Forms.ComboBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.comCustGroupID = new System.Windows.Forms.ComboBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtLineDistance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtCustNameAlias = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.comCost = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSpellCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCustID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAccoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.ckIsStop);
            this.groupPanel2.Controls.Add(this.txtAddress);
            this.groupPanel2.Controls.Add(this.txtContactID);
            this.groupPanel2.Controls.Add(this.txtTaxGroup);
            this.groupPanel2.Controls.Add(this.txtInvoiceAccoutID);
            this.groupPanel2.Controls.Add(this.btnAdd);
            this.groupPanel2.Controls.Add(this.btnCancel);
            this.groupPanel2.Controls.Add(this.btnUpdate);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.labelX14);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.comLocationID);
            this.groupPanel2.Controls.Add(this.labelX12);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.comCustGroupID);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.txtLineDistance);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.txtCustNameAlias);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.comCost);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtSpellCode);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtCustName);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtCustID);
            this.groupPanel2.Location = new System.Drawing.Point(548, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(395, 531);
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
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "编辑";
            // 
            // ckIsStop
            // 
            this.ckIsStop.AutoSize = true;
            this.ckIsStop.BackColor = System.Drawing.Color.Transparent;
            this.ckIsStop.Enabled = false;
            this.ckIsStop.Font = new System.Drawing.Font("宋体", 12F);
            this.ckIsStop.Location = new System.Drawing.Point(281, 396);
            this.ckIsStop.Name = "ckIsStop";
            this.ckIsStop.Size = new System.Drawing.Size(91, 20);
            this.ckIsStop.TabIndex = 54;
            this.ckIsStop.Text = "是否停用";
            this.ckIsStop.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(105, 422);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 26);
            this.txtAddress.TabIndex = 52;
            // 
            // txtContactID
            // 
            // 
            // 
            // 
            this.txtContactID.Border.Class = "TextBoxBorder";
            this.txtContactID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactID.Enabled = false;
            this.txtContactID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContactID.Location = new System.Drawing.Point(105, 390);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(127, 26);
            this.txtContactID.TabIndex = 51;
            // 
            // txtTaxGroup
            // 
            // 
            // 
            // 
            this.txtTaxGroup.Border.Class = "TextBoxBorder";
            this.txtTaxGroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaxGroup.Enabled = false;
            this.txtTaxGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTaxGroup.Location = new System.Drawing.Point(106, 310);
            this.txtTaxGroup.Name = "txtTaxGroup";
            this.txtTaxGroup.Size = new System.Drawing.Size(267, 26);
            this.txtTaxGroup.TabIndex = 50;
            // 
            // txtInvoiceAccoutID
            // 
            // 
            // 
            // 
            this.txtInvoiceAccoutID.Border.Class = "TextBoxBorder";
            this.txtInvoiceAccoutID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvoiceAccoutID.Enabled = false;
            this.txtInvoiceAccoutID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInvoiceAccoutID.Location = new System.Drawing.Point(105, 188);
            this.txtInvoiceAccoutID.Name = "txtInvoiceAccoutID";
            this.txtInvoiceAccoutID.Size = new System.Drawing.Size(267, 26);
            this.txtInvoiceAccoutID.TabIndex = 49;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(3, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "新 增(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(299, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "取 消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(103, 469);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "修 改(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(205, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 45;
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
            this.labelX14.Location = new System.Drawing.Point(3, 424);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(94, 26);
            this.labelX14.TabIndex = 44;
            this.labelX14.Text = "地  址：";
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
            this.labelX13.Location = new System.Drawing.Point(6, 390);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(94, 26);
            this.labelX13.TabIndex = 42;
            this.labelX13.Text = "联系人:";
            // 
            // comLocationID
            // 
            this.comLocationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLocationID.Enabled = false;
            this.comLocationID.Font = new System.Drawing.Font("宋体", 12F);
            this.comLocationID.FormattingEnabled = true;
            this.comLocationID.Location = new System.Drawing.Point(105, 352);
            this.comLocationID.Name = "comLocationID";
            this.comLocationID.Size = new System.Drawing.Size(267, 24);
            this.comLocationID.TabIndex = 40;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX12.Location = new System.Drawing.Point(6, 352);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(69, 26);
            this.labelX12.TabIndex = 39;
            this.labelX12.Text = "地  区:";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.Location = new System.Drawing.Point(6, 310);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(94, 26);
            this.labelX11.TabIndex = 38;
            this.labelX11.Text = "增值税:";
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
            this.labelX10.Location = new System.Drawing.Point(6, 229);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(94, 26);
            this.labelX10.TabIndex = 36;
            this.labelX10.Tag = "";
            this.labelX10.Text = "客户组：";
            // 
            // comCustGroupID
            // 
            this.comCustGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCustGroupID.Enabled = false;
            this.comCustGroupID.Font = new System.Drawing.Font("宋体", 12F);
            this.comCustGroupID.FormattingEnabled = true;
            this.comCustGroupID.Location = new System.Drawing.Point(105, 229);
            this.comCustGroupID.Name = "comCustGroupID";
            this.comCustGroupID.Size = new System.Drawing.Size(267, 24);
            this.comCustGroupID.TabIndex = 35;
            this.comCustGroupID.SelectedValueChanged += new System.EventHandler(this.comCustGroupID_SelectedValueChanged);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(6, 188);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(94, 26);
            this.labelX8.TabIndex = 34;
            this.labelX8.Text = "发票账号:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(270, 150);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(40, 26);
            this.labelX7.TabIndex = 32;
            this.labelX7.Text = "KM";
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
            this.labelX6.Location = new System.Drawing.Point(6, 150);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 26);
            this.labelX6.TabIndex = 31;
            this.labelX6.Text = "直线距离:";
            // 
            // txtLineDistance
            // 
            // 
            // 
            // 
            this.txtLineDistance.Border.Class = "TextBoxBorder";
            this.txtLineDistance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLineDistance.Enabled = false;
            this.txtLineDistance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLineDistance.Location = new System.Drawing.Point(105, 150);
            this.txtLineDistance.Name = "txtLineDistance";
            this.txtLineDistance.Size = new System.Drawing.Size(155, 26);
            this.txtLineDistance.TabIndex = 30;
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
            this.labelX5.Location = new System.Drawing.Point(6, 110);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 26);
            this.labelX5.TabIndex = 29;
            this.labelX5.Text = "客户别名:";
            // 
            // txtCustNameAlias
            // 
            // 
            // 
            // 
            this.txtCustNameAlias.Border.Class = "TextBoxBorder";
            this.txtCustNameAlias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustNameAlias.Enabled = false;
            this.txtCustNameAlias.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustNameAlias.Location = new System.Drawing.Point(105, 110);
            this.txtCustNameAlias.Name = "txtCustNameAlias";
            this.txtCustNameAlias.Size = new System.Drawing.Size(267, 26);
            this.txtCustNameAlias.TabIndex = 28;
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
            this.labelX9.Location = new System.Drawing.Point(6, 271);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(94, 26);
            this.labelX9.TabIndex = 27;
            this.labelX9.Tag = "";
            this.labelX9.Text = "计费类型：";
            // 
            // comCost
            // 
            this.comCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCost.Enabled = false;
            this.comCost.Font = new System.Drawing.Font("宋体", 12F);
            this.comCost.FormattingEnabled = true;
            this.comCost.Location = new System.Drawing.Point(105, 271);
            this.comCost.Name = "comCost";
            this.comCost.Size = new System.Drawing.Size(267, 24);
            this.comCost.TabIndex = 26;
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
            this.labelX3.Location = new System.Drawing.Point(6, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 26);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "助记码：";
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
            this.txtSpellCode.Location = new System.Drawing.Point(105, 75);
            this.txtSpellCode.Name = "txtSpellCode";
            this.txtSpellCode.Size = new System.Drawing.Size(267, 26);
            this.txtSpellCode.TabIndex = 4;
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
            this.labelX2.Location = new System.Drawing.Point(6, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 26);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "客户名称:";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustName.Enabled = false;
            this.txtCustName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustName.Location = new System.Drawing.Point(105, 40);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(267, 26);
            this.txtCustName.TabIndex = 2;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
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
            this.labelX1.Location = new System.Drawing.Point(6, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 26);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "客户编码：";
            // 
            // txtCustID
            // 
            // 
            // 
            // 
            this.txtCustID.Border.Class = "TextBoxBorder";
            this.txtCustID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustID.Enabled = false;
            this.txtCustID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustID.Location = new System.Drawing.Point(105, 3);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(267, 26);
            this.txtCustID.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvCust);
            this.groupPanel1.Location = new System.Drawing.Point(2, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(540, 531);
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
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "详细信息";
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToResizeRows = false;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.CustName,
            this.CustNameAlias,
            this.SpellCode,
            this.InvoiceAccoutID,
            this.CustGroupID,
            this.CustGroupName,
            this.CostModelID,
            this.CostModelName,
            this.TaxGroup,
            this.LocationID,
            this.LineDistance,
            this.ContactID,
            this.ContactName,
            this.Address,
            this.AccountCode,
            this.IsStop});
            this.dgvCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCust.Location = new System.Drawing.Point(0, 0);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersVisible = false;
            this.dgvCust.RowTemplate.Height = 23;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(534, 507);
            this.dgvCust.TabIndex = 0;
            this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustGroup_CellClick);
            this.dgvCust.SelectionChanged += new System.EventHandler(this.dgvCustGroup_SelectionChanged);
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.HeaderText = "客户编码";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Visible = false;
            // 
            // CustName
            // 
            this.CustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "客户名称";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // CustNameAlias
            // 
            this.CustNameAlias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustNameAlias.DataPropertyName = "CustNameAlias";
            this.CustNameAlias.HeaderText = "客户别名";
            this.CustNameAlias.Name = "CustNameAlias";
            this.CustNameAlias.ReadOnly = true;
            // 
            // SpellCode
            // 
            this.SpellCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpellCode.DataPropertyName = "SpellCode";
            this.SpellCode.HeaderText = "助记码";
            this.SpellCode.Name = "SpellCode";
            this.SpellCode.ReadOnly = true;
            // 
            // InvoiceAccoutID
            // 
            this.InvoiceAccoutID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceAccoutID.DataPropertyName = "InvoiceAccoutID";
            this.InvoiceAccoutID.HeaderText = "发票账号";
            this.InvoiceAccoutID.Name = "InvoiceAccoutID";
            this.InvoiceAccoutID.ReadOnly = true;
            // 
            // CustGroupID
            // 
            this.CustGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustGroupID.DataPropertyName = "CustGroupID";
            this.CustGroupID.HeaderText = "客户组编码";
            this.CustGroupID.Name = "CustGroupID";
            this.CustGroupID.ReadOnly = true;
            this.CustGroupID.Visible = false;
            // 
            // CustGroupName
            // 
            this.CustGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustGroupName.DataPropertyName = "CustGroupName";
            this.CustGroupName.HeaderText = "客户组名称";
            this.CustGroupName.Name = "CustGroupName";
            this.CustGroupName.ReadOnly = true;
            // 
            // CostModelID
            // 
            this.CostModelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostModelID.DataPropertyName = "CostModelID";
            this.CostModelID.HeaderText = "计费模式编码";
            this.CostModelID.Name = "CostModelID";
            this.CostModelID.ReadOnly = true;
            this.CostModelID.Visible = false;
            // 
            // CostModelName
            // 
            this.CostModelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostModelName.DataPropertyName = "CostModelName";
            this.CostModelName.HeaderText = "计费模式";
            this.CostModelName.Name = "CostModelName";
            this.CostModelName.ReadOnly = true;
            // 
            // TaxGroup
            // 
            this.TaxGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaxGroup.DataPropertyName = "TaxGroup";
            this.TaxGroup.HeaderText = "增值税";
            this.TaxGroup.Name = "TaxGroup";
            this.TaxGroup.ReadOnly = true;
            // 
            // LocationID
            // 
            this.LocationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocationID.DataPropertyName = "LocationID";
            this.LocationID.HeaderText = "地区编码";
            this.LocationID.Name = "LocationID";
            this.LocationID.ReadOnly = true;
            this.LocationID.Visible = false;
            // 
            // LineDistance
            // 
            this.LineDistance.DataPropertyName = "LineDistance";
            this.LineDistance.HeaderText = "直线距离";
            this.LineDistance.Name = "LineDistance";
            this.LineDistance.ReadOnly = true;
            // 
            // ContactID
            // 
            this.ContactID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactID.DataPropertyName = "ContactID";
            this.ContactID.HeaderText = "联系人编码";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Visible = false;
            // 
            // ContactName
            // 
            this.ContactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "联系人";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
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
            // IsStop
            // 
            this.IsStop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsStop.DataPropertyName = "IsStop";
            this.IsStop.HeaderText = "是否停用";
            this.IsStop.Name = "IsStop";
            this.IsStop.ReadOnly = true;
            // 
            // FrmCustTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(949, 556);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmCustTable";
            this.Text = "客户信息维护";
            this.Load += new System.EventHandler(this.FrmCustTable_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSpellCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dgvCust;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustNameAlias;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLineDistance;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.ComboBox comCustGroupID;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.ComboBox comCost;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private System.Windows.Forms.ComboBox comLocationID;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaxGroup;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoiceAccoutID;
        private System.Windows.Forms.CheckBox ckIsStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNameAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAccoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsStop;
    }
}