
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz
{
    public class travelInfoBLL
    {
        travelInfoDAL dal;
      public  travelInfoBLL()
        {
            dal = new travelInfoDAL();
        }
        public ZongJie getZongJie()
        {
            return dal.getZongJie();
        }


        #region 添加新数据
        public bool AddNew(travelInfo info)
        {
            return dal.AddNew(info);
        }
        #endregion
        #region 修改数据
        public bool ModifyData(travelInfo info, int index)
        {
            return dal.ModifyData(info, index);
        }
        #endregion
        //添加借款
        public bool addBorrowM(string borrowM)
        { return dal.addBorrowM(borrowM); }
        #region 添加标题
        public bool addTitle(string title)
        {
            return dal.addTitle(title);
        }
        #endregion                

        #region 所有数据全部写入到excel中       
        public bool ZongJie2Excel(string excelpath,  int col)
        {
            return dal.ZongJie2Excel(excelpath, col);
        }
        #endregion      

        #region 读取excel到zongjie中
        public void excel2ZongJie(string strFileName)
        {
             dal.excel2ZongJie(strFileName);
        }
        #endregion
        #region 系列化
        public void serialize_zongjie(string path)
        { dal.serialize_zongjie(path); }
        #endregion
        #region 反系列化
        public void deserialize_zongjie(string path)
        { dal.deserialize_zongjie(path); }
        #endregion
        //#region 添加数据到数据表中供显示
        //public DataTable AddToDt(travelInfo info, DataTable dt)
        //{ return dal.AddToDt(info, dt); }
        //#endregion

        //#region 读取excel中的数据到dt中
        //public static System.Data.DataTable ReadExcel(String strFileName, int startrow, int startcol, int readrows, int readcols)
        //{
        //    return travelInfoDAL.ReadExcel(strFileName, startrow, startcol, readrows, readcols);
        //}
        //#endregion

        //#region 将list中的数据转到dt中
        //public DataTable list2Dt(ZongJie zongjie)
        //{ return dal.list2Dt(zongjie); }
        //#endregion

        //#region 数据表中的数据到excel，应该不用       
        //public bool Dt2Excel(string strfileName, ZongJie zongjie, int startrow, int col)
        //{
        //    return dal.Dt2Excel(strfileName, zongjie, startrow, col);
        //}
        //#endregion
    }
}
