using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class SanPham
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
        private string Ma_NCC;
        public string ma_NCC
        {
            get { return Ma_NCC; }
            set { Ma_NCC = value; }
        }
        private string Tenncc;
        public string tennnc
        {
            get { return Tenncc; }
            set { Tenncc = value; }
        }
        public int soluong { get; set; }
        public float dongianhap { get; set; }
        public float dongiaban { get; set; }
        private string Ghichu;
        public string ghichu
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }
        private string Anh;
        public string img
        {
            get { return Anh; }
            set { Anh = value; }
        }
        
    }
}
