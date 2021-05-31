using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class nhanvien
    {
        private string holot;
        public string ho_lot
        {
            get { return holot; }
            set { holot = value; }
        }
        private string Ten;
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        private DateTime Ngaysinh;
        public Object ngaysinh
        {
            get { return Ngaysinh.ToString("MM/dd/yyyy"); }
            set { Ngaysinh = DateTime.Parse(value.ToString()); }
        }
        private string Gioitinh;
        public string gioitinh
        {
            get { return Gioitinh; }
            set { Gioitinh = value; }
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
        public float luong { get; set; }
        private string Username;
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        private string Pass;
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
       
    }
}
