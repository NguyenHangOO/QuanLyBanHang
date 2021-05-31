using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmNhanVien : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BUS_QLBH.nhanvien.getNhanvien(dtNhanVien);
            cboTK.Text = "Username";
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
            //
        }
        string tenquyen;
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddNhanVien tnv = new frmAddNhanVien();
            tnv.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string user = dtNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                if (BUS_QLBH.nhanvien.TimTheoUser(user) == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên muốn xóa!");
                    return;
                }
                if (!BUS_QLBH.nhanvien.XoaNhanVien(user))
                {
                    MessageBox.Show("Không Xóa được. Do còn quyền hạn nhân viên");
                    return;
                }
                BUS_QLBH.nhanvien.getNhanvien(dtNhanVien);
                MessageBox.Show("Đã xóa nhân viên thành công.");
                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa nhân viên");
            } 
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(cboTK.Text.Equals("Username"))
            {
                //BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                List<DTO_QLBH.nhanvien> lstnv = BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên có user: " + txtTK.Text+ " !");
                    return;
                }
               dtNhanVien.DataSource = lstnv;
            }  
            else
            {
                List<DTO_QLBH.nhanvien> lstnv = BUS_QLBH.nhanvien.TimTheoHoTen(txtTK.Text);
                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên có họ hoặc tên: " + txtTK.Text + " !");
                    return;
                }
                dtNhanVien.DataSource = lstnv;
                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "tìm nhân viên");
            }    
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            string holot = dtNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            string ten = dtNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            string ngaysinh = dtNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            string gt = dtNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            string sdt = dtNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            string dc = dtNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            string luong = dtNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            string user = dtNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            string pass = dtNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            frmEditNhanVien tnv = new frmEditNhanVien(holot,ten,user,pass,ngaysinh,gt,sdt,dc,luong);
            tnv.ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_QLBH.nhanvien.getNhanvien(dtNhanVien);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void brbtnEX_ItemClick(object sender, ItemClickEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dtNhanVien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtNhanVien.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtNhanVien.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtNhanVien.Columns.Count; j++)
                {
                    if (dtNhanVien.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

    }
}