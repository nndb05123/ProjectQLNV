using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_VTHP.Core.DAO;
using HRM_VTHP.Core.DTO;

namespace HRM_VTHP.Core.DAO
{
    class LuongChucDanhDAO
    {
        private static LuongChucDanhDAO instance;

        internal static LuongChucDanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new LuongChucDanhDAO(); return HRM_VTHP.Core.DAO.LuongChucDanhDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.LuongChucDanhDAO.instance = value;
            }
        }
        public string LoadData_LuongChucDanh()
        {
            string sql = "Select * from LuongChucDanh";
            return sql;
        }
        public string Add_LuongChucDanh(LuongChucDanhDTO luongChucDanhDTO)
        {
            string sql = "Insert into LuongChucDanh(TenChucDanh, TienLuongCung, PhuCap)" + " values (N'" + luongChucDanhDTO.TenChucDanh + "', '" + luongChucDanhDTO.TienLuongCung + "', '" + "" + luongChucDanhDTO.PhuCap + "')";
            return sql;
        }
        public string Update_LuongChucDanh(LuongChucDanhDTO luongChucDanhDTO,int ChucDanhID)
        {
            string sql = "Update LuongChucDanh set TenChucDanh =N'" + luongChucDanhDTO.TenChucDanh + "', TienLuongCung='" + luongChucDanhDTO.TienLuongCung + "', PhuCap='" + luongChucDanhDTO.PhuCap + "' where ChucDanhID = '" + ChucDanhID + "'";
            return sql;
        }
        public string Delete_LuongChucDanh(int ChucDanhID)
        {
            string sql = "Delete LuongChucDanh where ChucDanhID='" + ChucDanhID + "'";
            return sql;
        }
        public  string Load_NhanVienChucDanh(int ChucDanhID)
        {
            string sql = "Select *from NhanVienChucDanh where ChucDanhID = '" + ChucDanhID + "'";
            return sql;
        }
    }
}
