namespace WindowsFormsApp4
{
    partial class Skor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureHighScore = new System.Windows.Forms.PictureBox();
            this.yuksekSkorlar = new System.Windows.Forms.Panel();
            this.labelYuksekScore = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHighScore)).BeginInit();
            this.yuksekSkorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureHighScore);
            this.panel1.Controls.Add(this.yuksekSkorlar);
            this.panel1.Location = new System.Drawing.Point(253, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 134);
            this.panel1.TabIndex = 4;
            // 
            // pictureHighScore
            // 
            this.pictureHighScore.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.High_Score;
            this.pictureHighScore.Location = new System.Drawing.Point(29, 3);
            this.pictureHighScore.Name = "pictureHighScore";
            this.pictureHighScore.Size = new System.Drawing.Size(113, 27);
            this.pictureHighScore.TabIndex = 0;
            this.pictureHighScore.TabStop = false;
            // 
            // yuksekSkorlar
            // 
            this.yuksekSkorlar.Controls.Add(this.labelYuksekScore);
            this.yuksekSkorlar.ForeColor = System.Drawing.Color.Red;
            this.yuksekSkorlar.Location = new System.Drawing.Point(15, 39);
            this.yuksekSkorlar.Name = "yuksekSkorlar";
            this.yuksekSkorlar.Size = new System.Drawing.Size(182, 58);
            this.yuksekSkorlar.TabIndex = 4;
            // 
            // labelYuksekScore
            // 
            this.labelYuksekScore.AutoSize = true;
            this.labelYuksekScore.Font = new System.Drawing.Font("8BIT WONDER", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYuksekScore.Location = new System.Drawing.Point(40, 26);
            this.labelYuksekScore.Name = "labelYuksekScore";
            this.labelYuksekScore.Size = new System.Drawing.Size(0, 27);
            this.labelYuksekScore.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.X__1_;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1312, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 53);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Skor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Skor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Skor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHighScore)).EndInit();
            this.yuksekSkorlar.ResumeLayout(false);
            this.yuksekSkorlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel yuksekSkorlar;
        private System.Windows.Forms.PictureBox pictureHighScore;
        private System.Windows.Forms.Label labelYuksekScore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}