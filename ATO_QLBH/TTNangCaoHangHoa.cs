using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ATO_QLBH
{
    public class TTNangCaoHangHoa
    {
        public static List<DTO_QLBH.SanPham> TimKiemNangCao(string tenhanghoa, string chonnhacc, string ncc,
            string chonsoluong, string sosanhslg, string soluongtu, string soluongden)
        {
            List<DTO_QLBH.SanPham> list = new List<DTO_QLBH.SanPham>();
            String sql = @"select * from tblHANGHOA where Tenhh like N'%" + tenhanghoa+"%'";
            if (!chonnhacc.Equals("NONE"))
                sql +=" "+ chonnhacc +" "+ "Ma_NCC like N'%" +ncc+"%'";
            if (!chonsoluong.Equals("NONE") && !sosanhslg.Equals("between"))
                sql += " " +chonsoluong + " soluong" + " " + sosanhslg + " '"+soluongtu+"'";
            else if (sosanhslg.Equals("between"))
                sql += " " +chonsoluong + " soluong" + " "+ sosanhslg + "'" + soluongtu + "'" + " and '" + soluongden + "'";
            using (SqlDataAdapter da = new SqlDataAdapter(sql,connect.cn))
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
                        //tennnc = r["tenncc"].ToString(),
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
    }
}
