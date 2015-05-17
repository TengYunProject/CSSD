using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.BaseClass
{
    public interface IDelayedupdate
    {
        ///// <summary>
        ///// 数据唯一标识
        ///// </summary>
        //int DataID { get; set; }

        ///// <summary>
        ///// 数据当前状态
        ///// </summary>
        //DataState DataState { get; set; }

        /// <summary>
        /// 添加新数据
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        bool DelayedInsert(out string errorString, string connectionString);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        bool DelayedUpdate(out string errorString, string connectionString);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        bool DelayedDelete(out string errorString, string connectionString);

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        object DelayedSelectAll(out string errorString, string connectionString);
        /// <summary>
        /// 查询所有数据（返回DataTable）
        /// </summary>
        /// <param name="errorString">异常消息</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns></returns>
        DataTable DelayedSelectAllToTable(out string errorString, string connectionString);
    }
}
