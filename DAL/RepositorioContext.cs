using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioContext : DbContext
    {
        public RepositorioContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString: @"server = localhost; user id = root; pwd = batata; database = duas-camadas;");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
