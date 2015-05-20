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
    public class CustTableModel : IDelayedupdate
    {
        #region 字段
        private int custID;

        public int CustID
        {
            get { return custID; }
            set { custID = value; }
        }
        private string custName;

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        private string custNameAlias;

        public string CustNameAlias
        {
            get { return custNameAlias; }
            set { custNameAlias = value; }
        }
        private string lineDistance;

        public string LineDistance
        {
            get { return lineDistance; }
            set { lineDistance = value; }
        }
        private int invoiceAccoutID;

        public int InvoiceAccoutID
        {
            get { return invoiceAccoutID; }
            set { invoiceAccoutID = value; }
        }
        private int custGroupID;

        public int CustGroupID
        {
            get { return custGroupID; }
            set { custGroupID = value; }
        }
        private int costModelID;

        public int CostModelID
        {
            get { return costModelID; }
            set { costModelID = value; }
        }
        private string taxGroup;

        public string TaxGroup
        {
            get { return taxGroup; }
            set { taxGroup = value; }
        }
        private int locationID;

        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        private int contactID;

        public int ContactID
        {
            get { return contactID; }
            set { contactID = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
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

        private string isStop;

        public string IsStop
        {
            get { return isStop; }
            set { isStop = value; }
        }

        private string custGroupName;

        public string CustGroupName
        {
            get { return custGroupName; }
            set { custGroupName = value; }
        }

        private string costModelName;

        public string CostModelName
        {
            get { return costModelName; }
            set { costModelName = value; }
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
            string sqlStr = "insert into CustTable(" +
                "CustName,CustNameAlias,LineDistance,InvoiceAccoutID,CustGroupID,"
            + "CostModelID,TaxGroup,LocationID,ContactID,Address,AccountCode,SpellCode,IsStop,CustGroupName,CostModelName" +
            ")values(@CustName,@CustNameAlias,@LineDistance,@InvoiceAccoutID,@CustGroupID,"
            + "@CostModelID,@TaxGroup,@LocationID,@ContactID,@Address,@AccountCode,@SpellCode,@IsStop,@CustGroupName,@CostModelName);";
            SqlParameter[] parameters = {   new SqlParameter("@CustName", CustName),
                                            new SqlParameter("@CustNameAlias", CustNameAlias),
                                            new SqlParameter("@LineDistance", LineDistance),
                                            new SqlParameter("@InvoiceAccoutID", InvoiceAccoutID),
                                            new SqlParameter("@CustGroupID", CustGroupID),
                                            new SqlParameter("@CostModelID", CostModelID),
                                            new SqlParameter("@TaxGroup", TaxGroup),
                                            new SqlParameter("@LocationID", LocationID),
                                            new SqlParameter("@ContactID", ContactID),
                                            new SqlParameter("@Address", Address),
                                            new SqlParameter("@AccountCode", AccountCode),

                                             new SqlParameter("@CustGroupName", CustGroupName),
                                            new SqlParameter("@CostModelName", CostModelName),

                                            new SqlParameter("@IsStop", IsStop),
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
            string sqlStr = "select * from CustTable";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sqlStr);
            return dt;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            errorString = string.Empty;
            string sqlStr = "update CustTable set " +
                "CustName=@CustName,CustNameAlias=@CustNameAlias,LineDistance=@LineDistance,InvoiceAccoutID=@InvoiceAccoutID"
                + ",CustGroupID=@CustGroupID,CostModelID=@CostModelID,TaxGroup=@TaxGroup,"
            + "LocationID=@LocationID,ContactID=@ContactID,Address=@Address,AccountCode=@AccountCode,SpellCode=@SpellCode,"
            + "CustGroupName=@CustGroupName,CostModelName=@CostModelName,IsStop=@IsStop"
            + " where CustID=@CustID;";

            SqlParameter[] parameters = {   new SqlParameter("@CustID", CustID),
                                            new SqlParameter("@CustName", CustName),
                                            new SqlParameter("@CustNameAlias", CostModelID),
                                            new SqlParameter("@LineDistance", CustName),
                                            new SqlParameter("@InvoiceAccoutID", InvoiceAccoutID),
                                            new SqlParameter("@CustGroupID", CustGroupID),
                                            new SqlParameter("@CostModelID", CostModelID),
                                            new SqlParameter("@TaxGroup", TaxGroup),
                                            new SqlParameter("@LocationID", LocationID),
                                            new SqlParameter("@ContactID", ContactID),
                                            new SqlParameter("@Address", Address),
                                            new SqlParameter("@AccountCode", AccountCode),
                                            new SqlParameter("@IsStop", IsStop),
                                             new SqlParameter("@CustGroupName", CustGroupName),
                                            new SqlParameter("@CostModelName", CostModelName),
                                            new SqlParameter("@SpellCode", SpellCode)};
            int result = SqlDatabaseManager<CustGroupModel>.ExecuteNonQuery(out errorString, connectionString, sqlStr, parameters);
            return result <= 0 ? false : true;
        }
        #endregion
    }
}
