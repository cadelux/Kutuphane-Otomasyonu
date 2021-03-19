using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace KütüphaneOtomasyon
{
    public partial class kitapbilgi : Form
    {
        public kitapbilgi()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BU KİTABI ŞU AN KİM OKUYOR? //
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tablolar.mdb");
            DataTable OgrenciBilgiTablo = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select kayitkitapad,kayitogrenciad,kayitogrencisoyad,tarih from kayit WHERE [kayitkitapserino] LIKE " + kbilgiTCtxt.Text, baglanti);
            da.Fill(OgrenciBilgiTablo);
            dataGridView1.DataSource = OgrenciBilgiTablo;

            // BU KİTABI KİMLER OKUDU //
            OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tablolar.mdb");
            DataTable OgrenciBilgiTablo2 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("select kayitkitapad,kayitogrenciad,kayitogrencisoyad,tarih from iade WHERE [kayitkitapserino] LIKE " + kbilgiTCtxt.Text, baglanti2);
            da1.Fill(OgrenciBilgiTablo2);
            dataGridView2.DataSource = OgrenciBilgiTablo2;
        }

        private void kitapbilgi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
