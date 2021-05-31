
namespace GUI_QLBH
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.brbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnRefsesh = new DevExpress.XtraBars.BarButtonItem();
            this.brbtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDGN = new DevExpress.XtraEditors.TextEdit();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.txtDGB = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnh = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.grpTTSP = new DevExpress.XtraEditors.GroupControl();
            this.cboNcc = new System.Windows.Forms.ComboBox();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.dtvSp = new System.Windows.Forms.DataGridView();
            this.grpDSSP = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTSP)).BeginInit();
            this.grpTTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDSSP)).BeginInit();
            this.grpDSSP.SuspendLayout();
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
            this.brbtnSearch});
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.brbtnSearch)});
            this.bar1.Text = "Tools";
            // 
            // brbtnThem
            // 
            this.brbtnThem.Caption = "Add";
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
            // brbtnSearch
            // 
            this.brbtnSearch.Caption = "Search";
            this.brbtnSearch.Id = 4;
            this.brbtnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brbtnSearch.ImageOptions.SvgImage")));
            this.brbtnSearch.Name = "brbtnSearch";
            this.brbtnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brbtnSearch_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1076, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1076, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1076, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(40, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mã hàng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(3, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 21);
            this.label15.TabIndex = 41;
            this.label15.Text = "Nhà cung cấp:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(346, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "Đơn giá nhập:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(34, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 21);
            this.label14.TabIndex = 43;
            this.label14.Text = "Tên hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(23, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "Số lượng:";
            // 
            // txtDGN
            // 
            this.txtDGN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDGN.Location = new System.Drawing.Point(466, 46);
            this.txtDGN.Name = "txtDGN";
            this.txtDGN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGN.Properties.Appearance.Options.UseFont = true;
            this.txtDGN.Size = new System.Drawing.Size(210, 28);
            this.txtDGN.TabIndex = 4;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(125, 203);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Properties.Appearance.Options.UseFont = true;
            this.txtDVT.Size = new System.Drawing.Size(191, 28);
            this.txtDVT.TabIndex = 3;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(125, 96);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Properties.Appearance.Options.UseFont = true;
            this.txtTenHang.Size = new System.Drawing.Size(191, 28);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtDGB
            // 
            this.txtDGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDGB.Location = new System.Drawing.Point(466, 96);
            this.txtDGB.Name = "txtDGB";
            this.txtDGB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGB.Properties.Appearance.Options.UseFont = true;
            this.txtDGB.Size = new System.Drawing.Size(210, 28);
            this.txtDGB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(346, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Đơn giá bán:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(380, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ghi chú:";
            // 
            // txtAnh
            // 
            this.txtAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnh.Enabled = false;
            this.txtAnh.Location = new System.Drawing.Point(762, 203);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.Properties.Appearance.Options.UseFont = true;
            this.txtAnh.Size = new System.Drawing.Size(189, 28);
            this.txtAnh.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(711, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ảnh:";
            // 
            // btnload
            // 
            this.btnload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnload.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.Color.Blue;
            this.btnload.Location = new System.Drawing.Point(957, 202);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(82, 31);
            this.btnload.TabIndex = 7;
            this.btnload.Text = "Open";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhiChu.Location = new System.Drawing.Point(466, 153);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(210, 78);
            this.txtGhiChu.TabIndex = 48;
            // 
            // picAnh
            // 
            this.picAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnh.Location = new System.Drawing.Point(715, 41);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(323, 147);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 49;
            this.picAnh.TabStop = false;
            // 
            // grpTTSP
            // 
            this.grpTTSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTSP.Controls.Add(this.cboNcc);
            this.grpTTSP.Controls.Add(this.picAnh);
            this.grpTTSP.Controls.Add(this.txtGhiChu);
            this.grpTTSP.Controls.Add(this.btnload);
            this.grpTTSP.Controls.Add(this.label10);
            this.grpTTSP.Controls.Add(this.label15);
            this.grpTTSP.Controls.Add(this.label3);
            this.grpTTSP.Controls.Add(this.label2);
            this.grpTTSP.Controls.Add(this.label1);
            this.grpTTSP.Controls.Add(this.label18);
            this.grpTTSP.Controls.Add(this.label14);
            this.grpTTSP.Controls.Add(this.label12);
            this.grpTTSP.Controls.Add(this.txtAnh);
            this.grpTTSP.Controls.Add(this.txtDGB);
            this.grpTTSP.Controls.Add(this.txtDGN);
            this.grpTTSP.Controls.Add(this.txtDVT);
            this.grpTTSP.Controls.Add(this.txtMaHang);
            this.grpTTSP.Controls.Add(this.txtTenHang);
            this.grpTTSP.Location = new System.Drawing.Point(10, 37);
            this.grpTTSP.Name = "grpTTSP";
            this.grpTTSP.Size = new System.Drawing.Size(1054, 245);
            this.grpTTSP.TabIndex = 50;
            this.grpTTSP.Text = "Thông tin sản phẩm";
            // 
            // cboNcc
            // 
            this.cboNcc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNcc.FormattingEnabled = true;
            this.cboNcc.Location = new System.Drawing.Point(125, 149);
            this.cboNcc.Name = "cboNcc";
            this.cboNcc.Size = new System.Drawing.Size(190, 29);
            this.cboNcc.TabIndex = 2;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(125, 46);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Properties.Appearance.Options.UseFont = true;
            this.txtMaHang.Size = new System.Drawing.Size(191, 28);
            this.txtMaHang.TabIndex = 0;
            // 
            // dtvSp
            // 
            this.dtvSp.AllowUserToAddRows = false;
            this.dtvSp.AllowUserToDeleteRows = false;
            this.dtvSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSp.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSp.Location = new System.Drawing.Point(5, 31);
            this.dtvSp.Name = "dtvSp";
            this.dtvSp.ReadOnly = true;
            this.dtvSp.RowHeadersWidth = 51;
            this.dtvSp.RowTemplate.Height = 24;
            this.dtvSp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvSp.Size = new System.Drawing.Size(1042, 219);
            this.dtvSp.TabIndex = 51;
            this.dtvSp.Click += new System.EventHandler(this.dtvSp_Click);
            // 
            // grpDSSP
            // 
            this.grpDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDSSP.Controls.Add(this.dtvSp);
            this.grpDSSP.Location = new System.Drawing.Point(10, 288);
            this.grpDSSP.Name = "grpDSSP";
            this.grpDSSP.Size = new System.Drawing.Size(1054, 255);
            this.grpDSSP.TabIndex = 52;
            this.grpDSSP.Text = "Danh sách sản phẩm";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 554);
            this.Controls.Add(this.grpDSSP);
            this.Controls.Add(this.grpTTSP);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmSanPham.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTSP)).EndInit();
            this.grpTTSP.ResumeLayout(false);
            this.grpTTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDSSP)).EndInit();
            this.grpDSSP.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem brbtnSearch;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtAnh;
        private DevExpress.XtraEditors.TextEdit txtDGB;
        private DevExpress.XtraEditors.TextEdit txtDGN;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.GroupControl grpDSSP;
        private System.Windows.Forms.DataGridView dtvSp;
        private DevExpress.XtraEditors.GroupControl grpTTSP;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private System.Windows.Forms.ComboBox cboNcc;
    }
}