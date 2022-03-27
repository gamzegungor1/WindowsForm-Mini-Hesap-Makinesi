using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsForm3
{
    public partial class Form1 : Form
    {

        Matematikİslemleri matematikİslemleri = new Matematikİslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

          int toplam =  matematikİslemleri.topla(sayi1, sayi2);

            lbl_sonuc.Text = toplam.ToString();



       }

        private void btn_cıkarma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int cikarma = matematikİslemleri.cikarma(sayi1, sayi2);

            lbl_sonuc.Text = cikarma.ToString();
        }

        private void btn_çarpma_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int carpma = matematikİslemleri.carpma(sayi1, sayi2);

            lbl_sonuc.Text = carpma.ToString();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_sayi1.Text);
            double sayi2 = Convert.ToDouble(txt_sayi2.Text);

            double bolme= matematikİslemleri.bolme(sayi1, sayi2);

            lbl_sonuc.Text = bolme.ToString();
        }
    }
}
