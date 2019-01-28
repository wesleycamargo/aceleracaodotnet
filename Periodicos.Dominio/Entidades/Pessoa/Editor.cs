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
    public class Editor
        : IEditor
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa o identificador do editor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define ou acessa o nome do editor
        /// </summary>
        public string Nome { get; set; }

        #endregion

        #region Constutores

        /// <summary>
        /// Construtor da classe editor
        /// </summary>
        public Editor() { }

        #endregion

        #region Metodos

        /// <summary>
        /// Encaminha os artigos para os avaliadores
        /// </summary>
        /// <param name="artigo"></param>
        /// <returns></returns>
        public IArtigo EncaminharArtigo(IArtigo artigo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cria uma edição com os artigos aceitos
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public IEdicao CriarEdicao(IEdicao numero)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
