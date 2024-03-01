namespace Ivedi_Yikama
{
    partial class Musteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            dataGridView_musteriler = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            adi = new DataGridViewTextBoxColumn();
            soyadi = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            adres = new DataGridViewTextBoxColumn();
            panel_ekran = new Panel();
            txt_bul = new TextBox();
            txt_telefon = new MaskedTextBox();
            btn_siparis = new Button();
            label7 = new Label();
            comboBox_arama = new ComboBox();
            label6 = new Label();
            txt_adres = new RichTextBox();
            btn_geri = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            btn_ekle = new Button();
            txt_soyadi = new TextBox();
            txt_adi = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_musteriler).BeginInit();
            panel_ekran.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_musteriler
            // 
            dataGridView_musteriler.AllowUserToAddRows = false;
            dataGridView_musteriler.AllowUserToDeleteRows = false;
            dataGridView_musteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_musteriler.BackgroundColor = Color.Gainsboro;
            dataGridView_musteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_musteriler.Columns.AddRange(new DataGridViewColumn[] { id, adi, soyadi, telefon, adres });
            dataGridView_musteriler.Location = new Point(12, 284);
            dataGridView_musteriler.Name = "dataGridView_musteriler";
            dataGridView_musteriler.ReadOnly = true;
            dataGridView_musteriler.RowHeadersVisible = false;
            dataGridView_musteriler.Size = new Size(641, 263);
            dataGridView_musteriler.TabIndex = 10;
            dataGridView_musteriler.CellClick += dataGridView_musteriler_CellClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.DataPropertyName = "id";
            id.HeaderText = "Müşteri No";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 91;
            // 
            // adi
            // 
            adi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            adi.DataPropertyName = "adi";
            adi.HeaderText = "Adı";
            adi.Name = "adi";
            adi.ReadOnly = true;
            adi.Width = 50;
            // 
            // soyadi
            // 
            soyadi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            soyadi.DataPropertyName = "soyadi";
            soyadi.HeaderText = "Soyadı";
            soyadi.Name = "soyadi";
            soyadi.ReadOnly = true;
            soyadi.Width = 67;
            // 
            // telefon
            // 
            telefon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefon.DataPropertyName = "telefon";
            telefon.HeaderText = "Telefon";
            telefon.Name = "telefon";
            telefon.ReadOnly = true;
            telefon.Width = 70;
            // 
            // adres
            // 
            adres.DataPropertyName = "adres";
            adres.HeaderText = "Adres";
            adres.Name = "adres";
            adres.ReadOnly = true;
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DimGray;
            panel_ekran.Controls.Add(txt_bul);
            panel_ekran.Controls.Add(txt_telefon);
            panel_ekran.Controls.Add(btn_siparis);
            panel_ekran.Controls.Add(label7);
            panel_ekran.Controls.Add(comboBox_arama);
            panel_ekran.Controls.Add(label6);
            panel_ekran.Controls.Add(txt_adres);
            panel_ekran.Controls.Add(btn_geri);
            panel_ekran.Controls.Add(btn_sil);
            panel_ekran.Controls.Add(btn_guncelle);
            panel_ekran.Controls.Add(btn_ekle);
            panel_ekran.Controls.Add(txt_soyadi);
            panel_ekran.Controls.Add(txt_adi);
            panel_ekran.Controls.Add(txt_id);
            panel_ekran.Controls.Add(label5);
            panel_ekran.Controls.Add(label4);
            panel_ekran.Controls.Add(label3);
            panel_ekran.Controls.Add(label2);
            panel_ekran.Controls.Add(label1);
            panel_ekran.Location = new Point(12, 14);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(641, 261);
            panel_ekran.TabIndex = 11;
            // 
            // txt_bul
            // 
            txt_bul.Location = new Point(410, 153);
            txt_bul.Name = "txt_bul";
            txt_bul.Size = new Size(166, 23);
            txt_bul.TabIndex = 51;
            txt_bul.TextChanged += txt_bul_TextChanged;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(100, 153);
            txt_telefon.Mask = "(999) 000-0000";
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(144, 23);
            txt_telefon.TabIndex = 8;
            txt_telefon.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_siparis
            // 
            btn_siparis.Location = new Point(389, 199);
            btn_siparis.Name = "btn_siparis";
            btn_siparis.Size = new Size(109, 47);
            btn_siparis.TabIndex = 13;
            btn_siparis.Text = "Sipariş Oluştur";
            btn_siparis.UseVisualStyleBackColor = true;
            btn_siparis.Click += btn_siparis_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(277, 121);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 18;
            label7.Text = "Arama Türü :";
            // 
            // comboBox_arama
            // 
            comboBox_arama.FormattingEnabled = true;
            comboBox_arama.Items.AddRange(new object[] { "Adı", "Soyadı", "Telefon", "Adres" });
            comboBox_arama.Location = new Point(410, 121);
            comboBox_arama.Name = "comboBox_arama";
            comboBox_arama.Size = new Size(166, 23);
            comboBox_arama.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(353, 149);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 15;
            label6.Text = "Bul :";
            // 
            // txt_adres
            // 
            txt_adres.Location = new Point(277, 32);
            txt_adres.Name = "txt_adres";
            txt_adres.Size = new Size(299, 83);
            txt_adres.TabIndex = 9;
            txt_adres.Text = "";
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(512, 199);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(109, 47);
            btn_geri.TabIndex = 14;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_cikis_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(143, 199);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(109, 47);
            btn_sil.TabIndex = 11;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(266, 199);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(109, 47);
            btn_guncelle.TabIndex = 12;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(20, 199);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(109, 47);
            btn_ekle.TabIndex = 10;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // txt_soyadi
            // 
            txt_soyadi.Location = new Point(100, 107);
            txt_soyadi.Name = "txt_soyadi";
            txt_soyadi.Size = new Size(144, 23);
            txt_soyadi.TabIndex = 7;
            // 
            // txt_adi
            // 
            txt_adi.Location = new Point(100, 58);
            txt_adi.Name = "txt_adi";
            txt_adi.Size = new Size(144, 23);
            txt_adi.TabIndex = 1;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(100, 9);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(144, 23);
            txt_id.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 9);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "No : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(277, 4);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Adres : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefon : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı : ";
            // 
            // Musteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(664, 561);
            Controls.Add(panel_ekran);
            Controls.Add(dataGridView_musteriler);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Musteriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteriler";
            FormClosing += Musteriler_FormClosing;
            Load += Musteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_musteriler).EndInit();
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_musteriler;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn adi;
        private DataGridViewTextBoxColumn soyadi;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn adres;
        private Panel panel_ekran;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_soyadi;
        private TextBox txt_adi;
        private TextBox txt_id;
        private Button btn_geri;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_ekle;
        private RichTextBox txt_adres;
        private Label label7;
        private ComboBox comboBox_arama;
        private Label label6;
        private Button btn_siparis;
        private MaskedTextBox txt_telefon;
        private TextBox txt_bul;
    }
}