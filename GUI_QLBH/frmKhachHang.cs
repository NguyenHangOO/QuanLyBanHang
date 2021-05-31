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
    public partial class frmKhachHang : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string tenquyen;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //dckPnlLKH.Close();
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
            dtvLoaiKH.RowHeadersVisible = false;
            BUS_QLBH.KhachHang.getLoaiKH(dtvLoaiKH);
            dtvLoaiKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BUS_QLBH.KhachHang.getKH(dtvKhachHang);
            BUS_QLBH.KhachHang.getCLKH(cboLKH);
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            frmAddLoaiKH lkh = new frmAddLoaiKH();
            lkh.ShowDialog();
        }

        private void brbtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_QLBH.KhachHang.getLoaiKH(dtvLoaiKH);
            BUS_QLBH.KhachHang.getKH(dtvKhachHang);
            BUS_QLBH.KhachHang.getCLKH(cboLKH);
            restText();
        }
        private void crchckKH_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (brchckKH.Checked==false)
            {
                dckPlKhachHang.Close();
            }
            else
            {
                dckPlKhachHang.Show();
            }
        }

        private void brchckLKH_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (brchckLKH.Checked == false)
            {
                dckPnlLoaiKH.Close();
            }
            else
            {
                dckPnlLoaiKH.Show();
            }
        }

        private void dtvKhachHang_Click(object sender, EventArgs e)
        {
            String gt = dtvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
            DataGridViewRow r = new DataGridViewRow();
            r = dtvKhachHang.SelectedRows[0];
            txtMa.Text = r.Cells["Ma_kh"].Value.ToString();
            txtHoTen.Text = r.Cells["Hoten"].Value.ToString();
            if (gt == "Nam")
            {
                rdoNam.Checked = true;
            }
            else rdoNu.Checked = true;
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = r.Cells["SDT"].Value.ToString();
            //cboLKH.SelectedValue = r.Cells["TenLoaiKH"].Value.ToString();
            cboLKH.SelectedValue = r.Cells["Ma_LKH"].Value.ToString();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            string malkh = dtvLoaiKH.SelectedRows[0].Cells[0].Value.ToString();
            string tenlkh = dtvLoaiKH.SelectedRows[0].Cells[1].Value.ToString();
            frmEditLoaiKH slkh = new frmEditLoaiKH(malkh,tenlkh);
            slkh.ShowDialog();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            string ma = dtvLoaiKH.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa loại khách hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                
                if (!BUS_QLBH.KhachHang.Xoa_LKH(ma))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                {
                    BUS_QLBH.KhachHang.getLoaiKH(dtvLoaiKH);
                    BUS_QLBH.KhachHang.getCLKH(cboLKH);
                    MessageBox.Show("Đã xóa loại khách hàng thành công.");
                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "Xóa loại khách hàng");
                }
               
            }
        }

        private void brbtnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMa.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10 || Edit.IsNumber(txtSDT.Text) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (BUS_QLBH.KhachHang.KTMaKH(txtMa.Text) == null)
                    {
                        if (txtMa.Text.Length == 5)
                        {
                            string gt = "";
                            if (rdoNu.Checked == true)
                            {
                                gt = "Nữ";
                            }
                            else gt = "Nam";
                            DTO_QLBH.khachhang kh = new DTO_QLBH.khachhang
                            {
                                ma_kh = txtMa.Text,
                                hoten = txtHoTen.Text,
                                gioitinh = gt,
                                diachi = txtDiaChi.Text,
                                sdt = txtSDT.Text,
                                ma_lkh = cboLKH.SelectedValue.ToString(),
                            };
                            if (!BUS_QLBH.KhachHang.ADD_KH(kh))
                            {
                                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm khách hàng");
                                BUS_QLBH.KhachHang.getKH(dtvKhachHang);
                                restText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã khách hàng phải đủ 5 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void brbtnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMa.Text !="")
            {
                //BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                List<DTO_QLBH.khachhang> lstkh = BUS_QLBH.KhachHang.TimTheoMaKH(txtMa.Text);
                if (lstkh == null)
                {
                    MessageBox.Show("Không tìm khách hàng có mã: " + txtMa.Text + " !");
                    return;
                }
                dtvKhachHang.DataSource = lstkh;
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");
        }

        private void brbtnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMa.Enabled = false;
            if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
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
                    if (BUS_QLBH.KhachHang.KTMaKH(txtMa.Text) != null)
                    {
                        if (txtMa.Text.Length == 5)
                        {
                            string gt = "";
                            if (rdoNu.Checked == true)
                            {
                                gt = "Nữ";
                            }
                            else gt = "Nam";
                            DTO_QLBH.khachhang kh = new DTO_QLBH.khachhang
                            {
                                ma_kh = txtMa.Text,
                                hoten = txtHoTen.Text,
                                gioitinh = gt,
                                diachi = txtDiaChi.Text,
                                sdt = txtSDT.Text,
                                ma_lkh = cboLKH.SelectedValue.ToString(),
                            };
                            if (!BUS_QLBH.KhachHang.Edit_KH(kh))
                            {
                                MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa khách hàng");
                                txtMa.Enabled = true;
                                restText();
                                BUS_QLBH.KhachHang.getKH(dtvKhachHang);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã khách hàng không được phép thay đổi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng không được phép thay đổi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void brbtnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ma = dtvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                if (!BUS_QLBH.KhachHang.Xoa_KH(ma))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                {
                    BUS_QLBH.KhachHang.getKH(dtvKhachHang);
                    MessageBox.Show("Đã xóa khách hàng thành công.");
                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa khách hàng");
                }

            }
        }
        private void restText()
        {
            txtMa.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.ResetText();
            txtSDT.ResetText();
            rdoNam.Checked = true;
            rdoNu.Checked = false;
        }

        private void brbtnEx_ItemClick(object sender, ItemClickEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dtvKhachHang.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtvKhachHang.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtvKhachHang.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtvKhachHang.Columns.Count; j++)
                {
                    if (dtvKhachHang.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtvKhachHang.Rows[i].Cells[j].Value.ToString();
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