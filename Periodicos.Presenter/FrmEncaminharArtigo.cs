using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
// Presenter
//
using Periodicos.Presenter.Helpers;
//
// Dominio
//
using Periodicos.Dominio.Entidades.Periodico;
using Periodicos.Dominio.Entidades.Pessoa;
//
// Base
//
using Base.Colecoes;
//
// Servico
//
using Periodicos.Servico.BD;
//

namespace Periodicos.Presenter
{
    public partial class FrmEncaminharArtigo
        : Form
    {
        #region Atributos

        /// <summary>
        /// Define ou acessa um artigo
        /// </summary>
        public IArtigo Artigo { get; set; }

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor do form encaminhar artigo
        /// </summary>
        private FrmEncaminharArtigo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor do form encaminhar artigo
        /// </summary>
        /// <param name="artigo"></param>
        public FrmEncaminharArtigo(IArtigo artigo)
        {
            try
            {
                InitializeComponent();

                this.Artigo = artigo;
                this.bd = BancoDeDados.GetInstance();

                this.txtNome.Text = artigo.Nome;

                this.lvAvaliadores.View = View.Details;
                this.lvAvaliadores.Columns.Add("Autores");
                this.lvAutores.View = View.Details;

                ComponentesHelper.AdicionaItemListView(artigo.Autores, this.lvAutores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Verifica se os campos obrigatorios estao preenchidos
        /// </summary>
        private void ValidarCampos()
        {
            this.Artigo.ComentarioEditor = this.txtComentarios.Text;

            Lista<String> nomesAvaliadores = ComponentesHelper.ListViewToLista(this.lvAvaliadores);

            while (nomesAvaliadores.ContemProximo())
            {
                IAvaliador avaliador = new Avaliador();
                avaliador.Nome = (String)nomesAvaliadores.Proximo();

                try
                {
                    avaliador = (IAvaliador)bd.AdicionarPessoa(avaliador);
                }
                catch (Exception)
                { }


                if (!this.Artigo.Avaliadores.Existe(avaliador))
                {
                    this.Artigo.Avaliadores.Adicionar(avaliador);
                }

            }
            if (this.Artigo.Avaliadores.Tamanho >= 2)
            {
                this.Close();
            }
            else
            {
                throw new Exception("O artigo deve ser encaminhado para no mínimo 2 avaliadores!");
            }
        }

        #endregion

        #region Eventos

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionaPalavraChave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtAvaliador.Text))
                {
                    ComponentesHelper.AdicionaItemListView(this.txtAvaliador.Text, this.lvAvaliadores);
                    this.txtAvaliador.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemovePalavraChave_Click(object sender, EventArgs e)
        {
            try
            {
                ComponentesHelper.RemoverItemListView(this.lvAvaliadores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}

