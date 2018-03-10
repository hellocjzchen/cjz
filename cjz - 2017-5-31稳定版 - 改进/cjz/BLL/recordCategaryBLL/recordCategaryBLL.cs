using cjz.DAL.recordCategaryDAL;
using cjz.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz.BLL.recordCategaryBLL
{
    public  class recordCategaryBLL
    {
        recordCategaryDAL dal = new recordCategaryDAL();
        public List<recordCategary> GetrecordCategaryList()
        {
            return dal.GetrecordCategaryList();
        }
        public bool InsertrecordCategaryInfo(recordCategary categary)
        {
            return dal.InsertrecordCategaryInfo(categary) > 0;
        }
        public bool updaterCategaryByID(recordCategary cat)
        {
            return dal.updaterCategaryByID(cat);
        }
        public bool DeleteItemByName(string name)
        {
            return dal.DeleteItemByName(name);
        }
    }
}
