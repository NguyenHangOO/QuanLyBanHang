using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class LoadDLBanHang
    {
        public static List<DTO_QLBH.LoadDLBanHang> LayDLBanHang(string ma)
        {
            List<DTO_QLBH.LoadDLBanHang> list = new List<DTO_QLBH.LoadDLBanHang>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.Ma_HH, b.TenHH, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblCHITIETHD AS a, tblHANGHOA AS b WHERE a.Ma_HD = N'" + ma + "' AND a.Ma_HH = b.Ma_HH", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.LoadDLBanHang
                    {
                        ma_hh = r["ma_hh"].ToString(),
                        tenhh = r["tenhh"].ToString(),
                        soluong = Int32.Parse(r["soluong"].ToString()),
                        dongiaban = float.Parse(r["dongiaban"].ToString()),
                        giamgia = float.Parse(r["giamgia"].ToString()),
                        thanhtien = float.Parse(r["thanhtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }

        public static bool ADD_HD(DTO_QLBH.HoaDon hd)
        {
            String str = String.Format("INSERT INTO tblHOADON(Ma_HD,Ma_KH,USERNAME,NgayLap,TongTien,Hinhthuc) VALUES(N'{0}',N'{1}' ,N'{2}',N'{3}','{4}',N'{5}')",
                hd.ma_hd, hd.ma_kh, hd.username, hd.ngaylap, hd.tongtien,hd.hinhthuc);
            return connect.excQuery(str);

        }
        public static bool ADD_CTHD(DTO_QLBH.ChitietHD cthd)
        {
            String str = String.Format("insert into tblCHITIETHD(Ma_HD,Ma_HH,SoLuong,DonGia,GiamGia,ThanhTien) VALUES(N'{0}',N'{1}' ,'{2}',N'{3}','{4}','{5}')",
                cthd.ma_hd, cthd.ma_hh, cthd.soluong, cthd.dongia, cthd.giamgia, cthd.thanhtien);
            return connect.excQuery(str);

        }

        public static bool Update_SlgSP(DTO_QLBH.SanPham sp)
        {
            String str = String.Format(@"update  tblHANGHOA set soluong = N'{1}' where ma_hh = N'{0}'",
               sp.ma_hh,sp.soluong);
            return connect.excQuery(str);

        }
        public static bool Update_TTg(DTO_QLBH.HoaDon hd)
        {
            String str = String.Format(@"update  tblHOADON set TongTien = N'{1}' where Ma_HD = N'{0}'",
               hd.ma_hd, hd.tongtien);
            return connect.excQuery(str);

        }
        public static List<DTO_QLBH.HoaDon> LaymAhd(string ma)
        {
            List<DTO_QLBH.HoaDon> list = new List<DTO_QLBH.HoaDon>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.ma_hd FROM tblHOADON AS a WHERE a.Ma_HD = N'" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.HoaDon
                    {
                        ma_hd = r["ma_hd"].ToString(),  
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.ChitietHD> LayMhh(string mahd, string mahh)
        {
            List<DTO_QLBH.ChitietHD> list = new List<DTO_QLBH.ChitietHD>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT Ma_HH FROM tblCHITIETHD WHERE Ma_HH=N'"+mahh+ "' AND Ma_HD = N'" + mahd + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.ChitietHD
                    {
                       ma_hh=r["ma_hh"].ToString(),
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
                SqlCommand cmd = new SqlCommand("SELECT TongTien FROM tblHOADON WHERE Ma_HD=N'" + ma + "'", connect.cn);
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
            String str = String.Format(@"Delete from tblCHITIETHD where Ma_HD = N'{0}' and Ma_HH = N'{1}'", Ma,mahh);
            return connect.excQuery(str);
        }
        public static bool Edit_SPHD(DTO_QLBH.ChitietHD sp)
        {
            String str = String.Format(@"update  tblCHITIETHD set SoLuong = N'{2}', GiamGia= N'{3}',ThanhTien= N'{4}' where Ma_HD = N'{0}' and Ma_HH=N'{1}'",
               sp.ma_hd,sp.ma_hh,sp.soluong,sp.giamgia,sp.thanhtien);
            return connect.excQuery(str);

        }
        public static int LaySLgSPXoa(string mahh, string mahd)
        {
            int slg = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT soluong FROM tblCHITIETHD WHERE Ma_HH=N'" + mahh + "' and Ma_HD=N'" + mahd + "'", connect.cn);
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
                SqlCommand cmd = new SqlCommand("SELECT thanhtien FROM tblCHITIETHD WHERE Ma_HH=N'" + mahh + "' and Ma_HD=N'" + mahd + "'", connect.cn);
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

        public static List<DTO_QLBH.HoaDon> LayHDBan(string ma)
        {
            List<DTO_QLBH.HoaDon> list = new List<DTO_QLBH.HoaDon>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.ma_hd ,a.username,a.tongtien FROM tblHOADON AS a WHERE a.Ma_kh like N'%" + ma + "%'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.HoaDon
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        username = r["username"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.HoaDon> LayDSHDB()
        {
            List<DTO_QLBH.HoaDon> list = new List<DTO_QLBH.HoaDon>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT a.ma_hd, a.ma_kh ,a.username,a.tongtien FROM tblHOADON AS a ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.HoaDon
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        ma_kh= r["ma_kh"].ToString(),
                        username = r["username"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }
    }
}
