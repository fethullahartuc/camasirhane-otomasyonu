using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivedi_Yikama
{
    internal class veritabani
    {
        SqlConnection con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;
        // Müşterilerle alakalı methodlar

        // Müşteri getirme
        public void MusteriGetir(DataGridView tablo)
        {
            da = new SqlDataAdapter("select * from musteriler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteriler");
            tablo.DataSource = ds.Tables["musteriler"];
            con.Close();

        }

        // Kişi ekleme
        public void KisiEkle(string adi, string soyadi, string telefon, string adres)
        {
            // aynı müşterinin kaydı var mı diye kontrol ediyoruz.
            SqlCommand tekrar = new SqlCommand("select count(*) from musteriler where adi='" + adi + "' and " +
                "soyadi='" + soyadi + "' and " +
                "telefon='" + telefon + "' and " +
                "adres='" + adres + "'", con);
            con.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            con.Close();
            // eğer yoksa yani sonuc 0 ise kayıt oluşturuyoruz.
            if (sonuc == 0)
            {
                // boş kutu bırakırsa kayıt yapmıyoruz.
                if (adi.Trim() == "" || soyadi.Trim() == "" || telefon.Trim() == "" || adres.Trim() == "")
                {
                    MessageBox.Show("Boş kutu bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // kutular doluysa kayıt gerçekleştiriyoruz.
                else
                {
                    com = new SqlCommand("insert into musteriler(adi,soyadi,telefon,adres) values(@adi,@soyadi,@telefon,@adres)", con);
                    com.Parameters.AddWithValue("@adi", adi);
                    com.Parameters.AddWithValue("@soyadi", soyadi);
                    com.Parameters.AddWithValue("@telefon", telefon);
                    com.Parameters.AddWithValue("@adres", adres);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            // kayıt varsa yani sonuc 0 dan büyükse hata mesajı veriyoruz.
            else if (sonuc > 0)
            {
                MessageBox.Show("Kaydetmek istediğiniz müşteri zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        // Kişi güncelleme
        public void KisiGuncelle(string id,string adi, string soyadi, string telefon, string adres)
        {
            if(id=="")
            {
                MessageBox.Show("Güncellemek istediğiniz müşteriyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // aynı müşterinin kaydı var mı diye kontrol ediyoruz.
            SqlCommand tekrar = new SqlCommand("select count(*) from musteriler where adi='" + adi + "' and " +
                "soyadi='" + soyadi + "' and " +
                "telefon='" + telefon + "' and " +
                "adres='" + adres+ "'", con);
            con.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            // eğer varsa yani sonuc 1 ise hata oluşturuyoruz.
            if (sonuc == 1)
            {
                MessageBox.Show("Güncellemek istediğiniz müşteri zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // kayıt varsa yani sonuc 0 dan büyükse hata mesajı veriyoruz.
            else if (sonuc < 1)
            {
                con.Close();
                com = new SqlCommand("update musteriler set adi = @adi, soyadi = @soyadi, telefon = @telefon, adres = @adres where id = @id", con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@adi", adi);
                com.Parameters.AddWithValue("@soyadi", soyadi);
                com.Parameters.AddWithValue("@telefon", telefon);
                com.Parameters.AddWithValue("@adres", adres);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            con.Close();

        }

        // Kişi silme
        public void KisiSil(string id)
        {
            if (MessageBox.Show("Müşteriyi silmek istediğinizden emin misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                if (id == "")
                {
                    MessageBox.Show("Silmek istediğiniz müşteriyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con = new SqlConnection("Data Source=DARKRAIDISASTER;Initial Catalog=ivediyikama;Integrated Security=True;");
                com = new SqlCommand("Delete from musteriler where id=@id", con);
                com.Parameters.AddWithValue("@id", id);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        // Kişi bulma
        
        public void KisiBul(ComboBox combobox,DataGridView datagrid,string bul,string durum,string baglanti)
        {

            if (combobox.SelectedIndex == 0)
            {
                ds.Tables[durum].Clear();
                con.Open();
                da = new SqlDataAdapter(baglanti + " adi like '%" + bul + "%'", con);
                da.Fill(ds, durum);
                datagrid.DataSource = ds.Tables[durum];
                con.Close();

            }
            else if (combobox.SelectedIndex == 1)
            {
                ds.Tables[durum].Clear();
                con.Open();
                da = new SqlDataAdapter(baglanti + " soyadi like '%" + bul + "%'", con);
                da.Fill(ds, durum);
                datagrid.DataSource = ds.Tables[durum];
                con.Close();
            }
            else if (combobox.SelectedIndex == 2)
            {
                ds.Tables[durum].Clear();
                con.Open();
                da = new SqlDataAdapter(baglanti + " telefon like '%" + bul + "%'", con);
                da.Fill(ds, durum);
                datagrid.DataSource = ds.Tables[durum];
                con.Close();
            }
            else if (combobox.SelectedIndex == 3)
            {
                ds.Tables[durum].Clear();
                con.Open();
                da = new SqlDataAdapter(baglanti + " adres like '%" + bul + "%'", con);
                da.Fill(ds, durum);
                datagrid.DataSource = ds.Tables[durum];
                con.Close();
            }
        }

        // Sipariş oluşturma

        public void SiparisOlustur(string id, string adi, string soyadi, string telefon, string adres)
        {
            if (id != "")
            {
                // aynı siparis kaydı var mı diye kontrol ediyoruz.
                SqlCommand tekrar = new SqlCommand("select count(*) from halidurumu " +
                    "INNER JOIN musteriler on halidurumu.musteri_id = musteriler.id where alinacak=1 and " +
                    " adi='" + adi + "' and " +
               "soyadi='" + soyadi + "' and " +
               "telefon='" + telefon + "' and " +
               "adres='" + adres + "'", con);
                con.Open();
                int sonuc = (int)tekrar.ExecuteScalar();
                con.Close();
                // eğer yoksa yani sonuc 0 ise siparis oluşturuyoruz.
                if (sonuc == 0)
                {
                    com = new SqlCommand("insert into halidurumu(musteri_id,alinacak,yikamada,verilecek,siparis_tarihi) " +
                        "values(@musteri_id,@alinacak,@yikamada,@verilecek,@siparis_tarihi)", con);
                    com.Parameters.AddWithValue("@musteri_id", id);
                    com.Parameters.AddWithValue("@alinacak", 1);
                    com.Parameters.AddWithValue("@yikamada", 0);
                    com.Parameters.AddWithValue("@verilecek", 0);
                    com.Parameters.AddWithValue("@siparis_tarihi", DateTime.Now);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sipariş başarılı şekilde oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sipariş zaten oluşturulmuş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sipariş vermek için önce müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        // Sipariş Sil
        public void SiparisSil(string id)
        {

            if (id != "")
            {
                com = new SqlCommand("Delete from halidurumu where musteri_id=@id", con);
                com.Parameters.AddWithValue("@id", id);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        // Müşterilerle alakalı tablo bitiş 

        public void ListeGetir(DataGridView datagrid,string tablo)
        {
            da = new SqlDataAdapter("select halidurumu.id,musteriler.adi,musteriler.soyadi,musteriler.telefon,musteriler.adres," +
                "halidurumu.siparis_tarihi from " +
                "musteriler INNER JOIN halidurumu on musteriler.id = halidurumu.musteri_id where halidurumu."+tablo+"=1;", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "halidurumu");
            datagrid.DataSource = ds.Tables["halidurumu"];
            con.Close();

        }

        // Alındı verildi işlemleri

        public void islemyap_alindi(string id,DataGridView datagrid,string tabloadı)
        {
            
                com = new SqlCommand("update halidurumu set alinacak = @alinacak ,yikamada = @yikamada ,verilecek = @verilecek " +
                    " where id = @id", con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@alinacak", 0);
                com.Parameters.AddWithValue("@yikamada", 1);
                com.Parameters.AddWithValue("@verilecek", 0);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                id = "";
                ListeGetir(datagrid, tabloadı);

        }
        public void islemyap_yikandi(string id, DataGridView datagrid, string tabloadı)
        {

            com = new SqlCommand("update halidurumu set alinacak = @alinacak ,yikamada = @yikamada ,verilecek = @verilecek  " +
                " where id = @id", con);
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@alinacak", 0);
            com.Parameters.AddWithValue("@yikamada", 0);
            com.Parameters.AddWithValue("@verilecek", 1);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            id = "";
            ListeGetir(datagrid, tabloadı);

        }
        public void islemyap_teslimedildi(string id, DataGridView datagrid, string tabloadı)
        {

            com = new SqlCommand("update halidurumu set alinacak = @alinacak ,yikamada = @yikamada ,verilecek = @verilecek ,teslim_edildi = @teslim_edildi " +
                " where id = @id", con);
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@alinacak", 0);
            com.Parameters.AddWithValue("@yikamada", 0);
            com.Parameters.AddWithValue("@verilecek", 0);
            com.Parameters.AddWithValue("@teslim_edildi", 1);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            id = "";
            ListeGetir(datagrid, tabloadı);

        }

    }
}
