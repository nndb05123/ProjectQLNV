using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO(); return HRM_VTHP.Core.DAO.NhanVienDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NhanVienDAO.instance = value;
            }
        }


    }
}
