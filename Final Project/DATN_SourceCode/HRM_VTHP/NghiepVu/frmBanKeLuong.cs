using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.NghiepVu
{
    public partial class frmBanKeLuong : Form
    {
        public frmBanKeLuong()
        {
            InitializeComponent();
        }

        private void frmBanKeLuong_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {

            try
            {

                string time = dtpThang.Value.Year.ToString() + dtpThang.Value.Month.ToString("D2");
                string sql = @"select a.NhanVienID, a.MaNV, a.TenNV, b.TamUng, b.ThangTamUng, c.NgayCongChuan, c.ThangKeLuong,
                                c.TrangThai, c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong, f.TienLuongCung, f.PhuCap*f.TienLuongCung/100 as PhuCap, g.HieuSuat,
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) TongLuong,
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) - b.TamUng ThucLinh 
                            From NhanVien a 
                            inner join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            inner join DanhGiaHieuSuat g on g.NhanVienID = a.NhanVienID and g.Thang = '" + time + @"'
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + "'";
                DataTable dt = Core.Core.GetData(sql);
                bindingSource1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không tính được lương!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView row = gridView1.GetRow(i) as DataRowView;
                if (row != null)
                {
                    string ChiTietBanKeLuongID = row.Row["ChiTietBanKeLuongID"].ToString();
                    int NgayCongChuan = row.Row["NgayCongChuan"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayCongChuan"]);
                    int NhanVienID = Convert.ToInt32(row.Row["NhanVienID"]);
                    decimal HieuSuat = row.Row["HieuSuat"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["HieuSuat"]);
                    decimal TienLuongCung = row.Row["TienLuongCung"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["TienLuongCung"]);
                    decimal PhuCap = row.Row["PhuCap"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["PhuCap"]);
                    decimal TamUng = row.Row["TamUng"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["TamUng"]);
                    int NgayTinhLuong = row.Row["NgayTinhLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayTinhLuong"]);
                    int TongLuong = row.Row["TongLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["TongLuong"]);
                    decimal ThueThuNhapCaNhan = row.Row["ThueThuNhapCaNhan"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["ThueThuNhapCaNhan"]);
                    decimal ThucLinh = row.Row["ThucLinh"] == DBNull.Value ? 0 : Convert.ToDecimal(row.Row["ThucLinh"]);
                    string TrangThai = row.Row["TrangThai"].ToString();
                    if (ChiTietBanKeLuongID != "" && TrangThai == "1")
                    {
                        string sql = @"UPDATE ChiTietBanKeLuong
                        SET
                            [TienLuongCung] = '" + TienLuongCung + @"'
                            ,[HieuSuat] = '" + HieuSuat + @"'
                            ,[PhuCap] = '" + PhuCap + @"'
                            ,[TamUng] = '" + TamUng + @"'
                            ,[TongLuong] = '" + TongLuong + @"' 
                            ,[ThueThuNhapCaNhan] = '" + ThueThuNhapCaNhan + @"'
                            ,[ThucLinh] = '" + ThucLinh + @"'   
                        WHERE ChiTietBanKeLuongID = '" + ChiTietBanKeLuongID + "'";
                        Core.Core.RunSql(sql);
                        dem++;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Không có bản kê lương nào để lưu!");
                    //}
                }
            }
            
            if(dem == 0)
            {
                MessageBox.Show("Không có bản kê lương nào thay đổi");
            }
            else
            {
                MessageBox.Show("Lưu " + dem + " bản kê lương");
            }
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            try
            {
                int dem = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRowView row = gridView1.GetRow(i) as DataRowView;
                    if (row != null)
                    {
                        if (row.Row["TrangThai"].ToString() == "1")
                        {
                            string ChiTietBanKeLuongID = row.Row["ChiTietBanKeLuongID"].ToString();

                            string sql = @"Update ChiTietBanKeLuong Set TrangThai = 2 where ChiTietBanKeLuongID = '" + ChiTietBanKeLuongID + "'";
                            Core.Core.RunSql(sql);

                            sql = @"update ChiTietTamUng set TrangThaiID = 2 Where NhanVienID = '"+ row.Row["NhanVienID"].ToString() + "' And ThangTamUng = '"+ row.Row["ThangTamUng"].ToString() + "'";
                            Core.Core.RunSql(sql);
                            dem++;
                        }

                    }
                }
                //btnNop_Click(null, null);
                if (dem == 0)
                {
                    MessageBox.Show("Không có bản kê lương nào được nộp!");
                }
                else
                    MessageBox.Show("Nộp " + dem.ToString() + " bản kê lương thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nộp chấm công!");
            }
        }
    }
}
