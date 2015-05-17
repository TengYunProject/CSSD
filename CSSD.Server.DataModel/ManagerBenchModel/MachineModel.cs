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
    public class MachineModel : IDelayedupdate
    {
        #region 字段
        private int machineID;

        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }
        private int machineIDGroupID;

        public int MachineIDGroupID
        {
            get { return machineIDGroupID; }
            set { machineIDGroupID = value; }
        }
        private int machineStatusID;

        public int MachineStatusID
        {
            get { return machineStatusID; }
            set { machineStatusID = value; }
        }
        private string machineName;

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }
        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }
        private string machineOriginallyID;

        public string MachineOriginallyID
        {
            get { return machineOriginallyID; }
            set { machineOriginallyID = value; }
        }
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        private string machineStatusName;

        public string MachineStatusName
        {
            get { return machineStatusName; }
            set { machineStatusName = value; }
        }
        private string machineIDGroupName;

        public string MachineIDGroupName
        {
            get { return machineIDGroupName; }
            set { machineIDGroupName = value; }
        }
        private string machineDesc;

        public string MachineDesc
        {
            get { return machineDesc; }
            set { machineDesc = value; }
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
            string sqlStr = "insert into Machine(" +
                "MachineIDGroupID,spellCode,MachineStatusID,MachineName,AccountCode,MachineOriginallyID,"
            + "MachineStatusName,MachineIDGroupName,MachineDesc" +
            ")values(@MachineIDGroupID,@spellCode,@MachineStatusID,@MachineName,@AccountCode,"
            + "@MachineOriginallyID,@MachineStatusName,@MachineIDGroupName,@MachineDesc);";
            SqlParameter[] parameters = {   new SqlParameter("@MachineIDGroupID", MachineIDGroupID),
                                            new SqlParameter("@spellCode", spellCode),
                                            new SqlParameter("@MachineStatusID", MachineStatusID),
                                            new SqlParameter("@MachineName", MachineName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@MachineStatusName", MachineStatusName),
                                            new SqlParameter("@MachineIDGroupName", MachineIDGroupName),
                                            new SqlParameter("@MachineDesc", MachineDesc),
                                            new SqlParameter("@MachineOriginallyID", MachineOriginallyID)};
            int result = SqlDatabaseManager<MachineModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from Machine";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update Machine set " +
                "MachineIDGroupID=@MachineIDGroupID,spellCode=@spellCode,"
            + "MachineStatusID=@MachineStatusID,MachineName=@MachineName,"
            + "AccountCode=@AccountCode,MachineOriginallyID=@MachineOriginallyID,MachineStatusName=@MachineStatusName,"
            + "MachineDesc=@MachineDesc,MachineIDGroupName=@MachineIDGroupName"
            + " where MachineID=@MachineID;";
            SqlParameter[] parameters = {   new SqlParameter("@MachineID", MachineID),
                                            new SqlParameter("@MachineIDGroupID", MachineIDGroupID),
                                            new SqlParameter("@spellCode", spellCode),
                                            new SqlParameter("@MachineStatusID", MachineStatusID),
                                            new SqlParameter("@MachineName", MachineName),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@MachineStatusName", MachineStatusName),
                                            new SqlParameter("@MachineIDGroupName", MachineIDGroupName),
                                            new SqlParameter("@MachineDesc", MachineDesc),
                                            new SqlParameter("@MachineOriginallyID", MachineOriginallyID)};
            int result = SqlDatabaseManager<MachineModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
