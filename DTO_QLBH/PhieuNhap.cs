using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class PhieuNhap
    {
        private string Ma_PNhap;
        public string ma_phap
        {
            get { return Ma_PNhap; }
            set { Ma_PNhap = value; }
        }
        private string Ma_ncc;
        public string ma_ncc
        {
            get { return Ma_ncc; }
            set { Ma_ncc = value; }
        }
        private string Nguoinhap;
        public string nguoinhap
        {
            get { return Nguoinhap; }
            set { Nguoinhap = value; }
        }
        private DateTime NgayLap;
        public Object ngaylap
        {
            get { return NgayLap.ToString("MM/dd/yyyy"); }
            set { NgayLap = DateTime.Parse(value.ToString()); }
        }
        public float tongtien { get; set; }
        private string Hinhthuc;
        public string hinhthuc
        {
            get { return Hinhthuc; }
            set { Hinhthuc = value; }
        }
    }
}
