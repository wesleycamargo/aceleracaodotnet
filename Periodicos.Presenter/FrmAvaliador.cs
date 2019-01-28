using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
// Base
//
using Base.Colecoes;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico.Estados;
using Periodicos.Dominio.Entidades.Periodico;
using Periodicos.Dominio.Entidades.Pessoa;
using Periodicos.Presenter.Helpers;
//
// Serviço
//
using Periodicos.Servico.BD;
//

namespace Periodicos.Presenter
{
    public partial class FrmAvaliador 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena a pessoa autenticada na tela
        /// </summary>
        private IPessoa pessoa;

        /// <summary>
        /// Armazena os artigos do avaliador autenticado
        /// </summary>
        private Lista<IArtigo> artigos;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor do form Avaliador
        /// </summary>
        private FrmAvaliador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor do form Avaliador
        /// </summary>
        public FrmAvaliador(IPessoa avaliador)
        {
            InitializeComponent();
            this.pessoa = avaliador;
            this.bd = BancoDeDados.GetInstance();

            this.artigos = new Lista<IArtigo>();

            this.AtualizarArtigos();
            this.InicializaListView();

            this.PreencheListView(this.artigos);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Recupera os artigos do banco de dados
        /// </summary>
        private void AtualizarArtigos()
        {
            Lista<IArtigo> artigos = this.bd.SelecionarArtigoByAvaliador((IAvaliador)this.pessoa);
            
            while (artigos.ContemProximo())
	        {
                this.artigos.Limpar();

		        IArtigo artigo = (IArtigo)artigos.Proximo();

                while(artigo.Avaliadores.ContemProximo())
                {
                    IAvaliador avaliador = (IAvaliador)artigo.Avaliadores.Proximo();

                    if (avaliador.Id.Equals(this.pessoa.Id))
                    {
                        if (avaliador.ArtigosAvaliados == null || !avaliador.ArtigosAvaliados.Existe(artigo))
                        {
                            this.artigos.Adicionar(artigo);
                        }
                    }
                }
	        }            
        }

        /// <summary>
        /// Preenche o listview com os artigos do autor
        /// </summary>
        public void PreencheListView(Lista<IArtigo> artigos)
        {
            this.lvArtigos.Items.Clear();

            int contador = 0;

            this.AtualizarArtigos();

            while (artigos.ContemProximo())
            {
                IArtigo artigo = (IArtigo)artigos.Proximo();

                if (artigo.Status is Avaliacao)
                {
                    ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvArtigos, 1);
                    ComponentesHelper.AdicionaSubItemListView(contador, "Avaliação", this.lvArtigos);

                    this.lvArtigos.Items[contador].SubItems.Add(artigo.Id.ToString());
                }       
                contador++;
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        private void InicializaListView()
        {
            this.lvArtigos.View = View.Details;

            this.lvArtigos.SmallImageList = imgList;

            this.lvArtigos.Columns.Add("Nome");
            this.lvArtigos.Columns.Add("Status");
            this.lvArtigos.Columns.Add("Id");

            this.lvArtigos.Columns[2].Width = 0;
        }
        
        #endregion

        #region Eventos

        private void lvArtigos_DoubleClick(object sender, EventArgs e)
        {
            Lista<IArtigo> resultado;
            IArtigo artigo = new Artigo();

            artigo.Id = Convert.ToInt32(this.lvArtigos.FocusedItem.SubItems[2].Text);

            resultado = this.bd.SelecionarArtigoById(artigo);
            if (resultado.ContemProximo())
            {
                artigo = (IArtigo)resultado.Proximo();

                FrmCadastroArtigo cadastro = new FrmCadastroArtigo(this.pessoa, artigo);
                cadastro.ShowDialog();

                artigo = cadastro.Artigo;

                ((IAvaliador)this.pessoa).ArtigosAvaliados.Adicionar(artigo);

                this.bd.AtualizarPublicacao(artigo);

                this.AtualizarArtigos();
                this.PreencheListView(this.artigos);
            }
            else
            {
                throw new Exception("Arquivo nao encontrado!");
            }
        }

        #endregion
    }
}
