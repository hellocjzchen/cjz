using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cjz
{
    public partial class baoxiaoDatabaseFrm : Form
    {
        public baoxiaoDatabaseFrm()
        {
            InitializeComponent();
        }

        private void baoxiaoDatabaseFrm_Load(object sender, EventArgs e)
        {
            string str_path = System.Configuration.ConfigurationManager.AppSettings["cjz"];
            userControl11.SetFile(str_path);
        }
    }
}
