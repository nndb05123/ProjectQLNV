using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            LoadBoPhan();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bỏ
        }
        private void LoadBoPhan()
        {
            try
            {

                DataTable dt = ChamCongBUS.Instance.LoadData_BoPhan();
                cmbBoPhan.DataSource = dt;
                cmbBoPhan.ValueMember = "BoPhanID";
                cmbBoPhan.DisplayMember = "TenBoPhan";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách bộ phận!");
            }
        }
        private void LoadItems()
        {
            //bỏ
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //bỏ
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                ChamCongDTO chamCongDTO = new ChamCongDTO();
                chamCongDTO.Thang = dtpThang.Value.ToString("yyyyMM");
                chamCongDTO.BoPhanID = int.Parse(cmbBoPhan.SelectedValue.ToString());
                DataTable dt = ChamCongBUS.Instance.LoadData_Show_ChamCong(chamCongDTO);
                bindingSource1.DataSource = dt;

                // Customize Cell Status
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách chấm công!");
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
                    string ChamCongID = row.Row["ChamCongID"].ToString();
                    int NgayCongChuan = row.Row["NgayCongChuan"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayCongChuan"]);
                    int NhanVienID = Convert.ToInt32(row.Row["NhanVienID"]);
                    int NgayDiLam = row.Row["NgayDiLam"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayDiLam"]);
                    int NgayNghiLe = row.Row["NgayNghiLe"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayNghiLe"]);
                    int NgayNghiPhepTinhLuong = row.Row["NgayNghiPhepTinhLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayNghiPhepTinhLuong"]);
                    int NgayKhongLuong = row.Row["NgayKhongLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayKhongLuong"]);
                    int NgayTinhLuong = row.Row["NgayTinhLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayTinhLuong"]);
                    int NgayChamCong = row.Row["NgayChamCong"] == DBNull.Value ? 0 : Convert.ToInt32(row.Row["NgayChamCong"]);
                    string GhiChu = row.Row["GhiChu"].ToString();

                    string TrangThai = row.Row["TrangThai"].ToString();

                    if (ChamCongID == "")
                    {
                        // thực hiện lệnh insert
                        string sql = @"INSERT INTO [ChamCong]
                                           ([Thang]
                                           ,[NgayCongChuan]
                                           ,[BoPhanID]
                                           ,[NhanVienID]
                                           ,[NgayDiLam]
                                           ,[NgayNghiLe]
                                           ,[NgayNghiPhepTinhLuong]
                                           ,[NgayKhongLuong]
                                           ,[NgayTinhLuong]
                                           ,[NgayChamCong]
                                           ,[GhiChu]
                                           ,[TrangThai])
                                     VALUES(
                                           '" + dtpThang.Value.ToString("yyyyMM") + @"'
                                           ,'" + NgayCongChuan + @"'
                                           ,'" + cmbBoPhan.SelectedValue + @"'
                                           ,'" + NhanVienID + @"'
                                           ,'" + NgayDiLam + @"'
                                           ,'" + NgayNghiLe + @"'
                                           ,'" + NgayNghiPhepTinhLuong + @"'
                                           ,'" + NgayKhongLuong + @"'
                                           ,'" + NgayTinhLuong + @"'
                                           ,'" + NgayChamCong + @"'
                                           ,'" + GhiChu + @"'
                                           ,'1')";
                        Core.Core.RunSql(sql);
                        dem++;
                    }
                    else
                    {
                        if (TrangThai == "1")
                        {
                            string sql = @"UPDATE [ChamCong]
                                       SET[Thang] = '" + dtpThang.Value.ToString("yyyyMM") + @"'
                                      ,[NgayCongChuan] = '" + NgayCongChuan + @"'
                                      ,[BoPhanID] = '" + cmbBoPhan.SelectedValue + @"'
                                      ,[NhanVienID] = '" + NhanVienID + @"'
                                      ,[NgayDiLam] = '" + NgayDiLam + @"'
                                      ,[NgayNghiLe] =  '" + NgayNghiLe + @"'
                                      ,[NgayNghiPhepTinhLuong] = '" + NgayNghiPhepTinhLuong + @"'
                                      ,[NgayKhongLuong] = '" + NgayKhongLuong + @"'
                                      ,[NgayTinhLuong] = '" + NgayTinhLuong + @"'
                                      ,[NgayChamCong] = '" + NgayChamCong + @"'
                                      ,[GhiChu] = '" + GhiChu + @"'
                                 WHERE ChamCongID = '" + ChamCongID + "'";
                            Core.Core.RunSql(sql);
                            dem++;
                        }
                    }
                }
            }
            btnHienThi_Click(null, null);
            if (dem == 0)
            {
                MessageBox.Show("Không có bản ghi nào thay đổi");
            }
            else
            {
                MessageBox.Show("Lưu " + dem + " bản ghi thành công!");
            }

        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            // update toan bo ve trang thai = 2
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn nộp bản chấm công này không. Nếu nộp bạn sẽ không thể thay đổi dữ liệu chấm công!", "Thông báo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int dem = 0;
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRowView row = gridView1.GetRow(i) as DataRowView;
                        if (row != null)
                        {
                            if (row.Row["TrangThai"].ToString() == "1")
                            {

                                string ChamCongID = row.Row["ChamCongID"].ToString();

                                string sql = @"Update ChamCong Set TrangThai = 2 where ChamCongID = '" + ChamCongID + "'";
                                Core.Core.RunSql(sql);
                                dem++;

                                // insert sang bảng ChiTietBanKeLuong
                                string ThangKeLuong = row.Row["Thang"].ToString();
                                string NhanVienID = row.Row["NhanVienID"].ToString();
                                string NgayCongChuan = row.Row["NgayCongChuan"].ToString();
                                string NgayTinhLuong = row.Row["NgayTinhLuong"].ToString();

                                sql = @"INSERT INTO [dbo].[ChiTietBanKeLuong]
                                           ([ThangKeLuong]
                                           ,[NhanVienID]
                                           ,[TienLuongCung]
                                           ,[HieuSuat]
                                           ,[NgayCongChuan]
                                           ,[NgayTinhLuong]
                                           ,[PhuCap]
                                           ,[TamUng]
                                           ,[ThucLinh]
                                           ,[TongLuong]
                                           ,[ThueThuNhapCaNhan]
                                           ,[TrangThai])
                                     VALUES
                                           ('" + ThangKeLuong + @"'
                                           ,'" + NhanVienID + @"'
                                           ,NULL
                                           ,NULL
                                           ,'" + NgayCongChuan + @"'
                                           ,'" + NgayTinhLuong + @"'
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,'1')";
                                Core.Core.RunSql(sql);
                            }
                        }
                    }

                    btnHienThi_Click(null, null);
                    if (dem == 0)
                    {
                        MessageBox.Show("Không có bản ghi nào được nộp!");
                    }
                    else
                    {

                        MessageBox.Show("Nộp " + dem.ToString() + " bản thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nộp chấm công!");
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            //if (e.RowHandle == view.FocusedRowHandle) return;
            if (e.Column.FieldName != "TrangThai") return;
            // Fill a cell
            if (e.CellValue != null && e.CellValue.ToString().Trim() != "" && Convert.ToInt32(e.CellValue) == 2)
            {
                Image image = Image.FromFile("c:\\lock.png");
                e.Graphics.DrawImage(image, new Point(e.Bounds.Location.X + 35, e.Bounds.Location.Y));
            }
            if (e.CellValue != null && e.CellValue.ToString().Trim() != "" && Convert.ToInt32(e.CellValue) == 1)
            {
                Image image = Image.FromFile("c:\\unlock.png");
                e.Graphics.DrawImage(image, new Point(e.Bounds.Location.X + 35, e.Bounds.Location.Y));
            }
        }
    }
}
