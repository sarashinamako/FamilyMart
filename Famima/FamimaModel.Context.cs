﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Famima
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FamilyMartEntities : DbContext
    {
        private static FamilyMartEntities instance;
        private FamilyMartEntities()
            : base("name=FamilyMartEntities")
        {
        }

        public static FamilyMartEntities getInstance()
        {
            if (instance == null) instance = new FamilyMartEntities();
            return instance;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<item> item { get; set; }
    }
}