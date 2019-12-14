using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO(); return HRM_VTHP.Core.DAO.NhanVienDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NhanVienDAO.instance = value;
            }
        }

        public string LoadAllNhanVien()
        {
            string sql = @"Select a.NhanVienID, a.MaNV, a.TenNV, a.NgaySinh, b.GioiTinhID ,b.GioiTinh, a.DiaChi, a.SDT, a.SoCMND, a.Email, a.TrangThaiID 
                        from NhanVien a inner join GioiTinh b 
                        on a.GioiTinhID = b.GioiTinhID";
            return sql;
        }

        public string LoadAllGioiTinh()
        {
            string sql = "Select * from GioiTinh";
            return sql;
        }

        public string ThemNhanVien(NhanVienDTO nhanVienDTO)
        {
            string sql = "Insert into NhanVien(MaNV, TenNV, NgaySinh, GioiTinhID, SDT, SoCMND, Email, DiaChi, TrangThaiID) values ('" + nhanVienDTO.MaNV + "', N'" + nhanVienDTO.TenNV + "', '" + nhanVienDTO.NgaySinh + "', '" + nhanVienDTO.GioiTinhID + "', '" + nhanVienDTO.SDT + "', '" + nhanVienDTO.SoCMND + "' , '" + nhanVienDTO.Email + "', N'" + nhanVienDTO.DiaChi + "', '" + nhanVienDTO.TrangThaiID + "')";
            return sql;
        }

        public string UpdateNhanVien(NhanVienDTO nhanVienDTO)
        {
            string sql = "Update NhanVien set MaNV = '" + nhanVienDTO.MaNV + "', TenNV = N'" + nhanVienDTO.TenNV + "', NgaySinh = '" + nhanVienDTO.NgaySinh + "', GioiTinhID = '" + nhanVienDTO.GioiTinhID + "', SDT = '" + nhanVienDTO.SDT + "', SoCMND = '" + nhanVienDTO.SoCMND + "', Email = '" + nhanVienDTO.Email + "', DiaChi = N'" + nhanVienDTO.DiaChi + "', TrangThaiID = '" + nhanVienDTO.TrangThaiID + "' where NhanVienID = '" + nhanVienDTO.NhanVienID + "'";
            return sql;
        }

        public string DeleteNhanVien(int nhanVienID)
        {
            string sql = "Delete NhanVien where NhanVienID = '" + nhanVienID + "'";
            return sql;
        }
    }
}
