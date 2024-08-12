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

namespace dovizalissatis
{
    public partial class uyegiris : Form
    {
        public uyegiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=dovizalissatis;Integrated Security=True");

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select KullaniciAd , Sifre from doviz where KullaniciAd = @p1 AND Sifre = @p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtkullanici.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtkullanici.Text = dr[0].ToString();
                txtsifre.Text = dr[1].ToString();

                MessageBox.Show("Giriş Başarılı." , "Başarılı Giriş",MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                uyesayfa us = new uyesayfa();
                us.kullan = txtkullanici.Text;  
                us.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Başarısız Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();

        



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            uyeol grs = new uyeol();
            grs.Show();
            this.Hide();
        }

        private void linkuye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alissatis ug = new alissatis();
            ug.Show();
            this.Hide();
        }

        private void uyegiris_Load(object sender, EventArgs e)
        {
           pBeye.Visible = false;
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
            pBeye.Visible=true;
            txtsifre.UseSystemPasswordChar = false;
        }
    }
}
