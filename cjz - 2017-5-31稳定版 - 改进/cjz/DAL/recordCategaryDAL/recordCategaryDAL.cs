using cjz.module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace cjz.DAL.recordCategaryDAL
{
    public class recordCategaryDAL
    {
        public  List<recordCategary> GetrecordCategaryList()
        {
            try
            {
                string sql = "select * from recordCategary ";
                DataTable da = SQLiteHelper.ExecteDataTable(sql);
                List<recordCategary> list = null;
                if (da.Rows.Count > 0)
                {
                    list = new List<recordCategary>();
                    recordCategary memberinfo = null;
                    foreach (DataRow row in da.Rows)
                    {
                        memberinfo = new recordCategary();
                        LoadEntity(memberinfo, row);
                        list.Add(memberinfo);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        private static void LoadEntity(recordCategary memberinfo, DataRow row)
        {
            memberinfo.id = Convert.ToInt32(row["id"]);
            memberinfo.rCategary = row["rCategary"].ToString();
            memberinfo.DelFlag = Convert.ToBoolean(row["DelFlag"]);
        }

        public  int InsertrecordCategaryInfo(recordCategary categary)
        {
            try
            {
                string sql = "insert into recordCategary values(@id,@rCategary,@DelFlag)";
                SQLiteParameter[] pms = {
                    new SQLiteParameter("@id",categary.id),
                new SQLiteParameter("@rCategary",categary.rCategary),
                new SQLiteParameter("@DelFlag",categary.DelFlag)                
            };
                return SQLiteHelper.ExecuteNonQuery(sql, pms);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public bool updaterCategaryByID(recordCategary cat)
        {
            string sql = "update recordCategary set rCategary = @rcat where ID=@id";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@rcat",cat.rCategary),
                new SQLiteParameter("@id",cat.id)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms)>0;
        }
        public bool DeleteItemByName(string name)
        {
            string sql = "update recordCategary set DelFlag=1 where rCategary=@names";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@names",name)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms) > 0;
        }

    }
}
