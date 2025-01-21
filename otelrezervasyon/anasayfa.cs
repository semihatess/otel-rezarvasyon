using otelrezervasyon.BL;
using otelrezervasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static otelrezervasyon.BL.BLrezervasyon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otelrezervasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        public string AlinanDeger { get; set; }
        private MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
       
        private void MusteriBilgileriniYukle()
        {
            try
            {
                dataGridView1.DataSource = musteriIslemleri.Listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Müşteri bilgileri yüklenirken hata oluştu: {hata.Message}");
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string MusteriAd = txtAd.Text;
            string MusteriSoyad = txtSoyad.Text;
            string OdaNo = cmbOdaNo.Text;
            string GirisTarihi = dtGiris.Text;
            string CikisTarihi = dtCikis.Text;
            string OdaTipi = cmbTip.Text;
            (new BLrezervasyon()).MusteriEkle(MusteriAd, MusteriSoyad, OdaNo, GirisTarihi, CikisTarihi, OdaTipi);
            MessageBox.Show("Kaydedildi");
            MusteriBilgileriniYukle();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Lütfen geçerli bir ID seçin.");
                return;
            }
            new BLrezervasyon().MusteriSil(id);
            MessageBox.Show("Rezervasyon silindi!");
            MusteriBilgileriniYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int MusteriID = int.Parse(txtID.Text);
            string MusteriAd = txtAd.Text;
            string MusteriSoyad = txtSoyad.Text;
            string OdaNo = cmbOdaNo.Text;
            string GirisTarihi = dtGiris.Value.ToString("dd-MM-yyyy");
            string CikisTarihi = dtCikis.Value.ToString("dd-MM-yyyy");
            string OdaTipi = cmbTip.Text;

            new BLrezervasyon().MusteriGuncelle( MusteriAd, MusteriSoyad, OdaNo, GirisTarihi,CikisTarihi,OdaTipi, MusteriID);
            MessageBox.Show("Rezervasyon güncellendi!");
            MusteriBilgileriniYukle();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            MusteriBilgileriniYukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                txtAd.Text = satir.Cells["MusteriAd"].Value?.ToString();
                txtSoyad.Text = satir.Cells["MusteriSoyad"].Value?.ToString();
                cmbTip.Text = satir.Cells["OdaTipi"].Value?.ToString();
                cmbOdaNo.Text = satir.Cells["OdaNo"].Value?.ToString();
                dtGiris.Text = satir.Cells["GirisTarihi"].Value?.ToString();
                dtCikis.Text = satir.Cells["CikisTarihi"].Value?.ToString();
                txtID.Text = satir.Cells["MusteriID"].Value?.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
