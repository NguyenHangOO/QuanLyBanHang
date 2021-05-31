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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BUS_QLBH.NCC.getNCC(dtvNCC);
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
        }
        string tenquyen;
        private void dtvNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtvNCC.SelectedRows[0];
            txtma.Text = r.Cells["Ma_ncc"].Value.ToString();
            txtTen.Text = r.Cells["tenncc"].Value.ToString();
            txtSDT.Text = r.Cells["SDT"].Value.ToString();
            txtDC.Text = r.Cells["DiaChi"].Value.ToString();
            txtSoThe.Text = r.Cells["SoThe"].Value.ToString();

        }

        private void resest()
        {
            txtma.ResetText();
            txtTen.ResetText();
            txtSDT.ResetText();
            txtDC.ResetText();
            txtSoThe.ResetText();
        }

        private void brbtnTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtma.Text != "")
            {
                //BUS_QLBH.nhanvien.TimTheoUser(txtTK.Text);
                List<DTO_QLBH.NCC> lstkh = BUS_QLBH.NCC.TimTheoMa(txtma.Text);
                if (lstkh == null)
                {
                    MessageBox.Show("Không tìm nhà cung cấp có mã: " + txtma.Text + " !");
                    return;
                }
                dtvNCC.DataSource = lstkh;
                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "tìm nhà cung cấp");
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");
        }

        private void brbtnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtma.Text == "" || txtTen.Text == "" || txtDC.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (((txtSoThe.Text.Length == 10 || txtSoThe.Text.Length == 13) && Edit.IsNumber(txtSoThe.Text)) || txtSoThe.Text == "")
                {
                    if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10 || Edit.IsNumber(txtSDT.Text) == false)
                    {
                        MessageBox.Show("Số điện thoại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (BUS_QLBH.NCC.TimTheoMa(txtma.Text) == null)
                        {
                            if (txtma.Text.Length == 4)
                            {
                                DTO_QLBH.NCC ncc = new DTO_QLBH.NCC
                                {
                                    ma_NCC = txtma.Text,
                                    tenncc = txtTen.Text,
                                    sdt = txtSDT.Text,
                                    diachi = txtDC.Text,
                                    sothe = txtSoThe.Text,
                                };
                                if (!BUS_QLBH.NCC.ADD_NCC(ncc))
                                {
                                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm nhà cung cấp");
                                    BUS_QLBH.NCC.getNCC(dtvNCC);
                                    resest();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mã nhà cung cấp phải đủ 4 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã nhà cung cấp đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số thẻ ngân hàng không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void brbtnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtma.Enabled = false;
            if (txtTen.Text == "" || txtDC.Text == "" || txtSDT.Text == "")
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
                    if (((txtSoThe.Text.Length == 10 || txtSoThe.Text.Length == 13) && Edit.IsNumber(txtSoThe.Text)) || txtSoThe.Text == "")
                    {
                        if (BUS_QLBH.NCC.TimTheoMa(txtma.Text) != null)
                        {
                            if (txtma.Text.Length == 4)
                            {
                                DTO_QLBH.NCC ncc = new DTO_QLBH.NCC
                                {
                                    ma_NCC = txtma.Text,
                                    tenncc = txtTen.Text,
                                    sdt = txtSDT.Text,
                                    diachi = txtDC.Text,
                                    sothe = txtSoThe.Text,
                                };
                                if (!BUS_QLBH.NCC.Edit_NCC(ncc))
                                {
                                    MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa nhà cung cấp");
                                    txtma.Enabled = true;
                                    resest();
                                    BUS_QLBH.NCC.getNCC(dtvNCC);
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
                    else
                    {
                        MessageBox.Show("Số thẻ ngân hàng không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void brbtnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ma = dtvNCC.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                if (!BUS_QLBH.NCC.Xoa_NCC(ma))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                {
                    BUS_QLBH.NCC.getNCC(dtvNCC);
                    MessageBox.Show("Đã xóa nhà cung cấp thành công.");
                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa nhà cung cấp");
                }

            }
        }

        private void brbtnRefsesh_ItemClick(object sender, ItemClickEventArgs e)
        {
            resest();
        }

        private void brbtnEx_ItemClick(object sender, ItemClickEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dtvNCC.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtvNCC.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtvNCC.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtvNCC.Columns.Count; j++)
                {
                    if (dtvNCC.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtvNCC.Rows[i].Cells[j].Value.ToString();
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