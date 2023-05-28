using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, gectimi;
            int sinav1, sinav2, proje, ogrno;
            double ortalama;
            

            sinav1 = Convert.ToInt16(textBox3.Text);
            sinav2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ogrno = Convert.ToInt32(textBox6.Text);


            ortalama = ((sinav1 * 0.4) + (sinav2 * 0.5) + (proje * 0.1));

            ad = textBox1.Text;
            soyad = textBox2.Text;

            if (ortalama >= 50)
            {
                gectimi = "GEÇTİ";
            }
            else
            {
                gectimi = "KALDI";
            }

            listBox1.Items.Add( ad + " " + soyad + " " + ogrno + " Öğrencisinin Ortalaması : " + ortalama + " Durumu: " + gectimi);
        }
    }
}
