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
    
    public partial class GioHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GioHang()
        {
            this.SanPhamTrongGios = new HashSet<SanPhamTrongGio>();
        }
    
        public int MaGioHang { get; set; }
        public Nullable<int> MaNguoiDung { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamTrongGio> SanPhamTrongGios { get; set; }
    }
}