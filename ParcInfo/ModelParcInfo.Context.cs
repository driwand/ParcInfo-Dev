﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParcInformatiqueEntities : DbContext
    {
        public ParcInformatiqueEntities()
            : base("name=ParcInformatiqueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AffectationClient> AffectationClients { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Demande> Demandes { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Installer> Installers { get; set; }
        public virtual DbSet<Intervention> Interventions { get; set; }
        public virtual DbSet<observation> observations { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<ProduitClient> ProduitClients { get; set; }
        public virtual DbSet<ProduitUtiliser> ProduitUtilisers { get; set; }
        public virtual DbSet<ProprietesProduit> ProprietesProduits { get; set; }
        public virtual DbSet<RoleUtilisateur> RoleUtilisateurs { get; set; }
        public virtual DbSet<TypeProduit> TypeProduits { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<ValeurProp> ValeurProps { get; set; }
    }
}