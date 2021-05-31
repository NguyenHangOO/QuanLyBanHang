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
    public partial class frmLapHD : DevExpress.XtraEditors.XtraForm
    {
        public frmLapHD()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtNgayBan.Text = DateTime.Now.ToShortDateString();
            //cboUser.Text = "";
            cboMaKH.Text = "";
            txtTongTien.Text = "0";
            lblTongTien.Text = "..........";
            cboMaHang.Text = "";
            mrcsoluong.Text = "";
           // txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }
        private void frmLapHD_Load(object sender, EventArgs e)
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
            //
            BUS_QLBH.SanPham.getCboSP(cboMaHang);
            BUS_QLBH.KhachHang.getCboKH(cboMaKH);
            cboUser.Text = frmDangNhap_Main.USERNAME;
            txtTenNV.Text = BUS_QLBH.nhanvien.LayTNV(frmDangNhap_Main.USERNAME);  
        }
        string tenquyen;
        private void cboMaKH_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = BUS_QLBH.KhachHang.LayTen(cboMaKH.SelectedValue + "");
            txtDC.Text = BUS_QLBH.KhachHang.LayDC(cboMaKH.SelectedValue + "");
            txtSDT.Text = BUS_QLBH.KhachHang.LaySDT(cboMaKH.SelectedValue + "");
            string malkh = BUS_QLBH.KhachHang.LayMLKH(cboMaKH.SelectedValue + "");
            txtGiamGia.Text = BUS_QLBH.KhuyenMai.LayMKM(malkh);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHD.Text = Edit.TaoKhoa("HDB");
            loadDLBH();
        }
        private void loadDLBH()
        {
            List<DTO_QLBH.LoadDLBanHang> lsdlbh = BUS_QLBH.LoadDLBangHang.GetDLBanHang(txtMaHD.Text);
            dtvHDBH.DataSource = lsdlbh;
            dtvHDBH.RowHeadersVisible = false;
            dtvHDBH.Columns[0].HeaderText = "Mã hàng";
            dtvHDBH.Columns[1].HeaderText = "Tên hàng";
            dtvHDBH.Columns[2].HeaderText = "Số lượng";
            dtvHDBH.Columns[3].HeaderText = "Đơn giá";
            dtvHDBH.Columns[4].HeaderText = "Giảm giá %";
            dtvHDBH.Columns[5].HeaderText = "Thành tiền";
            dtvHDBH.Columns[0].Width = 80;
            dtvHDBH.Columns[1].Width = 130;
            dtvHDBH.Columns[2].Width = 80;
            dtvHDBH.Columns[3].Width = 90;
            dtvHDBH.Columns[4].Width = 90;
            dtvHDBH.Columns[5].Width = 90;
            dtvHDBH.Columns[6].Visible = false;

        }
        private void cboMaHang_TextChanged(object sender, EventArgs e)
        {
            txtTenHang.Text = BUS_QLBH.SanPham.LayTen(cboMaHang.SelectedValue + "");
            txtDonGia.Text = BUS_QLBH.SanPham.LayDG(cboMaHang.SelectedValue + "");
        }

        private void mrcsoluong_ValueChanged(object sender, EventArgs e)
        {
            int sl = 0; float tt, dg, gg;
            if (mrcsoluong.Text != "")
                sl = Int32.Parse(mrcsoluong.Text);
            else
                sl = 0;
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = float.Parse(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = float.Parse(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            int sl; float tt, dg, gg;
            if (mrcsoluong.Text == "")
                sl = 0;
            else
                sl = Int32.Parse(mrcsoluong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = float.Parse(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = float.Parse(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }
        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            mrcsoluong.Text = "";
           // txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl, SLcon; float tong, Tongmoi;
            string ht = "null";
            if (txtGiamGia.Text == "")
            {
                txtGiamGia.Text = "0";
            }
            float ggg = (float.Parse(txtDonGia.Text) * Int32.Parse(mrcsoluong.Text)) * float.Parse(txtGiamGia.Text) / 100;   
            if (BUS_QLBH.LoadDLBangHang.LayMaHD(txtMaHD.Text) == null)
            {
                if (rdoTienMat.Checked == true)
                {
                    ht = "Tiền mặt";
                }

                if (dtNgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtNgayBan.Focus();
                    return;
                }
                if (cboUser.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboUser.Focus();
                    return;
                }
                if (cboMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKH.Focus();
                    return;
                }
                DTO_QLBH.HoaDon hd = new DTO_QLBH.HoaDon
                {
                    ma_hd = txtMaHD.Text,
                    ma_kh = cboMaKH.SelectedValue + "",
                    username = frmDangNhap_Main.USERNAME,
                    ngaylap = dtNgayBan.Text,
                    tongtien = float.Parse(txtTongTien.Text),
                    hinhthuc = ht,
                };
                if (!BUS_QLBH.LoadDLBangHang.Add_HD(hd))
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
            if (txtGiamGia.Text.Trim().Length == 0)
            {
                txtGiamGia.Text = "0";
            }
            if (BUS_QLBH.LoadDLBangHang.LayMaHH(txtMaHD.Text, cboMaHang.SelectedValue + "") != null)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            sl = BUS_QLBH.LoadDLBangHang.LaySlg(cboMaHang.SelectedValue + "");
            if (Convert.ToDouble(mrcsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mrcsoluong.Text = "";
                mrcsoluong.Focus();
                return;
            }
            DTO_QLBH.ChitietHD cthd = new DTO_QLBH.ChitietHD
            {
                ma_hd = txtMaHD.Text,
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Int32.Parse(mrcsoluong.Text),
                dongia = float.Parse(txtDonGia.Text),
                giamgia = ggg,
                thanhtien = float.Parse(txtThanhTien.Text),
            };
            if (!BUS_QLBH.LoadDLBangHang.Add_CTHD(cthd))
            {
                MessageBox.Show("Lưu hóa đơn chi tiết không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            loadDLBH();
            SLcon = sl - Int32.Parse(mrcsoluong.Text);
            DTO_QLBH.SanPham upsp = new DTO_QLBH.SanPham
            {
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Convert.ToInt32(SLcon),
            };
            if (!BUS_QLBH.LoadDLBangHang.Update_SlgSP(upsp))
            {
                MessageBox.Show("Update số lượng tồn không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = BUS_QLBH.LoadDLBangHang.LayTongTien(txtMaHD.Text);
            Tongmoi = tong + float.Parse(txtThanhTien.Text);
            DTO_QLBH.HoaDon uptt = new DTO_QLBH.HoaDon
            {
                ma_hd = txtMaHD.Text,
                tongtien = Tongmoi,
            };
            if (!BUS_QLBH.LoadDLBangHang.Update_TTg(uptt))
            {
                MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "lập hóa đơn bán");
            txtTongTien.Text = Tongmoi.ToString();
            lblTongTien.Text = Edit.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int slgxoa, slgton, slgmoi;
            float ttxoa, ttmoi, tthco;
            string ma = txtMaHD.Text;
            string mahh = dtvHDBH.SelectedRows[0].Cells[0].Value.ToString();
            slgxoa = BUS_QLBH.LoadDLBangHang.LaySlgXoa(mahh, ma);
            slgton = BUS_QLBH.LoadDLBangHang.LaySlg(mahh);
            slgmoi = slgton + slgxoa;
            ttxoa = BUS_QLBH.LoadDLBangHang.LayTTXoa(mahh, ma);
            tthco = BUS_QLBH.LoadDLBangHang.LayTongTien(ma);
            ttmoi = tthco - ttxoa;
            DTO_QLBH.SanPham upsp = new DTO_QLBH.SanPham
            {
                ma_hh = cboMaHang.SelectedValue + "",
                soluong = Convert.ToInt32(slgmoi),
            };
            if (!BUS_QLBH.LoadDLBangHang.Update_SlgSP(upsp))
            {
                MessageBox.Show("Update số lượng tồn không thành công, nên không thể xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                DTO_QLBH.HoaDon uptt = new DTO_QLBH.HoaDon
                {
                    ma_hd = txtMaHD.Text,
                    tongtien = ttmoi,
                };
                if (!BUS_QLBH.LoadDLBangHang.Update_TTg(uptt))
                {
                    MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }               
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {

                        if (!BUS_QLBH.LoadDLBangHang.Xoa_SPHD(ma, mahh))
                        {
                            MessageBox.Show("Không xóa được.");
                            return;
                        }
                        else
                        {
                            txtTongTien.Text = ttmoi.ToString();
                            loadDLBH();
                            MessageBox.Show("Đã xóa sản phẩm thành công.");
                            BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa sản phẩm trên hóa đơn");
                        }
                    }
                }

            }
        }
    
        private void mnuSua_Click(object sender, EventArgs e)
        {
            
            if (mrcsoluong.Text!="")
            {
                int slgxoa, slgton, slgmoi, slgth;
                float ttxoa, ttmoi, tthco, ttthem;
                string ma = txtMaHD.Text;
                string mahh = dtvHDBH.SelectedRows[0].Cells[0].Value.ToString();
                slgxoa = BUS_QLBH.LoadDLBangHang.LaySlgXoa(mahh, ma);
                slgton = BUS_QLBH.LoadDLBangHang.LaySlg(mahh);
                slgth = Int32.Parse(mrcsoluong.Text);
                slgmoi = (slgton + slgxoa) - slgth;
                ttxoa = BUS_QLBH.LoadDLBangHang.LayTTXoa(mahh, ma);
                tthco = BUS_QLBH.LoadDLBangHang.LayTongTien(ma);
                ttthem = float.Parse(txtThanhTien.Text);
                ttmoi = tthco - ttxoa + ttthem;
                if (txtGiamGia.Text.Trim().Length == 0)
                {
                    txtGiamGia.Text = "0";
                }
                DTO_QLBH.ChitietHD cthd = new DTO_QLBH.ChitietHD
                {
                    ma_hd = txtMaHD.Text,
                    ma_hh=cboMaHang.Text,
                    soluong = Int32.Parse(mrcsoluong.Text),
                    giamgia= float.Parse(txtGiamGia.Text),
                    thanhtien = float.Parse(txtThanhTien.Text),

                };
                if (!BUS_QLBH.LoadDLBangHang.Edit_SPHD(cthd))
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
                    if (!BUS_QLBH.LoadDLBangHang.Update_SlgSP(upsp))
                    {
                        MessageBox.Show("Update số lượng tồn không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DTO_QLBH.HoaDon uptt = new DTO_QLBH.HoaDon
                        {
                            ma_hd = txtMaHD.Text,
                            tongtien = ttmoi,
                        };
                        if (!BUS_QLBH.LoadDLBangHang.Update_TTg(uptt))
                        {
                            MessageBox.Show("Update tổng tiền không thành công?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtTongTien.Text = ttmoi.ToString();
                            loadDLBH();
                            MessageBox.Show("Đã sửa số lượng sản phẩm thành công.");
                            BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa số lượng sản phẩm");
                        }
                        
                    }    
                }
            } 
            else
            {
                MessageBox.Show("Chưa nhập số lượng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void dtvHDBH_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtvHDBH.SelectedRows[0];
            mrcsoluong.Text = r.Cells["soluong"].Value.ToString();
            cboMaHang.Text= r.Cells["ma_hh"].Value.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string ma = txtMaHD.Text;
            string manh = ".";
            frmInHoaDon ihd = new frmInHoaDon(ma,manh);
            ihd.ShowDialog();

        }
    }
}