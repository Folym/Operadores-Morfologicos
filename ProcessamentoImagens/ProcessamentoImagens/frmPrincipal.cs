using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;
            pictBoxImg2.Image = null;
        }


        private void btnDilata_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.dilatacao(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnErosao_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.erosao(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnAbre_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            Bitmap imgDestAux = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.erosao(imageBitmap, imgDestAux);
            Filtros.dilatacao(imgDestAux, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            Bitmap imgDestAux = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.dilatacao(imageBitmap, imgDestAux);
            Filtros.erosao(imgDestAux, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void DilatacaoDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.dilatacaoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void ErosaoDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.erosaoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void AberturaDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            Bitmap imgDestAux = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.erosaoDMA(imageBitmap, imgDestAux);
            Filtros.dilatacaoDMA(imgDestAux, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void FechamentoDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDestAux = new Bitmap(image);
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.dilatacaoDMA(imageBitmap, imgDestAux);
            Filtros.erosaoDMA(imgDestAux, imgDest);
            pictBoxImg2.Image = imgDest;
        }
    }
}
