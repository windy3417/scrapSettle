using ScrapSettlement.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ScrapSettlement.DAL
{
    class ScrapSettleContext : DbContext
    {


        public ScrapSettleContext()
            : base("name=myConcetionForEF")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<WeighingSettlement> WeighingSettlement { get; set; }
        public virtual DbSet<Scrap> Scraps { get; set; }
        public virtual DbSet<Coefficient> Coefficients{get;set;}
        public virtual DbSet<Person> Peple { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<VehicleBrand> VehicleBrands { get; set; }
    }
}

