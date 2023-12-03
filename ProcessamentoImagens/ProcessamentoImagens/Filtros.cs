using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProcessamentoImagens
{
    class Filtros
    {

        //sem acesso direto a memoria
        public static void threshould(Bitmap imageBitmapSrc)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    gs = (r + g + b) / 3;
                    if (gs > 127)
                        gs = 255;
                    else
                        gs = 0;

                    //nova cor
                    Color newcolor = Color.FromArgb(gs, gs, gs);
                    imageBitmapSrc.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void dilatacao(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            threshould(imageBitmapSrc);
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            for(int y = 1; y < height-1; y++)
            {
                for(int x = 1;x < width-1; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);
                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    if(r == g && g == b)
                    {
                        if (r == 0)
                        {
                            imageBitmapDest.SetPixel(x, y, cor);
                            imageBitmapDest.SetPixel(x + 1, y, cor);
                            imageBitmapDest.SetPixel(x, y + 1, cor);
                            imageBitmapDest.SetPixel(x - 1, y, cor);
                            imageBitmapDest.SetPixel(x, y - 1, cor);
                            imageBitmapDest.SetPixel(x + 1, y + 1, cor);
                            imageBitmapDest.SetPixel(x + 1, y - 1, cor);
                            imageBitmapDest.SetPixel(x - 1, y + 1, cor);
                            imageBitmapDest.SetPixel(x - 1, y - 1, cor);
                        }
                    }
                }
            }
        }

        //sem acesso direto a memoria
        public static void erosao(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            threshould(imageBitmapSrc);
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Color corBranco = Color.FromArgb(255, 255, 255);
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    Color cor1 = imageBitmapSrc.GetPixel(x, y);
                    Color cor2 = imageBitmapSrc.GetPixel(x + 1, y);
                    Color cor3 = imageBitmapSrc.GetPixel(x, y + 1);
                    Color cor4 = imageBitmapSrc.GetPixel(x - 1, y);
                    Color cor5 = imageBitmapSrc.GetPixel(x, y - 1);
                    Color cor6 = imageBitmapSrc.GetPixel(x + 1, y + 1);
                    Color cor7 = imageBitmapSrc.GetPixel(x + 1, y - 1);
                    Color cor8 = imageBitmapSrc.GetPixel(x - 1, y + 1);
                    Color cor9 = imageBitmapSrc.GetPixel(x - 1, y - 1);
                    if (cor1.R == 0 && cor2.R == 0 && cor3.R == 0 && cor4.R == 0 && cor5.R == 0 && cor6.R == 0 && cor7.R == 0 && cor8.R == 0 && cor9.R==0)
                    {
                        imageBitmapDest.SetPixel(x, y, cor1);
                    }
                    else
                    {
                        imageBitmapDest.SetPixel(x, y, corBranco);
                    }
                    
                }
            }

        }


        //com acesso direto a memoria
        public static void dilatacaoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            threshould(imageBitmapSrc);
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bitmapDataSrc.Stride;
            int padding = bitmapDataSrc.Stride - (width * pixelSize);
            unsafe
            {
                byte* auxC = (byte*)bitmapDataDst.Scan0.ToPointer();
                byte* auxB = (byte*)bitmapDataDst.Scan0.ToPointer() + (stride * 2);
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer()+stride+3;
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer()+stride+3;
                int r, g, b;
                for (int y = 1; y < height-1; y++)
                {
                    for (int x = 1; x < width-1; x++)
                    {
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        if (r == 0)
                        {
                            dst = dst-3;
                            for(int i = 0; i < 3; i++)
                            {
                                *(auxC++) = (byte)b;
                                *(auxC++) = (byte)g;
                                *(auxC++) = (byte)r;
                                *(auxB++) = (byte)b;
                                *(auxB++) = (byte)g;
                                *(auxB++) = (byte)r;
                                *(dst++) = (byte)b;
                                *(dst++) = (byte)g;
                                *(dst++) = (byte)r;

                            }
                            auxB = auxB - 6;
                            dst = dst - 3;
                            auxC = auxC - 6;
                        }
                        else
                        {
                            dst += 3;
                            auxB += 3;
                            auxC += 3;
                        }
                    }
                    auxB += padding + 6;
                    auxC += padding + 6;
                    src += padding+6;
                    dst += padding+6;

                }
                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
                //unlock imagem destino
                imageBitmapDest.UnlockBits(bitmapDataDst);
            }
        }

        //com acesso direto a memoria
        public static void erosaoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            threshould(imageBitmapSrc);
            
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;



            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bitmapDataSrc.Stride;
            int padding = bitmapDataSrc.Stride - (width * pixelSize);


  

            unsafe
            {
                byte* auxCAnt = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* auxC = (byte*)bitmapDataSrc.Scan0.ToPointer()+3;
                byte* auxCProx = (byte*)bitmapDataSrc.Scan0.ToPointer()+6;
                byte* auxBant = (byte*)bitmapDataSrc.Scan0.ToPointer() + (stride * 2);
                byte* auxB = (byte*)bitmapDataSrc.Scan0.ToPointer() + (stride * 2)+3;
                byte* auxBprox = (byte*)bitmapDataSrc.Scan0.ToPointer() + (stride * 2)+6;
                byte* srcAnt = (byte*)bitmapDataSrc.Scan0.ToPointer() + stride;
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer() + stride + 3;
                byte* srcProx = (byte*)bitmapDataSrc.Scan0.ToPointer() + stride + 6;

                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer() + stride + 3;
                int rcant , rc, rcprox, rbant, rb, rbprox, rsrca,rsrc,rsrcp;
                for (int y = 1; y < height - 1; y++)
                {
                    for (int x = 1; x < width - 1; x++)
                    {
                        rcprox = *(auxCProx += 3);
                        rc = *(auxC += 3);
                        rcant = *(auxCAnt += 3);

                        rbprox = *(auxBprox += 3);
                        rb = *(auxB += 3);
                        rbant = *(auxBant += 3);

                        rsrcp = *(srcProx += 3);
                        rsrc = *(src+=3);
                        rsrca = *(srcAnt+=3);

                        if (rc == 0 && rcant==0 && rcprox ==0 && rbant == 0 && rbprox == 0 && rb ==0 && rsrc ==0 && rsrca == 0 && rsrcp == 0)
                        {
                            *(dst++) = (byte)rsrc;
                            *(dst++) = (byte)rsrc;
                            *(dst++) = (byte)rsrc;
                        }
                        else
                        {
                            *(dst++) = 255;
                            *(dst++) = 255;
                            *(dst++) = 255;
                        }
                    }
                    auxBant += padding + 6;
                    auxB += padding + 6;
                    auxBprox += padding + 6;
                    auxCAnt += padding + 6;
                    auxC += padding + 6;
                    auxCProx += padding + 6;
                    srcAnt += padding + 6;
                    src += padding + 6;
                    srcProx += padding + 6;
                    dst += padding + 6;

                }
                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
                //unlock imagem destino
                imageBitmapDest.UnlockBits(bitmapDataDst);
            }
        }

    }
}
