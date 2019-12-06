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
            string sql = "Select * from NguoiDung where TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau = '" + txtMatKhauCu.Text + "'";
            DataTable dt = Core.Core.GetData(sql);
            errorProvider1.Clear();
            if(txtTenDangNhap.Text=="" || txtMatKhauCu.Text==""|| txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
            }
            
            else if (dt.Rows.Count >0)
            {
                if(txtMatKhauMoi.Text==txtNhapLai.Text)
                {
                    sql = "Update NguoiDung set MatKhau='"+txtMatKhauMoi.Text+"' where TenDangNhap='"+txtTenDangNhap.Text+"' and MatKhau='"+txtMatKhauCu.Text+"' ";
                    Core.Core.RunSql(sql);
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
