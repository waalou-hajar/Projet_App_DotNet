﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace books.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SEntities2 : DbContext
    {
        public SEntities2()
            : base("name=SEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<commande> commande { get; set; }
        public virtual DbSet<livres> livres { get; set; }
        public virtual DbSet<panier> panier { get; set; }
    }
}