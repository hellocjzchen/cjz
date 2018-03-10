using cjz.DAL.RecContentDAL;
using cjz.module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz.BLL.RecContentBLL
{
   public class RecContentBLL
    {
         RecContentDAL dal = new RecContentDAL();
        public  List<RecContent> GetRecContentList()
        {
            return dal.GetRecContentList();
        }
        public string GetContentByID(int id)
        { return dal.GetContentByID(id); }
        public bool InsertMemberInfo(RecContent reccontent)
        {
            return dal.InsertMemberInfo(reccontent) > 0;
        }
        public DataTable GetAll()
        {
            return dal.GetAll();
        }
        public bool updaterRecNameByID(RecContent content)
        {
           return  dal.updaterRecNameByID(content);
        }
        public bool DeleteItemByName(string name)
        {
            return dal.DeleteItemByName(name);
        }
        public bool UpdateContentByID(int id, string str)
        {
            return dal.UpdateContentByID(id, str);
        }
    }
}
