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
    public class SiteTypeModel : IDelayedupdate
    {
        #region 字段
        private int siteTypeID;
        /// <summary>
        /// 工厂类型编码
        /// </summary>
        public int SiteTypeID
        {
            get { return siteTypeID; }
            set { siteTypeID = value; }
        }

        private string typeName;
        /// <summary>
        /// 工厂类型名称
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        private string typeDesc;
        /// <summary>
        /// 工厂类型描述
        /// </summary>
        public string TypeDesc
        {
            get { return typeDesc; }
            set { typeDesc = value; }
        }

        private string spellCode;
        /// <summary>
        /// 助记码（缩写）
        /// </summary>
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
            string sqlStr = "insert into SiteType(" +
                "TypeName,TypeDesc,SpellCode" +
            ")values(@TypeName,@TypeDesc,@SpellCode);";
            SqlParameter[] parameters = {   new SqlParameter("@TypeName", TypeName),
                                            new SqlParameter("@TypeDesc", TypeDesc),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<SiteTypeModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from SiteType";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update SiteType set " +
                "TypeName=@TypeName,TypeDesc=@TypeDesc,SpellCode=@SpellCode" +
                " where SiteTypeID=@SiteTypeID";
            SqlParameter[] parameters = { new SqlParameter("@SiteTypeID", SiteTypeID),
                                            new SqlParameter("@TypeName", TypeName),
                                            new SqlParameter("@TypeDesc", TypeDesc),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<SiteTypeModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion
    }
}
