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
    public partial class FrmPrinter : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 打印机实体
        /// </summary>
        PrinterModel printerModel;
        /// <summary>
        /// 错误消息
        /// </summary>
        string errorString = string.Empty;

        public FrmPrinter()
        {
            InitializeComponent();
        }

        #region 事件

        private void FrmPrinter_Load(object sender, EventArgs e)
        {
            try
            {
                printerModel = new PrinterModel();
                DataTable dt = printerModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                dgvPrinter.DataSource = dt;
                //绑定工作台类型
                ArrayList mylist = CommUtility.GetAllDefinitionDDLById("Printer");
                if (mylist == null || mylist.Count <= 0)
                {
                    MessageBox.Show("未找到工作台类型，请在配置文件中添加！");
                    return;
                }
                else
                {
                    comPrinterType.DataSource = mylist;
                    comPrinterType.DisplayMember = "Value";
                    comPrinterType.ValueMember = "Key";
                }
                errorString = string.Empty;
                StationModel station = new StationModel();
                DataTable dtStation = station.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                if (dtStation == null || dtStation.Rows.Count <= 0)
                {
                    MessageBox.Show("请先创建工作台！");
                    return;
                }
                else
                {
                    ArrayList listStation = new ArrayList();
                    foreach (DataRow row in dtStation.Rows)
                    {
                        listStation.Add(new DictionaryEntry(row["StationName"] + "", row["StationID"] + ""));
                    }
                    //绑定工厂类型控件
                    comStation.DataSource = listStation;
                    comStation.DisplayMember = "Key";
                    comStation.ValueMember = "Value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, txtPrinterCode, btnSave, btnCancel, comPrinterType, txtPrinterName, txtSpellCode, txtPrinterIP, comStation, txtPrinterDesc);
            CommUtility.ClearControl(txtPrinterCode, txtPrinterName, txtSpellCode, txtPrinterIP, txtPrinterDesc, txtPrinterID);
            btnAdd.Enabled = false;
            comPrinterType.SelectedIndex = 0;
            comStation.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CommUtility.SetEnabled(true, txtPrinterCode, btnSave, btnCancel, comPrinterType, txtPrinterName, txtSpellCode, txtPrinterIP, comStation, txtPrinterDesc);
            CommUtility.SetEnabled(false, btnAdd, btnUpdate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (string.IsNullOrEmpty(txtPrinterName.Text.Trim()))
                {
                    MessageBox.Show("工作台名称不可以为空！");
                    return;
                }
                errorString = string.Empty;
                printerModel = new PrinterModel();
                printerModel.PrinterCode = txtPrinterCode.Text.Trim();
                printerModel.PrinterGroupID = Convert.ToInt32(comPrinterType.SelectedValue);
                printerModel.PrinterGroupName = comPrinterType.Text;
                printerModel.PrinterName = txtPrinterName.Text.Trim();
                printerModel.SpellCode = txtSpellCode.Text.Trim();
                printerModel.StationID = Convert.ToInt32(comStation.SelectedValue);
                printerModel.StationName = comStation.Text;
                printerModel.PrinterDesc = txtPrinterDesc.Text;
                printerModel.IPAddress = txtPrinterIP.Text.Trim();
                printerModel.AccountCode = "";//PubStaticModel.AccountCode;
                if (string.IsNullOrEmpty(txtPrinterID.Text.Trim()))
                {
                    result = printerModel.DelayedInsert(out errorString, PubStaticModel.ConnectionStr);
                }
                else
                {
                    printerModel.PrinterID = Convert.ToInt32(txtPrinterID.Text.Trim());
                    result = printerModel.DelayedUpdate(out errorString, PubStaticModel.ConnectionStr);
                }

                if (result)
                {
                    MessageBox.Show("保存成功！");
                    CommUtility.SetEnabled(false, txtPrinterCode, btnSave, btnCancel, comPrinterType, txtPrinterName, txtSpellCode, txtPrinterIP, comStation, txtPrinterDesc);
                    btnAdd.Enabled = true;
                    DataTable dtPrinter = printerModel.DelayedSelectAllToTable(out errorString, PubStaticModel.ConnectionStr);
                    dgvPrinter.DataSource = dtPrinter;
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
            CommUtility.SetEnabled(false, txtPrinterCode, btnSave, btnCancel, comPrinterType, txtPrinterName, txtSpellCode, txtPrinterIP, comStation, txtPrinterDesc);
            CommUtility.ClearControl(txtPrinterCode, txtPrinterName, txtSpellCode, txtPrinterIP, txtPrinterDesc, txtPrinterID);
            btnAdd.Enabled = true;
            comPrinterType.SelectedIndex = 0;
            comStation.SelectedIndex = 0;
        }

        private void txtPrinterName_TextChanged(object sender, EventArgs e)
        {
            txtSpellCode.Text = CommUtility.GetSpellCode(txtPrinterName.Text);
        }

        private void dgvPrinter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetPrinterValue();
        }

        private void dgvPrinter_SelectionChanged(object sender, EventArgs e)
        {
            GetPrinterValue();
        }

        #endregion

        #region 内部方法

        private void GetPrinterValue()
        {
            try
            {
                int rowIndex = dgvPrinter.CurrentRow.Index;
                if (rowIndex < 0) return;
                txtPrinterCode.Text = dgvPrinter.CurrentRow.Cells["PrinterCode"].Value + "";
                comPrinterType.Text = dgvPrinter.CurrentRow.Cells["PrinterGroupName"].Value + "";
                txtPrinterName.Text = dgvPrinter.CurrentRow.Cells["PrinterName"].Value + "";
                txtSpellCode.Text = dgvPrinter.CurrentRow.Cells["SpellCode"].Value + "";
                comStation.Text = dgvPrinter.CurrentRow.Cells["StationName"].Value + "";
                txtPrinterDesc.Text = dgvPrinter.CurrentRow.Cells["PrinterDesc"].Value + "";
                txtPrinterID.Text = dgvPrinter.CurrentRow.Cells["PrinterID"].Value + "";
                txtPrinterIP.Text = dgvPrinter.CurrentRow.Cells["IPAddress"].Value + "";
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
