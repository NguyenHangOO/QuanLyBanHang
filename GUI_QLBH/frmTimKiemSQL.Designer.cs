
namespace GUI_QLBH
{
    partial class frmTimKiemSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemSQL));
            this.grpTTTK = new DevExpress.XtraEditors.GroupControl();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblTT = new DevExpress.XtraEditors.LabelControl();
            this.grpKetQua = new DevExpress.XtraEditors.GroupControl();
            this.dtvKetQua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTTK)).BeginInit();
            this.grpTTTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKetQua)).BeginInit();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTTTK
            // 
            this.grpTTTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTTK.Controls.Add(this.txtTK);
            this.grpTTTK.Controls.Add(this.btnTK);
            this.grpTTTK.Controls.Add(this.lblTT);
            this.grpTTTK.Location = new System.Drawing.Point(16, 16);
            this.grpTTTK.Name = "grpTTTK";
            this.grpTTTK.Size = new System.Drawing.Size(586, 154);
            this.grpTTTK.TabIndex = 0;
            this.grpTTTK.Text = "Thông tin";
            // 
            // txtTK
            // 
            this.txtTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(26, 79);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(467, 33);
            this.txtTK.TabIndex = 2;
            // 
            // btnTK
            // 
            this.btnTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.Blue;
            this.btnTK.Location = new System.Drawing.Point(499, 77);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(67, 36);
            this.btnTK.TabIndex = 1;
            this.btnTK.Text = "Tìm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblTT
            // 
            this.lblTT.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTT.Appearance.Options.UseFont = true;
            this.lblTT.Appearance.Options.UseForeColor = true;
            this.lblTT.Location = new System.Drawing.Point(26, 46);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(137, 21);
            this.lblTT.TabIndex = 0;
            this.lblTT.Text = "Nhập câu lệnh sql:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQua.Controls.Add(this.dtvKetQua);
            this.grpKetQua.Location = new System.Drawing.Point(17, 176);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(585, 348);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.Text = "Kết quả";
            // 
            // dtvKetQua
            // 
            this.dtvKetQua.AllowUserToAddRows = false;
            this.dtvKetQua.AllowUserToDeleteRows = false;
            this.dtvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvKetQua.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvKetQua.Location = new System.Drawing.Point(5, 31);
            this.dtvKetQua.Name = "dtvKetQua";
            this.dtvKetQua.ReadOnly = true;
            this.dtvKetQua.RowHeadersWidth = 51;
            this.dtvKetQua.RowTemplate.Height = 24;
            this.dtvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvKetQua.Size = new System.Drawing.Size(575, 312);
            this.dtvKetQua.TabIndex = 0;
            // 
            // frmTimKiemSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 548);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpTTTK);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmTimKiemSQL.IconOptions.SvgImage")));
            this.Name = "frmTimKiemSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemSQL";
            ((System.ComponentModel.ISupportInitialize)(this.grpTTTK)).EndInit();
            this.grpTTTK.ResumeLayout(false);
            this.grpTTTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKetQua)).EndInit();
            this.grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpTTTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTK;
        private DevExpress.XtraEditors.LabelControl lblTT;
        private DevExpress.XtraEditors.GroupControl grpKetQua;
        private System.Windows.Forms.DataGridView dtvKetQua;
    }
}