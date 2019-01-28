using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico;
using Base.Colecoes;
//

namespace Periodicos.Dominio.Entidades.Pessoa
{
    public class Avaliador
        : IAvaliador
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa o identificador do avaliador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define ou acessa o nome do avaliador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Define ou acessa os artigos avaliados
        /// </summary>
        public Lista<IArtigo> ArtigosAvaliados { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe avaliador
        /// </summary>
        public Avaliador()
        {
            this.ArtigosAvaliados = new Lista<IArtigo>();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Avalia um artigo enviado pelo Editor
        /// </summary>
        /// <param name="artigo">Artigo a ser avaliado</param>
        /// <returns>Artigo avaliado</returns>
        public IArtigo AvaliarArtigo(Periodico.IArtigo artigo)
        {
            throw new NotImplementedException();
        }

        #endregion        
    }
}
