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
    public class MachineStatusModel : IDelayedupdate
    {
        #region 字段
        private int machineStatusID;

        public int MachineStatusID
        {
            get { return machineStatusID; }
            set { machineStatusID = value; }
        }
        private string machineDesc;

        public string MachineDesc
        {
            get { return machineDesc; }
            set { machineDesc = value; }
        }
        private string statusType;

        public string StatusType
        {
            get { return statusType; }
            set { statusType = value; }
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
            string sqlStr = "insert into MachineStatus(" +
                "Desc,StatusType,SpellCode,AccountCode" +
            ")values(@Desc,@StatusType,@SpellCode,@AccountCode);";
            SqlParameter[] parameters = {   new SqlParameter("@Desc", MachineDesc),
                                            new SqlParameter("@StatusType", StatusType),
                                            new SqlParameter("@spellCode", spellCode),
                                            new SqlParameter("@AccountCode", AccountCode)};
            int result = SqlDatabaseManager<MachineStatusModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from MachineStatus";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update MachineStatus(" +
                "Desc=@Desc,StatusType=@StatusType,SpellCode=@SpellCode,AccountCode=@AccountCode" +
                " where MachineStatusID=@MachineStatusID;";
            SqlParameter[] parameters = {  new SqlParameter("@MachineStatusID", MachineStatusID),
                                            new SqlParameter("@Desc", MachineDesc),
                                            new SqlParameter("@StatusType", StatusType),
                                            new SqlParameter("@spellCode", spellCode),
                                            new SqlParameter("@AccountCode", AccountCode)};
            int result = SqlDatabaseManager<MachineStatusModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
