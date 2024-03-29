﻿namespace ATO_QLBH
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveConnect = new System.Windows.Forms.Button();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpLogin = new DevExpress.XtraEditors.GroupControl();
            this.ckbusser = new System.Windows.Forms.CheckBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.ckbtnaccount = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLogin)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONECTION TO DATABASE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveConnect
            // 
            this.btnSaveConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveConnect.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSaveConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConnect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveConnect.Location = new System.Drawing.Point(22, 482);
            this.btnSaveConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveConnect.Name = "btnSaveConnect";
            this.btnSaveConnect.Size = new System.Drawing.Size(490, 41);
            this.btnSaveConnect.TabIndex = 13;
            this.btnSaveConnect.Text = "SAVE CONNECTION";
            this.btnSaveConnect.UseVisualStyleBackColor = false;
            this.btnSaveConnect.Click += new System.EventHandler(this.btnSaveConnect_Click);
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTestConnect.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTestConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTestConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestConnect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnect.Location = new System.Drawing.Point(22, 424);
            this.btnTestConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(490, 44);
            this.btnTestConnect.TabIndex = 12;
            this.btnTestConnect.Text = "TEST CONNECTION";
            this.btnTestConnect.UseVisualStyleBackColor = false;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grpLogin);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.cbbDatabase);
            this.panel1.Controls.Add(this.ckbtnaccount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Location = new System.Drawing.Point(24, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 316);
            this.panel1.TabIndex = 11;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.ckbusser);
            this.grpLogin.Controls.Add(this.txtLogin);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Enabled = false;
            this.grpLogin.Location = new System.Drawing.Point(14, 156);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(458, 143);
            this.grpLogin.TabIndex = 14;
            this.grpLogin.Text = "Login";
            // 
            // ckbusser
            // 
            this.ckbusser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbusser.AutoSize = true;
            this.ckbusser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbusser.Location = new System.Drawing.Point(314, 111);
            this.ckbusser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbusser.Name = "ckbusser";
            this.ckbusser.Size = new System.Drawing.Size(120, 28);
            this.ckbusser.TabIndex = 13;
            this.ckbusser.Text = "Save login";
            this.ckbusser.UseVisualStyleBackColor = true;
            this.ckbusser.CheckedChanged += new System.EventHandler(this.ckbusser_CheckedChanged);
            this.ckbusser.Click += new System.EventHandler(this.ckbusser_CheckedChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(160, 40);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(278, 30);
            this.txtLogin.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(160, 77);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(278, 30);
            this.txtPassword.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(31, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Login name:";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Green;
            this.btnLoad.Location = new System.Drawing.Point(396, 58);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 38);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(171, 59);
            this.cbbDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(219, 33);
            this.cbbDatabase.TabIndex = 1;
            // 
            // ckbtnaccount
            // 
            this.ckbtnaccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbtnaccount.AutoSize = true;
            this.ckbtnaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbtnaccount.Location = new System.Drawing.Point(171, 107);
            this.ckbtnaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbtnaccount.Name = "ckbtnaccount";
            this.ckbtnaccount.Size = new System.Drawing.Size(152, 28);
            this.ckbtnaccount.TabIndex = 3;
            this.ckbtnaccount.Text = "Using account";
            this.ckbtnaccount.UseVisualStyleBackColor = true;
            this.ckbtnaccount.CheckedChanged += new System.EventHandler(this.ckbtnaccount_CheckedChanged);
            this.ckbtnaccount.Click += new System.EventHandler(this.ckbtnaccount_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server name:";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(171, 13);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(301, 30);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = ".\\SQLEXPRESS";
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 568);
            this.Controls.Add(this.btnSaveConnect);
            this.Controls.Add(this.btnTestConnect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(545, 614);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect DataBase";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpLogin)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveConnect;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl grpLogin;
        private System.Windows.Forms.CheckBox ckbusser;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.CheckBox ckbtnaccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
    }
}

