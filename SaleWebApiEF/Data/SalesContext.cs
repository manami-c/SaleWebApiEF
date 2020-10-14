using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebApiEF.Models;

namespace SaleWebApiEF.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext (DbContextOptions<SalesContext> options)
            : base(options)
        {
        }
       
        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<Orderline> Orderline { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Customer>(e =>
            {
                e.HasIndex(p => p.Code).IsUnique();
            });
        }

        public DbSet<SaleWebApiEF.Models.Order> Order { get; set; }

        public DbSet<SaleWebApiEF.Models.Product> Product { get; set; }

    }
}
