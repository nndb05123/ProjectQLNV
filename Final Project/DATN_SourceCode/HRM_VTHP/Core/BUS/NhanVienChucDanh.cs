using HRM_VTHP.Core.DAO;
using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class NhanVienChucDanh
    {
        private static NhanVienChucDanh instance;

        internal static NhanVienChucDanh Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienChucDanh(); return HRM_VTHP.Core.BUS.NhanVienChucDanh.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NhanVienChucDanh.instance = value;
            }
        }
        public DataTable LoadDaTa_NhanVienChucDanh()
        {
            DataTable dt = Core.GetData(NhanVienChucDanhDAO.Instance.LoadData_NhanVienChucDanh());
            return dt;
        }
        public DataTable Load_BoPhan()
        {
            DataTable dt = Core.GetData(NhanVienChucDanhDAO.Instance.Load_BoPhan());
            return dt;
        }
        public DataTable Load_LuongChucDanh()
        {
            DataTable dt = Core.GetData(NhanVienChucDanhDAO.Instance.Load_LuongChucDanh());
            return dt;
        }
        public int Add_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            return Core.RunSql(NhanVienChucDanhDAO.Instance.ADD_NhanVienChucDanh(nhanVienChucDanhDTO));
        }
        public void Update_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            Core.RunSql(NhanVienChucDanhDAO.Instance.Update_NhanVienChucDanh(nhanVienChucDanhDTO));
        }
        public void Delete_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            Core.RunSql(NhanVienChucDanhDAO.Instance.Delete_NhanVienChucDanh(nhanVienChucDanhDTO));
        }
        public DataTable Load_NhanVienBoPhan(string BoPhanID)
        {
            DataTable dt = Core.GetData(NhanVienChucDanhDAO.Instance.Load_NhanVienBoPhan(BoPhanID));
            return dt;
        }
    }
}
