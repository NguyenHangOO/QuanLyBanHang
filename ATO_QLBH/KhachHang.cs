using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class KhachHang
    {
        public static List<DTO_QLBH.LoaiKH> LayLoaiKH()
        {
            List<DTO_QLBH.LoaiKH> list = new List<DTO_QLBH.LoaiKH>();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from tblLoaiKH ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.LoaiKH
                    {
                        ma_lkh = r["ma_lkh"].ToString(),
                        tenloaikh = r["tenloaikh"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.LoaiKH> TimTheoMa(string ma)
        {
            List<DTO_QLBH.LoaiKH> list = new List<DTO_QLBH.LoaiKH>();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from tblLoaiKH where Ma_LKH='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.LoaiKH
                    {
                        ma_lkh = r["ma_lkh"].ToString(),
                        tenloaikh = r["tenloaikh"].ToString(),

                    });
                }
            }
            return list;
        }
        public static List<DTO_QLBH.khachhang> LayKH()
        {
            List<DTO_QLBH.khachhang> list = new List<DTO_QLBH.khachhang>();
            using (SqlDataAdapter da = new SqlDataAdapter("select kh.*, lkh.TenLoaiKH from tblKHACHHANG kh  ,tblLoaiKH lkh where kh.Ma_LKH=lkh.Ma_LKH ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.khachhang
                    {
                        ma_kh= r["ma_kh"].ToString(),
                        hoten = r["hoten"].ToString(),
                        gioitinh = r["gioitinh"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sdt = r["sdt"].ToString(),
                        ma_lkh = r["ma_lkh"].ToString(),
                        tenlkh= r["tenloaikh"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static bool ADD_LoaiKH(DTO_QLBH.LoaiKH lkh)
        {
            String str = String.Format("INSERT INTO tblLoaiKH(Ma_LKH,TenLoaiKH) VALUES(N'{0}',N'{1}')",
                lkh.ma_lkh,lkh.tenloaikh);
            return connect.excQuery(str);

        }
        public static bool Edit_LoaiKH(DTO_QLBH.LoaiKH lkh)
        {
            String str = String.Format(@"update  tblLoaiKH set TenLoaiKH = N'{1}' where Ma_LKH = N'{0}'",
                lkh.ma_lkh, lkh.tenloaikh);
            return connect.excQuery(str);

        }
        public static bool Xoa_LoaiKH(string Ma)
        {

            String str = String.Format(@"Delete from tblLoaiKH where Ma_LKH = N'{0}'", Ma);
            return connect.excQuery(str);

        }
        public static bool ADD_KH(DTO_QLBH.khachhang kh)
        {
            String str = String.Format("INSERT INTO tblKHACHHANG(ma_kh,hoten,gioitinh,diachi,sdt,ma_lkh) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                kh.ma_kh,kh.hoten,kh.gioitinh,kh.diachi,kh.sdt,kh.ma_lkh);
            return connect.excQuery(str);

        }
        public static bool Edit_KH(DTO_QLBH.khachhang kh)
        {
            String str = String.Format(@"update  tblKHACHHANG set hoten = N'{1}',gioitinh = N'{2}',diachi = N'{3}',sdt = N'{4}', Ma_LKH = N'{5}' where ma_kh = N'{0}'",
               kh.ma_kh, kh.hoten, kh.gioitinh, kh.diachi, kh.sdt, kh.ma_lkh);
            return connect.excQuery(str);

        }
        public static bool Xoa_KH(string Ma)
        {

            String str = String.Format(@"Delete from tblKHACHHANG where ma_kh = N'{0}'", Ma);
            return connect.excQuery(str);

        }
        public static List<DTO_QLBH.khachhang> TimTheoMaKH(string ma)
        {
            List<DTO_QLBH.khachhang> list = new List<DTO_QLBH.khachhang>();
            using (SqlDataAdapter da = new SqlDataAdapter("select kh.*, lkh.TenLoaiKH from tblKHACHHANG kh  ,tblLoaiKH lkh where kh.Ma_LKH=lkh.Ma_LKH and kh.ma_kh='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.khachhang
                    {
                        ma_kh = r["ma_kh"].ToString(),
                        hoten = r["hoten"].ToString(),
                        gioitinh = r["gioitinh"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sdt = r["sdt"].ToString(),
                        ma_lkh = r["ma_lkh"].ToString(),
                        tenlkh = r["tenloaikh"].ToString(),
                    });
                }
            }
            return list;
        }
        public static List<DTO_QLBH.khachhang> KTMaKH(string ma)
        {
            List<DTO_QLBH.khachhang> list = new List<DTO_QLBH.khachhang>();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from tblKHACHHANG where ma_kh='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.khachhang
                    {
                        ma_kh = r["ma_kh"].ToString(),
                        hoten = r["hoten"].ToString(),
                        gioitinh = r["gioitinh"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sdt = r["sdt"].ToString(),
                        ma_lkh = r["ma_lkh"].ToString(),
                        //tenlkh = r["tenloaikh"].ToString(),
                    });
                }
            }
            return list;
        }

        public static string LayTen(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select kh.hoten from tblKHACHHANG kh where ma_kh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["hoten"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return Ten;
        }
        public static string LayDC(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select kh.diachi from tblKHACHHANG kh where ma_kh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["diachi"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return Ten;
        }
        public static string LaySDT(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select kh.sdt from tblKHACHHANG kh where ma_kh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["sdt"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return Ten;
        }
        public static string LayMLKH(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select kh.ma_lkh from tblKHACHHANG kh where ma_kh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["ma_lkh"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return Ten;
        }
    }
}
