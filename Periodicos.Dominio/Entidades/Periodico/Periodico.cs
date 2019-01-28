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
    public class Periodico
        : IPeriodico
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa o identificador do periodico
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define ou acessa as edições que compoem o periodico
        /// </summary>
        public ILista<IEdicao> Edicoes { get; set; }

        /// <summary>
        /// Define ou acessa a descricao do periodico
        /// </summary>
        public string Descricao { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe periodico
        /// </summary>
        public Periodico() { }

        #endregion
    }
}
