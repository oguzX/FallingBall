using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class sesCal
    {
        WMPLib.WindowsMediaPlayer bgSound;
        private string yol = "";
        Random rnd = new Random();
        int SesIndex;
        string asilYol;
        string[] sesler =  { "kanal1.mp3",
                              "kanal2.mp3",
                            "kanal3.mp3",
                            "kanal4.mp3",
                            "kanal5.mp3",
                            "kanal6.mp3",
                            "kanal7.mp3",
                            "ucurum1.mp3",
                            "ucurum2.mp3",
                            "genelkurmay.mp3",
                            "nani.mp3",
                            "sabri.mp3",
                            "sabri1.mp3",
                            "sabri2.mp3",
                            "sabri3.mp3",
                            "imki.mp3",
                            "teyze.mp3"
                };
        public sesCal(string yol)
        {
            this.yol = yol+ @"\sound\sesler\";
            bgSound = new WMPLib.WindowsMediaPlayer();
        }
        public void cal()
        {
            SesIndex= rnd.Next(0, sesler.Length-1); 
            asilYol = this.yol + sesler[SesIndex];
            caliniyor();
        }
        public void fail()
        {
            asilYol = this.yol + "fail.mp3";
            caliniyor();
        }
        public string basarili()
        {
            asilYol = this.yol + "beep.mp3";
            caliniyor();
            return asilYol;
        }
        public void health()
        {
            asilYol = this.yol + "health.mp3";
            caliniyor();
        }
        private void caliniyor()
        {
            bgSound.URL = asilYol;
            bgSound.controls.play();
        }
        public void duraklat()
        {
            bgSound.controls.pause();
        }
        public void devamet()
        {
            bgSound.controls.play();
        }
    }
}
