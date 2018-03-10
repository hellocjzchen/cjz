using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace cjz
{
    public class ScholzJobNoDAL
    {
        public List<ScholzJobNo> GetMemberList()
        {
            string sql = "select * from Scholz";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<ScholzJobNo> list = null;
            if (da.Rows.Count>0)
            {
                list = new List<ScholzJobNo>();
                ScholzJobNo memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new ScholzJobNo();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<ScholzJobNo> GetMemberListByUserName(string username)
        {
            string sql = "select * from Scholz where userName=@username";

            DataTable da = SQLiteHelper.ExecteDataTable(sql,new SQLiteParameter("@username",username));
            List<ScholzJobNo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<ScholzJobNo>();
                ScholzJobNo memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new ScholzJobNo();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<string> GetUserName()
        {
            string sql = "select username from Scholz";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<string> usrlist =null;
            if (da.Rows.Count > 0)
            {
                usrlist = new List<string>();
                string ur;
                foreach (DataRow row in da.Rows)
                {
                    ur = row["username"].ToString();
                    if (!usrlist.Contains(ur))
                    {
                        usrlist.Add(row["username"].ToString());
                    }               
                    
                }
            }
            return usrlist;

        }
        public int EmptyDatabaseTable()
        {
            try
            {
                string sql = "delete from Scholz";
                SQLiteHelper.ExecuteNonQuery(sql);
                string sql1 = "VACUUM";
                SQLiteHelper.ExecuteNonQuery(sql1);
                string sql2 = "PRAGMA auto_vacuum = 1;";
                SQLiteHelper.ExecuteNonQuery(sql2);
                return 1;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public bool InsertMemberlist(List<ScholzJobNo> list)
        {
            try
            {
                //string sql4 = "delete  from Scholz";
                //string sql1 = "VACUUM";
                //string sql2 = "PRAGMA auto_vacuum = 1;";
               
                //KeyValuePair<string, SQLiteParameter[]> mpair;
                //mpair = new KeyValuePair<string, SQLiteParameter[]>(sql4, null);

                //mlist.Add(mpair);
                //mpair = new KeyValuePair<string, SQLiteParameter[]>(sql1, null);
                //mlist.Add(mpair);
                //mpair = new KeyValuePair<string, SQLiteParameter[]>(sql2, null);
                //mlist.Add(mpair);
                if (list.Count > 0)
                {

                    List<KeyValuePair<string, SQLiteParameter[]>> mlist = new List<KeyValuePair<string, SQLiteParameter[]>>();
                    string sql = "INSERT INTO Scholz VALUES (null,@user,@jobNo1,@SignYear1 ,@Dvalid1,@Lvalid1,@PressureMax1,@TempMax1,@DelFlag1)";
                    KeyValuePair<string, SQLiteParameter[]> mpair;
                    foreach (ScholzJobNo cmppj in list)
                    {
                        SQLiteParameter[] pms = {
                                                    new SQLiteParameter("@user",cmppj.userName),
                                                    new SQLiteParameter("@jobNo1",cmppj.jobNo),
                                                    new SQLiteParameter("@SignYear1",cmppj.SignYear),
                                                    new SQLiteParameter("@Dvalid1",cmppj.Dvalid),
                                                    new SQLiteParameter("@Lvalid1",cmppj.Lvalid),
                                                    new SQLiteParameter("@PressureMax1",cmppj.PressureMax),
                                                    new SQLiteParameter("@TempMax1",cmppj.TempMax),
                                                    new SQLiteParameter("@DelFlag1",cmppj.DelFlag)
                                                };

                        mpair = new KeyValuePair<string, SQLiteParameter[]>(sql, pms);
                        mlist.Add(mpair);
                    }
                    SQLiteHelper.ExecuteNonQueryBatch(mlist);
                    // System.Windows.Forms.MessageBox.Show("数据库插入成功");
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false; ;
            }
        }

        public int DeleteMemberInfoByID(int id)
        {
            string sql = "update Scholz set DelFlag=1 where id=@iid";
            return SQLiteHelper.ExecuteNonQuery(sql, new SQLiteParameter("@iid", id));
        }

        public int InsertMemberInfo(ScholzJobNo jobno)
        {
            string sql = "INSERT INTO Scholz VALUES (@jobNo,@userName,@SignYear ,@Dvalid,@Lvalid,@PressureMax,@TempMax,@DelFlag)";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@jobNo",jobno.jobNo),
                new SQLiteParameter("@userName",jobno.userName),
                new SQLiteParameter("@SignYear",jobno.SignYear),
                new SQLiteParameter("@Dvalid",jobno.Dvalid),
                new SQLiteParameter("@Lvalid",jobno.Lvalid),
                new SQLiteParameter("@PressureMax",jobno.PressureMax),
                new SQLiteParameter("@TempMax",jobno.TempMax),
                new SQLiteParameter("@DelFlag",jobno.DelFlag)
            };
            return SQLiteHelper.ExecuteNonQuery(sql,pms);
        }
        public int ModifyMemberInfobyid(ScholzJobNo jobno,int id)
        {
            string sql = "update Scholz set userName=@userName,jobNo=@jobno,SignYear=@signy,Dvalid=@validD,Lvalid=@validL,PressureMax=@txtP,TempMax=@txtT,DelFlag=@DelFlag where id=@id";
            SQLiteParameter[] pms =
            {
                new SQLiteParameter("@userName",jobno.userName),
                new SQLiteParameter("@jobno",jobno.jobNo),               
                new SQLiteParameter("@signy",jobno.SignYear),
                new SQLiteParameter("@validD",jobno.Dvalid),
                new SQLiteParameter("@validL",jobno.Lvalid),
                new SQLiteParameter("@txtP",jobno.PressureMax),
                new SQLiteParameter("@txtT",jobno.TempMax),
                new SQLiteParameter("@DelFlag",jobno.DelFlag),
                new SQLiteParameter("@id",id)
            };
            return SQLiteHelper.ExecuteNonQuery(sql, pms);
        }
        private void LoadEntity(ScholzJobNo memberinfo, DataRow row)
        {
            memberinfo.id = Convert.ToInt32(row["id"]);
            memberinfo.jobNo = row["jobNo"].ToString();
            memberinfo.userName = row["userName"].ToString();
            memberinfo.SignYear = row["SignYear"].ToString();
            memberinfo.Dvalid = row["Dvalid"].ToString();
            memberinfo.Lvalid = row["Lvalid"].ToString();
            memberinfo.PressureMax = row["PressureMax"].ToString();
            memberinfo.TempMax = row["TempMax"].ToString();
            memberinfo.DelFlag = row["DelFlag"]==DBNull.Value?false:Convert.ToBoolean(row["DelFlag"]);
        }

        public List<ScholzJobNo> LoadExcel2Datatable(string filePath)
        {

            DataTable dt = CommonHelper.ToDataTable(filePath);
            List<ScholzJobNo> list = null;
            if (dt.Rows.Count > 0)
            {
                int id = 1;
                list = new List<ScholzJobNo>();
                ScholzJobNo memberinfo = null;
                foreach (DataRow row in dt.Rows)
                {
                    memberinfo = new ScholzJobNo();
                    LoadEntity(memberinfo, row, id);
                    list.Add(memberinfo);
                    id++;
                }
            }
            return list;
        }

        private void LoadEntity(ScholzJobNo memberinfo, DataRow row, int id)
        {
            memberinfo.id = id;
            memberinfo.userName = row[0].ToString();
            memberinfo.jobNo = row[1].ToString();
            memberinfo.SignYear =row[2].ToString();
            memberinfo.Dvalid = row[3].ToString();
            memberinfo.Lvalid = row[4].ToString();
            memberinfo.PressureMax = row[5].ToString();
            memberinfo.TempMax = row[6].ToString();
            memberinfo.DelFlag = false;
        }
    }
}
