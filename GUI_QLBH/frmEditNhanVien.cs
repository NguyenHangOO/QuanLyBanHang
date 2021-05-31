using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmEditNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmEditNhanVien()
        {
            InitializeComponent();
            txtUser.Enabled = false;
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
        public frmEditNhanVien(string holot,string ten,string  user,string pass,string ngaysinh,string gt,string sdt,string dc,string luong ):this()
        {
            txtHo.Text = holot;
            txtTen.Text = ten;
            txtUser.Text = user;
            txtPass.Text = DTO_QLBH.Encode.Decrypt(pass);
            dtNgaysinh.Text = ngaysinh;
            if (gt == "Nam")
            {
                rdbNam.Checked = true;
            }
            else rdbNu.Checked = true;
            txtSDT.Text = sdt;
            txtDiaChi.Text = dc;
            txtLuong.Text = luong;
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            string gt = "";
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            else gt = "Nam";
            DTO_QLBH.nhanvien nv = new DTO_QLBH.nhanvien
            {
                ho_lot = txtHo.Text,
                ten = txtTen.Text,
                ngaysinh = dtNgaysinh.Text,
                gioitinh = gt,
                sdt = txtSDT.Text,
                diachi = txtDiaChi.Text,
                luong = float.Parse(txtLuong.Text),
                username = txtUser.Text,
                pass = DTO_QLBH.Encode.Encrypt(txtPass.Text),
            };
            if (!BUS_QLBH.nhanvien.SuaNhanVien(nv))
            {
                if (MessageBox.Show("Lỗi kết nối, bạn có muốn mở trình quản lý kết nối?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process.Start("Connection.exe");
                }
                //else;
            }
            else
            {
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "sửa nhân viên");
                this.Dispose();
                
            }
        }
        private void frmEditNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEdit.PerformClick();
            }    
        }
    }
}