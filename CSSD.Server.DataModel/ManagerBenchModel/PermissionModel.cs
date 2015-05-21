using CSSD.Server.BaseClass;
using CSSD.Server.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.ManagerBenchModel
{
    public class PermissionModel : IDelayedupdate
    {
        public bool DelayedDelete(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public bool DelayedInsert(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public object DelayedSelectAll(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "select * from Permission";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
