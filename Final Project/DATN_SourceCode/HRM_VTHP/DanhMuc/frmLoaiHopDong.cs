using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.DanhMuc
{
    public partial class frmLoaiHopDong : Form
    {
        public frmLoaiHopDong()
        {
            InitializeComponent();
        }
        int kt = 0;
        int LoaiHopDongID = 0;
        void Load_DL()
        {
            string sql = "Select * from LoaiHopDong";
            DataTable dt = Core.Core.GetData(sql);
            grdLoaiHopDong.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtLoaiHopDong.Text = "";
            txtLoaiHopDong.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtLoaiHopDong.Text = "";
            txtLoaiHopDong.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
            txtLoaiHopDong.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            { 
                if(txtLoaiHopDong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập loại hợp đồng");
                }
                else
                {
                    string sql = "Insert into LoaiHopDong(TenLoaiHopDong) values(N'" + txtLoaiHopDong.Text + "')";
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
                string sql = "Update LoaiHopDong set TenLoaiHopDong = N'" + txtLoaiHopDong.Text + "' where LoaiHopDongID = '" + LoaiHopDongID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HopDong where LoaiHopDongID = '"+LoaiHopDongID+"'";
            DataTable dt = Core.Core.GetData(sql);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hợp đồng");
            }
            else
            {
                sql = "Delete LoaiHopDong where LoaiHopDongID = '" + LoaiHopDongID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
            
        }

        private void frmLoaiHopDong_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoaiHopDongID = int.Parse(gridView1.GetFocusedRowCellValue("LoaiHopDongID").ToString());
            txtLoaiHopDong.Text = gridView1.GetFocusedRowCellValue("TenLoaiHopDong").ToString();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
