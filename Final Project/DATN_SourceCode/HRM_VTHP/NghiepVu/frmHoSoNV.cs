using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.NghiepVu
{
    public partial class frmHoSoNV : Form
    {
        public string CurrentImagePath = "";
      
        public frmHoSoNV()
        {
            InitializeComponent();
        }
        int kt = 0;
        //int NhanVienID = 0;
        void Load_DL()
        {
            DataTable dt = HoSoNhanVienBUS.Instance.LoadAllHSNhanVien();
            grdHoSoNhanVien.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            btnCapNhat.Enabled = false;
            cmbTenNV.Enabled = false;
            cmbBangCap.Enabled = false;
            cmbDanToc.Enabled = false;
            cmbNgoaiNgu.Enabled = false;
            cmbTinHoc.Enabled = false;
            cmbTinhThanh.Enabled = false;
            cmbTonGiao.Enabled = false;
            txtGhiChu.Enabled = false;
            dtpNgayVaoLam.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbTenNV.Enabled = true;
            cmbBangCap.Enabled = true;
            cmbDanToc.Enabled = true;
            cmbNgoaiNgu.Enabled = true;
            cmbTinHoc.Enabled = true;
            cmbTinhThanh.Enabled = true;
            cmbTonGiao.Enabled = true;
            txtGhiChu.Enabled = true;
            dtpNgayVaoLam.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbBangCap.Enabled = true;
            cmbDanToc.Enabled = true;
            cmbNgoaiNgu.Enabled = true;
            cmbTinHoc.Enabled = true;
            cmbTinhThanh.Enabled = true;
            cmbTonGiao.Enabled = true;
            txtGhiChu.Enabled = true;
            dtpNgayVaoLam.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ImagePath = "\\AnhHSNV" + CurrentImagePath;
            HoSoNhanVienDTO hsNhanVien = new HoSoNhanVienDTO();
            hsNhanVien.NhanVienID = int.Parse(cmbTenNV.SelectedValue.ToString());
            hsNhanVien.NgayVaoLam = dtpNgayVaoLam.Value;
            hsNhanVien.DanTocID = int.Parse(cmbDanToc.SelectedValue.ToString());
            hsNhanVien.TonGiaoID = int.Parse(cmbTonGiao.SelectedValue.ToString());
            hsNhanVien.TinhThanhID = int.Parse(cmbTinhThanh.SelectedValue.ToString());
            hsNhanVien.NgoaiNguID = int.Parse(cmbNgoaiNgu.SelectedValue.ToString());
            hsNhanVien.TinHocID = int.Parse(cmbTinHoc.SelectedValue.ToString());
            hsNhanVien.BangCapID = int.Parse(cmbBangCap.SelectedValue.ToString());
            hsNhanVien.GhiChu = txtGhiChu.Text.Trim();
            hsNhanVien.ImagePath = ImagePath;
            if (kt == 1)
            {
                if (HoSoNhanVienBUS.Instance.ThemHSNhanVien(hsNhanVien) == -1)
                {
                    MessageBox.Show("Lỗi khi thêm mới");
                }
                else
                {
                    Load_DL();
                }
            }
            else
            {
                HoSoNhanVienBUS.Instance.UpdateHoSoNhanVien(hsNhanVien);
                Load_DL();
            }
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoSoNhanVienBUS.Instance.DeleteHSNhanVien(int.Parse(cmbTenNV.SelectedValue.ToString()));
            Load_DL();
            Reset();

        }

        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            DataTable dt1 = DanTocBUS.Instance.LoadAllDanToc();
            cmbDanToc.DataSource = dt1;
            cmbDanToc.ValueMember = "DanTocID";
            cmbDanToc.DisplayMember = "TenDanToc";
            DataTable dt2 = TonGiaoBUS.Instance.LoadAllTonGiao();
            cmbTonGiao.DataSource = dt2;
            cmbTonGiao.ValueMember = "TonGiaoID";
            cmbTonGiao.DisplayMember = "TenTonGiao";
            DataTable dt3 = TinhThanhBUS.Instance.LoadAllTinhThanh();
            cmbTinhThanh.DataSource = dt3;
            cmbTinhThanh.ValueMember = "TinhThanhID";
            cmbTinhThanh.DisplayMember = "TenTinhThanh";
            DataTable dt4 = NgoaiNguBUS.Instance.LoadAllNgoaiNgu();
            cmbNgoaiNgu.DataSource = dt4;
            cmbNgoaiNgu.ValueMember = "NgoaiNguID";
            cmbNgoaiNgu.DisplayMember = "TenCCNN";
            DataTable dt5 = TinHocBUS.Instance.LoadAllTinHoc();
            cmbTinHoc.DataSource = dt5;
            cmbTinHoc.ValueMember = "TinHocID";
            cmbTinHoc.DisplayMember = "TenCCTH";
            DataTable dt6 = BangCapBUS.Instance.LoadAllBangCap();
            cmbBangCap.DataSource = dt6;
            cmbBangCap.ValueMember = "BangCapID";
            cmbBangCap.DisplayMember = "TenBangCap";
            DataTable dt7 = NhanVienBUS.Instance.LoadAllNhanVien();
            cmbTenNV.DataSource = dt7;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //NhanVienID= int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
            cmbTenNV.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
            dtpNgayVaoLam.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayVaoLam").ToString());
            cmbDanToc.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("DanTocID").ToString());
            cmbTonGiao.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("TonGiaoID").ToString());
            cmbTinhThanh.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("TinhThanhID").ToString());
            cmbNgoaiNgu.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NgoaiNguID").ToString());
            cmbTinHoc.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("TinHocID").ToString());
            cmbBangCap.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BangCapID").ToString());
            txtGhiChu.Text = gridView1.GetFocusedRowCellValue("GhiChu").ToString();
            LoadImage(gridView1.GetFocusedRowCellValue("ImagePath").ToString());
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "";
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = false; // cho phép chọn 1 ảnh
            this.openFileDialog1.Title = "Ảnh HSNV";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string files = openFileDialog1.FileName;
            CurrentImagePath = files.Substring(files.LastIndexOf("\\"));
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(files);
            System.IO.FileStream fileStream = fileInfo.OpenRead();
            pictureBox1.Image = resizeImage(System.Drawing.Image.FromStream(fileStream), new Size(150,200));
            fileStream.Close();
        }
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public void LoadImage(string path)
        {
            string AppPath = Application.StartupPath;
            string file = AppPath + path; 
            if (File.Exists(file))
            {
                pictureBox1.Image = null;
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                System.IO.FileStream fileStream = fileInfo.OpenRead();
                pictureBox1.Image = resizeImage(System.Drawing.Image.FromStream(fileStream), new Size(150, 200));
                fileStream.Close();
            }
            
            
        }
    }
}
