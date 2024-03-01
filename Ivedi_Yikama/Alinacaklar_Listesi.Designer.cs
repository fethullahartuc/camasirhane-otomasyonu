namespace Ivedi_Yikama
{
    partial class Alinacaklar_Listesi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alinacaklar_Listesi));
            dataGridView_alinacaklar = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            adi = new DataGridViewTextBoxColumn();
            soyadi = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            adres = new DataGridViewTextBoxColumn();
            siparis_tarihi = new DataGridViewTextBoxColumn();
            btn_geri = new Button();
            txt_id = new TextBox();
            btn_alindi = new Button();
            label5 = new Label();
            panel_ekran = new Panel();
            label7 = new Label();
            comboBox_arama = new ComboBox();
            txt_bul = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_alinacaklar).BeginInit();
            panel_ekran.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_alinacaklar
            // 
            dataGridView_alinacaklar.AllowUserToAddRows = false;
            dataGridView_alinacaklar.AllowUserToDeleteRows = false;
            dataGridView_alinacaklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_alinacaklar.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_alinacaklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_alinacaklar.Columns.AddRange(new DataGridViewColumn[] { id, adi, soyadi, telefon, adres, siparis_tarihi });
            dataGridView_alinacaklar.Location = new Point(14, 97);
            dataGridView_alinacaklar.Name = "dataGridView_alinacaklar";
            dataGridView_alinacaklar.ReadOnly = true;
            dataGridView_alinacaklar.RowHeadersVisible = false;
            dataGridView_alinacaklar.Size = new Size(776, 271);
            dataGridView_alinacaklar.TabIndex = 11;
            dataGridView_alinacaklar.CellClick += dataGridView_alinacaklar_CellClick;
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
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(71, 23);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(144, 23);
            txt_id.TabIndex = 51;
            // 
            // btn_alindi
            // 
            btn_alindi.Location = new Point(237, 13);
            btn_alindi.Name = "btn_alindi";
            btn_alindi.Size = new Size(109, 47);
            btn_alindi.TabIndex = 52;
            btn_alindi.Text = "Alındı";
            btn_alindi.UseVisualStyleBackColor = true;
            btn_alindi.Click += btn_alindi_Click;
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
            panel_ekran.Controls.Add(btn_alindi);
            panel_ekran.Location = new Point(14, 12);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(776, 72);
            panel_ekran.TabIndex = 54;
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
            // Alinacaklar_Listesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 381);
            Controls.Add(panel_ekran);
            Controls.Add(dataGridView_alinacaklar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Alinacaklar_Listesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alınacaklar Listesi";
            FormClosing += Alinacaklar_Listesi_FormClosing;
            Load += Alinacaklar_Listesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_alinacaklar).EndInit();
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_alinacaklar;
        private Button btn_geri;
        private TextBox txt_id;
        private Button btn_alindi;
        private Label label5;
        private Panel panel_ekran;
        private Label label7;
        private ComboBox comboBox_arama;
        private TextBox txt_bul;
        private Label label6;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn adi;
        private DataGridViewTextBoxColumn soyadi;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn adres;
        private DataGridViewTextBoxColumn siparis_tarihi;
    }
}