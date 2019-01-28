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
// Presenter
//
using Periodicos.Presenter.Helpers;
//

namespace Periodicos.Presenter
{
    public partial class FrmCadastroArtigo 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena os autores do artigo
        /// </summary>
        private Lista<IAutor> autores;

        /// <summary>
        /// Armazena o artigo
        /// </summary>
        private IArtigo artigo;

        /// <summary>
        /// Armazena a pessoa autenticada na tela
        /// </summary>
        private IPessoa pessoa;

        /// <summary>
        /// Define ou acessa o artigo
        /// </summary>
        public IArtigo Artigo { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor do form Cadastro Artigo
        /// </summary>
        private FrmCadastroArtigo()
        {
        }

        /// <summary>
        /// Construtor do Cadastro de Artigos
        /// </summary>
        /// <param name="pessoa">Autor do artigo</param>        
        public FrmCadastroArtigo(IPessoa pessoa)
        {
            try
            {
                InitializeComponent();

                this.artigo = new Artigo();
                this.autores = new Lista<IAutor>();

                this.autores.Adicionar((IAutor)pessoa);
                this.pessoa = pessoa;

                ComponentesHelper.AdicionaItemListView(artigo.ComentarioEditor, this.lvComentarios);
                ComponentesHelper.AdicionaItemListView(artigo.ComentariosAvaliadores, this.lvComentarios);
                ComponentesHelper.AdicionaItemListView(artigo.PalavrasChave, this.lvPalavrasChave);
                ComponentesHelper.AdicionaItemListView(autores, this.lvAutores);

                this.InicializalvComentarios();
                this.InicializaComponentes(pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Construtor do Cadastro de Artigos
        /// </summary>
        /// <param name="pessoa">Autor do artigo</param>
        /// <param name="artigo">Artigo</param>
        public FrmCadastroArtigo(IPessoa pessoa, IArtigo artigo)
        {
            try
            {
                InitializeComponent();

                this.artigo = artigo;
                this.pessoa = pessoa;
                
                this.AdicionarAutores();

                ComponentesHelper.AdicionaItemListView(artigo.ComentarioEditor, this.lvComentarios);
                ComponentesHelper.AdicionaItemListView(artigo.ComentariosAvaliadores, this.lvComentarios);
                ComponentesHelper.AdicionaItemListView(artigo.PalavrasChave, this.lvPalavrasChave);
                ComponentesHelper.AdicionaItemListView(autores, this.lvAutores);

                this.PreencheCampos();

                this.InicializalvComentarios();
                this.InicializaComponentes(pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }          

        #endregion

        #region Metodos

        /// <summary>
        /// Preenche os campos da tela de acordo com os atributos do artigo
        /// </summary>
        public void PreencheCampos()
        {
            this.txtNome.Text = this.artigo.Nome;
            this.txtResumo.Text = this.artigo.Resumo;
            this.txtConteudo.Text = this.artigo.Conteudo;
        }

        /// <summary>
        /// Preenche a propriedade Artigo com os dados da tela
        /// </summary>        
        private void PreencheArtigo()
        {
            if (this.artigo == null)
                this.artigo = new Artigo();

            this.artigo.Nome = txtNome.Text;
            this.artigo.Resumo = txtResumo.Text;
            this.artigo.Conteudo = txtConteudo.Text;

            if (this.pessoa is Autor)
            {
                this.artigo.Status = new Apreciacao(this.artigo);
            }

            //retorno.Autores = ListViewToLista(lvAutores);
            this.artigo.PalavrasChave = ComponentesHelper.ListViewToLista(lvPalavrasChave);
            this.artigo.Autores = autores;

            this.Artigo = this.artigo;
        }
        
        /// <summary>
        /// Adiciona os autores do artigo no listview
        /// </summary>
        private void AdicionarAutores()
        {
            if (this.autores == null)
                this.autores = new Lista<IAutor>();

            if (this.artigo != null)
                this.autores = artigo.Autores;
        }

        /// <summary>
        /// Verifica se os campos obrigatorios da tela estao preenchidos
        /// </summary>
        /// <returns></returns>
        private bool ValidaTela()
        { 
            bool retorno = false;

            if (String.IsNullOrEmpty(txtNome.Text))
            {
                retorno = true;
                throw new Exception("Campo nome não preenchido!");
            }
            if (String.IsNullOrEmpty(txtConteudo.Text))
            {
                retorno = true;
                throw new Exception("Campo conteudo não preenchido!");
            }
            if (lvAutores.Items.Count == 0)
            {
                retorno = true;
                throw new Exception("O artigo deve conter ao menos um autor!");
            }
            if (lvPalavrasChave.Items.Count == 0)
            {
                retorno = true;
                throw new Exception("O artigo deve conter ao menos uma palavra chave!");
            }
            return retorno;
        }
        
        /// <summary>
        /// Inicializa corretamente o listview
        /// </summary>
        private void InicializalvComentarios()
        {
            this.lvComentarios.View = View.Details;

            this.lvComentarios.Columns.Add("Autor");
            this.lvComentarios.Columns.Add("Descrição");
        }

        /// <summary>
        /// Inicializa os componentes da tela de acordo com a pessoa logada
        /// </summary>
        public void InicializaAutor(IAutor autor)
        {
            this.lvComentarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverComentario.Enabled = btnAdicionarComentario.Enabled = false;

            if (!autores.Existe((IAutor)autor))
            {
                this.autores.Adicionar((IAutor)autor);
            }
        }

        /// <summary>
        /// Inicializa corretamente os atributos da classe
        /// </summary>
        private void InicializaComponentes(IPessoa pessoa)
        {
            if (pessoa is Autor)
            {
                this.InicializaAutor((IAutor)pessoa);
            }
            if (pessoa is Editor || pessoa is Avaliador)
            {
                this.InicializaEditorAvaliador(pessoa);
            }

            this.lvAutores.View = View.List;
            this.lvAutores.Columns.Add("Nome");

            this.txtStatus.Text = this.artigo.GetStatus();

            if (this.artigo.Editor != null)
                this.txtEditor.Text = this.artigo.Editor.Nome;

            this.lvPalavrasChave.View = View.List;
        }

        /// <summary>
        /// Inicializa os componentes da tela de acordo com a pessoa logada
        /// </summary>
        public void InicializaEditorAvaliador(IPessoa pessoa)
        {

            if (pessoa is Avaliador || pessoa is Editor)
            {
                this.lvComentarios.BackColor = System.Drawing.Color.White;
                this.btnRemoverComentario.Enabled = this.btnAdicionarComentario.Enabled = true;

                this.txtNome.Enabled = false;
                this.txtConteudo.Enabled = false;
                this.txtNomeAutor.Enabled = false;
                this.txtPalavraChave.Enabled = false;
                this.txtResumo.Enabled = false;
                this.txtComentario.ReadOnly = false;

                this.btnSalvar.Text = "Aprovado";
                this.btnCancelar.Text = "Reprovado";
            }
        }        
        
        #endregion

        #region Eventos

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtPalavraChave.Text))
                    ComponentesHelper.AdicionaItemListView(this.txtPalavraChave.Text, this.lvPalavrasChave);

                this.txtPalavraChave.Clear();
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
                ComponentesHelper.RemoverItemListView(this.lvPalavrasChave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.artigo.Status != null)
                {
                    if (this.artigo.Status is Avaliacao)
                    {
                        this.artigo.AvaliacoesNegativas++;
                        this.artigo.Status.ProximoEstado();
                    }
                }
                this.PreencheArtigo();

                this.Close();
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
                if (!ValidaTela())
                {

                    if (this.artigo.Status != null)
                    {
                        if (this.artigo.Status is Avaliacao)
                        {
                            this.artigo.AvaliacoesPositivas++;
                            this.artigo.Status.ProximoEstado();
                        }
                    }

                    this.PreencheArtigo();

                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtNomeAutor.Text))
                {
                    IAutor autor = new Autor();

                    autor.Nome = this.txtNomeAutor.Text;

                    // Recupera a instancia do banco de dados ja inicializada
                    BancoDeDados bd = BancoDeDados.GetInstance();
                    bd.AdicionarPessoa(autor);

                    this.autores.Adicionar(autor);

                    ComponentesHelper.AdicionaItemListView(autor.Nome, this.lvAutores);

                    this.txtNomeAutor.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoverAutor_Click(object sender, EventArgs e)
        {
            try
            {
                ComponentesHelper.RemoverItemListView(this.lvAutores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                ComponentesHelper.AdicionaItemListView(this.txtComentario.Text, this.lvComentarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoverComentario_Click(object sender, EventArgs e)
        {
            try
            {
                ComponentesHelper.RemoverItemListView(this.lvComentarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
