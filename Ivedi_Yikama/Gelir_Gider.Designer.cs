namespace Ivedi_Yikama
{
    partial class Gelir_Gider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gelir_Gider));
            panel_ekran = new Panel();
            btn_sil = new Button();
            dateTimePicker = new DateTimePicker();
            label6 = new Label();
            dataGridView_gelirgider = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            gelir = new DataGridViewTextBoxColumn();
            gider = new DataGridViewTextBoxColumn();
            gelir_aciklama = new DataGridViewTextBoxColumn();
            gider_aciklama = new DataGridViewTextBoxColumn();
            tarih = new DataGridViewTextBoxColumn();
            btn_geri = new Button();
            btn_guncelle = new Button();
            btn_ekle = new Button();
            txt_gideraciklama = new TextBox();
            txt_geliraciklama = new TextBox();
            label4 = new Label();
            txt_gider = new TextBox();
            txt_gelir = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_ekran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_gelirgider).BeginInit();
            SuspendLayout();
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DimGray;
            panel_ekran.Controls.Add(btn_sil);
            panel_ekran.Controls.Add(dateTimePicker);
            panel_ekran.Controls.Add(label6);
            panel_ekran.Controls.Add(dataGridView_gelirgider);
            panel_ekran.Controls.Add(btn_geri);
            panel_ekran.Controls.Add(btn_guncelle);
            panel_ekran.Controls.Add(btn_ekle);
            panel_ekran.Controls.Add(txt_gideraciklama);
            panel_ekran.Controls.Add(txt_geliraciklama);
            panel_ekran.Controls.Add(label4);
            panel_ekran.Controls.Add(txt_gider);
            panel_ekran.Controls.Add(txt_gelir);
            panel_ekran.Controls.Add(txt_id);
            panel_ekran.Controls.Add(label5);
            panel_ekran.Controls.Add(label3);
            panel_ekran.Controls.Add(label2);
            panel_ekran.Controls.Add(label1);
            panel_ekran.Location = new Point(12, 12);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(780, 434);
            panel_ekran.TabIndex = 55;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(539, 62);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(109, 47);
            btn_sil.TabIndex = 65;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(305, 13);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(219, 23);
            dateTimePicker.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(229, 11);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 67;
            label6.Text = "Tarih : ";
            // 
            // dataGridView_gelirgider
            // 
            dataGridView_gelirgider.AllowUserToAddRows = false;
            dataGridView_gelirgider.AllowUserToDeleteRows = false;
            dataGridView_gelirgider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_gelirgider.BackgroundColor = Color.Gainsboro;
            dataGridView_gelirgider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_gelirgider.Columns.AddRange(new DataGridViewColumn[] { id, gelir, gider, gelir_aciklama, gider_aciklama, tarih });
            dataGridView_gelirgider.Location = new Point(10, 134);
            dataGridView_gelirgider.Name = "dataGridView_gelirgider";
            dataGridView_gelirgider.ReadOnly = true;
            dataGridView_gelirgider.RowHeadersVisible = false;
            dataGridView_gelirgider.Size = new Size(755, 277);
            dataGridView_gelirgider.TabIndex = 67;
            dataGridView_gelirgider.CellClick += dataGridView_gelirgider_CellClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // gelir
            // 
            gelir.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gelir.DataPropertyName = "gelir";
            gelir.HeaderText = "Gelir";
            gelir.Name = "gelir";
            gelir.ReadOnly = true;
            gelir.Width = 56;
            // 
            // gider
            // 
            gider.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gider.DataPropertyName = "gider";
            gider.HeaderText = "Gider";
            gider.Name = "gider";
            gider.ReadOnly = true;
            gider.Width = 60;
            // 
            // gelir_aciklama
            // 
            gelir_aciklama.DataPropertyName = "gelir_aciklama";
            gelir_aciklama.HeaderText = "Gelir Açıklama";
            gelir_aciklama.Name = "gelir_aciklama";
            gelir_aciklama.ReadOnly = true;
            // 
            // gider_aciklama
            // 
            gider_aciklama.DataPropertyName = "gider_aciklama";
            gider_aciklama.HeaderText = "Gider Açıklama";
            gider_aciklama.Name = "gider_aciklama";
            gider_aciklama.ReadOnly = true;
            // 
            // tarih
            // 
            tarih.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tarih.DataPropertyName = "tarih";
            tarih.HeaderText = "Tarih";
            tarih.Name = "tarih";
            tarih.ReadOnly = true;
            tarih.Width = 57;
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(654, 62);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(109, 47);
            btn_geri.TabIndex = 66;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(654, 11);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(109, 47);
            btn_guncelle.TabIndex = 64;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(539, 11);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(109, 47);
            btn_ekle.TabIndex = 63;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // txt_gideraciklama
            // 
            txt_gideraciklama.Location = new Point(380, 76);
            txt_gideraciklama.Name = "txt_gideraciklama";
            txt_gideraciklama.Size = new Size(144, 23);
            txt_gideraciklama.TabIndex = 61;
            // 
            // txt_geliraciklama
            // 
            txt_geliraciklama.Location = new Point(380, 47);
            txt_geliraciklama.Name = "txt_geliraciklama";
            txt_geliraciklama.Size = new Size(144, 23);
            txt_geliraciklama.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(225, 74);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 59;
            label4.Text = "Gider Açıklama :";
            // 
            // txt_gider
            // 
            txt_gider.Location = new Point(78, 75);
            txt_gider.Name = "txt_gider";
            txt_gider.Size = new Size(144, 23);
            txt_gider.TabIndex = 56;
            txt_gider.KeyPress += txt_gider_KeyPress;
            // 
            // txt_gelir
            // 
            txt_gelir.Location = new Point(78, 44);
            txt_gelir.Name = "txt_gelir";
            txt_gelir.Size = new Size(144, 23);
            txt_gelir.TabIndex = 52;
            txt_gelir.KeyPress += txt_gelir_KeyPress;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(78, 13);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(144, 23);
            txt_id.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 11);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 55;
            label5.Text = "No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 54;
            label3.Text = "Gider :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(232, 44);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 53;
            label2.Text = "Gelir Açıklama :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 51;
            label1.Text = "Gelir :";
            // 
            // Gelir_Gider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 458);
            Controls.Add(panel_ekran);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Gelir_Gider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Gider Listesi";
            FormClosing += Gelir_Gider_FormClosing;
            Load += Gelir_Gider_Load;
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_gelirgider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ekran;
        private Label label4;
        private TextBox txt_gider;
        private TextBox txt_gelir;
        private TextBox txt_id;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_gideraciklama;
        private TextBox txt_geliraciklama;
        private Button btn_guncelle;
        private Button btn_ekle;
        private Button btn_geri;
        private DataGridView dataGridView_gelirgider;
        private DateTimePicker dateTimePicker;
        private Label label6;
        private Button btn_sil;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn gelir;
        private DataGridViewTextBoxColumn gider;
        private DataGridViewTextBoxColumn gelir_aciklama;
        private DataGridViewTextBoxColumn gider_aciklama;
        private DataGridViewTextBoxColumn tarih;
    }
}