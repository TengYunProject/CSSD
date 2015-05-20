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
    public class UserGroupModel : IDelayedupdate
    {
        #region 字段
        private int userGroupID;

        public int UserGroupID
        {
            get { return userGroupID; }
            set { userGroupID = value; }
        }
        private int userGroupDesc;

        public int UserGroupDesc
        {
            get { return userGroupDesc; }
            set { userGroupDesc = value; }
        }
        private int permissionID;

        public int PermissionID
        {
            get { return permissionID; }
            set { permissionID = value; }
        }
        private string userGroupName;

        public string UserGroupName
        {
            get { return userGroupName; }
            set { userGroupName = value; }
        }
        private int createUserID;

        public int CreateUserID
        {
            get { return createUserID; }
            set { createUserID = value; }
        }
        private DateTime createDateTime;

        public DateTime CreateDateTime
        {
            get { return createDateTime; }
            set { createDateTime = value; }
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
            string sqlStr = "insert into UserGroup(" +
                "UserGroupDesc,PermissionID,UserGroupName,CreateUserID,CreateDateTime,AccountCode,SpellCode" +
            ")values(@UserGroupDesc,@PermissionID,@UserGroupName,@CreateUserID,@CreateDateTime,@AccountCode,@SpellCode);";
            SqlParameter[] parameters = {   new SqlParameter("@UserGroupDesc", UserGroupDesc),
											new SqlParameter("@PermissionID", PermissionID),
                                            new SqlParameter("@UserGroupName", UserGroupName),
											new SqlParameter("@CreateUserID", CreateUserID),
                                            new SqlParameter("@CreateDateTime", CreateDateTime),
											new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<SiteTypeModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from UserGroup";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update UserGroup set" +
                "UserGroupID=@UserGroupID,UserGroupDesc=@UserGroupDesc,PermissionID=@PermissionID,UserGroupName=@UserGroupName,"
                + "CreateUserID=@CreateUserID,CreateDateTime=@CreateDateTime,AccountCode@AccountCode,SpellCode=@SpellCode "
                + " where UserGroupID=@UserGroupID;";
            SqlParameter[] parameters = {   new SqlParameter("@UserGroupID", UserGroupID),			
                                            new SqlParameter("@UserGroupDesc", UserGroupDesc),
											new SqlParameter("@PermissionID", PermissionID),
                                            new SqlParameter("@UserGroupName", UserGroupName),
											new SqlParameter("@CreateUserID", CreateUserID),
                                            new SqlParameter("@CreateDateTime", CreateDateTime),
											new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<SiteTypeModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
