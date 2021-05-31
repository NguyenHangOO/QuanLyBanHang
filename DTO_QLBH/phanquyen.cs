using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
     public class phanquyen
    {
        private string holot;
        public string ho_lot
        {
            get { return holot; }
            set { holot = value; }
        }
        private string Ten;
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        private string user;
        public string username
        {
            get { return user; }
            set { user = value; }
        }
        private string Pass;
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
        /////phân quyền
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
        private string tenct;
        public string TEN_CT
        {
            get { return tenct; }
            set { tenct = value; }
        }
        
       private string ma;
        public string MA
        {
            get { return ma; }
            set { ma = value; }
        }

    }
}
