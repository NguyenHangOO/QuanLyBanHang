using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class LoadDLBangHang
    {
        public static List<DTO_QLBH.LoadDLBanHang> GetDLBanHang(string ma)
        {
            return ATO_QLBH.LoadDLBanHang.LayDLBanHang(ma);
        }
        public static List<DTO_QLBH.HoaDon> LayMaHD(string ma)
        {
            return ATO_QLBH.LoadDLBanHang.LaymAhd(ma);
        }
        public static List<DTO_QLBH.ChitietHD> LayMaHH(string mahd, string mahh)
        {
            return ATO_QLBH.LoadDLBanHang.LayMhh(mahd,mahh);
        }
        public static bool Add_HD(DTO_QLBH.HoaDon hd)
        {
            return ATO_QLBH.LoadDLBanHang.ADD_HD(hd);
        }
        public static bool Add_CTHD(DTO_QLBH.ChitietHD cthd)
        {
            return ATO_QLBH.LoadDLBanHang.ADD_CTHD(cthd);
        }
        public static bool Update_SlgSP(DTO_QLBH.SanPham sp)
        {
            return ATO_QLBH.LoadDLBanHang.Update_SlgSP(sp);
        }
        public static bool Update_TTg(DTO_QLBH.HoaDon hd)
        {
            return ATO_QLBH.LoadDLBanHang.Update_TTg(hd);
        }
        public static int LaySlg(string ma)
        {
            return ATO_QLBH.LoadDLBanHang.LaySLgton(ma);
        }
        public static float LayTongTien(string ma)
        {
            return ATO_QLBH.LoadDLBanHang.LayTongTien(ma);
        }
        public static bool Xoa_SPHD(string ma,string mahh)
        {
            return ATO_QLBH.LoadDLBanHang.Xoa_SPHD(ma,mahh);
        }
        public static bool Edit_SPHD(DTO_QLBH.ChitietHD sp)
        {
            return ATO_QLBH.LoadDLBanHang.Edit_SPHD(sp);
        }
        public static int LaySlgXoa(string mahh, string mahd)
        {
            return ATO_QLBH.LoadDLBanHang.LaySLgSPXoa(mahh,mahd);
        }
        public static float LayTTXoa(string mahh, string mahd)
        {
            return ATO_QLBH.LoadDLBanHang.LayTTSPXoa(mahh, mahd);
        }
        public static List<DTO_QLBH.HoaDon> LayDSHD(string ma)
        {
            return ATO_QLBH.LoadDLBanHang.LayHDBan(ma);
        }
        public static void LayDSNHD(DataGridView dtvDSHD)
        {
            dtvDSHD.DataSource = ATO_QLBH.LoadDLBanHang.LayDSHDB();
            dtvDSHD.Columns[0].HeaderText = "Mã HD";
            dtvDSHD.Columns[0].Width = 120;
            dtvDSHD.Columns[1].HeaderText = "Mã khách hàng";
            dtvDSHD.Columns[1].Width = 50;
            dtvDSHD.Columns[2].HeaderText = "Nhân viên";
            dtvDSHD.Columns[3].Visible = false;
            dtvDSHD.Columns[4].HeaderText = "Tổng tiền";
            dtvDSHD.Columns[5].Visible = false;
        }
        public static void HDB(ComboBox cboBAN)
        {
            cboBAN.DataSource = ATO_QLBH.LoadDLBanHang.LayDSHDB();
            cboBAN.DisplayMember = "Ma_hd";
            //cboBAN.ValueMember = "Ma_hd";
        }
    }
}
