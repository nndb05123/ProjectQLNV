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
    class LoaiHopDongBUS
    {
        private static LoaiHopDongBUS instance;

        internal static LoaiHopDongBUS Instance
        {
            get
            {
                if (instance == null) instance = new LoaiHopDongBUS(); return HRM_VTHP.Core.BUS.LoaiHopDongBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.LoaiHopDongBUS.instance = value;
            }
        }

        public DataTable LoadAllLoaiHopDong()
        {
            string sql = LoaiHopDongDAO.Instance.LoadAllLoaiHopDong();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            return Core.RunSql(LoaiHopDongDAO.Instance.ThemLoaiHopDong(loaiHopDongDTO));
        }

        public void UpdateLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            Core.RunSql(LoaiHopDongDAO.Instance.UpdateLoaiHopDong(loaiHopDongDTO));
        }

        public DataTable LoadLoaiHopDongFromHoSoNhanVien(LoaiHopDongDTO loaiHopDongDTO)
        {
            string sql = LoaiHopDongDAO.Instance.LoadLoaiHopDongFromHoSoNhanVien(loaiHopDongDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            Core.RunSql(LoaiHopDongDAO.Instance.DeleteLoaiHopDong(loaiHopDongDTO));
        }

        internal int ThemLoaiHopDong(object loaiHopDongDTO)
        {
            throw new NotImplementedException();
        }
    }
}
