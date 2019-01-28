using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Periodicos.Dominio.Entidades.Periodico.Estados
{
    /// <summary>
    /// Estado inicial de um artigo
    /// </summary>
    public class Apreciacao
        : IEstado
    {
        #region Construtor

        /// <summary>
        /// Inicializa o construtor da classe abstrata
        /// </summary>
        /// <param name="artigo"></param>
        public Apreciacao(IArtigo artigo)
            : base(artigo){}

        #endregion

        #region Metodos

        /// <summary>
        /// Altera o estado de Apreciação para avaliação
        /// </summary>
        public override void ProximoEstado()
        {
            artigo.Status = new Avaliacao(artigo);
        }

        #endregion
    }
}
