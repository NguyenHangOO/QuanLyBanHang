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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            BUS_QLBH.SanPham.getCboSP(cboMaHang);
            BUS_QLBH.NCC.getCNCC(cboMaNCC);
            cboUser.Text = frmDangNhap.USERNAME;
            txtTenNV.Text = BUS_QLBH.nhanvien.LayTNV(frmDangNhap.USERNAME);
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
        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtNgayNhap.Text = DateTime.Now.ToShortDateString();
            cboMaNCC.Text = "";
            txtTongTien.Text = "0";
            //lblTongTien.Text = "..........";
            cboMaHang.Text = "";
            mrcsoluong.Text = "";
            txtThanhTien.Text = "0";
        }
        private void loadDLNH()
        {
            List<DTO_QLBH.DSSPNhap> lsdlnh = BUS_QLBH.NhapHang.GetDLNhapHang(txtMaHD.Text);
            dtvHDNH.DataSource = lsdlnh;
            dtvHDNH.RowHeadersVisible = false;
            dtvHDNH.Columns[0].HeaderText = "Mã hàng";
            dtvHDNH.Columns[1].HeaderText = "Tên hàng";
            dtvHDNH.Columns[2].HeaderText = "Số lượng";
            dtvHDNH.Columns[3].HeaderText = "Đơn giá";
            dtvHDNH.Columns[4].HeaderText = "Thành tiền";
            dtvHDNH.Columns[0].Width = 80;
            dtvHDNH.Columns[1].Width = 130;
            dtvHDNH.Columns[2].Width = 80;
            dtvHDNH.Columns[3].Width = 90;
            dtvHDNH.Columns[4].Width = 90;
            dtvHDNH.Columns[5].Visible = false;

        }

        private void cboMaHang_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = BUS_QLBH.SanPham.LayTen(cboMaHang.SelectedValue + "");
            txtDonGia.Text = BUS_QLBH.SanPham.LayDGN(cboMaHang.SelectedValue + "");
        }

        private void mrcsoluong_Click(object sender, EventArgs e)
        {
            int sl = 0; float tt, dg;
            if (mrcsoluong.Text != "")
                sl = Int32.Parse(mrcsoluong.Text);
            else
                sl = 0;
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = float.Parse(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }
        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            mrcsoluong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtvHDNH_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtvHDNH.SelectedRows[0];
            mrcsoluong.Text = r.Cells["soluong"].Value.ToString();
            cboMaHang.Text = r.Cells["ma_hh"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHD.Text = Edit.TaoKhoa("HDN");
            loadDLNH();
        }

        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            txtTenNCC.Text = BUS_QLBH.NCC.LayTen(cboMaNCC.SelectedValue + "");
            txtDC.Text = BUS_QLBH.NCC.LayDC(cboMaNCC.SelectedValue + "");
            txtSDT.Text = BUS_QLBH.NCC.LaySDT(cboMaNCC.SelectedValue + "");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl, SLcon; float tong, Tongmoi;
            string ht = "null";
            if (BUS_QLBH.NhapHang.LayMaHD(txtMaHD.Text) == null)
            {
                if (rdoTienMat.Checked == true)
                {
                    ht = "Tiền mặt";
                }

                if (dtNgayNhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtNgayNhap.Focus();
                    return;
                }
                if (cboUser.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboUser.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNCC.Focus();
                    return;
                }
                DTO_QLBH.PhieuNhap hd = new DTO_QLBH.PhieuNhap
                {
                    ma_phap = txtMaHD.Text,
                    ma_ncc = cboMaNCC.SelectedValue + "",
                    nguoinhap = frmDangNhap.USERNAME,
                    ngaylap = dtNgayNhap.Text,
                    tongtien = float.Parse(txtTongTien.Text),
                    hinhthuc = ht,
                };
                if (!BUS_QLBH.NhapHang.Add_HDN(hd))
                {
                    MessageBox.Show("Lưu hóa đơn không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            //////chitietshoDON
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((mrcsoluong.Text.Trim().Length == 0) || (mrcsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mrcsoluong.Text = "";
                mrcsoluong.Focus();
                return;
            }
            if (BUS_QLBH.NhapHang.LayMaHH(txtMaHD.Text, cboMaHang.SelectedValue + "") != null)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            sl = BUS_QLBH.NhapHang.LaySlg(cboMaHang.SelectedValue + "");
            
            DTO_QLBH.ChiTietPN cthd = new DTO_QLBH.ChiTietPN
            {
                ma_phap = txtMaHD.Text,
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Int32.Parse(mrcsoluong.Text),
                dongia = float.Parse(txtDonGia.Text),
                thanhtien = float.Parse(txtThanhTien.Text),
            };
            if (!BUS_QLBH.NhapHang.Add_CTHDN(cthd))
            {
                MessageBox.Show("Lưu hóa đơn chi tiết không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            loadDLNH();
            SLcon = sl + Int32.Parse(mrcsoluong.Text);
            DTO_QLBH.SanPham upsp = new DTO_QLBH.SanPham
            {
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Convert.ToInt32(SLcon),
            };
            if (!BUS_QLBH.NhapHang.Update_SlgSP(upsp))
            {
                MessageBox.Show("Update số lượng tồn không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = BUS_QLBH.NhapHang.LayTongTien(txtMaHD.Text);
            Tongmoi = tong + float.Parse(txtThanhTien.Text);
            DTO_QLBH.PhieuNhap uptt = new DTO_QLBH.PhieuNhap
            {
                ma_phap = txtMaHD.Text,
                tongtien = Tongmoi,
            };
            if (!BUS_QLBH.NhapHang.Update_TTg(uptt))
            {
                MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "lập hóa đơn nhập hàng");
            txtTongTien.Text = Tongmoi.ToString();
            //lblTongTien.Text = Edit.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            int slgxoa, slgton, slgmoi;
            float ttxoa, ttmoi, tthco;
            string ma = txtMaHD.Text;
            string mahh = dtvHDNH.SelectedRows[0].Cells[0].Value.ToString();
            slgxoa = BUS_QLBH.NhapHang.LaySlgXoa(mahh, ma);
            slgton = BUS_QLBH.NhapHang.LaySlg(mahh);
            slgmoi = slgton - slgxoa;
            ttxoa = BUS_QLBH.NhapHang.LayTTXoa(mahh, ma);
            tthco = BUS_QLBH.NhapHang.LayTongTien(ma);
            ttmoi = tthco - ttxoa;
            DTO_QLBH.SanPham upsp = new DTO_QLBH.SanPham
            {
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Convert.ToInt32(slgmoi),
            };
            if (!BUS_QLBH.NhapHang.Update_SlgSP(upsp))
            {
                MessageBox.Show("Update số lượng tồn không thành công, nên không thể xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                DTO_QLBH.PhieuNhap uptt = new DTO_QLBH.PhieuNhap
                {
                    ma_phap = txtMaHD.Text,
                    tongtien = ttmoi,
                };
                if (!BUS_QLBH.NhapHang.Update_TTg(uptt))
                {
                    MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {

                        if (!BUS_QLBH.NhapHang.Xoa_SPHD(ma, mahh))
                        {
                            MessageBox.Show("Không xóa được.");
                            return;
                        }
                        else
                        {
                            txtTongTien.Text = ttmoi.ToString();
                            loadDLNH();
                            MessageBox.Show("Đã xóa sản phẩm thành công.");
                            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "xóa sản phẩm nhập hàng");
                        }
                    }
                }

            }
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
           
            if (mrcsoluong.Text != "")
            {
                int slgxoa, slgton, slgmoi, slgth;
                float ttxoa, ttmoi, tthco, ttthem;
                string ma = txtMaHD.Text;
                string mahh = dtvHDNH.SelectedRows[0].Cells[0].Value.ToString();
                slgxoa = BUS_QLBH.NhapHang.LaySlgXoa(mahh, ma);
                slgton = BUS_QLBH.NhapHang.LaySlg(mahh);
                slgth = Int32.Parse(mrcsoluong.Text);
                slgmoi = (slgton - slgxoa) + slgth;
                ttxoa = BUS_QLBH.NhapHang.LayTTXoa(mahh, ma);
                tthco = BUS_QLBH.NhapHang.LayTongTien(ma);
                ttthem = float.Parse(txtThanhTien.Text);
                ttmoi = tthco - ttxoa + ttthem;
                DTO_QLBH.ChiTietPN cthd = new DTO_QLBH.ChiTietPN
                {
                    ma_phap = txtMaHD.Text,
                    ma_hh = cboMaHang.Text,
                    soluong = Int32.Parse(mrcsoluong.Text),
                    thanhtien = float.Parse(txtThanhTien.Text),

                };
                if (!BUS_QLBH.NhapHang.Edit_SPHD(cthd))
                {
                    MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DTO_QLBH.SanPham upsp = new DTO_QLBH.SanPham
                    {
                        ma_hh = cboMaHang.SelectedValue + "",
                        soluong = Convert.ToInt32(slgmoi),
                    };
                    if (!BUS_QLBH.NhapHang.Update_SlgSP(upsp))
                    {
                        MessageBox.Show("Update số lượng tồn không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DTO_QLBH.PhieuNhap uptt = new DTO_QLBH.PhieuNhap
                        {
                            ma_phap = txtMaHD.Text,
                            tongtien = ttmoi,
                        };
                        if (!BUS_QLBH.NhapHang.Update_TTg(uptt))
                        {
                            MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtTongTien.Text = ttmoi.ToString();
                            loadDLNH();
                            MessageBox.Show("Đã sửa số lượng sản phẩm thành công.");
                            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "sửa số lượng sản phẩm nhập hàng");
                        }

                    }
                }
            }
            else
                MessageBox.Show("Số lượng không được trống?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string manh = txtMaHD.Text;
            string ma = ".";
            frmInHoaDon ihd = new frmInHoaDon(ma, manh);
            ihd.ShowDialog();
        }
    }
}