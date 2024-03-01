using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ivedi_Yikama
{
    public partial class Alinacaklar_Listesi : Form
    {
        public Alinacaklar_Listesi()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ana_Ekran frm = new Ana_Ekran();
            this.Hide();
            frm.Show();
        }

        string baglama = "select musteriler.id,musteriler.adi,musteriler.soyadi,musteriler.telefon,musteriler.adres," +
                "halidurumu.siparis_tarihi from " +
                "musteriler INNER JOIN halidurumu on musteriler.id = halidurumu.musteri_id where halidurumu.alinacak=1 and";

        veritabani alinacak = new veritabani();
        string durum_degeri = "halidurumu";
        string tabloadı = "alinacak";
        private void txt_bul_TextChanged(object sender, EventArgs e)
        {
            alinacak.KisiBul(comboBox_arama, dataGridView_alinacaklar, txt_bul.Text, durum_degeri, baglama);
        }

        private void Alinacaklar_Listesi_Load(object sender, EventArgs e)
        {
            comboBox_arama.SelectedIndex = 0;
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            alinacak.ListeGetir(dataGridView_alinacaklar,tabloadı);
        }
        private void btn_alindi_Click(object sender, EventArgs e)
        {
            if(txt_id.Text!="")
            {
                alinacak.islemyap_alindi(txt_id.Text, dataGridView_alinacaklar, tabloadı);
                MessageBox.Show("Sipariş teslim alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txt_id.Text = "";
            }
            else MessageBox.Show("Lütfen önce aldığınız adresi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Alinacaklar_Listesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView_alinacaklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_alinacaklar.Rows[e.RowIndex];
            txt_id.Text = row.Cells["id"].Value.ToString();
        }
    }
}
