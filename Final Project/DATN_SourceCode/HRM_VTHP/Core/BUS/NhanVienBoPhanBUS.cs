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
    class NhanVienBoPhanBUS
    {
        private static NhanVienBoPhanBUS instance;

        internal static NhanVienBoPhanBUS Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBoPhanBUS(); return HRM_VTHP.Core.BUS.NhanVienBoPhanBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NhanVienBoPhanBUS.instance = value;
            }
        }
        public DataTable LoadAllNhanVien()
        {
            DataTable dt = Core.GetData(NhanVienBoPhanDAO.Instance.LoadAllNhanVienBoPhan());
            return dt;
        }
        public DataTable LoadData_NhanVien()
        {
            DataTable dt = Core.GetData(NhanVienBoPhanDAO.Instance.LoadData_NhanVien());
            return dt;
        }
        public DataTable LoadData_BoPhan()
        {
            DataTable dt = Core.GetData(NhanVienBoPhanDAO.Instance.LoadData_BoPhan());
            return dt;
        }
        public int Add_NhanVien_BoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            return Core.RunSql(NhanVienBoPhanDAO.Instance.Add_NhanVien_BoPhan(nhanVienBoPhanDTO));
        }
        public void Update_NhanVien_BoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            Core.RunSql(NhanVienBoPhanDAO.Instance.Update_NhanVien_BoPhan(nhanVienBoPhanDTO));
        }
        public DataTable Load_NhanVienChucDanh(int NhanVienID)
        {
            DataTable dt = Core.GetData(NhanVienBoPhanDAO.Instance.Load_NhanVienChucDanh(NhanVienID));
            return dt;

        }
        public void Delete_NhanVien_BoPhan(NhanVienBoPhanDTO nhanVienBoPhanDTO)
        {
            Core.RunSql(NhanVienBoPhanDAO.Instance.Delete_NhanVienBoPhan(nhanVienBoPhanDTO));
        }
    }
}
