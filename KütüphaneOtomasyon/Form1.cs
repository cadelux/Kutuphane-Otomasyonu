using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // öğrenci adlı formu oluşturduk.
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci frm = new Ogrenci();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           kitap frm = new kitap();
            frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Kitap_Alma_İşlemleri frm = new Kitap_Alma_İşlemleri();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitapiade frm = new Kitapiade();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ögrencibilgi frm = new ögrencibilgi();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kitapbilgi frm = new kitapbilgi();
            frm.Show();
        }
    }
}
