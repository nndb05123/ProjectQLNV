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
    class TamUngBUS
    {
        
            private static TamUngBUS instance;

            internal static TamUngBUS Instance
            {
                get
                {
                    if (instance == null) instance = new TamUngBUS(); return HRM_VTHP.Core.BUS.TamUngBUS.instance;
                }

                private set
                {
                    HRM_VTHP.Core.BUS.TamUngBUS.instance = value;
                }
            }

            public DataTable LoadAllTamUng()
            {
                string sql = TamUngDAO.Instance.LoadAllTamUng();
                DataTable dt = Core.GetData(sql);
                return dt;
            }

            public int ThemTamUng(TamUngDTO tamUngDTO)
            {
                return Core.RunSql(TamUngDAO.Instance.ThemTamUng(tamUngDTO));
            }

            public void UpdateTamUng(TamUngDTO tamUngDTO)
            {
                Core.RunSql(TamUngDAO.Instance.UpdateTamUng(tamUngDTO));
            }

            public DataTable LoadTamUngFromHoSoNhanVien(TamUngDTO tamUngDTO)
            {
                string sql = TamUngDAO.Instance.LoadTamUngFromHoSoNhanVien(tamUngDTO);
                DataTable dt = Core.GetData(sql);
                return dt;
            }

            public void DeleteTamUng(TamUngDTO tamUngDTO)
            {
                Core.RunSql(TamUngDAO.Instance.DeleteTamUng(tamUngDTO));
            }
        }
}
