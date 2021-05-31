using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmInHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmInHoaDon()
        {
            InitializeComponent();
            lblMa.Visible = false;
            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }
        public frmInHoaDon(string ma,string manh) : this()
        {
            lblMa.Text = ma;
            lblManh.Text = manh;
        }

        private void dcVewHoaDonban_Load(object sender, EventArgs e)
        {
            if(lblMa.Text!=".")
            {
                RptInHoaDon rptIn = new RptInHoaDon();
                rptIn.DataSource = BUS_QLBH.InHoaDon.InBanHang(lblMa.Text);
                // dcVewHoaDonban.PrintingSystem = rptIn.PrintingSystem;
                rptIn.CreateDocument();
                dcVewHoaDonban.DocumentSource = rptIn;
            }    
            else
            {
                if (lblManh.Text != ".")
                {
                    RptInNhapHang rptIn = new RptInNhapHang();
                    rptIn.DataSource = BUS_QLBH.InHoaDon.InNhaoHang(lblManh.Text);
                    // dcVewHoaDonban.PrintingSystem = rptIn.PrintingSystem;
                    rptIn.CreateDocument();
                    dcVewHoaDonban.DocumentSource = rptIn;
                }
            }      
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            RptInHoaDon rptIn = new RptInHoaDon();
            //
            e.Graphics.DrawString("Hello Printer", new Font("Arial", 10), Brushes.Black, new Point(10, 10));
        }
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.printDialog.Document = this.printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

    }
}