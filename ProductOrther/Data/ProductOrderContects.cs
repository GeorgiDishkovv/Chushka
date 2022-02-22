using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrther.Data
{
    public class ProductOrderContects : DbContext
    {
        public ProductOrderContects(DbContextOptions<ProductOrderContects>options):base(options) { }
         public virtual DbSet<UserVM> Users { get; set; }
        public virtual DbSet<ProductVM> Products { get; set; }
        public virtual DbSet<OrderVM> Orders { get; set; }
    }
   
}
