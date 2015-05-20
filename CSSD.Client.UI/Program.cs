using CSSD.Client.UI.ManagerBench;
using CSSD.Client.UI.Routine_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD.Client.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string urlWeb = Application.StartupPath + "\\FormConfig.ini";
            StreamReader reader = new StreamReader(urlWeb, System.Text.Encoding.Default);
            string formType = reader.ReadLine();
            switch (formType)
            {
                //消耗点单一验收入库
                case "FrmMain":
                    Application.Run(new FrmMain());
                    break;
            }
        }
    }
}
