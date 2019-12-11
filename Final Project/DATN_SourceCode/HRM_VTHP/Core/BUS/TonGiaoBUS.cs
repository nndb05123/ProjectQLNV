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
    class TonGiaoBUS
    {
        private static TonGiaoBUS instance;

        internal static TonGiaoBUS Instance
        {
            get
            {
                if (instance == null) instance = new TonGiaoBUS(); return HRM_VTHP.Core.BUS.TonGiaoBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.TonGiaoBUS.instance = value;
            }
        }

        public DataTable LoadAllTonGiao()
        {
            string sql = TonGiaoDAO.Instance.LoadAllTonGiao();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            return Core.RunSql(TonGiaoDAO.Instance.ThemTonGiao(tonGiaoDTO));
        }

        public void UpdateTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            Core.RunSql(TonGiaoDAO.Instance.UpdateTonGiao(tonGiaoDTO));
        }

        public DataTable LoadTonGiaoFromHoSoNhanVien(TonGiaoDTO tonGiaoDTO)
        {
            string sql = TonGiaoDAO.Instance.LoadTonGiaoFromHoSoNhanVien(tonGiaoDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            Core.RunSql(TonGiaoDAO.Instance.DeleteTonGiao(tonGiaoDTO));
        }

        internal int ThemLoaiTonGiao(object loaiHopDongDTO)
        {
            throw new NotImplementedException();
        }
    }
}
