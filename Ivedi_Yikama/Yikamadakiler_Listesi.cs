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

namespace Ivedi_Yikama
{
    public partial class Yikamadakiler_Listesi : Form
    {
        public Yikamadakiler_Listesi()
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
                "musteriler INNER JOIN halidurumu on halidurumu.musteri_id = musteriler.id where halidurumu.yikamada=1 and";

        veritabani yikamada = new veritabani();
        string durum_degeri = "halidurumu";
        string tabloadı = "yikamada";
        private void txt_bul_TextChanged(object sender, EventArgs e)
        {
            yikamada.KisiBul(comboBox_arama, dataGridView_yikamada, txt_bul.Text, durum_degeri, baglama);
        }

        private void btn_yikandi_Click(object sender, EventArgs e)
        {
            if(txt_id.Text!="")
            {
                yikamada.islemyap_yikandi(txt_id.Text, dataGridView_yikamada, tabloadı);
                MessageBox.Show("Sipariş yıkandı teslime hazır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
            }
            else MessageBox.Show("Lütfen önce yıkanan adresi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Yikamadakiler_Listesi_Load(object sender, EventArgs e)
        {
            comboBox_arama.SelectedIndex = 0;
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            yikamada.ListeGetir(dataGridView_yikamada,tabloadı);
        }

        private void dataGridView_alinacaklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_yikamada.Rows[e.RowIndex];
            txt_id.Text = row.Cells["id"].Value.ToString();
        }

        

        private void Yikamadakiler_Listesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
