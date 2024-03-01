namespace Ivedi_Yikama
{
    partial class Yikamadakiler_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yikamadakiler_Listesi));
            panel_ekran = new Panel();
            label7 = new Label();
            comboBox_arama = new ComboBox();
            txt_bul = new TextBox();
            label6 = new Label();
            btn_geri = new Button();
            label5 = new Label();
            txt_id = new TextBox();
            btn_yikandi = new Button();
            dataGridView_yikamada = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            adi = new DataGridViewTextBoxColumn();
            soyadi = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            adres = new DataGridViewTextBoxColumn();
            siparis_tarihi = new DataGridViewTextBoxColumn();
            panel_ekran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_yikamada).BeginInit();
            SuspendLayout();
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DimGray;
            panel_ekran.Controls.Add(label7);
            panel_ekran.Controls.Add(comboBox_arama);
            panel_ekran.Controls.Add(txt_bul);
            panel_ekran.Controls.Add(label6);
            panel_ekran.Controls.Add(btn_geri);
            panel_ekran.Controls.Add(label5);
            panel_ekran.Controls.Add(txt_id);
            panel_ekran.Controls.Add(btn_yikandi);
            panel_ekran.Location = new Point(14, 12);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(776, 72);
            panel_ekran.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(466, 13);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 57;
            label7.Text = "Arama Türü :";
            // 
            // comboBox_arama
            // 
            comboBox_arama.FormattingEnabled = true;
            comboBox_arama.Items.AddRange(new object[] { "Adı", "Soyadı", "Telefon", "Adres" });
            comboBox_arama.Location = new Point(599, 13);
            comboBox_arama.Name = "comboBox_arama";
            comboBox_arama.Size = new Size(166, 23);
            comboBox_arama.TabIndex = 54;
            // 
            // txt_bul
            // 
            txt_bul.Location = new Point(599, 42);
            txt_bul.Name = "txt_bul";
            txt_bul.Size = new Size(166, 23);
            txt_bul.TabIndex = 56;
            txt_bul.TextChanged += txt_bul_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(542, 41);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 55;
            label6.Text = "Bul :";
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(352, 13);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(109, 47);
            btn_geri.TabIndex = 15;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 21);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 53;
            label5.Text = "ID : ";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(71, 23);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(144, 23);
            txt_id.TabIndex = 51;
            // 
            // btn_yikandi
            // 
            btn_yikandi.Location = new Point(237, 13);
            btn_yikandi.Name = "btn_yikandi";
            btn_yikandi.Size = new Size(109, 47);
            btn_yikandi.TabIndex = 52;
            btn_yikandi.Text = "Yıkandı";
            btn_yikandi.UseVisualStyleBackColor = true;
            btn_yikandi.Click += btn_yikandi_Click;
            // 
            // dataGridView_yikamada
            // 
            dataGridView_yikamada.AllowUserToAddRows = false;
            dataGridView_yikamada.AllowUserToDeleteRows = false;
            dataGridView_yikamada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_yikamada.BackgroundColor = Color.Gainsboro;
            dataGridView_yikamada.Columns.AddRange(new DataGridViewColumn[] { id, adi, soyadi, telefon, adres, siparis_tarihi });
            dataGridView_yikamada.Location = new Point(14, 97);
            dataGridView_yikamada.Name = "dataGridView_yikamada";
            dataGridView_yikamada.ReadOnly = true;
            dataGridView_yikamada.RowHeadersVisible = false;
            dataGridView_yikamada.Size = new Size(776, 271);
            dataGridView_yikamada.TabIndex = 56;
            dataGridView_yikamada.CellClick += dataGridView_alinacaklar_CellClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.DataPropertyName = "id";
            id.HeaderText = "Sipariş ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 80;
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
            // siparis_tarihi
            // 
            siparis_tarihi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            siparis_tarihi.DataPropertyName = "siparis_tarihi";
            siparis_tarihi.HeaderText = "Sipariş Tarihi";
            siparis_tarihi.Name = "siparis_tarihi";
            siparis_tarihi.ReadOnly = true;
            siparis_tarihi.Width = 97;
            // 
            // Yikamadakiler_Listesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 381);
            Controls.Add(panel_ekran);
            Controls.Add(dataGridView_yikamada);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Yikamadakiler_Listesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yıkamada Olanlar Listesi";
            FormClosing += Yikamadakiler_Listesi_FormClosing;
            Load += Yikamadakiler_Listesi_Load;
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_yikamada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ekran;
        private Label label7;
        private ComboBox comboBox_arama;
        private TextBox txt_bul;
        private Label label6;
        private Button btn_geri;
        private Label label5;
        private TextBox txt_id;
        private Button btn_yikandi;
        private DataGridView dataGridView_yikamada;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn adi;
        private DataGridViewTextBoxColumn soyadi;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn adres;
        private DataGridViewTextBoxColumn siparis_tarihi;
    }
}