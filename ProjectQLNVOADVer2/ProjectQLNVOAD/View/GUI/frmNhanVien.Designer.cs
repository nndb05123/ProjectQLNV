namespace ProjectQLNVOAD.View.GUI
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_CapNhatDuLieu = new DevComponents.DotNetBar.ButtonX();
            this.btn_LamLai = new DevComponents.DotNetBar.ButtonX();
            this.cbb_ChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_DonVi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.date_NgayVaoLam = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_NgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_DanToc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_DiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_CMND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TenNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel_GioiTinh = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayVaoLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh)).BeginInit();
            this.panel_GioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm nhân viên";
            this.navigationPage2.Controls.Add(this.groupBox4);
            this.navigationPage2.Controls.Add(this.groupBox3);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(690, 316);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_CapNhatDuLieu);
            this.groupBox4.Controls.Add(this.btn_LamLai);
            this.groupBox4.Controls.Add(this.cbb_ChucVu);
            this.groupBox4.Controls.Add(this.cbb_DonVi);
            this.groupBox4.Controls.Add(this.labelX17);
            this.groupBox4.Controls.Add(this.labelX18);
            this.groupBox4.Location = new System.Drawing.Point(350, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 307);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Vụ";
            // 
            // btn_CapNhatDuLieu
            // 
            this.btn_CapNhatDuLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_CapNhatDuLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_CapNhatDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhatDuLieu.Image")));
            this.btn_CapNhatDuLieu.Location = new System.Drawing.Point(148, 211);
            this.btn_CapNhatDuLieu.Name = "btn_CapNhatDuLieu";
            this.btn_CapNhatDuLieu.Size = new System.Drawing.Size(104, 32);
            this.btn_CapNhatDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_CapNhatDuLieu.TabIndex = 5;
            this.btn_CapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btn_CapNhatDuLieu.Click += new System.EventHandler(this.btn_CapNhatDuLieu_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LamLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_LamLai.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamLai.Image")));
            this.btn_LamLai.Location = new System.Drawing.Point(30, 211);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(95, 32);
            this.btn_LamLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_LamLai.TabIndex = 4;
            this.btn_LamLai.Text = "Làm Lại";
            this.btn_LamLai.Click += new System.EventHandler(this.btn_LamLai_Click);
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.DisplayMember = "Text";
            this.cbb_ChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.ItemHeight = 16;
            this.cbb_ChucVu.Location = new System.Drawing.Point(111, 135);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(141, 22);
            this.cbb_ChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_ChucVu.TabIndex = 3;
            this.cbb_ChucVu.SelectedIndexChanged += new System.EventHandler(this.cbb_ChucVu_SelectedIndexChanged);
            // 
            // cbb_DonVi
            // 
            this.cbb_DonVi.DisplayMember = "Text";
            this.cbb_DonVi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_DonVi.FormattingEnabled = true;
            this.cbb_DonVi.ItemHeight = 16;
            this.cbb_DonVi.Location = new System.Drawing.Point(111, 81);
            this.cbb_DonVi.Name = "cbb_DonVi";
            this.cbb_DonVi.Size = new System.Drawing.Size(141, 22);
            this.cbb_DonVi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_DonVi.TabIndex = 2;
            this.cbb_DonVi.SelectedIndexChanged += new System.EventHandler(this.cbb_DonVi_SelectedIndexChanged);
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(30, 135);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(75, 23);
            this.labelX17.TabIndex = 1;
            this.labelX17.Text = "Chức Vụ";
            // 
            // labelX18
            // 
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(30, 81);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(75, 23);
            this.labelX18.TabIndex = 0;
            this.labelX18.Text = "Đơn Vị";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.date_NgayVaoLam);
            this.groupBox3.Controls.Add(this.date_NgaySinh);
            this.groupBox3.Controls.Add(this.tb_DanToc);
            this.groupBox3.Controls.Add(this.tb_DiaChi);
            this.groupBox3.Controls.Add(this.tb_CMND);
            this.groupBox3.Controls.Add(this.tb_TenNhanVien);
            this.groupBox3.Controls.Add(this.labelX10);
            this.groupBox3.Controls.Add(this.panel_GioiTinh);
            this.groupBox3.Controls.Add(this.labelX11);
            this.groupBox3.Controls.Add(this.labelX12);
            this.groupBox3.Controls.Add(this.labelX13);
            this.groupBox3.Controls.Add(this.labelX14);
            this.groupBox3.Controls.Add(this.labelX15);
            this.groupBox3.Controls.Add(this.labelX16);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 307);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin cơ bản";
            // 
            // date_NgayVaoLam
            // 
            // 
            // 
            // 
            this.date_NgayVaoLam.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_NgayVaoLam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgayVaoLam.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_NgayVaoLam.ButtonDropDown.Visible = true;
            this.date_NgayVaoLam.IsPopupCalendarOpen = false;
            this.date_NgayVaoLam.Location = new System.Drawing.Point(133, 233);
            // 
            // 
            // 
            // 
            // 
            // 
            this.date_NgayVaoLam.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgayVaoLam.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_NgayVaoLam.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgayVaoLam.MonthCalendar.DisplayMonth = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.date_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgayVaoLam.MonthCalendar.TodayButtonVisible = true;
            this.date_NgayVaoLam.Name = "date_NgayVaoLam";
            this.date_NgayVaoLam.Size = new System.Drawing.Size(167, 21);
            this.date_NgayVaoLam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_NgayVaoLam.TabIndex = 19;
            this.date_NgayVaoLam.Click += new System.EventHandler(this.date_NgayVaoLam_Click);
            // 
            // date_NgaySinh
            // 
            // 
            // 
            // 
            this.date_NgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_NgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_NgaySinh.ButtonDropDown.Visible = true;
            this.date_NgaySinh.IsPopupCalendarOpen = false;
            this.date_NgaySinh.Location = new System.Drawing.Point(133, 93);
            // 
            // 
            // 
            // 
            // 
            // 
            this.date_NgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_NgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_NgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.date_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_NgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_NgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(167, 21);
            this.date_NgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_NgaySinh.TabIndex = 18;
            this.date_NgaySinh.Click += new System.EventHandler(this.date_NgaySinh_Click);
            // 
            // tb_DanToc
            // 
            // 
            // 
            // 
            this.tb_DanToc.Border.Class = "TextBoxBorder";
            this.tb_DanToc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_DanToc.Location = new System.Drawing.Point(133, 190);
            this.tb_DanToc.Name = "tb_DanToc";
            this.tb_DanToc.PreventEnterBeep = true;
            this.tb_DanToc.Size = new System.Drawing.Size(167, 21);
            this.tb_DanToc.TabIndex = 15;
            this.tb_DanToc.TextChanged += new System.EventHandler(this.tb_DanToc_TextChanged);
            // 
            // tb_DiaChi
            // 
            // 
            // 
            // 
            this.tb_DiaChi.Border.Class = "TextBoxBorder";
            this.tb_DiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_DiaChi.Location = new System.Drawing.Point(133, 151);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.PreventEnterBeep = true;
            this.tb_DiaChi.Size = new System.Drawing.Size(167, 21);
            this.tb_DiaChi.TabIndex = 14;
            this.tb_DiaChi.TextChanged += new System.EventHandler(this.tb_DiaChi_TextChanged);
            // 
            // tb_CMND
            // 
            // 
            // 
            // 
            this.tb_CMND.Border.Class = "TextBoxBorder";
            this.tb_CMND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_CMND.Location = new System.Drawing.Point(133, 119);
            this.tb_CMND.Name = "tb_CMND";
            this.tb_CMND.PreventEnterBeep = true;
            this.tb_CMND.Size = new System.Drawing.Size(167, 21);
            this.tb_CMND.TabIndex = 13;
            this.tb_CMND.TextChanged += new System.EventHandler(this.tb_CMND_TextChanged);
            // 
            // tb_TenNhanVien
            // 
            // 
            // 
            // 
            this.tb_TenNhanVien.Border.Class = "TextBoxBorder";
            this.tb_TenNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TenNhanVien.Location = new System.Drawing.Point(133, 22);
            this.tb_TenNhanVien.Name = "tb_TenNhanVien";
            this.tb_TenNhanVien.PreventEnterBeep = true;
            this.tb_TenNhanVien.Size = new System.Drawing.Size(167, 21);
            this.tb_TenNhanVien.TabIndex = 12;
            this.tb_TenNhanVien.TextChanged += new System.EventHandler(this.tb_TenNhanVien_TextChanged);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(15, 233);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 11;
            this.labelX10.Text = "Ngày vào làm";
            // 
            // panel_GioiTinh
            // 
            this.panel_GioiTinh.Controls.Add(this.radioButton3);
            this.panel_GioiTinh.Controls.Add(this.radioButton4);
            this.panel_GioiTinh.Location = new System.Drawing.Point(133, 60);
            this.panel_GioiTinh.Name = "panel_GioiTinh";
            this.panel_GioiTinh.Size = new System.Drawing.Size(167, 23);
            this.panel_GioiTinh.TabIndex = 10;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(59, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nữ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Nam ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(15, 188);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 5;
            this.labelX11.Text = "Dân tộc";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(15, 148);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 4;
            this.labelX12.Text = "Địa chỉ hiện tại";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(15, 119);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 3;
            this.labelX13.Text = "Số CMND";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(15, 90);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 23);
            this.labelX14.TabIndex = 2;
            this.labelX14.Text = "Ngày Sinh";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(15, 61);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 1;
            this.labelX15.Text = "Giới tính";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(15, 20);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(75, 23);
            this.labelX16.TabIndex = 0;
            this.labelX16.Text = "Tên nhân viên";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Danh sách nhân viên";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(690, 316);
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(845, 389);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(845, 389);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 413);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.navigationPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayVaoLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh)).EndInit();
            this.panel_GioiTinh.ResumeLayout(false);
            this.panel_GioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btn_CapNhatDuLieu;
        private DevComponents.DotNetBar.ButtonX btn_LamLai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_ChucVu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_DonVi;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX18;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_NgayVaoLam;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_NgaySinh;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_DanToc;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_DiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CMND;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TenNhanVien;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.Panel panel_GioiTinh;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
    }
}