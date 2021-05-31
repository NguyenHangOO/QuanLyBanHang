using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class KhuyenMai
    {
        public static void getKM(DataGridView dtvkm)
        {
            dtvkm.DataSource = ATO_QLBH.KhuyenMai.LayKM();
            dtvkm.Columns[0].HeaderText = "Mã";
            dtvkm.Columns[1].HeaderText = "Tên khuyến mãi";
            dtvkm.Columns[2].HeaderText = "Phần trăm";

        }
        public static List<DTO_QLBH.KhuyenMai> TimTheoMa(string ma)
        {
            return ATO_QLBH.KhuyenMai.TimTheoMa(ma);
        }
        public static bool ADD_KM(DTO_QLBH.KhuyenMai km)
        {
            return ATO_QLBH.KhuyenMai.ADD_KM(km);
        }
        public static bool Edit_KM(DTO_QLBH.KhuyenMai km)
        {
            return ATO_QLBH.KhuyenMai.Edit_KM(km);
        }
        public static bool Xoa_KM(string ma)
        {
            return ATO_QLBH.KhuyenMai.Xoa_KM(ma);
        }
        public static string LayMKM(string ma)
        {
            return ATO_QLBH.KhuyenMai.LayMKM(ma);
        }
    }
}
