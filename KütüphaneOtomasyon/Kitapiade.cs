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
    public partial class Kitapiade : Form
    {
        public Kitapiade()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tablolar.mdb");
        DataTable KayitTablo = new DataTable();

        // Datagridview mizde öğrencileri görüntülemek için veritabanını açıp tabloyu içinden çektik.
        public void Kayitgoruntule()  
        {
            baglanti.Open();
            OleDbDataAdapter ogrenciadptr = new OleDbDataAdapter("select * from kayit", baglanti);
            ogrenciadptr.Fill(KayitTablo);
            kayitdatagridview.DataSource = KayitTablo;
            baglanti.Close();

        }
        // Datagridview mizde öğrencileri görüntülemek için veritabanını açıp tabloyu içinden çektik.

        private void Kitapiade_Load(object sender, EventArgs e)
        {
            Kayitgoruntule();
        }
        private void button1_Click(object sender, EventArgs e)
        {

          /* Önce iade tablosuna ekliyoruz */
            baglanti.Open();
            OleDbCommand Keklecmd = new OleDbCommand("insert into iade(kayitkitapyazari,kayitkitapserino,kayitogrencisoyad,kayitkitapad,kayitogrenciad,kayitogrencitel,kayitogrencitc,tarih) values ('" + kayitdatagridview.CurrentRow.Cells["kayitkitapyazari"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["kayitkitapserino"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["kayitogrencisoyad"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["kayitkitapad"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["kayitogrenciad"].Value.ToString()+ "','" + kayitdatagridview.CurrentRow.Cells["kayitogrencitel"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["kayitogrencitc"].Value.ToString() + "','" + kayitdatagridview.CurrentRow.Cells["tarih"].Value.ToString() + "')", baglanti); // iade tablosuna veri eklemek için
            Keklecmd.ExecuteNonQuery(); //EKLE FONKSİYONUNU PROGRAMA  TANITMA FONKSİYONU
            baglanti.Close();

            /* Önce iade tablosuna ekliyoruz */

            /*  BURASI KAYİT TABLOSUNDAN SİLMEK İÇİN   */
            baglanti.Open();
            OleDbCommand Ksilcmd = new OleDbCommand("delete *from kayit where kayitkitapyazari='" + kayitdatagridview.CurrentRow.Cells["kayitkitapyazari"].Value.ToString() + "'and kayitkitapserino='" + kayitdatagridview.CurrentRow.Cells["kayitkitapserino"].Value.ToString() + "'and kayitogrencisoyad='" + kayitdatagridview.CurrentRow.Cells["kayitogrencisoyad"].Value.ToString() + "'and kayitkitapad='" + kayitdatagridview.CurrentRow.Cells["kayitkitapad"].Value.ToString() + "'and kayitogrenciad='" + kayitdatagridview.CurrentRow.Cells["kayitogrenciad"].Value.ToString() + "'and kayitogrencitel='" + kayitdatagridview.CurrentRow.Cells["kayitogrencitel"].Value.ToString() + "'and kayitogrencitc='" + kayitdatagridview.CurrentRow.Cells["kayitogrencitc"].Value.ToString() + "'and tarih='" + kayitdatagridview.CurrentRow.Cells["tarih"].Value.ToString() + "'", baglanti); // kayit tablosundan veri SİLMEK için
            Ksilcmd.ExecuteNonQuery();  //SİLME FONKSİYONUNU PROGRAMA  TANITMA FONKSİYONU
            baglanti.Close();
            MessageBox.Show("Kitap iade edildi!");
            KayitTablo.Clear();
            Kayitgoruntule();
            /*  BURASI KAYİT TABLOSUNDAN SİLMEK İÇİN   */
        }


    }
}
