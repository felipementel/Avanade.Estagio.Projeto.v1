using Avanade.Estagiario.API.Domain;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace Avanade.Estagiario.API.Repositorio
{
    //ADO.NET
    //Dapper
    // * Entity Framework

    public class CervejaContext : DbContext
    {
        public DbSet<Cerveja> Cervejas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cerveja>()
                .HasKey(p => p.Id);

            //base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=localhost;Database=Avanade;Uid=root;Pwd=my-secret-pw;";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
