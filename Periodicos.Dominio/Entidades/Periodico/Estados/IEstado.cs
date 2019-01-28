using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Periodicos.Dominio.Entidades.Periodico.Estados
{
    public abstract class IEstado
    {
        #region Atributos

        /// <summary>
        /// Armazena o artigo 
        /// </summary>
        protected IArtigo artigo;

        #endregion

        #region Construtores

        /// <summary>
        /// Define o estado do artigo 
        /// </summary>
        /// <param name="artigo">O artigo</param>
        public IEstado(IArtigo artigo)
        {
            this.artigo = artigo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Define o proximo estado do artigo
        /// </summary>
        /// <returns></returns>
        public abstract void ProximoEstado();

        #endregion
    }
}
