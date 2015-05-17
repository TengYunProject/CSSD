using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.BaseClass
{
    public abstract class BaseDataBase<T> where T : new()
    {

        /// <summary>
        /// 从DataReader中读取当前行的数据，并为目标对象赋值
        /// </summary>
        /// <param name="reader">数据读取器</param>
        /// <param name="targetObj">目标对象</param>
        protected static void ReaderToObject(IDataReader reader, object targetObj)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                System.Reflection.PropertyInfo propertyInfo = targetObj.GetType().GetProperty(reader.GetName(i), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                if (propertyInfo != null)
                {
                    object value = reader.GetValue(i);
                    if (value != DBNull.Value)
                    {
                        if (propertyInfo.PropertyType.IsEnum)
                        {
                            propertyInfo.SetValue(targetObj, Enum.ToObject(propertyInfo.PropertyType, value), null);
                        }
                        else
                        {
                            try
                            {
                                propertyInfo.SetValue(targetObj, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                            }
                            catch (Exception)
                            {
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// 针对数据提供程序的Connection对象执行SQL语句，并返回影响的行数。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        protected static int ExecuteNonQuery(out string errorString, IDbCommand dbCommand, params IDbDataParameter[] args)
        {
            int result = 0;
            errorString = string.Empty;
            try
            {
                if (args != null && args.Length > 0)
                {
                    foreach (IDbDataParameter item in args)
                    {
                        dbCommand.Parameters.Add(item);
                    }
                }
                dbCommand.Connection.Open();
                result = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
            }
            catch (Exception e)
            {
                errorString = e.Message;
            }
            finally
            {
                if (dbCommand.Connection.State != ConnectionState.Closed)
                {
                    dbCommand.Connection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行查询，并返回查询结果集中第一行第一列的值。忽略额外的列或行。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        protected static object ExecuteScalar(out string errorString, IDbCommand dbCommand, params IDbDataParameter[] args)
        {
            object result = null;
            errorString = string.Empty;
            try
            {
                if (args != null && args.Length > 0)
                {
                    foreach (IDbDataParameter item in args)
                    {
                        dbCommand.Parameters.Add(item);
                    }
                }
                dbCommand.Connection.Open();
                result = dbCommand.ExecuteScalar();
                dbCommand.Connection.Close();
            }
            catch (Exception e)
            {
                errorString = e.Message;
            }
            finally
            {
                if (dbCommand.Connection.State != ConnectionState.Closed)
                {
                    dbCommand.Connection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 通过dbCommand对象中描述的查询语句，查询后生成对象列表集(List)。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        protected static List<T> FillToObjectList(out string errorString, IDbCommand dbCommand, params IDbDataParameter[] args)
        {
            List<T> result = new List<T>();
            errorString = string.Empty;

            try
            {
                if (args != null && args.Length > 0)
                {
                    foreach (IDbDataParameter item in args)
                    {
                        dbCommand.Parameters.Add(item);
                    }
                }

                dbCommand.Connection.Open();
                IDataReader msdr = dbCommand.ExecuteReader();

                while (msdr.Read())
                {
                    T item = new T();
                    ReaderToObject(msdr, item);
                    result.Add(item);
                }

                dbCommand.Connection.Close();

            }
            catch (Exception e)
            {
                errorString = e.Message;
            }
            finally
            {
                if (dbCommand.Connection.State != ConnectionState.Closed)
                {
                    dbCommand.Connection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 通过dbCommand对象中描述的查询语句，查询后生成对象DataTable。
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        protected static DataTable FillToDataTable(out string errorString, SqlCommand dbCommand, params IDbDataParameter[] args)
        {
            DataTable dt = new DataTable();
            errorString = string.Empty;

            try
            {
                if (args != null && args.Length > 0)
                {
                    foreach (IDbDataParameter item in args)
                    {
                        dbCommand.Parameters.Add(item);
                    }
                }

                dbCommand.Connection.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter();
                sqlDap.SelectCommand = dbCommand;

                DataSet ds = new DataSet();
                try
                {
                    sqlDap.Fill(ds);
                    dt = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    errorString = ex.Message;
                }
                finally
                {
                    ds.Dispose();
                    sqlDap.Dispose();
                }

                dbCommand.Connection.Close();

            }
            catch (Exception e)
            {
                errorString = e.Message;
            }
            finally
            {
                if (dbCommand.Connection.State != ConnectionState.Closed)
                {
                    dbCommand.Connection.Close();
                }
            }

            return dt;
        }

        /// <summary>
        /// 填充单个数据对象
        /// </summary>
        /// <param name="objectItem">已实例化的对象</param>
        /// <param name="errorString">错误描述</param>
        /// <param name="dbCommand">数据执行对象</param>
        /// <param name="args">参数</param>
        /// <returns>成功填充返回True；失败返回False</returns>
        protected static bool FillToObject(T objectItem, out string errorString, IDbCommand dbCommand, params IDbDataParameter[] args)
        {
            bool result = false;
            errorString = string.Empty;

            try
            {
                if (args != null && args.Length > 0)
                {
                    foreach (IDbDataParameter item in args)
                    {
                        dbCommand.Parameters.Add(item);
                    }
                }

                dbCommand.Connection.Open();

                IDataReader msdr = dbCommand.ExecuteReader();
                if (msdr.Read())
                {
                    ReaderToObject(msdr, objectItem);
                    result = true;
                }
                else
                {
                    result = false;
                }
                dbCommand.Connection.Close();

            }
            catch (Exception e)
            {
                errorString = e.Message;
                result = false;
            }
            finally
            {
                if (dbCommand.Connection.State != ConnectionState.Closed)
                {
                    dbCommand.Connection.Close();
                }
            }

            return result;
        }

    }
}