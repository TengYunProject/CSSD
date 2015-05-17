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
    public partial class FrmEquipment : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设备实体
        /// </summary>
        MachineModel machine;
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;

        #region 窗体事件
        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                machine = new MachineModel();
                //绑定机器列表信息
                DataTable dtMachine = machine.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvMain.DataSource = dtMachine;

                //绑定机器类型
                ArrayList listMachineType = CommUtility.GetAllDefinitionDDLById("EquipmentMain");
                if (listMachineType == null || listMachineType.Count <= 0)
                {
                    MessageBox.Show("机器类型为空，请在配置文件中添加！");
                    return;
                }
                else
                {
                    comMachineType.DataSource = listMachineType;
                    comMachineType.DisplayMember = "Value";
                    comMachineType.ValueMember = "Key";
                }
                //绑定状态类型
                ArrayList listType = CommUtility.GetAllDefinitionDDLById("MachineStatus");
                if (listType == null || listType.Count <= 0)
                {
                    MessageBox.Show("状态类型为空，请在配置文件中添加！");
                    return;
                }
                else
                {
                    cmMainType.DataSource = listType;
                    cmMainType.DisplayMember = "Value";
                    cmMainType.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 主设备处理事件

        private void btnMainAdd_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnMainCancel, btnMainSave, comMachineType, txtMachineName, txtMachineSpellCode, txtMachineCode, cmMainType, txtMachineDesc);
            CommUtility.ClearControl(txtMachineName, txtMachineID, txtMachineSpellCode, txtMachineCode, txtMachineDesc);
            btnMainAdd.Enabled = false;
            comMachineType.SelectedIndex = 0;
            cmMainType.SelectedIndex = 0;
        }

        private void btnMainUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, btnMainCancel, btnMainSave, comMachineType, txtMachineName, txtMachineSpellCode, txtMachineCode, cmMainType, txtMachineDesc);
            CommUtility.SetEnabled(false, btnMainAdd, btnMainUpdate);
        }

        private void btnMainSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (string.IsNullOrEmpty(txtMachineName.Text.Trim()))
                {
                    MessageBox.Show("机器名称不可以为空！");
                    return;
                }
                machine = new MachineModel();
                machine.MachineIDGroupID = Convert.ToInt32(comMachineType.SelectedValue + "");
                machine.MachineIDGroupName = comMachineType.Text;
                machine.MachineName = txtMachineName.Text.Trim();
                machine.SpellCode = txtMachineSpellCode.Text.Trim();
                machine.MachineOriginallyID = txtMachineCode.Text.Trim();
                machine.MachineStatusID = Convert.ToInt32(cmMainType.SelectedValue + "");
                machine.MachineStatusName = cmMainType.Text;
                machine.MachineDesc = txtMachineDesc.Text;
                machine.AccountCode = "";//PubStaticModel.AccountCode;
                if (string.IsNullOrEmpty(txtMachineID.Text.Trim()))
                {
                    result = machine.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    machine.MachineID = Convert.ToInt32(txtMachineID.Text.Trim());
                    result = machine.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }
                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, btnMainCancel, btnMainSave, comMachineType, txtMachineName, txtMachineSpellCode, txtMachineCode, cmMainType, txtMachineDesc);
                    btnMainAdd.Enabled = true;
                    DataTable dtSiteTypes = machine.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvMain.DataSource = dtSiteTypes;
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

        private void btnMainCancel_Click(object sender, EventArgs e)
        {
            try
            {
                CommUtility.SetEnabled(false, btnMainCancel, btnMainSave, comMachineType, txtMachineName, txtMachineSpellCode, txtMachineCode, cmMainType, txtMachineDesc);
                CommUtility.ClearControl(txtMachineID, txtMachineName, txtMachineSpellCode, txtMachineCode, txtMachineDesc);
                btnMainAdd.Enabled = true;
                comMachineType.SelectedIndex = 0;
                cmMainType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMachineName_TextChanged(object sender, EventArgs e)
        {
            txtMachineSpellCode.Text = CommUtility.GetSpellCode(txtMachineName.Text);
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            GetDGVMainValue();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDGVMainValue();
        }
        private void GetDGVMainValue()
        {
            try
            {
                int rowIndex = dgvMain.CurrentRow.Index;
                if (rowIndex < 0) return;
                txtMachineID.Text = dgvMain.CurrentRow.Cells["MachineID"].Value + "";
                comMachineType.Text = dgvMain.CurrentRow.Cells["MachineIDGroupName"].Value + "";
                cmMainType.Text = dgvMain.CurrentRow.Cells["MachineStatusName"].Value + "";
                comMachineType.Text = dgvMain.CurrentRow.Cells["MachineIDGroupName"].Value + "";
                txtMachineName.Text = dgvMain.CurrentRow.Cells["MachineName"].Value + "";
                txtMachineSpellCode.Text = dgvMain.CurrentRow.Cells["SpellCode"].Value + "";
                txtMachineCode.Text = dgvMain.CurrentRow.Cells["MachineOriginallyID"].Value + "";
                cmMainType.Text = dgvMain.CurrentRow.Cells["MachineStatusName"].Value + "";
                txtMachineDesc.Text = dgvMain.CurrentRow.Cells["MachineDesc"].Value + "";
                btnMainUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
