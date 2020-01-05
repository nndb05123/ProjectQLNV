using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;
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
                string queryTamUng = @"select  a.NhanVienID, b.TamUng
                            From NhanVien a 
                            left join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'";
                DataTable data_NhanVienTamUng = Core.Core.GetData(queryTamUng);
                string queryHieuSuat = @"select a.NhanVienID,b.HieuSuat
                                    From NhanVien a
                                    Left join DanhGiaHieuSuat b on a.NhanVienID =b.NhanVienID and b.Thang='" + time + @"'";
                DataTable data_DanhGiaHieuSuat = Core.Core.GetData(queryHieuSuat);
                String sql = "";
                int idNhanvien;
                DataTable data_BanKeLuong = new DataTable();
                data_BanKeLuong.Columns.Add("NhanVienID");
                data_BanKeLuong.Columns.Add("MaNV");
                data_BanKeLuong.Columns.Add("TenNV");
                data_BanKeLuong.Columns.Add("TamUng");
                data_BanKeLuong.Columns.Add("ThangTamUng");
                data_BanKeLuong.Columns.Add("NgayCongChuan");
                data_BanKeLuong.Columns.Add("ThangKeLuong");
                data_BanKeLuong.Columns.Add("TrangThai");
                data_BanKeLuong.Columns.Add("ChiTietBanKeLuongID");
                data_BanKeLuong.Columns.Add("ThueThuNhapCaNhan");
                data_BanKeLuong.Columns.Add("NgayTinhLuong");
                data_BanKeLuong.Columns.Add("TienLuongCung");
                data_BanKeLuong.Columns.Add("PhuCap");
                data_BanKeLuong.Columns.Add("HieuSuat");
                data_BanKeLuong.Columns.Add("TongLuong");
                data_BanKeLuong.Columns.Add("ThucLinh");
                for (int i = 0; i < data_NhanVienTamUng.Rows.Count; i++)
                {
                    idNhanvien = int.Parse(data_NhanVienTamUng.Rows[i][0].ToString());
                    if (!string.IsNullOrEmpty(data_DanhGiaHieuSuat.Rows[i][1].ToString()))
                    {
                        if (!string.IsNullOrEmpty(data_NhanVienTamUng.Rows[i][1].ToString()))
                        {
                            sql = @"select a.NhanVienID, a.MaNV, a.TenNV, b.TamUng, b.ThangTamUng, c.NgayCongChuan, c.ThangKeLuong,
                                c.TrangThai, c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong, f.TienLuongCung, f.PhuCap*f.TienLuongCung/100 as PhuCap, g.HieuSuat,
                                f.TienLuongCung*g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) TongLuong,
                                f.TienLuongCung *g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) - b.TamUng ThucLinh 
                            From NhanVien a 
                            left join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            inner join DanhGiaHieuSuat g on g.NhanVienID = a.NhanVienID and g.Thang = '" + time + @"'
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + @"'Where a.NhanVienID='" + idNhanvien + @"'";
                            DataTable dt = new DataTable();
                            dt = Core.Core.GetData(sql);
                            foreach (DataRow dr in dt.Rows)
                            {
                                data_BanKeLuong.Rows.Add(dr.ItemArray);
                            }

                        }
                        else
                        {
                            sql = @"select a.NhanVienID, a.MaNV, a.TenNV, b.TamUng, b.ThangTamUng, c.NgayCongChuan, c.ThangKeLuong,
                                c.TrangThai, c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong, f.TienLuongCung, f.PhuCap*f.TienLuongCung/100 as PhuCap, g.HieuSuat,
                                f.TienLuongCung*g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) TongLuong,
                                f.TienLuongCung *g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) ThucLinh 
                            From NhanVien a 
                            left join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            inner join DanhGiaHieuSuat g on g.NhanVienID = a.NhanVienID and g.Thang = '" + time + @"'
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + @"'Where a.NhanVienID='" + idNhanvien + @"'";
                            DataTable d2t = new DataTable();
                            d2t = Core.Core.GetData(sql);
                            foreach (DataRow dr in d2t.Rows)
                            {
                                data_BanKeLuong.Rows.Add(dr.ItemArray);
                            }
                        }

                    }
                    if (string.IsNullOrEmpty(data_DanhGiaHieuSuat.Rows[i][1].ToString()))
                    {
                        if (!string.IsNullOrEmpty(data_NhanVienTamUng.Rows[i][1].ToString()))
                        {
                            //MessageBox.Show(" Khoong hieu suat , co tam ung");
                            sql = @"select a.NhanVienID, a.MaNV, a.TenNV, b.TamUng, b.ThangTamUng, c.NgayCongChuan, c.ThangKeLuong,
                                c.TrangThai, c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong, f.TienLuongCung, f.PhuCap*f.TienLuongCung/100 as PhuCap,
                                f.TienLuongCung * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) TongLuong,
                                f.TienLuongCung * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) - b.TamUng ThucLinh 
                            From NhanVien a 
                            left join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + @"'Where a.NhanVienID='" + idNhanvien + @"'";
                            DataTable dt2 = new DataTable();
                            dt2 = Core.Core.GetData(sql);
                            foreach (DataRow dr in dt2.Rows)
                            {
                                data_BanKeLuong.Rows.Add(dr.ItemArray);
                            }

                        }
                        else
                        {
                            //MessageBox.Show(" Khoong hieu suat , khong tam ung");
                            sql = @"select a.NhanVienID, a.MaNV, a.TenNV, b.TamUng, b.ThangTamUng, c.NgayCongChuan, c.ThangKeLuong,
                                c.TrangThai, c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong, f.TienLuongCung, f.PhuCap*f.TienLuongCung/100 as PhuCap,
                                f.TienLuongCung * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) TongLuong,
                                f.TienLuongCung * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) ThucLinh 
                            From NhanVien a 
                            left join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID                   
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + @"'Where a.NhanVienID='" + idNhanvien + @"'";
                            DataTable d2t2 = new DataTable();
                            d2t2 = Core.Core.GetData(sql);
                            foreach (DataRow dr in d2t2.Rows)
                            {
                                data_BanKeLuong.Rows.Add(dr.ItemArray);
                            }
                        }
                    }


                }


                bindingSource1.DataSource = data_BanKeLuong;

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
                            ChiTietBanKeLuongDTO chiTietBanKeLuongDTO = new ChiTietBanKeLuongDTO();
                            chiTietBanKeLuongDTO.ChiTietBanKeLuongID = int.Parse(row.Row["ChiTietBanKeLuongID"].ToString());
                            ChiTietBanKeLuongBUS.Instance.UpdateStatusChiTietBanKeLuong(chiTietBanKeLuongDTO);
                            ChiTietBanKeLuongBUS.Instance.UpdateStatusChiTietBanKeLuongWithNhanVienAndTamUng(int.Parse(row.Row["NhanVienID"].ToString()), int.Parse(row.Row["ThangTamUng"].ToString()));
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
