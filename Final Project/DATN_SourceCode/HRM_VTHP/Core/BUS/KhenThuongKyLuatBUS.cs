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
    class KhenThuongKyLuatBUS
    {
        private static KhenThuongKyLuatBUS instance;

        internal static KhenThuongKyLuatBUS Instance
        {
            get
            {
                if (instance == null) instance = new KhenThuongKyLuatBUS(); return HRM_VTHP.Core.BUS.KhenThuongKyLuatBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.KhenThuongKyLuatBUS.instance = value;
            }
        }
        public DataTable LoadData_KhenThuongKyLuat()
        {
            DataTable dt = Core.GetData(KhenThuongKyLuatDAO.Instance.LoadData_KhenThuongKyLuat());
            return dt;
        }
        public int Add_KhenThuongKyLuat(KhenThuongKyLuatDTO khenThuongKyLuatDTO)
        {
            return Core.RunSql(KhenThuongKyLuatDAO.Instance.Add_KhenThuongKyLuat(khenThuongKyLuatDTO));
        }
        public void Update_KhenThuongKyLuat(KhenThuongKyLuatDTO khenThuongKyLuatDTO, int KhenThuongKyLuatID)
        {
            Core.RunSql(KhenThuongKyLuatDAO.Instance.Update_KhenThuongKyLuat(khenThuongKyLuatDTO, KhenThuongKyLuatID));
        }
        public void Delete_KhenThuongKyLuat(int KhenThuongKyLuatID)
        {
            Core.RunSql(KhenThuongKyLuatDAO.Instance.Delete_KhenThuongKyLuat(KhenThuongKyLuatID));
        }
    }
}
