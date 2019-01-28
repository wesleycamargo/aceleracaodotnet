using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public class Visitante
        : IVisitante
    {
        #region Atributos
		
        /// <summary>
        /// Define ou acessa o nome do visitante
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Define ou acessa o id do visitante
        /// </summary>
        public int Id { get; set; }
  
	    #endregion   
    }
}
