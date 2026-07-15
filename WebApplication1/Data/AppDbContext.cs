using ElectronicsAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace ElectronicsAPI.Models.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
   }

