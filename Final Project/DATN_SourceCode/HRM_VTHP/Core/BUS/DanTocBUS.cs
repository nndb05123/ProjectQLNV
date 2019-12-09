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
    class DanTocBUS
    {
        private static DanTocBUS instance;

        internal static DanTocBUS Instance
        {
            get
            {
                if (instance == null) instance = new DanTocBUS(); return HRM_VTHP.Core.BUS.DanTocBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.DanTocBUS.instance = value;
            }
        }

        public DataTable LoadAllDanToc()
        {
            string sql = DanTocDAO.Instance.LoadAllDanToc();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemDanToc(DanTocDTO danTocDTO)
        {
            return Core.RunSql(DanTocDAO.Instance.ThemDanToc(danTocDTO));
        }

        public void UpdateDanToc(DanTocDTO danTocDTO)
        {
            Core.RunSql(DanTocDAO.Instance.UpdateDanToc(danTocDTO));
        }

        public DataTable LoadDanTocFromHoSoNhanVien(DanTocDTO danTocDTO)
        {
            string sql = DanTocDAO.Instance.LoadDanTocFromHoSoNhanVien(danTocDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteDanToc(DanTocDTO danTocDTO)
        {
            Core.RunSql(DanTocDAO.Instance.DeleteDanToc(danTocDTO));
        }
    }
}
