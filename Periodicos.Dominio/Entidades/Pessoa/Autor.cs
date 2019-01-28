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
    public class Autor
        : IAutor
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa o identificador do autor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define ou acessa o nome do editor
        /// </summary>
        public string Nome { get; set; }

        #endregion

        #region Contrutores

        public Autor() { }

        #endregion

        #region Metodos

        /// <summary>
        /// Cria um novo artigo
        /// </summary>
        /// <returns></returns>
        public IArtigo CriarArtigo()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
