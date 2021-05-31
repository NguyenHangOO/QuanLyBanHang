using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class KhachHang
    {
        public static void getLoaiKH(DataGridView dtvLoaiKH)
        {
            dtvLoaiKH.DataSource = ATO_QLBH.KhachHang.LayLoaiKH();
            dtvLoaiKH.Columns[0].HeaderText = "Mã";
            //dtvLoaiKH.Columns[0].Width = 50;
            dtvLoaiKH.Columns[1].HeaderText = "Tên loại KH";
            
        }
        public static void getKH(DataGridView dtvKH)
        {
            dtvKH.DataSource = ATO_QLBH.KhachHang.LayKH();
            dtvKH.Columns[0].HeaderText = "Mã";
            dtvKH.Columns[1].HeaderText = "Tên KH";
            dtvKH.Columns[2].HeaderText = "Giới tính";
            dtvKH.Columns[3].HeaderText = "Địa chỉ";
            dtvKH.Columns[4].HeaderText = "SĐT";
            dtvKH.Columns[6].HeaderText = "Loại khách hàng";
            dtvKH.Columns[5].Visible = false;
        }
        public static void getCLKH(ComboBox cbolkh)
        {
            cbolkh.DataSource = ATO_QLBH.KhachHang.LayLoaiKH();
            cbolkh.DisplayMember = "TenLoaiKH";
            cbolkh.ValueMember = "Ma_LKH";

        }
        public static void getCboKH(ComboBox cbokh)
        {
            cbokh.DataSource = ATO_QLBH.KhachHang.LayKH();
            cbokh.DisplayMember = "Ma_KH";
            cbokh.ValueMember = "Ma_KH";
        }
        public static List<DTO_QLBH.LoaiKH> TimTheoMa(string ma)
        {
            return ATO_QLBH.KhachHang.TimTheoMa(ma);
        }
        public static bool ADD_LoaiKH(DTO_QLBH.LoaiKH lkh)
        {
            return ATO_QLBH.KhachHang.ADD_LoaiKH(lkh);
        }
        public static bool Edit_LKH(DTO_QLBH.LoaiKH lkh)
        {
            return ATO_QLBH.KhachHang.Edit_LoaiKH(lkh);
        }
        public static bool Xoa_LKH(string ma)
        {
            return ATO_QLBH.KhachHang.Xoa_LoaiKH(ma);
        }
        public static bool ADD_KH(DTO_QLBH.khachhang kh)
        {
            return ATO_QLBH.KhachHang.ADD_KH(kh);
        }
        public static bool Edit_KH(DTO_QLBH.khachhang kh)
        {
            return ATO_QLBH.KhachHang.Edit_KH(kh);
        }
        public static bool Xoa_KH(string ma)
        {
            return ATO_QLBH.KhachHang.Xoa_KH(ma);
        }
        public static List<DTO_QLBH.khachhang> TimTheoMaKH(string ma)
        {
            return ATO_QLBH.KhachHang.TimTheoMaKH(ma);
        }
        public static List<DTO_QLBH.khachhang> KTMaKH(string ma)
        {
            return ATO_QLBH.KhachHang.KTMaKH(ma);
        }
        public static string LayTen(string ma)
        {
            return ATO_QLBH.KhachHang.LayTen(ma);
        }
        public static string LayDC(string ma)
        {
            return ATO_QLBH.KhachHang.LayDC(ma);
        }
        public static string LaySDT(string ma)
        {
            return ATO_QLBH.KhachHang.LaySDT(ma);
        }
        public static string LayMLKH(string ma)
        {
            return ATO_QLBH.KhachHang.LayMLKH(ma);
        }
    }
}
