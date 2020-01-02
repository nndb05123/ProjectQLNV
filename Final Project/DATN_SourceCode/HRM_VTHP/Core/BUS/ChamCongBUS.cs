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
    class ChamCongBUS
    {
        private static ChamCongBUS instance;

        internal static ChamCongBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChamCongBUS(); return HRM_VTHP.Core.BUS.ChamCongBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.ChamCongBUS.instance = value;
            }
        }
        public DataTable LoadData_BoPhan()
        {
            DataTable dt = Core.GetData(ChamCongDAO.Instance.LoadData_BoPhan());
            return dt;

        }
        public DataTable LoadData_Show_ChamCong(ChamCongDTO chamCongDTO)
        {
            DataTable dt = Core.GetData(ChamCongDAO.Instance.LoadData_Show_ChamCong(chamCongDTO));
            return dt;
        }
    }
}
