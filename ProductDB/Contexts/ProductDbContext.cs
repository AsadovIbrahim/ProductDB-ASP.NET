using Microsoft.EntityFrameworkCore;
using ProductDB.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDB.Contexts
{
    public class ProductDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G25JVEL\\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;Trust Server Certificate=True;");
        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Order>Orders { get; set; }
    }
}
