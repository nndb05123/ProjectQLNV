namespace HRM_VTHP.HeThong
{
    partial class frmPhanQuyenNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyenNguoiDung));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmbNguoiDung = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.cbTKBaoCao = new System.Windows.Forms.CheckBox();
            this.cbQLTienLuong = new System.Windows.Forms.CheckBox();
            this.cbQLNhanSu = new System.Windows.Forms.CheckBox();
            this.cbQLDanhMuc = new System.Windows.Forms.CheckBox();
            this.cbQLHT = new System.Windows.Forms.CheckBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.grbThongTin.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmbNguoiDung);
            this.grbThongTin.Controls.Add(this.cmbNhanVien);
            this.grbThongTin.Controls.Add(this.cmbBoPhan);
            this.grbThongTin.Controls.Add(this.lblNguoiDung);
            this.grbThongTin.Controls.Add(this.lblNhanVien);
            this.grbThongTin.Controls.Add(this.lblBoPhan);
            this.grbThongTin.Location = new System.Drawing.Point(14, 13);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(317, 128);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin ";
            // 
            // cmbNguoiDung
            // 
            this.cmbNguoiDung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNguoiDung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNguoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNguoiDung.FormattingEnabled = true;
            this.cmbNguoiDung.Location = new System.Drawing.Point(118, 98);
            this.cmbNguoiDung.Name = "cmbNguoiDung";
            this.cmbNguoiDung.Size = new System.Drawing.Size(175, 30);
            this.cmbNguoiDung.TabIndex = 5;
            this.cmbNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cmbNguoiDung_SelectedIndexChanged);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(118, 60);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(175, 30);
            this.cmbNhanVien.TabIndex = 4;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBoPhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(118, 25);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(175, 30);
            this.cmbBoPhan.TabIndex = 3;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.Location = new System.Drawing.Point(17, 101);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(103, 22);
            this.lblNguoiDung.TabIndex = 2;
            this.lblNguoiDung.Text = "Người dùng";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(17, 64);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(89, 22);
            this.lblNhanVien.TabIndex = 1;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(17, 28);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(76, 22);
            this.lblBoPhan.TabIndex = 0;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.cbTKBaoCao);
            this.grbDanhSach.Controls.Add(this.cbQLTienLuong);
            this.grbDanhSach.Controls.Add(this.cbQLNhanSu);
            this.grbDanhSach.Controls.Add(this.cbQLDanhMuc);
            this.grbDanhSach.Controls.Add(this.cbQLHT);
            this.grbDanhSach.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSach.Location = new System.Drawing.Point(14, 163);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(317, 197);
            this.grbDanhSach.TabIndex = 1;
            this.grbDanhSach.TabStop = false;
            // 
            // cbTKBaoCao
            // 
            this.cbTKBaoCao.AutoSize = true;
            this.cbTKBaoCao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTKBaoCao.Location = new System.Drawing.Point(21, 165);
            this.cbTKBaoCao.Name = "cbTKBaoCao";
            this.cbTKBaoCao.Size = new System.Drawing.Size(179, 26);
            this.cbTKBaoCao.TabIndex = 4;
            this.cbTKBaoCao.Text = "Thống kê báo cáo";
            this.cbTKBaoCao.UseVisualStyleBackColor = true;
            // 
            // cbQLTienLuong
            // 
            this.cbQLTienLuong.AutoSize = true;
            this.cbQLTienLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLTienLuong.Location = new System.Drawing.Point(21, 128);
            this.cbQLTienLuong.Name = "cbQLTienLuong";
            this.cbQLTienLuong.Size = new System.Drawing.Size(183, 26);
            this.cbQLTienLuong.TabIndex = 3;
            this.cbQLTienLuong.Text = "Quản lý tiền lương";
            this.cbQLTienLuong.UseVisualStyleBackColor = true;
            // 
            // cbQLNhanSu
            // 
            this.cbQLNhanSu.AutoSize = true;
            this.cbQLNhanSu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLNhanSu.Location = new System.Drawing.Point(21, 89);
            this.cbQLNhanSu.Name = "cbQLNhanSu";
            this.cbQLNhanSu.Size = new System.Drawing.Size(167, 26);
            this.cbQLNhanSu.TabIndex = 2;
            this.cbQLNhanSu.Text = "Quản lý nhân sự";
            this.cbQLNhanSu.UseVisualStyleBackColor = true;
            // 
            // cbQLDanhMuc
            // 
            this.cbQLDanhMuc.AutoSize = true;
            this.cbQLDanhMuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLDanhMuc.Location = new System.Drawing.Point(21, 55);
            this.cbQLDanhMuc.Name = "cbQLDanhMuc";
            this.cbQLDanhMuc.Size = new System.Drawing.Size(181, 26);
            this.cbQLDanhMuc.TabIndex = 1;
            this.cbQLDanhMuc.Text = "Quản lý danh mục";
            this.cbQLDanhMuc.UseVisualStyleBackColor = true;
            // 
            // cbQLHT
            // 
            this.cbQLHT.AutoSize = true;
            this.cbQLHT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLHT.Location = new System.Drawing.Point(21, 20);
            this.cbQLHT.Name = "cbQLHT";
            this.cbQLHT.Size = new System.Drawing.Size(174, 26);
            this.cbQLHT.TabIndex = 0;
            this.cbQLHT.Text = "Quản lý hệ thống";
            this.cbQLHT.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(14, 382);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 33);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(231, 382);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPhanQuyenNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 438);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbThongTin);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhanQuyenNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHAN QUYEN NGUOI DUNG";
            this.Load += new System.EventHandler(this.frmPhanQuyenNguoiDung_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            this.grbDanhSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbNguoiDung;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.CheckBox cbTKBaoCao;
        private System.Windows.Forms.CheckBox cbQLTienLuong;
        private System.Windows.Forms.CheckBox cbQLNhanSu;
        private System.Windows.Forms.CheckBox cbQLDanhMuc;
        private System.Windows.Forms.CheckBox cbQLHT;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}