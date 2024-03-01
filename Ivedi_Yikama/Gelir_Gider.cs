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
    public partial class Gelir_Gider : Form
    {
        public Gelir_Gider()
        {
            InitializeComponent();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel_ust_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel_ust_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel_ust_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        SqlConnection con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Gelir_Gider_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void temizle()
        {
            txt_id.Text = "";
            txt_gelir.Text = "";
            txt_geliraciklama.Text = "";
            txt_gider.Text = "";
            txt_gideraciklama.Text = "";
        }

        void ListeGetir()
        {
            da = new SqlDataAdapter("select * from gelirgider", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gelirgider");
            dataGridView_gelirgider.DataSource = ds.Tables["gelirgider"];
            con.Close();
        }
        public void Ekle(string gelir, string gider, string geliraciklama, string gideraciklama)
        {
            // boş kutu bırakırsa kayıt yapmıyoruz.
            if (gelir.Trim() == "" || gider.Trim() == "" || geliraciklama.Trim() == "" || gideraciklama.Trim() == "")
            {
                MessageBox.Show("Boş kutu bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // kutular doluysa kayıt gerçekleştiriyoruz.
            else
            {
                com = new SqlCommand("insert into gelirgider(gelir,gelir_aciklama,gider,gider_aciklama,tarih) values(@gelir,@gelir_aciklama,@gider,@gider_aciklama,@tarih)", con);
                com.Parameters.AddWithValue("@gelir", gelir);
                com.Parameters.AddWithValue("@gelir_aciklama", geliraciklama);
                com.Parameters.AddWithValue("@gider", gider);
                com.Parameters.AddWithValue("@gider_aciklama", gideraciklama);
                com.Parameters.AddWithValue("@tarih", dateTimePicker.Value);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Veri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }
        public void guncelle()
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Lütfen önce kayıt seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com = new SqlCommand("update gelirgider set gelir = @gelir, gider = @gider, gelir_aciklama = @gelir_aciklama, gider_aciklama = @gider_aciklama, tarih = @tarih where id = @id", con);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@gelir", txt_gelir.Text);
                com.Parameters.AddWithValue("@gider", txt_gider.Text);
                com.Parameters.AddWithValue("@gelir_aciklama", txt_geliraciklama.Text);
                com.Parameters.AddWithValue("@gider_aciklama", txt_gideraciklama.Text);
                com.Parameters.AddWithValue("@tarih",dateTimePicker.Value);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tablo güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }

        }
        public void sil()
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz kaydı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    com = new SqlCommand("Delete from gelirgider where id=@id", con);
                    com.Parameters.AddWithValue("@id", txt_id.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    temizle();
                }

            }

        }
        private void Gelir_Gider_Load(object sender, EventArgs e)
        {
            panel_ekran.BackColor = Color.FromArgb(100, 0, 0, 0);
            ListeGetir();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Ekle(txt_gelir.Text.Trim(), txt_gider.Text.Trim(), txt_geliraciklama.Text.Trim(), txt_gideraciklama.Text.Trim());
            ListeGetir();

        }

        private void dataGridView_gelirgider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_gelirgider.Rows[e.RowIndex];
            txt_id.Text = row.Cells["id"].Value.ToString();
            txt_gelir.Text = row.Cells["gelir"].Value.ToString();
            txt_gider.Text = row.Cells["gider"].Value.ToString();
            txt_geliraciklama.Text = row.Cells["gelir_aciklama"].Value.ToString();
            txt_gideraciklama.Text = row.Cells["gider_aciklama"].Value.ToString();
            dateTimePicker.Value = Convert.ToDateTime(row.Cells["tarih"].Value);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            guncelle();
            ListeGetir();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ana_Ekran frm = new Ana_Ekran();
            this.Hide();
            frm.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            sil();
            ListeGetir();
        }

        private void txt_gelir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txt_gider_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
