using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD.Client.UI.Routine_Business
{
    public partial class FrmWash : Form
    {
        DevComponents.DotNetBar.ButtonX btnx = new DevComponents.DotNetBar.ButtonX();
        public FrmWash()
        {
            InitializeComponent();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ButtonBackColor(buttonX2, Color.Orange);
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(String));
            DataRow row1 = dt.NewRow();
            row1["Column1"] = "手洗";
            dt.Rows.Add(row1);
            row1 = dt.NewRow();
            row1["Column1"] = "机洗";
            dt.Rows.Add(row1);
            dataGridView1.DataSource = dt;

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("jiqi", typeof(String));
            DataRow row3 = dt1.NewRow();
            row3["jiqi"] = "清洗机A";
            dt1.Rows.Add(row3);
            row3 = dt1.NewRow();
            row3["jiqi"] = "清洗机B";
            dt1.Rows.Add(row3);
            row3 = dt1.NewRow();
            row3["jiqi"] = "清洗机C";
            dt1.Rows.Add(row3);
            row3 = dt1.NewRow();
            row3["jiqi"] = "清洗机D";
            dt1.Rows.Add(row3);
            dataGridView2.DataSource = dt1;
            dataGridView1.Rows[0].Selected = false;
            dataGridView2.Rows[0].Selected = false;
            ribbonClientPanel1.Text = "登录人：张三  清洗方式：机洗  机器：清洗机A";
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            ButtonBackColor(buttonX3, Color.Green);
        }
        private void ButtonBackColor(DevComponents.DotNetBar.ButtonX btn, Color col)
        {
            btn.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            btn.BackColor = col;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ButtonBackColor(buttonX1, Color.Red);
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }
    }
}