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
    public partial class FrmSiteType : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 工厂类型实体
        /// </summary>
        SiteTypeModel siteTypeModel = new SiteTypeModel();
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;
        public FrmSiteType()
        {
            InitializeComponent();
        }
        #region 窗体事件

        private void FrmSiteType_Load(object sender, EventArgs e)
        {
            try
            {
                siteTypeModel = new SiteTypeModel();
                //获取工厂类型数据绑定表格
                DataTable dtSiteTypes = siteTypeModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                if (dtSiteTypes != null && dtSiteTypes.Rows.Count > 0)
                    dgvStiteType.DataSource = dtSiteTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设置控件是否可用状态
            CommUtility.SetEnabled(true, txtTypeName, txtTypeDesc, btnSave, btnCancel, txtSpellCode);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
            CommUtility.ClearControl(txtSiteTypeID, txtSpellCode, txtTypeDesc, txtTypeName);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, txtTypeName, txtTypeDesc, btnSave, btnCancel, txtSpellCode);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTypeName.Text))
                {
                    MessageBox.Show("类别名称不可以为空！");
                    return;
                }
                bool result = false;
                siteTypeModel = new SiteTypeModel();
                siteTypeModel.TypeName = txtTypeName.Text.Trim();
                siteTypeModel.SpellCode = txtSpellCode.Text.Trim();
                siteTypeModel.TypeDesc = txtTypeDesc.Text.Trim();
                if (string.IsNullOrEmpty(txtSiteTypeID.Text))
                {
                    result = siteTypeModel.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    siteTypeModel.SiteTypeID = Convert.ToInt32(txtSiteTypeID.Text.Trim());
                    result = siteTypeModel.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, txtSpellCode, txtTypeName, txtTypeDesc, btnSave, btnCancel);
                    btnAdd.Enabled = true;
                    DataTable dtSiteTypes = siteTypeModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvStiteType.DataSource = dtSiteTypes;
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
            //清空控件
            CommUtility.ClearControl(txtSpellCode, txtTypeName, txtTypeDesc, txtSiteTypeID);
            //设置控件状态不可用
            CommUtility.SetEnabled(false, btnCancel, btnSave, btnUpdate, txtSpellCode, txtTypeName, txtTypeDesc, txtSiteTypeID);
            btnAdd.Enabled = true;
        }
        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtTypeName.Text);
        }

        private void dgvStiteType_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvStiteType.CurrentRow.Index;
                if (rowIndex < 0) return;
                txtSiteTypeID.Text = dgvStiteType.CurrentRow.Cells["SiteTypeID"].Value + "";
                txtSpellCode.Text = dgvStiteType.CurrentRow.Cells["SpellCode"].Value + "";
                txtTypeName.Text = dgvStiteType.CurrentRow.Cells["TypeName"].Value + "";
                txtTypeDesc.Text = dgvStiteType.CurrentRow.Cells["TypeDesc"].Value + "";
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
