using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// sqlHelper 的摘要说明
/// </summary>
public class sqlHelper
{
    //连接字符串
    //private static string connStr = ConfigurationManager.ConnectionStrings["JWGLConnectionString"].ToString();
    private static string connStr = "server=.;database=JWGL;uid=sa;pwd=123456";
    //数据连接对象
    SqlConnection conn = new SqlConnection(connStr);

    internal SqlDataReader ExecuteReader()
    {
        throw new NotImplementedException();
    }

    //数据操作对象
    SqlCommand cmd = new SqlCommand();
    /// <summary>构造函数
    /// 
    /// </summary>
    public sqlHelper()
    {

    }
    /// <summary>开启数据连接
    /// 
    /// </summary>
    public void connOpen()
    {
        try
        {
            conn.Open();
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>关闭数据连接
    /// 
    /// </summary>
    public void connClose()
    {
        try
        {
            conn.Close();
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>获取数据列表
    /// 
    /// </summary>
    /// <param name="sql">select查询语句</param>
    /// <returns>Dataset数据列表</returns>
    public DataSet GetList(string sql)
    {
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>获取查询到的第一行第一列的值
    /// 
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public int ExecuteScalar(string sql)
    {
        try
        {
            cmd.CommandText = sql;
            cmd.Connection = conn;
            connOpen();
            int rs = Convert.ToInt16(cmd.ExecuteScalar());
            connClose();
            return rs;
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>判断是否存在数据 逐行读取
    /// 
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public bool excuteReader(string sql)
    {
        try
        {
            cmd.CommandText = sql;
            cmd.Connection = conn;
            connOpen();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                connClose();
                return true;
            }
            else
            {
                connClose();
                return false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>插入删除修改数据
    /// 
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public bool excuteNonQuery(string sql)
    {
        try
        {
            int rs = 0;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            connOpen();
            rs = cmd.ExecuteNonQuery();
            if (rs == 1)
            {
                connClose();
                return true;
            }
            else
            {
                connClose();
                return false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>删除多行数据
    /// 
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public bool deleteMult(string sql)
    {
        try
        {
            int rs = 0;
            cmd.CommandText = sql;
            cmd.Connection = conn;
            connOpen();
            rs = cmd.ExecuteNonQuery();
            if (rs >0)
            {
                connClose();
                return true;
            }
            else
            {
                connClose();
                return false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>分页获取数据列表
    /// 
    /// </summary>
    /// <param name="pageSize">每页大小</param>
    /// <param name="pageNums">当前页数</param>
    /// <returns></returns>
    public DataSet GetListPager(int pageSize, int pageNums,string table,string mainKey)
    {
        try
        {
            string sql = "select top " + pageSize + " * from " + table + " where ("+mainKey+" not in (select top (" + pageSize + "*" + pageNums + ") "+mainKey+" from "+table+" order by "+mainKey+"))";
            return GetList(sql);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>分页获取数据列表（有筛选条件）
    /// 
    /// </summary>
    /// <param name="pageSize">每页大小</param>
    /// <param name="pageNums">当前页数</param>
    /// <returns></returns>
    public DataSet GetListPager(int pageSize, int pageNums, string table, string mainKey,string where)
    {
        try
        {
            string sql = "select top " + pageSize + " * from " + table + " where (" + mainKey + " not in (select top (" + pageSize + "*" + pageNums + ") " + mainKey + " from " + table +" where "+where+")) and "+where;
            return GetList(sql);
        }
        catch (Exception)
        {
            throw;
        }
    }
}