using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class ChitietHD
    {
        private string Ma_hd;
        public string ma_hd
        {
            get { return Ma_hd; }
            set { Ma_hd = value; }
        }
        private string Ma_hh;
        public string ma_hh
        {
            get { return Ma_hh; }
            set { Ma_hh = value; }
        }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public float giamgia { get; set; }
        public float thanhtien { get; set; }
        
    }
}
