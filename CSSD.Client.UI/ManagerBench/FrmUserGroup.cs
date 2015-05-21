using CSSD.Client.UI.PubHelper;
using CSSD.Server.DataModel.ManagerBenchModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD.Client.UI.ManagerBench
{
    public partial class FrmUserGroup : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 用户组实体
        /// </summary>
        UserGroupModel userGroup;
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;
        /// <summary>
        /// 存储权限信息
        /// </summary>
        DataTable dtp = new DataTable();
        public FrmUserGroup()
        {
            InitializeComponent();
            PermissionModel permission = new PermissionModel();
            errorString = string.Empty;
            dtp = permission.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
            if (dtp != null && dtp.Rows.Count > 0)
            {
                for (int i = 0; i < dtp.Rows.Count; i++)
                {
                    checkedListBox1.Items.Add(dtp.Rows[i]["PermissionName"]);
                }
            }
        }
        #region 事件
        private void FrmUserGroup_Load(object sender, EventArgs e)
        {
            try
            {
                userGroup = new UserGroupModel();
                errorString = string.Empty;
                DataTable dtUserGroup = userGroup.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvUserGroup.DataSource = dtUserGroup;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(true, checkedListBox1, txtUserGroupName, btnSave, btnCancel, txtSpellCode, txtUserGroupDesc);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
            CommUtility.ClearControl(txtUserGroupID, txtSpellCode, txtUserGroupName, txtUserGroupDesc);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(true, checkedListBox1, txtUserGroupName, btnSave, btnCancel, txtSpellCode, txtUserGroupDesc);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserGroupName.Text))
                {
                    MessageBox.Show("用户组名称不可以为空！");
                    return;
                }
                bool result = false;
                userGroup = new UserGroupModel();
                errorString = string.Empty;
                userGroup.UserGroupName = txtUserGroupName.Text.Trim();
                userGroup.SpellCode = txtSpellCode.Text;
                //获取权限编码
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        DataRow[] drs = dtp.Select("PermissionName='" + checkedListBox1.GetItemText(checkedListBox1.Items[i]) + "'");
                        userGroup.PermissionID += drs[0]["PermissionID"] + ",";
                    }
                }
                //截取掉最后的逗号
                userGroup.PermissionID = userGroup.PermissionID.Substring(0, userGroup.PermissionID.Length - 1);
                userGroup.UserGroupDesc = txtUserGroupDesc.Text;
                userGroup.AccountCode = "";
                userGroup.CreateUserID = 1;
                userGroup.CreateDateTime = DateTime.Now;
                if (string.IsNullOrEmpty(txtUserGroupID.Text))
                {
                    result = userGroup.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    userGroup.UserGroupID = Convert.ToInt32(txtUserGroupID.Text);
                    result = userGroup.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }

                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, checkedListBox1, txtUserGroupID, txtUserGroupName, btnSave, btnCancel, txtSpellCode, txtUserGroupDesc);
                    btnAdd.Enabled = true;
                    DataTable dtGroup = userGroup.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvUserGroup.DataSource = dtGroup;
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(false, checkedListBox1, txtUserGroupID, txtUserGroupName, btnSave, btnCancel, txtSpellCode, txtUserGroupDesc);
            CommUtility.SetEnabled(true, btnAdd, btnUpdate);
            CommUtility.ClearControl(txtUserGroupID, txtSpellCode, txtUserGroupName, txtUserGroupDesc);
        }

        private void txtUserGroupName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtUserGroupName.Text);
        }

        private void dgvUserGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetValue();
        }

        private void dgvUserGroup_SelectionChanged(object sender, EventArgs e)
        {
            GetValue();
        }
        #endregion

        #region 内部方法
        private void GetValue()
        {
            try
            {
                int rowIndex = dgvUserGroup.CurrentRow.Index;
                if (rowIndex < 0) return;
                txtUserGroupID.Text = dgvUserGroup.CurrentRow.Cells["UserGroupID"].Value + "";
                txtUserGroupName.Text = dgvUserGroup.CurrentRow.Cells["UserGroupName"].Value + "";
                txtSpellCode.Text = dgvUserGroup.CurrentRow.Cells["SpellCode"].Value + "";
                // txtPermissionID.Text = dgvUserGroup.CurrentRow.Cells["PermissionID"].Value + "";
                txtUserGroupDesc.Text = dgvUserGroup.CurrentRow.Cells["UserGroupDesc"].Value + "";
                //将checkedListBox1 赋值
                string permissionID = dgvUserGroup.CurrentRow.Cells["PermissionID"].Value + "";
                string[] cid_arr = permissionID.Split(',').Distinct().ToArray();
                for (int i = 0; i < cid_arr.Length; i++)
                {
                    DataRow[] rows = dtp.Select("PermissionID='" + cid_arr[i].ToString() + "'");
                    string perName = rows[0]["PermissionName"] + "";
                    for (int j = 0; j < checkedListBox1.Items.Count; j++)
                    {
                        if (perName == checkedListBox1.GetItemText(checkedListBox1.Items[j]))
                        {
                            checkedListBox1.SetItemCheckState(j, CheckState.Checked);
                        }
                    }
                }
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
