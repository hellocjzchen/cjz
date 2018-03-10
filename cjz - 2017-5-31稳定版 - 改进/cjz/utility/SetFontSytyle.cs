using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cjz.utility
{
    public static class SetFontSytyle
    {
        #region =★=*=*=★= 设置选中字体样式 =★=*=*=★=  

        //1.粗体　2.斜体　3.下划线　4.删除线  
        //5.粗体+斜体　6.粗体+下划线　7.粗体+删除线　8.斜体+下划线　9.斜体+删除线　10.下划线+删除线  
        //11.斜体+下划线+删除线　12.粗体+下划线+删除线　13.粗体+斜体+删除线　14.粗体+斜体+下划线  
        //15.粗、斜、下、删  


        /// <summary> 设置选中字体样式(1) <para>　</para>  
        /// 此方法有五种形式:<para>　</para>  
        /// 1.)只改变字体大小　<para></para>2.)在1的基本上，粗、斜体、下划线、删除线样式　  
        /// <para></para>3.)在2的基本上，高亮模式(字体上色)<para>　</para>  
        /// 4.)可同时设置〖FontStyle〗多样化　<para></para>5.)在4的基本上设置字体颜色<para>　</para></summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="fontsize">设置选中字体大小，设置时应为(0.5)的倍数。</param>  
        public static void changeFontSize(RichTextBox rich, float fontsize)
        {
            int selStart = rich.SelectionStart;
            int selLen = rich.SelectionLength;
            int selEnd = selStart + selLen;

            changeHelp(rich, selStart, selEnd, fontsize);

            rich.Select(selStart, selLen);
        }

        /// <summary> 设置选中字体样式(2) <para>　</para>  
        /// 此方法有五种形式:<para>　</para>  
        /// 1.)只改变字体大小　<para></para>2.)在1的基本上，粗、斜体、下划线、删除线样式　  
        /// <para></para>3.)在2的基本上，高亮模式(字体上色)<para>　</para>  
        /// 4.)可同时设置〖FontStyle〗多样化　<para></para>5.)在4的基本上设置字体颜色 </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="fontsize">设置选中字体大小，设置时应为(0.5)的倍数。</param>  
        /// <param name="style">字体样式:普通，粗体，斜体，删除线，下划线 样式</param>  
        public static void changeFontSize(RichTextBox rich, float fontsize, FontStyle style)
        {
            int selStart = rich.SelectionStart;
            int selLen = rich.SelectionLength;
            int selEnd = selStart + selLen;

            changeHelp(rich, selStart, selEnd, fontsize, style);

            rich.Select(selStart, selLen);
        }

        /// <summary> 设置选中字体样式(3) <para>　</para>  
        /// 此方法有五种形式:<para>　</para>  
        /// 1.)只改变字体大小　<para></para>2.)在1的基本上，粗、斜体、下划线、删除线样式　  
        /// <para></para>3.)在2的基本上，高亮模式(字体上色)<para>　</para>  
        /// 4.)可同时设置〖FontStyle〗多样化　<para></para>5.)在4的基本上设置字体颜色 </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="fontsize">设置选中字体大小，设置时应为(0.5)的倍数。</param>  
        /// <param name="style">字体样式:普通，粗体，斜体，删除线，下划线 样式</param>  
        /// <param name="color">设置选中字体颜色</param>  
        public static void changeFontSize(RichTextBox rich, float fontsize, FontStyle style, Color color)
        {
            int selStart = rich.SelectionStart;
            int selLen = rich.SelectionLength;
            int selEnd = selStart + selLen;

            changeHelp(rich, selStart, selEnd, fontsize, style, color);

            rich.Select(selStart, selLen);
        }

        /// <summary> 设置选中字体样式(4) <para>　</para>  
        /// 此方法有五种形式:<para></para>  
        /// 1.)只改变字体大小　<para></para>2.)在1的基本上，粗、斜体、下划线、删除线样式　  
        /// <para></para>3.)在2的基本上，高亮模式(字体上色)<para></para>  
        /// 4.)可同时设置〖FontStyle〗多样化　<para></para>5.)在4的基本上设置字体颜色 </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="fontsize">设置选中字体大小，设置时应为(0.5)的倍数。</param>  
        /// <param name="cont">Int值 十六种字体样式 以下数字代表：<para></para>  
        /// 1.粗体　2.斜体　3.下划线　4.删除线　<para></para>  
        /// 5.粗体+斜体　6.粗体+下划线　7.粗体+删除线　8.斜体+下划线　9.斜体+删除线　10.下划线+删除线<para></para>  
        /// 11.斜体+下划线+删除线　12.粗体+下划线+删除线　13.粗体+斜体+删除线　14.粗体+斜体+下划线<para></para>  
        /// 15.粗、斜、下、删</param>  
        public static void changeFontSize(RichTextBox rich, float fontsize, int cont)
        {
            int selStart = rich.SelectionStart;
            int selLen = rich.SelectionLength;
            int selEnd = selStart + selLen;

            changeHelp(rich, selStart, selEnd, fontsize, FontStyleBius(cont));

            rich.Select(selStart, selLen);
        }

        /// <summary> 设置选中字体样式(5) <para>　</para>  
        /// 此方法有五种形式:<para></para>  
        /// 1.)只改变字体大小　<para></para>2.)在1的基本上，粗、斜体、下划线、删除线样式　  
        /// <para></para>3.)在2的基本上，高亮模式(字体上色)<para></para>  
        /// 4.)可同时设置〖FontStyle〗多样化　<para></para>5.)在4的基本上设置字体颜色 </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="fontsize">设置选中字体大小，设置时应为(0.5)的倍数。</param>  
        /// <param name="cont">Int值 十六种字体样式 以下数字代表：<para></para>  
        /// 1.粗体　2.斜体　3.下划线　4.删除线　<para></para>  
        /// 5.粗体+斜体　6.粗体+下划线　7.粗体+删除线　8.斜体+下划线　9.斜体+删除线　10.下划线+删除线<para></para>  
        /// 11.斜体+下划线+删除线　12.粗体+下划线+删除线　13.粗体+斜体+删除线　14.粗体+斜体+下划线<para></para>  
        /// 15.粗、斜、下、删</param>  
        /// <param name="color">设置选中字体颜色</param>  
        public static void changeFontSize(RichTextBox rich, float fontsize, int cont, Color color)
        {
            int selStart = rich.SelectionStart;
            int selLen = rich.SelectionLength;
            int selEnd = selStart + selLen;

            changeHelp(rich, selStart, selEnd, fontsize, FontStyleBius(cont), color);

            rich.Select(selStart, selLen);
        }
        #endregion



        #region =★=*=*=★= 设置字体样式〖调用方法〗 =★=*=*=★=  
        /// <summary> 设置字体样式(一)  
        /// <para></para> </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="start">选中文本位置，从(0)开始计算</param>  
        /// <param name="end">选中文本长度</param>  
        /// <param name="fontsize">设置选中字体大小</param>  
        private static void changeHelp(RichTextBox rich, int start, int length, float fontsize)
        {
            rich.Select(start, length - start);

            if (rich.SelectionFont != null)
            {
                Font oldFont = rich.SelectionFont;

                rich.SelectionFont = new Font(oldFont.Name, fontsize);
            }
            else
            {
                int mid = (start + length) / 2;

                changeHelp(rich, start, mid, fontsize);
                changeHelp(rich, mid, length, fontsize);
            }
        }

        /// <summary> 设置字体样式(二)  
        /// <para></para> </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="start">选中文本位置，从(0)开始计算</param>  
        /// <param name="end">选中文本长度</param>  
        /// <param name="fontsize">设置选中字体大小</param>  
        /// <param name="style">字体样式:普通，粗体，斜体，删除线，下划线 样式</param>  
        private static void changeHelp(RichTextBox rich, int start, int length, float fontsize, FontStyle style)
        {
            rich.Select(start, length - start);

            if (rich.SelectionFont != null)
            {
                Font oldFont = rich.SelectionFont;

                rich.SelectionFont = new Font(oldFont.Name, fontsize, style);
            }
            else
            {
                int mid = (start + length) / 2;

                changeHelp(rich, start, mid, fontsize, style);
                changeHelp(rich, mid, length, fontsize, style);
            }
        }

        /// <summary> 设置字体样式(三)  
        /// <para></para> </summary>  
        /// <param name="rich">RichTextBox 控件</param>  
        /// <param name="start">选中文本位置，从(0)开始计算</param>  
        /// <param name="end">选中文本长度</param>  
        /// <param name="fontsize">设置选中字体大小</param>  
        /// <param name="style">字体样式:普通，粗体，斜体，删除线，下划线 样式</param>  
        /// <param name="color">设置字体颜色</param>  
        private static void changeHelp(RichTextBox rich, int start, int length, float fontsize, FontStyle style, Color color)
        {
            rich.Select(start, length - start);

            if (rich.SelectionFont != null)
            {
                Font oldFont = rich.SelectionFont;

                rich.SelectionFont = new Font(oldFont.Name, fontsize, style);
                rich.SelectionColor = color;
            }
            else
            {
                int mid = (start + length) / 2;

                changeHelp(rich, start, mid, fontsize, style, color);
                changeHelp(rich, mid, length, fontsize, style, color);
            }
        }

        /// <summary> FontStyle 多样化 </summary>  
        /// <param name="i"></param>  
        /// <returns></returns>  
        private static FontStyle FontStyleBius(int i)
        {
            FontStyle style;
            switch (i)
            {
                case 1:
                    style = FontStyle.Bold;
                    return style;
                case 2:
                    style = FontStyle.Italic;
                    return style;
                case 3:
                    style = FontStyle.Underline;
                    return style;
                case 4:
                    style = FontStyle.Strikeout;
                    return style;
                case 5:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Italic);
                    return style;
                case 6:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Underline);
                    return style;
                case 7:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Strikeout);
                    return style;
                case 8:
                    style = (FontStyle)(FontStyle.Italic | FontStyle.Underline);
                    return style;
                case 9:
                    style = (FontStyle)(FontStyle.Italic | FontStyle.Strikeout);
                    return style;
                case 10:
                    style = (FontStyle)(FontStyle.Underline | FontStyle.Strikeout);
                    return style;
                case 11:
                    style = (FontStyle)(FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                    return style;
                case 12:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
                    return style;
                case 13:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
                    return style;
                case 14:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    return style;
                case 15:
                    style = (FontStyle)(FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                    return style;

                default:
                    style = FontStyle.Regular;
                    return style;
            }
        }

        #endregion
    }
 }
