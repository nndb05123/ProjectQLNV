using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;

namespace HRM_VTHP.DanhMuc
{
    public partial class frmBangCap : Form
    {
        public frmBangCap()
        {
            InitializeComponent();
        }
        int kt = 0;
        int BangCapID = 0;
        void Load_DL()
        {
            DataTable dt = BangCapBUS.Instance.LoadAllBangCap();
            grdBangCap.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtBangCap.Text = "";
            txtBangCap.Enabled = false;
        }

        private void frmBangCap_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtBangCap.Text = "";
            txtBangCap.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtBangCap.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                if (txtBangCap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bằng cấp");
                }
                else
                {
                    BangCapDTO bangCapDTO = new BangCapDTO();
                    bangCapDTO.TenBangCap = txtBangCap.Text.Trim();
                    if(BangCapBUS.Instance.ThemBangCap(bangCapDTO) == -1)
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
                if (txtBangCap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bằng cấp");
                } else
                {
                    BangCapDTO bangCapDTO = new BangCapDTO();
                    bangCapDTO.TenBangCap = txtBangCap.Text.Trim();
                    bangCapDTO.BangCapID = BangCapID;
                    BangCapBUS.Instance.UpdateBangCap(bangCapDTO);
                    Load_DL();
                }

            }
            Reset();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BangCapDTO bangCap = new BangCapDTO();
            bangCap.TenBangCap = txtBangCap.Text.Trim();
            bangCap.BangCapID = BangCapID;
            DataTable dt = BangCapBUS.Instance.LoadBangCapFromHoSoNhanVien(bangCap);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                BangCapBUS.Instance.DeleteBangCap(bangCap);
                Load_DL();
                Reset();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            BangCapID = int.Parse(gridView1.GetFocusedRowCellValue("BangCapID").ToString());
            txtBangCap.Text = gridView1.GetFocusedRowCellValue("TenBangCap").ToString();
        }

        private void txtBangCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
