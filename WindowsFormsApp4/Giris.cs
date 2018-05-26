using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private SoundPlayer ses;
        private string dizin;
        private bool ayarlarAcik = false;
        private Image topResmi = Properties.Resources.top1; //Kullanici secim yapmazsa default top resmi 1.top resmi
        private int seviye = 1; //Kullanici secim yapmazsa default seviye 1
        Form1 form1;
        public Form1()
        {
            InitializeComponent();
        }
        sesCal sescal = new sesCal(Application.StartupPath);
        private void Form1_Load(object sender, EventArgs e)
        {

            ses = new SoundPlayer();
            form1 = new Form1();
            dizin = Application.StartupPath + @"\sound\game.wav";
            play();
        }

        private void play()
        {
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!ayarlarAcik)
            {
                sescal.basarili();
                panelAyarlar.Visible = true;
                buttonOyunBaslat.Top = buttonOyunBaslat.Top - 60;
                panelAyarlar.Top = buttonOyunBaslat.Top + buttonOyunBaslat.Height + 10;
                buttonYuksekSkorlar.Top = panelAyarlar.Top + panelAyarlar.Height + 10;
                ayarlarAcik = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            form1.Close();
            this.Hide();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dizin = Application.StartupPath + @"\sound\start.wav";
            play();
            Skor frm2 = new Skor();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dizin = Application.StartupPath + @"\sound\game.wav";
            play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dizin = Application.StartupPath + @"\sound\game.wav";
            ses.SoundLocation = dizin;
            ses.Stop();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            dizin = Application.StartupPath + @"\sound\start.wav";
            play();
            Oyun frm2 = new Oyun(topResmi, seviye);
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
        
        //Seviye Buton Ayarlari
        private void seviye1_Click(object sender, EventArgs e) { seviyeSecim(seviye1, 1); sescal.basarili(); }
        private void seviye2_Click(object sender, EventArgs e) { seviyeSecim(seviye2, 2); sescal.basarili(); }
        private void seviye3_Click(object sender, EventArgs e) { seviyeSecim(seviye3, 3); sescal.basarili(); }
        private void seviye4_Click(object sender, EventArgs e) { seviyeSecim(seviye4, 4); sescal.basarili(); }
        private void seviye5_Click(object sender, EventArgs e) { seviyeSecim(seviye5, 5); sescal.basarili(); }
        private void seviye6_Click(object sender, EventArgs e) { seviyeSecim(seviye6, 6); sescal.basarili(); }
        private void seviye7_Click(object sender, EventArgs e) { seviyeSecim(seviye7, 7); sescal.basarili(); }
        private void seviye8_Click(object sender, EventArgs e) { seviyeSecim(seviye8, 8); sescal.basarili(); }
        private void seviye9_Click(object sender, EventArgs e) { seviyeSecim(seviye9, 9); sescal.basarili(); }
        private void seviye10_Click(object sender, EventArgs e) { seviyeSecim(seviye10, 10); sescal.basarili(); }

        //Top Resmi Buton Ayarlari
        private void top1_Click(object sender, EventArgs e){ topSecim(top1, Properties.Resources.top1); sescal.basarili(); }
        private void top2_Click(object sender, EventArgs e) { topSecim(top2, Properties.Resources.top2); sescal.basarili(); }
        private void top3_Click(object sender, EventArgs e) { topSecim(top3, Properties.Resources.top3); sescal.basarili(); }
        private void top4_Click(object sender, EventArgs e) { topSecim(top4, Properties.Resources.top4); sescal.basarili(); }
        private void top5_Click(object sender, EventArgs e) { topSecim(top5, Properties.Resources.top5); sescal.basarili(); }
        private void top6_Click(object sender, EventArgs e) { topSecim(top6, Properties.Resources.top6); sescal.basarili(); }

        private void seviyeSecim(Control c,int seviye)
        {
            foreach(Control ctr in panelSeviyeler.Controls)
            {
                ctr.BackColor = Color.Transparent;
            }
            c.BackColor = Color.Orange;
            this.seviye = seviye;
        }

        private void topSecim(Control c, Image resim)
        {
            foreach(Control ctr in panelToplar.Controls)
            {
                ctr.BackColor = Color.Transparent;
            }
            c.BackColor = Color.Orange;
            topResmi = resim;
        }

        
    }
}