using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using System.Threading;
namespace cjz
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bCreatedNew;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //单例
            Mutex m = new Mutex(false, "cjz", out bCreatedNew);
            if (bCreatedNew)
            {
                Application.Run(new MainFrm());
            }
                
        }
    }
}
