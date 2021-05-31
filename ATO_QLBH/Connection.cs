using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Media;
using System.IO;

namespace ATO_QLBH
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }
        
        private void ckbtnaccount_CheckedChanged(object sender, EventArgs e)
        {
            grpLogin.Enabled = ckbtnaccount.Checked;
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (test())
            {
                MessageBox.Show("Successful connection", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Connection failed", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["server"]);
                cbbDatabase.Text = DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["database"]);
                ckbtnaccount.Checked = Boolean.Parse(DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["checkuser"]));
                ckbusser.Checked = Boolean.Parse(DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["checkpassword"]));
                if (Boolean.Parse(DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["checkpassword"])) == true)
                {
                    txtPassword.Text = DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["password"]);
                    txtLogin.Text = DTO_QLBH.Encode.Decrypt(System.Configuration.ConfigurationManager.AppSettings["login"]);
                }
            }
            catch
            {
                txtServer.Text = "Server name!";
            }
            
        }
        bool loaddata()
        {
            try
            {
                string connectionString = "Data Source=" + 
                    txtServer.Text +"; Integrated Security="+
                    !ckbtnaccount.Checked+ "; User ID = "+txtLogin.Text+"; Password = "+
                    txtPassword.Text+ ";Connection Timeout=1";
            
                List<string> databasename = new List<string>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                databasename.Add(dr[0].ToString());
                            }
                        }
                    }
                    con.Close();
                }
                cbbDatabase.DataSource = databasename;           
                return true;
            }
            catch
            {
                cbbDatabase.DataSource = null;
                cbbDatabase.Text = "No database!";
                return false;
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            cbbDatabase.DataSource = null;
            cbbDatabase.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (loaddata() == false)
                MessageBox.Show("Cannot connect to Database check " + ((ckbtnaccount.Checked) ? "account, password and server." : "server name."),"Connect",MessageBoxButtons.OK,MessageBoxIcon.Error);     
            else SystemSounds.Beep.Play();
        }
        bool test()
        {
            try
            {
                string connectionString = "Data Source=" +
                txtServer.Text + ";Initial Catalog="+cbbDatabase.Text+"; Integrated Security=" +
                !ckbtnaccount.Checked + "; User ID = " + txtLogin.Text + "; Password = " +
                txtPassword.Text + "; Connection Timeout=1";
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();
                cn.Close();
                return true;
            }
            catch {
                return false;
            }
        }
        private void btnSaveConnect_Click(object sender, EventArgs e)
        {
            if (test())
            {
                MessageBox.Show("Save Successful connection", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Configuration.Configuration configuration =
                System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                configuration.AppSettings.Settings["server"].Value = DTO_QLBH.Encode.Encrypt(txtServer.Text);
                configuration.AppSettings.Settings["database"].Value = DTO_QLBH.Encode.Encrypt(cbbDatabase.Text);
                configuration.AppSettings.Settings["checkuser"].Value = DTO_QLBH.Encode.Encrypt(ckbtnaccount.Checked + "");
                configuration.AppSettings.Settings["checkpassword"].Value = DTO_QLBH.Encode.Encrypt(ckbusser.Checked + "");
                if (ckbusser.Checked)
                {
                    configuration.AppSettings.Settings["login"].Value = DTO_QLBH.Encode.Encrypt(txtLogin.Text);
                    configuration.AppSettings.Settings["password"].Value = DTO_QLBH.Encode.Encrypt(txtPassword.Text);
                }
                else
                {
                }
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
                configuration.Save(System.Configuration.ConfigurationSaveMode.Modified);
                string txt = "Data Source=" + txtServer.Text+
                ";Initial Catalog=" + cbbDatabase.Text+
                "; Integrated Security=" + !ckbtnaccount.Checked + "; " +
                ((ckbtnaccount.Checked == false) ? "" :
                "User ID = " + txtLogin.Text + "; Password = " +
                txtPassword.Text + ";");
                 File.WriteAllText("connectionString.txt", DTO_QLBH.Encode.Encrypt(txt));
                 this.Dispose();
            }
            else
                MessageBox.Show("Save Connection failed", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
        }

        private void ckbusser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
 