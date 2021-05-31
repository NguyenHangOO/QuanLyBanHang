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
    public partial class frmAddLoaiKH : DevExpress.XtraEditors.XtraForm
    {
        public frmAddLoaiKH()
        {
            InitializeComponent();
        }
        string tenquyen = "";
        private void frmAdd_EditLoaiKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               if(txtMa.Text!=""&& txtMa.Text.Length==5)
                {
                    if(txtTenLoai.Text!="")
                    {
                        if (BUS_QLBH.KhachHang.TimTheoMa(txtMa.Text) == null)
                        {
                            DTO_QLBH.LoaiKH lkh = new DTO_QLBH.LoaiKH
                            {
                                ma_lkh = txtMa.Text,
                                tenloaikh = txtTenLoai.Text,
                            };
                            if (!BUS_QLBH.KhachHang.ADD_LoaiKH(lkh))
                            {
                                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "thêm loại khách hàng");
                                this.Dispose();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã loại khách hàng này đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMa.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                { 
                    MessageBox.Show("Mã loại không được để trống và phải đủ 5 ký tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmAddLoaiKH_Load(object sender, EventArgs e)
        {
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
            //BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "thêm khuyến mãi");
        }
    }
}