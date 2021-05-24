using Microsoft.EntityFrameworkCore;
using Modelos;

namespace DAL
{
    public class RepositorioContext : DbContext
    {
        public RepositorioContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySQL(connectionString: @"server = localhost; user id = root; pwd = batata; database = duas-camadas;");
            optionsBuilder.UseMySQL(connectionString: @"server = localhost; user id = root; pwd = batata; database = bdteste;");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
