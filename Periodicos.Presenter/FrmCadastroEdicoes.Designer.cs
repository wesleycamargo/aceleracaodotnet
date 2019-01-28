namespace Periodicos.Presenter
{
    partial class FrmCadastroEdicoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEdicoes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lvTodos = new System.Windows.Forms.ListView();
            this.lblArtigos = new System.Windows.Forms.Label();
            this.lvArtigoEdicao = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.txtNomeEdicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Demais Artigos";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(76, 24);
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lvTodos
            // 
            this.lvTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTodos.Location = new System.Drawing.Point(12, 191);
            this.lvTodos.Name = "lvTodos";
            this.lvTodos.Size = new System.Drawing.Size(510, 73);
            this.lvTodos.TabIndex = 32;
            this.lvTodos.UseCompatibleStateImageBehavior = false;
            this.lvTodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTodos_MouseClick);
            // 
            // lblArtigos
            // 
            this.lblArtigos.AutoSize = true;
            this.lblArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigos.Location = new System.Drawing.Point(12, 57);
            this.lblArtigos.Name = "lblArtigos";
            this.lblArtigos.Size = new System.Drawing.Size(134, 20);
            this.lblArtigos.TabIndex = 31;
            this.lblArtigos.Text = "Artigos da Edição";
            // 
            // lvArtigoEdicao
            // 
            this.lvArtigoEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvArtigoEdicao.Location = new System.Drawing.Point(12, 84);
            this.lvArtigoEdicao.Name = "lvArtigoEdicao";
            this.lvArtigoEdicao.Size = new System.Drawing.Size(510, 73);
            this.lvArtigoEdicao.TabIndex = 30;
            this.lvArtigoEdicao.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "apreciacao.png");
            this.imgList.Images.SetKeyName(1, "avaliacao.png");
            this.imgList.Images.SetKeyName(2, "aceito.png");
            this.imgList.Images.SetKeyName(3, "inativo.png");
            this.imgList.Images.SetKeyName(4, "confirmar.png");
            this.imgList.Images.SetKeyName(5, "cancelar.png");
            // 
            // txtNomeEdicao
            // 
            this.txtNomeEdicao.Location = new System.Drawing.Point(13, 30);
            this.txtNomeEdicao.Name = "txtNomeEdicao";
            this.txtNomeEdicao.Size = new System.Drawing.Size(509, 20);
            this.txtNomeEdicao.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descrição";
            // 
            // FrmCadastroEdicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeEdicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lvTodos);
            this.Controls.Add(this.lblArtigos);
            this.Controls.Add(this.lvArtigoEdicao);
            this.Name = "FrmCadastroEdicoes";
            this.Text = "FrmCadastroEdicoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnConfirmar;
        protected System.Windows.Forms.ListView lvTodos;
        protected System.Windows.Forms.Label lblArtigos;
        protected System.Windows.Forms.ListView lvArtigoEdicao;
        protected System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TextBox txtNomeEdicao;
        protected System.Windows.Forms.Label label2;
    }
}