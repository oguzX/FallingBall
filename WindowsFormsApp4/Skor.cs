using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Skor : Form
    {
        public Skor()
        {
            InitializeComponent();
        }

        int adetLimiti = 10;
        WMPLib.WindowsMediaPlayer bgSound;
        private void Skor_Load(object sender, EventArgs e)
        {
            itemKonumlandir();
            using (StreamReader sr = new StreamReader("scores.txt")) {
                String line;
                String[] islenmis = new String[2];
                List<oyuncuKayit> oyuncular = new List<oyuncuKayit>();

                int sayac = 1;
                    while (sr.Peek() >= 0)
                {
                        line = sr.ReadLine();
                        islenmis = line.Split('*');
                        oyuncuKayit oyuncuClass = new oyuncuKayit();
                        oyuncuClass.ayarla(islenmis[0], Convert.ToInt32(islenmis[1]));
                        oyuncular.Add(oyuncuClass);
                    }
                for (int i = 0; i < oyuncular.Count; i++)
                {
                    for (int j = i; j < oyuncular.Count; j++)
                    {
                        if (oyuncular[i].alScore() < oyuncular[j].alScore())
                        {
                            oyuncuKayit temp;
                            temp = oyuncular[i];
                            oyuncular[i] = oyuncular[j];
                            oyuncular[j] = temp;
                        }
                    }
                }
                    foreach (oyuncuKayit row in oyuncular)
                        {
                            labelYuksekScore.Text += sayac++ +"." +row.alNick();
                             for (int i = 0; i < 70 - row.alNick().Length*6; i++) labelYuksekScore.Text += '.';
                             labelYuksekScore.Text += row.alScore()+"\n" ;
                    if (--adetLimiti <= 0) break;

                        }

                bgSound = new WMPLib.WindowsMediaPlayer();
                bgSound.URL = Application.StartupPath + @"\sound\skor.mp3";
            }
        }

        private void itemKonumlandir()
        {
            panel1.Width = this.Width / 2;
            panel1.Left = this.Width / 4;
            panel1.Height = 600;
            pictureHighScore.Width = panel1.Width;
            pictureHighScore.BackgroundImageLayout = ImageLayout.Stretch;
            pictureHighScore.Height = 104;
            pictureHighScore.Left = 0;
            yuksekSkorlar.Width = panel1.Width;
            yuksekSkorlar.Left = panel1.Width / 8;
            yuksekSkorlar.Top = pictureHighScore.Top + 120;
            yuksekSkorlar.Height = panel1.Height;
            labelYuksekScore.Left = 0;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            button2.Left = this.Width - button2.Width - 10;
            button2.Top = 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgSound.controls.stop();
            Form1 frm2 = new Form1();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
