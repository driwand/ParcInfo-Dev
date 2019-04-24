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
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.ProduitClients = new HashSet<ProduitClient>();
            this.ValeurProps = new HashSet<ValeurProp>();
        }
    
        public int id { get; set; }
        public string Marque { get; set; }
        public string Model { get; set; }
        public Nullable<System.DateTime> Datefabrication { get; set; }
        public Nullable<double> Prix { get; set; }
        public Nullable<int> IsHardware { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<System.DateTime> Datecreation { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Creepar { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual TypeProduit TypeProduit { get; set; }
        public virtual Utilisateur Utilisateur1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitClient> ProduitClients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValeurProp> ValeurProps { get; set; }
    }
}
