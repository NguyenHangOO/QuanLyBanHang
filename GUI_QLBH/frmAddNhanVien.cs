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
    public partial class frmAddNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
        }
        string tenquyen = "";
        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10 || Edit.IsNumber(txtSDT.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (BUS_QLBH.nhanvien.TimTheoUser(txtUser.Text) == null)
                    {
                        if (Edit.IsNumber(txtLuong.Text) == true)
                        {
                            if (txtUser.Text != "")
                            {
                                if (txtPass.Text != "" && txtPass.Text.Length >= 6)
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
                                    if (!BUS_QLBH.nhanvien.Add(nv))
                                    {
                                        if (MessageBox.Show("Lỗi kết nối, bạn có muốn mở trình quản lý kết nối?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                                        {
                                            Process.Start("Connection.exe");
                                        }
                                        //else;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm nhân viên");
                                        this.Dispose();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không được trống và tối thiểu 6 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập không được trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lương không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }     
                    }
                    else
                    {
                        MessageBox.Show("Username đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10 || Edit.IsNumber(txtSDT.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (BUS_QLBH.nhanvien.TimTheoUser(txtUser.Text) == null)
                    {
                        if (Edit.IsNumber(txtLuong.Text) == true)
                        {
                            if (txtUser.Text != "")
                            {
                                if (txtPass.Text != "" && txtPass.Text.Length >= 6)
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
                                    if (!BUS_QLBH.nhanvien.Add(nv))
                                    {
                                        if (MessageBox.Show("Lỗi kết nối, bạn có muốn mở trình quản lý kết nối?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                                        {
                                            Process.Start("Connection.exe");
                                        }
                                        //else;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm nhân viên");
                                        this.Dispose();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không được trống và tối thiểu 6 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập không được trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lương không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frmAddNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }

        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
            //BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm khuyến mãi");
        }

        /// <summary>
        /// Undo va Redo
        /// </summary>


    }
}