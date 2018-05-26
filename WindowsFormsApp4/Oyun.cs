using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Oyun : Form
    {
        Timer timerGuncelleyen;
        int panelAraligi = 20,
            timeTutucu,
            can = 0,
            skor = 0;
        customPanel panelYonet;
        Top top;
        private Image topResmi;
        WMPLib.WindowsMediaPlayer bgSound;
        oyuncu oyuncu = new oyuncu();
        sesCal sescal = new sesCal(Application.StartupPath);
        sesCal sesefekt = new sesCal(Application.StartupPath);
        bool bittimi = false,
            sesAcikmi=true;
        //Test değişkenleri son
        public static int seviye = 1;
        
        public Oyun(Image _topResmi,int seviye)
        {
            InitializeComponent();
            itemKonumlandir();
            oyuncu.setSeviye(seviye);
            topResmi = _topResmi;
            timerGuncelleyen = new Timer();
            timerGuncelleyen.Interval = 100;
            timerGuncelleyen.Tick += new EventHandler(guncelle);
            panelYonet = new customPanel(anaPanel,seviye);
            timerGuncelleyen.Start();
            bgSound = new WMPLib.WindowsMediaPlayer();
            bgSound.URL = Application.StartupPath + @"\sound\bgSound.mp3";
            bgSound.settings.volume = 10;
        }

        private void itemKonumlandir()
        {
            int sagOrta = sagPanel.Width / 4;
            int sagPanelBoyu = 300;
            anaPanel.Width = this.Width- sagPanelBoyu;
            anaPanel.Height = this.Height;
            anaPanel.SizeMode = PictureBoxSizeMode.StretchImage;
            anaPanel.Dock = DockStyle.Left;
            anaPanel.Image = Properties.Resources.bg2;
            sagPanel.Width = sagPanelBoyu;
            sagPanel.Top = 0;
            sagPanel.Left = anaPanel.Width;
            sagPanel.Height = this.Height;
            labelSeviye.Width = sagPanel.Width;
            panelCanlar.Left = sagOrta;
            labelSeviye.Left = sagOrta-30;

            panelSkor.Left = 0;
            panelSkor.Width = lblSkorSt.Width = lblHizst.Width = panel2.Width = labelSkor.Width=labelHiz.Width = sagPanel.Width;
        }

        private void guncelle(object sender, EventArgs e)
        {
            if(oyuncu.getCan() > 0)
            {
                if (timeTutucu % panelAraligi == 0)
                {
                    panelEkle();
                }
                if(oyuncu.getCan() != can)
                {
                    picCanGuncelle();
                    can = oyuncu.getCan();
                    sescal.health();
                }
                if (oyuncu.getSkor() > skor)
                {
                    labelSkor.Text = oyuncu.getSkor().ToString();
                    skor = oyuncu.getSkor();
                    sescal.basarili();
                }
                if (oyuncu.alSeviye() != seviye)
                {
                    seviye = oyuncu.alSeviye();
                    labelSeviye.Text = "Seviye " + seviye.ToString()+".";
                    gorunum.gorunumDegistir(anaPanel, seviye);
                    sesefekt.cal();
                    panelYonet.panelDegistir(seviye);
                    int hiz = panelYonet.hiziArttir(oyuncu.alSeviye());
                    labelHiz.Text =  hiz.ToString();
                    if (seviye >= 3) panelAraligi = 10;
                }
                if (++timeTutucu % 100 == 0) timeTutucu = 0;

            }
            else//oyun bitti
            {
                if (!bittimi)
                {
                    bittimi = true;
                    oyunuBitir();
                }
            }       
        }

        private void oyunuBitir()
        {
            timerGuncelleyen.Stop();
            panelYonet.panelSifirla();
            oyuncu = null;
            top.Dispose();
            skorKaydet frm2 = new skorKaydet(skor);
            this.Hide();
            bgSound.controls.stop();
            frm2.ShowDialog();
            this.Close();
        }

        private void Oyun_Load(object sender, EventArgs e)
        {
            top = new Top(anaPanel,oyuncu,topResmi);
            bgSound.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            bgSound.controls.stop();
        }

        private void panelEkle()
        {
            customPanel yeniPanel = new customPanel(anaPanel,seviye);
            yeniPanel.panelDegistir(seviye);
            anaPanel.Controls.Add(yeniPanel);
        }

        private void kup(object sender, KeyEventArgs e)//tuşa basmayı kestiğinde çalışır
        {
            if (e.KeyValue == 68) panelYonet.sagKayMa();
            else if (e.KeyValue == 65) panelYonet.sagKayMa();
        }

        private void solaKay() { panelYonet.solKay(); }

        private void kpress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) solaKay();
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) sagKay();
            if (e.KeyCode == Keys.O) bgSustur();
            if (e.KeyCode == Keys.D9) oyuncu.skorArttir(1);
        }

        private void bgSustur()
        {
            if (sesAcikmi) { bgSound.controls.pause(); sesAcikmi = false; pbSes.Image = Properties.Resources.volumeOff; }
            else { bgSound.controls.play(); sesAcikmi = true; pbSes.Image = Properties.Resources.volumeOn; }
        }

        private void pictureBox1_Click(object sender, EventArgs e){bgSustur();}

        private void sagKay() { panelYonet.sagKay(); }
        private void picCanGuncelle()
        {
            panelCanlar.Controls.Clear();
            for (int i = 0; i < oyuncu.getCan(); i++)
            {
                PictureBox pictureHeart = new PictureBox();
                pictureHeart.Size = new System.Drawing.Size(50, 50);
                pictureHeart.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureHeart.Left = i * 55;
                pictureHeart.Image = Properties.Resources.heart;
                panelCanlar.Controls.Add(pictureHeart);
            }
        } // Can için kalpleri günceller
        ~Oyun()
        {
            bgSound.controls.stop();
        }
    }
}
