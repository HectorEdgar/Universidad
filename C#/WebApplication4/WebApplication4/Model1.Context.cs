﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class securityEntities2 : DbContext
    {
        public securityEntities2()
            : base("name=securityEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Control> Controls { get; set; }
        public DbSet<ControlType> ControlTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<userAutentication> userAutentications { get; set; }
        public DbSet<UserAutenticationType> UserAutenticationTypes { get; set; }
        public DbSet<UserLoginHistory> UserLoginHistories { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Usser> Ussers { get; set; }
    }
}