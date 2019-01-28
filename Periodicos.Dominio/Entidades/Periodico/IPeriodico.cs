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
    public interface IPeriodico
        : IPublicacao
    {
        #region Atributos
		
        /// <summary>
        /// Define ou acessa as edições do periodico
        /// </summary>
        ILista<IEdicao> Edicoes { get; set; }

        /// <summary>
        /// Define ou acessa a descrição do periodico
        /// </summary>
        String Descricao { get; set; }

	    #endregion
    }
}
