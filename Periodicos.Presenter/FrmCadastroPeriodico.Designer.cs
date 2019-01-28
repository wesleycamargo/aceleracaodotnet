namespace Periodicos.Presenter
{
    partial class FrmCadastroPeriodico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroPeriodico));
            this.label2 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lvTodos = new System.Windows.Forms.ListView();
            this.lblArtigos = new System.Windows.Forms.Label();
            this.lvEdicaoPeriodico = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Descrição";
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 33);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(509, 20);
            this.txtDescricao.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Demais Edições";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 279);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(76, 24);
            this.btnConfirmar.TabIndex = 40;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lvTodos
            // 
            this.lvTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTodos.Location = new System.Drawing.Point(12, 194);
            this.lvTodos.Name = "lvTodos";
            this.lvTodos.Size = new System.Drawing.Size(510, 73);
            this.lvTodos.TabIndex = 39;
            this.lvTodos.UseCompatibleStateImageBehavior = false;
            // 
            // lblArtigos
            // 
            this.lblArtigos.AutoSize = true;
            this.lblArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigos.Location = new System.Drawing.Point(12, 60);
            this.lblArtigos.Name = "lblArtigos";
            this.lblArtigos.Size = new System.Drawing.Size(157, 20);
            this.lblArtigos.TabIndex = 38;
            this.lblArtigos.Text = "Edições do Periódico";
            // 
            // lvEdicaoPeriodico
            // 
            this.lvEdicaoPeriodico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEdicaoPeriodico.Location = new System.Drawing.Point(12, 87);
            this.lvEdicaoPeriodico.Name = "lvEdicaoPeriodico";
            this.lvEdicaoPeriodico.Size = new System.Drawing.Size(510, 73);
            this.lvEdicaoPeriodico.TabIndex = 37;
            this.lvEdicaoPeriodico.UseCompatibleStateImageBehavior = false;
            // 
            // FrmCadastroPeriodico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lvTodos);
            this.Controls.Add(this.lblArtigos);
            this.Controls.Add(this.lvEdicaoPeriodico);
            this.Name = "FrmCadastroPeriodico";
            this.Text = "FrmCadastroPeriodico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TextBox txtDescricao;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListView lvTodos;
        protected System.Windows.Forms.Label lblArtigos;
        protected System.Windows.Forms.ListView lvEdicaoPeriodico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;

    }
}