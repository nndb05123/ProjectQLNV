using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class ChamCongDAO
    {
        private static ChamCongDAO instance;

        internal static ChamCongDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChamCongDAO(); return HRM_VTHP.Core.DAO.ChamCongDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.ChamCongDAO.instance = value;
            }
        }
        public string LoadData_BoPhan()
        {
            string sql = @"Select BoPhanID, TenBoPhan From BoPhan Order by TenBoPhan";
            return sql;
        }
        public string LoadData_Show_ChamCong(ChamCongDTO chamCongDTO)
        {
            string sql = @"select a.BoPhanID, a.NhanVienID, b.MaNV, b.TenNV, c.ChamCongID,c.NgayChamCong, c.NgayCongChuan,c.NgayDiLam,c.NgayKhongLuong, c.NgayNghiLe, c.NgayNghiPhepTinhLuong, c.NgayTinhLuong,
		                    c.ChamCongID, c.GhiChu, c.TrangThai, c.Thang
                            from NhanVienBoPhan a inner join NhanVien b on a.NhanVienID = b.NhanVienID
                            left join ChamCong c on c.BoPhanID = a.BoPhanID and c.NhanVienID = a.NhanVienID and c.Thang = '" + chamCongDTO.Thang + @"'
                            Where a.BoPhanID = '" + chamCongDTO.BoPhanID + "'";
            return sql;
        }
    }
}
