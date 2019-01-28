using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//
// Servico
//
using Periodicos.Servico.BD;
//
//
//
using Periodicos.Dominio.Entidades.Pessoa;
using Periodicos.Dominio.Entidades.Periodico;
//

namespace Testes.Servico.BancoDeDados
{
    /// <summary>
    /// Summary description for BancoDeDadosTest
    /// </summary>
    [TestClass]
    public class BancoDeDadosTest
    {        
        public BancoDeDadosTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion




        [TestMethod]
        public void Deve_Adicionar_Um_Artigo()
        {
            Periodicos.Servico.BD.BancoDeDados bd;

            bd = Periodicos.Servico.BD.BancoDeDados.GetInstance();

            IArtigo artigo = new Artigo();

            IAutor autor = new Autor();

            autor.Id = 1;

            autor.Nome = "Wesley";

            artigo.Id = 1;
            artigo.Autores.Adicionar(autor);


            bd.AdicionarPublicacao(artigo);

            bd.SelecionarArtigoByAutor(autor);
        }
    }
}
