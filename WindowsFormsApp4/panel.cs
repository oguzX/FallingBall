using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{   
    class customPanel : Label
    {
        static oyuncu oyuncuPanel;
        PictureBox eklenecekYer;
        static int[] panelKaydirmaHizlari = { 4, 5, 6, 7, 8, 9, 10, 11,12,13,14};
        Timer timerKaydir;
        Timer timerKontroller = new Timer();
        bool panelAktiflik = false;
        int panelYukseklik = 50,
            delikBoyu,
            hareketliYukseklik;//panelin hareket ettirilebilecek yüsekliği
        private static bool sol, sag; //sola veya saga kaydırma durumları
        Random rastgele = new Random();
        Panel delik; //Delikler Label sınıfının objelerinden oluşturuldu

        static private int panelKaymaHizi = 4;
        static private int panelType;
        static private Image bgImg, bgImgAktif;
        public customPanel(PictureBox _eklenecekYer, int seviye)
        {
            oyuncuPanel = new oyuncu();
            eklenecekYer = _eklenecekYer;
            if (panelType == 0) panelDegistir(seviye);
            this.BackgroundImage = bgImg;
            this.Width = eklenecekYer.Width;
            this.Height = panelYukseklik;
            this.Top = (eklenecekYer.Height) + 10;
            hareketliYukseklik = _eklenecekYer.Height / 2;
            delikBoyu = 300 / 2 * oyuncuPanel.alSeviye();
            delikOlustur();
            timerKaydir = new Timer();
            timerKaydir.Interval = panelKaymaHizi;
            timerKaydir.Tick += new EventHandler(fonkKay);
            timerKaydir.Start();
            timerKontroller.Interval = 24;
            timerKontroller.Tick += new EventHandler(kontroller);
            timerKontroller.Start();

        }

        private void kontroller(object sender, EventArgs e)
        {
            this.Top -= panelKaymaHizi;
            if (this.Top < hareketliYukseklik)
            {
                if (panelAktiflik == false)
                {
                    this.BackgroundImage = bgImgAktif;
                    panelAktiflik = true;
                }
            }
        }

        public void fonkKay(object sender, EventArgs e)
        {
            if (this.Top < -60)
                panelSil();
            if (sol == true && this.Top < hareketliYukseklik && delik.Left > 0)
            {
                delik.Left -= (panelKaymaHizi + 10);
            }
            else if (sag == true && this.Top < hareketliYukseklik && delik.Left<eklenecekYer.Width-delik.Width)
            {
                delik.Left += (panelKaymaHizi + 10);
            }
        }
        private void delikOlustur()
        {
            delik = new Panel();
            int solUzunluk = rastgele.Next(0, (this.Width - delikBoyu)); // Delik konumu
            delik.BackgroundImage = Properties.Resources.hole;
            delik.BackgroundImageLayout = ImageLayout.Stretch;
            delik.Left = solUzunluk;
            delik.Height = panelYukseklik;
            delik.Width = rastgele.Next(delikBoyu - 15, delikBoyu + 15);
            this.Controls.Add(delik);
        }
        private void panelSil()
        {
            eklenecekYer.Controls.Remove(this);
            timerKaydir.Stop();
            this.Dispose();
        }
        public void solKay() { sol = true; sag = false; }
        public void sagKay() { sag = true; sol = false; }
        public void solKayMa() { sol = false; sag = false; }
        public void sagKayMa() { sag = false; sol = false; }
        public int hiziArttir(int level) { panelKaymaHizi = panelKaydirmaHizlari[level]; return panelKaymaHizi; }
        public int getirHiz() { return panelKaymaHizi; }
        public static int getirKaymaHizi() { return panelKaymaHizi; }
        public void panelDegistir(int seviye)
        {
            panelType++;
            switch (seviye)
            {
                case 1: bgImg = Properties.Resources.dirt; bgImgAktif = Properties.Resources.dirtAktif; break;
                case 2: bgImg = Properties.Resources.Su; bgImgAktif = Properties.Resources.SuAktif; break;
                case 3: bgImg = Properties.Resources.ates; bgImgAktif = Properties.Resources.atesAktif; break;
                case 4: bgImg = Properties.Resources.color; bgImgAktif = Properties.Resources.colorAktif; break;
                case 5: bgImg = Properties.Resources.matrix; bgImgAktif = Properties.Resources.matrixAktif; break;
                case 6: bgImg = Properties.Resources.nebulagalaksi; bgImgAktif = Properties.Resources.nebulagalaksiAktif; break;
                case 7: bgImg = Properties.Resources.platformRed; bgImgAktif = Properties.Resources.redAktif; break;
                case 8: bgImg = Properties.Resources.rock; bgImgAktif = Properties.Resources.rockAktif; break;
                case 9: bgImg = Properties.Resources.pup; bgImgAktif = Properties.Resources.pupAktif; break;
                case 10: bgImg = Properties.Resources.altin; bgImgAktif = Properties.Resources.altinAktif; break;
                default:
                    bgImg = Properties.Resources.altin;
                    break;
            }
        }

        public void panelSifirla()
        {
            panelType = 0;
        }
    }
   
}
