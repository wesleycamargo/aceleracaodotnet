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
// Servico
//
using Periodicos.Servico.BD;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico.Estados;
using Periodicos.Dominio.Entidades.Periodico;
//
// Presenter
//
using Periodicos.Presenter.Helpers;
//

namespace Periodicos.Presenter
{
    public partial class FrmCadastroEdicoes 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena uma lista de artigos da edicao
        /// </summary>
        private Lista<IArtigo> artigos;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        /// <summary>
        /// Armazena uma edição
        /// </summary>
        private IEdicao edicao;

        /// <summary>
        /// Define ou acessa uma edição
        /// </summary>
        public IEdicao Edicao { get; set; }

        #endregion

        #region Construtores

        public FrmCadastroEdicoes()
        {
            try
            {
                InitializeComponent();
                this.InicializaListView();
                this.bd = BancoDeDados.GetInstance();
                this.edicao = new Edicao();
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
        /// Atualiza a lista de artigos
        /// </summary>
        private void AtualizarArtigos()
        {
            Lista<IArtigo> artigos = new Lista<IArtigo>();
            IArtigo artigo;

            this.artigos = new Lista<IArtigo>();

            this.artigos.Limpar();


            artigos = bd.SelecionarArtigos();

            while (artigos.ContemProximo())
            {
                artigo = (IArtigo)artigos.Proximo();
                if (artigo.Status is Aceito)
                    this.artigos.Adicionar(artigo);
            }
        }

        /// <summary>
        /// Preenche o listview com os artigos do autor
        /// </summary>
        public void PreencheListView(Lista<IArtigo> artigos)
        {
            this.lvTodos.Items.Clear();

            int contador = 0;

            while (artigos.ContemProximo())
            {
                IArtigo artigo = (IArtigo)artigos.Proximo();

                if (artigo.Status is Aceito)
                {
                    ComponentesHelper.AdicionaItemListView(artigo.Nome, this.lvTodos, 0);
                    ComponentesHelper.AdicionaSubItemListView(contador, "Aceito", this.lvTodos);

                    this.lvTodos.Items[contador].SubItems.Add(artigo.Id.ToString());
                }
                contador++;
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        private void InicializaListView()
        {
            this.lvTodos.View = View.Details;

            this.lvTodos.SmallImageList = imgList;

            this.lvTodos.Columns.Add("Nome");
            this.lvTodos.Columns.Add("Status");
            this.lvTodos.Columns.Add("Id");

            this.lvTodos.Columns[2].Width = 0;

            this.lvArtigoEdicao.View = View.Details;

            this.lvArtigoEdicao.SmallImageList = imgList;

            this.lvArtigoEdicao.Columns.Add("Nome");
            this.lvArtigoEdicao.Columns.Add("Status");
            this.lvArtigoEdicao.Columns.Add("Id");

            this.lvArtigoEdicao.Columns[2].Width = 0;
        }

        /// <summary>
        /// Preenche a edição com os campos da tela
        /// </summary>
        private void PreencheEdicao()
        {
            Lista<IArtigo> artigos = GetIdArtigos();

            if (artigos != null)
            {
                artigos = PreencheArtigos(artigos);
            }

            this.edicao.Descricao = this.txtNomeEdicao.Text;
            this.edicao.Artigos = artigos;
        }

        /// <summary>
        /// Recupera o id dos artigos do listview
        /// </summary>
        /// <returns></returns>
        private Lista<IArtigo> GetIdArtigos()
        {
            Lista<IArtigo> artigos = null;

            if (!this.lvArtigoEdicao.Items.Count.Equals(0))
            {
                artigos = new Lista<IArtigo>();

                for (int i = 0; i < this.lvArtigoEdicao.Items.Count; i++)
                {
                    IArtigo artigo = new Artigo();

                    artigo.Id = Convert.ToInt32(this.lvArtigoEdicao.Items[i].SubItems[2].Text);

                    artigos.Adicionar(artigo);
                }
            }
            return artigos;
        }

        /// <summary>
        /// Preenche os artigos do listview
        /// </summary>
        /// <param name="artigos"></param>
        /// <returns></returns>
        private Lista<IArtigo> PreencheArtigos(Lista<IArtigo> artigos)
        {
            if (artigos != null)
            {
                if (artigos.ContemProximo())
                {
                    IArtigo artigo = (IArtigo)artigos.Proximo();

                    artigos = this.bd.SelecionarArtigoById(artigo);
                }
            }
            return artigos;
        }

        #endregion

        #region Eventos

        private void lvTodos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.lvArtigoEdicao.Items.Add(this.lvTodos.FocusedItem.Text);

                for (int i = 0; i < this.lvTodos.FocusedItem.SubItems.Count; i++)
                {
                    if (i.Equals(0))
                        i++;

                    this.lvArtigoEdicao.Items[this.lvArtigoEdicao.Items.Count - 1].SubItems.Add(this.lvTodos.FocusedItem.SubItems[i].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvArtigoEdicao.Items.Count > 0)
                {
                    this.PreencheEdicao();
                    this.Edicao = edicao;

                    this.Close();
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
