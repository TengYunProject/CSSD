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
    public partial class FrmCodingRules : Form
    {
        string errorString = string.Empty;
        CodingRulesModel codingModel;
        int btnType = 0;//1为新增，2为修改
        int _StiteID = 0;//工厂编码
        public FrmCodingRules(int stiteID)
        {
            InitializeComponent();
            if (stiteID == 0)
                this._StiteID = PubStaticModel.StiteID;
            else
                this._StiteID = stiteID;
        }

        #region 窗体事件
        private void FrmCodingRules_Load(object sender, EventArgs e)
        {
            try
            {
                codingModel = new CodingRulesModel();
                DataTable dt = codingModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvCodingRules.DataSource = dt;
                ArrayList mylist = CommUtility.GetAllDefinitionDDLById("CodingRuless");
                if (mylist == null || mylist.Count <= 0)
                {
                    MessageBox.Show("未找到编码类型，请在配置文件中添加！");
                    return;
                }
                else
                {
                    cmbRulesType.DataSource = mylist;
                    cmbRulesType.DisplayMember = "Value";
                    cmbRulesType.ValueMember = "Key";
                }
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            CommUtility.ClearControl(txtCodingRulesIncreasing, txtCodingRulesLength, txtCodingRulesValue);
            btnType = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            btnType = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbRulesType.Text))
                {
                    MessageBox.Show("编码类型不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txtCodingRulesValue.Text))
                {
                    MessageBox.Show("预设值不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txtCodingRulesIncreasing.Text))
                {
                    MessageBox.Show("递增值不可以为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txtCodingRulesLength.Text))
                {
                    MessageBox.Show("长度值不可以为空！");
                    return;
                }
                bool result = false;
                errorString = string.Empty;
                codingModel = new CodingRulesModel();
                codingModel.CodingRulesID = Convert.ToInt32(cmbRulesType.SelectedValue + "");
                codingModel.CodingRulesType = cmbRulesType.Text;
                codingModel.CodingRulesValue = txtCodingRulesValue.Text.Trim();
                codingModel.CodingRulesIncreasing = txtCodingRulesIncreasing.Text.Trim();
                codingModel.AccountCode = PubStaticModel.AccountCode + "";
                codingModel.SiteID = _StiteID;
                codingModel.CodingRulesLength = Convert.ToInt32(txtCodingRulesLength.Text.Trim());
                DataTable dtByID = codingModel.DelayedSelectByID(out errorString, PubStaticModel.ConnectionStr, Convert.ToInt32(codingModel.CodingRulesID));
                //如果是新增状态，则不可以重复添加
                if (btnType == 1)
                {
                    if (dtByID == null || dtByID.Rows.Count <= 0)
                    {
                        codingModel.CurrentCode = 1;
                    }
                    else
                    {
                        MessageBox.Show("已存在此编码规则！");
                        return;
                    }
                }
                else
                {
                    codingModel.CurrentCode = Convert.ToInt32(dgvCodingRules.CurrentRow.Cells["CurrentCode"].Value + "");
                }
                if (btnType == 1)
                    result = codingModel.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                else
                    result = codingModel.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    DataTable dt = codingModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvCodingRules.DataSource = dt;
                    EnableControl(false);
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
            EnableControl(false);
        }
        private void dgvCodingRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDgvValue();
        }

        private void dgvCodingRules_SelectionChanged(object sender, EventArgs e)
        {
            GetDgvValue();
        }
        #endregion

        #region 内部方法
        /// <summary>
        /// 设置控件状态
        /// </summary>
        /// <param name="bo"></param>
        private void EnableControl(bool bo)
        {
            if (bo)
            {
                CommUtility.SetEnabled(bo, txtCodingRulesIncreasing, txtCodingRulesLength, txtCodingRulesValue, btnCancel, btnSave, cmbRulesType);
                CommUtility.SetEnabled(false, btnAdd);
            }
            else
            {
                CommUtility.SetEnabled(bo, txtCodingRulesIncreasing, txtCodingRulesLength, txtCodingRulesValue, btnCancel, btnSave, cmbRulesType);
                CommUtility.SetEnabled(true, btnAdd);
            }
        }
        private void GetDgvValue()
        {
            try
            {
                int rowIndex = dgvCodingRules.CurrentRow.Index;
                if (rowIndex < 0) return;
                btnUpdate.Enabled = true;
                cmbRulesType.Text = dgvCodingRules.CurrentRow.Cells["CodingRulesType"].Value + "";
                txtCodingRulesValue.Text = dgvCodingRules.CurrentRow.Cells["CodingRulesValue"].Value + "";
                txtCodingRulesLength.Text = dgvCodingRules.CurrentRow.Cells["CodingRulesLength"].Value + "";
                txtCodingRulesIncreasing.Text = dgvCodingRules.CurrentRow.Cells["CodingRulesIncreasing"].Value + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
