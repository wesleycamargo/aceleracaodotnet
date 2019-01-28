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
//
// Servico
//
using Periodicos.Servico.BD;
//
// Presenter
//
using Periodicos.Presenter.Helpers;
//

namespace Periodicos.Presenter
{
    public partial class FrmAutor 
         : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena a pessoa autenticada na tela
        /// </summary>
        private IPessoa pessoa;

        /// <summary>
        /// Armazena os artigos do autor autenticado
        /// </summary>
        private Lista<IArtigo> artigos;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor do form Autor
        /// </summary>
        /// <param name="pessoa"></param>
        private FrmAutor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor do form Autor
        /// </summary>
        /// <param name="pessoa"></param>
        public FrmAutor(IPessoa pessoa)
        {
            try
            {
                InitializeComponent();

                this.pessoa = pessoa;
                this.bd = BancoDeDados.GetInstance();
                this.artigos = new Lista<IArtigo>();

                this.InicializaListView();
                this.AtualizarArtigos();
                this.PreencheListView(this.artigos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        
        #endregion

        #region Metodos

        /// <summary>
        /// Recupera os artigos do banco de dados
        /// </summary>
        private void AtualizarArtigos()
        {
            try
            {
                this.artigos = this.bd.SelecionarArtigoByAutor((IAutor)this.pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Preenche o listview com os artigos do autor
        /// </summary>
        public void PreencheListView(Lista<IArtigo> artigos)
        {
            try
            {
                this.lvArtigos.Items.Clear();

                int contador = 0;

                while (artigos.ContemProximo())
                {
                    IArtigo artigo = (IArtigo)artigos.Proximo();

                    if (artigo.Status is Apreciacao)
                    {
                        ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvArtigos, 0);
                        ComponentesHelper.AdicionaSubItemListView(contador, "Apreciação", this.lvArtigos);
                    }
                    else if (artigo.Status is Avaliacao)
                    {
                        ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvArtigos, 1);
                        ComponentesHelper.AdicionaSubItemListView(contador, "Avaliação", this.lvArtigos);
                    }
                    else if (artigo.Status is Aceito)
                    {
                        ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvArtigos, 2);
                        ComponentesHelper.AdicionaSubItemListView(contador, "Aceito", this.lvArtigos);
                    }
                    else if (artigo.Status is Inativo)
                    {
                        ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvArtigos, 3);
                        ComponentesHelper.AdicionaSubItemListView(contador, "Inativo", this.lvArtigos);
                    }

                    this.lvArtigos.Items[contador].SubItems.Add(artigo.Id.ToString());

                    contador++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        private void InicializaListView()
        {
            try
            {
                this.lvArtigos.View = View.Details;

                this.lvArtigos.SmallImageList = imgList;

                this.lvArtigos.Columns.Add("Nome");
                this.lvArtigos.Columns.Add("Status");
                this.lvArtigos.Columns.Add("Id");

                this.lvArtigos.Columns[2].Width = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Eventos

        private void lvArtigos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Lista<IArtigo> resultado;
                IArtigo artigo = new Artigo();

                artigo.Id = Convert.ToInt32(this.lvArtigos.FocusedItem.SubItems[2].Text);

                resultado = bd.SelecionarArtigoById(artigo);
                if (resultado.ContemProximo())
                {
                    artigo = (IArtigo)resultado.Proximo();

                    FrmCadastroArtigo cadastro = new FrmCadastroArtigo(this.pessoa, artigo);
                    cadastro.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroArtigo cadastro = new FrmCadastroArtigo((IAutor)this.pessoa);
                cadastro.ShowDialog();

                IArtigo artigo = cadastro.Artigo;

                bd.AdicionarPublicacao(artigo);

                AtualizarArtigos();

                PreencheListView(this.artigos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion
    }
}
