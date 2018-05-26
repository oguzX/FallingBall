using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class oyuncuKayit
    {
        private string nick;
        private int score;
        public oyuncuKayit()
        {

        }
        public void ayarla(string nick, int score)
        {
            this.nick = nick;
            this.score = score;
        }
        public string alNick() { return nick; }
        public int alScore() { return score; }
    }
}
