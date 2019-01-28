using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Dominio
//
using Periodicos.Dominio.Entidades;
//

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public interface IPessoa 
        : IEntidade
    {
        #region Atributos

        String Nome { get; set; }
        
        #endregion
    }
}
