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
    public partial class frmTimKiemSQL : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemSQL()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(txtTK.Text!="")
            {
                try
                {
                    List<DTO_QLBH.TTHDCTHD> lst2b = BUS_QLBH.TKSQL.Tim2Bang(txtTK.Text);
                    if (lst2b == null)
                    {
                        MessageBox.Show("Không tìm thấy!");
                        return;
                    }
                    else
                    {
                        dtvKetQua.DataSource = lst2b;
                        dtvKetQua.RowHeadersVisible = false;
                    }
                }
                catch(Exception)
                {
                    try
                    {
                        List<DTO_QLBH.HoaDon> lsthd = BUS_QLBH.TKSQL.TimBangHD(txtTK.Text);
                        if (lsthd == null)
                        {
                            MessageBox.Show("Không tìm thấy!");
                            return;
                        }
                        else
                        {
                            dtvKetQua.DataSource = lsthd;
                            dtvKetQua.RowHeadersVisible = false;
                        }
                    }
                    catch (Exception)
                    {
                        List<DTO_QLBH.ChitietHD> lstds = BUS_QLBH.TKSQL.TimBagCT(txtTK.Text);
                        if (lstds == null)
                        {
                            MessageBox.Show("Không tìm thấy!");
                            return;
                        }
                        else
                        {
                            dtvKetQua.DataSource = lstds;
                            dtvKetQua.RowHeadersVisible = false;
                        }
                    }
                    
                }    
            }
            else MessageBox.Show("Hãy nhập câu lênh sql!");
        }
    }
}