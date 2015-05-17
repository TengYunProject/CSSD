using CSSD.Server.BaseClass;
using CSSD.Server.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel
{
    /// <summary>
    /// 批次
    /// </summary>
    public class BatchModel : IDelayedupdate
    {
        private string BatchID;

        public string BatchID1
        {
            get { return BatchID; }
            set { BatchID = value; }
        }

        private string BatchFailureReasonID;

        public string BatchFailureReasonID1
        {
            get { return BatchFailureReasonID; }
            set { BatchFailureReasonID = value; }
        }

        private string CreateUserID;

        public string CreateUserID1
        {
            get { return CreateUserID; }
            set { CreateUserID = value; }
        }

        private string FailureUserID;

        public string FailureUserID1
        {
            get { return FailureUserID; }
            set { FailureUserID = value; }
        }

        private string MachineID;

        public string MachineID1
        {
            get { return MachineID; }
            set { MachineID = value; }
        }

        private string MachineBatchNo;

        public string MachineBatchNo1
        {
            get { return MachineBatchNo; }
            set { MachineBatchNo = value; }
        }

        private string DatetimeCreated;

        public string DatetimeCreated1
        {
            get { return DatetimeCreated; }
            set { DatetimeCreated = value; }
        }

        private string DatetimeStarted;

        public string DatetimeStarted1
        {
            get { return DatetimeStarted; }
            set { DatetimeStarted = value; }
        }

        private string DatetimeFailed;

        public string DatetimeFailed1
        {
            get { return DatetimeFailed; }
            set { DatetimeFailed = value; }
        }

        private string DatetimeArchived;

        public string DatetimeArchived1
        {
            get { return DatetimeArchived; }
            set { DatetimeArchived = value; }
        }

        private string MachineIDSelected;

        public string MachineIDSelected1
        {
            get { return MachineIDSelected; }
            set { MachineIDSelected = value; }
        }

        private string MachineBatchNoSelected;

        public string MachineBatchNoSelected1
        {
            get { return MachineBatchNoSelected; }
            set { MachineBatchNoSelected = value; }
        }


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
            string sql = "select * from Batch;";
            List<BatchModel> lst = SqlDatabaseManager<BatchModel>.FillToObjectList(out errorString, connectionString, sql);
            return lst;
        }

        public bool DelayedUpdate(out string errorString, string connectionString)
        {
            throw new NotImplementedException();
        }

        public DataTable DelayedSelectAllToTable(out string errorString, string connectionString)
        {
            string sql = "select * from Batch;";
            DataTable dt = SqlDatabaseManager<DataTable>.FillToDataTable(out errorString, connectionString, sql);
            return dt;
        }

        public DataTable getALL(out string error, string connection)
        {
            DataTable dt = new DataTable();
            string str = "select * from Batch";
            return SqlDatabaseManager<DataTable>.FillToDataTable(out error, connection, str);
        }
    }
}