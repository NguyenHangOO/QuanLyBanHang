
namespace GUI_QLBH
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.cboDThu = new System.Windows.Forms.ComboBox();
            this.grpThoiGian = new System.Windows.Forms.GroupBox();
            this.rdoHangNgay = new System.Windows.Forms.RadioButton();
            this.rdoHangTuan = new System.Windows.Forms.RadioButton();
            this.rdoHangThang = new System.Windows.Forms.RadioButton();
            this.grpTG = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoKhoang = new System.Windows.Forms.RadioButton();
            this.dtTu = new DevExpress.XtraEditors.DateEdit();
            this.dtDen = new DevExpress.XtraEditors.DateEdit();
            this.lblDen = new DevExpress.XtraEditors.LabelControl();
            this.btnThu = new System.Windows.Forms.Button();
            this.btnChi = new System.Windows.Forms.Button();
            this.grpThoiGian.SuspendLayout();
            this.grpTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDThu
            // 
            this.cboDThu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDThu.FormattingEnabled = true;
            this.cboDThu.Location = new System.Drawing.Point(162, 12);
            this.cboDThu.Name = "cboDThu";
            this.cboDThu.Size = new System.Drawing.Size(266, 29);
            this.cboDThu.TabIndex = 0;
            this.cboDThu.Click += new System.EventHandler(this.cboDThu_Click);
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.rdoKhoang);
            this.grpThoiGian.Controls.Add(this.rdoHangThang);
            this.grpThoiGian.Controls.Add(this.rdoHangTuan);
            this.grpThoiGian.Controls.Add(this.rdoHangNgay);
            this.grpThoiGian.Location = new System.Drawing.Point(17, 47);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Size = new System.Drawing.Size(125, 156);
            this.grpThoiGian.TabIndex = 1;
            this.grpThoiGian.TabStop = false;
            // 
            // rdoHangNgay
            // 
            this.rdoHangNgay.AutoSize = true;
            this.rdoHangNgay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHangNgay.ForeColor = System.Drawing.Color.Black;
            this.rdoHangNgay.Location = new System.Drawing.Point(6, 21);
            this.rdoHangNgay.Name = "rdoHangNgay";
            this.rdoHangNgay.Size = new System.Drawing.Size(107, 22);
            this.rdoHangNgay.TabIndex = 0;
            this.rdoHangNgay.TabStop = true;
            this.rdoHangNgay.Text = "Hàng ngày";
            this.rdoHangNgay.UseVisualStyleBackColor = true;
            this.rdoHangNgay.Click += new System.EventHandler(this.frmBaoCao_Load);
            // 
            // rdoHangTuan
            // 
            this.rdoHangTuan.AutoSize = true;
            this.rdoHangTuan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHangTuan.ForeColor = System.Drawing.Color.Black;
            this.rdoHangTuan.Location = new System.Drawing.Point(6, 55);
            this.rdoHangTuan.Name = "rdoHangTuan";
            this.rdoHangTuan.Size = new System.Drawing.Size(104, 22);
            this.rdoHangTuan.TabIndex = 0;
            this.rdoHangTuan.TabStop = true;
            this.rdoHangTuan.Text = "Hàng tuần";
            this.rdoHangTuan.UseVisualStyleBackColor = true;
            this.rdoHangTuan.Click += new System.EventHandler(this.frmBaoCao_Load);
            // 
            // rdoHangThang
            // 
            this.rdoHangThang.AutoSize = true;
            this.rdoHangThang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHangThang.ForeColor = System.Drawing.Color.Black;
            this.rdoHangThang.Location = new System.Drawing.Point(6, 85);
            this.rdoHangThang.Name = "rdoHangThang";
            this.rdoHangThang.Size = new System.Drawing.Size(113, 22);
            this.rdoHangThang.TabIndex = 0;
            this.rdoHangThang.TabStop = true;
            this.rdoHangThang.Text = "Hàng tháng";
            this.rdoHangThang.UseVisualStyleBackColor = true;
            this.rdoHangThang.Click += new System.EventHandler(this.frmBaoCao_Load);
            // 
            // grpTG
            // 
            this.grpTG.Controls.Add(this.lblDen);
            this.grpTG.Controls.Add(this.dtDen);
            this.grpTG.Controls.Add(this.dtTu);
            this.grpTG.Location = new System.Drawing.Point(162, 47);
            this.grpTG.Name = "grpTG";
            this.grpTG.Size = new System.Drawing.Size(266, 156);
            this.grpTG.TabIndex = 2;
            this.grpTG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Người lập:";
            // 
            // rdoKhoang
            // 
            this.rdoKhoang.AutoSize = true;
            this.rdoKhoang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhoang.ForeColor = System.Drawing.Color.Black;
            this.rdoKhoang.Location = new System.Drawing.Point(6, 117);
            this.rdoKhoang.Name = "rdoKhoang";
            this.rdoKhoang.Size = new System.Drawing.Size(84, 22);
            this.rdoKhoang.TabIndex = 0;
            this.rdoKhoang.TabStop = true;
            this.rdoKhoang.Text = "Khoảng";
            this.rdoKhoang.UseVisualStyleBackColor = true;
            this.rdoKhoang.Click += new System.EventHandler(this.frmBaoCao_Load);
            // 
            // dtTu
            // 
            this.dtTu.EditValue = null;
            this.dtTu.Enabled = false;
            this.dtTu.Location = new System.Drawing.Point(31, 23);
            this.dtTu.Name = "dtTu";
            this.dtTu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTu.Properties.Appearance.Options.UseFont = true;
            this.dtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Size = new System.Drawing.Size(202, 30);
            this.dtTu.TabIndex = 0;
            // 
            // dtDen
            // 
            this.dtDen.EditValue = null;
            this.dtDen.Enabled = false;
            this.dtDen.Location = new System.Drawing.Point(31, 109);
            this.dtDen.Name = "dtDen";
            this.dtDen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDen.Properties.Appearance.Options.UseFont = true;
            this.dtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Size = new System.Drawing.Size(202, 30);
            this.dtDen.TabIndex = 0;
            // 
            // lblDen
            // 
            this.lblDen.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblDen.Appearance.Options.UseFont = true;
            this.lblDen.Appearance.Options.UseForeColor = true;
            this.lblDen.Location = new System.Drawing.Point(106, 73);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(32, 21);
            this.lblDen.TabIndex = 1;
            this.lblDen.Text = "đến";
            // 
            // btnThu
            // 
            this.btnThu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThu.ForeColor = System.Drawing.Color.Blue;
            this.btnThu.Location = new System.Drawing.Point(109, 222);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(93, 33);
            this.btnThu.TabIndex = 4;
            this.btnThu.Text = "Thu";
            this.btnThu.UseVisualStyleBackColor = false;
            this.btnThu.Click += new System.EventHandler(this.btnThu_Click);
            // 
            // btnChi
            // 
            this.btnChi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChi.ForeColor = System.Drawing.Color.Blue;
            this.btnChi.Location = new System.Drawing.Point(229, 221);
            this.btnChi.Name = "btnChi";
            this.btnChi.Size = new System.Drawing.Size(93, 33);
            this.btnChi.TabIndex = 4;
            this.btnChi.Text = "Chi";
            this.btnChi.UseVisualStyleBackColor = false;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 267);
            this.Controls.Add(this.btnChi);
            this.Controls.Add(this.btnThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTG);
            this.Controls.Add(this.grpThoiGian);
            this.Controls.Add(this.cboDThu);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmBaoCao.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.grpTG.ResumeLayout(false);
            this.grpTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDThu;
        private System.Windows.Forms.GroupBox grpThoiGian;
        private System.Windows.Forms.RadioButton rdoHangThang;
        private System.Windows.Forms.RadioButton rdoHangTuan;
        private System.Windows.Forms.RadioButton rdoHangNgay;
        private System.Windows.Forms.GroupBox grpTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoKhoang;
        private DevExpress.XtraEditors.LabelControl lblDen;
        private DevExpress.XtraEditors.DateEdit dtDen;
        private DevExpress.XtraEditors.DateEdit dtTu;
        private System.Windows.Forms.Button btnThu;
        private System.Windows.Forms.Button btnChi;
    }
}