using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoHoSoMotNV : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoHoSoMotNV(DataTable dt)
        {
            InitializeComponent();

            DataRow dr = dt.Rows[0];
            // gán giá trị
            LoadImage(dr["ImagePath"].ToString());
            txtMaNV.Text = dr["MaNV"].ToString();
            txtTenNV.Text = dr["TenNV"].ToString();
            txtDanToc.Text = dr["TenDanToc"].ToString();
            txtBangCap.Text = dr["TenBangCap"].ToString();
            txtDiaChi.Text = dr["DiaChi"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtGioiTinh.Text = dr["GioiTinh"].ToString();
            txtNgaySinh.Text = dr["NgaySinh"].ToString() == "" ? "" : Convert.ToDateTime(dr["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
            txtNgayVaoLam.Text = dr["NgayVaoLam"].ToString() == "" ? "" : Convert.ToDateTime(dr["NgayVaoLam"].ToString()).ToString("dd/MM/yyyy");
            txtNgoaiNgu.Text = dr["TenCCNN"].ToString();
            txtTinHoc.Text = dr["TenCCTH"].ToString();
            txtTinhThanh.Text = dr["TenTinhThanh"].ToString();
            txtTonGiao.Text = dr["TenTonGiao"].ToString();
            txtSoCMND.Text = dr["SoCMND"].ToString();
            txtSDT.Text = dr["SDT"].ToString();
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
                PictureBox1.Image = null;
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                System.IO.FileStream fileStream = fileInfo.OpenRead();
                PictureBox1.Image = resizeImage(System.Drawing.Image.FromStream(fileStream), new Size(150, 200));
                fileStream.Close();
            }


        }

    }
}
