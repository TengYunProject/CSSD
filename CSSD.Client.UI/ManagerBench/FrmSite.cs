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
    public partial class FrmSite : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmSite()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 工厂信息实体和方法
        /// </summary>
        SiteModel siteModel = new SiteModel();
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;

        #region 事件处理
        private void FrmSite_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定表格信息
                #region 绑定表格信息
                errorString = string.Empty;
                DataTable dt = siteModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvStite.DataSource = dt;
                //如果当前存在工厂信息，则不可以再次创建,只可以做修改;如果工厂信息都是停用状态，那么可以创建新的工厂
                //////if (dgvStite.Rows.Count > 1)
                //////{
                //////    foreach (DataRow row in dt.Rows)
                //////    {
                //////        if (row["IsStop"] + "" == "否")
                //////        {
                //////            MessageBox.Show("请先停掉其他工厂，在创建新的工厂！");
                //////            return;
                //////        }
                //////    }
                //////    btnAdd.Enabled = false;
                //////    btnUpdate.Enabled = true;
                //////}
                #endregion

                #region 绑定工厂类型
                SiteTypeModel siteType = new SiteTypeModel();
                DataTable dtType = siteType.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                //绑定工厂类型数据，如果没有创建工厂类型，则不可以创建工厂信息
                if (dtType == null || dtType.Rows.Count <= 0)
                {
                    MessageBox.Show("请先创建工厂类型！");
                    return;
                }
                else
                {
                    ArrayList mylist = new ArrayList();
                    foreach (DataRow row in dtType.Rows)
                    {
                        mylist.Add(new DictionaryEntry(row["TypeName"] + "", row["SiteTypeID"] + ""));
                    }
                    //绑定工厂类型控件
                    comSiteType.DataSource = mylist;
                    comSiteType.DisplayMember = "Key";
                    comSiteType.ValueMember = "Value";
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgvStite.Rows)
            {
                if (dgvRow.Cells["IsStop"].Value + "" == "否")
                {
                    MessageBox.Show("请先停用其他工厂，在启用此工厂！");
                    return;
                }
            }
            CommUtility.SetEnabled(true, btnCancel, btnSave, txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, ckIsStop, ckSiteType2, txtCapacity, txtLocationID, comSiteType, btnCodingRules);
            CommUtility.ClearControl(txtSiteName, txtSiteID, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, txtCapacity, txtLocationID);
            btnAdd.Enabled = false; ckIsStop.Checked = false; ckSiteType2.Checked = false;
            comSiteType.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnCancel, btnSave, txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, ckIsStop, ckSiteType2, txtCapacity, txtLocationID, comSiteType, btnCodingRules);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccountCode.Text))
                {
                    MessageBox.Show("账套编码不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txtSiteName.Text))
                {
                    MessageBox.Show("工厂名称不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("地址不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(comSiteType.Text))
                {
                    MessageBox.Show("工厂类型不可以为空！");
                    return;
                }
                int outNum = 0;
                bool result = false;
                errorString = string.Empty;
                siteModel = new SiteModel();
                siteModel.AccountCode = txtAccountCode.Text.Trim();
                siteModel.SiteName = txtSiteName.Text.Trim();
                siteModel.SpellCode = txtSpellCode.Text.Trim();
                siteModel.Address = txtAddress.Text.Trim();
                siteModel.LocationID = txtLocationID.Text.Trim();
                if (int.TryParse(txtCapacity.Text, out outNum))
                    siteModel.Capacity = Convert.ToInt32(txtCapacity.Text);
                else
                    siteModel.Capacity = outNum;
                siteModel.SiteType = Convert.ToInt32(comSiteType.SelectedValue);
                //0未选中1选中
                siteModel.SiteType2 = ckSiteType2.Checked == false ? "否" : "是";
                siteModel.IsStop = ckIsStop.Checked == false ? "否" : "是";
                siteModel.UserName = "admin";// PubStaticModel.UserName;
                siteModel.CreateDate = DateTime.Now;
                siteModel.SiteDesc = txtSiteDesc.Text.Trim();

                //如果工厂编码为空的情况下，则是新增工厂，否则修改
                if (string.IsNullOrEmpty(txtSiteID.Text))
                {
                    result = siteModel.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    siteModel.SiteCodeID = Convert.ToInt32(txtSiteID.Text.Trim());
                    foreach (DataGridViewRow dgvRow in dgvStite.Rows)
                    {
                        if (dgvRow.Cells["IsStop"].Value + "" == "否" && siteModel.SiteCodeID != Convert.ToInt32(dgvRow.Cells["SiteCodeID"].Value + "") && siteModel.IsStop == "否")
                        {
                            MessageBox.Show("请先停用其他工厂，在启用此工厂！");
                            return;
                        }
                    }
                    result = siteModel.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, btnCancel, btnSave, txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, ckIsStop, ckSiteType2, txtCapacity, txtLocationID, comSiteType, btnCodingRules);
                    CommUtility.ClearControl(txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, txtCapacity, txtLocationID);
                    btnAdd.Enabled = true;
                    DataTable dt = siteModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvStite.DataSource = dt;
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
            CommUtility.SetEnabled(false, btnCancel, btnSave, txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, ckIsStop, ckSiteType2, txtCapacity, txtLocationID, comSiteType, btnCodingRules);
            CommUtility.ClearControl(txtSiteID, txtSiteName, txtSpellCode, txtAddress, txtSpellCode, txtSiteDesc, txtAccountCode, txtCapacity, txtLocationID);
            btnAdd.Enabled = true; ckIsStop.Checked = false; ckSiteType2.Checked = false;
            comSiteType.SelectedIndex = 0;
        }
        private void dgvStite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDgvValue();
        }
        private void dgvStite_SelectionChanged(object sender, EventArgs e)
        {
            GetDgvValue();
        }

        private void txtSiteName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtSiteName.Text);
        }
        #endregion

        #region 窗体方法
        private void GetDgvValue()
        {
            try
            {
                int rowIndex = dgvStite.CurrentRow.Index;
                if (rowIndex < 0) return;
                btnUpdate.Enabled = true;
                txtAccountCode.Text = dgvStite.CurrentRow.Cells["AccountCode"].Value + "";
                txtSiteName.Text = dgvStite.CurrentRow.Cells["SiteName"].Value + "";
                txtSpellCode.Text = dgvStite.CurrentRow.Cells["SpellCode"].Value + "";
                txtAddress.Text = dgvStite.CurrentRow.Cells["Address"].Value + "";
                txtLocationID.Text = dgvStite.CurrentRow.Cells["LocationID"].Value + "";
                txtCapacity.Text = dgvStite.CurrentRow.Cells["Capacity"].Value + "";
                comSiteType.SelectedValue = dgvStite.CurrentRow.Cells["SiteType"].Value + "";
                ////0未选中1选中
                ckSiteType2.Checked = dgvStite.CurrentRow.Cells["SiteType2"].Value + "" == "是" ? true : false;
                ckIsStop.Checked = dgvStite.CurrentRow.Cells["IsStop"].Value + "" == "是" ? true : false;
                txtSiteDesc.Text = dgvStite.CurrentRow.Cells["SiteDesc"].Value + "";
                txtSiteID.Text = dgvStite.CurrentRow.Cells["SiteCodeID"].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCodingRules_Click(object sender, EventArgs e)
        {
            int sitie = 0;
            if (!string.IsNullOrEmpty(txtSiteID.Text.Trim()))
            {
                sitie = Convert.ToInt32(txtSiteID.Text.Trim());
            }
            FrmCodingRules frmCoding = new FrmCodingRules(sitie);
            frmCoding.ShowDialog();
        }
        #endregion

    }
}
