using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico;
//

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public interface IAutor
        : IPessoa
    {
        #region Metodos

        IArtigo CriarArtigo();
        
        #endregion
    }
}
