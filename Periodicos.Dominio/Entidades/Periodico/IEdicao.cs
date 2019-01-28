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
    public interface IEdicao        
        : IPublicacao
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa os artigos da edição
        /// </summary>
        ILista<IArtigo> Artigos { get; set; }

        /// <summary>
        /// Define ou acessa o periodico da edição
        /// </summary>
        IPeriodico Periodico { get; set; }

        /// <summary>
        /// Define ou acessa a descrição da edição
        /// </summary>
        String Descricao { get; set; }

        #endregion
    }
}
