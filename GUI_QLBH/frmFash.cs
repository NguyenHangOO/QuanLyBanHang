using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmFash : DevExpress.XtraEditors.XtraForm
    {
        //int timer_interval = 5000;
        public frmFash()
        {
            InitializeComponent();
        }

        private void frmFash_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            prbflash.Value += 2;
            if (prbflash.Value ==100)
            {
                this.Dispose();
            }
            if (prbflash.Value>80)
            {
                this.Opacity -= 0.05;
            }
            lblPhanTram.Text = prbflash.Value.ToString() + " %";
            
        }
    }
}