using Modelos;
using System.Data.Entity;

namespace DAL
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext() : base(nameOrConnectionString: "ProdutosContext")
        {

        }

        public DbSet<Produto> produtos { get; set; }
    }
}
