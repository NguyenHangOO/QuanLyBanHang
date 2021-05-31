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
    public partial class frmIN : DevExpress.XtraEditors.XtraForm
    {
        public frmIN()
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
        }
        string tenquyen;
        private void frmIN_Load(object sender, EventArgs e)
        {
            if(rdoBan.Checked==true)
            {
                BUS_QLBH.LoadDLBangHang.HDB(cboHD);
            } 
            else if(rdoNhap.Checked==true)
            {
                BUS_QLBH.NhapHang.HDN(cboHD);
            }    
                
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdoBan.Checked == true)
            {
                string ma = cboHD.Text;
                string manh = ".";
                frmInHoaDon ihd = new frmInHoaDon(ma, manh);
                BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "tìm và in hóa đơn bán");
                ihd.ShowDialog();
            }
            else if (rdoNhap.Checked == true)
            {
                string ma = ".";
                string manh = cboHD.Text; 
                frmInHoaDon ihd = new frmInHoaDon(ma, manh);
                BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "tìm và in hóa đơn nhập ");
                ihd.ShowDialog();
            }
            
        }
    }
}