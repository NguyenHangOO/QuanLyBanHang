using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmSQTM : DevExpress.XtraEditors.XtraForm
    {
        public frmSQTM()
        {
            InitializeComponent();
        }

        private void frmSQTM_Load(object sender, EventArgs e)
        {
            RptTienMat rpt = new RptTienMat();
            rpt.DataSource = BUS_QLBH.BaoCao.TienMat();
            rpt.CreateDocument();
            dcvwTienMat.DocumentSource = rpt;
        }
    }
}