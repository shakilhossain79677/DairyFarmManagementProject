//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dairy_Farm_Management_Project_3rd_try.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DairyFarm3rdTryEntities : DbContext
    {
        public DairyFarm3rdTryEntities()
            : base("name=DairyFarm3rdTryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<BreedingRecord> BreedingRecords { get; set; }
        public virtual DbSet<DailyMilkProduction> DailyMilkProductions { get; set; }
        public virtual DbSet<HerdReport> HerdReports { get; set; }
        public virtual DbSet<SignUp> SignUps { get; set; }
        public virtual DbSet<TreatmentReport> TreatmentReports { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }
        public virtual DbSet<VaccineDetail> VaccineDetails { get; set; }
    }
}
