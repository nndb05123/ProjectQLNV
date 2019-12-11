using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.BaoCao
{
    public partial class frmBaoCaoHoSoMotNV : Form
    {
        public frmBaoCaoHoSoMotNV()
        {
            InitializeComponent();
        }

        private void frmBaoCaoHoSoMotNV_Load(object sender, EventArgs e)
        {
            string sql = @"Select * From BoPhan Order By TenBoPhan";
            DataTable dt = Core.Core.GetData(sql);

            cbbDonVi.DataSource = dt;
            cbbDonVi.DisplayMember = "TenBoPhan";
            cbbDonVi.ValueMember = "BoPhanID";

            LayDanhSachNV();
        }

        public void LayDanhSachNV()
        {
            string sql = @"Select distinct a.NhanVienID, a.TenNV 
                    from NhanVien a join NhanVienBoPhan b on b.NhanVienID = a.NhanVienID
                    Where b.BoPhanID = " + cbbDonVi.SelectedValue + @"
                    Order by a.TenNV";
            DataTable dt = Core.Core.GetData(sql);

            cbbNhanVien.DataSource = dt;
            cbbNhanVien.DisplayMember = "TenNV";
            cbbNhanVien.ValueMember = "NhanVienID";
            
        }

        private void cbbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDanhSachNV();
        }

        protected void LoadBaoCao()
        {
            try
            {
                string sql = @"select a.TenNV, a.DiaChi, a.Email, a.MaNV, a.NgaySinh, a.SDT, b.ImagePath,
                                    a.SoCMND, b.NgayVaoLam, c.TenDanToc, d.TenBangCap, e.TenCCNN, 
                                    f.TenCCTH, g.TenTinhThanh, h.TenTonGiao, i.GioiTinh from NhanVien a 
                                inner join HoSoNhanVien b on a.NhanVienID = b.NhanVienID
                                inner join DanToc c on b.DanTocID = c.DanTocID
                                inner join BangCap d on b.BangCapID = d.BangCapID
                                inner join NgoaiNgu e on b.NgoaiNguID = e.NgoaiNguID
                                inner join TinHoc f on b.TinHocID = f.TinHocID
                                inner join TinhThanh g on b.TinhThanhID = g.TinhThanhID
                                inner join TonGiao h on b.TonGiaoID = h.TonGiaoID
                                inner join GioiTinh i on i.GioiTinhID = a.GioiTinhID
                                where a.NhanVienID = " + cbbNhanVien.SelectedValue + @"";

                DataTable dt = Core.Core.GetData(sql);
                if(dt != null && dt.Rows.Count > 0)
                {

                    BaoCaoHoSoMotNV reports = new BaoCaoHoSoMotNV(dt);
                    reports.Parameters["BoPhanID"].Value = cbbDonVi.SelectedValue;
                    reports.Parameters["NhanVienID"].Value = cbbNhanVien.SelectedValue;
                    documentViewer1.DocumentSource = reports;
                    reports.CreateDocument();
                }else
                {
                    //MessageBox.Show("Không có dữ liệu!");
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
