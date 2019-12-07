using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_VTHP.Core.DAO;
using System.Data;
using HRM_VTHP.Core;

namespace HRM_VTHP.Core.BUS
{
    class BangCapBUS
    {
        private static BangCapBUS instance;

        internal static BangCapBUS Instance
        {
            get
            {
                if (instance == null) instance = new BangCapBUS(); return HRM_VTHP.Core.BUS.BangCapBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.BangCapBUS.instance = value;
            }
        }

        public DataTable LoadAllBangCap() {
            string sql = BangCapDAO.Instance.LoadAllBangCap();
            DataTable dt = Core.GetData(sql);
            return dt;
        }
    }
}
