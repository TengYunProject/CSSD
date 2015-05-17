using CSSD.Server.BaseClass;
using CSSD.Server.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.ManagerBenchModel
{
    public class SiteModel : IDelayedupdate
    {
        #region 字段
        private int siteCodeID;
        /// <summary>
        /// 工厂编码
        /// </summary>
        public int SiteCodeID
        {
            get { return siteCodeID; }
            set { siteCodeID = value; }
        }

        private string locationID;
        /// <summary>
        /// 右臂那
        /// </summary>
        public string LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        private string address;
        /// <summary>
        /// 工厂地址
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int siteType;
        /// <summary>
        /// 工厂类别
        /// </summary>
        public int SiteType
        {
            get { return siteType; }
            set { siteType = value; }
        }

        private string siteType2;
        /// <summary>
        /// 此工厂支持单厂还是多厂
        /// </summary>
        public string SiteType2
        {
            get { return siteType2; }
            set { siteType2 = value; }
        }

        private int capacity;
        /// <summary>
        /// 产能
        /// </summary>
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private string siteName;
        /// <summary>
        /// 名称
        /// </summary>
        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; }
        }

        private string siteDesc;
        /// <summary>
        /// 描述
        /// </summary>
        public string SiteDesc
        {
            get { return siteDesc; }
            set { siteDesc = value; }
        }

        private string spellCode;
        /// <summary>
        /// 助记码
        /// </summary>
        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }

        private string userName;
        /// <summary>
        /// 创建人
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private DateTime createDate;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private string isStop;
        /// <summary>
        /// 是否停用
        /// </summary>
        public string IsStop
        {
            get { return isStop; }
            set { isStop = value; }
        }
        private string accountCode;
        /// <summary>
        /// 账套
        /// </summary>
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        #endregion

        #region 方法
        public bool DelayedDelete(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public bool DelayedInsert(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "insert into Site(" +
                "LocationID,Address,SiteType,SiteType2,Capacity,SiteName,SiteDesc,SpellCode,AccountCode,UserName,CreateDate,IsStop" +
            ")values(@LocationID,@Address,@SiteType,@SiteType2,@Capacity,@SiteName,@SiteDesc,@SpellCode,@AccountCode,@UserName,@CreateDate,@IsStop);";
            SqlParameter[] parameters = {   new SqlParameter("@LocationID",LocationID ),
                                            new SqlParameter("@Address",Address ),
                                            new SqlParameter("@SiteType",SiteType ),
                                            new SqlParameter("@SiteType2",SiteType2 ),
                                            new SqlParameter("@Capacity",Capacity ),
                                            new SqlParameter("@SiteName",SiteName ),
                                            new SqlParameter("@SiteDesc",siteDesc ),
                                            new SqlParameter("@SpellCode",SpellCode ),
                                            new SqlParameter("@AccountCode",AccountCode ),
                                            new SqlParameter("@UserName",UserName ),
                                            new SqlParameter("@CreateDate",CreateDate ),
                                            new SqlParameter("@IsStop",IsStop )};
            int result = SqlDatabaseManager<SiteModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from site";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update Site set " +
                "LocationID=@LocationID,Address=@Address,SiteType=@SiteType,SiteType2=@SiteType2" +
            ",Capacity=@Capacity,SiteName=@SiteName,SiteDesc=@SiteDesc,SpellCode=@SpellCode" +
            ",AccountCode=@AccountCode,UserName=@UserName,CreateDate=@CreateDate,IsStop=@IsStop" +
            " where SiteCodeID=@SiteCodeID;";
            SqlParameter[] parameters = {   new SqlParameter("@SiteCodeID",SiteCodeID ),
                                            new SqlParameter("@LocationID",LocationID ),
                                            new SqlParameter("@Address",Address ),
                                            new SqlParameter("@SiteType",SiteType ),
                                            new SqlParameter("@SiteType2",SiteType2 ),
                                            new SqlParameter("@Capacity",Capacity ),
                                            new SqlParameter("@SiteName",SiteName ),
                                            new SqlParameter("@SiteDesc",siteDesc ),
                                             new SqlParameter("@SpellCode",SpellCode ),
                                            new SqlParameter("@AccountCode",AccountCode ),
                                            new SqlParameter("@UserName",UserName ),
                                            new SqlParameter("@CreateDate",CreateDate ),
                                            new SqlParameter("@IsStop",IsStop )};
            int result = SqlDatabaseManager<SiteModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
