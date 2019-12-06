using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace HRM_VTHP.BaoCao
{
    public partial class MauHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public MauHopDongLaoDong()
        {
            InitializeComponent();
        }
        public MauHopDongLaoDong(DataTable dtNV, DataTable dtGD )
        {
            InitializeComponent();
            ///---------------NV
            lblChucDanh.Text = "Chức vụ : "+ dtNV.Rows[0]["TenChucDanh"].ToString();
            lblTenNV.Text = "Chúng tôi, một bên là Ông/ Bà : " + dtNV.Rows[0]["TenNV"].ToString();
            lblSDT.Text = "Điện thoại : " + dtNV.Rows[0]["SDT"].ToString();
            lblDiaChi.Text = "Địa chỉ : " + dtNV.Rows[0]["DiaChi"].ToString();
            lblNV.Text = "-Ông, bà : " + dtNV.Rows[0]["TenNV"].ToString() + " làm việc theo hợp đồng lao động";
            lblRow1.Text = "từ ngày " + string.Format("{0:dd/MM/yyyy}", dtNV.Rows[0]["NgayHieuLuc"]);
            lblRow2.Text = "đến ngày " + string.Format("{0:dd/MM/yyyy}", dtNV.Rows[0]["NgayHetHan"]);
            ///----------------GĐ
            lblTenGD.Text = "Và một bên là Ông / Bà : " + dtGD.Rows[0]["TenNV"].ToString();
            lblNgaySinhGD.Text = "Sinh ngày : " + string.Format("{0:dd/MM/yyyy}", dtGD.Rows[0]["NgaySinh"]);
            lblChucDanhGD.Text = "Chức danh : " + dtGD.Rows[0]["TenChucDanh"].ToString();
            lblDiaChiGD.Text = "Địa chỉ thường trú : " + dtGD.Rows[0]["DiaChi"].ToString();
            lblSoCMNDGD.Text = "Số CMND : " + dtGD.Rows[0]["SoCMND"].ToString();
            
            
        }

    }
}
