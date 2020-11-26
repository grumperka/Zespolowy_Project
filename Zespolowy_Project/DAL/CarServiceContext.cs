using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projekt_Zespolowy.Models;

namespace Zespolowy_Project.DAL
{
    public class CarServiceContext : DbContext
    {
        public CarServiceContext() : base ("ZespolowyConnection")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPhoto> CarPhotos { get; set; }
        public DbSet<CarRepair> CarRepairs { get; set; }
        public DbSet<CarService> CarServices { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}