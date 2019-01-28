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
using Periodicos.Dominio.Entidades.Pessoa;
//
// Presenter
//
using Periodicos.Presenter.Helpers;
//
// Serviço
//
using Periodicos.Servico.BD;
//

namespace Periodicos.Presenter
{
    public partial class FrmInicial 
        : Form
    {
        #region Atributos

        /// <summary>
        /// Armazena um objeto que simula o banco de dados
        /// </summary>
        private BancoDeDados bd;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe frmInicial
        /// </summary>
        public FrmInicial()
        {
            try
            {
                InitializeComponent();

                this.bd = BancoDeDados.GetInstance();
                rdVisitante.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        #region Metodos Privados

        /// <summary>
        /// Adiciona um autor ao banco de dados
        /// </summary>
        /// <returns></returns>
        public IAutor SelecionarAutor()
        {
            IAutor autor = new Autor();

            autor.Nome = txtNome.Text;

            autor = (IAutor)this.bd.AdicionarPessoa(autor);        

            return autor;
        }

        /// <summary>
        /// Adiciona um editor ao banco de dados
        /// </summary>
        /// <returns></returns>
        public IEditor SelecionarEditor()
        {
            IEditor editor = new Editor();

            editor.Nome = txtNome.Text;

            editor = (IEditor)this.bd.AdicionarPessoa(editor);

            return editor;
        }

        /// <summary>
        /// Adiciona um avaliador ao banco de dados
        /// </summary>
        /// <returns></returns>
        public IAvaliador SelecionarAvaliador()
        {
            IAvaliador avaliador = new Avaliador();

            avaliador.Nome = txtNome.Text;

            avaliador = (IAvaliador)this.bd.AdicionarPessoa(avaliador);

            return avaliador;
        }        

        #endregion

        #region Eventos

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    IPessoa pessoa = new Visitante();

                    Form form = new Form();

                    if (rdAutor.Checked)
                    {
                        pessoa = SelecionarAutor();
                        form = new FrmAutor(pessoa);
                    }
                    if (rdEditor.Checked)
                    {
                        pessoa = SelecionarEditor();
                        form = new FrmEditor(pessoa);
                    }
                    if (rdAvaliador.Checked)
                    {
                        pessoa = SelecionarAvaliador();
                        form = new FrmAvaliador(pessoa);
                    }

                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Digite um nome de usuário!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComponentesHelper.ComponenteFocus(btnConfirma, e, 13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComponentesHelper.ComponenteFocus(btnConfirma, e, 13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdAvaliador_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComponentesHelper.ComponenteFocus(btnConfirma, e, 13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComponentesHelper.ComponenteFocus(btnConfirma, e, 13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
