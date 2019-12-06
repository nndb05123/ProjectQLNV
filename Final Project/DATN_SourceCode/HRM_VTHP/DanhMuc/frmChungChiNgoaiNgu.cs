using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM_VTHP.Core;


namespace HRM_VTHP.DanhMuc
{
    public partial class frmChungChiNgoaiNgu : Form
    {
        int kt = 0;
        int NgoaiNguID = 0;
        public frmChungChiNgoaiNgu()
        {
            InitializeComponent();
        }

        private void frmChungChiNgoaiNgu_Load(object sender, EventArgs e)
        {
            Reset();
            Load_DuLieu();
        }
        void Reset()
        {
            txtNgoaiNgu.Text = "";
            txtNgoaiNgu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
        }
        void Load_DuLieu()
        {
            string sql = "Select * from NgoaiNgu";
            DataTable dt = Core.Core.GetData(sql);
            grdNgoaiNgu.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            txtNgoaiNgu.Enabled = true;
            txtNgoaiNgu.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            txtNgoaiNgu.Enabled = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if(txtNgoaiNgu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chứng chỉ ngoại ngữ");
                }
                else
                {
                    string sql = "Insert into NgoaiNgu(TenCCNN) values (N'" + txtNgoaiNgu.Text + "')";
                    if (Core.Core.RunSql(sql) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }
                    else
                    {
                        Load_DuLieu();
                    }
                }
            }
            else
            {
                //Update du lieu
                string sql = "";
                sql = "Update NgoaiNgu set TenCCNN = N'" + txtNgoaiNgu.Text + "' where NgoaiNguID = '" + NgoaiNguID + "'";
                Core.Core.RunSql(sql);
                Load_DuLieu();
            }
            Reset();

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HoSoNhanVien where NgoaiNguID = '" + NgoaiNguID + "'";
            DataTable dt = Core.Core.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                sql = "Delete NgoaiNgu where NgoaiNguID = '" + NgoaiNguID + "'";
                Core.Core.RunSql(sql);
                Load_DuLieu();
                Reset();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            NgoaiNguID = int.Parse(gridView1.GetFocusedRowCellValue("NgoaiNguID").ToString());
            txtNgoaiNgu.Text = gridView1.GetFocusedRowCellValue("TenCCNN").ToString();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
