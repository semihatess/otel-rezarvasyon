using MySql.Data.MySqlClient;
using otelrezervasyon.BL;
using otelrezervasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelrezervasyon
{
    public partial class YöneticiGiriş : Form
    {
        public YöneticiGiriş()
        {
            InitializeComponent();
        }
        baglanti snf = new baglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {
            (new BLgiris()).girisbilgi(txtad.Text, txtsifre.Text);
            MySqlCommand komut = new MySqlCommand("select * from yöneticigiriş where kullanıcıad =@a1 and şifre=@s1", snf.baglantiGetir());
            komut.Parameters.AddWithValue("@a1",txtad.Text);
            komut.Parameters.AddWithValue("@s1",txtsifre.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                 anasayfa fr = new anasayfa();
                fr.Show();
                this.Hide();
           
                
            }
            else 
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalıdır");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void YöneticiGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
