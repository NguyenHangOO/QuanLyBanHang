
namespace GUI_QLBH
{
    partial class frmDangNhap_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap_Main));
            this.prcLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkDK = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDN = new System.Windows.Forms.Button();
            this.chkHien = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prcLogin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // prcLogin
            // 
            this.prcLogin.Image = ((System.Drawing.Image)(resources.GetObject("prcLogin.Image")));
            this.prcLogin.Location = new System.Drawing.Point(152, 74);
            this.prcLogin.Name = "prcLogin";
            this.prcLogin.Size = new System.Drawing.Size(153, 135);
            this.prcLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prcLogin.TabIndex = 0;
            this.prcLogin.TabStop = false;
            this.prcLogin.Click += new System.EventHandler(this.prcLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Don\'t have an acount?";
            // 
            // lnkDK
            // 
            this.lnkDK.AutoSize = true;
            this.lnkDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDK.Location = new System.Drawing.Point(322, 518);
            this.lnkDK.Name = "lnkDK";
            this.lnkDK.Size = new System.Drawing.Size(79, 25);
            this.lnkDK.TabIndex = 4;
            this.lnkDK.TabStop = true;
            this.lnkDK.Text = "Sing up";
            this.lnkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDK_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDN);
            this.panel1.Controls.Add(this.chkHien);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(12, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 196);
            this.panel1.TabIndex = 4;
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDN.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.Blue;
            this.btnDN.Location = new System.Drawing.Point(21, 137);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(384, 44);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "SING IN";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // chkHien
            // 
            this.chkHien.AutoSize = true;
            this.chkHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHien.Location = new System.Drawing.Point(61, 95);
            this.chkHien.Name = "chkHien";
            this.chkHien.Size = new System.Drawing.Size(72, 24);
            this.chkHien.TabIndex = 2;
            this.chkHien.Text = "Show";
            this.chkHien.UseVisualStyleBackColor = true;
            this.chkHien.CheckedChanged += new System.EventHandler(this.chkHien_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(61, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(344, 27);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(61, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(344, 27);
            this.txtUser.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // frmDangNhap_Main
            // 
            this.AcceptButton = this.btnDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prcLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDangNhap_Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.prcLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prcLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkDK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.CheckBox chkHien;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}