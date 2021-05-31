
namespace GUI_QLBH
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.brbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnRefsesh = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnTK = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grpDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.dtvNCC = new System.Windows.Forms.DataGridView();
            this.grpTTNCC = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoThe = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.brbtnEx = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDSNCC)).BeginInit();
            this.grpDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTNCC)).BeginInit();
            this.grpTTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.brbtnThem,
            this.brbtnSua,
            this.brbtnXoa,
            this.brbtnRefsesh,
            this.brbtnTK,
            this.brbtnEx});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnRefsesh),
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnTK),
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnEx)});
            this.bar1.Text = "Tools";
            // 
            // brbtnThem
            // 
            this.brbtnThem.Caption = "ADD";
            this.brbtnThem.Id = 0;
            this.brbtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnThem.ImageOptions.SvgImage")));
            this.brbtnThem.Name = "brbtnThem";
            this.brbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnThem_ItemClick);
            // 
            // brbtnSua
            // 
            this.brbtnSua.Caption = "Edit";
            this.brbtnSua.Id = 1;
            this.brbtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnSua.ImageOptions.SvgImage")));
            this.brbtnSua.Name = "brbtnSua";
            this.brbtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnSua_ItemClick);
            // 
            // brbtnXoa
            // 
            this.brbtnXoa.Caption = "Delete";
            this.brbtnXoa.Id = 2;
            this.brbtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnXoa.ImageOptions.SvgImage")));
            this.brbtnXoa.Name = "brbtnXoa";
            this.brbtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnXoa_ItemClick);
            // 
            // brbtnRefsesh
            // 
            this.brbtnRefsesh.Caption = "Refsesh";
            this.brbtnRefsesh.Id = 3;
            this.brbtnRefsesh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnRefsesh.ImageOptions.SvgImage")));
            this.brbtnRefsesh.Name = "brbtnRefsesh";
            this.brbtnRefsesh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnRefsesh_ItemClick);
            // 
            // brbtnTK
            // 
            this.brbtnTK.Caption = "Search";
            this.brbtnTK.Hint = "Tìm kiếm theo mã nhà cung cấp";
            this.brbtnTK.Id = 4;
            this.brbtnTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnTK.ImageOptions.SvgImage")));
            this.brbtnTK.Name = "brbtnTK";
            this.brbtnTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnTK_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(946, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(946, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(946, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // grpDSNCC
            // 
            this.grpDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDSNCC.Controls.Add(this.dtvNCC);
            this.grpDSNCC.Location = new System.Drawing.Point(7, 216);
            this.grpDSNCC.Name = "grpDSNCC";
            this.grpDSNCC.Size = new System.Drawing.Size(921, 219);
            this.grpDSNCC.TabIndex = 10;
            this.grpDSNCC.Text = "Danh dách nhà cung cấp";
            // 
            // dtvNCC
            // 
            this.dtvNCC.AllowUserToAddRows = false;
            this.dtvNCC.AllowUserToDeleteRows = false;
            this.dtvNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNCC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNCC.Location = new System.Drawing.Point(5, 31);
            this.dtvNCC.Name = "dtvNCC";
            this.dtvNCC.ReadOnly = true;
            this.dtvNCC.RowHeadersWidth = 51;
            this.dtvNCC.RowTemplate.Height = 24;
            this.dtvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvNCC.Size = new System.Drawing.Size(909, 183);
            this.dtvNCC.TabIndex = 1;
            this.dtvNCC.Click += new System.EventHandler(this.dtvNCC_Click);
            // 
            // grpTTNCC
            // 
            this.grpTTNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTNCC.Controls.Add(this.label5);
            this.grpTTNCC.Controls.Add(this.label4);
            this.grpTTNCC.Controls.Add(this.label2);
            this.grpTTNCC.Controls.Add(this.label3);
            this.grpTTNCC.Controls.Add(this.label1);
            this.grpTTNCC.Controls.Add(this.txtSoThe);
            this.grpTTNCC.Controls.Add(this.txtTen);
            this.grpTTNCC.Controls.Add(this.txtSDT);
            this.grpTTNCC.Controls.Add(this.txtDC);
            this.grpTTNCC.Controls.Add(this.txtma);
            this.grpTTNCC.Location = new System.Drawing.Point(7, 30);
            this.grpTTNCC.Name = "grpTTNCC";
            this.grpTTNCC.Size = new System.Drawing.Size(920, 180);
            this.grpTTNCC.TabIndex = 11;
            this.grpTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(103, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số thẻ ngân hàng (nếu có):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(591, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(535, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số điện thoại:";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoThe.Location = new System.Drawing.Point(364, 140);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThe.Properties.Appearance.Options.UseFont = true;
            this.txtSoThe.Size = new System.Drawing.Size(429, 30);
            this.txtSoThe.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(192, 94);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(219, 30);
            this.txtTen.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(675, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(235, 30);
            this.txtSDT.TabIndex = 12;
            // 
            // txtDC
            // 
            this.txtDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDC.Location = new System.Drawing.Point(675, 94);
            this.txtDC.Name = "txtDC";
            this.txtDC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Properties.Appearance.Options.UseFont = true;
            this.txtDC.Size = new System.Drawing.Size(235, 30);
            this.txtDC.TabIndex = 13;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(192, 40);
            this.txtma.MenuManager = this.barManager1;
            this.txtma.Name = "txtma";
            this.txtma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Properties.Appearance.Options.UseFont = true;
            this.txtma.Size = new System.Drawing.Size(219, 30);
            this.txtma.TabIndex = 4;
            // 
            // brbtnEx
            // 
            this.brbtnEx.Caption = "Excel";
            this.brbtnEx.Id = 5;
            this.brbtnEx.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.brbtnEx.Name = "brbtnEx";
            this.brbtnEx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnEx_ItemClick);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.grpTTNCC);
            this.Controls.Add(this.grpDSNCC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNhaCungCap.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDSNCC)).EndInit();
            this.grpDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTNCC)).EndInit();
            this.grpTTNCC.ResumeLayout(false);
            this.grpTTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem brbtnThem;
        private DevExpress.XtraBars.BarButtonItem brbtnSua;
        private DevExpress.XtraBars.BarButtonItem brbtnXoa;
        private DevExpress.XtraBars.BarButtonItem brbtnRefsesh;
        private DevExpress.XtraBars.BarButtonItem brbtnTK;
        private DevExpress.XtraEditors.GroupControl grpTTNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSoThe;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.GroupControl grpDSNCC;
        private System.Windows.Forms.DataGridView dtvNCC;
        private DevExpress.XtraBars.BarButtonItem brbtnEx;
    }
}