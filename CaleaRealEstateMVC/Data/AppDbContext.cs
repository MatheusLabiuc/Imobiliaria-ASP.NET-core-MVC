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
            //  modelBuilder.Entity<ImovelEndereco>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ImovelEndereco>().HasKey(c => c.Id);

            modelBuilder.Entity<ImovelEndereco>().HasOne(v => v.Imovel);

            modelBuilder.Entity<Vendedor>().HasMany(m => m.Imoveis);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Imovel> Imoveis { get; set;}

        public DbSet<ImovelEndereco> ImoveisEnderecos { get; set; }
    }
}
