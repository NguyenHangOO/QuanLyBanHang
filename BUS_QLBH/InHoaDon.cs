using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class InHoaDon
    {
        public static List<DTO_QLBH.InHoaDonBan> InBanHang(string ma)
        {
            return ATO_QLBH.InHoaDon.InBanHang(ma);
        }
        public static List<DTO_QLBH.InHoaDonNhap> InNhaoHang(string ma)
        {
            return ATO_QLBH.InHoaDon.InNhapHang(ma);
        }
    }
}
