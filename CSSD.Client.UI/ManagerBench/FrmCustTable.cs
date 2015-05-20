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
    public partial class FrmCustTable : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 客户实体
        /// </summary>
        CustTableModel csutTable;
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;
        /// <summary>
        /// 窗体状态
        /// </summary>
        int FormType = 0;
        public FrmCustTable()
        {
            InitializeComponent();
        }

        #region 事件
        private void FrmCustTable_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定客户表格信息
                errorString = string.Empty;
                csutTable = new CustTableModel();
                DataTable dtCust = csutTable.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvCust.DataSource = dtCust;
                //绑定客户组控件
                errorString = string.Empty;
                CustGroupModel custGroup = new CustGroupModel();
                DataTable dtCustGroup = custGroup.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                if (dtCustGroup != null && dtCustGroup.Rows.Count > 0)
                {
                    ArrayList costList = new ArrayList();
                    foreach (DataRow row in dtCustGroup.Rows)
                    {
                        costList.Add(new DictionaryEntry(row["CustGroupName"] + "", row["CustGroupID"] + ""));
                    }
                    //绑定控件
                    comCustGroupID.DataSource = costList;
                    comCustGroupID.DisplayMember = "Key";
                    comCustGroupID.ValueMember = "Value";
                }
                //绑定计费模式控件
                errorString = string.Empty;
                CostModelModel costModel = new CostModelModel();
                DataTable dtCost = costModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                if (dtCost != null && dtCost.Rows.Count > 0)
                {
                    ArrayList costList = new ArrayList();
                    foreach (DataRow row in dtCost.Rows)
                    {
                        costList.Add(new DictionaryEntry(row["CostName"] + "", row["CostModelID"] + ""));
                    }
                    //绑定控件
                    comCost.DataSource = costList;
                    comCost.DisplayMember = "Key";
                    comCost.ValueMember = "Value";
                }
                //绑定地区控件
                FormType = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(true, btnSave, btnCancel, txtCustName, txtSpellCode,
                txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID, comCustGroupID, comCost,
                txtTaxGroup, comLocationID, txtContactID, txtAddress, ckIsStop);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
            CommUtility.ClearControl(txtCustName, txtSpellCode,
                txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID,
                txtTaxGroup, txtContactID, txtAddress);

            if (comCost.DataSource != null)
                comCost.SelectedIndex = 0;
            if (comCustGroupID.DataSource != null)
                comCustGroupID.SelectedIndex = 0;
            if (comLocationID.DataSource != null)
                comLocationID.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnSave, btnCancel, txtCustName, txtSpellCode,
               txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID, comCustGroupID, comCost,
               txtTaxGroup, comLocationID, txtContactID, txtAddress, ckIsStop);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (string.IsNullOrEmpty(txtCustName.Text.Trim()))
                {
                    MessageBox.Show("客户编码不可以为空！");
                    return;
                }
                //if (string.IsNullOrEmpty(txtLineDistance.Text.Trim()))
                //{
                //    MessageBox.Show("直线距离不可以为空！");
                //    return;
                //}
                csutTable = new CustTableModel();
                csutTable.CustName = txtCustName.Text.Trim();
                csutTable.CustNameAlias = txtCustNameAlias.Text.Trim();
                csutTable.LineDistance = txtLineDistance.Text.Trim();
                csutTable.InvoiceAccoutID = Convert.ToInt32(txtInvoiceAccoutID.Text.Trim());
                csutTable.TaxGroup = txtTaxGroup.Text.Trim();
                csutTable.LocationID = 0;//Convert.ToInt32(comLocationID.SelectedValue + "");
                csutTable.ContactID = 10;//txtContactID.Text.Trim();
                csutTable.Address = txtAddress.Text;
                csutTable.AccountCode = "";
                csutTable.SpellCode = txtSpellCode.Text;
                csutTable.IsStop = ckIsStop.Checked == true ? "是" : "否";
                csutTable.CustGroupID = Convert.ToInt32(comCustGroupID.SelectedValue + "");
                csutTable.CostModelID = Convert.ToInt32(comCost.SelectedValue + "");
                csutTable.CustGroupName = comCustGroupID.Text;
                csutTable.CostModelName = comCost.Text;
                errorString = string.Empty;
                if (string.IsNullOrEmpty(txtCustID.Text))
                {
                    result = csutTable.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    csutTable.CustID = Convert.ToInt32(txtCustID.Text);
                    result = csutTable.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, btnSave, btnCancel, txtCustName, txtSpellCode,
                txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID, comCustGroupID, comCost,
                txtTaxGroup, comLocationID, txtContactID, txtAddress, ckIsStop);
                    CommUtility.SetEnabled(true, btnAdd, btnUpdate);
                    CommUtility.ClearControl(txtCustName, txtSpellCode,
                        txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID,
                        txtTaxGroup, txtContactID, txtAddress);
                    btnAdd.Enabled = true;
                    if (comCost.DataSource != null)
                        comCost.SelectedIndex = 0;
                    DataTable dt = csutTable.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvCust.DataSource = dt;
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
            CommUtility.SetEnabled(false, btnSave, btnCancel, txtCustName, txtSpellCode,
                txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID, comCustGroupID, comCost,
                txtTaxGroup, comLocationID, txtContactID, txtAddress, ckIsStop);
            CommUtility.SetEnabled(true, btnAdd, btnUpdate);
            CommUtility.ClearControl(txtCustName, txtSpellCode,
                txtCustNameAlias, txtLineDistance, txtInvoiceAccoutID,
                txtTaxGroup, txtContactID, txtAddress);
            btnAdd.Enabled = true;
        }
        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtCustName.Text);
        }

        private void dgvCustGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetValue();
        }

        private void dgvCustGroup_SelectionChanged(object sender, EventArgs e)
        {
            GetValue();
        }
        private void comCustGroupID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (FormType == 0) return;
                int? id = null;
                if (!string.IsNullOrEmpty(comCustGroupID.SelectedValue + ""))
                    id = Convert.ToInt32(comCustGroupID.SelectedValue + "");
                CustGroupModel custGoup = new CustGroupModel();
                errorString = string.Empty;
                DataTable dtGroup = custGoup.DelayedSelectAllToTableByID(out errorString, PubStaticModel.ConnectionStr, id);
                if (dtGroup != null && dtGroup.Rows.Count == 1)
                {
                    comCost.Text = dtGroup.Rows[0]["CostName"] + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 内部方法
        private void GetValue()
        {
            try
            {
                int rowIndex = dgvCust.CurrentRow.Index;
                if (rowIndex < 0) return;
                btnUpdate.Enabled = true;
                txtCustID.Text = dgvCust.CurrentRow.Cells["CustID"].Value + "";
                txtCustName.Text = dgvCust.CurrentRow.Cells["CustName"].Value + "";
                txtCustNameAlias.Text = dgvCust.CurrentRow.Cells["CustNameAlias"].Value + "";
                txtLineDistance.Text = dgvCust.CurrentRow.Cells["LineDistance"].Value + "";
                txtInvoiceAccoutID.Text = dgvCust.CurrentRow.Cells["InvoiceAccoutID"].Value + "";
                txtTaxGroup.Text = dgvCust.CurrentRow.Cells["TaxGroup"].Value + "";
                csutTable.LocationID = 0;//Convert.ToInt32(comLocationID.SelectedValue + "");
                csutTable.ContactID = 0;//txtContactID.Text.Trim();
                txtAddress.Text = dgvCust.CurrentRow.Cells["Address"].Value + "";
                txtSpellCode.Text = dgvCust.CurrentRow.Cells["SpellCode"].Value + "";
                ckIsStop.Checked = dgvCust.CurrentRow.Cells["IsStop"].Value + "" == "是" ? true : false;
                comCustGroupID.SelectedValue = dgvCust.CurrentRow.Cells["CustGroupID"].Value + "";
                //csutTable.CostModelID = Convert.ToInt32(comCost.SelectedValue + "");
                //csutTable.CustID = Convert.ToInt32(txtCustID.Text);
                comCost.Text = dgvCust.CurrentRow.Cells["CustGroupName"].Value + "";
                comCustGroupID.Text = dgvCust.CurrentRow.Cells["CostModelName"].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion
    }
}
