using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Ivedi_Yikama
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();

        }
        void temizle()
        {
            txt_id.Text = "";
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_telefon.Text = "";
            txt_adres.Text = "";
        }

        veritabani musteriler = new veritabani();
        private void Musteriler_Load(object sender, EventArgs e)
        {
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            comboBox_arama.SelectedIndex = 0;
            musteriler.MusteriGetir(dataGridView_musteriler);
        }

        private void dataGridView_musteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_musteriler.Rows[e.RowIndex];
            txt_id.Text = row.Cells["id"].Value.ToString();
            txt_adi.Text = row.Cells["adi"].Value.ToString();
            txt_soyadi.Text = row.Cells["soyadi"].Value.ToString();
            txt_telefon.Text = row.Cells["telefon"].Value.ToString();
            txt_adres.Text = row.Cells["adres"].Value.ToString();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Ana_Ekran frm = new Ana_Ekran();
            this.Hide();
            frm.Show();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            musteriler.KisiEkle(txt_adi.Text.Trim(), txt_soyadi.Text.Trim(), txt_telefon.Text.Trim(), txt_adres.Text.Trim());
            musteriler.MusteriGetir(dataGridView_musteriler);
            temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            musteriler.KisiGuncelle(txt_id.Text, txt_adi.Text.Trim(), txt_soyadi.Text.Trim(), txt_telefon.Text.Trim(), txt_adres.Text.Trim());
            musteriler.MusteriGetir(dataGridView_musteriler);
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_adi.Text!="")
            {
                musteriler.SiparisSil(txt_id.Text);
                musteriler.KisiSil(txt_id.Text);
                musteriler.MusteriGetir(dataGridView_musteriler);
                temizle();
            }
            else MessageBox.Show("Silmek istediğiniz müşteriyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void txt_bul_TextChanged(object sender, EventArgs e)
        {
            string baglama = "select * from musteriler where";
            string durum_degeri = "musteriler";
            musteriler.KisiBul(comboBox_arama, dataGridView_musteriler, txt_bul.Text,durum_degeri,baglama);
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            musteriler.SiparisOlustur(txt_id.Text, txt_adi.Text, txt_soyadi.Text, txt_telefon.Text, txt_adres.Text);
            temizle();
        }

        private void Musteriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
