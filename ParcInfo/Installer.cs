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
    
    public partial class Installer
    {
        public int id { get; set; }
        public Nullable<System.DateTime> Dateexpiration { get; set; }
        public Nullable<int> Idhardsoft { get; set; }
        public Nullable<int> Idproduitclient { get; set; }
        public Nullable<System.DateTime> Datecreation { get; set; }
        public Nullable<System.DateTime> Datemodification { get; set; }
        public Nullable<int> Creepar { get; set; }
        public Nullable<int> Modifierpar { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ProduitClient ProduitClient { get; set; }
        public virtual ProduitClient ProduitClient1 { get; set; }
        public virtual Utilisateur Utilisateur1 { get; set; }
    }
}
