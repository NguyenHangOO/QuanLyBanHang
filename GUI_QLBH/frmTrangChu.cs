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
using DevExpress.XtraBars.Docking;
using System.IO;

namespace GUI_QLBH
{
    public partial class frmTrangChu : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {

        public frmTrangChu()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
           // string strDate = dt.ToString("dd / MM / yy");
            brTime.Caption = dt.ToString();
            HTMenu();
            andoc();
            luu_ChiTiet = BUS_QLBH.nhanvien.chitiet(frmDangNhap.USERNAME);
        }
        frmPhanQuyen pq;
        frmNhanVien nv;
        frmKhachHang kh;
        frmNhaCungCap ncc;
        frmSanPham sp;
        frmLapHD lhd;
        frmTK_HangHoa tkhh;
        frmTimKiemSQL tksql;
        frmNhapHang nh;
        private void andoc()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
        private void HTMenu()
        {
            pnlMenuHeThong.Visible = false;
            pnlHangHoa.Visible = false;
            pnlBanHang.Visible = false;
            pnlBaoCao.Visible = false;
        }
        private void HMenu()
        {
            if (pnlMenuHeThong.Visible == true)
                pnlMenuHeThong.Visible = false;
            if (pnlHangHoa.Visible == true)
                pnlHangHoa.Visible = false;
            if (pnlBanHang.Visible == true)
                pnlBanHang.Visible = false;
            if (pnlBaoCao.Visible == true)
                pnlBaoCao.Visible = false;
        }
        private void HienMenu(Panel sMenu)
        {
            if (sMenu.Visible == false)
            {
                HMenu();
                sMenu.Visible = true;
            }
            else
                sMenu.Visible = false;
        }
        private void btnConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("Connection.exe");
        }
        /// <summary>
        /// /KT quyền hạn
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        List<string> luu_ChiTiet = null;
        public Boolean checkper(string m)
        {
            Boolean check = false;
            foreach (string item in luu_ChiTiet)
            {
                if (item == m)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        string tenquyen = "";
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            ///////
            
            if (checkper("QL")==true)
            {
                brBTHBanHang.Enabled = true;
                brbtnBaoCaoo.Enabled = true;
                brbtnHangHoa.Enabled = true;
                brbtnMaHoaa.Enabled = true;
                brbtnDSHD.Enabled = true;
                brbtnKhachHang.Enabled = true;
                brbtnNCC.Enabled = true;
                btnNhanVien.Enabled = true;
                btnPhanQuyen.Enabled = true;
                brbtnLog.Enabled = true;
                brbtnBackup.Enabled = true;
                brbtnLHDN.Enabled = true;
                btnHeThong.Enabled = true;
                btnBaoCao.Enabled = true;
                btnBanHang.Enabled = true;
                btnLapHoaDon.Enabled = true;
                btnMahoa.Enabled = true;
                brbtnDSRPT.Enabled = true;
                brbtnRestore.Enabled = true;
                brbtnTKSQL.Enabled = true;
            }
            if(checkper("NV") == true)
            {
                btnNhanVien.Enabled = true;
                btnPhanQuyen.Enabled = true;
                brBTHBanHang.Enabled = true;
                brbtnHangHoa.Enabled = true;
                brbtnDSHD.Enabled = true;
                brbtnKhachHang.Enabled = true;
                brbtnNCC.Enabled = true;
                brbtnLHDN.Enabled = true;
                btnHeThong.Enabled = true;
                btnHistory.Enabled = false;
                btnBanHang.Enabled = true;
            }
            if (checkper("NVBH") == true)
            {
                brBTHBanHang.Enabled = true;
                brbtnHangHoa.Enabled = true;
                brbtnDSHD.Enabled = true;
                brbtnKhachHang.Enabled = true;
                btnBanHang.Enabled = true;
            }
            if (checkper("NVKH") == true)
            {
                brbtnNCC.Enabled = true;
                brbtnHangHoa.Enabled = true;
                brbtnLHDN.Enabled = true;
            }
            if (frmDangNhap.USERNAME == "QuanLi")
            {
                bhdLogin.Caption = frmDangNhap.USERNAME + " (Admin)";
                btnAccont.Caption = frmDangNhap.USERNAME + " (Admin)";
            }
            else
            {
                bhdLogin.Caption = frmDangNhap.USERNAME;
                btnAccont.Caption = frmDangNhap.USERNAME;
            }
            dckKhuyenMai.Close();
            dckDSHD.Close();
            BUS_QLBH.KhachHang.getCLKH(cboMKH);
            dtvDSHD.RowHeadersVisible = false;
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
        }
        private void btnAccont_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Visible = false;
            dn.ShowDialog();
            
        }
        /// <summary>
        /// /dock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckNV.Show();
            if (nv == null || nv.IsDisposed)
            {
                nv = new frmNhanVien();
                //nv.MdiParent = this;
                //nv.Show();
                nv.TopLevel = false;
                dckNV.Controls.Add(nv);
                nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "thoát chương trình");
            Application.Exit();
            
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckPQ.Show();
            if (pq == null || pq.IsDisposed)
            {
                pq = new frmPhanQuyen();
                pq.TopLevel = false;
                dckPQ.Controls.Add(pq);
                pq.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                pq.Dock = DockStyle.Fill;
                pq.Show();
            }
        }

        private void brbtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckKH.Show();
            if (kh == null || kh.IsDisposed)
            {
                kh = new frmKhachHang();
                kh.TopLevel = false;
                dckKH.Controls.Add(kh);
                kh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                kh.Dock = DockStyle.Fill;
                kh.Show();
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            HienMenu(pnlMenuHeThong);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            HienMenu(pnlBanHang);
        }

        private void btnbaoCao_Click(object sender, EventArgs e)
        {
            HienMenu(pnlBaoCao);
        }

        private void brbtnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Visible = false;
            dn.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            dckNV.Show();
            if (nv == null || nv.IsDisposed)
            {
                nv = new frmNhanVien();
                //nv.MdiParent = this;
                //nv.Show();
                nv.TopLevel = false;
                dckNV.Controls.Add(nv);
                nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            HMenu();
        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            dckPQ.Show();
            if (pq == null || pq.IsDisposed)
            {
                pq = new frmPhanQuyen();
                pq.TopLevel = false;
                dckPQ.Controls.Add(pq);
                pq.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                pq.Dock = DockStyle.Fill;
                pq.Show();
            }
            HMenu();
        }

        private void brbtnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckPnlMenu.Show();
        }

        private void brbtnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckNCC.Show();
            if (ncc == null || ncc.IsDisposed)
            {
                ncc = new frmNhaCungCap();
                ncc.TopLevel = false;
                dckNCC.Controls.Add(ncc);
                ncc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ncc.Dock = DockStyle.Fill;
                ncc.Show();
            }
        }

        private void brbtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckKH.Close();
            dckNCC.Close();
            dckNV.Close();
            dckPQ.Close();
            dckSP.Close();
            dckKhuyenMai.Close();
            dckDSHD.Close();
            dckLHD.Close();
            dckHDNhap.Close();
        }

        private void brbtnSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckSP.Show();
            if (sp == null || sp.IsDisposed)
            {
                sp = new frmSanPham();
                sp.TopLevel = false;
                dckSP.Controls.Add(sp);
                sp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                sp.Dock = DockStyle.Fill;
                sp.Show();
            }
        }

        private void brbtnKM_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckKhuyenMai.Show();
            BUS_QLBH.KhuyenMai.getKM(dtvKM);
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if (txtTenKM.Text != "" && txtPT.Text!="")
            {
                if (BUS_QLBH.KhuyenMai.TimTheoMa(cboMKH.SelectedValue+"") == null)
                {
                    DTO_QLBH.KhuyenMai km = new DTO_QLBH.KhuyenMai
                    {
                        makm = cboMKH.SelectedValue + "",
                        tenkm = txtTenKM.Text,
                        phantram = txtPT.Text,
                    };
                    if (!BUS_QLBH.KhuyenMai.ADD_KM(km))
                    {
                        MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    }
                    else
                    {   
                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUS_QLBH.KhuyenMai.getKM(dtvKM);
                        BUS_QLBH.KhachHang.getCLKH(cboMKH);
                        txtPT.ResetText();
                        txtTenKM.ResetText();
                        BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "thêm khuyến mãi");
                    }
                }
                else
                {
                    MessageBox.Show("Mã khuyến mãi này đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (txtTenKM.Text != "" && txtPT.Text != "")
            {
                if (BUS_QLBH.KhuyenMai.TimTheoMa(cboMKH.SelectedValue + "") != null)
                {
                    DTO_QLBH.KhuyenMai km = new DTO_QLBH.KhuyenMai
                    {
                        makm = cboMKH.SelectedValue + "",
                        tenkm = txtTenKM.Text,
                        phantram = txtPT.Text,
                    };
                    if (!BUS_QLBH.KhuyenMai.Edit_KM(km))
                    {
                        MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUS_QLBH.KhuyenMai.getKM(dtvKM);
                        BUS_QLBH.KhachHang.getCLKH(cboMKH);
                        txtPT.ResetText();
                        txtTenKM.ResetText();
                        BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "sửa khuyến mãi");
                    }
                }
                else
                {
                    MessageBox.Show("Mã khuyến mãi này chưa có không thể sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            string ma = dtvKM.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                if (!BUS_QLBH.KhuyenMai.Xoa_KM(ma))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                { 
                    MessageBox.Show("Đã xóa khuyến mãi thành công.");
                    BUS_QLBH.KhuyenMai.getKM(dtvKM);
                    BUS_QLBH.KhachHang.getCLKH(cboMKH);
                    BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "xóa khuyến mãi");
                }

            }
        }

        private void dtvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtvKM.SelectedRows[0];
            txtTenKM.Text = r.Cells["tenkm"].Value.ToString();
            txtPT.Text = r.Cells["phantram"].Value.ToString();
            cboMKH.SelectedValue = r.Cells["MaKM"].Value.ToString();
        }

        private void mnuSr_Click(object sender, EventArgs e)
        {
            if (cboMKH.Text != "")
            {
                //BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                List<DTO_QLBH.KhuyenMai> lskm = BUS_QLBH.KhuyenMai.TimTheoMa(cboMKH.SelectedValue+"");
                if (lskm == null)
                {
                    MessageBox.Show("Không tìm khách hàng có mã: " + cboMKH.Text + " !");
                    BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "tìm kiếm khách hàng");
                    return;
                }
                dtvKM.DataSource = lskm;
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");

        }

        private void brbtnLHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckLHD.Show();
            if (lhd == null || lhd.IsDisposed)
            {
                lhd = new frmLapHD();
                lhd.TopLevel = false;
                dckLHD.Controls.Add(lhd);
                lhd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                lhd.Dock = DockStyle.Fill;
                lhd.Show();
            }
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            HienMenu(pnlHangHoa);
        }


        private void btnMahoa_Click(object sender, EventArgs e)
        {
            // frmMaHoa mh = new frmMaHoa();
            //mh.ShowDialog();
            MessageBox.Show("Hãy cài đặt tool và sử dụng", "Thông báo");
        }

        private void brbtnMayTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dtvDSHD.Visible = true;
            txtTK.Visible = true;
            dckDSHD.Show();
            BUS_QLBH.LoadDLBangHang.LayDSNHD(dtvDSHD);
        }

        private void mnuTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "")
            {
                List<DTO_QLBH.HoaDon> lstdshd = BUS_QLBH.LoadDLBangHang.LayDSHD(txtTK.Text);
                if (lstdshd == null)
                {
                    MessageBox.Show("Khách hàng: " + txtTK.Text + " chưa có mua hàng!");
                    return;
                }
                dtvDSHD.DataSource = lstdshd;
                dtvDSHD.Columns[0].HeaderText = "Mã HD";
                dtvDSHD.Columns[0].Width = 120;
                dtvDSHD.Columns[1].Visible = false;
                dtvDSHD.Columns[2].HeaderText = "Nhân viên";
                dtvDSHD.Columns[3].Visible = false;
                dtvDSHD.Columns[4].HeaderText = "Tổng tiền";
                dtvDSHD.Columns[5].Visible = false;
            }
            else MessageBox.Show("Vui lòng nhập khách hàng để tìm kiếm");
        }

        private void brbtnTraTru_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (tkhh == null || tkhh.IsDisposed)
            {
                tkhh = new frmTK_HangHoa();
                tkhh.Show();
            }
        }

        private void brbtnTKSQL_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckDSHD.Show();
            dtvDSHD.Visible = false;
            txtTK.Visible = false;
            if (tksql == null || tksql.IsDisposed)
            {
                tksql = new frmTimKiemSQL();
                tksql.TopLevel = false;
                dckDSHD.Controls.Add(tksql);
                tksql.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                tksql.Dock = DockStyle.Fill;
                tksql.Show();
            }
        }

        private void brbtnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            dtvDSHD.Visible = true;
            txtTK.Visible = true;
            dckDSHD.Show();
            BUS_QLBH.LoadDLBangHang.LayDSNHD(dtvDSHD);
        }

        private void brbtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReadLog().ShowDialog();
        }

        private void brbtnLHDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            dckHDNhap.Show();
            if (nh == null || nh.IsDisposed)
            {
                nh = new frmNhapHang();
                nh.TopLevel = false;
                dckHDNhap.Controls.Add(nh);
                nh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                nh.Dock = DockStyle.Fill;
                nh.Show();
            }
        }

        private void brbtnTTSP_ItemClick(object sender, ItemClickEventArgs e)
        {
           frmThongTinSanPham tt= new frmThongTinSanPham();
            tt.ShowDialog();

        }

        private void brbtnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCao bc = new frmBaoCao();
            bc.ShowDialog();
        }

        private void brbtnINHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmIN iinn = new frmIN();
            iinn.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new ReadLog().ShowDialog();
            HMenu();
        }

        private void btnLBH_Click(object sender, EventArgs e)
        {
            dckLHD.Show();
            if (lhd == null || lhd.IsDisposed)
            {
                lhd = new frmLapHD();
                lhd.TopLevel = false;
                dckLHD.Controls.Add(lhd);
                lhd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                lhd.Dock = DockStyle.Fill;
                lhd.Show();
            }
            HMenu();
        }

        private void btnHDBH_Click(object sender, EventArgs e)
        {
            dtvDSHD.Visible = true;
            txtTK.Visible = true;
            dckDSHD.Show();
            BUS_QLBH.LoadDLBangHang.LayDSNHD(dtvDSHD);
            HMenu();
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            dckKhuyenMai.Show();
            BUS_QLBH.KhuyenMai.getKM(dtvKM);
            HMenu();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            dckHDNhap.Show();
            if (nh == null || nh.IsDisposed)
            {
                nh = new frmNhapHang();
                nh.TopLevel = false;
                dckHDNhap.Controls.Add(nh);
                nh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                nh.Dock = DockStyle.Fill;
                nh.Show();
            }
            HMenu();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            dckSP.Show();
            if (sp == null || sp.IsDisposed)
            {
                sp = new frmSanPham();
                sp.TopLevel = false;
                dckSP.Controls.Add(sp);
                sp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                sp.Dock = DockStyle.Fill;
                sp.Show();
            }
            HMenu();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (tkhh == null || tkhh.IsDisposed)
            {
                tkhh = new frmTK_HangHoa();
                tkhh.Show();
            }
            HMenu();
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            frmBaoCao bc = new frmBaoCao();
            bc.ShowDialog();
            HMenu();
        }

        private void btnTiemMat_Click(object sender, EventArgs e)
        {
            HMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HMenu();
        }

        private void brbtnDSRPT_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmDesignReport();
        }

        private void brbtnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool bBackUpStatus = true;
            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"c:\SQLBackup"))
            {
                if (File.Exists(@"c:\SQLBackup\wcBackUp1.bak"))
                {
                    if (MessageBox.Show(@"Do you want to replace it?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\SQLBackup\wcBackUp1.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"c:\SQLBackup");
            BUS_QLBH.Backup.BackUp();
            MessageBox.Show("Backup thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BUS_QLBH.WriteLog.Write(frmDangNhap.USERNAME, tenquyen, "backup dữ liệu");
        }

        private void brbtnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"c:\SQLBackup\wcBackUp1.bak"))
                {
                    if (MessageBox.Show("Bạn có chắc chắn bạn khôi phục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BUS_QLBH.Backup.Restore();
                        MessageBox.Show("Đã được khôi phục cơ sở dữ liệu", "Phục hồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"Không thể thực hiện khôi phục dữ liệu (hoặc không đúng đường dẫn)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void brbtnTienMat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSQTM sq =  new frmSQTM();
            sq.ShowDialog();
            
        }

        private void brbtnHDSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            // frmHelp hp = new frmHelp();
            // hp.ShowDialog();
            Help.ShowHelp(this, "file://E:\\NopBai\\Git_QLDAPM\\QuanLyBanHang\\HDSuDung\\HDSuDung.chm");
        }
    }
}