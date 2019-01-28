using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
// Base
//
using Base.Colecoes;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Pessoa;
using Periodicos.Dominio.Entidades.Periodico.Estados;
//

namespace Periodicos.Dominio.Entidades.Periodico
{
    public class Artigo
        : IArtigo
    {        
        #region Atributos

        #region IEntidade

        /// <summary>
        /// Define ou acessa o identificador do artigo
        /// </summary>
        public int Id { get; set; }

        #endregion

        /// <summary>
        /// Quantidade de avaliações positivas
        /// </summary>
        public int AvaliacoesPositivas { get; set; }
        /// <summary>
        /// Quantidade de avaliações negativas
        /// </summary>
        public  int AvaliacoesNegativas { get; set; }

        /// <summary>
        /// Define ou acessa uma Lista de autores do artigo
        /// </summary>
        public Lista<IAutor> Autores { get; set; }

        /// <summary>
        /// Define ou acessa uma lista de palavras chave do arquivo
        /// </summary>
        public Lista<string> PalavrasChave { get; set; }

        /// <summary>
        /// Define ou acessa um resumo do arquivo
        /// </summary>
        public string Resumo { get; set; }

        /// <summary>
        /// Define ou acessa o status do artigo
        /// </summary>
        public IEstado Status { get; set; }

        /// <summary>
        /// Define ou acessa o conteudo do artigo
        /// </summary>
        public string Conteudo { get; set; }

        #endregion        
    
        #region IArtigo

        /// <summary>
        /// Define ou acessa o nome do artigo
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Define ou acessa os avaliadores do artigo
        /// </summary>
        public Lista<IAvaliador> Avaliadores { get; set; }

        /// <summary>
        /// Define ou acessa o editor do artigo
        /// </summary>
        public IEditor Editor { get; set; }

        /// <summary>
        /// Define ou acessa a edição do artigo
        /// </summary>
        public IEdicao Edicao { get; set; }

        /// <summary>
        /// Define ou acessa os comentarios dos avaliadores
        /// </summary>
        public Lista<string> ComentariosAvaliadores { get; set; }

        /// <summary>
        /// Define ou acessa os comentarios do editor
        /// </summary>
        public string ComentarioEditor { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe artigo
        /// </summary>
        public Artigo()
        {
            Autores = new Lista<IAutor>();
            Avaliadores = new Lista<IAvaliador>();
            PalavrasChave = new Lista<String>();
            ComentariosAvaliadores = new Lista<String>();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Acessa o status do artigo
        /// </summary>
        /// <returns></returns>
        public String GetStatus()
        { 
            string retorno = "";
            
            if (Status is Apreciacao)
                retorno = "Apreciação";
            if (Status is Avaliacao)
                retorno = "Avaliação";
            if (Status is Aceito)
                retorno = "Aceito";
            if (Status is Inativo)
                retorno = "Inativo";
            
            return retorno;
        }

        #endregion
    }
}
