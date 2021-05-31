using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class KhuyenMai
    {
        public static List<DTO_QLBH.KhuyenMai> LayKM()
        {
            List<DTO_QLBH.KhuyenMai> list = new List<DTO_QLBH.KhuyenMai>();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from tblKM", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.KhuyenMai
                    {
                        makm = r["makm"].ToString(),
                        tenkm = r["tenkm"].ToString(),
                        phantram = r["phantram"].ToString(),
                        
                    });
                }
                connect.Close();
            }
            return list;
        }

        public static List<DTO_QLBH.KhuyenMai> TimTheoMa(string ma)
        {
            List<DTO_QLBH.KhuyenMai> list = new List<DTO_QLBH.KhuyenMai>();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from tblKM where makm='" + ma + "'", connect.cn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DTO_QLBH.KhuyenMai
                    {
                        makm = r["makm"].ToString(),
                        tenkm = r["tenkm"].ToString(),
                        phantram = r["phantram"].ToString(),
                    });
                }
            }
            return list;
        }

        public static bool ADD_KM(DTO_QLBH.KhuyenMai km)
        {
            String str = String.Format("INSERT INTO tblKM(makm,tenkm,phantram) VALUES(N'{0}',N'{1}',N'{2}')",
                km.makm, km.tenkm, km.phantram);
            return connect.excQuery(str);

        }
        public static bool Edit_KM(DTO_QLBH.KhuyenMai km)
        {
            String str = String.Format(@"update  tblKM set tenkm = N'{1}',phantram = N'{2}' where makm = N'{0}'",
              km.makm, km.tenkm, km.phantram);
            return connect.excQuery(str);

        }
        public static bool Xoa_KM(string Ma)
        {

            String str = String.Format(@"Delete from tblKM where makm = N'{0}'", Ma);
            return connect.excQuery(str);

        }
        public static string LayMKM(string ma)
        {
            string Ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand("select km.phantram from tblKM km where makm='" + ma + "'", connect.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Ten = dr["phantram"].ToString();
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
