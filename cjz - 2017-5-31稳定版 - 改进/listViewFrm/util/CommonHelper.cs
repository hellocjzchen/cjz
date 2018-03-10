using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace MyUtils
{
    public class CommonHelper
    {
        /// <summary>
        /// 获取目录下的子目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetSubFolder(string path)
        {
            return Directory.GetDirectories(path);
        }
        /// <summary>
        /// 获取目录下的子文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetSubFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        /// <summary>
        /// 获取一个拥有完整路径文件名的文件名和路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetFileNameandPath(string path)
        {
            string[] str = new string[2];
            int index = path.LastIndexOf(@"\");

            str[0] = path.Substring(index + 1, path.Length - index - 1);
            str[1] = path.Substring(0, index) + @"\";
            return str;
        }
        /// <summary>
        /// 将路径拆分成两部分，一部分是名字，另一部分是路径，放到hashtable中
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Hashtable GetFileNameAndPathToHashtable(string path)
        {
            string[] str = new string[2];
            int index = path.LastIndexOf(@"\");
            Hashtable tb = new Hashtable();
            tb.Add(path.Substring(index + 1, path.Length - index - 1), path.Substring(0, index) + @"\");
            return tb;
        }
        /// <summary>
        /// 获取文件目录下所有的子文件的文件名和文件路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Hashtable GetFolderSubFileName(string path)
        {
            string[] str = Directory.GetDirectories(path);

            Hashtable hashtbl = new Hashtable();
            for (int i = 0; i < str.Length; i++)
            {
                hashtbl.Add(GetFileNameandPath(str[i])[0], GetFileNameandPath(str[i])[1]);
            }
            return hashtbl;
        }
        public static string[] GetFoldbFileName(string path)
        {
            string[] str = Directory.GetDirectories(path);

            string[] foldername = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foldername[i] = GetFileNameandPath(str[i])[0];
            }
            return foldername;
        }

        /// <summary>
        /// 调用cmd命令
        /// </summary>
        /// <param name="cmdArgs"></param>
        /// <returns></returns>
        public static string InvokeCmd(string cmdArgs)
        {
            string Tstr = "";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            p.StandardInput.WriteLine(cmdArgs);
            p.StandardInput.WriteLine("exit");
            Tstr = p.StandardOutput.ReadToEnd();
            p.Close();
            return Tstr;
        }
        public static Hashtable SetHashTable(string key, string value)
        {
            try
            {
                Hashtable tb = new Hashtable();
                tb.Add(key, value);
                return tb;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #region 获取文件图标
        [DllImport("shell32.DLL", EntryPoint = "ExtractAssociatedIcon")]
        private static extern int ExtractAssociatedIconA(int hInst, string lpIconPath, ref int lpiIcon); //声明函数
        static System.IntPtr thisHandle;
        public static System.Drawing.Icon GetIcon(string s)//S是要获取文件路径，返回ico格式文件
        {
            int RefInt = 0;
            thisHandle = new IntPtr(ExtractAssociatedIconA(0, s, ref RefInt));
            return System.Drawing.Icon.FromHandle(thisHandle);
        }
        #endregion
        #region 文件夹操作
        /// 复制文件夹中的所有文件夹与文件到另一个文件夹
        /// </summary>
        /// <param name="sourcePath">源文件夹</param>
        /// <param name="destPath">目标文件夹</param>
        public static void CopyFolder(string sourcePath, string destPath)
        {
            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destPath))
                {
                    //目标目录不存在则创建
                    try
                    {
                        Directory.CreateDirectory(destPath);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("创建目标目录失败：" + ex.Message);
                    }
                }
                //获得源文件下所有文件
                List<string> files = new List<string>(Directory.GetFiles(sourcePath));
                files.ForEach(c =>
                {
                    string destFile = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    File.Copy(c, destFile, true);//覆盖模式
                });
                //获得源文件下所有目录文件
                List<string> folders = new List<string>(Directory.GetDirectories(sourcePath));
                folders.ForEach(c =>
                {
                    string destDir = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    //采用递归的方法实现
                    CopyFolder(c, destDir);
                });
            }
            else
            {
                throw new DirectoryNotFoundException("源目录不存在！");
            }
        }
        #endregion
        #region 数字转换大小写
        //将阿拉伯数字转成大写中文 
        public static string num2String(double num)
        {
            if (num >= 1000000000)
            {
                Console.WriteLine("num is too large");
                return "";
            }
            string result = "";
            string front = "";//整数部分 
            string back = "";//小数部分 
            string[] num_strs = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };//大写数字数组 
            string[] num_dw = { "", "拾", "佰", "仟", "万", "拾万", "佰万", "仟万", "亿" };//大写数字单位数组 
            string[] money_dw = { "分", "角", "圆" };//人民币单位数组 
            string str_num = num.ToString();
            string[] strs = str_num.Split('.');
            if (num < 0)//负数的话 
            {
                result += "负";
                str_num = str_num.Replace("-", "");
            }

            int num_f = 0;//整数部分 
            int num_back = 0;//小数部分 

            if (strs.Length == 2)
            {
                front = strs[0];
                back = strs[1];

                num_f = Convert.ToInt32(front);
                num_back = Convert.ToInt32(back);


            }
            else
            {
                front = num.ToString();
                num_f = Convert.ToInt32(front);
            }

            for (int i = 8; i >= 0; i--)//从八个0 就是亿开始 
            {
                string cs = "1";//除数 
                for (int j = 1; j <= i; j++)//除数补零 
                {
                    cs += "0";
                }
                int num_cs = Convert.ToInt32(cs);
                int s = num_f / num_cs;//商 
                if (s == 0)//商为0意味着除数没有这么大 直接跳到下一次循环 
                {
                    continue;
                }
                else
                {
                    result += num_strs[s] + num_dw[i];//针对这一位生成结果 
                    num_f = num_f % num_cs;//整数部分重新赋值成余数继续循环 
                }
            }
            result += money_dw[2];//整数位添加货币单位 
            //以下针对结果进行处理使之合理化 
            //循环加零 如2003 不处理将是两千三圆 处理后为两千零三圆 
            //算法为在数字单位数组中从佰开始遍历（第三位）找结果字符串中是否含有它的上一位 如没有则需在此单位的下一位置加入一个“零” 
            for (int i = 2; i < num_dw.Length; i++)
            {
                if (result.IndexOf(num_dw[i]) == -1)
                {
                    continue;
                }

                if (result.IndexOf(num_dw[i - 1]) == -1)
                {
                    result = result.Insert(result.IndexOf(num_dw[i]) + 1, "零");
                }
            }
            //以下处理多出的“万” 如出现二十万两万。。。应为二十二万 
            //算法为保留最后出现的万字 其他去掉 
            string[] strs1 = result.Split('万');
            result = "";
            //以万字拆分字符串后 遍历结果数组 在结果数组的前一位加上万字 
            for (int i = 0; i < strs1.Length; i++)
            {
                result += strs1[i];
                if (i == strs1.Length - 2)
                {
                    result += "万";
                }

            }
            //以下处理录入0时 直接生成零圆 
            if (result == money_dw[2])
            {
                result = "零" + money_dw[2];
            }

            //小数部分处理 
            if (back != null && back != "")
            {
                if (back.Length > 2)//只截取前两位 到分 在小的无货币单位支持 没有意义 
                {
                    back = back.Substring(0, 2);
                }
                num_back = Convert.ToInt32(back);

                int s = num_back / 10;
                int ys = num_back % 10;
                if (s == 0)//只有角一位 
                {
                    result += (num_strs[ys] + money_dw[1]);
                }
                else
                {
                    result += (num_strs[s] + money_dw[1] + num_strs[ys] + money_dw[0]);
                }
            }

            return result;
        }
        #endregion

        public static void loadFileAndFolder(string path, ListView listView1, ImageList largeimagelist,ImageList smallimagelist)
        {
            #region 初始化各个列表
            DirectoryInfo folderinfo = new DirectoryInfo(path);
            listView1.Clear();
            listView1.Items.Clear();
            largeimagelist.Images.Clear();
            #endregion
            #region 数据装载到itemlist中
            ListViewItem item;

            #region 装载文件
            List<ListViewItem> viewitemlist = new List<ListViewItem>();
            int filecount = 0;
            FileInfo[] filelist = folderinfo.GetFiles();
            if (filelist.Length > 0)
            {
                filecount = filelist.Length;
                for (int j = 0; j < filelist.Length; j++)
                {
                    Icon ico = SystemIcon.GetFileIcon(filelist[j].FullName, false);
                    largeimagelist.Images.Add(ico);
                    smallimagelist.Images.Add(ico);
                    item = new ListViewItem();
                    item.Text = filelist[j].Name;
                    item.ImageIndex = j;
                    item.Tag = filelist[j].FullName;
                    item.SubItems.Add(filelist[j].LastAccessTime.ToShortDateString());
                    viewitemlist.Add(item);
                }
            }

            #endregion
            #region 装载文件夹
            DirectoryInfo[] dirlist = folderinfo.GetDirectories();
            if (dirlist.Length > 0)
            {
                for (int i = 0; i < dirlist.Length; i++)
                {
                    long iconvalue = 0;
                    Icon ico = SystemIcon.GetFolderIcon(dirlist[i].FullName, false, out iconvalue);
                    largeimagelist.Images.Add(ico);
                    smallimagelist.Images.Add(ico);
                    item = new ListViewItem();
                    item.Text = dirlist[i].Name;
                    item.ImageIndex = filecount + i;
                    item.Tag = dirlist[i].FullName;
                    item.SubItems.Add(dirlist[i].LastAccessTime.ToShortDateString());
                    item.ImageIndex = i + filecount;
                    viewitemlist.Add(item);
                }
            }
            #endregion
            #endregion

            #region 加载listview
            listView1.BeginUpdate();
            listView1.Items.AddRange(viewitemlist.ToArray());
            listView1.EndUpdate();
            #endregion
        }
        #region 方法
        /// <summary>
        /// 比较--两个类型一样的实体类对象的值
        /// </summary>
        /// <param name="oneT"></param>
        /// <returns></returns>
        public static bool CompareType<T>(T oneT, T twoT)
        {
            #region
            bool result = true;//两个类型作比较时使用,如果有不一样的就false
            Type typeOne = oneT.GetType();
            Type typeTwo = twoT.GetType();
            //如果两个T类型不一样  就不作比较
            if (!typeOne.Equals(typeTwo)) { return false; }
            PropertyInfo[] pisOne = typeOne.GetProperties(); //获取所有公共属性(Public)
            PropertyInfo[] pisTwo = typeTwo.GetProperties();
            //如果长度为0返回false
            if (pisOne.Length <= 0 || pisTwo.Length <= 0)
            {
                return false;
            }
            //如果长度不一样，返回false
            if (!(pisOne.Length.Equals(pisTwo.Length))) { return false; }
            //遍历两个T类型，遍历属性，并作比较
            for (int i = 0; i < pisOne.Length; i++)
            {
                //获取属性名
                string oneName = pisOne[i].Name;
                string twoName = pisTwo[i].Name;
                //获取属性的值
                object oneValue = pisOne[i].GetValue(oneT, null);
                object twoValue = pisTwo[i].GetValue(twoT, null);
                //比较,只比较值类型
                if ((pisOne[i].PropertyType.IsValueType || pisOne[i].PropertyType.Name.StartsWith("String")) && (pisTwo

[i].PropertyType.IsValueType || pisTwo[i].PropertyType.Name.StartsWith("String")))
                {
                    if (oneName.Equals(twoName))
                    {
                        if (oneValue == null)
                        {
                            if (twoValue != null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                        else if (oneValue != null)
                        {
                            if (twoValue != null)
                            {
                                if (!oneValue.Equals(twoValue))
                                {
                                    result = false;
                                    break; //如果有不一样的就退出循环
                                }
                            }
                            else if (twoValue == null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    //如果对象中的属性是实体类对象，递归遍历比较
                    bool b = CompareType(oneValue, twoValue);
                    if (!b) { result = b; break; }
                }
            }
            return result;
            #endregion
        }
        #endregion
    }
}
