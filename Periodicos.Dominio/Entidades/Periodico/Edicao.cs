using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Base
//
using Base.Colecoes;
//

namespace Periodicos.Dominio.Entidades.Periodico
{
    public class Edicao
        : IEdicao
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa o identificador da edição
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define ou acessa os artigos que compoem a edição
        /// </summary>
        public ILista<IArtigo> Artigos { get; set; }

        /// <summary>
        /// Define ou acessa o periodico que esta Edição pertence
        /// </summary>
        public IPeriodico Periodico { get; set; }

        /// <summary>
        /// Define ou acessa a descrição da edição
        /// </summary>
        public string Descricao { get; set; }

        #endregion               
    
        #region Contrutores

        public Edicao() { } 

        #endregion
    }
}
