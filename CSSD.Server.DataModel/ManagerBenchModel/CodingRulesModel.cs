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
    public class CodingRulesModel : IDelayedupdate
    {
        #region 字段
        private int codingRulesID;

        public int CodingRulesID
        {
            get { return codingRulesID; }
            set { codingRulesID = value; }
        }

        private string codingRulesType;

        public string CodingRulesType
        {
            get { return codingRulesType; }
            set { codingRulesType = value; }
        }

        private string codingRulesValue;

        public string CodingRulesValue
        {
            get { return codingRulesValue; }
            set { codingRulesValue = value; }
        }

        private string codingRulesIncreasing;

        public string CodingRulesIncreasing
        {
            get { return codingRulesIncreasing; }
            set { codingRulesIncreasing = value; }
        }

        private int codingRulesLength;

        public int CodingRulesLength
        {
            get { return codingRulesLength; }
            set { codingRulesLength = value; }
        }

        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private int siteID;

        public int SiteID
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private int currentCode;

        public int CurrentCode
        {
            get { return currentCode; }
            set { currentCode = value; }
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
            string sqlStr = "insert into CodingRules(" +
                "CodingRulesID,CodingRulesType,CodingRulesValue,CodingRulesIncreasing," +
            "CodingRulesLength,AccountCode,SiteID,CurrentCode)values(@CodingRulesID,@CodingRulesType,@CodingRulesValue,@CodingRulesIncreasing," +
            "@CodingRulesLength,@AccountCode,@SiteID,@CurrentCode);";
            SqlParameter[] parameters = {   new SqlParameter("@CodingRulesID", CodingRulesID),
                                            new SqlParameter("@CodingRulesType", CodingRulesType),
                                             new SqlParameter("@CodingRulesValue", CodingRulesValue),
                                            new SqlParameter("@CodingRulesIncreasing", CodingRulesIncreasing),
                                             new SqlParameter("@CodingRulesLength", CodingRulesLength),
                                            new SqlParameter("@AccountCode", AccountCode),
                                             new SqlParameter("@CurrentCode", CurrentCode),
                                            new SqlParameter("@SiteID", SiteID)};
            int result = SqlDatabaseManager<CodingRulesModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from CodingRules";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }
        public System.Data.DataTable DelayedSelectByID(out string errorString, string connectionString, int codingRulesID)
        {
            errorString = string.Empty;
            string sqlStr = "select * from CodingRules where CodingRulesID=" + codingRulesID + "";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update CodingRules set " +
                "CodingRulesID=@CodingRulesID,CodingRulesType=@CodingRulesType,CodingRulesValue=@CodingRulesValue,CodingRulesIncreasing=@CodingRulesIncreasing," +
            "CodingRulesLength=@CodingRulesLength,AccountCode=@AccountCode,SiteID=@SiteID ,CurrentCode=@CurrentCode where CodingRulesID=@CodingRulesID;";
            SqlParameter[] parameters = {    new SqlParameter("@CodingRulesID", CodingRulesID),
                                             new SqlParameter("@CodingRulesType", CodingRulesType),
                                             new SqlParameter("@CodingRulesValue", CodingRulesValue),
                                             new SqlParameter("@CodingRulesIncreasing", CodingRulesIncreasing),
                                             new SqlParameter("@CodingRulesLength", CodingRulesLength),
                                             new SqlParameter("@AccountCode", AccountCode),
                                             new SqlParameter("@CurrentCode", CurrentCode),
                                             new SqlParameter("@SiteID", SiteID)};
            int result = SqlDatabaseManager<CodingRulesModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        public bool DelayedUpdateCurrentCode(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update CodingRules set " +
                "CurrentCode=@CurrentCode where CodingRulesID=@CodingRulesID;";
            SqlParameter[] parameters = {    new SqlParameter("@CodingRulesID", CodingRulesID),                                             
                                             new SqlParameter("@CurrentCode", CurrentCode)};
            int result = SqlDatabaseManager<CodingRulesModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion
    }
}
