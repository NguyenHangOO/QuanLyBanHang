using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class InHoaDon
    {
        public static List<DTO_QLBH.InHoaDonBan> InBanHang(string ma)
        {
            List<DTO_QLBH.InHoaDonBan> list = new List<DTO_QLBH.InHoaDonBan>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HD where Ma_HD = N'" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.InHoaDonBan
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        hoten = r["hoten"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sdt = r["sdt"].ToString(),
                        hotennv = r["hotennv"].ToString(),
                        ngaylap = r["ngaylap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        hinhthuc = r["hinhthuc"].ToString(),
                        tenhh = r["tenhh"].ToString(),
                        soluong = Int32.Parse(r["soluong"].ToString()),
                        dongia = float.Parse(r["dongia"].ToString()),
                        giamgia = float.Parse(r["giamgia"].ToString()),
                        thanhtien = float.Parse(r["thanhtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.InHoaDonNhap> InNhapHang(string ma)
        {
            List<DTO_QLBH.InHoaDonNhap> list = new List<DTO_QLBH.InHoaDonNhap>();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HD_Nhap where Ma_PNhap = N'" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.InHoaDonNhap
                    {
                        ma_phap = r["Ma_PNhap"].ToString(),
                        tenncc = r["tenncc"].ToString(),
                        diachi = r["diachi"].ToString(),
                        sdt = r["sdt_ncc"].ToString(),
                        hotennv = r["hotennv"].ToString(),
                        ngaylap = r["ngaynhap"].ToString(),
                        tenhh = r["tenhh"].ToString(),
                        soluong = Int32.Parse(r["soluong"].ToString()),
                        dongia = float.Parse(r["dongia"].ToString()),
                        thanhtien = float.Parse(r["thanhtien"].ToString()),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                    });
                }
                connect.Close();
            }
            return list;
        }
    }
}
