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
    public partial class frmPhanQuyen : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
            luu_ChiTiet = BUS_QLBH.nhanvien.chitiet(frmDangNhap_Main.USERNAME);
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            if (checkper("QL") == false)
            {
                //btnSua.Enabled = false;
                btnXoaQh.Enabled = false;
            }  
                
            BUS_QLBH.nhanvien.getPhanQuyen(dtPhanQuyen);
            BUS_QLBH.nhanvien.getUSER(cboUser);
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
        string tenquyen;
        private void dtPhanQuyen_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtPhanQuyen.SelectedRows[0];
            cboUser.SelectedValue = r.Cells["username"].Value;
            cboDP.Text = r.Cells["DP"].Value.ToString();
            cboQH.Text = r.Cells["ten_ct"].Value.ToString();
            txtQH.Text = r.Cells["id_qh"].Value.ToString();
          
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cboUser.SelectedValue.ToString() == "QuanLi")
            {
                if (frmDangNhap_Main.USERNAME == "QuanLi")
                {
                    DTO_QLBH.moilienhe pq1 = new DTO_QLBH.moilienhe
                    {
                        username = cboUser.SelectedValue.ToString(),
                        ID_QH = txtQH.Text,
                        DP = cboDP.Text,
                    };
                    if (!BUS_QLBH.PhanQuyen.SuaMLH(pq1))
                    {
                        MessageBox.Show("Sửa không thành công mối liên hệ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string ten = "";
                        if (cboQH.Text == "QuanLi")
                        {
                            ten = "QL";
                        }
                        else
                        {
                            if (cboQH.Text == "Nhân viên")
                            {
                                ten = "NV";
                            }
                            else
                            {
                                if (cboQH.Text == "Nhân viên bán hàng")
                                    ten = "NVBH";
                                else ten = "NVKH";
                            }

                        }
                        DTO_QLBH.quyenchitiet pq2 = new DTO_QLBH.quyenchitiet
                        {

                            TEN_CT = cboQH.Text,
                            MA = ten,
                            username = cboUser.SelectedValue.ToString(),

                        };
                        if (!BUS_QLBH.PhanQuyen.SuaQH(pq2))
                        {
                            MessageBox.Show("Sửa không thành công quyền?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền sửa UserName này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            else
            {
                DTO_QLBH.moilienhe pq = new DTO_QLBH.moilienhe
                {
                    username = cboUser.SelectedValue.ToString(),
                    ID_QH = txtQH.Text,
                    DP = cboDP.Text,
                };
                if (!BUS_QLBH.PhanQuyen.SuaMLH(pq))
                {
                    MessageBox.Show("Sửa không thành công mối liên hệ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa mối liên hệ quyền nhân viên");
                }
                else
                {
                    string ten = "";
                    if (cboQH.Text == "QuanLi")
                    {
                        ten = "QL";
                    }
                    else
                    {
                        if (cboQH.Text == "Nhân viên")
                        {
                            ten = "NV";
                        }
                        else
                        {
                            if (cboQH.Text == "Nhân viên bán hàng")
                                ten = "NVBH";
                            else ten = "NVKH";
                        }

                    }
                    DTO_QLBH.quyenchitiet pq2 = new DTO_QLBH.quyenchitiet
                    {

                        TEN_CT = cboQH.Text,
                        MA = ten,
                        username = cboUser.SelectedValue.ToString(),

                    };
                    if (!BUS_QLBH.PhanQuyen.SuaQH(pq2))
                    {
                        MessageBox.Show("Sửa không thành công quyền?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "sửa quyền nhân viên");
                    }
                }
            }

        }
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(txtQH.Text!="" && Edit.IsNumber(txtQH.Text))
            {
                if(cboDP.Text!="")
                {
                    if(cboQH.Text!="")
                    {
                        DTO_QLBH.moilienhe pq = new DTO_QLBH.moilienhe
                        {
                            username = cboUser.SelectedValue.ToString(),
                            ID_QH = txtQH.Text,
                            DP = cboDP.Text,
                        };
                        if (!BUS_QLBH.PhanQuyen.Add_MoiLienHe(pq))
                        {
                            MessageBox.Show("User đã tồn tại phân quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string ten = "";
                            if (cboQH.Text == "QuanLi")
                            {
                                ten = "QL";
                            }
                            else
                            {
                                if (cboQH.Text == "Nhân viên")
                                {
                                    ten = "NV";
                                }
                                else
                                {
                                    if (cboQH.Text == "Nhân viên bán hàng")
                                        ten = "NVBH";
                                    else ten = "NVKH";
                                }

                            }
                            DTO_QLBH.quyenchitiet pq2 = new DTO_QLBH.quyenchitiet
                            {
                                TEN_CT = cboQH.Text,
                                MA = ten,
                                username = cboUser.SelectedValue.ToString(),

                            };
                            if (!BUS_QLBH.PhanQuyen.ADD_QuyenChiTiet(pq2))
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
                                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "thêm quyền cho nhân viên");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên quyền hạn không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Được phép không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ID quyền hạn không được để trống và phải là số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            BUS_QLBH.nhanvien.getPhanQuyen(dtPhanQuyen);
            BUS_QLBH.nhanvien.getUSER(cboUser);
            txtQH.ResetText();
            cboDP.ResetText();
            cboQH.ResetText();
        }

        private void btnXoaQh_ItemClick(object sender, ItemClickEventArgs e)
        {
            string user = cboUser.SelectedValue.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa  quyền nhân viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                if (BUS_QLBH.nhanvien.TimTheoUser(user) == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên muốn xóa!");
                    return;
                }
                if (!BUS_QLBH.PhanQuyen.XoaMLH(user))
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                else
                {
                    BUS_QLBH.PhanQuyen.XoaQH(user);
                }    
                BUS_QLBH.nhanvien.getPhanQuyen(dtPhanQuyen);
                MessageBox.Show("Đã xóa quyền nhân viên thành công.");
                BUS_QLBH.WriteLog.Write(frmDangNhap_Main.USERNAME, tenquyen, "xóa quyền nhân viên");
            }
        }
    }
}