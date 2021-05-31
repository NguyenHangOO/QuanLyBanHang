using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class SanPham
    {
        public static List<DTO_QLBH.SanPham> LaySP()
        {
            List<DTO_QLBH.SanPham> list = new List<DTO_QLBH.SanPham>();
            using (SqlDataAdapter da = new SqlDataAdapter("select hh.*,ncc.tenncc from tblHANGHOA hh, tblnhacungcap ncc where hh.ma_ncc=ncc.ma_ncc ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.SanPham
                    {
                        ma_hh = r["ma_hh"].ToString(),
                        tenhh = r["tenhh"].ToString(),
                        ma_NCC = r["ma_ncc"].ToString(),
                        tennnc = r["tenncc"].ToString(),
                        soluong = Int32.Parse(r["soluong"].ToString()),
                        dongianhap = float.Parse(r["dongianhap"].ToString()),
                        dongiaban = float.Parse(r["dongiaban"].ToString()),
                        ghichu = r["ghichu"].ToString(),
                        img = r["img"].ToString(),
                        
                    });
                }
                connect.Close();
            }
            return list;
        }

        public static List<DTO_QLBH.SanPham> TimTheoMa(string ma)
        {
            List<DTO_QLBH.SanPham> list = new List<DTO_QLBH.SanPham>();
            using (SqlDataAdapter da = new SqlDataAdapter("select hh.*,ncc.tenncc from tblHANGHOA hh, tblnhacungcap ncc where hh.ma_ncc=ncc.ma_ncc and ma_hh='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.SanPham
                    {
                        ma_hh = r["ma_hh"].ToString(),
                        tenhh = r["tenhh"].ToString(),
                        ma_NCC = r["ma_ncc"].ToString(),
                        tennnc = r["tenncc"].ToString(),
                        soluong = Int32.Parse(r["soluong"].ToString()),
                        dongianhap = float.Parse(r["dongianhap"].ToString()),
                        dongiaban = float.Parse(r["dongiaban"].ToString()),
                        ghichu = r["ghichu"].ToString(),
                        img = r["img"].ToString(),
                    });
                }
            }
            return list;
        }

        public static bool ADD_SP(DTO_QLBH.SanPham sp)
        {
            String str = String.Format("INSERT INTO tblHANGHOA(ma_hh,tenhh,ma_ncc,soluong,dongianhap,dongiaban,ghichu, img) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",
                sp.ma_hh, sp.tenhh, sp.ma_NCC, sp.soluong, sp.dongianhap, sp.dongiaban,sp.ghichu,sp.img);
            return connect.excQuery(str);

        }
        public static bool Edit_SP(DTO_QLBH.SanPham sp)
        {
            String str = String.Format(@"update  tblHANGHOA set tenhh = N'{1}',ma_ncc = N'{2}',soluong = N'{3}',dongianhap = N'{4}', dongiaban = N'{5}', ghichu = N'{6}', img = N'{7}' where ma_hh = N'{0}'",
               sp.ma_hh, sp.tenhh, sp.ma_NCC, sp.soluong, sp.dongianhap, sp.dongiaban, sp.ghichu, sp.img);
            return connect.excQuery(str);

        }
        public static bool Xoa_SP(string Ma)
        {

            String str = String.Format(@"Delete from tblHANGHOA where ma_hh = N'{0}'", Ma);
            return connect.excQuery(str);

        }
        public static string LayTen(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select hh.tenhh from tblHANGHOA hh where ma_hh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["tenhh"].ToString();
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
        public static string LayDG(string ma)
        {
            string DG = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select hh.dongiaban from tblHANGHOA hh where ma_hh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DG = dr["dongiaban"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return DG;
        }
        public static string LayDGNhap(string ma)
        {
            string DG = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select hh.dongianhap from tblHANGHOA hh where ma_hh='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DG = dr["dongianhap"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return DG;
        }
    }
}
