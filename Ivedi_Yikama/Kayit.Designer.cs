namespace Ivedi_Yikama
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            panel_ekran = new Panel();
            txt_sifretekrar = new TextBox();
            label1 = new Label();
            link_girisyap = new LinkLabel();
            btn_cikis = new Button();
            btn_kayit = new Button();
            lbl_kayit = new Label();
            txt_sifre = new TextBox();
            txt_kadi = new TextBox();
            lbl_sifre = new Label();
            lbl_kadi = new Label();
            panel_ekran.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ekran
            // 
            panel_ekran.BackColor = Color.DarkGray;
            panel_ekran.Controls.Add(txt_sifretekrar);
            panel_ekran.Controls.Add(label1);
            panel_ekran.Controls.Add(link_girisyap);
            panel_ekran.Controls.Add(btn_cikis);
            panel_ekran.Controls.Add(btn_kayit);
            panel_ekran.Controls.Add(lbl_kayit);
            panel_ekran.Controls.Add(txt_sifre);
            panel_ekran.Controls.Add(txt_kadi);
            panel_ekran.Controls.Add(lbl_sifre);
            panel_ekran.Controls.Add(lbl_kadi);
            panel_ekran.Location = new Point(16, 11);
            panel_ekran.Name = "panel_ekran";
            panel_ekran.Size = new Size(253, 338);
            panel_ekran.TabIndex = 5;
            // 
            // txt_sifretekrar
            // 
            txt_sifretekrar.Location = new Point(27, 200);
            txt_sifretekrar.Name = "txt_sifretekrar";
            txt_sifretekrar.PasswordChar = '*';
            txt_sifretekrar.Size = new Size(198, 23);
            txt_sifretekrar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 177);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 8;
            label1.Text = "Şifre Tekrar";
            // 
            // link_girisyap
            // 
            link_girisyap.ActiveLinkColor = Color.FromArgb(242, 241, 235);
            link_girisyap.AutoSize = true;
            link_girisyap.BackColor = Color.Transparent;
            link_girisyap.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            link_girisyap.ForeColor = Color.White;
            link_girisyap.LinkColor = Color.White;
            link_girisyap.Location = new Point(41, 228);
            link_girisyap.Name = "link_girisyap";
            link_girisyap.Size = new Size(171, 15);
            link_girisyap.TabIndex = 7;
            link_girisyap.TabStop = true;
            link_girisyap.Text = "Üye misiniz ? Giriş Yapın.";
            link_girisyap.TextAlign = ContentAlignment.MiddleCenter;
            link_girisyap.VisitedLinkColor = Color.DarkGray;
            link_girisyap.LinkClicked += link_hesapolustur_LinkClicked;
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(135, 259);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(87, 49);
            btn_cikis.TabIndex = 6;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = true;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(30, 259);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(87, 49);
            btn_kayit.TabIndex = 5;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // lbl_kayit
            // 
            lbl_kayit.AutoSize = true;
            lbl_kayit.BackColor = Color.Transparent;
            lbl_kayit.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_kayit.ForeColor = Color.White;
            lbl_kayit.Location = new Point(59, 22);
            lbl_kayit.Name = "lbl_kayit";
            lbl_kayit.Size = new Size(134, 37);
            lbl_kayit.TabIndex = 4;
            lbl_kayit.Text = "KAYIT OL";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(27, 151);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(198, 23);
            txt_sifre.TabIndex = 3;
            // 
            // txt_kadi
            // 
            txt_kadi.Location = new Point(27, 99);
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
            lbl_sifre.Location = new Point(27, 128);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(47, 20);
            lbl_sifre.TabIndex = 1;
            lbl_sifre.Text = "Şifre";
            // 
            // lbl_kadi
            // 
            lbl_kadi.AutoSize = true;
            lbl_kadi.BackColor = Color.Transparent;
            lbl_kadi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbl_kadi.ForeColor = Color.White;
            lbl_kadi.Location = new Point(27, 76);
            lbl_kadi.Name = "lbl_kadi";
            lbl_kadi.Size = new Size(111, 20);
            lbl_kadi.TabIndex = 0;
            lbl_kadi.Text = "Kullanıcı Adı ";
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(284, 361);
            Controls.Add(panel_ekran);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            FormClosing += Kayit_FormClosing;
            Load += Form_Kayit_Load;
            panel_ekran.ResumeLayout(false);
            panel_ekran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_ekran;
        private LinkLabel link_girisyap;
        private Button btn_cikis;
        private Button btn_kayit;
        private Label lbl_kayit;
        private TextBox txt_sifre;
        private TextBox txt_kadi;
        private Label lbl_sifre;
        private Label lbl_kadi;
        private TextBox txt_sifretekrar;
        private Label label1;
    }
}