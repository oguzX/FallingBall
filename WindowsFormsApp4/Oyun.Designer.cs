namespace WindowsFormsApp4
{
    partial class Oyun
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
            this.sagPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSes = new System.Windows.Forms.PictureBox();
            this.panelSkor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHizst = new System.Windows.Forms.Label();
            this.labelHiz = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSkorSt = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.labelSeviye = new System.Windows.Forms.Label();
            this.panelCanlar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.anaPanel = new System.Windows.Forms.PictureBox();
            this.sagPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSes)).BeginInit();
            this.panelSkor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // sagPanel
            // 
            this.sagPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sagPanel.Controls.Add(this.panel1);
            this.sagPanel.Controls.Add(this.panelSkor);
            this.sagPanel.Controls.Add(this.panelCanlar);
            this.sagPanel.Controls.Add(this.button2);
            this.sagPanel.Location = new System.Drawing.Point(998, 12);
            this.sagPanel.Name = "sagPanel";
            this.sagPanel.Size = new System.Drawing.Size(311, 557);
            this.sagPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbSes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 56);
            this.panel1.TabIndex = 5;
            // 
            // pbSes
            // 
            this.pbSes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSes.Image = global::WindowsFormsApp4.Properties.Resources.volumeOn;
            this.pbSes.Location = new System.Drawing.Point(0, 0);
            this.pbSes.Name = "pbSes";
            this.pbSes.Size = new System.Drawing.Size(66, 56);
            this.pbSes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSes.TabIndex = 0;
            this.pbSes.TabStop = false;
            this.pbSes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSkor
            // 
            this.panelSkor.Controls.Add(this.panel3);
            this.panelSkor.Controls.Add(this.panel2);
            this.panelSkor.Controls.Add(this.labelSeviye);
            this.panelSkor.Location = new System.Drawing.Point(48, 140);
            this.panelSkor.Name = "panelSkor";
            this.panelSkor.Size = new System.Drawing.Size(194, 315);
            this.panelSkor.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblHizst);
            this.panel3.Controls.Add(this.labelHiz);
            this.panel3.Location = new System.Drawing.Point(15, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 50);
            this.panel3.TabIndex = 4;
            // 
            // lblHizst
            // 
            this.lblHizst.AutoSize = true;
            this.lblHizst.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHizst.ForeColor = System.Drawing.Color.Crimson;
            this.lblHizst.Location = new System.Drawing.Point(60, 7);
            this.lblHizst.Name = "lblHizst";
            this.lblHizst.Size = new System.Drawing.Size(40, 13);
            this.lblHizst.TabIndex = 3;
            this.lblHizst.Text = "HIZ";
            this.lblHizst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHiz
            // 
            this.labelHiz.AutoSize = true;
            this.labelHiz.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHiz.ForeColor = System.Drawing.Color.Crimson;
            this.labelHiz.Location = new System.Drawing.Point(67, 27);
            this.labelHiz.Name = "labelHiz";
            this.labelHiz.Size = new System.Drawing.Size(28, 19);
            this.labelHiz.TabIndex = 2;
            this.labelHiz.Text = "4";
            this.labelHiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSkorSt);
            this.panel2.Controls.Add(this.labelSkor);
            this.panel2.Location = new System.Drawing.Point(15, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 50);
            this.panel2.TabIndex = 3;
            // 
            // lblSkorSt
            // 
            this.lblSkorSt.AutoSize = true;
            this.lblSkorSt.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkorSt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSkorSt.Location = new System.Drawing.Point(49, 0);
            this.lblSkorSt.Name = "lblSkorSt";
            this.lblSkorSt.Size = new System.Drawing.Size(59, 13);
            this.lblSkorSt.TabIndex = 1;
            this.lblSkorSt.Text = "Puan";
            this.lblSkorSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelSkor.Location = new System.Drawing.Point(65, 13);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(28, 19);
            this.labelSkor.TabIndex = 0;
            this.labelSkor.Text = "0";
            this.labelSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSeviye
            // 
            this.labelSeviye.AutoSize = true;
            this.labelSeviye.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeviye.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelSeviye.Location = new System.Drawing.Point(37, 19);
            this.labelSeviye.Name = "labelSeviye";
            this.labelSeviye.Size = new System.Drawing.Size(134, 19);
            this.labelSeviye.TabIndex = 1;
            this.labelSeviye.Text = "Seviye 1";
            this.labelSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCanlar
            // 
            this.panelCanlar.Location = new System.Drawing.Point(24, 59);
            this.panelCanlar.Name = "panelCanlar";
            this.panelCanlar.Size = new System.Drawing.Size(206, 51);
            this.panelCanlar.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.X__1_;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(215, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 53);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // anaPanel
            // 
            this.anaPanel.Location = new System.Drawing.Point(0, 0);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(100, 50);
            this.anaPanel.TabIndex = 3;
            this.anaPanel.TabStop = false;
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 768);
            this.Controls.Add(this.sagPanel);
            this.Controls.Add(this.anaPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Oyun";
            this.Text = "Oyun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Oyun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kpress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kup);
            this.sagPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSes)).EndInit();
            this.panelSkor.ResumeLayout(false);
            this.panelSkor.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox anaPanel;
        private System.Windows.Forms.Panel sagPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelCanlar;
        private System.Windows.Forms.Panel panelSkor;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label labelSeviye;
        private System.Windows.Forms.Label labelHiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHizst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSkorSt;
    }
}