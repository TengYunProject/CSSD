namespace CSSD.Client.UI.ManagerBench
{
    partial class FrmUserGroup
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtUserGroupDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSpellCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtUserGroupName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtUserGroupID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvUserGroup = new System.Windows.Forms.DataGridView();
            this.UserGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroupDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.checkedListBox1);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.btnAdd);
            this.groupPanel2.Controls.Add(this.btnCancel);
            this.groupPanel2.Controls.Add(this.btnUpdate);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtUserGroupDesc);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtSpellCode);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtUserGroupName);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtUserGroupID);
            this.groupPanel2.Location = new System.Drawing.Point(495, 1);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(399, 495);
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
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(120, 171);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(249, 148);
            this.checkedListBox1.TabIndex = 15;
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
            this.labelX5.Location = new System.Drawing.Point(-2, 171);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(111, 26);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "用户组权限：";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(6, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新 增(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(302, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取 消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(106, 420);
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
            this.btnSave.Location = new System.Drawing.Point(208, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保 存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.labelX4.Location = new System.Drawing.Point(6, 323);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(111, 26);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "类别描述";
            // 
            // txtUserGroupDesc
            // 
            // 
            // 
            // 
            this.txtUserGroupDesc.Border.Class = "TextBoxBorder";
            this.txtUserGroupDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserGroupDesc.Enabled = false;
            this.txtUserGroupDesc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserGroupDesc.Location = new System.Drawing.Point(120, 327);
            this.txtUserGroupDesc.Multiline = true;
            this.txtUserGroupDesc.Name = "txtUserGroupDesc";
            this.txtUserGroupDesc.Size = new System.Drawing.Size(249, 87);
            this.txtUserGroupDesc.TabIndex = 6;
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
            this.labelX3.Location = new System.Drawing.Point(3, 121);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 26);
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
            this.txtSpellCode.Location = new System.Drawing.Point(120, 121);
            this.txtSpellCode.Name = "txtSpellCode";
            this.txtSpellCode.Size = new System.Drawing.Size(249, 26);
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
            this.labelX2.Location = new System.Drawing.Point(3, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(111, 26);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "用户组名称:";
            // 
            // txtUserGroupName
            // 
            // 
            // 
            // 
            this.txtUserGroupName.Border.Class = "TextBoxBorder";
            this.txtUserGroupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserGroupName.Enabled = false;
            this.txtUserGroupName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserGroupName.Location = new System.Drawing.Point(120, 73);
            this.txtUserGroupName.Name = "txtUserGroupName";
            this.txtUserGroupName.Size = new System.Drawing.Size(249, 26);
            this.txtUserGroupName.TabIndex = 2;
            this.txtUserGroupName.TextChanged += new System.EventHandler(this.txtUserGroupName_TextChanged);
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
            this.labelX1.Location = new System.Drawing.Point(3, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(111, 26);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "用户编码：";
            // 
            // txtUserGroupID
            // 
            // 
            // 
            // 
            this.txtUserGroupID.Border.Class = "TextBoxBorder";
            this.txtUserGroupID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserGroupID.Enabled = false;
            this.txtUserGroupID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserGroupID.Location = new System.Drawing.Point(120, 24);
            this.txtUserGroupID.Name = "txtUserGroupID";
            this.txtUserGroupID.Size = new System.Drawing.Size(249, 26);
            this.txtUserGroupID.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvUserGroup);
            this.groupPanel1.Location = new System.Drawing.Point(8, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(482, 495);
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
            // dgvUserGroup
            // 
            this.dgvUserGroup.AllowUserToAddRows = false;
            this.dgvUserGroup.AllowUserToResizeRows = false;
            this.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserGroupID,
            this.UserGroupName,
            this.SpellCode,
            this.PermissionID,
            this.CreateUserID,
            this.CreateDateTime,
            this.UserGroupDesc,
            this.AccountCode});
            this.dgvUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvUserGroup.Name = "dgvUserGroup";
            this.dgvUserGroup.ReadOnly = true;
            this.dgvUserGroup.RowHeadersVisible = false;
            this.dgvUserGroup.RowTemplate.Height = 23;
            this.dgvUserGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserGroup.Size = new System.Drawing.Size(476, 471);
            this.dgvUserGroup.TabIndex = 0;
            this.dgvUserGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserGroup_CellClick);
            this.dgvUserGroup.SelectionChanged += new System.EventHandler(this.dgvUserGroup_SelectionChanged);
            // 
            // UserGroupID
            // 
            this.UserGroupID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGroupID.DataPropertyName = "UserGroupID";
            this.UserGroupID.HeaderText = "组编码";
            this.UserGroupID.Name = "UserGroupID";
            this.UserGroupID.ReadOnly = true;
            this.UserGroupID.Visible = false;
            // 
            // UserGroupName
            // 
            this.UserGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGroupName.DataPropertyName = "UserGroupName";
            this.UserGroupName.HeaderText = "用户组名称";
            this.UserGroupName.Name = "UserGroupName";
            this.UserGroupName.ReadOnly = true;
            // 
            // SpellCode
            // 
            this.SpellCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpellCode.DataPropertyName = "SpellCode";
            this.SpellCode.HeaderText = "用户组助记码";
            this.SpellCode.Name = "SpellCode";
            this.SpellCode.ReadOnly = true;
            // 
            // PermissionID
            // 
            this.PermissionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermissionID.DataPropertyName = "PermissionID";
            this.PermissionID.HeaderText = "权限";
            this.PermissionID.Name = "PermissionID";
            this.PermissionID.ReadOnly = true;
            this.PermissionID.Visible = false;
            // 
            // CreateUserID
            // 
            this.CreateUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateUserID.DataPropertyName = "CreateUserID";
            this.CreateUserID.HeaderText = "创建人";
            this.CreateUserID.Name = "CreateUserID";
            this.CreateUserID.ReadOnly = true;
            // 
            // CreateDateTime
            // 
            this.CreateDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateDateTime.DataPropertyName = "CreateDateTime";
            this.CreateDateTime.HeaderText = "创建时间";
            this.CreateDateTime.Name = "CreateDateTime";
            this.CreateDateTime.ReadOnly = true;
            // 
            // UserGroupDesc
            // 
            this.UserGroupDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGroupDesc.DataPropertyName = "UserGroupDesc";
            this.UserGroupDesc.HeaderText = "描述";
            this.UserGroupDesc.Name = "UserGroupDesc";
            this.UserGroupDesc.ReadOnly = true;
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
            // FrmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(902, 508);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmUserGroup";
            this.Text = "用户组管理";
            this.Load += new System.EventHandler(this.FrmUserGroup_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserGroupDesc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSpellCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserGroupName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserGroupID;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dgvUserGroup;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroupDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCode;
    }
}