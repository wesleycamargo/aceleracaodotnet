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
using Periodicos.Dominio.Entidades;
using Periodicos.Dominio.Entidades.Periodico;
using Periodicos.Dominio.Entidades.Pessoa;
//

namespace Periodicos.Servico.BD
{
    public class BancoDeDados
    {
        #region Atributos

        /// <summary>
        /// Instancia estatica da classe
        /// </summary>
        private static BancoDeDados bd;        

        /// <summary>
        /// Armazena os artigos
        /// </summary>
        private Lista<IArtigo> Artigos;

        /// <summary>
        /// Armazena as edições
        /// </summary>
        private Lista<IEdicao> Edicoes;

        /// <summary>
        /// Armazena os periodicos
        /// </summary>
        private Lista<IPeriodico> Periodicos;


        /// <summary>
        /// Armazena os autores
        /// </summary>
        private Lista<IAutor> Autores;

        /// <summary>
        /// Armazena os editores
        /// </summary>
        private Lista<IEditor> Editores;

        /// <summary>
        /// Armazena os avaliadores
        /// </summary>
        private Lista<IAvaliador> Avaliadores;        

        #endregion

        #region Construtores
        
        /// <summary>
        /// Construtor da classe banco de dados. Para recuperar uma instancia da classe utilize o metodo GetInstance()
        /// </summary>
        private BancoDeDados()
        {
            #region Periodicos

            if (Artigos == null)
                Artigos = new Lista<IArtigo>();
            if (Edicoes == null)
                Edicoes = new Lista<IEdicao>();
            if (Periodicos == null)
                Periodicos = new Lista<IPeriodico>();

            #endregion

            #region Pessoa

            if (Autores == null)
                Autores = new Lista<IAutor>();
            if (Editores == null)
                Editores = new Lista<IEditor>();
            if (Avaliadores == null)
                Avaliadores = new Lista<IAvaliador>();

            #endregion
        }

        #endregion

        #region Metodos

        #region Atualizar

        /// <summary>
        /// Adiciona uma publicação
        /// </summary>
        /// <param name="publicacao"></param>
        public void AtualizarPublicacao(IPublicacao publicacao)
        {
            Artigos.Remover((IArtigo)publicacao);
            Artigos.Adicionar((IArtigo)publicacao);
        }

        #endregion

        #region Adicionar

        /// <summary>
        /// Adiciona uma publicação
        /// </summary>
        /// <param name="publicacao"></param>
        public void AdicionarPublicacao(IPublicacao publicacao)
        {
            if (publicacao is IArtigo)
            {
                if (!VerificaIdentityArtigos(publicacao, Artigos))
                {
                    publicacao.Id = Artigos.Tamanho + 1;
                    AdicionarArtigo((IArtigo)publicacao);
                }
                else
                    throw new Exception(String.Format("Artigo ja cadastrado com o id {0}", publicacao.Id));
            }
            else if (publicacao is IEdicao)
            {
                if (!VerificaIdentityEdicao(publicacao, Edicoes))
                {
                    publicacao.Id = Edicoes.Tamanho + 1;
                    AdicionarEdicao((IEdicao)publicacao);
                }
                else
                    throw new Exception(String.Format("Edição ja cadastrada com o id {0}", publicacao.Id));
            }
            else if (publicacao is IPeriodico)
            {
                if (!VerificaIdentityPeriodicos(publicacao, Periodicos))
                {
                    publicacao.Id = Periodicos.Tamanho + 1;
                    AdicionarPeriodico((IPeriodico)publicacao);
                }
                else
                    throw new Exception(String.Format("Periodico ja cadastrado com o id {0}", publicacao.Id));
            }
        }

