//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCPT
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        public int IDKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public int SDTKhach { get; set; }
        public string DiaChi { get; set; }
    
        public virtual Hoatdong Hoatdong { get; set; }
    }
}
