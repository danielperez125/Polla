﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApuestasPolla.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PollaEntities : DbContext
    {
        public PollaEntities()
            : base("name=PollaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ApuestaPartido> ApuestaPartido { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<EquipoPartido> EquipoPartido { get; set; }
        public DbSet<FasePartido> FasePartido { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Partido> Partido { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TipoPuntaje> TipoPuntaje { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
