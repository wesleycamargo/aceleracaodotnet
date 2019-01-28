namespace Periodicos.Presenter
{
    partial class FrmEncaminharArtigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEncaminharArtigo));
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvAutores = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemovePalavraChave = new System.Windows.Forms.Button();
            this.btnAdicionaPalavraChave = new System.Windows.Forms.Button();
            this.txtAvaliador = new System.Windows.Forms.TextBox();
            this.lvAvaliadores = new System.Windows.Forms.ListView();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCancelar);
            this.panel7.Controls.Add(this.btnConfirmar);
            this.panel7.Controls.Add(this.txtComentarios);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 80);
            this.panel7.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(91, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(9, 40);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(76, 24);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(8, 14);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(510, 20);
            this.txtComentarios.TabIndex = 23;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 56);
            this.panel4.TabIndex = 26;
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
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Location = new System.Drawing.Point(8, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(510, 20);
            this.txtNome.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(534, 119);
            this.panel8.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvAutores);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autores";
            // 
            // lvAutores
            // 
            this.lvAutores.BackColor = System.Drawing.SystemColors.Menu;
            this.lvAutores.Location = new System.Drawing.Point(6, 19);
            this.lvAutores.Name = "lvAutores";
            this.lvAutores.Size = new System.Drawing.Size(238, 84);
            this.lvAutores.TabIndex = 11;
            this.lvAutores.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemovePalavraChave);
            this.groupBox1.Controls.Add(this.btnAdicionaPalavraChave);
            this.groupBox1.Controls.Add(this.txtAvaliador);
            this.groupBox1.Controls.Add(this.lvAvaliadores);
            this.groupBox1.Location = new System.Drawing.Point(274, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaliadores";
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
            this.btnAdicionaPalavraChave.Click += new System.EventHandler(this.btnAdicionaPalavraChave_Click);
            // 
            // txtAvaliador
            // 
            this.txtAvaliador.Location = new System.Drawing.Point(6, 18);
            this.txtAvaliador.Name = "txtAvaliador";
            this.txtAvaliador.Size = new System.Drawing.Size(208, 20);
            this.txtAvaliador.TabIndex = 18;
            // 
            // lvAvaliadores
            // 
            this.lvAvaliadores.Location = new System.Drawing.Point(6, 42);
            this.lvAvaliadores.Name = "lvAvaliadores";
            this.lvAvaliadores.Size = new System.Drawing.Size(208, 61);
            this.lvAvaliadores.TabIndex = 12;
            this.lvAvaliadores.UseCompatibleStateImageBehavior = false;
            // 
            // FrmEncaminharArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 255);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Name = "FrmEncaminharArtigo";
            this.Text = "Encaminhar Artigo";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtComentarios;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtNome;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.ListView lvAutores;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button btnRemovePalavraChave;
        protected System.Windows.Forms.Button btnAdicionaPalavraChave;
        protected System.Windows.Forms.TextBox txtAvaliador;
        protected System.Windows.Forms.ListView lvAvaliadores;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnConfirmar;
    }
}