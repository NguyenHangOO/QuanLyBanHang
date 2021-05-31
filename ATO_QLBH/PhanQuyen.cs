using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
     public class PhanQuyen
    {
        public static bool ADD_MoiLienHe(DTO_QLBH.moilienhe pq)
        {
            String str = String.Format("INSERT INTO tblMOILIENHE(USERNAME_LH, ID_QH,DP) VALUES(N'{0}',N'{1}' ,'{2}')",
                pq.username,pq.ID_QH,pq.DP);
            return connect.excQuery(str);

        }
        public static bool ADD_QuyenChiTiet(DTO_QLBH.quyenchitiet pq)
        {
            String str = String.Format("INSERT INTO tblQUYENCHITIET(TEN_CT, MA,USERNAME) VALUES(N'{0}',N'{1}' ,'{2}')",
                pq.TEN_CT, pq.MA, pq.username);
            return connect.excQuery(str);

        }
        public static bool SuaMLH(DTO_QLBH.moilienhe pq)
        {

            String str = String.Format(@"update  tblMOILIENHE set ID_QH = N'{1}',DP = N'{2}' where USERNAME_LH = N'{0}'",
                pq.username,pq.ID_QH, pq.DP );
            return connect.excQuery(str);

        }
        public static bool XoaMLH(string username)
        {

            String str = String.Format(@"Delete from tblMOILIENHE where USERNAME_LH = N'{0}'", username);
            return connect.excQuery(str);

        }
        public static bool SuaQH(DTO_QLBH.quyenchitiet pq)
        {

            String str = String.Format(@"update tblQUYENCHITIET set TEN_CT = N'{0}', MA = N'{1}' where username = N'{2}'",
               pq.TEN_CT, pq.MA, pq.username);
            return connect.excQuery(str);

        }
        public static bool XoaQH(string username)
        {

            String str = String.Format(@"Delete from tblQUYENCHITIET where username = N'{0}'", username);
            return connect.excQuery(str);

        }
    }
}
