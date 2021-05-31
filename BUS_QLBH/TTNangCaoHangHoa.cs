using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BUS_QLBH
{
    public class TTNangCaoHangHoa
    {
        
        public static List<DTO_QLBH.SanPham> TimKiemNangCao(string tenhang, string chonnnc, string ncc, string chonslg, string slgsosanh, string soluongtu, string soluongden)
        {
             return ATO_QLBH.TTNangCaoHangHoa.TimKiemNangCao(tenhang,chonnnc,ncc,chonslg,slgsosanh,soluongtu,soluongden);
        }
    }
}
