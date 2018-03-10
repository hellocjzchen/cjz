using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz
{
    public class ScholzJobNoBLL
    {
        ScholzJobNoDAL dal = new ScholzJobNoDAL();
        public List<ScholzJobNo> GetMemberList()
        {
            return dal.GetMemberList();
        }
        public bool DeleteMemberInfoByID(int id)
        {
            return dal.DeleteMemberInfoByID(id) > 0;
        }
        public List<ScholzJobNo> GetMemberListByUserName(string username)
        {
            return dal.GetMemberListByUserName(username);
        }
        public List<string> GetUserName()
        {
            return dal.GetUserName();
        }
        public bool InsertMemberInfo(ScholzJobNo jobno)
        {
            return dal.InsertMemberInfo(jobno) > 0;
        }
        public bool ModifyMemberInfobyid(ScholzJobNo jobno, int id)
        {
            return dal.ModifyMemberInfobyid(jobno, id) > 0;
        }
        public List<ScholzJobNo> LoadExcel2Datatable(string filePath)
        {
            return dal.LoadExcel2Datatable(filePath);
        }
        public bool InsertMemberlist(List<ScholzJobNo> list)
        {
            return dal.InsertMemberlist(list);
        }
        public bool EmptyDatabaseTable()
        {
            return dal.EmptyDatabaseTable() > 0;
        }
    }
}
