using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Client.UI.PubHelper
{
    public class PubStaticModel
    {
        private static string connectionStr;
        /// <summary>
        /// 链接数据库字符串
        /// </summary>
        public static string ConnectionStr
        {
            get { return connectionStr; }
            set { connectionStr = value; }
        }

        private static string userName;
        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName
        {
            get { return PubStaticModel.userName; }
            set { PubStaticModel.userName = value; }
        }

        private static string stiteName;
        /// <summary>
        /// 工厂名称
        /// </summary>
        public static string StiteName
        {
            get { return PubStaticModel.StiteName; }
            set { PubStaticModel.StiteName = value; }
        }

        private static string accountCode;
        /// <summary>
        /// 账套编码
        /// </summary>
        public static string AccountCode
        {
            get { return PubStaticModel.accountCode; }
            set { PubStaticModel.accountCode = value; }
        }
        private static int stiteID;
        /// <summary>
        /// 工厂代码（为了区别后期多工厂）
        /// </summary>
        public static int StiteID
        {
            get { return PubStaticModel.stiteID; }
            set { PubStaticModel.stiteID = value; }
        }


    }
}
