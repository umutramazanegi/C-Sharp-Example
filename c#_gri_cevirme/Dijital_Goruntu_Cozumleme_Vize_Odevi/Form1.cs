using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijital_Goruntu_Cozumleme_Vize_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Fotoğrafı aç*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Jpeg Dosyası|*.jpeg;*.jpg|Bmp Dosyası|*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dosyaSecici.FileName;
            }
        }
        /*Fotoğrafı gri yap*/

        private Bitmap griyap(Bitmap cikisresim)
        {
            for (int i = 0; i < cikisresim.Height - 1; i++)
            {
                for (int j = 0; j < cikisresim.Width - 1; j++)
                {
                    int deger  =(cikisresim.GetPixel(j,i).R + cikisresim.GetPixel(j,i).G + cikisresim.GetPixel(j,i).B*0) /3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    cikisresim.SetPixel(j, i, renk);
                }
            }
            return cikisresim;
        }

        private void gri_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griyap(image);
            pictureBox2.Image = gri;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Kaydet
        private void kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Jpeg Dosyası|*.jpeg;*.jpg|Bmp Dosyası|*.bmp";
            if (DialogResult.OK == kaydet.ShowDialog())
            {
                this.pictureBox2.Image.Save(kaydet.FileName);
            }

        }
    }
}
