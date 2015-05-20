using CSSD.Client.UI.ManagerBench;
using CSSD.Client.UI.PubHelper;
using CSSD.Client.UI.Routine_Business;
using CSSD.Server.DataModel;
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
using WeifenLuo.WinFormsUI.Docking;

namespace CSSD.Client.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //FrmLogin fogin = new FrmLogin();
            //fogin.ShowDialog();
            ReadFile readSql = new ReadFile();
            string str = CommUtility.GetCodingRules(1001);
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            FrmSiteType frmSiteType = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmSiteType)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSiteType = new FrmSiteType();
            frmSiteType.Show(this.dockPanel1);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            FrmSite frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmSite)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmSite();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            FrmEquipment frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmEquipment)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmEquipment();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            FrmStation frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmStation)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmStation();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            FrmPrinter frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmPrinter)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmPrinter();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCustGroup frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmCustGroup)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmCustGroup();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            FrmCustTable frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmCustTable)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmCustTable();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmUser frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmUser)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmUser();
            frmSite.Show(this.dockPanel1);
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            FrmUserGroup frmSite = null;
            foreach (DockContent frm in dockPanel1.Contents)
            {
                if (frm is FrmUserGroup)
                {
                    frm.Activate();
                    return;
                }
            }
            frmSite = new FrmUserGroup();
            frmSite.Show(this.dockPanel1);
        }
    }
}
