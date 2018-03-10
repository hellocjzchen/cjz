using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz
{
    public class ScholzJobNo
    {

        public int id { get; set; }
        public string userName { get; set; }
        public string jobNo { get; set; }
        public string SignYear { get; set; }
        public string Dvalid { get; set; }
        public string Lvalid { get; set; }
        public string PressureMax { get; set; }
        public string  TempMax { get; set; }

        public bool DelFlag { get; set; }
    }
}
