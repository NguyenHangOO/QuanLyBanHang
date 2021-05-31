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
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao()
        {
            InitializeComponent();
            cboDThu.Items.Add("<Tất cả>");
            cboDThu.SelectedIndex = 0;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            cboDThu.SelectedIndex = 0;
            if (rdoHangNgay.Checked==true)
            {
                dtTu.Enabled = false;
                dtDen.Enabled = false;
                dtTu.Text = DateTime.Now.ToShortDateString();
                dtDen.Text = DateTime.Now.ToShortDateString();
            } 
            else if(rdoHangTuan.Checked==true)
            {
                dtTu.Enabled = false;
                dtDen.Enabled = false;
                if (DateTime.Now.DayOfWeek.ToString()=="Sunday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-6).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.ToShortDateString();
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Monday")
                {
                    dtTu.Text = DateTime.Now.ToShortDateString();
                    dtDen.Text = DateTime.Now.AddDays(+6).ToString("MM/dd/yyyy");
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.AddDays(5).ToString("MM/dd/yyyy");
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.AddDays(4).ToString("MM/dd/yyyy");
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Thursday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Friday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                }
                if (DateTime.Now.DayOfWeek.ToString() == "Saturday")
                {
                    dtTu.Text = DateTime.Now.AddDays(-5).ToString("MM/dd/yyyy");
                    dtDen.Text = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                }
            }
            else if(rdoHangThang.Checked==true)
            {
                dtTu.Enabled = false;
                dtDen.Enabled = false;
                string thang = DateTime.Now.Month.ToString();
                string nam = DateTime.Now.Year.ToString();
                if(DateTime.Now.Month.ToString()=="2")
                {
                    dtTu.Text = thang + "/1/" + nam;
                    dtDen.Text = thang + "/28/" + nam;
                }    
                else if(thang=="1" || thang == "3" || thang == "5" || thang == "7" || thang == "8" || thang == "10" || thang == "12")
                {
                    dtTu.Text = thang + "/1/" + nam;
                    dtDen.Text = thang + "/31/" + nam;
                }
                else
                {
                    dtTu.Text = thang + "/1/" + nam;
                    dtDen.Text = thang + "/30/" + nam;
                } 
                    
            } 
            else if(rdoKhoang.Checked==true)
            {
                dtTu.Enabled = true;
                dtDen.Enabled = true;
                dtTu.Text = DateTime.Now.ToShortDateString();
                dtDen.Text = DateTime.Now.ToShortDateString();
            }    
        }

        private void cboDThu_Click(object sender, EventArgs e)
        {
            BUS_QLBH.nhanvien.getUSER(cboDThu);
        }
        private void btnThu_Click(object sender, EventArgs e)
        {
            if(cboDThu.Text== "<Tất cả>")
            {
                string loai = "or";
                frmBaoCaoDT bchd = new frmBaoCaoDT(dtTu.Text,dtDen.Text,loai,cboDThu.Text);
                bchd.ShowDialog();
            } 
            else
            {
                string loai = "and";
                frmBaoCaoDT bchd = new frmBaoCaoDT(dtTu.Text, dtDen.Text, loai, cboDThu.Text);
                bchd.ShowDialog();
            }    
        }

        private void btnChi_Click(object sender, EventArgs e)
        {
            if (cboDThu.Text == "<Tất cả>")
            {
                string loai = "or";
                frmChi bchd = new frmChi(dtTu.Text, dtDen.Text, loai, cboDThu.Text);
                bchd.ShowDialog();
            }
            else
            {
                string loai = "and";
                frmChi bchd = new frmChi(dtTu.Text, dtDen.Text, loai, cboDThu.Text);
                bchd.ShowDialog();
            }
        }
    }
}