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
    public class PrinterModel : IDelayedupdate
    {
        #region 字段
        private int printerID;

        public int PrinterID
        {
            get { return printerID; }
            set { printerID = value; }
        }
        private int printerGroupID;

        public int PrinterGroupID
        {
            get { return printerGroupID; }
            set { printerGroupID = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string iPAddress;

        public string IPAddress
        {
            get { return iPAddress; }
            set { iPAddress = value; }
        }
        private string printerDesc;

        public string PrinterDesc
        {
            get { return printerDesc; }
            set { printerDesc = value; }
        }
        private int stationID;

        public int StationID
        {
            get { return stationID; }
            set { stationID = value; }
        }
        private string printerCode;

        public string PrinterCode
        {
            get { return printerCode; }
            set { printerCode = value; }
        }
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
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
            string sqlStr = "insert into Printer(" +
                "PrinterGroupID,Name,IPAddress,PrinterDesc,AccountCode,SpellCode,StationID,PrinterCode" +
            ")values(@PrinterGroupID,@Name,@IPAddress,@PrinterDesc,@AccountCode,@SpellCode,@StationID,@PrinterCode);";
            SqlParameter[] parameters = {   new SqlParameter("@PrinterGroupID", PrinterGroupID),
                                            new SqlParameter("@Name", Name),
                                            new SqlParameter("@IPAddress", IPAddress),

                                            new SqlParameter("@PrinterDesc", PrinterDesc),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode),
                                            new SqlParameter("@StationID", StationID),
                                            new SqlParameter("@PrinterCode", PrinterCode)
                                        };
            int result = SqlDatabaseManager<PrinterModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from Printer";
            System.Data.DataTable dt = SqlDatabaseManager<System.Data.DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update Printer set " +
                "PrinterGroupID=@PrinterGroupID,Name=@Name,IPAddress=@IPAddress,PrinterDesc=@PrinterDesc,AccountCode=@AccountCode,SpellCode=@SpellCode,StationID=@StationID,PrinterCode=@PrinterCode;";
            SqlParameter[] parameters = {   new SqlParameter("@PrinterGroupID", PrinterGroupID),
                                            new SqlParameter("@Name", Name),
                                            new SqlParameter("@IPAddress", IPAddress),
                                            new SqlParameter("@PrinterID", PrinterID),
                                            new SqlParameter("@PrinterDesc", PrinterDesc),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode),
                                            new SqlParameter("@StationID", StationID),
                                            new SqlParameter("@PrinterCode", PrinterCode)
                                        };
            int result = SqlDatabaseManager<PrinterModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
