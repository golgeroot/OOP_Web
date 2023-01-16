

using Microsoft.EntityFrameworkCore;
using OOP_Web.Entity;

namespace OOP_Web.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=BERKIT\SQLEXPRESS;database=DbNewOooCore;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
