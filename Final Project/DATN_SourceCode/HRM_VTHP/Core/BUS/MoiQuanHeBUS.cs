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
    class MoiQuanHeBUS
    {
        private static MoiQuanHeBUS instance;

        internal static MoiQuanHeBUS Instance
        {
            get
            {
                if (instance == null) instance = new MoiQuanHeBUS(); return HRM_VTHP.Core.BUS.MoiQuanHeBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.MoiQuanHeBUS.instance = value;
            }
        }

        public DataTable LoadAllMoiQuanHe()
        {
            string sql = MoiQuanHeDAO.Instance.LoadAllMoiQuanHe();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            return Core.RunSql(MoiQuanHeDAO.Instance.ThemMoiQuanHe(moiQuanHeDTO));
        }

        public void UpdateMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            Core.RunSql(MoiQuanHeDAO.Instance.UpdateMoiQuanHe(moiQuanHeDTO));
        }

        public DataTable LoadMoiQuanHeFromHoSoNhanVien(MoiQuanHeDTO moiQuanHeDTO)
        {
            string sql = MoiQuanHeDAO.Instance.LoadMoiQuanHeFromHoSoNhanVien(moiQuanHeDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            Core.RunSql(MoiQuanHeDAO.Instance.DeleteMoiQuanHe(moiQuanHeDTO));
        }
    }
}
