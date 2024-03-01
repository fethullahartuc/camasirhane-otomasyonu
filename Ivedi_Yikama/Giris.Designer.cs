namespace Ivedi_Yikama
{
    partial class Form_Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Giris));
            panel_ekran = new Panel();
            link_hesapolustur = new LinkLabel();
            btn_cikis = new Button();
            btn_giris = new Button();
            lbl_giris = new Label();
            txt_sifre = new TextBox();
            txt_kadi = new TextBox();
            lbl_sifre = new Label();
            lbl_kadı = new Label();
            panel_ekran.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DarkGray;
            panel_ekran.Controls.Add(link_hesapolustur);
            panel_ekran.Controls.Add(btn_cikis);
            panel_ekran.Controls.Add(btn_giris);
            panel_ekran.Controls.Add(lbl_giris);
            panel_ekran.Controls.Add(txt_sifre);
            panel_ekran.Controls.Add(txt_kadi);
            panel_ekran.Controls.Add(lbl_sifre);
            panel_ekran.Controls.Add(lbl_kadı);
            panel_ekran.Location = new Point(17, 30);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(250, 300);
            panel_ekran.TabIndex = 3;
            // 
            // link_hesapolustur
            // 
            link_hesapolustur.ActiveLinkColor = Color.FromArgb(242, 241, 235);
            link_hesapolustur.AutoSize = true;
            link_hesapolustur.BackColor = Color.Transparent;
            link_hesapolustur.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            link_hesapolustur.ForeColor = Color.White;
            link_hesapolustur.LinkColor = Color.White;
            link_hesapolustur.Location = new Point(30, 192);
            link_hesapolustur.Name = "link_hesapolustur";
            link_hesapolustur.Size = new Size(192, 15);
            link_hesapolustur.TabIndex = 7;
            link_hesapolustur.TabStop = true;
            link_hesapolustur.Text = "Üye değil misiniz ? Kaydolun";
            link_hesapolustur.TextAlign = ContentAlignment.MiddleCenter;
            link_hesapolustur.VisitedLinkColor = Color.DarkGray;
            link_hesapolustur.LinkClicked += link_hesapolustur_LinkClicked;
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(135, 223);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(87, 49);
            btn_cikis.TabIndex = 6;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = true;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(30, 223);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(87, 49);
            btn_giris.TabIndex = 5;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // lbl_giris
            // 
            lbl_giris.AutoSize = true;
            lbl_giris.BackColor = Color.Transparent;
            lbl_giris.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_giris.ForeColor = Color.White;
            lbl_giris.Location = new Point(83, 22);
            lbl_giris.Name = "lbl_giris";
            lbl_giris.Size = new Size(87, 37);
            lbl_giris.TabIndex = 4;
            lbl_giris.Text = "GİRİŞ";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(27, 155);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(198, 23);
            txt_sifre.TabIndex = 3;
            // 
            // txt_kadi
            // 
            txt_kadi.Location = new Point(27, 103);
            txt_kadi.Name = "txt_kadi";
            txt_kadi.Size = new Size(198, 23);
            txt_kadi.TabIndex = 2;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Transparent;
            lbl_sifre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbl_sifre.ForeColor = Color.White;
            lbl_sifre.Location = new Point(27, 132);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(47, 20);
            lbl_sifre.TabIndex = 1;
            lbl_sifre.Text = "Şifre";
            // 
            // lbl_kadı
            // 
            lbl_kadı.AutoSize = true;
            lbl_kadı.BackColor = Color.Transparent;
            lbl_kadı.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbl_kadı.ForeColor = Color.White;
            lbl_kadı.Location = new Point(27, 80);
            lbl_kadı.Name = "lbl_kadı";
            lbl_kadı.Size = new Size(111, 20);
            lbl_kadı.TabIndex = 0;
            lbl_kadı.Text = "Kullanıcı Adı ";
            // 
            // Form_Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(284, 361);
            Controls.Add(panel_ekran);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            FormClosing += Form_Giris_FormClosing;
            Load += Form1_Load;
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_ekran;
        private Label lbl_giris;
        private TextBox txt_sifre;
        private TextBox txt_kadi;
        private Label lbl_sifre;
        private Label lbl_kadı;
        private LinkLabel link_hesapolustur;
        private Button btn_cikis;
        private Button btn_giris;
    }
}
