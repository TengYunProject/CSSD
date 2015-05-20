using CSSD.Client.UI.PubHelper;
using CSSD.Server.DataModel.ManagerBenchModel;
using System;
using System.Collections;
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
    public partial class FrmCustGroup : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 客户组实体
        /// </summary>
        CustGroupModel custGroup;
        /// <summary>
        /// 计费实体
        /// </summary>
        CostModelModel costModel;
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;
        public FrmCustGroup()
        {
            InitializeComponent();
        }

        #region 事件
        private void FrmCustGroup_Load(object sender, EventArgs e)
        {
            try
            {
                custGroup = new CustGroupModel();
                errorString = string.Empty;
                DataTable dt = custGroup.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvCustGroup.DataSource = dt;
                errorString = string.Empty;
                costModel = new CostModelModel();
                //绑定计费模式
                DataTable dtCost = costModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                if (dtCost != null && dtCost.Rows.Count > 0)
                {
                    ArrayList mylist = new ArrayList();
                    foreach (DataRow row in dtCost.Rows)
                    {
                        mylist.Add(new DictionaryEntry(row["CostName"] + "", row["CostModelID"] + ""));
                    }
                    //绑定控件
                    comCost.DataSource = mylist;
                    comCost.DisplayMember = "Key";
                    comCost.ValueMember = "Value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(true, comCost, txtCustGroupName, txtCustGroupDesc, btnSave, btnCancel, txtSpellCode);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
            if (comCost.DataSource != null)
                comCost.SelectedIndex = 0;
            CommUtility.ClearControl(txtCustGroupID, txtSpellCode, txtCustGroupDesc, txtCustGroupName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, comCost, txtCustGroupName, txtCustGroupDesc, btnSave, btnCancel, txtSpellCode);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustGroupName.Text))
            {
                MessageBox.Show("客户组名称不可以为空！");
                return;
            }
            bool result = false;
            custGroup = new CustGroupModel();
            //
            custGroup.CustDesc = txtCustGroupDesc.Text;
            custGroup.CostModeliID = Convert.ToInt32(comCost.SelectedValue);
            custGroup.CustGroupName = txtCustGroupName.Text.Trim();
            custGroup.AccountCode = "";
            custGroup.SpellCode = txtSpellCode.Text.Trim();
            errorString = string.Empty;
            if (string.IsNullOrEmpty(txtCustGroupID.Text))
            {
                result = custGroup.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
            }
            else
            {
                custGroup.CustGroupID = Convert.ToInt32(txtCustGroupID.Text);
                result = custGroup.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
            }
            if (result)
            {
                MessageBox.Show("保存成功！");
                CommUtility.SetEnabled(false, comCost, txtCustGroupName, txtCustGroupDesc, btnSave, btnCancel, txtSpellCode);
                CommUtility.ClearControl(txtSpellCode, txtCustGroupName, txtCustGroupDesc, txtCustGroupID);
                btnAdd.Enabled = true;
                if (comCost.DataSource != null)
                    comCost.SelectedIndex = 0;
                DataTable dt = custGroup.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvCustGroup.DataSource = dt;
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //清空控件
            CommUtility.ClearControl(txtSpellCode, txtCustGroupName, txtCustGroupDesc, txtCustGroupID);
            //设置控件状态不可用
            CommUtility.SetEnabled(false, comCost, txtCustGroupName, txtCustGroupDesc, btnSave, btnCancel, txtSpellCode);
            btnAdd.Enabled = true;
        }

        private void txtCustGroupName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtCustGroupName.Text);
        }

        private void dgvCustGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetValue();
        }

        private void dgvCustGroup_SelectionChanged(object sender, EventArgs e)
        {
            GetValue();
        }
        #endregion

        #region 内部方法
        private void GetValue()
        {
            try
            {
                int rowIndex = dgvCustGroup.CurrentRow.Index;
                if (rowIndex < 0) return;
                btnUpdate.Enabled = true;
                txtCustGroupDesc.Text = dgvCustGroup.CurrentRow.Cells["CustDesc"].Value + "";
                comCost.Text = dgvCustGroup.CurrentRow.Cells["CostModeliID"].Value + "";
                txtCustGroupName.Text = dgvCustGroup.CurrentRow.Cells["CustGroupName"].Value + "";
                txtSpellCode.Text = dgvCustGroup.CurrentRow.Cells["SpellCode"].Value + "";
                txtCustGroupID.Text = dgvCustGroup.CurrentRow.Cells["CustGroupID"].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
