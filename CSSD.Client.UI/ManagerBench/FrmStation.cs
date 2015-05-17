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
    public partial class FrmStation : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;
        //工作台实体
        StationModel stationModel;
        public FrmStation()
        {
            InitializeComponent();
        }

        #region 事件
        private void FrmStation_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定工作台列表
                stationModel = new StationModel();
                DataTable dt = stationModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvStation.DataSource = dt;
                //绑定工作台类型
                ArrayList mylist = CommUtility.GetAllDefinitionDDLById("Station");
                if (mylist == null || mylist.Count <= 0)
                {
                    MessageBox.Show("未找到工作台类型，请在配置文件中添加！");
                    return;
                }
                else
                {
                    comStationType.DataSource = mylist;
                    comStationType.DisplayMember = "Value";
                    comStationType.ValueMember = "Key";
                }
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnCan, btnCan, comStationType, txtStationName, txtSpellCode, txtIP, txtDesc);
            CommUtility.ClearControl(txtStationName, txtSpellCode, txtIP, txtDesc, txtStationID);
            btnAdd.Enabled = false;
            comStationType.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnCan, btnCan, comStationType, txtStationName, txtSpellCode, txtIP, txtDesc);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (string.IsNullOrEmpty(txtStationName.Text.Trim()))
                {
                    MessageBox.Show("工作台名称不可以为空！");
                    return;
                }
                errorString = string.Empty;
                stationModel = new StationModel();
                stationModel.StationName = txtStationName.Text.Trim();
                stationModel.SpellCode = txtSpellCode.Text.Trim();
                stationModel.IPAddress = txtIP.Text.Trim();
                stationModel.StationDesc = txtDesc.Text;
                stationModel.StationGroupID = Convert.ToInt32(comStationType.SelectedValue + "");
                stationModel.StationGroupName = comStationType.Text;
                if (string.IsNullOrEmpty(txtStationID.Text.Trim()))
                {
                    result = stationModel.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    stationModel.StationID = Convert.ToInt32(txtStationID.Text);
                    result = stationModel.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, btnCan, btnCan, comStationType, txtStationName, txtSpellCode, txtIP, txtDesc);
                    btnAdd.Enabled = true;
                    DataTable dtSiteTypes = stationModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvStation.DataSource = dtSiteTypes;
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

        private void btnCan_Click(object sender, EventArgs e)
        {
            try
            {
                CommUtility.SetEnabled(false, btnCan, btnCan, comStationType, txtStationName, txtSpellCode, txtIP, txtDesc);
                CommUtility.ClearControl(txtStationName, txtSpellCode, txtIP, txtDesc, txtStationID);
                btnAdd.Enabled = true;
                comStationType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDgvValue();
        }

        private void dgvStation_SelectionChanged(object sender, EventArgs e)
        {
            GetDgvValue();
        }
        private void txtStationName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtStationName.Text);
        }
        #endregion

        #region 内部方法

        private void GetDgvValue()
        {
            try
            {
                int rowIndex = dgvStation.CurrentRow.Index;
                if (rowIndex < 0) return;
                txtStationID.Text = dgvStation.CurrentRow.Cells["StationID"].Value + "";
                txtStationName.Text = dgvStation.CurrentRow.Cells["StationName"].Value + "";
                txtSpellCode.Text = dgvStation.CurrentRow.Cells["SpellCode"].Value + "";
                txtIP.Text = dgvStation.CurrentRow.Cells["IPAddress"].Value + "";
                txtDesc.Text = dgvStation.CurrentRow.Cells["StationDesc"].Value + "";
                comStationType.Text = dgvStation.CurrentRow.Cells["StationGroupName"].Value + "";
                btnUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }
}
