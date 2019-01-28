namespace Periodicos.Presenter
{
    partial class FrmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditor));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnPeriodicos = new System.Windows.Forms.Button();
            this.lblArtigos = new System.Windows.Forms.Label();
            this.lvArtigos = new System.Windows.Forms.ListView();
            this.btnEncaminhar = new System.Windows.Forms.Button();
            this.btnEdicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btnPeriodicos
            // 
            this.btnPeriodicos.Location = new System.Drawing.Point(93, 271);
            this.btnPeriodicos.Name = "btnPeriodicos";
            this.btnPeriodicos.Size = new System.Drawing.Size(75, 36);
            this.btnPeriodicos.TabIndex = 6;
            this.btnPeriodicos.Text = "Periodicos";
            this.btnPeriodicos.UseVisualStyleBackColor = true;            
            // 
            // lblArtigos
            // 
            this.lblArtigos.AutoSize = true;
            this.lblArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigos.Location = new System.Drawing.Point(13, 7);
            this.lblArtigos.Name = "lblArtigos";
            this.lblArtigos.Size = new System.Drawing.Size(59, 20);
            this.lblArtigos.TabIndex = 8;
            this.lblArtigos.Text = "Artigos";
            // 
            // lvArtigos
            // 
            this.lvArtigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvArtigos.Location = new System.Drawing.Point(12, 35);
            this.lvArtigos.Name = "lvArtigos";
            this.lvArtigos.Size = new System.Drawing.Size(510, 230);
            this.lvArtigos.TabIndex = 7;
            this.lvArtigos.UseCompatibleStateImageBehavior = false;
            this.lvArtigos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvArtigos_MouseDoubleClick);
            // 
            // btnEncaminhar
            // 
            this.btnEncaminhar.Location = new System.Drawing.Point(12, 271);
            this.btnEncaminhar.Name = "btnEncaminhar";
            this.btnEncaminhar.Size = new System.Drawing.Size(75, 36);
            this.btnEncaminhar.TabIndex = 9;
            this.btnEncaminhar.Text = "Encaminhar Artigos";
            this.btnEncaminhar.UseVisualStyleBackColor = true;
            this.btnEncaminhar.Click += new System.EventHandler(this.btnEncaminhar_Click);
            // 
            // btnEdicoes
            // 
            this.btnEdicoes.Location = new System.Drawing.Point(174, 271);
            this.btnEdicoes.Name = "btnEdicoes";
            this.btnEdicoes.Size = new System.Drawing.Size(75, 36);
            this.btnEdicoes.TabIndex = 10;
            this.btnEdicoes.Text = "Edições";
            this.btnEdicoes.UseVisualStyleBackColor = true;
            this.btnEdicoes.Click += new System.EventHandler(this.btnEdicoes_Click);
            // 
            // FrmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.btnEdicoes);
            this.Controls.Add(this.btnEncaminhar);
            this.Controls.Add(this.lblArtigos);
            this.Controls.Add(this.lvArtigos);
            this.Controls.Add(this.btnPeriodicos);
            this.Name = "FrmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnPeriodicos;
        protected System.Windows.Forms.Label lblArtigos;
        protected System.Windows.Forms.ListView lvArtigos;
        private System.Windows.Forms.Button btnEncaminhar;
        private System.Windows.Forms.Button btnEdicoes;

    }
}