namespace Periodicos.Presenter
{
    partial class FrmInicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.rdVisitante = new System.Windows.Forms.RadioButton();
            this.rdAvaliador = new System.Windows.Forms.RadioButton();
            this.rdEditor = new System.Windows.Forms.RadioButton();
            this.rdAutor = new System.Windows.Forms.RadioButton();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Periódicos";
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.rdVisitante);
            this.grpUsuario.Controls.Add(this.rdAvaliador);
            this.grpUsuario.Controls.Add(this.rdEditor);
            this.grpUsuario.Controls.Add(this.rdAutor);
            this.grpUsuario.Location = new System.Drawing.Point(41, 90);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(200, 138);
            this.grpUsuario.TabIndex = 1;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Realizar Login como:";
            // 
            // rdVisitante
            // 
            this.rdVisitante.AutoSize = true;
            this.rdVisitante.Location = new System.Drawing.Point(18, 105);
            this.rdVisitante.Name = "rdVisitante";
            this.rdVisitante.Size = new System.Drawing.Size(65, 17);
            this.rdVisitante.TabIndex = 3;
            this.rdVisitante.TabStop = true;
            this.rdVisitante.Text = "Visitante";
            this.rdVisitante.UseVisualStyleBackColor = true;
            this.rdVisitante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdVisitante_KeyPress);
            // 
            // rdAvaliador
            // 
            this.rdAvaliador.AutoSize = true;
            this.rdAvaliador.Location = new System.Drawing.Point(18, 82);
            this.rdAvaliador.Name = "rdAvaliador";
            this.rdAvaliador.Size = new System.Drawing.Size(69, 17);
            this.rdAvaliador.TabIndex = 2;
            this.rdAvaliador.TabStop = true;
            this.rdAvaliador.Text = "Avaliador";
            this.rdAvaliador.UseVisualStyleBackColor = true;
            this.rdAvaliador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdAvaliador_KeyPress);
            // 
            // rdEditor
            // 
            this.rdEditor.AutoSize = true;
            this.rdEditor.Location = new System.Drawing.Point(18, 55);
            this.rdEditor.Name = "rdEditor";
            this.rdEditor.Size = new System.Drawing.Size(52, 17);
            this.rdEditor.TabIndex = 1;
            this.rdEditor.TabStop = true;
            this.rdEditor.Text = "Editor";
            this.rdEditor.UseVisualStyleBackColor = true;
            this.rdEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdEditor_KeyPress);
            // 
            // rdAutor
            // 
            this.rdAutor.AutoSize = true;
            this.rdAutor.Location = new System.Drawing.Point(18, 28);
            this.rdAutor.Name = "rdAutor";
            this.rdAutor.Size = new System.Drawing.Size(50, 17);
            this.rdAutor.TabIndex = 0;
            this.rdAutor.TabStop = true;
            this.rdAutor.Text = "Autor";
            this.rdAutor.UseVisualStyleBackColor = true;
            this.rdAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdAutor_KeyPress);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(104, 234);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 5;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtBemVindo
            // 
            this.txtBemVindo.AutoSize = true;
            this.txtBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBemVindo.Location = new System.Drawing.Point(41, 62);
            this.txtBemVindo.Name = "txtBemVindo";
            this.txtBemVindo.Size = new System.Drawing.Size(0, 17);
            this.txtBemVindo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 54);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 0;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBemVindo);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.RadioButton rdAvaliador;
        private System.Windows.Forms.RadioButton rdEditor;
        private System.Windows.Forms.RadioButton rdAutor;
        private System.Windows.Forms.RadioButton rdVisitante;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label txtBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
    }
}

