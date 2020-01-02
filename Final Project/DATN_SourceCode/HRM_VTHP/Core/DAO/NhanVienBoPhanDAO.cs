using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NhanVienBoPhanDAO
    {
        private static NhanVienBoPhanDAO instance;

        internal static NhanVienBoPhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBoPhanDAO(); return HRM_VTHP.Core.DAO.NhanVienBoPhanDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NhanVienBoPhanDAO.instance = value;
            }
        }
        public string LoadAllNhanVienBoPhan()
        {
            string sql = @"Select a.NhanVienID, a.BoPhanID, b.TenNV, c.TenBoPhan
                            from ((NhanVienBoPhan a inner join NhanVien b on a.NhanVienID = b.NhanVienID)
                            inner join BoPhan c on a.BoPhanID = c.BoPhanID)";
            return sql;
        }
        public string LoadData_NhanVien()
        {
            string sql = "Select * from NhanVien";
            return sql;
        }
        public string LoadData_BoPhan()
        {
            string sql = "Select * from BoPhan";
            return sql;
        }
        public string Add_NhanVien_BoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            string sql = "Insert into NhanVienBoPhan(NhanVienID, BoPhanID) values ('" + nhanVienBoPhanDTO.NhanVienID + "', '" + nhanVienBoPhanDTO.BoPhanID + "')";
            return sql;
        }
        public string Update_NhanVien_BoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            string sql = "Update NhanVienBoPhan set NhanVienID ='" + nhanVienBoPhanDTO.NhanVienID + "', BoPhanID = '" + nhanVienBoPhanDTO.BoPhanID + "' where NhanVienID = '" + nhanVienBoPhanDTO.NhanVienID + "'";
            return sql;
        }
        public string Load_NhanVienChucDanh(int NhanVienID)
        {
            string sql = "Select * from NhanVienChucDanh where NhanVienID = '" + NhanVienID + "'";
            return sql;
        }
        public string Delete_NhanVienBoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            string sql = "Delete NhanVienBoPhan where NhanVienID = '" + nhanVienBoPhanDTO.NhanVienID + "' AND BoPhanID = '" + nhanVienBoPhanDTO.BoPhanID + "'";
            return sql;
            
        }


    }
}
