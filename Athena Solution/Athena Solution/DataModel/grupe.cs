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
    
    public partial class grupe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public grupe()
        {
            this.linksSet = new HashSet<linksSet>();
        }
    
        public int id_grupa { get; set; }
        public string nume_grupa { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<int> anul { get; set; }
        public Nullable<int> id_link { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linksSet> linksSet { get; set; }
    }
}
