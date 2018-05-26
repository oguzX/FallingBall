using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class skorKaydet : Form
    {
        int skor;
        public skorKaydet(int skor)
        {
            InitializeComponent();
            this.skor = skor;
            labelSkor.Text = skor.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            StreamWriter Dosya = File.AppendText("scores.txt");
            Dosya.Write(textBox1.Text+"*"+labelSkor.Text+"\n"); 
            Dosya.Close();
            Form1 giris = new Form1();
            this.Hide();
            giris.ShowDialog();
            this.Close();
        }

        private void skorKaydet_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width/2;
            panel1.Left = 2*(this.Width - panel1.Width) / 4;
            panel1.Top = (this.Height - panel1.Height) / 2;
            pbBg.Width = this.Width;
            pbBg.Height = this.Height;
            pbBg.Left =pbBg.Top= 0;
            panel1.Height = picGameOver.Height + panel2.Height + 20;
            panel2.Width = panel1.Width;
            panel2.Left = 0;
            panel2.Top = picGameOver.Height + 20;
            picGameOver.Width = 3*panel1.Width/4;
            picGameOver.Height = 65;
            picGameOver.Left = 3*panel1.Width / 16;
            pbKapat.Left = this.Width - pbKapat.Width - 10;
            pbKapat.Top = 10;
        }

        private void pbKapat_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            this.Hide();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
