﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAIManagment.ModuleCore.Data.DataSource.Local.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VSpracticeEntities : DbContext
    {
        public VSpracticeEntities()
            : base("name=VSpracticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarColor> CarColors { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<RegionCode> RegionCodes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }
    }
}
