using CaleaRealEstateMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CaleaRealEstateMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Vendedor>().HasMany(m => m.Imoveis).WithOne(v => v.Vendedor).HasForeignKey(a => a.VendedorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Imovel> Imoveis { get; set;}

    }
}
