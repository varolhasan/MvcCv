﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLDENEYIM> TBLDENEYIM { get; set; }
        public virtual DbSet<TBLEGITIM> TBLEGITIM { get; set; }
        public virtual DbSet<TBLHAKKIMDA> TBLHAKKIMDA { get; set; }
        public virtual DbSet<TBLHOBI> TBLHOBI { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLSERTIFIKA> TBLSERTIFIKA { get; set; }
        public virtual DbSet<TBLYETENEK> TBLYETENEK { get; set; }
        public virtual DbSet<TBLSOSYALMEDYA> TBLSOSYALMEDYA { get; set; }
    }
}