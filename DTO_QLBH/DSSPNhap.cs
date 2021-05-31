using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DSSPNhap
    {
        private string Ma_hh;
        public string ma_hh
        {
            get { return Ma_hh; }
            set { Ma_hh = value; }
        }
        private string Tenhang;
        public string tenhh
        {
            get { return Tenhang; }
            set { Tenhang = value; }
        }
        public int soluong { get; set; }
        public float dongianhap { get; set; }
        public float thanhtien { get; set; }
        private string Ma_PNhap;
        public string ma_phap
        {
            get { return Ma_PNhap; }
            set { Ma_PNhap = value; }
        }
    }
}
