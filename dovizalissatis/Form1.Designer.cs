namespace dovizalissatis
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pbdolar = new System.Windows.Forms.PictureBox();
            this.pbeuro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.gbdoviz = new System.Windows.Forms.GroupBox();
            this.lbldovizsatiskur = new System.Windows.Forms.Label();
            this.lbldovizaliskur = new System.Windows.Forms.Label();
            this.lbldovizsatis = new System.Windows.Forms.Label();
            this.lbldovizalis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbdolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            this.gbdoviz.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbdolar
            // 
            this.pbdolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbdolar.Image = ((System.Drawing.Image)(resources.GetObject("pbdolar.Image")));
            this.pbdolar.Location = new System.Drawing.Point(390, 281);
            this.pbdolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbdolar.Name = "pbdolar";
            this.pbdolar.Size = new System.Drawing.Size(102, 95);
            this.pbdolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdolar.TabIndex = 0;
            this.pbdolar.TabStop = false;
            this.pbdolar.Click += new System.EventHandler(this.pbdolar_Click);
            this.pbdolar.MouseEnter += new System.EventHandler(this.pbdolar_MouseEnter);
            this.pbdolar.MouseLeave += new System.EventHandler(this.pbdolar_MouseLeave);
            // 
            // pbeuro
            // 
            this.pbeuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbeuro.Image = ((System.Drawing.Image)(resources.GetObject("pbeuro.Image")));
            this.pbeuro.Location = new System.Drawing.Point(596, 281);
            this.pbeuro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbeuro.Name = "pbeuro";
            this.pbeuro.Size = new System.Drawing.Size(102, 95);
            this.pbeuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbeuro.TabIndex = 1;
            this.pbeuro.TabStop = false;
            this.pbeuro.Click += new System.EventHandler(this.pbeuro_Click);
            this.pbeuro.MouseEnter += new System.EventHandler(this.pbeuro_MouseEnter);
            this.pbeuro.MouseLeave += new System.EventHandler(this.pbeuro_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dövizim sayfası , döviz kurlarını takip etmenizi ve birikim hesabını takip etmeni" +
    "ze olanak tanır.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lütfen güncel döviz kurlarını görmek için seçim yapın.";
            // 
            // pbuser
            // 
            this.pbuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbuser.Image = ((System.Drawing.Image)(resources.GetObject("pbuser.Image")));
            this.pbuser.Location = new System.Drawing.Point(916, 6);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(62, 53);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbuser.TabIndex = 6;
            this.pbuser.TabStop = false;
            this.pbuser.Click += new System.EventHandler(this.pbuser_Click);
            // 
            // gbdoviz
            // 
            this.gbdoviz.Controls.Add(this.lbldovizsatiskur);
            this.gbdoviz.Controls.Add(this.lbldovizaliskur);
            this.gbdoviz.Controls.Add(this.lbldovizsatis);
            this.gbdoviz.Controls.Add(this.lbldovizalis);
            this.gbdoviz.Location = new System.Drawing.Point(117, 407);
            this.gbdoviz.Name = "gbdoviz";
            this.gbdoviz.Size = new System.Drawing.Size(817, 169);
            this.gbdoviz.TabIndex = 7;
            this.gbdoviz.TabStop = false;
            this.gbdoviz.Text = "Güncel Döviz Kur";
            // 
            // lbldovizsatiskur
            // 
            this.lbldovizsatiskur.AutoSize = true;
            this.lbldovizsatiskur.Location = new System.Drawing.Point(474, 107);
            this.lbldovizsatiskur.Name = "lbldovizsatiskur";
            this.lbldovizsatiskur.Size = new System.Drawing.Size(20, 28);
            this.lbldovizsatiskur.TabIndex = 3;
            this.lbldovizsatiskur.Text = "-";
            // 
            // lbldovizaliskur
            // 
            this.lbldovizaliskur.AutoSize = true;
            this.lbldovizaliskur.Location = new System.Drawing.Point(474, 60);
            this.lbldovizaliskur.Name = "lbldovizaliskur";
            this.lbldovizaliskur.Size = new System.Drawing.Size(20, 28);
            this.lbldovizaliskur.TabIndex = 2;
            this.lbldovizaliskur.Text = "-";
            // 
            // lbldovizsatis
            // 
            this.lbldovizsatis.AutoSize = true;
            this.lbldovizsatis.Location = new System.Drawing.Point(281, 107);
            this.lbldovizsatis.Name = "lbldovizsatis";
            this.lbldovizsatis.Size = new System.Drawing.Size(121, 28);
            this.lbldovizsatis.TabIndex = 1;
            this.lbldovizsatis.Text = "Döviz Satış :";
            // 
            // lbldovizalis
            // 
            this.lbldovizalis.AutoSize = true;
            this.lbldovizalis.Location = new System.Drawing.Point(291, 60);
            this.lbldovizalis.Name = "lbldovizalis";
            this.lbldovizalis.Size = new System.Drawing.Size(111, 28);
            this.lbldovizalis.TabIndex = 0;
            this.lbldovizalis.Text = "Döviz Alış :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pbuser);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 63);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(174, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dövizinizin tek adresi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dövizim";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(-7, 631);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 41);
            this.panel2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(408, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "© Copyright 2024 by DÖVİZİM. Tüm Hakları Saklıdır.";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(987, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbdoviz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbeuro);
            this.Controls.Add(this.pbdolar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbdolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            this.gbdoviz.ResumeLayout(false);
            this.gbdoviz.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdolar;
        private System.Windows.Forms.PictureBox pbeuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.GroupBox gbdoviz;
        private System.Windows.Forms.Label lbldovizsatiskur;
        private System.Windows.Forms.Label lbldovizaliskur;
        private System.Windows.Forms.Label lbldovizsatis;
        private System.Windows.Forms.Label lbldovizalis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

