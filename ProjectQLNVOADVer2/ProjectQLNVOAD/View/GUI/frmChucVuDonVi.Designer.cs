namespace ProjectQLNVOAD.View.GUI
{
    partial class frmChucVuDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVuDonVi));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DuLieuChucVu = new System.Windows.Forms.DataGridView();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btn_SuaThongTin = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Reload = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Xuat = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_PhuCapChucVu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbb_Nam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_CapNhatDuLieu = new DevComponents.DotNetBar.ButtonX();
            this.tb_ChucVu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbb_DonVi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Location = new System.Drawing.Point(3, -1);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(951, 447);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(951, 447);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Danh Sách Chức Vụ";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(791, 356);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm Chức Vụ";
            this.navigationPage2.Controls.Add(this.groupBox2);
            this.navigationPage2.Controls.Add(this.groupBox1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(802, 374);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_DuLieuChucVu);
            this.groupBox2.Controls.Add(this.bar1);
            this.groupBox2.Location = new System.Drawing.Point(303, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ  liệu chức vụ";
            // 
            // dgv_DuLieuChucVu
            // 
            this.dgv_DuLieuChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieuChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieuChucVu.Location = new System.Drawing.Point(6, 66);
            this.dgv_DuLieuChucVu.Name = "dgv_DuLieuChucVu";
            this.dgv_DuLieuChucVu.Size = new System.Drawing.Size(472, 296);
            this.dgv_DuLieuChucVu.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_SuaThongTin,
            this.btn_Xoa,
            this.btn_Reload,
            this.btn_Xuat,
            this.btn_Thoat});
            this.bar1.Location = new System.Drawing.Point(3, 17);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(475, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btn_SuaThongTin
            // 
            this.btn_SuaThongTin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_SuaThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaThongTin.Image")));
            this.btn_SuaThongTin.Name = "btn_SuaThongTin";
            this.btn_SuaThongTin.Text = "Sửa thông tin";
            this.btn_SuaThongTin.Click += new System.EventHandler(this.btn_SuaThongTin_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reload.Image")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Text = "Reload dữ liệu";
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Xuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xuat.Image")));
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Text = "Xuất CSV";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tb_PhuCapChucVu);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.cbb_Nam);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.btn_CapNhatDuLieu);
            this.groupBox1.Controls.Add(this.tb_ChucVu);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.cbb_DonVi);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // tb_PhuCapChucVu
            // 
            // 
            // 
            // 
            this.tb_PhuCapChucVu.Border.Class = "TextBoxBorder";
            this.tb_PhuCapChucVu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_PhuCapChucVu.Location = new System.Drawing.Point(134, 176);
            this.tb_PhuCapChucVu.Name = "tb_PhuCapChucVu";
            this.tb_PhuCapChucVu.PreventEnterBeep = true;
            this.tb_PhuCapChucVu.Size = new System.Drawing.Size(134, 21);
            this.tb_PhuCapChucVu.TabIndex = 13;
            this.tb_PhuCapChucVu.TextChanged += new System.EventHandler(this.tb_PhuCapChucVu_TextChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(17, 165);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(88, 38);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Phụ Cấp Chức Vụ";
            // 
            // cbb_Nam
            // 
            this.cbb_Nam.DisplayMember = "Text";
            this.cbb_Nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Nam.FormattingEnabled = true;
            this.cbb_Nam.ItemHeight = 16;
            this.cbb_Nam.Location = new System.Drawing.Point(134, 122);
            this.cbb_Nam.Name = "cbb_Nam";
            this.cbb_Nam.Size = new System.Drawing.Size(134, 22);
            this.cbb_Nam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_Nam.TabIndex = 11;
            this.cbb_Nam.SelectedIndexChanged += new System.EventHandler(this.cbb_Nam_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(17, 121);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Năm";
            // 
            // btn_CapNhatDuLieu
            // 
            this.btn_CapNhatDuLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_CapNhatDuLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_CapNhatDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhatDuLieu.Image")));
            this.btn_CapNhatDuLieu.Location = new System.Drawing.Point(86, 231);
            this.btn_CapNhatDuLieu.Name = "btn_CapNhatDuLieu";
            this.btn_CapNhatDuLieu.Size = new System.Drawing.Size(108, 41);
            this.btn_CapNhatDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_CapNhatDuLieu.TabIndex = 9;
            this.btn_CapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btn_CapNhatDuLieu.Click += new System.EventHandler(this.btn_CapNhatDuLieu_Click);
            // 
            // tb_ChucVu
            // 
            // 
            // 
            // 
            this.tb_ChucVu.Border.Class = "TextBoxBorder";
            this.tb_ChucVu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_ChucVu.Location = new System.Drawing.Point(134, 66);
            this.tb_ChucVu.Name = "tb_ChucVu";
            this.tb_ChucVu.PreventEnterBeep = true;
            this.tb_ChucVu.Size = new System.Drawing.Size(134, 21);
            this.tb_ChucVu.TabIndex = 5;
            this.tb_ChucVu.TextChanged += new System.EventHandler(this.tb_ChucVu_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(17, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Chức vụ";
            // 
            // cbb_DonVi
            // 
            this.cbb_DonVi.DisplayMember = "Text";
            this.cbb_DonVi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_DonVi.FormattingEnabled = true;
            this.cbb_DonVi.ItemHeight = 16;
            this.cbb_DonVi.Location = new System.Drawing.Point(134, 20);
            this.cbb_DonVi.Name = "cbb_DonVi";
            this.cbb_DonVi.Size = new System.Drawing.Size(134, 22);
            this.cbb_DonVi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_DonVi.TabIndex = 3;
            this.cbb_DonVi.SelectedIndexChanged += new System.EventHandler(this.cbb_DonVi_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Đơn vị bổ sung";
            // 
            // frmChucVuDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 458);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmChucVuDonVi";
            this.Text = "Chức Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_ChucVu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_DonVi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DuLieuChucVu;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btn_SuaThongTin;
        private DevComponents.DotNetBar.ButtonItem btn_Xoa;
        private DevComponents.DotNetBar.ButtonItem btn_Reload;
        private DevComponents.DotNetBar.ButtonItem btn_Xuat;
        private DevComponents.DotNetBar.ButtonItem btn_Thoat;
        private DevComponents.DotNetBar.ButtonX btn_CapNhatDuLieu;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PhuCapChucVu;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_Nam;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}