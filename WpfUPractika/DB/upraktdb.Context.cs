﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfUPractika.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UpraktDBEntities : DbContext
    {
        public UpraktDBEntities()
            : base("name=UpraktDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coordinate> Coordinate { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Need> Need { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Realtor> Realtor { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<TypeProperty> TypeProperty { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
