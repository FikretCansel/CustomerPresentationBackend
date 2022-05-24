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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CustomerPresentation;Trusted_Connection=true");
        }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }

        public DbSet<UsProduct> UsProducts { get; set; }

        public DbSet<UsProductImage> UsProductImages { get; set; }
    }
}
