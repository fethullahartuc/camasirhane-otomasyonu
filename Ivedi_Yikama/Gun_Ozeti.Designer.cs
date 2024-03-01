namespace Ivedi_Yikama
{
    partial class Gun_Ozeti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gun_Ozeti));
            panel_ekran = new Panel();
            lbl_tarih = new Label();
            lbl_teslimadet = new Label();
            lbl_tarihedilenadres = new Label();
            dateTimePicker = new DateTimePicker();
            btn_geri = new Button();
            label5 = new Label();
            dataGridView_gunozeti = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            adi = new DataGridViewTextBoxColumn();
            soyadi = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            adres = new DataGridViewTextBoxColumn();
            siparis_tarihi = new DataGridViewTextBoxColumn();
            teslim_tarihi = new DataGridViewTextBoxColumn();
            panel_ekran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_gunozeti).BeginInit();
            SuspendLayout();
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DimGray;
            panel_ekran.Controls.Add(lbl_tarih);
            panel_ekran.Controls.Add(lbl_teslimadet);
            panel_ekran.Controls.Add(lbl_tarihedilenadres);
            panel_ekran.Controls.Add(dateTimePicker);
            panel_ekran.Controls.Add(btn_geri);
            panel_ekran.Controls.Add(label5);
            panel_ekran.Location = new Point(14, 12);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(776, 72);
            panel_ekran.TabIndex = 58;
            // 
            // lbl_tarih
            // 
            lbl_tarih.AutoSize = true;
            lbl_tarih.BackColor = Color.Transparent;
            lbl_tarih.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_tarih.ForeColor = Color.White;
            lbl_tarih.Location = new Point(104, 9);
            lbl_tarih.Name = "lbl_tarih";
            lbl_tarih.Size = new Size(55, 25);
            lbl_tarih.TabIndex = 61;
            lbl_tarih.Text = "Tarih";
            // 
            // lbl_teslimadet
            // 
            lbl_teslimadet.AutoSize = true;
            lbl_teslimadet.BackColor = Color.Transparent;
            lbl_teslimadet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_teslimadet.ForeColor = Color.White;
            lbl_teslimadet.Location = new Point(308, 34);
            lbl_teslimadet.Name = "lbl_teslimadet";
            lbl_teslimadet.Size = new Size(23, 25);
            lbl_teslimadet.TabIndex = 60;
            lbl_teslimadet.Text = "0";
            // 
            // lbl_tarihedilenadres
            // 
            lbl_tarihedilenadres.AutoSize = true;
            lbl_tarihedilenadres.BackColor = Color.Transparent;
            lbl_tarihedilenadres.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_tarihedilenadres.ForeColor = Color.White;
            lbl_tarihedilenadres.Location = new Point(6, 34);
            lbl_tarihedilenadres.Name = "lbl_tarihedilenadres";
            lbl_tarihedilenadres.Size = new Size(311, 25);
            lbl_tarihedilenadres.TabIndex = 59;
            lbl_tarihedilenadres.Text = " Tarihinde Teslim Edilen Adresler : ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(431, 37);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(204, 23);
            dateTimePicker.TabIndex = 58;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(654, 13);
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
            label5.Location = new Point(427, 11);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 53;
            label5.Text = "Tarih : ";
            // 
            // dataGridView_gunozeti
            // 
            dataGridView_gunozeti.AllowUserToAddRows = false;
            dataGridView_gunozeti.AllowUserToDeleteRows = false;
            dataGridView_gunozeti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_gunozeti.BackgroundColor = Color.Gainsboro;
            dataGridView_gunozeti.Columns.AddRange(new DataGridViewColumn[] { id, adi, soyadi, telefon, adres, siparis_tarihi, teslim_tarihi });
            dataGridView_gunozeti.Location = new Point(14, 97);
            dataGridView_gunozeti.Name = "dataGridView_gunozeti";
            dataGridView_gunozeti.ReadOnly = true;
            dataGridView_gunozeti.RowHeadersVisible = false;
            dataGridView_gunozeti.Size = new Size(776, 271);
            dataGridView_gunozeti.TabIndex = 59;
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
            // teslim_tarihi
            // 
            teslim_tarihi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            teslim_tarihi.DataPropertyName = "teslim_tarihi";
            teslim_tarihi.HeaderText = "Teslim Tarihi";
            teslim_tarihi.Name = "teslim_tarihi";
            teslim_tarihi.ReadOnly = true;
            teslim_tarihi.Width = 96;
            // 
            // Gun_Ozeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 381);
            Controls.Add(dataGridView_gunozeti);
            Controls.Add(panel_ekran);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Gun_Ozeti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gün Özeti";
            FormClosing += Gun_Ozeti_FormClosing;
            Load += Gun_Ozeti_Load;
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_gunozeti).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_ekran;
        private Button btn_geri;
        private Label label5;
        private DateTimePicker dateTimePicker;
        private DataGridView dataGridView_gunozeti;
        private Label lbl_tarihedilenadres;
        private Label lbl_tarih;
        private Label lbl_teslimadet;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn adi;
        private DataGridViewTextBoxColumn soyadi;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn adres;
        private DataGridViewTextBoxColumn siparis_tarihi;
        private DataGridViewTextBoxColumn teslim_tarihi;
    }
}