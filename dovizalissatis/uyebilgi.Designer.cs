namespace dovizalissatis
{
    partial class uyebilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyebilgi));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblcins = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rBerkek = new System.Windows.Forms.RadioButton();
            this.rBkadin = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldogum = new System.Windows.Forms.Label();
            this.lblmeslek = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBeye = new System.Windows.Forms.PictureBox();
            this.pBhidden = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.lblkullanicibilgi = new System.Windows.Forms.Label();
            this.lblkızerkek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBhidden)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblcins);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.rBerkek);
            this.groupBox3.Controls.Add(this.rBkadin);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.lbldogum);
            this.groupBox3.Controls.Add(this.lblmeslek);
            this.groupBox3.Controls.Add(this.lblcinsiyet);
            this.groupBox3.Location = new System.Drawing.Point(61, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(708, 215);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ek Kullanıcı İşlemleri";
            // 
            // lblcins
            // 
            this.lblcins.AutoSize = true;
            this.lblcins.Enabled = false;
            this.lblcins.Location = new System.Drawing.Point(503, 53);
            this.lblcins.Name = "lblcins";
            this.lblcins.Size = new System.Drawing.Size(69, 28);
            this.lblcins.TabIndex = 8;
            this.lblcins.Text = "lblcins";
            this.lblcins.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(254, 152);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(242, 34);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // rBerkek
            // 
            this.rBerkek.AutoSize = true;
            this.rBerkek.Enabled = false;
            this.rBerkek.Location = new System.Drawing.Point(397, 51);
            this.rBerkek.Name = "rBerkek";
            this.rBerkek.Size = new System.Drawing.Size(83, 32);
            this.rBerkek.TabIndex = 5;
            this.rBerkek.TabStop = true;
            this.rBerkek.Text = "Erkek";
            this.rBerkek.UseVisualStyleBackColor = true;
            this.rBerkek.CheckedChanged += new System.EventHandler(this.rBerkek_CheckedChanged);
            // 
            // rBkadin
            // 
            this.rBkadin.AutoSize = true;
            this.rBkadin.Enabled = false;
            this.rBkadin.Location = new System.Drawing.Point(254, 51);
            this.rBkadin.Name = "rBkadin";
            this.rBkadin.Size = new System.Drawing.Size(84, 32);
            this.rBkadin.TabIndex = 4;
            this.rBkadin.TabStop = true;
            this.rBkadin.Text = "Kadın";
            this.rBkadin.UseVisualStyleBackColor = true;
            this.rBkadin.CheckedChanged += new System.EventHandler(this.rBkadin_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 101);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 7, 8, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 34);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 8, 0, 0, 0, 0);
            // 
            // lbldogum
            // 
            this.lbldogum.AutoSize = true;
            this.lbldogum.Enabled = false;
            this.lbldogum.Location = new System.Drawing.Point(82, 101);
            this.lbldogum.Name = "lbldogum";
            this.lbldogum.Size = new System.Drawing.Size(145, 28);
            this.lbldogum.TabIndex = 2;
            this.lbldogum.Text = "Doğum Tarihi :";
            // 
            // lblmeslek
            // 
            this.lblmeslek.AutoSize = true;
            this.lblmeslek.Enabled = false;
            this.lblmeslek.Location = new System.Drawing.Point(82, 152);
            this.lblmeslek.Name = "lblmeslek";
            this.lblmeslek.Size = new System.Drawing.Size(143, 28);
            this.lblmeslek.TabIndex = 1;
            this.lblmeslek.Text = "Cep Telefonu :";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Enabled = false;
            this.lblcinsiyet.Location = new System.Drawing.Point(127, 55);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(100, 28);
            this.lblcinsiyet.TabIndex = 0;
            this.lblcinsiyet.Text = "Cinsiyet : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBeye);
            this.groupBox2.Controls.Add(this.pBhidden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblkullanici);
            this.groupBox2.Controls.Add(this.txtsifre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtkullanici);
            this.groupBox2.Controls.Add(this.txtsoyad);
            this.groupBox2.Controls.Add(this.lblsoyad);
            this.groupBox2.Controls.Add(this.lblad);
            this.groupBox2.Controls.Add(this.txtad);
            this.groupBox2.Location = new System.Drawing.Point(61, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 213);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // pBeye
            // 
            this.pBeye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBeye.Image = ((System.Drawing.Image)(resources.GetObject("pBeye.Image")));
            this.pBeye.Location = new System.Drawing.Point(665, 133);
            this.pBeye.Name = "pBeye";
            this.pBeye.Size = new System.Drawing.Size(37, 34);
            this.pBeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBeye.TabIndex = 20;
            this.pBeye.TabStop = false;
            this.pBeye.Click += new System.EventHandler(this.pBeye_Click);
            // 
            // pBhidden
            // 
            this.pBhidden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBhidden.Image = ((System.Drawing.Image)(resources.GetObject("pBhidden.Image")));
            this.pBhidden.Location = new System.Drawing.Point(665, 133);
            this.pBhidden.Name = "pBhidden";
            this.pBhidden.Size = new System.Drawing.Size(37, 34);
            this.pBhidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBhidden.TabIndex = 20;
            this.pBhidden.TabStop = false;
            this.pBhidden.Click += new System.EventHandler(this.pBhidden_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(463, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(460, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(162, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(162, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Enabled = false;
            this.lblkullanici.Location = new System.Drawing.Point(29, 133);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(134, 28);
            this.lblkullanici.TabIndex = 4;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // txtsifre
            // 
            this.txtsifre.Enabled = false;
            this.txtsifre.Location = new System.Drawing.Point(485, 133);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(167, 34);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(394, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre :";
            // 
            // txtkullanici
            // 
            this.txtkullanici.Enabled = false;
            this.txtkullanici.Location = new System.Drawing.Point(198, 133);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(167, 34);
            this.txtkullanici.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Enabled = false;
            this.txtsoyad.Location = new System.Drawing.Point(485, 70);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(167, 34);
            this.txtsoyad.TabIndex = 1;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Enabled = false;
            this.lblsoyad.Location = new System.Drawing.Point(387, 70);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(78, 28);
            this.lblsoyad.TabIndex = 6;
            this.lblsoyad.Text = "Soyad :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Enabled = false;
            this.lblad.Location = new System.Drawing.Point(116, 64);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(48, 28);
            this.lblad.TabIndex = 5;
            this.lblad.Text = "Ad :";
            // 
            // txtad
            // 
            this.txtad.Enabled = false;
            this.txtad.Location = new System.Drawing.Point(198, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(167, 34);
            this.txtad.TabIndex = 0;
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(111, 579);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(184, 39);
            this.btnguncel.TabIndex = 8;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(332, 579);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(184, 39);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(546, 579);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(184, 39);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Hesabı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // lblkullanicibilgi
            // 
            this.lblkullanicibilgi.AutoSize = true;
            this.lblkullanicibilgi.Location = new System.Drawing.Point(794, 26);
            this.lblkullanicibilgi.Name = "lblkullanicibilgi";
            this.lblkullanicibilgi.Size = new System.Drawing.Size(66, 28);
            this.lblkullanicibilgi.TabIndex = 18;
            this.lblkullanicibilgi.Text = "label8";
            this.lblkullanicibilgi.Visible = false;
            // 
            // lblkızerkek
            // 
            this.lblkızerkek.AutoSize = true;
            this.lblkızerkek.Location = new System.Drawing.Point(794, 54);
            this.lblkızerkek.Name = "lblkızerkek";
            this.lblkızerkek.Size = new System.Drawing.Size(66, 28);
            this.lblkızerkek.TabIndex = 19;
            this.lblkızerkek.Text = "label8";
            this.lblkızerkek.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kişisel Bilgilerim";
            // 
            // uyebilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(893, 652);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblkızerkek);
            this.Controls.Add(this.lblkullanicibilgi);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uyebilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyebilgi";
            this.Load += new System.EventHandler(this.uyebilgi_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBhidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblcins;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton rBerkek;
        private System.Windows.Forms.RadioButton rBkadin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbldogum;
        private System.Windows.Forms.Label lblmeslek;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lblkullanicibilgi;
        private System.Windows.Forms.Label lblkızerkek;
        private System.Windows.Forms.PictureBox pBhidden;
        private System.Windows.Forms.PictureBox pBeye;
        private System.Windows.Forms.Label label6;
    }
}