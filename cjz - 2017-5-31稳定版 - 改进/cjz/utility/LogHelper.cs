using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using System.Reflection;
using System.Diagnostics;

namespace Utils
{
    //日志类
    class LogHelper
    {
        public static String logFileName = "history.log";

        public static void log(String message)
        {
            if (!File.Exists(logFileName))
            {
                File.CreateText(logFileName);
            }

            using (StreamWriter sw = File.AppendText(logFileName))
            {
                //获取调用者的信息
                StackTrace trace = new StackTrace();
                MethodBase method = trace.GetFrame(1).GetMethod();
                String methodInfo = method.DeclaringType.FullName + "." + method.Name + "()";

                //输出日期、调用者信息、message
                message = methodInfo + message;
                String strDate = DateTime.Now.ToString();
                sw.WriteLine("[ " + strDate + " ]: " + message);
            }
        }
    }
}