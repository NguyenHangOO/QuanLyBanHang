using DevExpress.XtraBars;
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
    public partial class frmEditLoaiKH : DevExpress.XtraEditors.XtraForm
    {
        public frmEditLoaiKH()
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
        public frmEditLoaiKH(string malkh, string tenlkh) : this()
        {
            txtMa.Text = malkh;
            txtTenLoai.Text = tenlkh;
        }
        private void frmEditLoaiKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMa.Text != "" && txtMa.Text.Length == 5)
                {
                    if (txtTenLoai.Text != "")
                    {
                        if (BUS_QLBH.KhachHang.TimTheoMa(txtMa.Text) != null)
                        {
                            DTO_QLBH.LoaiKH lkh = new DTO_QLBH.LoaiKH
                            {
                                ma_lkh = txtMa.Text,
                                tenloaikh = txtTenLoai.Text,
                            };
                            if (!BUS_QLBH.KhachHang.Edit_LKH(lkh))
                            {
                                MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "sửa loại khách hàng");
                                this.Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã loại khách hàng không được phép sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại khách hàng không được phép sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}