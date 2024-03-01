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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        private void link_hesapolustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Giris frm = new Form_Giris();
            frm.Show();
            this.Hide();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Form_Kayit_Load(object sender, EventArgs e)
        {
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        SqlConnection con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
        SqlCommand com;
        bool durum;
        void mukerrer()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from giris where kullaniciadi = @kullaniciadi",con);
            komut.Parameters.AddWithValue("@kullaniciadi",txt_kadi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            con.Close();
           
        }
        void KayitEkle()
        {
            mukerrer();
            if (durum==true) 
            {
                string kadi = txt_kadi.Text;
                string sifre = txt_sifre.Text;
                string sifre_tekrar = txt_sifretekrar.Text;
                com = new SqlCommand();
                if (txt_kadi.Text.Trim() == "" || txt_sifre.Text.Trim() == "" || txt_sifretekrar.Text.Trim() == "")
                {
                    MessageBox.Show("Boş kutu bırakamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sifre == sifre_tekrar)
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into giris(kullaniciadi,sifre) values (@kullaniciadi,@sifre)";
                    com.Parameters.AddWithValue("@kullaniciadi", txt_kadi.Text.Trim());
                    com.Parameters.AddWithValue("@sifre", txt_sifre.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("Kayıt oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_kadi.Text = "";
                    txt_sifre.Text = "";
                    txt_sifretekrar.Text = "";
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_sifre.Text = "";
                    txt_sifretekrar.Text = "";
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Zaten bu kullanıcı adında bir hesap var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            KayitEkle();
        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
