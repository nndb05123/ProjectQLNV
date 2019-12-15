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
    class LoaiQuyetDinhBUS
    {
        private static LoaiQuyetDinhBUS instance;

        internal static LoaiQuyetDinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new LoaiQuyetDinhBUS(); return HRM_VTHP.Core.BUS.LoaiQuyetDinhBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.LoaiQuyetDinhBUS.instance = value;
            }
        }

        public DataTable LoadAllLoaiQuyetDinh()
        {
            string sql = LoaiQuyetDinhDAO.Instance.LoadAllLoaiQuyetDinh();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            return Core.RunSql(LoaiQuyetDinhDAO.Instance.ThemLoaiQuyetDinh(loaiQuyetDinhDTO));
        }

        public void UpdateLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            Core.RunSql(LoaiQuyetDinhDAO.Instance.UpdateLoaiQuyetDinh(loaiQuyetDinhDTO));
        }

        public DataTable LoadLoaiQuyetDinhFromHoSoNhanVien(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            string sql = LoaiQuyetDinhDAO.Instance.LoadLoaiQuyetDinhFromHoSoNhanVien(loaiQuyetDinhDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            Core.RunSql(LoaiQuyetDinhDAO.Instance.DeleteLoaiQuyetDinh(loaiQuyetDinhDTO));
        }
    }
}
