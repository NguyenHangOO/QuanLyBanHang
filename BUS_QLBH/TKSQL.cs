using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class TKSQL
    {
        public static List<DTO_QLBH.HoaDon> TimBangHD(string ma)
        {
            return ATO_QLBH.TKSQL.TimBangHD(ma);
        }
        public static List<DTO_QLBH.ChitietHD> TimBagCT(string ma)
        {
            return ATO_QLBH.TKSQL.TimBangCTHD(ma);
        }
        public static List<DTO_QLBH.TTHDCTHD> Tim2Bang(string ma)
        {
            return ATO_QLBH.TKSQL.Tim2Bang(ma);
        }
    }
}
