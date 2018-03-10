using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace cjz.User_interface
{
    public partial class SystemManager : Form
    {
        public SystemManager()
        {
            InitializeComponent();
        }

        private void SystemManager_Load(object sender, EventArgs e)
        {
            KeyValueConfigurationCollection k = ConfigurationDispose.GetConfigurationList(@"cjz.exe");
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = k.Count;
            int i = 0;
            foreach (KeyValueConfigurationElement item in k)
            {
                #region 1
                Label lab = new Label();
                lab.Text = item.Key.ToString();
                lab.Name = "lab" + i.ToString();
                lab.AutoSize = true;
                //通过Anchor 设置Label 列中居中
                lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left)));
                tableLayoutPanel1.Controls.Add(lab);

                TextBox txtObj = new TextBox();
                txtObj.Name = "txt" + i.ToString();
                txtObj.Text = item.Value;
                txtObj.Width = 350;
                txtObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top)));
                tableLayoutPanel1.Controls.Add(txtObj);

                Button btn = new Button();
                btn.Text = "...";
                btn.Name = "btn" + i.ToString();
                btn.Tag = i;
                btn.AutoSize = true;
                btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left)));
                btn.Click += Btn_Click;
                tableLayoutPanel1.Controls.Add(btn);
                #endregion
                i++;
            }
            


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
