//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BazaNaprej
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanDejavnosti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanDejavnosti()
        {
            this.PlanDijak = new HashSet<PlanDijak>();
            this.PlanSodelavci = new HashSet<PlanSodelavci>();
        }
    
        public int PlaId { get; set; }
        public string PlaOpis { get; set; }
        public Nullable<int> PlaŠtDijakov { get; set; }
        public string PlaCilji { get; set; }
        public string PlaTrajanje { get; set; }
        public Nullable<int> PlaPodročje { get; set; }
    
        public virtual Področja Področja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanDijak> PlanDijak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSodelavci> PlanSodelavci { get; set; }
    }
}
