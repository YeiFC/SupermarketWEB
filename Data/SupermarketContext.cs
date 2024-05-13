using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SupermarketWEB.Models;
using System.Security.Principal;

namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {


        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
