using CSSD.Server.BaseClass;
using CSSD.Server.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.ManagerBenchModel
{
    public class StationModel : IDelayedupdate
    {

        #region 字段
        private int stationID;

        public int StationID
        {
            get { return stationID; }
            set { stationID = value; }
        }
        private string stationName;

        public string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }
        private int stationGroupID;

        public int StationGroupID
        {
            get { return stationGroupID; }
            set { stationGroupID = value; }
        }

        private string stationGroupName;

        public string StationGroupName
        {
            get { return stationGroupName; }
            set { stationGroupName = value; }
        }

        private string stationDesc;

        public string StationDesc
        {
            get { return stationDesc; }
            set { stationDesc = value; }
        }
        private int logonID;

        public int LogonID
        {
            get { return logonID; }
            set { logonID = value; }
        }
        private string iPAddress;

        public string IPAddress
        {
            get { return iPAddress; }
            set { iPAddress = value; }
        }
        private int printerID;

        public int PrinterID
        {
            get { return printerID; }
            set { printerID = value; }
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
            string sqlStr = "insert into Station(" +
                "StationGroupID,StationName,StationDesc,LogonID,IPAddress,PrinterID,AccountCode,SpellCode" +
            ")values(@StationGroupID,@StationName,@StationDesc,@LogonID,@IPAddress,@PrinterID,@AccountCode,@SpellCode);";
            SqlParameter[] parameters = {   new SqlParameter("@StationGroupID", StationGroupID),
                                            new SqlParameter("@StationName", StationName),
                                            new SqlParameter("@StationDesc", StationDesc),

                                            new SqlParameter("@LogonID", LogonID),
                                            new SqlParameter("@IPAddress", IPAddress),
                                            new SqlParameter("@PrinterID", PrinterID),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)
                                        };
            int result = SqlDatabaseManager<StationModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from Station";
            System.Data.DataTable dt = SqlDatabaseManager<System.Data.DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "Update Station set" +
                "StationGroupID=@StationGroupID,StationName=@StationName,StationDesc=@StationDesc,LogonID=@LogonID,IPAddress=@IPAddress,PrinterID=@PrinterID,AccountCode=@AccountCode,SpellCode=@SpellCode;";
            SqlParameter[] parameters = {   new SqlParameter("@StationGroupID", StationGroupID),
                                            new SqlParameter("@StationName", StationName),
                                            new SqlParameter("@StationDesc", StationDesc),
                                            new SqlParameter("@LogonID", LogonID),
                                            new SqlParameter("@IPAddress", IPAddress),
                                            new SqlParameter("@PrinterID", PrinterID),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)
                                        };
            int result = SqlDatabaseManager<StationModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
