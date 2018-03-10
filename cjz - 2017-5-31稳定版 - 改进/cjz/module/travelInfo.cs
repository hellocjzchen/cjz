using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz
{
    [Serializable]
    public class travelInfo
    {
        public string dtime { get; set; }
        public string summary { get; set; }
        public float flyticket { get; set; }
        public bool Ppayfly { get; set; }
        public float trainticket { get; set; }
        public float taxiticket { get; set; }
        public float otherpay { get; set; }
        public float accomadationpay { get; set; }
        public float allowance { get; set; }
        public float totalpay { get; set; }
    }
    [Serializable]
    public class ZongJie
    {
        public int addrowcount { get; set; }
        public string title { get; set; }
        public float totalfly { get; set; }
        public float totaltrain { get; set; }
        public float totaltaxi { get; set; }
        public float totalqita { get; set; }
        public float totalzhusu { get; set; }
        public float totalbutie { get; set; }
        public float totalzongshu { get; set; }
        public float jiekuan { get; set; }
        public float baoxiaojine { get; set; }
        public List<travelInfo> list { get; set; }
    }
}
