using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class InHoaDonNhap
    {
        private string Ma_phap;
        public string ma_phap
        {
            get { return Ma_phap; }
            set { Ma_phap = value; }
        }
        private string Ten;
        public string tenncc
        {
            get { return Ten; }
            set { Ten = value; }
        }
        private string Sdt;
        public string sdt
        {
            get { return Sdt; }
            set { Sdt = value; }
        }
        private string Diachi;
        public string diachi
        {
            get { return Diachi; }
            set { Diachi = value; }
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
        
        private string Tenhang;
        public string tenhh
        {
            get { return Tenhang; }
            set { Tenhang = value; }
        }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public float thanhtien { get; set; }
        public float tongtien { get; set; }
        private string Hinhthuc;
        public string hinhthuc
        {
            get { return Hinhthuc; }
            set { Hinhthuc = value; }
        }
    }
}
