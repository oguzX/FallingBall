using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class oyuncu
    {
        
        private int seviye = 0,
            can = 3,
            skor = 0,
            hiz = 0;
        int []seviyePuanlari = {0,2000,10000,30000,50000,70000,100000, 150000,190000,220000,250000 };
        public oyuncu()
        {
            
            seviye = 1;
        }
        public void canAzalt()
        {
            can--;
        }

        public int getCan()
        {
            return can;
        }

        public void skorArttir()
        {
            skor += (100 * seviye) + (hiz * 50);
            seviyeKontrol();
        }
        public void skorArttir(int sayi)
        {
            skor += 20000;
            seviyeKontrol();
        }

        public int getSkor()
        {
            return skor;
        }
        public void seviyeAtlat()
        {
            if (seviye + 1 < 10)
                seviye++;

        }

        public void setSeviye(int seviye)
        {
            this.seviye = seviye;
        }

        public int alSeviye()
        {
            return seviye;
        }
        private void seviyeKontrol()
        {
            int skor = this.getSkor();
            int seviye = this.alSeviye();
            if (skor > seviyePuanlari[seviye])
                seviyeAtlat();
            
        }
    }
}
