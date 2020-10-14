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

        public DbSet<SaleWebApiEF.Models.Customer> Customer { get; set; }
    }
}
