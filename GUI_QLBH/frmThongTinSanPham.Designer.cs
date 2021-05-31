
namespace GUI_QLBH
{
    partial class frmThongTinSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinSanPham));
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.lblPH = new DevExpress.XtraEditors.LabelControl();
            this.lblChuThich = new DevExpress.XtraEditors.LabelControl();
            this.lblTTT = new DevExpress.XtraEditors.LabelControl();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(744, 737);
            this.documentViewer1.TabIndex = 0;
            // 
            // lblPH
            // 
            this.lblPH.Location = new System.Drawing.Point(21, 28);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(284, 17);
            this.lblPH.TabIndex = 1;
            this.lblPH.Text = "Sản phẩm được phát hành bới @HangNguyen";
            // 
            // lblChuThich
            // 
            this.lblChuThich.Location = new System.Drawing.Point(21, 60);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(321, 17);
            this.lblChuThich.TabIndex = 1;
            this.lblChuThich.Text = "Phát hành vào tháng 05 năm 2021  phiên bản 1.0.0";
            // 
            // lblTTT
            // 
            this.lblTTT.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTTT.Appearance.Options.UseBackColor = true;
            this.lblTTT.Location = new System.Drawing.Point(21, 104);
            this.lblTTT.Name = "lblTTT";
            this.lblTTT.Size = new System.Drawing.Size(671, 34);
            this.lblTTT.TabIndex = 1;
            this.lblTTT.Text = "Để biết cách sử dụng vui lòng chọn phần Giúp đỡ sao đó chọn Hướng dẫn sử dụng. Ho" +
    "ặc mọi thắc mắc khác\r\n vui lòng liên hệ nhà phát hành qua đường link bên dưới.";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(240, 159);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(193, 17);
            this.lblLink.TabIndex = 2;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "https://nguyenhang.hh.ng.nv";
            // 
            // frmThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 737);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblTTT);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.lblPH);
            this.Controls.Add(this.documentViewer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmThongTinSanPham.IconOptions.SvgImage")));
            this.Name = "frmThongTinSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraEditors.LabelControl lblPH;
        private DevExpress.XtraEditors.LabelControl lblChuThich;
        private DevExpress.XtraEditors.LabelControl lblTTT;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}