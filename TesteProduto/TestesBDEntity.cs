using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;


namespace TesteProduto
{
    [TestClass]
    public class TestesBDEntity
    {
        [TestMethod]
        public void InserirProduto()
        {
            IRepositorio rep = new RepositorioEntity();
            try
            {
                rep.Inserir(new Produto("Sorvete", "kibon", "gelados" , 22));
            }
            catch (Exception ex)
            {


            }
            Assert.IsNotNull(rep.Consultar("sorvete"));
        }
    }
}
