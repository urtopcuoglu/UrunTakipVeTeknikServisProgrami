//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEKNİKSERVİS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUrun()
        {
            this.tblUrunHareket = new HashSet<tblUrunHareket>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string MARKA { get; set; }
        public Nullable<decimal> ALISFIYATI { get; set; }
        public Nullable<decimal> SATISFIYATI { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<byte> KATEGORI { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual tblKategori tblKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunHareket> tblUrunHareket { get; set; }
    }
}
