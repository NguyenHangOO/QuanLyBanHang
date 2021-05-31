using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class BaoCao
    {
        public static List<DTO_QLBH.HoaDon> DoanhThuVao(string tungay, string denngay, string loai, string nguoilap)
        {
            return ATO_QLBH.BaoCao.DoanhThuVao(tungay, denngay, loai, nguoilap);
        }
        public static List<DTO_QLBH.PhieuNhap> DoanhThuRa(string tungay, string denngay, string loai, string nguoilap)
        {
            return ATO_QLBH.BaoCao.DoanhThuRa(tungay, denngay, loai, nguoilap);
        }
        public static List<DTO_QLBH.TienMat> TienMat()
        {
            return ATO_QLBH.BaoCao.TienMat();
        }
    }
}
