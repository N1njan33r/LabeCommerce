using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabeCommerce.Models;

namespace LabeCommerce.Data
{
    public class ProductDbContext : DbContext
    {
        // ctor tab tab for constructor
        public ProductDbContext() : base("ProductContext")
        {
            Database.SetInitializer(new ProductDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }
}