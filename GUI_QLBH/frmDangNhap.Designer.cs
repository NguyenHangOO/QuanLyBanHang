
namespace GUI_QLBH
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnConnect = new DevExpress.XtraBars.BarButtonItem();
            this.btnDN = new DevExpress.XtraEditors.SimpleButton();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lnkDK = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chkHien = new DevExpress.XtraEditors.CheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.prcUser = new DevExpress.XtraEditors.PictureEdit();
            this.prcPass = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcAn = new System.Windows.Forms.PictureBox();
            this.prcLogin = new DevExpress.XtraEditors.PictureEdit();
            this.pcHien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHien)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(407, 31);
            this.toolbarFormControl1.TabIndex = 80;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.btnConnect);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnConnect});
            this.toolbarFormManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(407, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 574);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(407, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 543);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(407, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 543);
            // 
            // btnConnect
            // 
            this.btnConnect.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnConnect.Caption = "Connect";
            this.btnConnect.Id = 1;
            this.btnConnect.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConnect.ImageOptions.SvgImage")));
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnect_ItemClick);
            // 
            // btnDN
            // 
            this.btnDN.Appearance.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.Appearance.Options.UseFont = true;
            this.btnDN.Appearance.Options.UseForeColor = true;
            this.btnDN.Location = new System.Drawing.Point(36, 165);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(312, 40);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "SIGN IN";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(64, 20);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MenuManager = this.toolbarFormManager1;
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseBackColor = true;
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(284, 26);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(64, 76);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.MenuManager = this.toolbarFormManager1;
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Size = new System.Drawing.Size(284, 26);
            this.txtPass.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 504);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 19);
            this.labelControl1.TabIndex = 102;
            this.labelControl1.Text = "Don\'t have an acount?";
            // 
            // lnkDK
            // 
            this.lnkDK.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDK.Appearance.Options.UseFont = true;
            this.lnkDK.Location = new System.Drawing.Point(284, 504);
            this.lnkDK.Margin = new System.Windows.Forms.Padding(4);
            this.lnkDK.Name = "lnkDK";
            this.lnkDK.Size = new System.Drawing.Size(59, 19);
            this.lnkDK.TabIndex = 4;
            this.lnkDK.Text = "Sign up";
            this.lnkDK.Click += new System.EventHandler(this.lnkDK_Click);
            // 
            // chkHien
            // 
            this.chkHien.Location = new System.Drawing.Point(66, 124);
            this.chkHien.Margin = new System.Windows.Forms.Padding(4);
            this.chkHien.MenuManager = this.toolbarFormManager1;
            this.chkHien.Name = "chkHien";
            this.chkHien.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHien.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkHien.Properties.Appearance.Options.UseFont = true;
            this.chkHien.Properties.Appearance.Options.UseForeColor = true;
            this.chkHien.Properties.Caption = "";
            this.chkHien.Size = new System.Drawing.Size(22, 20);
            this.chkHien.TabIndex = 2;
            this.chkHien.CheckedChanged += new System.EventHandler(this.chkHien_CheckedChanged);
            // 
            // prcUser
            // 
            this.prcUser.EditValue = ((object)(resources.GetObject("prcUser.EditValue")));
            this.prcUser.Location = new System.Drawing.Point(18, 21);
            this.prcUser.Margin = new System.Windows.Forms.Padding(4);
            this.prcUser.MenuManager = this.toolbarFormManager1;
            this.prcUser.Name = "prcUser";
            this.prcUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.prcUser.Properties.Appearance.Options.UseBackColor = true;
            this.prcUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.prcUser.Properties.ZoomPercent = 76D;
            this.prcUser.Size = new System.Drawing.Size(39, 34);
            this.prcUser.TabIndex = 110;
            // 
            // prcPass
            // 
            this.prcPass.EditValue = ((object)(resources.GetObject("prcPass.EditValue")));
            this.prcPass.Location = new System.Drawing.Point(18, 78);
            this.prcPass.Margin = new System.Windows.Forms.Padding(4);
            this.prcPass.Name = "prcPass";
            this.prcPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.prcPass.Properties.Appearance.Options.UseBackColor = true;
            this.prcPass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.prcPass.Properties.ZoomPercent = 76D;
            this.prcPass.Size = new System.Drawing.Size(39, 34);
            this.prcPass.TabIndex = 110;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pcHien);
            this.panelControl1.Controls.Add(this.pcAn);
            this.panelControl1.Controls.Add(this.prcPass);
            this.panelControl1.Controls.Add(this.prcUser);
            this.panelControl1.Controls.Add(this.chkHien);
            this.panelControl1.Controls.Add(this.txtPass);
            this.panelControl1.Controls.Add(this.txtUser);
            this.panelControl1.Controls.Add(this.btnDN);
            this.panelControl1.Location = new System.Drawing.Point(19, 268);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(366, 219);
            this.panelControl1.TabIndex = 115;
            // 
            // pcAn
            // 
            this.pcAn.Image = ((System.Drawing.Image)(resources.GetObject("pcAn.Image")));
            this.pcAn.Location = new System.Drawing.Point(86, 123);
            this.pcAn.Name = "pcAn";
            this.pcAn.Size = new System.Drawing.Size(34, 23);
            this.pcAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAn.TabIndex = 111;
            this.pcAn.TabStop = false;
            // 
            // prcLogin
            // 
            this.prcLogin.EditValue = ((object)(resources.GetObject("prcLogin.EditValue")));
            this.prcLogin.Location = new System.Drawing.Point(125, 88);
            this.prcLogin.Margin = new System.Windows.Forms.Padding(4);
            this.prcLogin.MenuManager = this.toolbarFormManager1;
            this.prcLogin.Name = "prcLogin";
            this.prcLogin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.prcLogin.Properties.Appearance.Options.UseBackColor = true;
            this.prcLogin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.prcLogin.Properties.ZoomPercent = 60D;
            this.prcLogin.Size = new System.Drawing.Size(145, 131);
            this.prcLogin.TabIndex = 120;
            // 
            // pcHien
            // 
            this.pcHien.Image = ((System.Drawing.Image)(resources.GetObject("pcHien.Image")));
            this.pcHien.Location = new System.Drawing.Point(86, 123);
            this.pcHien.Name = "pcHien";
            this.pcHien.Size = new System.Drawing.Size(34, 23);
            this.pcHien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHien.TabIndex = 111;
            this.pcHien.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDN;
            this.Appearance.BackColor = System.Drawing.Color.Snow;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 574);
            this.Controls.Add(this.prcLogin);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lnkDK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmDangNhap.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDangNhap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnConnect;
        private DevExpress.XtraEditors.SimpleButton btnDN;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkDK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkHien;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit prcPass;
        private DevExpress.XtraEditors.PictureEdit prcUser;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit prcLogin;
        private System.Windows.Forms.PictureBox pcAn;
        private System.Windows.Forms.PictureBox pcHien;
    }
}