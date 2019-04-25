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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Demandes = new HashSet<Demande>();
            this.ProduitUtilisers = new HashSet<ProduitUtiliser>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Password_e { get; set; }
        public Nullable<int> IsResponsable { get; set; }
        public Nullable<int> IdDep { get; set; }
        public Nullable<int> Idclient { get; set; }
        public Nullable<System.DateTime> Datecreation { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Creepar { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demande> Demandes { get; set; }
        public virtual Departement Departement { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Utilisateur Utilisateur1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitUtiliser> ProduitUtilisers { get; set; }
    }
}
