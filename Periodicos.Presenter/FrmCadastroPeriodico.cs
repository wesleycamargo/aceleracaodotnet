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
using Periodicos.Dominio.Entidades.Periodico.Estados;
using Periodicos.Dominio.Entidades.Periodico;
//
// Dominio
//
using Base.Colecoes;
//
// Dominio
//
using Periodicos.Servico.BD;
//
// Dominio
//
using Periodicos.Presenter.Helpers;
//

namespace Periodicos.Presenter
{
    public partial class FrmCadastroPeriodico 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena um periodico
        /// </summary>
        private IPeriodico periodico;

        /// <summary>
        /// Armazena uma lista de edições
        /// </summary>
        private Lista<IEdicao> edicoes;

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        /// <summary>
        /// Armazena um periodico
        /// </summary>
        public IPeriodico Periodico { get; set; }

        #endregion

        #region Contrutores

        /// <summary>
        /// Construtor da classe Form CadastroPeriodico
        /// </summary>
        public FrmCadastroPeriodico()
        {
            try
            {
                InitializeComponent();

                this.periodico = new Periodico();
                this.bd = BancoDeDados.GetInstance();
                this.edicoes = bd.SelecionarTodasEdicoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        #region Metodos

        /// <summary>
        /// Atualiza a lista de edições
        /// </summary>
        private void AtualizarEdicoes()
        {
            this.edicoes = this.bd.SelecionarTodasEdicoes();
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
            this.lvTodos.Columns.Add("Id");


            this.lvEdicaoPeriodico.View = View.Details;

            this.lvEdicaoPeriodico.SmallImageList = imgList;

            this.lvEdicaoPeriodico.Columns.Add("Nome");
            this.lvEdicaoPeriodico.Columns.Add("Id");            
        }

        /// <summary>
        /// Preenche o periodico com os campos da tela
        /// </summary>
        private void PreenchePeriodico()
        {
            Lista<IEdicao> edicoes = this.GetIdEdicao();

            if (this.edicoes != null)
            {
                this.edicoes = this.PreencheEdicao(edicoes);
            }

            this.periodico.Descricao = this.txtDescricao.Text;
            this.periodico.Edicoes = this.edicoes;
        }

        /// <summary>
        /// Retorna os id das edicoes listadas
        /// </summary>
        /// <returns></returns>
        private Lista<IEdicao> GetIdEdicao()
        {
            Lista<IEdicao> edicoes = null;

            if (!this.lvEdicaoPeriodico.Items.Count.Equals(0))
            {
                edicoes = new Lista<IEdicao>();

                for (int i = 0; i < this.lvEdicaoPeriodico.Items.Count; i++)
                {
                    IEdicao edicao = new Edicao();

                    edicao.Id = Convert.ToInt32(this.lvEdicaoPeriodico.Items[i].SubItems[2].Text);
                }
            }
            return edicoes;
        }

        /// <summary>
        /// Preenche uma edicao com os campos da tela
        /// </summary>
        /// <param name="edicoes"></param>
        /// <returns></returns>
        private Lista<IEdicao> PreencheEdicao(Lista<IEdicao> edicoes)
        {
            if (edicoes != null)
            {
                while (edicoes.ContemProximo())
                {
                    IEdicao edicao = new Edicao();

                    edicoes = this.bd.SelecionarEdicaoById(edicao);
                }
            }
            return edicoes;
        }

        #endregion

        #region Eventos

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvEdicaoPeriodico.Items.Count > 0)
                {
                    this.PreenchePeriodico();
                    this.Periodico = periodico;

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
