﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoboticsToolData.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RoboticDataEntities : DbContext
    {
        public RoboticDataEntities()
            : base("name=RoboticDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblSourceFileDetail> tblSourceFileDetails { get; set; }
        public virtual DbSet<tblUserDetail> tblUserDetails { get; set; }
        public virtual DbSet<tblAddCTN> tblAddCTNs { get; set; }
        public virtual DbSet<tblAirtimeCredit> tblAirtimeCredits { get; set; }
        public virtual DbSet<tblHardwareCredit> tblHardwareCredits { get; set; }
        public virtual DbSet<tblAddCTNWithHardware> tblAddCTNWithHardwares { get; set; }
        public virtual DbSet<tblInvalidData> tblInvalidDatas { get; set; }
        public virtual DbSet<tblResign> tblResigns { get; set; }
        public virtual DbSet<tblResignWithHardware> tblResignWithHardwares { get; set; }
        public virtual DbSet<tblHardwareOnly> tblHardwareOnlies { get; set; }
        public virtual DbSet<tblInvalidHardwareOnly> tblInvalidHardwareOnlies { get; set; }
    }
}
