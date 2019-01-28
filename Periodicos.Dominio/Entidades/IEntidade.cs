using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Periodicos.Dominio.Entidades
{
    public interface IEntidade
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa um identificador
        /// </summary> 
        int Id { get; set; }
        
        #endregion
    }
}
