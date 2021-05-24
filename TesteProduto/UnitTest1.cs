using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;
using System.Collections.Generic;

namespace TesteProduto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InserirProduto()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Inserir(produto: new Produto(nome: "sorvete", marca: "kibon", tipo: "gelados", quantidade: 29));
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consultar(nome: "sorvete"));
        }

        [TestMethod]
        public void DeletarProduto()
        {
            IRepositorio rep = new RepositorioMySQL();
            rep = new RepositorioMySQL();
            try
            {
                rep.Deletar(nome: "sorvete");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNull(rep.Consultar(nome: "sorvete"));
        }

        [TestMethod]
        public void ConsultarProduto()
        {
            Produto pro = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                pro = rep.Consultar(nome: "biscoito");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(pro);
        }

        [TestMethod]
        public void ListarProdutos()
        {
            List<Produto> produtos = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                produtos = rep.Listar();
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(produtos);
        }
    }


}
