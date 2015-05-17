using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CSSD.Client.UI.PubHelper
{
    public class ReadFile
    {
        public ReadFile()
        {
            PubStaticModel.ConnectionStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString();
        }
    }
}
