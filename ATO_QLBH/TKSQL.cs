using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class TKSQL
    {
        public static List<DTO_QLBH.HoaDon> TimBangHD(string ma)
        {
            List<DTO_QLBH.HoaDon> list = new List<DTO_QLBH.HoaDon>();
            using (SqlDataAdapter da = new SqlDataAdapter(ma, connect.cn))
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
                        ma_kh = r["ma_kh"].ToString(),
                        username = r["username"].ToString(),
                        ngaylap = r["ngaylap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        hinhthuc = r["hinhthuc"].ToString(),
                    });
                }
                connect.Close();
            }
            return list;
        }
        public static List<DTO_QLBH.ChitietHD> TimBangCTHD(string ma)
        {
            List<DTO_QLBH.ChitietHD> list = new List<DTO_QLBH.ChitietHD>();
            using (SqlDataAdapter da = new SqlDataAdapter(ma, connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.ChitietHD
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        ma_hh = r["ma_hh"].ToString(),
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
        public static List<DTO_QLBH.TTHDCTHD> Tim2Bang(string ma)
        {
            List<DTO_QLBH.TTHDCTHD> list = new List<DTO_QLBH.TTHDCTHD>();
            using (SqlDataAdapter da = new SqlDataAdapter(ma, connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.TTHDCTHD
                    {
                        ma_hd = r["ma_hd"].ToString(),
                        ma_kh = r["ma_kh"].ToString(),
                        username = r["username"].ToString(),
                        ngaylap = r["ngaylap"].ToString(),
                        tongtien = float.Parse(r["tongtien"].ToString()),
                        hinhthuc = r["hinhthuc"].ToString(),
                        ma_hh = r["ma_hh"].ToString(),
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
    }
}
