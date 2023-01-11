using Project.DAL.StrategyPattern;
using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
   public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new BannerMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new ServiceMap());
            modelBuilder.Configurations.Add(new TeamMap());
            
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
