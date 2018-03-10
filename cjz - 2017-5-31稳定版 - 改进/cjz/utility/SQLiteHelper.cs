using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Data.Common;

namespace cjz
{
    public static class SQLiteHelper
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["sqliteConStr"].ConnectionString;
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] pms)
        {
            using (SQLiteConnection con = new SQLiteConnection(constr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    //pms = null 会报错
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);

                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 执行sql语句，返回单个值。
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="pms">sql语句中的参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] pms)
        {
            using (SQLiteConnection con = new SQLiteConnection(constr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        /// <summary>  
        /// 批量处理数据操作语句。  
        /// </summary>  
        /// <param name="list">SQL语句集合。</param>  
        /// <exception cref="Exception"></exception>  
        public static void ExecuteNonQueryBatch(List<KeyValuePair<string, SQLiteParameter[]>> list)
        {
            using (SQLiteConnection conn = new SQLiteConnection(constr))
            {
                try { conn.Open(); }
                catch { throw; }
                using (SQLiteTransaction tran = conn.BeginTransaction())
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        try
                        {
                            foreach (var item in list)
                            {
                                cmd.CommandText = item.Key;
                                cmd.Parameters.AddRange(item.Value);
                                cmd.ExecuteNonQuery();
                            }
                            tran.Commit();
                        }
                        catch (Exception ex) { tran.Rollback(); System.Windows.Forms.MessageBox.Show(ex.Message); }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] pms)
        {
            using (SQLiteConnection con = new SQLiteConnection(constr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    //传递commandBehavior.CloseConnection参数，当关闭的时候会自动关闭连接
                    SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;
                }
            }
        }
        /// <summary>
        /// 封装一个返回datatable的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static DataTable ExecteDataTable(string sql, params SQLiteParameter[] pms)
        {
            try
            {
                SQLiteDataAdapter sqliteAdapter = new SQLiteDataAdapter(sql, constr);
                if (pms != null)
                {
                    sqliteAdapter.SelectCommand.Parameters.AddRange(pms);
                }
                DataTable dt = new DataTable();
                sqliteAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}