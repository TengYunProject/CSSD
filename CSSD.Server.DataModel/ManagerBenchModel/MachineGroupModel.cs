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
    public class MachineGroupModel : IDelayedupdate
    {
        #region 字段
        private int machineGroupID;

        public int MachineGroupID
        {
            get { return machineGroupID; }
            set { machineGroupID = value; }
        }

        private string machineGroupDesc;

        public string MachineGroupDesc
        {
            get { return machineGroupDesc; }
            set { machineGroupDesc = value; }
        }

        private string machineGroupName;

        public string MachineGroupName
        {
            get { return machineGroupName; }
            set { machineGroupName = value; }
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
            string sqlStr = "insert into MachineGroup(" +
                ",spellCode,MachineIDStatusID,MachineName,AccountCode,MachineOriginallyID" +
            ")values(,@spellCode,@MachineIDStatusID,@MachineName,@AccountCode,@MachineOriginallyID);";
            SqlParameter[] parameters = {   
                                            new SqlParameter("@MachineGroupDesc", MachineGroupDesc),
                                            new SqlParameter("@MachineGroupName", MachineGroupName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<MachineGroupModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from MachineGroup";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update MachineGroup(" +
                "MachineIDGroupID=@MachineIDGroupID,spellCode=@spellCode,MachineIDStatusID=@MachineIDStatusID,"
            + "MachineName=@MachineName,AccountCode=@AccountCode,MachineOriginallyID=@MachineOriginallyID)"
            + " where MachineGroupID=@MachineGroupID;";
            SqlParameter[] parameters = {   new SqlParameter("@MachineGroupID", MachineGroupID),
                                            new SqlParameter("@MachineGroupDesc", MachineGroupDesc),
                                            new SqlParameter("@MachineGroupName", MachineGroupName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<MachineGroupModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
