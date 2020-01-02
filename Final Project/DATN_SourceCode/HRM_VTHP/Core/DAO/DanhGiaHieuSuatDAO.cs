using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class DanhGiaHieuSuatDAO
    {
        private static DanhGiaHieuSuatDAO instance;

        internal static DanhGiaHieuSuatDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhGiaHieuSuatDAO(); return HRM_VTHP.Core.DAO.DanhGiaHieuSuatDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.DanhGiaHieuSuatDAO.instance = value;
            }
        }
        public string LoadData_DanhGiaHieuSuat()
        {
            string sql = @"select a.NhanVienID, b.TenNV, a.HieuSuat, a.Thang, a.DanhGiaHieuSuatID, c.BoPhanID from DanhGiaHieuSuat a 
                           inner join NhanVien b on a.NhanVienID = b.NhanVienID
                           inner join NhanVienBoPhan c on a.NhanVienID = c.NhanVienID";
            return sql;
        }
        public string Add_DanhGiaHieuSuat(DanhGiaHieuSuatDTO danhGiaHieuSuatDTO)
        {
            string sql = "Insert into DanhGiaHieuSuat(Thang, NhanVienID, HieuSuat)" + " values ('" + danhGiaHieuSuatDTO.Thang + "', '" + danhGiaHieuSuatDTO.NhanVienID + "', '" + danhGiaHieuSuatDTO.HieuSuat + "')";
            return sql;
        }
        public string Update_DanhGiaHieuSuat(DanhGiaHieuSuatDTO danhGiaHieuSuatDTO,int DanhGiaHieuSuatID)
        {
            string sql = "Update DanhGiaHieuSuat set NhanVienID ='" + danhGiaHieuSuatDTO.NhanVienID + "', Thang = '" + danhGiaHieuSuatDTO.Thang + "', HieuSuat = '" + danhGiaHieuSuatDTO.HieuSuat + "' where DanhGiaHieuSuatID = '" + DanhGiaHieuSuatID + "'";
            return sql;

        }
        public string Delete_DanhGiaHieuSuat(int DanhGiaHieuSuatID)
        {
            string sql = "Delete DanhGiaHieuSuat where DanhGiaHieuSuatID = '" + DanhGiaHieuSuatID + "'";
            return sql;
        }
    }
}
