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
    public partial class Teslim_Listesi : Form
    {
        public Teslim_Listesi()
        {
            InitializeComponent();
        }

        string baglama = "select musteriler.id,musteriler.adi,musteriler.soyadi,musteriler.telefon,musteriler.adres," +
                "halidurumu.siparis_tarihi from " +
                "musteriler INNER JOIN halidurumu on musteriler.id = halidurumu.musteri_id where halidurumu.verilecek=1 and";

        veritabani teslim = new veritabani();
        string durum_degeri = "halidurumu";
        string tabloadı = "verilecek";
        private void Teslim_Listesi_Load(object sender, EventArgs e)
        {
            comboBox_arama.SelectedIndex = 0;
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            teslim.ListeGetir(dataGridView_teslim,tabloadı);
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ana_Ekran frm = new Ana_Ekran();
            this.Hide();
            frm.Show();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            if (txt_id.Text!="")
            {
                teslim.islemyap_teslimedildi(txt_id.Text, dataGridView_teslim, tabloadı);
                SqlConnection con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
                SqlCommand com = new SqlCommand("update halidurumu set teslim_tarihi = @teslim_tarihi where id = @id ", con);
                com.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sipariş teslim edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
            }
            else MessageBox.Show("Lütfen önce teslim ettiğiniz adresi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dataGridView_teslim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_teslim.Rows[e.RowIndex];
            txt_id.Text = row.Cells["id"].Value.ToString();
        }

        private void txt_bul_TextChanged(object sender, EventArgs e)
        {
            teslim.KisiBul(comboBox_arama,dataGridView_teslim,txt_bul.Text,durum_degeri,baglama);
        }

        private void Teslim_Listesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
