using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Periodicos.Dominio.Entidades.Pessoa;

namespace Periodicos.Dominio.Entidades.Periodico.Estados
{
    public class Avaliacao
        : IEstado
    {
        #region Construtores

        /// <summary>
        /// Inicializa o construtor da classe abstrata
        /// </summary>
        /// <param name="artigo"></param>
        public Avaliacao(IArtigo artigo)
            : base(artigo) { }

        #endregion

        #region Metodos

        /// <summary>
        /// Define o proximo estado do artigo
        /// </summary>
        public override void ProximoEstado()
        {
            //Enquanto nao for avaliado por todos os avaliadores, nao altera status
            if (artigo.Avaliadores.Tamanho.Equals(artigo.AvaliacoesNegativas + artigo.AvaliacoesPositivas))
            {                
                // Se numero de rejeição for maior que aceitação, Status = Inativo
                if (artigo.AvaliacoesNegativas > artigo.AvaliacoesPositivas)
                {
                    artigo.Status = new Inativo(artigo);
                }
                // Se numero de aceitaçãofor maior que rejeição, Status = Aceito
                else if (artigo.AvaliacoesPositivas > artigo.AvaliacoesNegativas)
                {
                    artigo.Status = new Aceito(artigo);
                }
                //Se houve empate nas avaliações, Status retorna para apreciação
                else if (artigo.AvaliacoesPositivas.Equals(artigo.AvaliacoesNegativas))
                {
                    artigo.Status = new Apreciacao(artigo);
                    LimparAvaliadores();
                    artigo.Avaliadores.Limpar();
                }
            }            
        }

        /// <summary>
        /// Remove o artigo dos avaliadores
        /// </summary>
        /// <returns></returns>
        private void LimparAvaliadores()
        { 
            while(artigo.Avaliadores.ContemProximo())
            {
                IAvaliador avaliador = (IAvaliador)artigo.Avaliadores.Proximo();
                while (avaliador.ArtigosAvaliados.ContemProximo())
                {
                    IArtigo a = (IArtigo)avaliador.ArtigosAvaliados.Proximo();

                    avaliador.ArtigosAvaliados.Remover(a);
                }
            }
        }

        #endregion
    }
}
