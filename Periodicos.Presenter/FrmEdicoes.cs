using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico;
//
// Base
//
using Base.Colecoes;
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
    public partial class FrmEdicoes 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena uma lista de edições
        /// </summary>
        private Lista<IEdicao> edicoes;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe frmEdicoes
        /// </summary>
        public FrmEdicoes()
        {
            try
            {
                InitializeComponent();

                this.bd = BancoDeDados.GetInstance();
                this.edicoes = bd.SelecionarTodasEdicoes();

                this.InicializaListView();
                this.PreencheListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        #region Metodos

        /// <summary>
        /// Atualiza a lista de edicoes
        /// </summary>
        private void AtualizarEdicoes()
        {
            this.edicoes = this.bd.SelecionarTodasEdicoes();
        }

        /// <summary>
        /// Preenche o list view com as edições
        /// </summary>
        private void PreencheListView()
        {
            while (this.edicoes.ContemProximo())
            {
                this.lvEdicoes.Clear();

                IEdicao edicao = (IEdicao)edicoes.Proximo();
                ComponentesHelper.AdicionaItemListView(edicao.Descricao, this.lvEdicoes);
                ComponentesHelper.AdicionaSubItemListView(this.lvEdicoes.Items.Count - 1, edicao.Id.ToString(), this.lvEdicoes);
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        private void InicializaListView()
        {
            this.lvEdicoes.View = View.Details;

            this.lvEdicoes.SmallImageList = imgList;

            this.lvEdicoes.Columns.Add("Nome");
            this.lvEdicoes.Columns.Add("Id");           
        }
        
        #endregion

        #region Eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroEdicoes edicoes = new FrmCadastroEdicoes();
                edicoes.ShowDialog();

                if (edicoes.Edicao != null)
                {
                    this.bd.AdicionarPublicacao(edicoes.Edicao);

                    while (edicoes.Edicao.Artigos.ContemProximo())
                    {
                        IArtigo artigo = (IArtigo)edicoes.Edicao.Artigos.Proximo();
                        artigo.Edicao = edicoes.Edicao;
                    }
                }

                this.AtualizarEdicoes();
                this.PreencheListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion
    }
}
