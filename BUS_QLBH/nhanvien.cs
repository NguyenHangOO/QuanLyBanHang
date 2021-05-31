using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class nhanvien
    {
        public static void getNhanvien(DataGridView dtvNhanVien)
        {
            dtvNhanVien.DataSource = ATO_QLBH.nhanvien.LayNhanvien();
            dtvNhanVien.Columns[0].HeaderText = "Họ lót";
            dtvNhanVien.Columns[1].HeaderText = "Tên";
            dtvNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            dtvNhanVien.Columns[3].HeaderText = "Giới tính";
            dtvNhanVien.Columns[4].HeaderText = "SĐT";
            dtvNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dtvNhanVien.Columns[6].HeaderText = "Lương";
            dtvNhanVien.Columns[7].HeaderText = "Tên đăng nhập";
            dtvNhanVien.Columns[8].Visible = false;
        }
        /*  public static List<DTO_QLBH.nhanvien> getNhanVhien()
          {
              return ATO_QLBH.nhanvien.LayNhanvien();
          }*/
        public static string GetID(string username, string pass)
        {
            return ATO_QLBH.nhanvien.GetID(username, pass);
        }
        public static string QuyenHan(string username_lh)
        {
            return ATO_QLBH.nhanvien.QuyenHan(username_lh);
        }
        public static List<string> chitiet(string id_qh)
        {
            return ATO_QLBH.nhanvien.chitiet(id_qh);
        }
        public static bool Add(DTO_QLBH.nhanvien nv)
        {
            return ATO_QLBH.nhanvien.ADD(nv);
        }
        public static void getPhanQuyen(DataGridView dtvNhanVien)
        {
            dtvNhanVien.DataSource = ATO_QLBH.nhanvien.layPhanQuyen();
            dtvNhanVien.Columns[0].HeaderText = "Họ lót";
            dtvNhanVien.Columns[1].HeaderText = "Tên";
            dtvNhanVien.Columns[2].HeaderText = "Tên đăng nhập";
            dtvNhanVien.Columns[3].Visible = false;
            dtvNhanVien.Columns[4].HeaderText = "ID quyền hạn";
            dtvNhanVien.Columns[5].HeaderText = "Được phép";
            dtvNhanVien.Columns[6].HeaderText = "Quyền";
            dtvNhanVien.Columns[7].Visible = false;
        }
        public static List<DTO_QLBH.nhanvien> TimTheoUser(string ma)
        {
            return ATO_QLBH.nhanvien.TimTheoUser(ma);
        }
        public static List<DTO_QLBH.nhanvien> TimTheoHoTen(string ma)
        {
            return ATO_QLBH.nhanvien.TimTheoHoTen(ma);
        }
        public static bool SuaNhanVien(DTO_QLBH.nhanvien nv)
        {
            return ATO_QLBH.nhanvien.SuaNhanVien(nv);
        }
        public static bool XoaNhanVien(string username)
        {
            return ATO_QLBH.nhanvien.XoaNhanVien(username);
        }
        public static void getUSER(ComboBox cboUser)
        {
            cboUser.DataSource = ATO_QLBH.nhanvien.LayNhanvien();
            cboUser.DisplayMember = "username";
            cboUser.ValueMember = "username";
        }
        public static string LayTNV(string ma)
        {
            return ATO_QLBH.nhanvien.LayTNV(ma);
        }
    }
}
