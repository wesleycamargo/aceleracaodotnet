using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//
// Base
//
using Base.Colecoes;
//

namespace Testes.Base.Colecoes
{   
    /// <summary>
    ///This is a test class for ListaTest and is intended
    ///to contain all ListaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListaTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion        

        [TestMethod()]
        public void Deve_Adicionar_Um_Item_Na_Lista()
        {
            String item = "String 1";

            Lista<String> target = new Lista<String>();
            
            target.Adicionar(item);
            
            String retorno = target.Buscar(item);

            Assert.AreEqual(item, retorno);
        }
       

        [TestMethod()]
        public void BuscarTest()
        {
            String item = "String 1";

            Lista<String> target = new Lista<String>();

            target.Adicionar(item);

            String retorno = target.Buscar(item);

            Assert.AreEqual(item, retorno);
        }        

        [TestMethod()]
        public void ContemProximoTest()
        {
            String str = "Teste";
            
            Lista<String> lista = new Lista<String>();

            Assert.IsFalse(lista.ContemProximo());

            lista.Adicionar(str);
            Assert.IsTrue(lista.ContemProximo());
        }

        [TestMethod()]
        public void ProximoTest()
        {
            String str = "Teste";
            String retorno = "";

            Lista<String> lista = new Lista<String>();
            lista.Adicionar(str);
            
            if (lista.ContemProximo())
                retorno = lista.Proximo().ToString();

            Assert.IsFalse(String.IsNullOrEmpty(retorno));
        }        

        [TestMethod()]
        public void RemoverTest()
        {
            String str = "Teste";
            String retorno = "";

            Lista<String> lista = new Lista<String>();
            lista.Adicionar(str);

            if (lista.ContemProximo())
                retorno = lista.Proximo().ToString();

            Assert.IsFalse(String.IsNullOrEmpty(retorno));

            lista.Remover(str);

            Assert.IsFalse(lista.ContemProximo());
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        public void RemoverTest1Helper<T>()
            where T : class
        {
            String str = "Teste";
            String retorno = "";

            Lista<String> lista = new Lista<String>();
            lista.Adicionar(str);

            if (lista.ContemProximo())
                retorno = lista.Proximo().ToString();

            Assert.IsFalse(String.IsNullOrEmpty(retorno));

            lista.Remover(1);

            Assert.IsFalse(lista.ContemProximo());
        }

        [TestMethod()]
        public void RemoverTest1()
        {
            RemoverTest1Helper<GenericParameterHelper>();
        }
    }
}
