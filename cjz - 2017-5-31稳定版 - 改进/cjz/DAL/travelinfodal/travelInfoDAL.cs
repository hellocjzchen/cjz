
using Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace cjz
{
    public class travelInfoDAL
    {

        ZongJie zongjie;
        public ZongJie getZongJie()
        {
            return zongjie;
        }
     public  travelInfoDAL()
        {
            zongjie = new ZongJie();
            initializeZongJie(zongjie);
        }
        #region 初始化数据
        public void initializeZongJie(ZongJie  zongjie )
        {
            if (zongjie.list == null)
            {
                zongjie.list = new List<travelInfo>();
            }
                zongjie.jiekuan = 0;
                zongjie.title = string.Empty;
                zongjie.addrowcount = 0;
                zongjie.baoxiaojine = 0;
                zongjie.totalbutie = 0;
                zongjie.totalfly = 0;
                zongjie.totalqita = 0;
                zongjie.totaltaxi = 0;
                zongjie.totaltrain = 0;
                zongjie.totalzhusu = 0;
                zongjie.totalzongshu = 0;
        }
        #endregion

        #region 添加新数据
        public bool AddNew(travelInfo info)
        {
            try
            {
                zongjie.list.Add(info);
                //计算添加的行数
                int len = zongjie.list.Count;
                zongjie.addrowcount++;
                //计算总额  
                
                zongjie.totalfly += (info.flyticket) ;
                zongjie.totaltrain += info.trainticket;
                zongjie.totaltaxi += info.taxiticket;
                zongjie.totalqita += info.otherpay;
                zongjie.totalzhusu += info.accomadationpay;
                zongjie.totalbutie += info.allowance;
                zongjie.totalzongshu += info.totalpay;
                //私人付款
                if (info.Ppayfly)
                {
                    zongjie.baoxiaojine += info.totalpay;
                }
                else
                {
                    //公司付款，报销金额-机票钱
                    zongjie.baoxiaojine += (info.totalpay - info.flyticket);
                }
                
                return true;
            }
            catch(Exception ex)
            {
                LogHelper.log(ex.Message);
                return false;
            }
           
        }
        #endregion
        #region 修改数据
        public bool ModifyData(travelInfo info,int index)
        {
            try
            {
                travelInfo olddata = zongjie.list[index];
                
                //计算总额  
                zongjie.totalfly += (info.flyticket-olddata.flyticket);
                zongjie.totaltrain +=( info.trainticket-olddata.trainticket);
                zongjie.totaltaxi += (info.taxiticket-olddata.taxiticket);
                zongjie.totalqita += (info.otherpay-olddata.otherpay);
                zongjie.totalzhusu += (info.accomadationpay-olddata.accomadationpay);
                zongjie.totalbutie +=( info.allowance-olddata.allowance);
                zongjie.totalzongshu +=( info.totalpay-olddata.totalpay);
                if (info.Ppayfly)
                {//私人付款
                    zongjie.baoxiaojine += (info.totalpay - olddata.totalpay - olddata.flyticket);
                }
                else
                {//公司付款
                    zongjie.baoxiaojine += (info.totalpay - olddata.totalpay - olddata.flyticket - info.flyticket);
                }
                
                //替换原来的class值
                zongjie.list[index] = info;
                return true;
            }
            catch(Exception ex)
            {
                LogHelper.log(ex.Message);
                return false;
            }

        }
        #endregion

        //添加借款
        public bool addBorrowM(string borrowM)
        {
            try
            {
                zongjie.jiekuan = float.Parse(borrowM);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
                return false;
                
            }
            
        }
        #region 添加标题和借款
        public bool addTitle(string title)
        {
            try
            {
                zongjie.title = title;
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.log(ex.Message);
                return false;                
            }
            
        }
        #endregion

        #region 读取excel到zongjie中
        public void excel2ZongJie(string strFileName)
        {
            try
            {
                Workbook book = new Workbook(strFileName);
                Worksheet sheet = book.Worksheets[0];
                Cells cells = sheet.Cells;
                int rows = cells.MaxDataRow+1;
                #region 零散数据添加
                zongjie.title = cells["A1"].StringValue;
                zongjie.baoxiaojine =Convert.ToSingle( cells[rows - 2, 2].Value);
                zongjie.jiekuan = Convert.ToSingle(cells[rows - 3, 2].Value);
                zongjie.totalfly = Convert.ToSingle(cells[rows - 4, 2].Value);
                zongjie.totaltaxi = Convert.ToSingle(cells[rows - 5, 3].Value);
                zongjie.totalqita = Convert.ToSingle(cells[rows - 5, 4].Value);
                zongjie.totalzhusu = Convert.ToSingle(cells[rows - 5, 5].Value);
                zongjie.totalbutie = Convert.ToSingle(cells[rows - 5, 6].Value);
                zongjie.totalzongshu = Convert.ToSingle(cells[rows - 5, 7].Value);
                #endregion
                travelInfo info;
                for (int i = 3; i <rows - 5; i++)
                {
                    info = new travelInfo();
                    info.dtime = cells[i, 0].StringValue;
                    info.summary = cells[i, 1].StringValue;
                    info.flyticket = Convert.ToSingle(cells[i, 2].Value);
                    info.taxiticket = Convert.ToSingle(cells[i, 3].Value);
                    info.otherpay = Convert.ToSingle(cells[i, 4].Value);
                    info.accomadationpay = Convert.ToSingle(cells[i, 5].Value);
                    info.allowance = Convert.ToSingle(cells[i, 6].Value);
                    info.totalpay = Convert.ToSingle(cells[i, 7].Value);   
                    zongjie.list.Add(info);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region 所有数据,即zongjie全部写入到excel中
        /// <summary>
        /// 所有数据写入excel中,先删除里面的数据，再全部重新填充
        /// </summary>
        /// <param name="excelpath">路径</param>
        /// <param name="zongjie">数据项</param>
        /// <param name="col">列数</param>
        /// <returns></returns>
        public bool ZongJie2Excel(string excelpath, int col)
        {
            try
            {
                Workbook book = new Workbook(excelpath);
                Worksheet sheet = book.Worksheets[0];
                Cells cells = sheet.Cells;
                cells[0, 0].PutValue(zongjie.title);
                if (cells.MaxDataRow > 8)
                {
                    cells.DeleteRows(3, cells.MaxDataRow - 7);
                }
                if (zongjie.list.Count > 0)
                {
                    sheet.Cells.InsertRows(3, zongjie.list.Count);
                }
                else return false;
                //接下来将数据填入。
                float companypayfly = 0;
                float ppayfly = 0;
                foreach (travelInfo item in zongjie.list)
                {
                    if (item.Ppayfly)
                    {
                        ppayfly += item.flyticket;
                    }
                    else
                    {
                        companypayfly+=item.flyticket;
                    }

                }
                int irow = 3;
                int index;
                int icol = col;
                travelInfo info;
                for (int i = 0; i < zongjie.list.Count; i++)
                {
                    index = irow + i;        
                    info = zongjie.list[i];
                    cells[index, 0].PutValue(info.dtime);
                    cells[index, 1].PutValue(info.summary);
                    cells[index, 2].PutValue(info.flyticket);
                    cells[index, 3].PutValue(info.taxiticket);
                    cells[index, 4].PutValue(info.otherpay);
                    cells[index, 5].PutValue(info.accomadationpay);
                    cells[index, 6].PutValue(info.allowance);
                   // cells[index, 7].PutValue(info.totalpay);
                    string f1 = string.Format("=SUM(C{0}:G{1})", index+1, index+1);
                    cells[index, 7].Formula = f1;
                    book.CalculateFormula(true);

                }          
                
                int rowindex = cells.MaxDataRow;
                //现金公司垫付机票
                // string f = string.Format("=C{0}", rowindex - 3);
                //cells[rowindex - 3, 2].Formula = f;
                cells[rowindex - 3, 2].PutValue(companypayfly);
                //现金报销金额
                //string f = string.Format("=H{0}-C{1}-C{2}",rowindex-3,rowindex-2,rowindex-1);
                //cells[rowindex - 1, 2].Formula = f;
                cells[rowindex - 1, 2].PutValue(zongjie.baoxiaojine );//可能有错
                //下边的合计
                string f2 = string.Format("=SUM(C{0}:C{1})",3,rowindex-4);
                string f3 = string.Format("=SUM(D{0}:D{1})", 3, rowindex - 4);
                string f4 = string.Format("=SUM(E{0}:E{1})", 3, rowindex - 4);
                string f5 = string.Format("=SUM(F{0}:F{1})", 3, rowindex - 4);
                string f6 = string.Format("=SUM(G{0}:G{1})", 3, rowindex - 4);
                string f7 = string.Format("=SUM(H{0}:H{1})", 3, rowindex - 4);
                book.CalculateFormula(true);
                //cells[rowindex - 3, 2].PutValue(zongjie.totalfly);
                //cells[rowindex - 2, 2].PutValue(zongjie.jiekuan);
                //cells[rowindex - 1, 2].PutValue(zongjie.baoxiaojine); 
                //写借款
                cells[rowindex - 2, 2].PutValue(zongjie.jiekuan);
                book.Save(excelpath);
                book = null;
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.log("writhe to excel fails" + ex.Message);
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region 系列化
        public void serialize_zongjie(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, zongjie);
                fs.Close();
            }   
        }
        #endregion
        #region 反系列化
        public void deserialize_zongjie(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo fi = new FileInfo(path);
                if (fi.Length == 0)
                {
                    initializeZongJie(this.zongjie);
                    return;
                }
                ZongJie zj = bf.Deserialize(fs) as ZongJie;
                this.zongjie = zj;
                fs.Close();
            }
        }
        #endregion

        //下面是连接到数据库
        public List<travelInfo> GetMemberList(string tableName)
        {
            string sql = "select * from " + tableName;
            DataTable da = SQLiteHelper.ExecteDataTable(sql);
            List<travelInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<travelInfo>();
                travelInfo memberinfo = null;
                foreach (DataRow row in da.Rows)
                {
                    memberinfo = new travelInfo();
                    LoadEntity(memberinfo, row);
                    list.Add(memberinfo);
                }
            }
            zongjie.list = list;
            return list;
        }

        private void LoadEntity(travelInfo memberinfo, DataRow row)
        {
            throw new NotImplementedException();
        }
    }
}
