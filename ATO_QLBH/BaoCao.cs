using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class BaoCao
    {
        public static List<DTO_QLBH.HoaDon> DoanhThuVao(string tungay, string denngay, string loai, string nguoilap)
        {
            List<DTO_QLBH.HoaDon> list = new List<DTO_QLBH.HoaDon>();
            String sql = @"select Ma_HD, ngaylap, tongtien,username from tblHOADON where NgayLap >='"+tungay+ "' and NgayLap<='" + denngay + "' " + loai + " USERNAME ='" + nguoilap + "'";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, connect.cn))
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
                        ngaylap = r["ngaylap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        username= r["username"].ToString(),
                    });
                }
            }
            return list;
        }
        public static List<DTO_QLBH.PhieuNhap> DoanhThuRa(string tungay, string denngay, string loai, string nguoilap)
        {
            List<DTO_QLBH.PhieuNhap> list = new List<DTO_QLBH.PhieuNhap>();
            String sql = @"select  Ma_PNhap, NgayNhap, tongtien, NguoiNhap from tblPhieunhap where NgayNhap >='" + tungay + "' and NgayNhap<='" + denngay + "' " + loai + " NguoiNhap ='" + nguoilap + "'";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, connect.cn))
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
                        ngaylap = r["ngaynhap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        nguoinhap = r["nguoinhap"].ToString(),
                    });
                }
            }
            return list;
        }
        public static List<DTO_QLBH.TienMat> TienMat()
        {
            List<DTO_QLBH.TienMat> list = new List<DTO_QLBH.TienMat>();
            String sql = @"select*from Tienmat ";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.TienMat
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        ngaylap = r["ngaylap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        ma_pnhap = r["ma_pnhap"].ToString(),
                        ngaynhap = r["ngaynhap"].ToString(),
                        tongtienchi = float.Parse(r["tongchi"].ToString()),
                    });
                }
            }
            return list;
        }
    }
}
