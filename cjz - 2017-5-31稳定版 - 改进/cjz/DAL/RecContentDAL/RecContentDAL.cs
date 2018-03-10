using cjz.module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace cjz.DAL.RecContentDAL
{
    public class RecContentDAL
    {
        public DataTable GetAll()
        {
            string sql = "select ID, recName from RecContent where DelFlag=0 union select id,rCategary from recordCategary where DelFlag = 0 ";
            return SQLiteHelper.ExecteDataTable(sql);
        }
        public  List<RecContent> GetRecContentList()
        {
            try
            {
                string sql = "select * from RecContent";
                DataTable da = SQLiteHelper.ExecteDataTable(sql);
                List<RecContent> list = null;
                if (da.Rows.Count > 0)
                {
                    list = new List<RecContent>();
                    RecContent memberinfo = null;
                    foreach (DataRow row in da.Rows)
                    {
                        memberinfo = new RecContent();
                        LoadEntity(memberinfo, row);
                        list.Add(memberinfo);
                    }
                }
                return list;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string GetContentByID(int id)
        {
            string sql = "select record from RecContent where ID=@mid";
            SQLiteParameter[] pms =
            {
                new SQLiteParameter("@mid",id)
            };
            return SQLiteHelper.ExecuteScalar(sql, pms).ToString();
        }
        public  int InsertMemberInfo(RecContent reccontent)
        {
            try
            {
                string sql = "insert into RecContent values(@id,@recname,@record ,@FID,@delflag)";
                SQLiteParameter[] pms = {
                new SQLiteParameter("@id",reccontent.ID),
                new SQLiteParameter("@recname",reccontent.recName),
                new SQLiteParameter("@record",reccontent.record),
                new SQLiteParameter("@FID",reccontent.FID),
                new SQLiteParameter("@delflag",reccontent.DelFlag),
            };
                return SQLiteHelper.ExecuteNonQuery(sql, pms);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public bool updaterRecNameByID(RecContent content)
        {
            string sql = "update RecContent set recName=@name where ID=@id";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@name",content.recName),
                new SQLiteParameter("@id",content.ID)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms) > 0;
        }
        public bool DeleteItemByName(string name)
        {
            string sql = "update RecContent set DelFlag=1 where recName=@names";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@names",name)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms)>0;
        }
        public bool UpdateContentByID(int id,string str)
        {
            string sql = "update RecContent set record=@str where ID=@ids";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@str",str),
                new SQLiteParameter("@ids",id)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms) > 0;
        }
        private static void LoadEntity(RecContent memberinfo, DataRow row)
        {
            memberinfo.ID =Convert.ToInt32(row["ID"]) ;
            memberinfo.recName = row["recName"].ToString();
            memberinfo.record = row["record"].ToString();
            memberinfo.FID = Convert.ToInt32(row["FID"]);
            memberinfo.DelFlag = Convert.ToBoolean(row["DelFlag"]);
        }

    }
}
