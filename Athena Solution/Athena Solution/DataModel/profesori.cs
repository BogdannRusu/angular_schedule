//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Athena_Solution.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class profesori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public profesori()
        {
            this.linksSet = new HashSet<linksSet>();
        }
    
        public int id_prof { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string patronimic { get; set; }
        public System.DateTime data_activarii { get; set; }
        public Nullable<System.DateTime> end_data_activarii { get; set; }
        public Nullable<bool> is_active { get; set; }
        public string functia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linksSet> linksSet { get; set; }
    }
}
