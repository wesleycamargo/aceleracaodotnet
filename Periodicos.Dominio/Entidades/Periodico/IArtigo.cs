using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Base
//
using Base.Colecoes;
//
// Pessoa
//
using Periodicos.Dominio.Entidades.Pessoa;
using Periodicos.Dominio.Entidades.Periodico.Estados;
//

namespace Periodicos.Dominio.Entidades.Periodico
{
    public interface IArtigo
        : IPublicacao
    {
        #region Propriedades
        
        String Nome { get; set; }

        int AvaliacoesPositivas { get; set; }
        int AvaliacoesNegativas { get; set; }

        Lista<IAvaliador> Avaliadores { get; set; }
        Lista<IAutor> Autores { get; set; }        
        IEditor Editor { get; set; }

        Lista<String> PalavrasChave { get; set; }
        IEdicao Edicao { get; set; }        
        String Resumo { get; set; }
        String Conteudo { get; set; }

        IEstado Status { get; set; }

        Lista<String> ComentariosAvaliadores { get; set; }
        String ComentarioEditor { get; set; }        

        #endregion

        #region Metodos

        /// <summary>
        /// Acessa o status atual do artigo
        /// </summary>
        /// <returns></returns>
        String GetStatus();

        #endregion
    }
}
