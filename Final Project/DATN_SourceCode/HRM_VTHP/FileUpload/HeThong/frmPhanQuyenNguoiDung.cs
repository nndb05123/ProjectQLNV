using HRM_VTHP.Core.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.HeThong
{
    public partial class frmPhanQuyenNguoiDung : Form
    {
        public frmPhanQuyenNguoiDung()
        {
            InitializeComponent();
        }

        private void frmPhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dt = BoPhanBUS.Instance.LoadAllBoPhan();
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNhanVien.DataSource = null;
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            DataTable dtNhanVien = QuyenNguoiDungBUS.Instance.GetNhanVienFromBoPhan(BoPhanID);
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbNhanVien.SelectedValue != null)
            {
                cmbNguoiDung.DataSource = null;
                string NhanVienID = cmbNhanVien.SelectedValue.ToString();
                DataTable dtNguoiDung = QuyenNguoiDungBUS.Instance.GetNguoiDungFromNhanVien(NhanVienID);
                cmbNguoiDung.DataSource = dtNguoiDung;
                cmbNguoiDung.ValueMember = "NguoiDungID";
                cmbNguoiDung.DisplayMember = "TenDangNhap";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string NguoiDungID = cmbNguoiDung.SelectedValue.ToString();
                string sql = "delete from QuyenNguoiDung where NguoiDungID = '" + cmbNguoiDung.SelectedValue + "'";
                QuyenNguoiDungBUS.Instance.DeleteQuyenNguoiDung(NguoiDungID);
                if (cbQLHT.Checked == true)
                {
                    QuyenNguoiDungBUS.Instance.ThemQuyenNguoiDung(NguoiDungID, "1");
                }
                if (cbQLDanhMuc.Checked == true)
                {
                    QuyenNguoiDungBUS.Instance.ThemQuyenNguoiDung(NguoiDungID, "2");
                }
                if (cbQLNhanSu.Checked == true)
                {
                    QuyenNguoiDungBUS.Instance.ThemQuyenNguoiDung(NguoiDungID, "3");
                }
                if (cbQLTienLuong.Checked == true)
                {
                    QuyenNguoiDungBUS.Instance.ThemQuyenNguoiDung(NguoiDungID, "4");
                }
                if (cbTKBaoCao.Checked == true)
                {
                    QuyenNguoiDungBUS.Instance.ThemQuyenNguoiDung(NguoiDungID, "5");
                }
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu");
            }
            
        }

        private void cmbNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (hoi == DialogResult.Yes)
            this.Close();
        }
    }
}
