namespace WindowsFormsApp4
{
    partial class skorKaydet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skorKaydet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSkor = new System.Windows.Forms.Label();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.pbBg = new System.Windows.Forms.PictureBox();
            this.pbKapat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picGameOver);
            this.panel1.Location = new System.Drawing.Point(95, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 365);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelSkor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 227);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(138, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(259, 136);
            this.label4.MinimumSize = new System.Drawing.Size(200, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kaydet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("8BIT WONDER", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 39);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 50);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSkor.Location = new System.Drawing.Point(327, 92);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(120, 27);
            this.labelSkor.TabIndex = 3;
            this.labelSkor.Text = "Skor";
            // 
            // picGameOver
            // 
            this.picGameOver.Image = ((System.Drawing.Image)(resources.GetObject("picGameOver.Image")));
            this.picGameOver.Location = new System.Drawing.Point(59, 22);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(488, 79);
            this.picGameOver.TabIndex = 5;
            this.picGameOver.TabStop = false;
            // 
            // pbBg
            // 
            this.pbBg.Image = ((System.Drawing.Image)(resources.GetObject("pbBg.Image")));
            this.pbBg.Location = new System.Drawing.Point(1, 0);
            this.pbBg.Name = "pbBg";
            this.pbBg.Size = new System.Drawing.Size(766, 425);
            this.pbBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBg.TabIndex = 1;
            this.pbBg.TabStop = false;
            // 
            // pbKapat
            // 
            this.pbKapat.BackColor = System.Drawing.Color.Black;
            this.pbKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbKapat.Image = global::WindowsFormsApp4.Properties.Resources.X__1_;
            this.pbKapat.Location = new System.Drawing.Point(711, 12);
            this.pbKapat.Name = "pbKapat";
            this.pbKapat.Size = new System.Drawing.Size(43, 50);
            this.pbKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKapat.TabIndex = 2;
            this.pbKapat.TabStop = false;
            this.pbKapat.Click += new System.EventHandler(this.pbKapat_Click);
            // 
            // skorKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbKapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "skorKaydet";
            this.Text = "skorKaydet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.skorKaydet_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbBg;
        private System.Windows.Forms.PictureBox pbKapat;
    }
}