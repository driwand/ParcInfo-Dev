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
    
    public partial class Intervention
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Intervention()
        {
            this.observations = new HashSet<observation>();
            this.ProduitClients = new HashSet<ProduitClient>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DateIntervention { get; set; }
        public string Deplacement { get; set; }
        public string TypeIntervention { get; set; }
        public Nullable<System.DateTime> Debut { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }
        public Nullable<int> Duree { get; set; }
        public string Statut { get; set; }
        public Nullable<int> IdDemande { get; set; }
        public Nullable<int> Idutilisateur { get; set; }
        public Nullable<int> Idclient { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<int> IdFacture { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Demande Demande { get; set; }
        public virtual Facture Facture { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Utilisateur UtilisateurEdit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<observation> observations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitClient> ProduitClients { get; set; }
    }
}
