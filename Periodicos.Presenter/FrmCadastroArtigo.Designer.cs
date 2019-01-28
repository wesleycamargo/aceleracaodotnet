namespace Periodicos.Presenter
{
    partial class FrmCadastroArtigo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroArtigo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlINferior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnRemoverComentario = new System.Windows.Forms.Button();
            this.btnAdicionarComentario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvComentarios = new System.Windows.Forms.ListView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverAutor = new System.Windows.Forms.Button();
            this.btnAdicionarAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lvAutores = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemovePalavraChave = new System.Windows.Forms.Button();
            this.btnAdicionaPalavraChave = new System.Windows.Forms.Button();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.lvPalavrasChave = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnlINferior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlINferior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 599);
            this.panel2.TabIndex = 6;
            // 
            // pnlINferior
            // 
            this.pnlINferior.AutoSize = true;
            this.pnlINferior.Controls.Add(this.panel1);
            this.pnlINferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlINferior.Location = new System.Drawing.Point(0, 0);
            this.pnlINferior.Name = "pnlINferior";
            this.pnlINferior.Size = new System.Drawing.Size(530, 599);
            this.pnlINferior.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 599);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnSalvar);
            this.panel6.Controls.Add(this.txtConteudo);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 365);
            this.panel6.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 24);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(8, 134);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(516, 195);
            this.txtConteudo.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtComentario);
            this.panel7.Controls.Add(this.btnRemoverComentario);
            this.panel7.Controls.Add(this.btnAdicionarComentario);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lvComentarios);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(530, 128);
            this.panel7.TabIndex = 0;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(8, 19);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.Size = new System.Drawing.Size(480, 20);
            this.txtComentario.TabIndex = 23;
            // 
            // btnRemoverComentario
            // 
            this.btnRemoverComentario.Enabled = false;
            this.btnRemoverComentario.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverComentario.Image")));
            this.btnRemoverComentario.Location = new System.Drawing.Point(494, 45);
            this.btnRemoverComentario.Name = "btnRemoverComentario";
            this.btnRemoverComentario.Size = new System.Drawing.Size(24, 24);
            this.btnRemoverComentario.TabIndex = 22;
            this.btnRemoverComentario.UseVisualStyleBackColor = true;
            this.btnRemoverComentario.Click += new System.EventHandler(this.btnRemoverComentario_Click);
            // 
            // btnAdicionarComentario
            // 
            this.btnAdicionarComentario.Enabled = false;
            this.btnAdicionarComentario.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarComentario.Image")));
            this.btnAdicionarComentario.Location = new System.Drawing.Point(494, 15);
            this.btnAdicionarComentario.Name = "btnAdicionarComentario";
            this.btnAdicionarComentario.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionarComentario.TabIndex = 21;
            this.btnAdicionarComentario.UseVisualStyleBackColor = true;
            this.btnAdicionarComentario.Click += new System.EventHandler(this.btnAdicionarComentario_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Comentarios";
            // 
            // lvComentarios
            // 
            this.lvComentarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvComentarios.Cursor = System.Windows.Forms.Cursors.No;
            this.lvComentarios.Location = new System.Drawing.Point(8, 45);
            this.lvComentarios.Name = "lvComentarios";
            this.lvComentarios.Size = new System.Drawing.Size(480, 80);
            this.lvComentarios.TabIndex = 0;
            this.lvComentarios.UseCompatibleStateImageBehavior = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.txtResumo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(530, 179);
            this.panel8.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoverAutor);
            this.groupBox2.Controls.Add(this.btnAdicionarAutor);
            this.groupBox2.Controls.Add(this.txtNomeAutor);
            this.groupBox2.Controls.Add(this.lvAutores);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autores";
            // 
            // btnRemoverAutor
            // 
            this.btnRemoverAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverAutor.Image")));
            this.btnRemoverAutor.Location = new System.Drawing.Point(220, 46);
            this.btnRemoverAutor.Name = "btnRemoverAutor";
            this.btnRemoverAutor.Size = new System.Drawing.Size(24, 24);
            this.btnRemoverAutor.TabIndex = 20;
            this.btnRemoverAutor.UseVisualStyleBackColor = true;
            this.btnRemoverAutor.Click += new System.EventHandler(this.btnRemoverAutor_Click);
            // 
            // btnAdicionarAutor
            // 
            this.btnAdicionarAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarAutor.Image")));
            this.btnAdicionarAutor.Location = new System.Drawing.Point(220, 16);
            this.btnAdicionarAutor.Name = "btnAdicionarAutor";
            this.btnAdicionarAutor.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionarAutor.TabIndex = 19;
            this.btnAdicionarAutor.UseVisualStyleBackColor = true;
            this.btnAdicionarAutor.Click += new System.EventHandler(this.btnAdicionarAutor_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(6, 18);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(208, 20);
            this.txtNomeAutor.TabIndex = 18;
            // 
            // lvAutores
            // 
            this.lvAutores.Location = new System.Drawing.Point(6, 42);
            this.lvAutores.Name = "lvAutores";
            this.lvAutores.Size = new System.Drawing.Size(208, 61);
            this.lvAutores.TabIndex = 11;
            this.lvAutores.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemovePalavraChave);
            this.groupBox1.Controls.Add(this.btnAdicionaPalavraChave);
            this.groupBox1.Controls.Add(this.txtPalavraChave);
            this.groupBox1.Controls.Add(this.lvPalavrasChave);
            this.groupBox1.Location = new System.Drawing.Point(274, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palavras Chave";
            // 
            // btnRemovePalavraChave
            // 
            this.btnRemovePalavraChave.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePalavraChave.Image")));
            this.btnRemovePalavraChave.Location = new System.Drawing.Point(220, 46);
            this.btnRemovePalavraChave.Name = "btnRemovePalavraChave";
            this.btnRemovePalavraChave.Size = new System.Drawing.Size(24, 24);
            this.btnRemovePalavraChave.TabIndex = 20;
            this.btnRemovePalavraChave.UseVisualStyleBackColor = true;
            this.btnRemovePalavraChave.Click += new System.EventHandler(this.btnRemovePalavraChave_Click);
            // 
            // btnAdicionaPalavraChave
            // 
            this.btnAdicionaPalavraChave.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionaPalavraChave.Image")));
            this.btnAdicionaPalavraChave.Location = new System.Drawing.Point(220, 16);
            this.btnAdicionaPalavraChave.Name = "btnAdicionaPalavraChave";
            this.btnAdicionaPalavraChave.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionaPalavraChave.TabIndex = 19;
            this.btnAdicionaPalavraChave.UseVisualStyleBackColor = true;
            this.btnAdicionaPalavraChave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(6, 18);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(208, 20);
            this.txtPalavraChave.TabIndex = 18;
            // 
            // lvPalavrasChave
            // 
            this.lvPalavrasChave.Location = new System.Drawing.Point(6, 42);
            this.lvPalavrasChave.Name = "lvPalavrasChave";
            this.lvPalavrasChave.Size = new System.Drawing.Size(208, 61);
            this.lvPalavrasChave.TabIndex = 12;
            this.lvPalavrasChave.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resumo";
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(8, 127);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(516, 40);
            this.txtResumo.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 55);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtEditor);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtStatus);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 56);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Editor";
            // 
            // txtEditor
            // 
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEditor.Location = new System.Drawing.Point(330, 27);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ReadOnly = true;
            this.txtEditor.Size = new System.Drawing.Size(94, 20);
            this.txtEditor.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStatus.Location = new System.Drawing.Point(430, 29);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(94, 20);
            this.txtStatus.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome do artigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(316, 20);
            this.txtNome.TabIndex = 15;
            // 
            // FrmCadastroArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 599);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Artigos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlINferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel pnlINferior;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel6;
        protected System.Windows.Forms.TextBox txtConteudo;
        protected System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ListView lvComentarios;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btnRemovePalavraChave;
        protected System.Windows.Forms.Button btnAdicionaPalavraChave;
        protected System.Windows.Forms.TextBox txtPalavraChave;
        protected System.Windows.Forms.ListView lvPalavrasChave;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtResumo;
        protected System.Windows.Forms.ListView lvAutores;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtStatus;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtNome;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btnRemoverAutor;
        protected System.Windows.Forms.Button btnAdicionarAutor;
        protected System.Windows.Forms.TextBox txtNomeAutor;
        protected System.Windows.Forms.Button btnRemoverComentario;
        protected System.Windows.Forms.Button btnAdicionarComentario;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtEditor;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.TextBox txtComentario;

    }
}