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
    
    public partial class ValeurProp
    {
        public int Id { get; set; }
        public string Valeur { get; set; }
        public Nullable<int> IdProduit { get; set; }
        public Nullable<int> IdPropriete { get; set; }
    
        public virtual Produit Produit { get; set; }
        public virtual ProprietesProduit ProprietesProduit { get; set; }
    }
}
