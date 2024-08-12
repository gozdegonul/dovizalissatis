using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dovizalissatis
{
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Gozde_Huawei;Initial Catalog=dovizalissatis;Integrated Security=True");

        private void btnkayit_Click(object sender, EventArgs e)
        {

            if(txtad.Text == string.Empty)
            {
                MessageBox.Show("Ad kısmı boş olamaz lütfen adınızı girin.", "Uyarı" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
                return;
            }
            if (txtsoyad.Text == string.Empty)
            {
                MessageBox.Show("Soyad kısmı boş olamaz lütfen soyadınızı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoyad.Focus();
                return;
            }
            if (txtkullanici.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adı kısmı boş olamaz lütfen kullanıcı adınızı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkullanici.Focus();
                return;
            }
            if (txtsifre.Text == string.Empty)
            {
                MessageBox.Show("Şifre kısmı boş olamaz lütfen şifrenizi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsifre.Focus();
                return;
            }
           


            baglanti.Open();
            SqlCommand kg = new SqlCommand("Select KullaniciAd from doviz where KullaniciAd='" + txtkullanici.Text + "'", baglanti);
            SqlDataReader ka = kg.ExecuteReader();
            if (ka.Read())
            {
                MessageBox.Show("Kullanıcı adınız başka bir kullanıcı ile aynı \n Lütfen kullanıcı adınızı değiştirin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkullanici.Text = string.Empty;
                txtkullanici.Focus();
                ka.Close();
                baglanti.Close();
                return;
            }
            baglanti.Close();



            baglanti.Open();

            
            if(lblcins.Text == "lblcins")
            {
                lblcins.Text = null;
            }

            SqlCommand kyt = new SqlCommand("insert into doviz (KullaniciAd , Ad , Soyad , Sifre , Cinsiyet , Dogum , CepTel) values (@p1,@p2,@p3,@p4 , @p5 , @p6,@p7)", baglanti);
            kyt.Parameters.AddWithValue("@p1", txtkullanici.Text);
            kyt.Parameters.AddWithValue("@p2", txtad.Text);
            kyt.Parameters.AddWithValue("@p3", txtsoyad.Text);
            kyt.Parameters.AddWithValue("@p4", txtsifre.Text);
            kyt.Parameters.AddWithValue("@p5", lblcins.Text);
            kyt.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
            kyt.Parameters.AddWithValue("@p7", maskedTextBox1.Text);

            kyt.ExecuteNonQuery();
            baglanti.Close();





            MessageBox.Show("Başarı ile kayıt oldunuz" , "Başarılı Kayıt İşlemi" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information);

            uyegiris ug = new uyegiris();
            ug.Show();
            this.Hide();

        }

        private void rBkadin_CheckedChanged(object sender, EventArgs e)
        {
            lblcins.Text = rBkadin.Text;
        }

        private void rBerkek_CheckedChanged(object sender, EventArgs e)
        {
            lblcins.Text = rBerkek.Text;
        }

        private void linkuye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alissatis ug = new alissatis(); 
            ug.Show();
            this.Hide();
            
        }

        private void uyeol_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            uyegiris ug = new uyegiris();
            ug.Show();
            this.Hide();
        }

        private void pBeye_Click(object sender, EventArgs e)
        {
            pBhidden.Visible = true;
            pBeye.Visible = false;
            txtsifre.UseSystemPasswordChar = true;
        }

        private void pBhidden_Click(object sender, EventArgs e)
        {
            pBhidden.Visible = false;
            pBeye.Visible = true;
            txtsifre.UseSystemPasswordChar = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
