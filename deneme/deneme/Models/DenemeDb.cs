using System;
using System.Collections.Generic;
using System.Data.Entity;


using System.Linq;
using System.Web;


namespace deneme.Models
{
    public class DenemeDb:DbContext
    {
        public DenemeDb():base("MyDb")
        {

        }
        public DbSet<DepartmentManager> DepartmentManagers { get; set; }
        
        public DbSet<FormatManager> FormatManagers { get; set; }

        public DbSet<RegionalManager> RegionalManagers { get; set; }

        public DbSet<Market> Markets { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Negative> Negatives { get; set; }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Worker>().HasMany(x => x.Markets).WithMany(x => x.Workers);
            
            base.OnModelCreating(modelBuilder);

           
        }

        

    }
}