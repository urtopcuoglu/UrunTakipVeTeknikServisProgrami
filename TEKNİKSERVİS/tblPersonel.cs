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
    
    public partial class tblPersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPersonel()
        {
            this.tblFaturaBilgi = new HashSet<tblFaturaBilgi>();
            this.tblUrunHareket = new HashSet<tblUrunHareket>();
            this.tblUrunKabul = new HashSet<tblUrunKabul>();
        }
    
        public short ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public Nullable<byte> DEPARTMAN { get; set; }
        public string FOTOGRAF { get; set; }
        public string MAIL { get; set; }
        public string TELEFON { get; set; }
    
        public virtual tblDepartman tblDepartman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFaturaBilgi> tblFaturaBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunHareket> tblUrunHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunKabul> tblUrunKabul { get; set; }
    }
}
