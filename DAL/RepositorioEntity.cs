using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class RepositorioEntity : IRepositorio
    {
        private RepositorioContext db = new RepositorioContext();
        Produto IRepositorio.Consultar(string nome)
        {
            return db.Produtos.First<Produto>(p => p.Nome == nome);
        }


        void IRepositorio.Deletar(string nome)
        {
            throw new NotImplementedException();
        }


        void IRepositorio.Inserir(Produto produto)
        {
            db.Add(produto);
            db.SaveChanges();
        }


        List<Produto> IRepositorio.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