        /// <summary>
        /// Adiciona uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        public IPessoa AdicionarPessoa(IPessoa pessoa)
        {
            IPessoa retorno = null;

            if (pessoa is IAutor)
            {
                if (!VerificaIdentityAutores(pessoa, Autores))
                {
                    pessoa.Id = Autores.Tamanho + 1;
                    AdicionarAutor((IAutor)pessoa);
                }
                else
                {
                    //throw new Exception(String.Format("Autor ja cadastrado com o id {0}", pessoa.Id));
                    retorno = SelecionarPessoaByNome(pessoa);
                }
                    
            }
            else if (pessoa is IEditor)
            {
                if (!VerificaIdentityEditores(pessoa, Editores))
                {
                    pessoa.Id = Editores.Tamanho + 1;
                    AdicionarEditor((IEditor)pessoa);                    
                }
                else
                {
                    retorno = SelecionarPessoaByNome(pessoa);
                }
            }
            else if (pessoa is IAvaliador)
            {
                if (!VerificaIdentityAvaliadores(pessoa, Avaliadores))
                {
                    pessoa.Id = Avaliadores.Tamanho + 1;
                    AdicionarAvaliador((IAvaliador)pessoa);
                }
                else
                {
                    retorno = SelecionarPessoaByNome(pessoa);
                }
            }

            if(retorno == null)
                retorno = pessoa;

            return retorno;
        }

        #endregion                           

