
using Domain.Common;
using Domain.Pedidos;
using Microsoft.EntityFrameworkCore;

namespace PersistenceEF.DataContext
{
    public class EF_DataContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        //public DbSet<Mesa> Mesas { get; set; }
        //public DbSet<Prato> Pratos { get; set; }
        //public DbSet<Produto> Produtos { get; set; }
        //public DbSet<PratoProduto> PratoProdutos { get; set; }
        public DbSet<Notification> Notifications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Notification>().HasNoKey().ToTable(nameof(Notifications), t => t.ExcludeFromMigrations());
            modelBuilder.Entity<Pessoa>().ToTable("TB_PESSOA");
            modelBuilder.Entity<Contato>().ToTable("TB_CONTATO");
            //modelBuilder.Entity<Mesa>().ToTable("TB_MESA");
            //modelBuilder.Entity<Prato>().ToTable("TB_PRATO");
            //modelBuilder.Entity<Produto>().ToTable("TB_PRODUTO");
            //modelBuilder.Entity<PratoProduto>().ToTable("TB_PRATO_PRODUTO");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBEFCore;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Augusto\OneDrive\Área de Trabalho\Faculdade\Orientada a Objetos\ProjetoFinal\Domain\Persistence\App_Data\RestauranteDados.mdf; Integrated Security=True;");
        }

    }
}
