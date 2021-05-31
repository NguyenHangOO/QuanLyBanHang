using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class ReadLog : Form
    {
        public ReadLog()
        {
            InitializeComponent();
            cbbfile.DataSource = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Log").ToList<string>().Select(c => c.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\Log\\", "")).ToList();
        }

        private void cbbfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLog.DataSource = BUS_QLBH.WriteLog.Read(cbbfile.Text);
            dgvLog.RowHeadersVisible = false;
        }
    }
}
