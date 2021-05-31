using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class moilienhe
    {
        private string user;
        public string username
        {
            get { return user; }
            set { user = value; }
        }
        private string qh;
        public string ID_QH
        {
            get { return qh; }
            set { qh = value; }
        }
        private string dp;
        public string DP
        {
            get { return dp; }
            set { dp = value; }
        }
    }
}
