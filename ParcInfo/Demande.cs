//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParcInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Demande()
        {
            this.Interventions = new HashSet<Intervention>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Datedemande { get; set; }
        public string Description_d { get; set; }
        public string Statut { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
