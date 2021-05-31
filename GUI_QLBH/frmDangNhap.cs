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
    public partial class frmDangNhap : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            //frmFash flash = new frmFash();
            //flash.ShowDialog();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Edit.chinhanh(prcLogin);
            Edit.chinhanh(prcUser);
            Edit.chinhanh(prcPass);
            txtUser.ForeColor = Color.LightGray;
            txtUser.Text = "Username";
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);

            txtPass.ForeColor = Color.LightGray;
            txtPass.Text = "Password";
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Black;
            }
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Gray;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Black;

            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Gray;
                // this.txtPass.PasswordChar = '*';
                this.txtPass.Properties.UseSystemPasswordChar = true;
            }
        }
        private void btnConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("Connection.exe");
        }
        public static string USERNAME = "";
        
        private void btnDN_Click(object sender, EventArgs e)
        {
            string tenquyen = "";
            if(txtUser.Text !="" && txtPass.Text !="")
            {
                USERNAME = BUS_QLBH.nhanvien.GetID(txtUser.Text, DTO_QLBH.Encode.Encrypt(txtPass.Text));
                if (USERNAME != "")
                {
                    if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME)=="3")
                    {
                        tenquyen = "Quản trị";
                    } 
                    else if(BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "2")
                    {
                        tenquyen = "Quản lý";
                    }   else tenquyen = "Nhân viên";
                    frmTrangChu tc = new frmTrangChu();
                    this.Visible = false;
                    MessageBox.Show("Xin chào user có tên: "+frmDangNhap.USERNAME.Trim()+" - thuộc nhóm quyền: "+ tenquyen, "Thông báo");
                    BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME,tenquyen,"đăng nhập vào hệ thống"); //nhập vô 3 cái chuỗi 1 là tên user 2 là quyền 3 là việc đang làm
                    tc.ShowDialog();  
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                txtUser.ResetText();
                txtPass.ResetText();
                txtUser.Focus();
            }    
            else
                MessageBox.Show("Vui lòng điền thông tin đăng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHien.Checked)
                txtPass.Properties.UseSystemPasswordChar = false;
            else
                txtPass.Properties.UseSystemPasswordChar = true;
        }

        private void lnkDK_Click(object sender, EventArgs e)
        {
            new frmDangKy().ShowDialog();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

    }
}