
namespace GUI_QLBH
{
    partial class frmIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIN));
            this.cboHD = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.rdoBan = new System.Windows.Forms.RadioButton();
            this.rdoNhap = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cboHD
            // 
            this.cboHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHD.FormattingEnabled = true;
            this.cboHD.Location = new System.Drawing.Point(12, 8);
            this.cboHD.Name = "cboHD";
            this.cboHD.Size = new System.Drawing.Size(367, 32);
            this.cboHD.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.Location = new System.Drawing.Point(138, 87);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 32);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rdoBan
            // 
            this.rdoBan.AutoSize = true;
            this.rdoBan.Checked = true;
            this.rdoBan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBan.ForeColor = System.Drawing.Color.Blue;
            this.rdoBan.Location = new System.Drawing.Point(14, 49);
            this.rdoBan.Name = "rdoBan";
            this.rdoBan.Size = new System.Drawing.Size(95, 21);
            this.rdoBan.TabIndex = 2;
            this.rdoBan.TabStop = true;
            this.rdoBan.Text = "Bán hàng";
            this.rdoBan.UseVisualStyleBackColor = true;
            this.rdoBan.Click += new System.EventHandler(this.frmIN_Load);
            // 
            // rdoNhap
            // 
            this.rdoNhap.AutoSize = true;
            this.rdoNhap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoNhap.Location = new System.Drawing.Point(138, 50);
            this.rdoNhap.Name = "rdoNhap";
            this.rdoNhap.Size = new System.Drawing.Size(105, 21);
            this.rdoNhap.TabIndex = 2;
            this.rdoNhap.Text = "Nhập hàng";
            this.rdoNhap.UseVisualStyleBackColor = true;
            this.rdoNhap.Click += new System.EventHandler(this.frmIN_Load);
            // 
            // frmIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 137);
            this.Controls.Add(this.rdoNhap);
            this.Controls.Add(this.rdoBan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboHD);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmIN.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In";
            this.Load += new System.EventHandler(this.frmIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rdoBan;
        private System.Windows.Forms.RadioButton rdoNhap;
    }
}