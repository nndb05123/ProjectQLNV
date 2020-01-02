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
    class NguoiThanBUS
    {
        private static NguoiThanBUS instance;

        internal static NguoiThanBUS Instance
        {
            get
            {
                if (instance == null) instance = new NguoiThanBUS(); return HRM_VTHP.Core.BUS.NguoiThanBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NguoiThanBUS.instance = value;
            }
        }

        public DataTable LoadAllThanNhan()
        {
            DataTable dt = Core.GetData(NguoiThanDAO.Instance.LoadAllThanNhan());
            return dt;
        }
        public DataTable LoadData_BoPhan()
        {
            DataTable dt = Core.GetData(NguoiThanDAO.Instance.LoadData_BoPhan());
            return dt;
        }
        public DataTable LoadData_MoiQuanHe()
        {
            DataTable dt = Core.GetData(NguoiThanDAO.Instance.LoadData_MoiQuanHe());
            return dt;
        }
        public DataTable LoadData_NhanVien_BoPhan(String BoPhanID)
        {
            DataTable dt = Core.GetData(NguoiThanDAO.Instance.LoadData_NhanVien_BoPhan(BoPhanID));
            return dt;
        }
        public int Add_NguoiThan(NguoiThanDTO nguoiThanDTO)
        {
            return Core.RunSql(NguoiThanDAO.Instance.ADD_NguoiThan(nguoiThanDTO));
        }
        public void Update_NguoiThan(NguoiThanDTO nguoiThanDTO, int NguoiThanID)
        {
            Core.RunSql(NguoiThanDAO.Instance.Update_NguoiThan(nguoiThanDTO, NguoiThanID));
        }
        public void Delete_NguoiThan(int NguoiThanID)
        {
            Core.RunSql(NguoiThanDAO.Instance.Delete_NguoiThan(NguoiThanID));
        }
    }
}
