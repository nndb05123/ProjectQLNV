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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable dt = NguoiDungBUS.Instance.GetNguoiDungFromTenDangNhap(txtTenDangNhap.Text.Trim());
            errorProvider1.Clear();
            if (txtTenDangNhap.Text=="" || txtMatKhauCu.Text==""|| txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
            }
            
            //else if (dt.Rows.Count >0)
            else if (dt.Rows[0]["MatKhau"].ToString() == Core.Security.EncryptMd5( txtMatKhauCu.Text.Trim()))
            {
                if(txtMatKhauMoi.Text==txtNhapLai.Text)
                {
                    NguoiDungBUS.Instance.UpdateMatKhau(txtTenDangNhap.Text.Trim(), txtMatKhauMoi.Text.Trim());
                    MessageBox.Show("Đã thay đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp nhau");
                }
            }
            else
            {
                errorProvider1.SetError(txtTenDangNhap,"Sai tên đăng nhập");
                errorProvider1.SetError(txtMatKhauCu, "Sai mật khẩu");
            }
        }
    }
}
