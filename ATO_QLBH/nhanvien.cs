using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;
namespace ATO_QLBH
{
    public class nhanvien
    {
        public static List<DTO_QLBH.nhanvien> LayNhanvien()
        {
            List<DTO_QLBH.nhanvien> list = new List<DTO_QLBH.nhanvien>();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from tblnhanvien nv ", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.nhanvien
                    {
                        ho_lot = r["ho_lot"].ToString(),
                        ten = r["ten"].ToString(),
                        ngaysinh = r["ngaysinh"].ToString(),
                        gioitinh =r["gioitinh"].ToString(),
                        sdt = r["sdt"].ToString(),
                        diachi = r["diachi"].ToString(),
                        luong = Int32.Parse(r["luong"].ToString()),
                        username = r["username"].ToString(),
                        pass = r["pass"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static string GetID(string username, string pass)
        {
            string USERNAME = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select *from tblnhanvien where username='" + username + "' and pass='" + pass + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        USERNAME = dr["username"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return USERNAME;
        }

        public static string QuyenHan(string username_lh)
        {
            string id = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select *from tblMOILIENHE where username_lh='" + username_lh + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["DP"].ToString() == "True")
                        {
                            id = dr["ID_QH"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {}
            finally
            {
                connect.Close();
            }
            return id;

        }
        public static List<string> chitiet(string username)
        {
            List<string> ct = new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblQUYENCHITIET WHERE username ='" + username + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ct.Add(dr["MA"].ToString());
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return ct;
        }
        public static bool ADD(DTO_QLBH.nhanvien nhanvien)
        {
            String str = String.Format("INSERT INTO tblNhanVien(ho_lot,ten,ngaysinh,gioitinh,sdt,diachi,luong,username,pass) VALUES(N'{0}',N'{1}' ,'{2}',N'{3}','{4}',N'{5}','{6}' ,'{7}','{8}')",
                nhanvien.ho_lot, nhanvien.ten, nhanvien.ngaysinh, nhanvien.gioitinh, nhanvien.sdt,nhanvien.diachi,nhanvien.luong,nhanvien.username,nhanvien.pass);
            return connect.excQuery(str);

        }
        public static bool SuaNhanVien(DTO_QLBH.nhanvien nv)
        {
           
            String str = String.Format(@"update tblNhanVien set ho_lot = N'{0}', ten = N'{1}',ngaysinh = N'{2}',gioitinh = N'{3}',sdt = N'{4}',diachi = N'{5}',luong = N'{6}',pass = N'{8}' where username = N'{7}'",
                nv.ho_lot, nv.ten, nv.ngaysinh, nv.gioitinh, nv.sdt, nv.diachi, nv.luong, nv.username, nv.pass);
            return connect.excQuery(str);

        }
        public static bool XoaNhanVien(string username)
        {

            String str = String.Format(@"Delete from tblnhanvien where username = N'{0}'",username);
            return connect.excQuery(str);

        }
        public static List<DTO_QLBH.phanquyen> layPhanQuyen()
        {
            List<DTO_QLBH.phanquyen> list = new List<DTO_QLBH.phanquyen>();
            using (SqlDataAdapter da = new SqlDataAdapter("select nv.Ho_Lot, nv.Ten, nv.USERNAME,nv.pass,ql.ID_QH,ql.DP,ct.TEN_CT,ct.ma  from tblNHANVIEN as nv,tblMOILIENHE as ql,tblQUYENCHITIET as ct   where nv.USERNAME=ql.USERNAME_LH and nv.USERNAME=ct.USERNAME", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.phanquyen
                    {
                        ho_lot = r["ho_lot"].ToString(),
                        ten = r["ten"].ToString(),
                        username = r["username"].ToString(),
                        pass = r["pass"].ToString(),
                        ID_QH = r["ID_QH"].ToString(),
                        DP = r["DP"].ToString(),
                        TEN_CT = r["ten_ct"].ToString(),
                        MA = r["MA"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.nhanvien> TimTheoUser(string ma)
        {
            List<DTO_QLBH.nhanvien> list = new List<DTO_QLBH.nhanvien>();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from tblnhanvien where username like N'%" + ma + "%'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.nhanvien
                    {
                        ho_lot = r["ho_lot"].ToString(),
                        ten = r["ten"].ToString(),
                        ngaysinh = r["ngaysinh"].ToString(),
                        gioitinh = r["gioitinh"].ToString(),
                        sdt = r["sdt"].ToString(),
                        diachi = r["diachi"].ToString(),
                        luong = Int32.Parse(r["luong"].ToString()),
                        username = r["username"].ToString(),
                        pass = r["pass"].ToString(),
                    });
                }   
            }
            return list;
        }
        public static List<DTO_QLBH.nhanvien> TimTheoHoTen(string ma)
        {
            List<DTO_QLBH.nhanvien> list = new List<DTO_QLBH.nhanvien>();
            using (SqlDataAdapter da = new SqlDataAdapter(@"select * from tblnhanvien where ho_lot like
            N'%" + ma + "%' or ten like N'%" + ma + "%'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.nhanvien
                    {
                        ho_lot = r["ho_lot"].ToString(),
                        ten = r["ten"].ToString(),
                        ngaysinh = r["ngaysinh"].ToString(),
                        gioitinh = r["gioitinh"].ToString(),
                        sdt = r["sdt"].ToString(),
                        diachi = r["diachi"].ToString(),
                        luong = Int32.Parse(r["luong"].ToString()),
                        username = r["username"].ToString(),
                        pass = r["pass"].ToString(),
                    });
                }
            }
            return list;
        }
        public static string LayTNV(string ma)
        {
            string HoLot = "";
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select nv.ho_lot , nv.ten from tblNhanVien nv where username='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        HoLot = dr["ho_lot"].ToString();
                        Ten = dr["ten"].ToString();
                    }
                }
            }
            catch (Exception)
            { }
            finally
            {
                connect.Close();
            }
            return HoLot+" "+Ten;
        }

    }

}
