namespace Ivedi_Yikama
{
    partial class Ana_Ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Ekran));
            btn_alinacaklar = new Button();
            btn_yikamadalar = new Button();
            btn_teslim = new Button();
            btn_musteriler = new Button();
            btn_gunozeti = new Button();
            btn_gelirgider = new Button();
            SuspendLayout();
            // 
            // btn_alinacaklar
            // 
            btn_alinacaklar.Image = (Image)resources.GetObject("btn_alinacaklar.Image");
            btn_alinacaklar.ImageAlign = ContentAlignment.TopCenter;
            btn_alinacaklar.Location = new Point(21, 19);
            btn_alinacaklar.Name = "btn_alinacaklar";
            btn_alinacaklar.Padding = new Padding(0, 10, 0, 10);
            btn_alinacaklar.Size = new Size(126, 86);
            btn_alinacaklar.TabIndex = 0;
            btn_alinacaklar.Text = "Alınacaklar Listesi";
            btn_alinacaklar.TextAlign = ContentAlignment.BottomCenter;
            btn_alinacaklar.UseVisualStyleBackColor = true;
            btn_alinacaklar.Click += btn_alinacaklar_Click;
            // 
            // btn_yikamadalar
            // 
            btn_yikamadalar.Image = (Image)resources.GetObject("btn_yikamadalar.Image");
            btn_yikamadalar.ImageAlign = ContentAlignment.TopCenter;
            btn_yikamadalar.Location = new Point(187, 19);
            btn_yikamadalar.Name = "btn_yikamadalar";
            btn_yikamadalar.Padding = new Padding(0, 10, 0, 10);
            btn_yikamadalar.Size = new Size(126, 86);
            btn_yikamadalar.TabIndex = 1;
            btn_yikamadalar.Text = "Yıkamada Olanlar";
            btn_yikamadalar.TextAlign = ContentAlignment.BottomCenter;
            btn_yikamadalar.UseVisualStyleBackColor = true;
            btn_yikamadalar.Click += btn_yikamadalar_Click;
            // 
            // btn_teslim
            // 
            btn_teslim.Image = (Image)resources.GetObject("btn_teslim.Image");
            btn_teslim.ImageAlign = ContentAlignment.TopCenter;
            btn_teslim.Location = new Point(21, 127);
            btn_teslim.Name = "btn_teslim";
            btn_teslim.Padding = new Padding(0, 10, 0, 10);
            btn_teslim.Size = new Size(126, 86);
            btn_teslim.TabIndex = 2;
            btn_teslim.Text = "Teslim Edilecekler";
            btn_teslim.TextAlign = ContentAlignment.BottomCenter;
            btn_teslim.UseVisualStyleBackColor = true;
            btn_teslim.Click += btn_teslim_Click;
            // 
            // btn_musteriler
            // 
            btn_musteriler.Image = (Image)resources.GetObject("btn_musteriler.Image");
            btn_musteriler.ImageAlign = ContentAlignment.TopCenter;
            btn_musteriler.Location = new Point(187, 127);
            btn_musteriler.Name = "btn_musteriler";
            btn_musteriler.Padding = new Padding(0, 10, 0, 10);
            btn_musteriler.Size = new Size(126, 86);
            btn_musteriler.TabIndex = 3;
            btn_musteriler.Text = "Müşteriler";
            btn_musteriler.TextAlign = ContentAlignment.BottomCenter;
            btn_musteriler.UseVisualStyleBackColor = true;
            btn_musteriler.Click += btn_musteriler_Click;
            // 
            // btn_gunozeti
            // 
            btn_gunozeti.Image = (Image)resources.GetObject("btn_gunozeti.Image");
            btn_gunozeti.ImageAlign = ContentAlignment.TopCenter;
            btn_gunozeti.Location = new Point(187, 235);
            btn_gunozeti.Name = "btn_gunozeti";
            btn_gunozeti.Padding = new Padding(0, 10, 0, 10);
            btn_gunozeti.Size = new Size(126, 86);
            btn_gunozeti.TabIndex = 5;
            btn_gunozeti.Text = "Gün Özeti";
            btn_gunozeti.TextAlign = ContentAlignment.BottomCenter;
            btn_gunozeti.UseVisualStyleBackColor = true;
            btn_gunozeti.Click += btn_gunozeti_Click;
            // 
            // btn_gelirgider
            // 
            btn_gelirgider.Image = (Image)resources.GetObject("btn_gelirgider.Image");
            btn_gelirgider.ImageAlign = ContentAlignment.TopCenter;
            btn_gelirgider.Location = new Point(21, 235);
            btn_gelirgider.Name = "btn_gelirgider";
            btn_gelirgider.Padding = new Padding(0, 10, 0, 10);
            btn_gelirgider.Size = new Size(126, 86);
            btn_gelirgider.TabIndex = 4;
            btn_gelirgider.Text = "Gelir/Gider Ekle";
            btn_gelirgider.TextAlign = ContentAlignment.BottomCenter;
            btn_gelirgider.UseVisualStyleBackColor = true;
            btn_gelirgider.Click += btn_gelirgider_Click;
            // 
            // Ana_Ekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(334, 341);
            Controls.Add(btn_gunozeti);
            Controls.Add(btn_gelirgider);
            Controls.Add(btn_musteriler);
            Controls.Add(btn_teslim);
            Controls.Add(btn_yikamadalar);
            Controls.Add(btn_alinacaklar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Ana_Ekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            FormClosing += Ana_Ekran_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_alinacaklar;
        private Button btn_yikamadalar;
        private Button btn_teslim;
        private Button btn_musteriler;
        private Button btn_gunozeti;
        private Button btn_gelirgider;
    }
}