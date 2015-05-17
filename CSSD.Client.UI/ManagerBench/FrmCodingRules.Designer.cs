namespace CSSD.Client.UI.ManagerBench
{
    partial class FrmCodingRules
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCodingRules = new System.Windows.Forms.DataGridView();
            this.CodingRulesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodingRulesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodingRulesValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodingRulesIncreasing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodingRulesLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtCodingRulesLength = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtCodingRulesIncreasing = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtCodingRulesValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbRulesType = new System.Windows.Forms.ComboBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodingRules)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvCodingRules);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(669, 495);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "详细信息";
            // 
            // dgvCodingRules
            // 
            this.dgvCodingRules.AllowUserToAddRows = false;
            this.dgvCodingRules.AllowUserToResizeRows = false;
            this.dgvCodingRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodingRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodingRulesID,
            this.CodingRulesType,
            this.CodingRulesValue,
            this.CodingRulesIncreasing,
            this.CurrentCode,
            this.CodingRulesLength,
            this.AccountCode,
            this.SiteID});
            this.dgvCodingRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCodingRules.Location = new System.Drawing.Point(0, 0);
            this.dgvCodingRules.Name = "dgvCodingRules";
            this.dgvCodingRules.ReadOnly = true;
            this.dgvCodingRules.RowHeadersVisible = false;
            this.dgvCodingRules.RowTemplate.Height = 23;
            this.dgvCodingRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodingRules.Size = new System.Drawing.Size(663, 471);
            this.dgvCodingRules.TabIndex = 0;
            this.dgvCodingRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCodingRules_CellClick);
            this.dgvCodingRules.SelectionChanged += new System.EventHandler(this.dgvCodingRules_SelectionChanged);
            // 
            // CodingRulesID
            // 
            this.CodingRulesID.DataPropertyName = "CodingRulesID";
            this.CodingRulesID.HeaderText = "编码ID";
            this.CodingRulesID.Name = "CodingRulesID";
            this.CodingRulesID.ReadOnly = true;
            this.CodingRulesID.Visible = false;
            // 
            // CodingRulesType
            // 
            this.CodingRulesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodingRulesType.DataPropertyName = "CodingRulesType";
            this.CodingRulesType.HeaderText = "编码类型";
            this.CodingRulesType.Name = "CodingRulesType";
            this.CodingRulesType.ReadOnly = true;
            // 
            // CodingRulesValue
            // 
            this.CodingRulesValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodingRulesValue.DataPropertyName = "CodingRulesValue";
            this.CodingRulesValue.HeaderText = "预设值";
            this.CodingRulesValue.Name = "CodingRulesValue";
            this.CodingRulesValue.ReadOnly = true;
            // 
            // CodingRulesIncreasing
            // 
            this.CodingRulesIncreasing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodingRulesIncreasing.DataPropertyName = "CodingRulesIncreasing";
            this.CodingRulesIncreasing.HeaderText = "递增量";
            this.CodingRulesIncreasing.Name = "CodingRulesIncreasing";
            this.CodingRulesIncreasing.ReadOnly = true;
            // 
            // CurrentCode
            // 
            this.CurrentCode.DataPropertyName = "CurrentCode";
            this.CurrentCode.HeaderText = "当前值";
            this.CurrentCode.Name = "CurrentCode";
            this.CurrentCode.ReadOnly = true;
            // 
            // CodingRulesLength
            // 
            this.CodingRulesLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodingRulesLength.DataPropertyName = "CodingRulesLength";
            this.CodingRulesLength.HeaderText = "长度";
            this.CodingRulesLength.Name = "CodingRulesLength";
            this.CodingRulesLength.ReadOnly = true;
            // 
            // AccountCode
            // 
            this.AccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountCode.DataPropertyName = "AccountCode";
            this.AccountCode.HeaderText = "AccountCode";
            this.AccountCode.Name = "AccountCode";
            this.AccountCode.ReadOnly = true;
            this.AccountCode.Visible = false;
            // 
            // SiteID
            // 
            this.SiteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiteID.DataPropertyName = "SiteID";
            this.SiteID.HeaderText = "SiteID";
            this.SiteID.Name = "SiteID";
            this.SiteID.ReadOnly = true;
            this.SiteID.Visible = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnAdd);
            this.groupPanel2.Controls.Add(this.btnCancel);
            this.groupPanel2.Controls.Add(this.btnUpdate);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.txtCodingRulesLength);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtCodingRulesIncreasing);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtCodingRulesValue);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.cmbRulesType);
            this.groupPanel2.Location = new System.Drawing.Point(698, 12);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(328, 495);
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
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "编辑";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(2, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 34);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "新 增(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(251, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取 消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(86, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 34);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修 改(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(168, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 34);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保 存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCodingRulesLength
            // 
            // 
            // 
            // 
            this.txtCodingRulesLength.Border.Class = "TextBoxBorder";
            this.txtCodingRulesLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodingRulesLength.Enabled = false;
            this.txtCodingRulesLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCodingRulesLength.Location = new System.Drawing.Point(125, 248);
            this.txtCodingRulesLength.Name = "txtCodingRulesLength";
            this.txtCodingRulesLength.Size = new System.Drawing.Size(194, 26);
            this.txtCodingRulesLength.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Enabled = false;
            this.labelX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(3, 251);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "长度值：";
            // 
            // txtCodingRulesIncreasing
            // 
            // 
            // 
            // 
            this.txtCodingRulesIncreasing.Border.Class = "TextBoxBorder";
            this.txtCodingRulesIncreasing.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodingRulesIncreasing.Enabled = false;
            this.txtCodingRulesIncreasing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCodingRulesIncreasing.Location = new System.Drawing.Point(125, 177);
            this.txtCodingRulesIncreasing.Name = "txtCodingRulesIncreasing";
            this.txtCodingRulesIncreasing.Size = new System.Drawing.Size(194, 26);
            this.txtCodingRulesIncreasing.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Enabled = false;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(3, 180);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "递增值：";
            // 
            // txtCodingRulesValue
            // 
            // 
            // 
            // 
            this.txtCodingRulesValue.Border.Class = "TextBoxBorder";
            this.txtCodingRulesValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodingRulesValue.Enabled = false;
            this.txtCodingRulesValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCodingRulesValue.Location = new System.Drawing.Point(125, 113);
            this.txtCodingRulesValue.Name = "txtCodingRulesValue";
            this.txtCodingRulesValue.Size = new System.Drawing.Size(194, 26);
            this.txtCodingRulesValue.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Enabled = false;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(3, 116);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "预设值：";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Enabled = false;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(3, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "编码类型：";
            // 
            // cmbRulesType
            // 
            this.cmbRulesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRulesType.Enabled = false;
            this.cmbRulesType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRulesType.FormattingEnabled = true;
            this.cmbRulesType.Location = new System.Drawing.Point(125, 40);
            this.cmbRulesType.Name = "cmbRulesType";
            this.cmbRulesType.Size = new System.Drawing.Size(194, 24);
            this.cmbRulesType.TabIndex = 0;
            // 
            // FrmCodingRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1038, 519);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCodingRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码设置";
            this.Load += new System.EventHandler(this.FrmCodingRules_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodingRules)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridView dgvCodingRules;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cmbRulesType;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodingRulesValue;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodingRulesLength;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodingRulesIncreasing;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodingRulesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodingRulesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodingRulesValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodingRulesIncreasing;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodingRulesLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteID;


    }
}