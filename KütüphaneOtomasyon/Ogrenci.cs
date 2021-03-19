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
    public partial class Ogrenci : Form
    {

        

        public Ogrenci()
        {
            InitializeComponent();
        }


        // Programımız ile VERİ TABANI BAĞLANTISI kurduk
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tablolar.mdb");
        DataTable OgrenciTablo = new DataTable();
        // Programımız ile VERİ TABANI BAĞLANTISI kurduk




        // Datagridview mizde öğrencileri görüntülemek için veritabanını açıp tabloyu içinden çektik.
        public void Ogrencigoruntule()
        {
            baglanti.Open();
            OleDbDataAdapter ogrenciadptr = new OleDbDataAdapter("select * from ogrenciler",baglanti);
            ogrenciadptr.Fill(OgrenciTablo);
            oDatagrdv.DataSource = OgrenciTablo;
            baglanti.Close();
        }
        // Datagridview mizde öğrencileri görüntülemek için veritabanını açıp tabloyu içinden çektik.




        // Öğrenci formu açılığında ögrencigorüntüle fonksiyonu çalışsın.
        private void Ogrenci_Load(object sender, EventArgs e)
        {
            Ogrencigoruntule();
        }



       // ÖĞGENCİ SİLME
        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand silcmd = new OleDbCommand("delete *from ogrenciler where ogrenciad='"+oDatagrdv.CurrentRow.Cells["ogrenciad"].Value.ToString()+ "'and ogrencisoyad='" + oDatagrdv.CurrentRow.Cells["ogrencisoyad"].Value.ToString()+ "'and ogrencitc='" + oDatagrdv.CurrentRow.Cells["ogrencitc"].Value.ToString() + "'and ogrencitel='" + oDatagrdv.CurrentRow.Cells["ogrencitel"].Value.ToString()+"'", baglanti); // ogrenciler tablosuna veri SİLMEK için
            silcmd.ExecuteNonQuery();  //SİLME FONKSİYONUNU PROGRAMA  TANITMA FONKSİYONU
            baglanti.Close();
            MessageBox.Show("Öğrenci Silindi!");
            OgrenciTablo.Clear();
            Ogrencigoruntule();
        }


        // ÖĞRENCİ EKLEME
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Kitapiade ograd = new Kitapiade();
            ograd.Text = ogrAdtxt.Text;
            baglanti.Open();
            OleDbCommand eklecmd = new OleDbCommand("insert into ogrenciler(ogrenciad,ogrencisoyad,ogrencitc,ogrencitel) values ('"+ogrAdtxt.Text+ "','" + ogrSoyadtxt.Text + "','" + ogrTctxt.Text + "','" + ogrTeltxt.Text + "')",baglanti); // ogrenciler tablosuna veri eklemek için
            eklecmd.ExecuteNonQuery(); //EKLE FONKSİYONUNU PROGRAMA  TANITMA FONKSİYONU
            baglanti.Close();
            MessageBox.Show("Öğrenci Eklendi!");
            OgrenciTablo.Clear();
            Ogrencigoruntule();
        }


        // DataGredView 'e çift tıklandığında tıkladığı kişinin bilgileri textboxlara geçsin.
        private void oDatagrdv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ogrAdtxt.Text = oDatagrdv.CurrentRow.Cells["ogrenciad"].Value.ToString();
            ogrSoyadtxt.Text = oDatagrdv.CurrentRow.Cells["ogrencisoyad"].Value.ToString();
            ogrTctxt.Text = oDatagrdv.CurrentRow.Cells["ogrencitc"].Value.ToString();
            ogrTeltxt.Text = oDatagrdv.CurrentRow.Cells["ogrencitel"].Value.ToString();

        }


        // ÖĞRENCİ Güncelleme
        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand guncellecmd = new OleDbCommand("update ogrenciler set ogrenciad='"+ogrAdtxt.Text+ "',ogrencisoyad='" + ogrSoyadtxt.Text + "',ogrencitel='" + ogrTeltxt.Text+"'where ogrencitc='"+ogrTctxt.Text+"'", baglanti); // ogrenciler tablosuna veri GÜNCELLEME İÇİN
            guncellecmd.ExecuteNonQuery(); //GÜNCELLE FONKSİYONUNU PROGRAMA  TANITMA FONKSİYONU
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellendi!");
            OgrenciTablo.Clear();
            Ogrencigoruntule();

        }

       
    }
}
