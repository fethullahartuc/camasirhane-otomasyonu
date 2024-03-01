using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Ivedi_Yikama

{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void link_hesapolustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit frm = new Kayit();
            this.Hide();
            frm.Show();
        }

        // sql baðlantý iþleri
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        void Giris()
        {
            con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from giris where kullaniciadi='" + txt_kadi.Text + "' and sifre='" + txt_sifre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Ana_Ekran frm = new Ana_Ekran();
                this.Hide();
                frm.Show();
            }
            else if (txt_kadi.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifrenizi giriniz giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik veya hatalý giriþ yaptýnýz. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void Form_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
