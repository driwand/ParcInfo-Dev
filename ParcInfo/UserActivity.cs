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
    
    public partial class UserActivity
    {
        public int Id { get; set; }
        public Nullable<int> Iduser { get; set; }
        public string Activity { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
