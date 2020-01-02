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
    class HopDongBUS
    {
        private static HopDongBUS instance;

        internal static HopDongBUS Instance
        {
            get
            {
                if (instance == null) instance = new HopDongBUS(); return HRM_VTHP.Core.BUS.HopDongBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.HopDongBUS.instance = value;
            }

        }
        public DataTable LoadData_HopDong()
        {
            DataTable dt = Core.GetData(HopDongDAO.Instance.LoadAll_HopDong());
            return dt;
        }
        public DataTable Load_LoaiHopDong()
        {
            DataTable dt = Core.GetData(HopDongDAO.Instance.Load_LoaiHopDong());
            return dt;
        }
        public DataTable Load_BoPhan()
        {
            DataTable dt = Core.GetData(HopDongDAO.Instance.Load_BoPhan());
            return dt;
        }
        public DataTable Load_NhanVienBoPhan(string BoPhanID)
        {
            DataTable dt = Core.GetData(HopDongDAO.Instance.Load_NhanVienBoPhan(BoPhanID));
            return dt;
        }
        public int Add_HopDong(HopDongDTO hopDongDTO)
        {
            return Core.RunSql(HopDongDAO.Instance.Add_HopDong(hopDongDTO));

        }
        public void Update_HopDong(HopDongDTO hopDongDTO,int HopDongID)
        {
            Core.RunSql(HopDongDAO.Instance.Update_HopDong(hopDongDTO, HopDongID));
        }
        public void Delete_HopDong(int HopDongID)
        {
            Core.RunSql(HopDongDAO.Instance.Delete_HopDong(HopDongID));
        }


    }
}
