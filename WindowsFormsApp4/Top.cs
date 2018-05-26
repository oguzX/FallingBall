using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace WindowsFormsApp4
{
    class Top : PictureBox
    {
        private PictureBox eklenecegiYer = new PictureBox();
        private Timer kontrolcu = new Timer();
        private static oyuncu oyuncu;
        private int kaydirmaHizi;
        public Top(PictureBox _eklenecegiYer, oyuncu _oyuncu,Image topResmi)
        {
            this.Image = topResmi;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Width = 50;
            this.Top = _eklenecegiYer.Top + this.Height * 2;
            this.Left = _eklenecegiYer.Right / 2 - this.Width / 2;

            eklenecegiYer = _eklenecegiYer;
            oyuncu = _oyuncu;
            
            eklenecegiYer.Controls.Add(this);
            kontrolcu.Interval = 1;
            kontrolcu.Tick += new EventHandler(cubukKontrol);
            kontrolcu.Start();
        }
        protected override void OnResize(EventArgs e)   //Topu yuvarlak yapmak icin
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

        private bool deliktenGecermi(Control c)
        {
            if (this.Left >= c.Controls[0].Left && this.Right <= c.Controls[0].Right)   
            {
                return true;
            }
            else
                return false;
        }


        private void cubukKontrol(object sender, EventArgs e)
        {
            foreach (Control c in eklenecegiYer.Controls)
            {
                if (c is customPanel && eklenecegiYer.Controls.IndexOf(c) == 1)    //0 topun indexi 1 en ust cubugun indexi
                {

                    if (c.Top < this.Bottom && !deliktenGecermi(c))  //Top cubuga degerse ve delikten gecmiyorsa 
                    {
                        kaydirmaHizi = customPanel.getirKaymaHizi();
                        this.Top -= kaydirmaHizi;   //Topu cubukla beraber yukariya tasi
              
                    }
                    else if (this.Top <= 0)
                    {
                        eklenecegiYer.Controls.SetChildIndex(c, 20);    //Topu en yukariya tasiyan cubugun indexini 20 yapiyorum ki alttan gelen yeni cubugun indexi 1 olsun
                        oyuncu.canAzalt();    //1 can azalt
                                              //TOPU ESKI KONUMUNA GETIR
                        this.Left = eklenecegiYer.Right / 2 - this.Width / 2;
                        this.Top = eklenecegiYer.Top + this.Height * 2 + 100;

                    }
                    else if (this.Top > c.Bottom)
                    {
                        eklenecegiYer.Controls.SetChildIndex(c, 20);
                        oyuncu.skorArttir();

                        //Top birinci cubugu gectikten sonra geciline cubugun indexini 20 yapiyorum ki alttan gelen cubugun indexi 1 olsun.
                        //20 yapilmasi onemli degil zaten 2-3 saniye sonra nesne yok edilecek ve panelden kaldirilacak.
                    }
                    break;
                }
            }
        }


    }
}

