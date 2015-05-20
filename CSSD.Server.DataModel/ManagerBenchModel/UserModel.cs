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
    public class UserModel : IDelayedupdate
    {
        #region 字段
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private int archivedUserID;

        public int ArchivedUserID
        {
            get { return archivedUserID; }
            set { archivedUserID = value; }
        }
        private int createdUserID;

        public int CreatedUserID
        {
            get { return createdUserID; }
            set { createdUserID = value; }
        }
        private int userGroupID;

        public int UserGroupID
        {
            get { return userGroupID; }
            set { userGroupID = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string externalID;

        public string ExternalID
        {
            get { return externalID; }
            set { externalID = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime created;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }
        private int iSExpired;

        public int ISExpired
        {
            get { return iSExpired; }
            set { iSExpired = value; }
        }
        private int isLockedOut;

        public int IsLockedOut
        {
            get { return isLockedOut; }
            set { isLockedOut = value; }
        }
        private int isOnline;

        public int IsOnline
        {
            get { return isOnline; }
            set { isOnline = value; }
        }
        private DateTime lastActivity;

        public DateTime LastActivity
        {
            get { return lastActivity; }
            set { lastActivity = value; }
        }
        private DateTime lastLogin;

        public DateTime LastLogin
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
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
            string sqlStr = "insert into User(" +
                "ArchivedUserID,CreatedUserID,UserGroupID,PassWord,ExternalID,UserName,Email," +
                "Created,ISExpired,IsLockedOut,IsOnline,LastActivity,LastLogin,Comment,Position,Telephone,AccountCode"
            + ")values(@ArchivedUserID,@CreatedUserID,@UserGroupID,@PassWord,@ExternalID,@UserName,@Email," +
                "@Created,@ISExpired,@IsLockedOut,@IsOnline,@LastActivity,@LastLogin,@Comment,@Position,@Telephone,@AccountCode)";
            SqlParameter[] parameters = {   new SqlParameter("@ArchivedUserID", ArchivedUserID),
											new SqlParameter("@CreatedUserID", CreatedUserID),
                                            new SqlParameter("@UserGroupID", UserGroupID),
											new SqlParameter("@PassWord", PassWord),
                                            new SqlParameter("@UserName", UserName),
                                             new SqlParameter("@Email", Email),
											new SqlParameter("@Created", Created),
                                            new SqlParameter("@ISExpired", ISExpired),
											new SqlParameter("@IsLockedOut", IsLockedOut),
                                            new SqlParameter("@IsOnline", IsOnline),
                                             new SqlParameter("@LastActivity", LastActivity),
											new SqlParameter("@LastLogin", LastLogin),
                                            new SqlParameter("@Comment", Comment),
											new SqlParameter("@Position", Position),
                                            new SqlParameter("@Telephone", Telephone),
											new SqlParameter("@AccountCode", AccountCode)};
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
            string sqlStr = "select * from User";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update User set " +
                "ArchivedUserID=@ArchivedUserID,CreatedUserID=@CreatedUserID,UserGroupID=@UserGroupID,PassWord=@PassWord,ExternalID=@ExternalID,UserName=@UserName,Email=@Email," +
                "Created=@Created,ISExpired=@ISExpired,IsLockedOut=@IsLockedOut,IsOnline=@IsOnline,LastActivity=@LastActivity,LastLogin=@LastLogin,Comment=@Comment,Position=@Position,Telephone=@Telephone,AccountCode=@AccountCode";
            SqlParameter[] parameters = {   new SqlParameter("@ArchivedUserID", ArchivedUserID),
											new SqlParameter("@CreatedUserID", CreatedUserID),
                                            new SqlParameter("@UserGroupID", UserGroupID),
											new SqlParameter("@PassWord", PassWord),
                                            new SqlParameter("@UserName", UserName),
                                             new SqlParameter("@Email", Email),
											new SqlParameter("@Created", Created),
                                            new SqlParameter("@ISExpired", ISExpired),
											new SqlParameter("@IsLockedOut", IsLockedOut),
                                            new SqlParameter("@IsOnline", IsOnline),
                                             new SqlParameter("@LastActivity", LastActivity),
											new SqlParameter("@LastLogin", LastLogin),
                                            new SqlParameter("@Comment", Comment),
											new SqlParameter("@Position", Position),
                                            new SqlParameter("@Telephone", Telephone),
											new SqlParameter("@AccountCode", AccountCode)};
            int result = SqlDatabaseManager<SiteTypeModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion

    }
}
