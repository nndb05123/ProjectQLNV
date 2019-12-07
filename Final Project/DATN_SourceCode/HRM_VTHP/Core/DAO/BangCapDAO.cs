using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class BangCapDAO
    {
        private static BangCapDAO instance;

        internal static BangCapDAO Instance
        {
            get
            {
                if (instance == null) instance = new BangCapDAO(); return HRM_VTHP.Core.DAO.BangCapDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.BangCapDAO.instance = value;
            }
        }

        public string LoadAllBangCap()
        {
            string sql = "Select * from BangCap";
            return sql;
        }
    }
}
