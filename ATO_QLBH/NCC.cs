using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class NCC
    {
        public static List<DTO_QLBH.NCC> LayNCC()
        {
            List<DTO_QLBH.NCC> list = new List<DTO_QLBH.NCC>();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from tblNhaCungCap ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.NCC
                    {
                        ma_NCC = r["ma_ncc"].ToString(),
                        tenncc = r["tenncc"].ToString(),
                        sdt = r["sdt_ncc"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sothe = r["sothe"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.NCC> TimTheoMa(string ma)
        {
            List<DTO_QLBH.NCC> list = new List<DTO_QLBH.NCC>();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from tblNhaCungCap where ma_ncc='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.NCC
                    {
                        ma_NCC = r["ma_ncc"].ToString(),
                        tenncc = r["tenncc"].ToString(),
                        sdt = r["sdt_ncc"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sothe = r["sothe"].ToString(),
                    });
                }
            }
            return list;
        }
        public static bool ADD_NCC(DTO_QLBH.NCC ncc)
        {
            String str = String.Format("INSERT INTO tblNhaCungCap(Ma_NCC,TenNCC,SDT_NCC,DiaChi,SoThe) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
                ncc.ma_NCC, ncc.tenncc, ncc.sdt, ncc.diachi, ncc.sothe);
            return connect.excQuery(str);

        }
        public static bool Edit_NCC(DTO_QLBH.NCC ncc)
        {
            String str = String.Format(@"update  tblNhaCungCap set TenNCC = N'{1}',SDT_NCC = N'{2}',DiaChi = N'{3}',SoThe = N'{4}' where Ma_NCC = N'{0}'",
               ncc.ma_NCC,ncc.tenncc,ncc.sdt,ncc.diachi,ncc.sothe);
            return connect.excQuery(str);

        }
        public static bool Xoa_NCC(string Ma)
        {

            String str = String.Format(@"Delete from tblNhaCungCap where ma_ncc = N'{0}'", Ma);
            return connect.excQuery(str);

        }
        public static string LayTen(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select kh.TenNCC from tblNhaCungCap kh where ma_ncc='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["TenNCC"].ToString();
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
                SqlCommand cmd = new SqlCommand("select kh.diachi from tblNhaCungCap kh where ma_ncc='" + ma + "'", connect.cn);
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
                SqlCommand cmd = new SqlCommand("select kh.SDT_NCC from tblNhaCungCap kh where ma_ncc='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["SDT_NCC"].ToString();
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
