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
    public partial class ögrencibilgi : Form
    {
        public ögrencibilgi()
        {
            InitializeComponent();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\Tablolar.mdb");
            DataTable OgrenciBilgiTablo = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kayit WHERE [kayitogrencitc] LIKE " + öbilgiTCtxt.Text, baglanti);
            da.Fill(OgrenciBilgiTablo);
            dataGridView1.DataSource = OgrenciBilgiTablo;

            OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Tablolar.mdb");
            DataTable OgrenciBilgiTablo2 = new DataTable();
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from iade WHERE [kayitogrencitc] LIKE " + öbilgiTCtxt.Text, baglanti2);
            da1.Fill(OgrenciBilgiTablo2);
            dataGridView2.DataSource = OgrenciBilgiTablo2;
        }

        private void ögrencibilgi_Load(object sender, EventArgs e)
        {

        }
    }



    }


