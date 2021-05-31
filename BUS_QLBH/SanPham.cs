using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class SanPham
    {
        public static void getSP(DataGridView dtvSp)
        {
            dtvSp.DataSource = ATO_QLBH.SanPham.LaySP();
            dtvSp.Columns[0].HeaderText = "Mã";
            dtvSp.Columns[1].HeaderText = "Tên hàng";
            dtvSp.Columns[2].Visible = false;
            dtvSp.Columns[3].HeaderText = "Nhà cung cấp";
            dtvSp.Columns[4].HeaderText = "Số lượng";
            dtvSp.Columns[5].HeaderText = "Đơn giá nhập";
            dtvSp.Columns[6].HeaderText = "Đơn giá bán";
            dtvSp.Columns[7].HeaderText = "Ghi chú";
            dtvSp.Columns[8].HeaderText = "Ảnh";
           
        }
        public static void getCboSP(ComboBox cboMaSp)
        {
            cboMaSp.DataSource = ATO_QLBH.SanPham.LaySP();
            cboMaSp.DisplayMember = "Ma_HH";
            cboMaSp.ValueMember = "Ma_HH";

        }
        public static List<DTO_QLBH.SanPham> TimTheoMa(string ma)
        {
            return ATO_QLBH.SanPham.TimTheoMa(ma);
        }
        public static bool ADD_SP(DTO_QLBH.SanPham sp)
        {
            return ATO_QLBH.SanPham.ADD_SP(sp);
        }
        public static bool Edit_SP(DTO_QLBH.SanPham sp)
        {
            return ATO_QLBH.SanPham.Edit_SP(sp);
        }
        public static bool Xoa_SP(string ma)
        {
            return ATO_QLBH.SanPham.Xoa_SP(ma);
        }
        public static string LayTen(string ma)
        {
            return ATO_QLBH.SanPham.LayTen(ma);
        }
        public static string LayDG(string ma)
        {
            return ATO_QLBH.SanPham.LayDG(ma);
        }
        public static string LayDGN(string ma)
        {
            return ATO_QLBH.SanPham.LayDGNhap(ma);
        }
    }
}
