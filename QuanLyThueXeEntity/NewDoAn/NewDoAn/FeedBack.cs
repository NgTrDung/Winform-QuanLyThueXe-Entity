//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewDoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeedBack
    {
        public FeedBack()
        {
        }

        public FeedBack(string maXe)
        {
            MaXe = maXe;
        }

        public FeedBack(string tenKhachHang, string loaiXe, string hangXe, string maXe, string tenXe)
        {
            TenKhachHang = tenKhachHang;
            LoaiXe = loaiXe;
            HangXe = hangXe;
            MaXe = maXe;
            TenXe = tenXe;
        }

        public FeedBack(int iD, string tenKhachHang, string loaiXe, string hangXe, string maXe, string tenXe, double danhGia, string noiDung)
        {
            ID = iD;
            TenKhachHang = tenKhachHang;
            LoaiXe = loaiXe;
            HangXe = hangXe;
            MaXe = maXe;
            TenXe = tenXe;
            DanhGia = danhGia;
            NoiDung = noiDung;
        }

        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string LoaiXe { get; set; }
        public string HangXe { get; set; }
        public string MaXe { get; set; }
        public string TenXe { get; set; }
        public double DanhGia { get; set; }
        public string NoiDung { get; set; }
    }
}
