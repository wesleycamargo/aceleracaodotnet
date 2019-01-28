using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico;
//
// Base
//
using Base.Colecoes;
//

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public interface IAvaliador
        : IPessoa
    {
        #region Atributos

        Lista<IArtigo> ArtigosAvaliados { get; set; }

        #endregion

        #region Metodos

        IArtigo AvaliarArtigo(IArtigo artigo);

        #endregion
    }
}
