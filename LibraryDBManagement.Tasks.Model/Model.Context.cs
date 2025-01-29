﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMVCLibraryManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int sp_deleteAllLibraryUsers(string role)
        {
            var roleParameter = role != null ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteAllLibraryUsers", roleParameter);
        }
    
        public virtual ObjectResult<sp_getAllLibraryUsers_Result> sp_getAllLibraryUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAllLibraryUsers_Result>("sp_getAllLibraryUsers");
        }
    }
}
