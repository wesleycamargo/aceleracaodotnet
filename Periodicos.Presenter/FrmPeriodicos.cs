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
    public partial class FrmPeriodicos 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena uma lista de periodicos
        /// </summary>
        private Lista<IPeriodico> periodicos;

        /// <summary>
        /// Armazena um objeto que simula um banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe frmPeriodicos
        /// </summary>
        public FrmPeriodicos()
        {
            try
            {
                InitializeComponent();

                this.bd = BancoDeDados.GetInstance();
                this.periodicos = new Lista<IPeriodico>();

                this.InicializaListView();
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
            this.periodicos = this.bd.SelecionarTodosPeriodicos();
        }

        /// <summary>
        /// Preenche o list view com as edições
        /// </summary>
        private void PreencheListView()
        {
            while (this.periodicos.ContemProximo())
            {
                this.lvPeriodicos.Clear();

                IPeriodico periodico = (IPeriodico)this.periodicos.Proximo();

                ComponentesHelper.AdicionaItemListView(periodico.Descricao, this.lvPeriodicos, 2);
                ComponentesHelper.AdicionaSubItemListView(this.lvPeriodicos.Items.Count - 1, periodico.Id.ToString(), this.lvPeriodicos);
            }
        }

        /// <summary>
        /// Inicializa corretamente o list view
        /// </summary>
        private void InicializaListView()
        {
            this.lvPeriodicos.View = View.Details;

            this.lvPeriodicos.SmallImageList = imgList;

            this.lvPeriodicos.Columns.Add("Nome");
            this.lvPeriodicos.Columns.Add("Id");
        }
        
        #endregion

        #region Eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroPeriodico periodicos = new FrmCadastroPeriodico();
                periodicos.ShowDialog();

                if (periodicos.Periodico != null)
                {
                    bd.AdicionarPublicacao(periodicos.Periodico);

                    while (periodicos.Periodico.Edicoes.ContemProximo())
                    {
                        IEdicao edicao = (IEdicao)periodicos.Periodico.Edicoes.Proximo();
                        edicao.Periodico = periodicos.Periodico;
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
