﻿namespace Periodicos.Presenter
{
    partial class FrmEdicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdicoes));
            this.lblArtigos = new System.Windows.Forms.Label();
            this.lvEdicoes = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArtigos
            // 
            this.lblArtigos.AutoSize = true;
            this.lblArtigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigos.Location = new System.Drawing.Point(13, 11);
            this.lblArtigos.Name = "lblArtigos";
            this.lblArtigos.Size = new System.Drawing.Size(66, 20);
            this.lblArtigos.TabIndex = 12;
            this.lblArtigos.Text = "Edições";
            // 
            // lvEdicoes
            // 
            this.lvEdicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEdicoes.Location = new System.Drawing.Point(12, 39);
            this.lvEdicoes.Name = "lvEdicoes";
            this.lvEdicoes.Size = new System.Drawing.Size(510, 230);
            this.lvEdicoes.TabIndex = 11;
            this.lvEdicoes.UseCompatibleStateImageBehavior = false;            
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
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 277);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 24);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmEdicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblArtigos);
            this.Controls.Add(this.lvEdicoes);
            this.Name = "FrmEdicoes";
            this.Text = "Edições";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblArtigos;
        protected System.Windows.Forms.ListView lvEdicoes;
        protected System.Windows.Forms.ImageList imgList;
        protected System.Windows.Forms.Button btnNovo;
    }
}