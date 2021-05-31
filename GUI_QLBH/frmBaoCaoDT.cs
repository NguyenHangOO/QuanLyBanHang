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
    public partial class frmBaoCaoDT : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoDT()
        {
            InitializeComponent();
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
            //
            lblTN.Enabled = false;
            lblDN.Enabled = false;
            lblL.Enabled = false;
            lblNL.Enabled = false;
        }
        string tenquyen;
        public frmBaoCaoDT(string tungay, string dengnay, string loai, string nguoilap) : this()
        {
            lblTN.Text = tungay;
            lblDN.Text = dengnay;
            lblL.Text = loai;
            lblNL.Text = nguoilap;
        }
        private void frmBaoCaoDT_Load(object sender, EventArgs e)
        {          
            RptBaoCaoDanhThu rptIn = new RptBaoCaoDanhThu();
            rptIn.DataSource = BUS_QLBH.BaoCao.DoanhThuVao(lblTN.Text, lblDN.Text, lblL.Text, lblNL.Text);
            // dcVewHoaDonban.PrintingSystem = rptIn.PrintingSystem;
            rptIn.CreateDocument();
            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "xem doanh thu");
            docViewDoanhThu.DocumentSource = rptIn;           
        }
    }
}