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
    public class CmpProjectDAL
    {
        public List<CmpProject> GetMemberList()
        {
            string sql = "select * from CmpProject";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<CmpProject> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<CmpProject>();
                CmpProject memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new CmpProject();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<CmpProject> GetMemberListByCustomer(string custmer)
        {
            string sql = "select * from CmpProject where mcustomer=@customer";

            DataTable da = SQLiteHelper.ExecteDataTable(sql, new SQLiteParameter("@customer", custmer));
            List<CmpProject> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<CmpProject>();
                CmpProject memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new CmpProject();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<CmpProject> GetMemberListBySupplier(string suuplier)
        {
            string sql = "select * from CmpProject where mSupplier=@suplier";

            DataTable da = SQLiteHelper.ExecteDataTable(sql, new SQLiteParameter("@suplier", suuplier));
            List<CmpProject> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<CmpProject>();
                CmpProject memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new CmpProject();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<CmpProject> GetMemberListByPjManager(string Manager)
        {
            string sql = "select * from CmpProject where pjManager like '%'||@xxx||'%';";
            DataTable da = SQLiteHelper.ExecteDataTable(sql, new SQLiteParameter("@xxx",Manager));          
            List<CmpProject> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<CmpProject>();
                CmpProject memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new CmpProject();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            return list;
        }
        public List<CmpProject> GetMemberlistByUnionSearch(String guest,string suppl,string gm)
        {
            string sql = "select * from CmpProject where mcustomer like '%'||@cust||'%' and mSupplier like '%'||@supplier||'%' and pjManager like '%'||@pjgm||'%' ;";
            SQLiteParameter[] pms = {
                new SQLiteParameter("@cust",guest),
                new SQLiteParameter("@supplier",suppl),
                new SQLiteParameter("@pjgm",gm)
            };
            List<CmpProject> list = null;
            try
            {
                DataTable da = SQLiteHelper.ExecteDataTable(sql, pms);
                if (da.Rows.Count > 0)
                {
                    list = new List<CmpProject>();
                    CmpProject memberinfo = null;
                    foreach (DataRow row in da.Rows)
                    {
                        memberinfo = new CmpProject();
                        LoadEntity(memberinfo, row);
                        list.Add(memberinfo);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return list;
            }
        }
        public List<string> Getcustomer()
        {
            string sql = "select mcustomer from CmpProject";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<string> usrlist = null;
            if (da.Rows.Count > 0)
            {
                usrlist = new List<string>();
                string ur;
                foreach (DataRow row in da.Rows)
                {
                    ur = row["mcustomer"].ToString();
                    if (!usrlist.Contains(ur))
                    {
                        usrlist.Add(ur);
                    }

                }
            }
            return usrlist;
        }
        public List<string> GetSupplier()
        {
            string sql = "select mSupplier from CmpProject";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<string> Supplierlist = null;
            if (da.Rows.Count > 0)
            {
                Supplierlist = new List<string>();
                string ur;
                foreach (DataRow row in da.Rows)
                {
                    ur = row["mSupplier"].ToString();
                    if (!Supplierlist.Contains(ur))
                    {
                        Supplierlist.Add(ur);
                    }

                }
            }
            return Supplierlist;
        }
        public List<string> GetpjManager()
        {
            string sql = "select pjManager from CmpProject";
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<string> pjManagerlist = null;
            if (da.Rows.Count > 0)
            {
                pjManagerlist = new List<string>();
                string ur;
                foreach (DataRow row in da.Rows)
                {
                    ur = row["pjManager"].ToString().Trim();
                    if (ur.Contains('，') || ur.Contains('、'))
                    {
                        if (ur.Contains('，'))
                        {
                            string[] str1 = ur.Split('，');
                            for (int i = 0; i < str1.Length; i++)
                            {
                                if (!pjManagerlist.Contains(str1[i]))
                                {
                                    pjManagerlist.Add(str1[i]);
                                }
                            }
                            continue;
                        }
                        if (ur.Contains('、'))
                        {
                            string[] str2 = ur.Split('、');
                            for (int i = 0; i < str2.Length; i++)
                            {
                                if (!pjManagerlist.Contains(str2[i]))
                                {
                                    pjManagerlist.Add(str2[i]);
                                }
                            }
                            continue;
                        }
                       
                    }
                    if (!pjManagerlist.Contains(ur))
                    {
                        pjManagerlist.Add(ur);
                    }

                }
            }
            return pjManagerlist;
        }

        public int InsertMemberInfo(CmpProject cmppj)
        {
            try
            {
                string sql = "insert into CmpProject values(null,@PID,@cust,@Supp ,@CDate,@pjDis,@pjMa,@nt,@pjSta)";
                SQLiteParameter[] pms = {
                new SQLiteParameter("@PID",cmppj.ProjectID),
                new SQLiteParameter("@cust",cmppj.customer),
                new SQLiteParameter("@Supp",cmppj.Supplier),
                new SQLiteParameter("@CDate",cmppj.CreateDate),
                new SQLiteParameter("@pjDis",cmppj.pjDiscription),
                new SQLiteParameter("@pjMa",cmppj.pjManager),
                new SQLiteParameter("@nt",cmppj.note),
                new SQLiteParameter("@pjSta",cmppj.pjStatus)
            };
                return SQLiteHelper.ExecuteNonQuery(sql, pms);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int SetId2Original()
        {
            string sql = "update sqlite_sequence set seq=0 where name='CmpProject'";
            return SQLiteHelper.ExecuteNonQuery(sql);
        }
        public bool InsertMemberlist(List<CmpProject> list)
        {
            try
            {
                if (list.Count > 0)
                {
                    List<KeyValuePair<string, SQLiteParameter[]>> mlist = new List<KeyValuePair<string, SQLiteParameter[]>>();

                    string sql = "INSERT INTO CmpProject VALUES (null,@mProjectID,@customer,@Supplier ,@mCreateDate,@mpjDiscription,@mpjManager,@mnote,@mpjStatus)";
                    KeyValuePair<string, SQLiteParameter[]> mpair;
                    
                    foreach (CmpProject cmppj in list)
                    {
                        SQLiteParameter[] pms = {
                                                    new SQLiteParameter("@mProjectID",cmppj.ProjectID),
                                                    new SQLiteParameter("@customer",cmppj.customer),
                                                    new SQLiteParameter("@Supplier",cmppj.Supplier),
                                                    new SQLiteParameter("@mCreateDate",cmppj.CreateDate),
                                                    new SQLiteParameter("@mpjDiscription",cmppj.pjDiscription),
                                                    new SQLiteParameter("@mpjManager",cmppj.pjManager),
                                                    new SQLiteParameter("@mnote",cmppj.note),
                                                    new SQLiteParameter("@mpjStatus",cmppj.pjStatus)
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
        public int ModifyMemberInfobyid(CmpProject cmppj, int id)
        {
            try
            {
                string sql = "update CmpProject set ProjectID=@ProjectID,mcustomer=@customer,mSupplier=@Supplier,CreateDate=@CreateDate,pjDiscription=@pjDiscription,pjManager=@pjManager,note=@note,pjStatus=@pjStatus where id=@id";
                SQLiteParameter[] pms =
                {
                new SQLiteParameter("@ProjectID",cmppj.ProjectID),
                new SQLiteParameter("@customer",cmppj.customer),
                new SQLiteParameter("@Supplier",cmppj.Supplier),
                new SQLiteParameter("@CreateDate",cmppj.CreateDate),
                new SQLiteParameter("@pjDiscription",cmppj.pjDiscription),
                new SQLiteParameter("@pjManager",cmppj.pjManager),
                new SQLiteParameter("@note",cmppj.note),
                new SQLiteParameter("@pjStatus",cmppj.pjStatus),
                new SQLiteParameter("@id",id)
            };
                return SQLiteHelper.ExecuteNonQuery(sql, pms);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public List<CmpProject> LoadExcel2Datatable(string filePath)
        {
           
            DataTable dt = CommonHelper.ToDataTable(filePath);
            List<CmpProject> list = null;
            if (dt.Rows.Count > 0)
            {
                int id = 1;
                list = new List<CmpProject>();
                CmpProject memberinfo = null;
                foreach (DataRow row in dt.Rows)
                {
                    memberinfo = new CmpProject();
                    LoadEntity(memberinfo, row,id);
                    list.Add(memberinfo);
                    id++;
                }
            }
            return list;
        }

        public int EmptyDatabaseTable()
        {
            try
            {
                string sql = "delete from CmpProject";
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

        private void LoadEntity(CmpProject memberinfo, DataRow row)
        {
            memberinfo.id = Convert.ToInt32(row["id"]);
            memberinfo.ProjectID = row["ProjectID"].ToString();
            memberinfo.customer = row["mcustomer"].ToString();
            memberinfo.Supplier = row["mSupplier"].ToString();
            memberinfo.CreateDate =Convert.ToDateTime( row["CreateDate"].ToString()).ToShortDateString().ToString();
            memberinfo.pjDiscription = row["pjDiscription"].ToString();
            memberinfo.pjManager = row["pjManager"].ToString();
            memberinfo.note = row["note"].ToString();
            memberinfo.pjStatus = row["pjStatus"].ToString();
        }
        private void LoadEntity(CmpProject memberinfo, DataRow row,int id)
        {
            memberinfo.id = id;
            memberinfo.ProjectID = row[0].ToString();
            memberinfo.customer = row[1].ToString();
            memberinfo.Supplier = row[2].ToString();
            memberinfo.CreateDate =Convert.ToDateTime( row[3].ToString()).ToShortDateString().ToString();
            memberinfo.pjDiscription = row[4].ToString();
            memberinfo.pjManager = row[5].ToString();
            memberinfo.note = row[6].ToString();
            memberinfo.pjStatus = row[7].ToString();
        }

    }
}
