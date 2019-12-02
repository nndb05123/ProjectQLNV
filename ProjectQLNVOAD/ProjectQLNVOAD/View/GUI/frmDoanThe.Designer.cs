namespace ProjectQLNVOAD.View.GUI
{
    partial class frmDoanThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanThe));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btn_SuaThongTin = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Reload = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Xuat = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_CapNhatDuLieu = new DevComponents.DotNetBar.ButtonX();
            this.tb_TenDoanThe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Location = new System.Drawing.Point(12, 12);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(967, 385);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(967, 385);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Danh Sách đoàn thể";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(789, 294);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm Đoàn Thể";
            this.navigationPage2.Controls.Add(this.groupControl2);
            this.navigationPage2.Controls.Add(this.groupControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(815, 312);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Controls.Add(this.bar1);
            this.groupControl2.Location = new System.Drawing.Point(326, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(486, 306);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dữ liệu đoàn thể";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 231);
            this.dataGridView1.TabIndex = 1;
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
            this.bar1.Location = new System.Drawing.Point(2, 23);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(482, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
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
            this.btn_Xoa.Text = "Xóa ";
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.btn_CapNhatDuLieu);
            this.groupControl1.Controls.Add(this.tb_TenDoanThe);
            this.groupControl1.Controls.Add(this.labelX1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(317, 306);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đoàn thể";
            // 
            // btn_CapNhatDuLieu
            // 
            this.btn_CapNhatDuLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_CapNhatDuLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_CapNhatDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhatDuLieu.Image")));
            this.btn_CapNhatDuLieu.Location = new System.Drawing.Point(85, 174);
            this.btn_CapNhatDuLieu.Name = "btn_CapNhatDuLieu";
            this.btn_CapNhatDuLieu.Size = new System.Drawing.Size(103, 40);
            this.btn_CapNhatDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_CapNhatDuLieu.TabIndex = 2;
            this.btn_CapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btn_CapNhatDuLieu.Click += new System.EventHandler(this.btn_CapNhatDuLieu_Click);
            // 
            // tb_TenDoanThe
            // 
            // 
            // 
            // 
            this.tb_TenDoanThe.Border.Class = "TextBoxBorder";
            this.tb_TenDoanThe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TenDoanThe.Location = new System.Drawing.Point(128, 104);
            this.tb_TenDoanThe.Name = "tb_TenDoanThe";
            this.tb_TenDoanThe.PreventEnterBeep = true;
            this.tb_TenDoanThe.Size = new System.Drawing.Size(116, 21);
            this.tb_TenDoanThe.TabIndex = 1;
            this.tb_TenDoanThe.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên đoàn thể";
            // 
            // frmDoanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 409);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmDoanThe";
            this.Text = "Quản lý đoàn thể";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TenDoanThe;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btn_SuaThongTin;
        private DevComponents.DotNetBar.ButtonItem btn_Xoa;
        private DevComponents.DotNetBar.ButtonItem btn_Reload;
        private DevComponents.DotNetBar.ButtonItem btn_Xuat;
        private DevComponents.DotNetBar.ButtonItem btn_Thoat;
        private DevComponents.DotNetBar.ButtonX btn_CapNhatDuLieu;
    }
}