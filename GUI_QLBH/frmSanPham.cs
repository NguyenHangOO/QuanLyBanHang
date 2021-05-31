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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
            luu_ChiTiet = BUS_QLBH.nhanvien.chitiet(frmDangNhap_Main.USERNAME);
            if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "3")
            {
                tenquyen = "Quản trị";
            }
            else if (BUS_QLBH.nhanvien.QuyenHan(frmDangNhap_Main.USERNAME) == "2")
            {
                tenquyen = "Quản lý";
            }
            else tenquyen = "Nhân viên";
        }
        string tenquyen;
        private void btnload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }
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
        private void reset()
        {
            txtMaHang.ResetText();
            txtTenHang.ResetText();
            txtGhiChu.ResetText();
            txtDVT.ResetText();
            txtDGN.ResetText();
            txtDGB.ResetText();
            txtAnh.ResetText();
            cboNcc.ResetText();
            picAnh.Image = null;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BUS_QLBH.NCC.getCboNCC(cboNcc);
            BUS_QLBH.SanPham.getSP(dtvSp);
            if (checkper("NVBH") == true)
            {
                brbtnThem.Enabled = false;
                brbtnSua.Enabled = false;
                brbtnXoa.Enabled = false;
            }
        }
        
        private void dtvSp_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtvSp.SelectedRows[0];
            txtMaHang.Text = r.Cells["ma_hh"].Value.ToString();
            txtTenHang.Text = r.Cells["tenhh"].Value.ToString();
            cboNcc.SelectedValue = r.Cells["Ma_ncc"].Value.ToString();
            txtDVT.Text = r.Cells["soluong"].Value.ToString();
            txtDGN.Text = r.Cells["dongianhap"].Value.ToString();
            txtDGB.Text = r.Cells["dongiaban"].Value.ToString();
            txtGhiChu.Text = r.Cells["ghichu"].Value.ToString();
            txtAnh.Text = r.Cells["img"].Value.ToString();
            if (txtAnh.Text != "")
            {
                try{
                    picAnh.Image = Image.FromFile(txtAnh.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Đường dẫn ảnh đã thay đổi hãy sửa lại");
                }
            }
            else picAnh.Image = null;
        }

        private void brbtnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtTenHang.Text == "" || txtMaHang.Text == "" || txtDVT.Text == "" || txtDGN.Text == "" || txtDGB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BUS_QLBH.SanPham.TimTheoMa(txtMaHang.Text) == null)
                {
                    if (txtMaHang.Text.Length == 4)
                    {
                        DTO_QLBH.SanPham sp = new DTO_QLBH.SanPham
                        {
                            ma_hh = txtMaHang.Text,
                            tenhh = txtTenHang.Text,
                            ma_NCC = cboNcc.SelectedValue.ToString(),
                            soluong = Int32.Parse(txtDVT.Text),
                            dongianhap = float.Parse(txtDGN.Text),
                            dongiaban = float.Parse(txtDGB.Text),
                            ghichu = txtGhiChu.Text,
                            img = txtAnh.Text,
                        };
                        if (!BUS_QLBH.SanPham.ADD_SP(sp))
                        {
                            MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm sản phẩm");
                            BUS_QLBH.SanPham.getSP(dtvSp);
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm phải đủ 4 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void brbtnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaHang.Enabled = false;
            if (txtTenHang.Text == "" || txtMaHang.Text == "" || txtDVT.Text == "" || txtDGN.Text == "" || txtDGB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BUS_QLBH.SanPham.TimTheoMa(txtMaHang.Text) != null)
                {
                    if (txtMaHang.Text.Length == 4)
                    {
                        DTO_QLBH.SanPham sp = new DTO_QLBH.SanPham
                        {
                            ma_hh = txtMaHang.Text,
                            tenhh = txtTenHang.Text,
                            ma_NCC = cboNcc.SelectedValue.ToString(),
                            soluong = Int32.Parse(txtDVT.Text),
                            dongianhap = float.Parse(txtDGN.Text),
                            dongiaban = float.Parse(txtDGB.Text),
                            ghichu = txtGhiChu.Text,
                            img = txtAnh.Text,
                        };
                        if (!BUS_QLBH.SanPham.Edit_SP(sp))
                        {
                            MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa sản phẩm");
                            BUS_QLBH.SanPham.getSP(dtvSp);
                            reset();
                            txtMaHang.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm phải đủ 4 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm không được phép thay đổi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void brbtnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ma = dtvSp.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                if (!BUS_QLBH.SanPham.Xoa_SP(ma))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                {
                    BUS_QLBH.SanPham.getSP(dtvSp);
                    MessageBox.Show("Đã xóa sản phẩm thành công.");
                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa sản phẩm");
                }

            }
        }

        private void brbtnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaHang.Text != "")
            {
                //BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                List<DTO_QLBH.SanPham> lstsp = BUS_QLBH.SanPham.TimTheoMa(txtMaHang.Text);
                if (lstsp == null)
                {
                    MessageBox.Show("Không tìm khách hàng có mã: " + txtMaHang.Text + " !");
                    return;
                }
                dtvSp.DataSource = lstsp;
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm ô mã hàng");
        }

        private void brbtnRefsesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            reset();
            BUS_QLBH.NCC.getCboNCC(cboNcc);
            BUS_QLBH.SanPham.getSP(dtvSp);
        }
    }
}