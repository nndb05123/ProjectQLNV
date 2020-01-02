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
    class LuongChucDanhBUS
    {
        private static LuongChucDanhBUS instance;

        internal static LuongChucDanhBUS Instance
        {
            get
            {
                if (instance == null) instance = new LuongChucDanhBUS(); return HRM_VTHP.Core.BUS.LuongChucDanhBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.LuongChucDanhBUS.instance = value;
            }
        }
        public DataTable LoadData_LuongChucDanh()
        {
            DataTable dt = Core.GetData(LuongChucDanhDAO.Instance.LoadData_LuongChucDanh());
            return dt;

        }
         public int Add_LuongChucDanh(LuongChucDanhDTO luongChucDanhDTO)
        {
            return Core.RunSql(LuongChucDanhDAO.Instance.Add_LuongChucDanh(luongChucDanhDTO));
        }
        public void Update_LuongChucDanh(LuongChucDanhDTO luongChucDanhDTO,int ChucDanhID)
        {
            Core.RunSql(LuongChucDanhDAO.Instance.Update_LuongChucDanh(luongChucDanhDTO, ChucDanhID));
        }
        public void Delete_LuongChucDanh(int ChucDanhID)
        {
            Core.RunSql(LuongChucDanhDAO.Instance.Delete_LuongChucDanh(ChucDanhID));
        }
        public DataTable Load_NhanVienChucDanh(int ChucDanhID)
        {
            DataTable dt = Core.GetData(LuongChucDanhDAO.Instance.Load_NhanVienChucDanh(ChucDanhID));
            return dt;

        }
    }
}
