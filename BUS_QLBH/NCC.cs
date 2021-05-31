using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class NCC
    {
        public static void getNCC(DataGridView dtvKH)
        {
            dtvKH.DataSource = ATO_QLBH.NCC.LayNCC();
            dtvKH.Columns[0].HeaderText = "Mã";
            dtvKH.Columns[1].HeaderText = "Tên NCC";
            dtvKH.Columns[2].HeaderText = "Số điện thoại";
            dtvKH.Columns[3].HeaderText = "Địa chỉ";
            dtvKH.Columns[4].HeaderText = "Số thẻ";
        }
        public static void getCboNCC(ComboBox cboNCC)
        {
            cboNCC.DataSource = ATO_QLBH.NCC.LayNCC();
            cboNCC.DisplayMember = "tenncc";
            cboNCC.ValueMember = "Ma_NCC";
        }
        public static List<DTO_QLBH.NCC> TimTheoMa(string ma)
        {
            return ATO_QLBH.NCC.TimTheoMa(ma);
        }
        public static bool ADD_NCC(DTO_QLBH.NCC ncc)
        {
            return ATO_QLBH.NCC.ADD_NCC(ncc);
        }
        public static bool Edit_NCC(DTO_QLBH.NCC ncc)
        {
            return ATO_QLBH.NCC.Edit_NCC(ncc);
        }
        public static bool Xoa_NCC(string ma)
        {
            return ATO_QLBH.NCC.Xoa_NCC(ma);
        }
        public static string LayTen(string ma)
        {
            return ATO_QLBH.NCC.LayTen(ma);
        }
        public static string LayDC(string ma)
        {
            return ATO_QLBH.NCC.LayDC(ma);
        }
        public static string LaySDT(string ma)
        {
            return ATO_QLBH.NCC.LaySDT(ma);
        }
        public static void getCNCC(ComboBox cboNCC)
        {
            cboNCC.DataSource = ATO_QLBH.NCC.LayNCC();
            cboNCC.DisplayMember = "Ma_NCC";
            cboNCC.ValueMember = "Ma_NCC";
        }
    }
}
