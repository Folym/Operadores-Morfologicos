namespace ProcessamentoImagens
{
    partial class frmPrincipal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDilata = new System.Windows.Forms.Button();
            this.btnAbre = new System.Windows.Forms.Button();
            this.btnErosao = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.DilatacaoDMA = new System.Windows.Forms.Button();
            this.ErosaoDMA = new System.Windows.Forms.Button();
            this.AberturaDMA = new System.Windows.Forms.Button();
            this.FechamentoDMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 512);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDilata
            // 
            this.btnDilata.Location = new System.Drawing.Point(647, 512);
            this.btnDilata.Name = "btnDilata";
            this.btnDilata.Size = new System.Drawing.Size(208, 23);
            this.btnDilata.TabIndex = 112;
            this.btnDilata.Text = "Dilatacao";
            this.btnDilata.UseVisualStyleBackColor = true;
            this.btnDilata.Click += new System.EventHandler(this.btnDilata_Click);
            // 
            // btnAbre
            // 
            this.btnAbre.Location = new System.Drawing.Point(647, 541);
            this.btnAbre.Name = "btnAbre";
            this.btnAbre.Size = new System.Drawing.Size(208, 23);
            this.btnAbre.TabIndex = 113;
            this.btnAbre.Text = "Abertura";
            this.btnAbre.UseVisualStyleBackColor = true;
            this.btnAbre.Click += new System.EventHandler(this.btnAbre_Click);
            // 
            // btnErosao
            // 
            this.btnErosao.Location = new System.Drawing.Point(861, 512);
            this.btnErosao.Name = "btnErosao";
            this.btnErosao.Size = new System.Drawing.Size(208, 23);
            this.btnErosao.TabIndex = 114;
            this.btnErosao.Text = "Erosao";
            this.btnErosao.UseVisualStyleBackColor = true;
            this.btnErosao.Click += new System.EventHandler(this.btnErosao_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(861, 541);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(208, 23);
            this.btnFecha.TabIndex = 115;
            this.btnFecha.Text = "Fechamento";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // DilatacaoDMA
            // 
            this.DilatacaoDMA.Location = new System.Drawing.Point(219, 512);
            this.DilatacaoDMA.Name = "DilatacaoDMA";
            this.DilatacaoDMA.Size = new System.Drawing.Size(208, 23);
            this.DilatacaoDMA.TabIndex = 116;
            this.DilatacaoDMA.Text = "DilatacaoDMA";
            this.DilatacaoDMA.UseVisualStyleBackColor = true;
            this.DilatacaoDMA.Click += new System.EventHandler(this.DilatacaoDMA_Click);
            // 
            // ErosaoDMA
            // 
            this.ErosaoDMA.Location = new System.Drawing.Point(433, 512);
            this.ErosaoDMA.Name = "ErosaoDMA";
            this.ErosaoDMA.Size = new System.Drawing.Size(208, 23);
            this.ErosaoDMA.TabIndex = 117;
            this.ErosaoDMA.Text = "ErosaoDMA";
            this.ErosaoDMA.UseVisualStyleBackColor = true;
            this.ErosaoDMA.Click += new System.EventHandler(this.ErosaoDMA_Click);
            // 
            // AberturaDMA
            // 
            this.AberturaDMA.Location = new System.Drawing.Point(219, 541);
            this.AberturaDMA.Name = "AberturaDMA";
            this.AberturaDMA.Size = new System.Drawing.Size(208, 23);
            this.AberturaDMA.TabIndex = 118;
            this.AberturaDMA.Text = "AberturaDMA";
            this.AberturaDMA.UseVisualStyleBackColor = true;
            this.AberturaDMA.Click += new System.EventHandler(this.AberturaDMA_Click);
            // 
            // FechamentoDMA
            // 
            this.FechamentoDMA.Location = new System.Drawing.Point(433, 541);
            this.FechamentoDMA.Name = "FechamentoDMA";
            this.FechamentoDMA.Size = new System.Drawing.Size(208, 23);
            this.FechamentoDMA.TabIndex = 119;
            this.FechamentoDMA.Text = "FechamentoDMA";
            this.FechamentoDMA.UseVisualStyleBackColor = true;
            this.FechamentoDMA.Click += new System.EventHandler(this.FechamentoDMA_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.FechamentoDMA);
            this.Controls.Add(this.AberturaDMA);
            this.Controls.Add(this.ErosaoDMA);
            this.Controls.Add(this.DilatacaoDMA);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnErosao);
            this.Controls.Add(this.btnAbre);
            this.Controls.Add(this.btnDilata);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnDilata;
        private System.Windows.Forms.Button btnAbre;
        private System.Windows.Forms.Button btnErosao;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button DilatacaoDMA;
        private System.Windows.Forms.Button ErosaoDMA;
        private System.Windows.Forms.Button AberturaDMA;
        private System.Windows.Forms.Button FechamentoDMA;
    }
}

