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
    
    public partial class ProduitUtiliser
    {
        public int Id { get; set; }
        public int IdProduitClient { get; set; }
        public int IdEmployee { get; set; }
        public string Login_u { get; set; }
        public string Password_u { get; set; }
        public Nullable<System.DateTime> Dateaffectation { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Creepar { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ProduitClient ProduitClient { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Utilisateur Utilisateur1 { get; set; }
    }
}
