//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.WP.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class sepet
    {
        public int sepetID { get; set; }
        public int urunID { get; set; }
        public int musteriID { get; set; }
        public int Adet { get; set; }
        public Nullable<decimal> sepetToplamTutar { get; set; }
    
        public virtual musteri musteri { get; set; }
        public virtual urun urun { get; set; }
    }
}
