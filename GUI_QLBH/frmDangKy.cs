using DevExpress.XtraEditors;
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
    public partial class frmDangKy : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        { 
            if(BUS_QLBH.nhanvien.TimTheoUser(txtUser.Text)!= null)
            {
                MessageBox.Show("Username này đã tồn tại. Vui lòng đặt tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
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
                        if (txtUser.Text != "")
                        {
                            if (txtPass.Text != "" && txtPass.Text.Length >= 6)
                            {
                                if (txtPass.Text.Equals(txtPass2.Text))
                                {
                                    float Luong = 3000000;
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
                                        luong = Luong,
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
                                        MessageBox.Show("Đăng ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu nhập không khớp. Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }
            }   
        }
    }
}