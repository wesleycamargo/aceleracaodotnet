using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
//
//
using Periodicos.Dominio.Entidades.Periodico.Estados;
using Periodicos.Dominio.Entidades.Periodico;
using Periodicos.Dominio.Entidades.Pessoa;
//
//
//
using Base.Colecoes;
//
//
//
using Periodicos.Servico.BD;
//
//
//
using Periodicos.Presenter.Helpers;
//

namespace Periodicos.Presenter
{
    public partial class FrmEditor 
         : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena uma pessoa autenticada
        /// </summary>
        private IPessoa pessoa;

        /// <summary>
        /// Armazena uma lista de artigos
        /// </summary>
        private Lista<IArtigo> artigos;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor do form Editor
        /// </summary>
        /// <param name="pessoa"></param>
        private FrmEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor do form Editor
        /// </summary>
        /// <param name="pessoa"></param>
        public FrmEditor(IPessoa pessoa)
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

                this.lblArtigos.Text = "Artigos em apreciação";
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
            Lista<IArtigo> artigos = new Lista<IArtigo>();
            IArtigo artigo;

            this.artigos.Limpar();

            artigos = this.bd.SelecionarArtigos();
            
            while (artigos.ContemProximo())
            {
                artigo = (IArtigo)artigos.Proximo();
                if (artigo.Status is Apreciacao)
                    this.artigos.Adicionar(artigo);
            }
        }

        /// <summary>
        /// Preenche o listview com os artigos do autor
        /// </summary>
        public void PreencheListView(Lista<IArtigo> artigos)
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

                    this.lvArtigos.Items[contador].SubItems.Add(artigo.Id.ToString());
                }                                
                contador++;
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        protected void InicializaListView()
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

        private void btnEdicoes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEdicoes edicoes = new FrmEdicoes();
                edicoes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void lvArtigos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
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
                }
                else
                {
                    throw new Exception("Arquivo nao encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEncaminhar_Click(object sender, EventArgs e)
        {
            try
            {
                Lista<IArtigo> resultado;
                IArtigo artigo = new Artigo();

                if (this.lvArtigos.FocusedItem != null)
                {
                    artigo.Id = Convert.ToInt32(this.lvArtigos.FocusedItem.SubItems[2].Text);
                }
                else
                {
                    MessageBox.Show("Selecione um artigo!");
                }

                resultado = this.bd.SelecionarArtigoById(artigo);
                if (resultado.ContemProximo())
                {
                    artigo = (IArtigo)resultado.Proximo();

                    FrmEncaminharArtigo encaminhar = new FrmEncaminharArtigo(artigo);
                    encaminhar.ShowDialog();

                    artigo = encaminhar.Artigo;
                    artigo.Editor = (IEditor)this.pessoa;

                    artigo.Status.ProximoEstado();

                    this.bd.AtualizarPublicacao(artigo);

                    this.AtualizarArtigos();

                    this.PreencheListView(this.artigos);
                }
                else
                {
                    throw new Exception("Arquivo nao encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
