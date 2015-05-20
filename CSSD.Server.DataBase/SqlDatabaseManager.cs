using CSSD.Server.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CSSD.Server.DataBase
{
    public class SqlDatabaseManager<T> : BaseDataBase<T> where T : new()
    {
        /// <summary>
        /// 针对数据提供程序的Connection对象执行SQL语句，并返回影响的行数。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="commandText">SQL语句</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(out string errorString, string connectionString, string commandText, params IDbDataParameter[] args)
        {
            using (SqlCommand dbCommand = new SqlCommand(commandText, new SqlConnection(connectionString)))
            {
                return BaseDataBase<T>.ExecuteNonQuery(out errorString, dbCommand, args);
            }   
        }


        /// <summary>
        /// 执行查询，并返回查询结果集中第一行第一列的值。忽略额外的列或行。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(out string errorString, string connectionString, string commandText, params IDbDataParameter[] args)
        {
            using (SqlCommand dbCommand = new SqlCommand(commandText, new SqlConnection(connectionString)))
            {
                return BaseDataBase<T>.ExecuteScalar(out errorString, dbCommand, args);
            }
        }

        /// <summary>
        /// 通过dbCommand对象中描述的查询语句，查询后生成对象列表集(List)。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static List<T> FillToObjectList(out string errorString, string connectionString, string commandText, params IDbDataParameter[] args)
        {
            using (SqlCommand dbCommand = new SqlCommand(commandText, new SqlConnection(connectionString)))
            {
                return BaseDataBase<T>.FillToObjectList(out errorString, dbCommand, args);
            }
        }
        

        /// <summary>
        /// 通过dbCommand对象中描述的查询语句，查询后生成对象列表集(List)。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static DataTable FillToDataTable(out string errorString, string connectionString, string commandText, params IDbDataParameter[] args)
        {
            using (SqlCommand dbCommand = new SqlCommand(commandText, new SqlConnection(connectionString)))
            {
                return BaseDataBase<T>.FillToDataTable(out errorString, dbCommand, args);
            }
        }

        /// <summary>
        /// 填充单个数据对象
        /// </summary>
        /// <param name="objectItem">已实例化的对象</param>
        /// <param name="errorString">错误描述</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns>成功填充返回True；失败返回False</returns>
        public static bool FillToObject(T objectItem, out string errorString, string connectionString, string commandText, params IDbDataParameter[] args)
        {
            using (SqlCommand dbCommand = new SqlCommand(commandText, new SqlConnection(connectionString)))
            {
                return BaseDataBase<T>.FillToObject(objectItem, out errorString, dbCommand, args);
            }
        }
    }
}
