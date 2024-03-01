using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivedi_Yikama
{
    public partial class Gun_Ozeti : Form
    {
        public Gun_Ozeti()
        {
            InitializeComponent();
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ana_Ekran frm = new Ana_Ekran();
            this.Hide();
            frm.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;
        void AdetBul()
        {
            string tarih = dateTimePicker.Value.ToString("yyyy-MM-dd");
            int adet = 0;
            string bugun = dateTimePicker.Value.ToString("dd-MM-yyyy");
            con.Open();
            com = new SqlCommand("select COUNT(teslim_tarihi) from halidurumu where CONVERT(date, halidurumu.teslim_tarihi) LIKE '%" + tarih + "%'", con);
            com.Parameters.AddWithValue("@bugun", bugun);
            adet = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            lbl_teslimadet.Text = adet.ToString();
        }
        void ListeGetir()
        {
            lbl_tarih.Text = dateTimePicker.Value.ToString("dd-MM-yyyy");
            string tarih = dateTimePicker.Value.ToString("yyyy-MM-dd");
            con.Open();
            da = new SqlDataAdapter("select halidurumu.id,musteriler.adi,musteriler.soyadi,musteriler.telefon,musteriler.adres," +
                "halidurumu.siparis_tarihi,halidurumu.teslim_tarihi from " +
                "musteriler INNER JOIN halidurumu on musteriler.id = halidurumu.musteri_id where CONVERT(date, halidurumu.teslim_tarihi) LIKE '%"+tarih+"%'", con);
            ds = new DataSet();
            da.Fill(ds, "halidurumu");
            dataGridView_gunozeti.DataSource = ds.Tables["halidurumu"];
            con.Close();

        }
        private void Gun_Ozeti_Load(object sender, EventArgs e)
        {
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            ListeGetir();
            AdetBul();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ListeGetir();
            AdetBul();

        }

        private void Gun_Ozeti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
