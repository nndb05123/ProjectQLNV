using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class KhenThuongKyLuatDAO
    {
        private static KhenThuongKyLuatDAO instance;

        internal static KhenThuongKyLuatDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhenThuongKyLuatDAO(); return HRM_VTHP.Core.DAO.KhenThuongKyLuatDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.KhenThuongKyLuatDAO.instance = value;
            }
        }
        public string LoadData_KhenThuongKyLuat()
        {
            string sql = @"select f.KhenThuongKyLuatID, f.NhanVienID, f.MaNV, f.TenNV, e.TenBoPhan, f.BoPhanID, f.TenLoaiQuyetDinh, f.LoaiQuyetDinhID, f.NgayQuyetDinh, f.GhiChu from BoPhan e
                        inner join
                        (select a.KhenThuongKyLuatID, a.NhanVienID, a.GhiChu, b.TenNV, b.MaNV, a.LoaiQuyetDinhID, a.NgayQuyetDinh, c.TenLoaiQuyetDinh, d.BoPhanID from KhenThuongKyLuat a
                        inner join NhanVien b on a.NhanVienID = b.NhanVienID inner join LoaiQuyetDinh c on a.LoaiQuyetDinhID = c.LoaiQuyetDinhID
                        inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as f on e.BoPhanID = f.BoPhanID";
            return sql;

        }
        public string Add_KhenThuongKyLuat(KhenThuongKyLuatDTO khenThuongKyLuatDTO)
        {
            string sql = "" + "Insert into KhenThuongKyLuat(NhanVienID," + " LoaiQuyetDinhID, NgayQuyetDinh, GhiChu) " + "values ('" + khenThuongKyLuatDTO.NhanVienID + "', '" + khenThuongKyLuatDTO.LoaiQuyetDinhID + "', '" + khenThuongKyLuatDTO.NgayQuyetDinh + "', N'" + khenThuongKyLuatDTO.GhiChu + "')";
            return sql;
        }
        public string Update_KhenThuongKyLuat(KhenThuongKyLuatDTO khenThuongKyLuatDTO,int KhenThuongKyLuatID)
        {
            string sql = "Update KhenThuongKyLuat set NhanVienID ='" + khenThuongKyLuatDTO.NhanVienID + "', LoaiQuyetDinhID = '" + khenThuongKyLuatDTO.LoaiQuyetDinhID + "', NgayQuyetDinh = '" + khenThuongKyLuatDTO.NgayQuyetDinh + "', GhiChu = N'" + khenThuongKyLuatDTO.GhiChu + "' where KhenThuongKyLuatID = '" + KhenThuongKyLuatID + "'";
            return sql;
        }
        public string Delete_KhenThuongKyLuat(int KhenThuongKyLuatID)
        {
            string sql = "Delete KhenThuongKyLuat where KhenThuongKyLuatID = '" + KhenThuongKyLuatID + "'";
            return sql;
        }

    }
}
