//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNTT2_TRANVANMINH_2210900112.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhGia
    {
        public int MaDanhGia { get; set; }
        public Nullable<int> MaNguoiDung { get; set; }
        public Nullable<int> MaSach { get; set; }
        public Nullable<int> DiemDanhGia { get; set; }
        public string BinhLuan { get; set; }
        public Nullable<System.DateTime> NgayDanhGia { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual Sach Sach { get; set; }
    }
}