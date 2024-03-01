using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivedi_Yikama
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

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

        private void btn_musteriler_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            this.Hide();
            frm.Show();
        }

        private void btn_alinacaklar_Click(object sender, EventArgs e)
        {
            Alinacaklar_Listesi frm = new Alinacaklar_Listesi();
            this.Hide();
            frm.Show();
        }

        private void btn_yikamadalar_Click(object sender, EventArgs e)
        {
            Yikamadakiler_Listesi frm = new Yikamadakiler_Listesi();
            this.Hide();
            frm.Show();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            Teslim_Listesi frm = new Teslim_Listesi();
            this.Hide();
            frm.Show();
        }

        private void btn_gunozeti_Click(object sender, EventArgs e)
        {
            Gun_Ozeti frm = new Gun_Ozeti();
            this.Hide();
            frm.Show();
        }

        private void btn_gelirgider_Click(object sender, EventArgs e)
        {
            Gelir_Gider frm = new Gelir_Gider();
            this.Hide();
            frm.Show();
        }

        private void Ana_Ekran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
