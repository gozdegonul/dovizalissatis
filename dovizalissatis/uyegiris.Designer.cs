namespace dovizalissatis
{
    partial class uyegiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyegiris));
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pBeye = new System.Windows.Forms.PictureBox();
            this.pBhidden = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBhidden)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(224, 65);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(235, 34);
            this.txtkullanici.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(224, 143);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(235, 34);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(62, 68);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(134, 28);
            this.lblkullanici.TabIndex = 2;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            this.lblkullanici.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(132, 159);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(64, 28);
            this.lblsifre.TabIndex = 3;
            this.lblsifre.Text = "Şifre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBhidden);
            this.groupBox1.Controls.Add(this.pBeye);
            this.groupBox1.Controls.Add(this.btngiris);
            this.groupBox1.Controls.Add(this.lblkullanici);
            this.groupBox1.Controls.Add(this.lblsifre);
            this.groupBox1.Controls.Add(this.txtkullanici);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Location = new System.Drawing.Point(53, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Giriş";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(222, 217);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(179, 38);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Üye değil misin ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(342, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 28);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hemen Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(-3, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 34);
            this.panel2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(408, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "© Copyright 2024 by DÖVİZİM. Tüm Hakları Saklıdır.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-9, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 63);
            this.panel1.TabIndex = 16;
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
            // pBeye
            // 
            this.pBeye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBeye.Image = ((System.Drawing.Image)(resources.GetObject("pBeye.Image")));
            this.pBeye.Location = new System.Drawing.Point(480, 143);
            this.pBeye.Name = "pBeye";
            this.pBeye.Size = new System.Drawing.Size(37, 34);
            this.pBeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBeye.TabIndex = 4;
            this.pBeye.TabStop = false;
            this.pBeye.Click += new System.EventHandler(this.pBeye_Click);
            // 
            // pBhidden
            // 
            this.pBhidden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBhidden.Image = ((System.Drawing.Image)(resources.GetObject("pBhidden.Image")));
            this.pBhidden.Location = new System.Drawing.Point(480, 143);
            this.pBhidden.Name = "pBhidden";
            this.pBhidden.Size = new System.Drawing.Size(37, 34);
            this.pBhidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBhidden.TabIndex = 5;
            this.pBhidden.TabStop = false;
            this.pBhidden.Click += new System.EventHandler(this.pBhidden_Click);
            // 
            // uyegiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uyegiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyegiris";
            this.Load += new System.EventHandler(this.uyegiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBhidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pBhidden;
        private System.Windows.Forms.PictureBox pBeye;
    }
}