using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Drawing;

namespace WindowsFormsApp4
{
    
    class gorunum
    {

        public static void gorunumDegistir(PictureBox anaPanel ,int seviye)
        {
            switch (seviye)
            {
                case 2: { anaPanel.Image = Properties.Resources._2; break; }
                case 3: { anaPanel.Image = Properties.Resources._3; break; }
                case 4: { anaPanel.Image = Properties.Resources._4; break; }
                case 5: { anaPanel.Image = Properties.Resources._5; break; }
                case 6: { anaPanel.Image = Properties.Resources._6; break; }
                case 7: { anaPanel.Image = Properties.Resources._7; break; }
                case 8: { anaPanel.Image = Properties.Resources._8; break; }
                case 9: { anaPanel.Image = Properties.Resources._9; break; }
                case 10: { anaPanel.Image = Properties.Resources._10; break; }
            }
        }

    }
}
