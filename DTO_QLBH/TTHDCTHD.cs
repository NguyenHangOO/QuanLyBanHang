using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class TTHDCTHD
    {
        private string Ma_hd;
        public string ma_hd
        {
            get { return Ma_hd; }
            set { Ma_hd = value; }
        }
        private string Ma_kh;
        public string ma_kh
        {
            get { return Ma_kh; }
            set { Ma_kh = value; }
        }
        private string Username;
        public string username
        {
            get { return Username; }
            set { Username = value; }
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
