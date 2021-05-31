using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class NhapHang
    {
        public static List<DTO_QLBH.DSSPNhap> LayDLNhapHang(string ma)
        {
            List<DTO_QLBH.DSSPNhap> list = new List<DTO_QLBH.DSSPNhap>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.Ma_HH, b.TenHH, a.SoLuong, b.DonGiaNhap,a.ThanhTien FROM tblCHITIETNHAP AS a, tblHANGHOA AS b WHERE a.Ma_PNhap = N'" + ma + "' AND a.Ma_HH = b.Ma_HH", connect.cn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow r in dt.Rows)
                    {
                        list.Add(new DTO_QLBH.DSSPNhap
                        {
                            ma_hh = r["ma_hh"].ToString(),
                            tenhh = r["tenhh"].ToString(),
                            soluong = Int32.Parse(r["soluong"].ToString()),
                            dongianhap = float.Parse(r["dongianhap"].ToString()),
                            thanhtien = float.Parse(r["thanhtien"].ToString()),
                        });
                    }
                    connect.Close();
                }
                catch(Exception)
                {
                    connect.Close();
                }
            }
            return list;
        }

        public static bool ADD_HDN(DTO_QLBH.PhieuNhap hd)
        {
            String str = String.Format("INSERT INTO tblPhieuNhap(Ma_PNhap,Ma_NCC,nguoinhap,NgayNhap,TongTien,hinhthuc) VALUES(N'{0}',N'{1}' ,N'{2}',N'{3}','{4}',N'{5}')",
                hd.ma_phap, hd.ma_ncc, hd.nguoinhap, hd.ngaylap, hd.tongtien,hd.hinhthuc);
            return connect.excQuery(str);

        }
        public static bool ADD_CTHDN(DTO_QLBH.ChiTietPN cthd)
        {
            String str = String.Format("insert into tblCHITIETNHAP(Ma_PNhap,Ma_HH,SoLuong,DonGia,ThanhTien) VALUES(N'{0}',N'{1}' ,'{2}',N'{3}','{4}')",
                cthd.ma_phap, cthd.ma_hh, cthd.soluong, cthd.dongia, cthd.thanhtien);
            return connect.excQuery(str);

        }

        public static bool Update_SlgSP(DTO_QLBH.SanPham sp)
        {
            String str = String.Format(@"update  tblHANGHOA set soluong = N'{1}' where ma_hh = N'{0}'",
               sp.ma_hh, sp.soluong);
            return connect.excQuery(str);

        }
        public static bool Update_TTg(DTO_QLBH.PhieuNhap hd)
        {
            String str = String.Format(@"update  tblPhieuNhap set TongTien = N'{1}' where Ma_PNhap = N'{0}'",
               hd.ma_phap, hd.tongtien);
            return connect.excQuery(str);

        }
        
        public static List<DTO_QLBH.ChiTietPN> LayMhh(string mahd, string mahh)
        {
            List<DTO_QLBH.ChiTietPN> list = new List<DTO_QLBH.ChiTietPN>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_HH FROM tblCHITIETNHAP WHERE Ma_HH=N'" + mahh + "' AND Ma_PNhap = N'" + mahd + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.ChiTietPN
                    {
                        ma_phap = r["ma_phap"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        
        public static List<DTO_QLBH.PhieuNhap> Laymahdn(string ma)
        {
            List<DTO_QLBH.PhieuNhap> list = new List<DTO_QLBH.PhieuNhap>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.Ma_PNhap FROM tblPhieuNhap AS a WHERE a.Ma_PNhap = N'" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.PhieuNhap
                    {
                        ma_phap = r["Ma_PNhap"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static int LaySLgton(string ma)
        {
            int slg = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT soluong FROM tblHANGHOA WHERE Ma_HH=N'" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        slg = Int32.Parse(dr["soluong"].ToString());
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return slg;
        }
        public static float LayTongTien(string ma)
        {
            float ttg = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT TongTien FROM tblPhieuNhap WHERE Ma_PNhap=N'" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ttg = float.Parse(dr["tongtien"].ToString());
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return ttg;
        }

        ///xóa
        ///
        public static bool Xoa_SPHD(string Ma, string mahh)
        {
            String str = String.Format(@"Delete from tblCHITIETNHAP where Ma_PNhap = N'{0}' and Ma_HH = N'{1}'", Ma, mahh);
            return connect.excQuery(str);
        }
        public static bool Edit_SPHD(DTO_QLBH.ChiTietPN sp)
        {
            String str = String.Format(@"update  tblCHITIETNHAP set SoLuong = N'{2}',ThanhTien= N'{3}' where Ma_PNhap = N'{0}' and Ma_HH=N'{1}'",
               sp.ma_phap, sp.ma_hh, sp.soluong, sp.thanhtien);
            return connect.excQuery(str);

        }
        public static int LaySLgSPXoa(string mahh, string mahd)
        {
            int slg = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT soluong FROM tblCHITIETNHAP WHERE Ma_HH=N'" + mahh + "' and Ma_PNhap=N'" + mahd + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        slg = Int32.Parse(dr["soluong"].ToString());
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return slg;
        }
        public static float LayTTSPXoa(string mahh, string mahd)
        {
            float slg = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT thanhtien FROM tblCHITIETNHAP WHERE Ma_HH=N'" + mahh + "' and Ma_PNhap=N'" + mahd + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        slg = float.Parse(dr["thanhtien"].ToString());
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return slg;
        }
        public static List<DTO_QLBH.PhieuNhap> LayDSHDN()
        {
            List<DTO_QLBH.PhieuNhap> list = new List<DTO_QLBH.PhieuNhap>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT ma_pnhap,Ma_NCC,NguoiNhap,TongTien FROM tblphieunhap ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.PhieuNhap
                    {
                        ma_phap = r["ma_pnhap"].ToString(),
                        ma_ncc = r["ma_ncc"].ToString(),
                        nguoinhap = r["nguoinhap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }
    }
}
