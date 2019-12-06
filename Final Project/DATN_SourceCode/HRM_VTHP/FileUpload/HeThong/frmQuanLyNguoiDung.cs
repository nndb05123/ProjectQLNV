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
    public partial class frmQuanLyNguoiDung : Form
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        int kt = 0;
        int NguoiDungID = 0;
        void Load_DL()
        {
            string sql = @"select a.NguoiDungID, a.TenDangNhap, a.MatKhau, a.QuanTri, b.NhanVienID, b.MaNV, b.TenNV, c.BoPhanID, d.TenBoPhan from NguoiDung a 
                            inner join NhanVien b on a.NhanVienID = b.NhanVienID
                            inner join NhanVienBoPhan c on a.NhanVienID = c.NhanVienID
                            inner join BoPhan d on d.BoPhanID = c.BoPhanID";
            DataTable dt = Core.Core.GetData(sql);
            grdNguoiDung.DataSource = dt;
        }
        void Reset()
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            cbQuanTri.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BoPhan";
            DataTable dt = Core.Core.GetData(sql);
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            cbQuanTri.Enabled = true;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            cbQuanTri.Enabled = true;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            DataTable dtNhanVien = Core.Core.GetData(sql);
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                if(txtTenDangNhap.Text =="" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu");
                }
                else
                {
                    string matkhau = Core.Security.EncryptMd5(txtMatKhau.Text);
                    string sql = "Insert into NguoiDung(TenDangNhap, MatKhau, QuanTri, NhanVienID) values ('" + txtTenDangNhap.Text + "', '" + matkhau + "', '"+cbQuanTri.Checked+"', " + cmbNhanVien.SelectedValue + ")";
                    if (Core.Core.RunSql(sql) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }
                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                string sql = "";
                if(txtMatKhau.Text.Trim() != "")
                {
                    string matkhau = Core.Security.EncryptMd5(txtMatKhau.Text);
                    sql = "Update NguoiDung set TenDangNhap = '" + txtTenDangNhap.Text + "', MatKhau = '" + matkhau + "', QuanTri = '" + cbQuanTri.Checked + "', NhanVienID = " + cmbNhanVien.SelectedValue + " where NguoiDungID = '" + NguoiDungID + "'";
                }else
                {
                    sql = "Update NguoiDung set TenDangNhap = '" + txtTenDangNhap.Text + "', QuanTri = '" + cbQuanTri.Checked + "', NhanVienID = " + cmbNhanVien.SelectedValue + " where NguoiDungID = '" + NguoiDungID + "'";
                }
                
                Core.Core.RunSql(sql);
                Load_DL();
                txtMatKhau.Text = "";
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from NguoiDung where NguoiDungID = '" + NguoiDungID + "'";
            Core.Core.RunSql(sql);
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtTenDangNhap.Text = gridView1.GetFocusedRowCellValue("TenDangNhap").ToString();
            //.Text = gridView1.GetFocusedRowCellValue("MatKhau").ToString();
            NguoiDungID = int.Parse(gridView1.GetFocusedRowCellValue("NguoiDungID").ToString());
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
            cbQuanTri.Checked = Boolean.Parse(gridView1.GetFocusedRowCellValue("QuanTri").ToString());
        }
    }
}
