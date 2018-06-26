//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildPC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CauHinhPC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauHinhPC()
        {
            this.PhanMems = new HashSet<PhanMem>();
            this.PhanMems1 = new HashSet<PhanMem>();
        }
    
        public string MaCH { get; set; }
        public string MaCPU { get; set; }
        public string MaMain { get; set; }
        public string MaRam { get; set; }
        public string MaRam2 { get; set; }
        public string MaHDD { get; set; }
        public string MaHDD2 { get; set; }
        public string MaCase { get; set; }
        public string MaNguon { get; set; }
        public string MaGPU { get; set; }
        public int Diem { get; set; }
        public int Giaban { get; set; }
    
        public virtual CasePC CasePC { get; set; }
        public virtual CPU CPU { get; set; }
        public virtual GPU GPU { get; set; }
        public virtual HDD HDD { get; set; }
        public virtual HDD HDD1 { get; set; }
        public virtual Mainboard Mainboard { get; set; }
        public virtual Nguon Nguon { get; set; }
        public virtual RAM RAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanMem> PhanMems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanMem> PhanMems1 { get; set; }
    }
}