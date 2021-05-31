using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLBH
{
    public class NhapHang
    {
        public static List<DTO_QLBH.DSSPNhap> GetDLNhapHang(string ma)
        {
            return ATO_QLBH.NhapHang.LayDLNhapHang(ma);
        }
        public static List<DTO_QLBH.PhieuNhap> LayMaHD(string ma)
        {
            return ATO_QLBH.NhapHang.Laymahdn(ma);
        }
        public static List<DTO_QLBH.ChiTietPN> LayMaHH(string mahd, string mahh)
        {
            return ATO_QLBH.NhapHang.LayMhh(mahd, mahh);
        }
        public static bool Add_HDN(DTO_QLBH.PhieuNhap hd)
        {
            return ATO_QLBH.NhapHang.ADD_HDN(hd);
        }
        public static bool Add_CTHDN(DTO_QLBH.ChiTietPN cthd)
        {
            return ATO_QLBH.NhapHang.ADD_CTHDN(cthd);
        }
        public static bool Update_SlgSP(DTO_QLBH.SanPham sp)
        {
            return ATO_QLBH.NhapHang.Update_SlgSP(sp);
        }
        public static bool Update_TTg(DTO_QLBH.PhieuNhap hd)
        {
            return ATO_QLBH.NhapHang.Update_TTg(hd);
        }
        public static int LaySlg(string ma)
        {
            return ATO_QLBH.NhapHang.LaySLgton(ma);
        }
        public static float LayTongTien(string ma)
        {
            return ATO_QLBH.NhapHang.LayTongTien(ma);
        }
        public static bool Xoa_SPHD(string ma, string mahh)
        {
            return ATO_QLBH.NhapHang.Xoa_SPHD(ma, mahh);
        }
        public static bool Edit_SPHD(DTO_QLBH.ChiTietPN sp)
        {
            return ATO_QLBH.NhapHang.Edit_SPHD(sp);
        }
        public static int LaySlgXoa(string mahh, string mahd)
        {
            return ATO_QLBH.NhapHang.LaySLgSPXoa(mahh, mahd);
        }
        public static float LayTTXoa(string mahh, string mahd)
        {
            return ATO_QLBH.NhapHang.LayTTSPXoa(mahh, mahd);
        }
        public static void HDN(ComboBox cboNhap)
        {
            cboNhap.DataSource = ATO_QLBH.NhapHang.LayDSHDN();
            cboNhap.DisplayMember = "ma_phap";
            //cboNhap.ValueMember = "ma_phap";
        }
    }
}
