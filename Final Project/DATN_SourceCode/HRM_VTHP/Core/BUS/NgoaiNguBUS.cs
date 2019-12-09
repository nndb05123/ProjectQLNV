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
    class NgoaiNguBUS
    {
        private static NgoaiNguBUS instance;

        internal static NgoaiNguBUS Instance
        {
            get
            {
                if (instance == null) instance = new NgoaiNguBUS(); return HRM_VTHP.Core.BUS.NgoaiNguBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NgoaiNguBUS.instance = value;
            }
        }

        public DataTable LoadAllNgoaiNgu()
        {
            string sql = NgoaiNguDAO.Instance.LoadAllNgoaiNgu();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            return Core.RunSql(NgoaiNguDAO.Instance.ThemNgoaiNgu(ngoaiNguDTO));
        }

        public void UpdateNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            Core.RunSql(NgoaiNguDAO.Instance.UpdateNgoaiNgu(ngoaiNguDTO));
        }

        public void DeleteNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            Core.RunSql(NgoaiNguDAO.Instance.DeleteNgoaiNgu(ngoaiNguDTO));
        }

        public DataTable LoadNgoaiNguFormHoSoNhanVien(NgoaiNguDTO ngoaiNguDTO)
        {
            string sql = NgoaiNguDAO.Instance.LoadNgoaiNguFormHoSoNhanVien(ngoaiNguDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }
    }
}