        #region Identity

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="entidade"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityArtigos(IEntidade entidade, Lista<IArtigo> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IEntidade)lista.Proximo()).Id.Equals(entidade.Id))
                    retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="entidade"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityEdicao(IEntidade entidade, Lista<IEdicao> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IEntidade)lista.Proximo()).Id.Equals(entidade.Id))
                    retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="entidade"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityPeriodicos(IEntidade entidade, Lista<IPeriodico> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IEntidade)lista.Proximo()).Id.Equals(entidade.Id))
                    retorno = true;
            }
            return retorno;
        }        

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityAutores(IPessoa pessoa, Lista<IAutor> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IPessoa)lista.Proximo()).Nome.Equals(pessoa.Nome))
                    retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="entidade"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityEditores(IPessoa pessoa, Lista<IEditor> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IPessoa)lista.Proximo()).Nome.Equals(pessoa.Nome))
                    retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica se a entidade ja existe na lista informada
        /// </summary>
        /// <param name="entidade"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        private bool VerificaIdentityAvaliadores(IPessoa pessoa, Lista<IAvaliador> lista)
        {
            bool retorno = false;

            while (lista.ContemProximo())
            {
                if (((IPessoa)lista.Proximo()).Nome.Equals(pessoa.Nome))
                    retorno = true;
            }
            return retorno;
        }
        
        #endregion

        #region Adicionar Private

        /// <summary>
        /// Adiciona um artigo
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarArtigo(IArtigo artigo)
        {
            this.Artigos.Adicionar(artigo);
        }

        /// <summary>
        /// Adiciona uma edição
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarEdicao(IEdicao edicao)
        {
            this.Edicoes.Adicionar(edicao);
        }

        /// <summary>
        /// Adiciona um periodico
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarPeriodico(IPeriodico periodico)
        {
            this.Periodicos.Adicionar(periodico);
        }       

        /// <summary>
        /// Adiciona um autor
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarAutor(IAutor autor)
        {
            this.Autores.Adicionar(autor);
        }

        /// <summary>
        /// Adiciona um editor
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarEditor(IEditor editor)
        {
            this.Editores.Adicionar(editor);
        }

        /// <summary>
        /// Adiciona um avaliador
        /// </summary>
        /// <param name="artigo"></param>
        private void AdicionarAvaliador(IAvaliador avaliador)
        {
            this.Avaliadores.Adicionar(avaliador);
        }        

        #endregion

        #region Selecionar

        #region Selecionar

        #region Publicacoes

        /// <summary>
        /// Seleciona um artigo
        /// </summary>
        /// <param name="artigo"></param>
        /// <returns></returns>
        private IArtigo SelecionarArtigo(IArtigo artigo)
        {
            IArtigo retorno = null;

            if (artigo.Id != null || !artigo.Id.Equals(0))
                retorno = Artigos.Buscar(artigo);

            return retorno;
        }


        /// <summary>
        /// Seleciona uma edição
        /// </summary>
        /// <param name="edicao"></param>
        /// <returns></returns>
        private IEdicao SelecionarEdicao(IEdicao edicao)
        {
            IEdicao retorno = null;

            if (edicao.Id != null || !edicao.Id.Equals(0))
                retorno = Edicoes.Buscar(edicao);

            return retorno;
        }

        /// <summary>
        /// Seleciona um periodico
        /// </summary>
        /// <param name="periodico"></param>
        /// <returns></returns>
        private IPeriodico SelecionarPeriodico(IPeriodico periodico)
        {
            IPeriodico retorno = null;

            if (periodico.Id != null || !periodico.Id.Equals(0))
                retorno = Periodicos.Buscar(periodico);

            return retorno;
        }

        #endregion

        #region Pessoa

        /// <summary>
        /// Seleciona um autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        private IAutor SelecionarAutor(IAutor autor)
        {
            IAutor retorno = null;

            if (autor.Id != null || !autor.Id.Equals(0))
            {
                retorno = Autores.Buscar(autor);
            }
            else
            {
                retorno = (IAutor)SelecionarPessoaByNome(autor);
            }

            return retorno;
        }


        private IPessoa SelecionarPessoaByNome(IPessoa pessoa)
        {
            IPessoa retorno = null;

            if (pessoa is IAutor)
            {
                Lista<IAutor> autores = SelecionarTodosAutores();
                
                while (autores.ContemProximo())
                {
                    IAutor autor = (IAutor)autores.Proximo();

                    if (autor.Nome.Equals(pessoa.Nome))
                    {
                        retorno = autor;
                    }
                }
            }

            if (pessoa is IEditor)
            {
                Lista<IEditor> editores = SelecionarTodasEditores();

                while (editores.ContemProximo())
                {
                    IEditor editor = (IEditor)editores.Proximo();

                    if (editor.Nome.Equals(pessoa.Nome))
                    {
                        retorno = editor;
                    }
                }
            }

            if (pessoa is IAvaliador)
            {
                Lista<IAvaliador> avaliadores = SelecionarTodosAvaliadores();

                while (avaliadores.ContemProximo())
                {
                    IAvaliador avaliador = (IAvaliador)avaliadores.Proximo();

                    if (avaliador.Nome.Equals(pessoa.Nome))
                    {
                        retorno = avaliador;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Seleciona um editor
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        private IEditor SelecionarEditor(IEditor editor)
        {
            IEditor retorno = null;

            if (editor.Id != null || !editor.Id.Equals(0))
                retorno = Editores.Buscar(editor);

            return retorno;
        }

        /// <summary>
        /// Seleciona um avaliador
        /// </summary>
        /// <param name="avaliador"></param>
        /// <returns></returns>
        private IAvaliador SelecionarAvaliador(IAvaliador avaliador)
        {
            IAvaliador retorno = null;

            if (avaliador.Id != null || !avaliador.Id.Equals(0))
                retorno = Avaliadores.Buscar(avaliador);

            return retorno;
        }

        #endregion

        #endregion

        #region Selecionar Todos

        #region Publicacoes

        /// <summary>
        /// Seleciona todos os artigos
        /// </summary>
        /// <returns>Uma lista de IArtigo</returns>
        public Lista<IArtigo> SelecionarArtigos()
        {
            return this.Artigos;
        }

        /// <summary>
        /// Seleciona todos as edições
        /// </summary>
        /// <returns>Uma lista de IEdicao</returns>
        public Lista<IEdicao> SelecionarTodasEdicoes()
        {
            return this.Edicoes;
        }

        /// <summary>
        /// Seleciona todos os periodicos
        /// </summary>
        /// <returns>Uma lista de IPeriodico</returns>
        public Lista<IPeriodico> SelecionarTodosPeriodicos()
        {
            return this.Periodicos;
        }

        #endregion

        #region Pessoa

        /// <summary>
        /// Seleciona todos os autores
        /// </summary>
        /// <returns>Uma lista de IAutor</returns>
        public Lista<IAutor> SelecionarTodosAutores()
        {
            return this.Autores;
        }

        /// <summary>
        /// Seleciona todos os editores
        /// </summary>
        /// <returns>Uma lista de IEditor</returns>
        public Lista<IEditor> SelecionarTodasEditores()
        {
            return this.Editores;
        }

        /// <summary>
        /// Seleciona todos os avaliadores
        /// </summary>
        /// <returns>Uma lista de IAvaliador</returns>
        public Lista<IAvaliador> SelecionarTodosAvaliadores()
        {
            return this.Avaliadores;
        }

        #endregion

        #endregion

        #region Selecionar By Id

        /// <summary>
        /// Seleciona um artigo por id
        /// </summary>
        /// <param name="periodico"></param>
        /// <returns></returns>
        public Lista<IArtigo> SelecionarArtigoById(IArtigo artigo)
        {
            Lista<IArtigo> retorno = new Lista<IArtigo>();

            while (Artigos.ContemProximo())
            {
                IArtigo artigoRetorno = (IArtigo)Artigos.Proximo();

                if (artigoRetorno.Id.Equals(artigo.Id))
                {
                    retorno.Adicionar(artigoRetorno);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona uma edição por id
        /// </summary>
        /// <param name="periodico"></param>
        /// <returns></returns>
        public Lista<IEdicao> SelecionarEdicaoById(IEdicao edicao)
        {
            Lista<IEdicao> retorno = new Lista<IEdicao>();

            while (Edicoes.ContemProximo())
            {
                IEdicao edicaoRetorno = (IEdicao)Edicoes.Proximo();

                if (edicao.Id.Equals(edicao.Id))
                {
                    retorno.Adicionar(edicaoRetorno);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Seleciona um periodico por id
        /// </summary>
        /// <param name="periodico"></param>
        /// <returns></returns>
        public Lista<IPeriodico> SelecionarPeriodicoById(IPeriodico periodico)
        {
            Lista<IPeriodico> retorno = new Lista<IPeriodico>();

            while (Periodicos.ContemProximo())
            {
                IPeriodico periodicoRetorno = (IPeriodico)Edicoes.Proximo();

                if (periodico.Id.Equals(periodico.Id))
                {
                    retorno.Adicionar(periodicoRetorno);
                }
            }
            return retorno;
        }

        #endregion

        #region Selecionar By Autor

        /// <summary>
        /// Busca uma lista com os artigos criados pelo autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        public Lista<IArtigo> SelecionarArtigoByAutor(IAutor autor)
        {
            Lista<IArtigo> retorno = new Lista<IArtigo>();

            while (Artigos.ContemProximo())
            {
                IArtigo artigoRetorno = (IArtigo)Artigos.Proximo();

                while (artigoRetorno.Autores.ContemProximo())
                {
                    IAutor autorRetorno = (IAutor)artigoRetorno.Autores.Proximo();

                    if (autor.Id.Equals(autorRetorno.Id))
                    {
                        retorno.Adicionar(artigoRetorno);
                    }
                }
            }
            return retorno;
        }

        #endregion

        #region Selecionar By Avaliador

        /// <summary>
        /// Busca uma lista com os artigos avaliados pelo avaliador
        /// </summary>
        /// <param name="avaliador"></param>
        /// <returns></returns>
        public Lista<IArtigo> SelecionarArtigoByAvaliador(IAvaliador avaliador)
        {
            Lista<IArtigo> retorno = new Lista<IArtigo>();

            while (Artigos.ContemProximo())
            {
                IArtigo artigoRetorno = (IArtigo)Artigos.Proximo();

                while (artigoRetorno.Avaliadores.ContemProximo())
                {
                    IAvaliador avaliadorRetorno = (IAvaliador)artigoRetorno.Avaliadores.Proximo();

                    if (avaliador.Id.Equals(avaliadorRetorno.Id))
                    {
                        retorno.Adicionar(artigoRetorno);
                    }
                }
            }
            return retorno;
        }

        #endregion

        #endregion        

        #endregion

        #region Metodos Estaticos

        /// <summary>
        /// Retorna um objeto BancoDeDados instanciado
        /// </summary>
        /// <returns></returns>
        public static BancoDeDados GetInstance()
        {
            // Garante que apenas uma instancia sera criada em todo o sistema
            if (bd == null)
                bd = new BancoDeDados();

            return bd;
        }

        #endregion
    }
}
