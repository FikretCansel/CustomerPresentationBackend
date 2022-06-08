using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerUIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CustomerPresentation;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(@"Server=178.18.196.230;Database=CustomerPresentation;User Id=BtAdmin;Password=Bt#2019;");
            //optionsBuilder.UseSqlServer(@"Server=6488-15259;Database=CustomerPresentation;User Id=BtAdmin;Password=Bt#2019;");
            //optionsBuilder.UseSqlServer(@"Server=185.86.246.70;Database=CustomerPresentation;User Id=BtAdmin;Password=Bt#2022;");
            optionsBuilder.UseSqlServer(@"Server=WIN-G73KDTUFGJE;Database=CustomerPresentation;User Id=BtAdmin;Password=Bt#2022;");
            //optionsBuilder.UseSqlServer(@"Server=WIN-G73KDTUFGJE;Database=CustomerPresentation;User Id=BtAdmin;Password=Bt#2022;");
        }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }

        public DbSet<UsProduct> UsProducts { get; set; }

        public DbSet<UsProductImage> UsProductImages { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<UsProductTag> UsProductTags { get; set; }

        public DbSet<CustomerTag> CustomerTags { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
