using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class TienMat
    {
        private string Ma_hd;
        public string ma_hd
        {
            get { return Ma_hd; }
            set { Ma_hd = value; }
        }
        private DateTime NgayLap;
        public Object ngaylap
        {
            get { return NgayLap.ToString("MM/dd/yyyy"); }
            set { NgayLap = DateTime.Parse(value.ToString()); }
        }
        public float tongtien { get; set; }
        private string Ma_PNhap;
        public string ma_pnhap
        {
            get { return Ma_PNhap; }
            set { Ma_PNhap = value; }
        }
        private DateTime NgayNhap;
        public Object ngaynhap
        {
            get { return NgayNhap.ToString("MM/dd/yyyy"); }
            set { NgayNhap = DateTime.Parse(value.ToString()); }
        }
        public float tongtienchi { get; set; }
    }
}
