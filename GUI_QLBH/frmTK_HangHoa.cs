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
    public partial class frmTK_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmTK_HangHoa()
        {
            InitializeComponent();
        }

        private void frmTK_HangHoa_Load(object sender, EventArgs e)
        {
            cboLoaiNCC.SelectedIndex = 0;
            cboChonSLg.SelectedIndex = 0;
        }

        private void cboLoaiNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNCC.SelectedIndex == 0)
                txtNCC.Enabled = false;
            else
                txtNCC.Enabled = true;
        }

        private void cboChonSLg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChonSLg.SelectedIndex==0)
            {
                cboSoSanhSlg.SelectedIndex = 0;
                cboSoSanhSlg.Enabled = false;
                txtSlgTu.Enabled = false;
            } 
            else 
            {
                cboSoSanhSlg.Enabled = true;
                txtSlgTu.Enabled = true;
            }    
        }

        private void cboSoSanhSlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSoSanhSlg.SelectedItem.ToString().Equals("between"))
                txtSlgDen.Enabled = true;
            else
                txtSlgDen.Enabled = false;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            List<DTO_QLBH.SanPham> lstsp = BUS_QLBH.TTNangCaoHangHoa.TimKiemNangCao(txtTenHH.Text,cboLoaiNCC.SelectedItem.ToString(),
                txtNCC.Text,cboChonSLg.SelectedItem.ToString(),cboSoSanhSlg.SelectedItem.ToString(),txtSlgTu.Text,txtSlgDen.Text);
            if (lstsp == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dtvDSTK.DataSource = lstsp;
            dtvDSTK.Columns[0].HeaderText = "Mã";
            dtvDSTK.Columns[1].HeaderText = "Tên hàng";
            dtvDSTK.Columns[2].HeaderText = "Mã NCC";
            dtvDSTK.Columns[3].Visible = false;
            dtvDSTK.Columns[4].HeaderText = "Số lượng";
            dtvDSTK.Columns[5].HeaderText = "Đơn giá nhập";
            dtvDSTK.Columns[6].HeaderText = "Đơn giá bán";
            dtvDSTK.Columns[7].HeaderText = "Ghi chú";
            dtvDSTK.Columns[8].HeaderText = "Ảnh";

            BindingSource bs = new BindingSource();
            bs.DataSource = lstsp;
            //gán du lieu len control kq
            bnKQ.BindingSource = bs;
            //dtvDSTK.DataSource = bs;
        }
    }
}