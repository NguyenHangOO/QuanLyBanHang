using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class PhanQuyen
    {
        public static bool Add_MoiLienHe(DTO_QLBH.moilienhe pq)
        {
            return ATO_QLBH.PhanQuyen.ADD_MoiLienHe(pq);
        }
        public static bool ADD_QuyenChiTiet(DTO_QLBH.quyenchitiet pq)
        {
            return ATO_QLBH.PhanQuyen.ADD_QuyenChiTiet(pq);
        }
        public static bool SuaMLH(DTO_QLBH.moilienhe pq)
        {
            return ATO_QLBH.PhanQuyen.SuaMLH(pq);
        }
        public static bool XoaMLH(string username)
        {
            return ATO_QLBH.PhanQuyen.XoaMLH(username);
        }
        public static bool SuaQH(DTO_QLBH.quyenchitiet pq)
        {
            return ATO_QLBH.PhanQuyen.SuaQH(pq);
        }
        public static bool XoaQH(string username)
        {
            return ATO_QLBH.PhanQuyen.XoaQH(username);
        }
    }
}