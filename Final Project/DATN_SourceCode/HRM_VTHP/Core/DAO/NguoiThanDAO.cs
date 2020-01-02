using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NguoiThanDAO
    {
        private static NguoiThanDAO instance;

        internal static NguoiThanDAO Instance
        {
            get
            {
                if (instance == null) instance = new NguoiThanDAO(); return HRM_VTHP.Core.DAO.NguoiThanDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NguoiThanDAO.instance = value;
            }
        }

        public string LoadAllThanNhan()
        {
            string sql = @"select a.NhanVienID, a.NguoiThanID, b.TenNV, b.MaNV, c.MoiQuanHeID, c.TenMoiQuanHe, a.TenNguoiThan, a.NgheNghiep, a.SDT, a.DiaChi, d.BoPhanID from NguoiThan a 
                           inner join NhanVien b on a.NhanVienID = b.NhanVienID
                           inner join MoiQuanHe c on a.MoiQuanHeID = c.MoiQuanHeID
                           inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID";
            return sql;
        }
        public string LoadData_BoPhan()
        {
            string sql = "Select * from BoPhan";
            return sql;
        }
        public string LoadData_MoiQuanHe()
        {
            string sql = "Select * from MoiQuanHe";
            return sql;
        }
        public string LoadData_NhanVien_BoPhan(String BoPhanID)
        {
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            return sql;
        }
        public string ADD_NguoiThan(NguoiThanDTO nguoiThanDTO)
        {
            string sql = "Insert into NguoiThan(NhanVienID, MoiQuanHeID, TenNguoiThan, NgheNghiep, SDT, DiaChi) values ('" + nguoiThanDTO.NhanVienID + "', '" + nguoiThanDTO.MoiQuanHeID + "', N'" + nguoiThanDTO.TenNguoiThan + "', N'" + nguoiThanDTO.NgheNghiep + "', '" + "" + nguoiThanDTO.SDT + "', N'" + nguoiThanDTO.DiaChi + "')";
            return sql;
        }
        public string Update_NguoiThan(NguoiThanDTO nguoiThanDTO,int  NguoiThanID)
        {
            string sql = "Update NguoiThan set NhanVienID ='" + nguoiThanDTO.NhanVienID + "', MoiQuanHeID = '" + nguoiThanDTO.MoiQuanHeID + "', TenNguoiThan = N'" + nguoiThanDTO.TenNguoiThan + "', NgheNghiep = N'" + nguoiThanDTO.NgheNghiep + "', SDT = '" + nguoiThanDTO.SDT + "', DiaChi = '" + nguoiThanDTO.DiaChi + "' where NguoiThanID = '" + NguoiThanID + "'";
            return sql;
        }
        public string Delete_NguoiThan(int NguoiThanID)
        {
            string sql = "Delete NguoiThan where NguoiThanID = '" + NguoiThanID + "'";
            return sql;
        }
    }
}
