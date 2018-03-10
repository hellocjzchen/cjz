using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz
{
    public class CmpProjectBLL
    {
        private CmpProjectDAL dal = new CmpProjectDAL();
        public List<CmpProject> GetMemberList()
        {
            return dal.GetMemberList();
        }
        public List<CmpProject> GetMemberListByCustomer(string custmer)
        {
            return dal.GetMemberListByCustomer(custmer);
        }
        public List<CmpProject> GetMemberListBySupplier(string suuplier)
        { return dal.GetMemberListBySupplier(suuplier); }
        public List<CmpProject> GetMemberListByPjManager(string Manager)
        {
            return dal.GetMemberListByPjManager(Manager);
        }
        public List<CmpProject> GetMemberlistByUnionSearch(String guest, string suppl, string gm)
        {
            return dal.GetMemberlistByUnionSearch(guest, suppl, gm);
        }
        public List<string> Getcustomer()
        {
            return dal.Getcustomer();
        }
        public List<string> GetSupplier()
        {
            return dal.GetSupplier();
        }
        public List<string> GetpjManager()
        {
            return dal.GetpjManager();
        }
        public int InsertMemberInfo(CmpProject cmppj)
        {
            return dal.InsertMemberInfo(cmppj);
        }
        public bool ModifyMemberInfobyid(CmpProject cmppj, int id)
        {
            return dal.ModifyMemberInfobyid(cmppj, id) > 0;
        }
        public List<CmpProject> LoadExcel2Datatable(string filePath)
        {
            return dal.LoadExcel2Datatable(filePath);
        }
        public bool InsertMemberlist(List<CmpProject> list)
        {
            return dal.InsertMemberlist(list);
        }
        public bool EmptyDatabaseTable()
        {
            return dal.EmptyDatabaseTable() > 0;
        }
        public bool SetId2Original()
        { return dal.SetId2Original()>0; }
    }
}
