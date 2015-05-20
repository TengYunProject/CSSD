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
    public class CustGroupModel : IDelayedupdate
    {
        #region 字段
        private int custGroupID;

        public int CustGroupID
        {
            get { return custGroupID; }
            set { custGroupID = value; }
        }
        private string custDesc;

        public string CustDesc
        {
            get { return custDesc; }
            set { custDesc = value; }
        }
        private int costModeliID;

        public int CostModeliID
        {
            get { return costModeliID; }
            set { costModeliID = value; }
        }
        private string custGroupName;

        public string CustGroupName
        {
            get { return custGroupName; }
            set { custGroupName = value; }
        }
        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }
        private string accountCode;

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
            string sqlStr = "insert into CustGroup(" +
                "CustDesc,CostModeliID,CustGroupName,AccountCode,SpellCode" +
            ")values(@CustDesc,@CostModeliID,@CustGroupName,@AccountCode,@SpellCode);";
            SqlParameter[] parameters = {   new SqlParameter("@CustDesc", CustDesc),
                                            new SqlParameter("@CostModeliID", CostModeliID),
                                            new SqlParameter("@CustGroupName", CustGroupName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<CustGroupModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select a.*,b.CostName from CustGroup a left join CostModel b on a.CostModeliID=b.CostModelID ";

            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public System.Data.DataTable DelayedSelectAllToTableByID(out string errorString, string connectionString, int? costID)
        {
            errorString = string.Empty;
            string sqlStr = "select a.*,b.CostName from CustGroup a left join CostModel b on a.CostModeliID=b.CostModelID where 1=1 ";
            if (costID != null)
                sqlStr += " and a.CostModeliID='" + costID + "'";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update CustGroup set " +
                "CustDesc=@CustDesc,CostModeliID=@CostModeliID,CustGroupName=@CustGroupName,AccountCode=@AccountCode,SpellCode=@SpellCode "
                + " where CustGroupID=@CustGroupID;";
            SqlParameter[] parameters = {   new SqlParameter("@CustGroupID", CustGroupID),
                                            new SqlParameter("@CustDesc", CustDesc),
                                            new SqlParameter("@CostModeliID", CostModeliID),
                                            new SqlParameter("@CustGroupName", CustGroupName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<CustGroupModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
