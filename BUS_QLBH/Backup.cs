using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class Backup
    {
       public static void BackUp()
        {
            ATO_QLBH.Backup.BackUp();
        }
        public static void Restore()
        {
            ATO_QLBH.Backup.Restore();
        }

    }
}
