using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class InHoaDonBan
    {
        private string Ma_hd;
        public string ma_hd
        {
            get { return Ma_hd; }
            set { Ma_hd = value; }
        }
        private string HoTen;
        public string hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        private string Diachi;
        public string diachi
        {
            get { return Diachi; }
            set { Diachi = value; }
        }
        private string Sdt;
        public string sdt
        {
            get { return Sdt; }
            set { Sdt = value; }
        }
        private string HoTenNV;
        public string hotennv
        {
            get { return HoTenNV; }
            set { HoTenNV = value; }
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
        private string Tenhang;
        public string tenhh
        {
            get { return Tenhang; }
            set { Tenhang = value; }
        }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public float giamgia { get; set; }
        public float thanhtien { get; set; }
    }
}
