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
    class TinHocBUS
    {
        private static TinHocBUS instance;

        internal static TinHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new TinHocBUS(); return HRM_VTHP.Core.BUS.TinHocBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.TinHocBUS.instance = value;
            }
        }

        public DataTable LoadAllTinHoc()
        {
            string sql = TinHocDAO.Instance.LoadAllTinHoc();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemTinHoc(TinHocDTO tinHocDTO)
        {
            return Core.RunSql(TinHocDAO.Instance.ThemTinHoc(tinHocDTO));
        }

        public void UpdateTinHoc(TinHocDTO tinHocDTO)
        {
            Core.RunSql(TinHocDAO.Instance.UpdateTinHoc(tinHocDTO));
        }

        public DataTable LoadTinHocFromHoSoNhanVien(TinHocDTO tinHocDTO)
        {
            string sql = TinHocDAO.Instance.LoadTinHocFromHoSoNhanVien(tinHocDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteTinHoc(TinHocDTO tinHocDTO)
        {
            Core.RunSql(TinHocDAO.Instance.DeleteTinHoc(tinHocDTO));
        }
    }
}
