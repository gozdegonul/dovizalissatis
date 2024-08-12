using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dovizalissatis
{
    public partial class uyebilgi : Form
    {
        public uyebilgi()
        {
            InitializeComponent();
        }
        public string bilgi;
        SqlConnection baglanti = new SqlConnection(@"Data Source=Gozde_Huawei;Initial Catalog=dovizalissatis;Integrated Security=True");

        private void uyebilgi_Load(object sender, EventArgs e)
        {
            pBeye.Visible = false;
           
            dateTimePicker1.MaxDate = DateTime.Now;
            
            lblkullanicibilgi.Text = bilgi;

          

            txtkullanici.Text = lblkullanicibilgi.Text;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select Ad , Soyad , Sifre , Cinsiyet , Dogum , CepTel from doviz where KullaniciAd=@p1",baglanti);
            cmd.Parameters.AddWithValue("@p1", lblkullanicibilgi.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                
                txtad.Text = dr[0].ToString();
                txtsoyad.Text = dr[1].ToString();
                txtsifre.Text = dr[2].ToString();
                lblkızerkek.Text = dr[3].ToString();
                dateTimePicker1.Text = dr[4].ToString();
                maskedTextBox1.Text = dr[5].ToString();


                if (lblkızerkek.Text == "Erkek")
                {
                    rBerkek.Checked = true;
                }
                else if (lblkızerkek.Text == "Kadın")
                {
                    rBkadin.Checked = true;
                }

            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from doviz where KullaniciAd = @p1", baglanti);
            cmd2.Parameters.AddWithValue("@p1", lblkullanicibilgi.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.Read())
            {
                
                    lblkullanici.Text = dr2[0].ToString();
                    
                

               
                    txtsifre.Text = dr2[1].ToString();
                 


                    txtad.Text = dr2[2].ToString();
              
               
                    txtsoyad.Text = dr2[3].ToString();
                

               
                    lblcins.Text = dr2[4].ToString();
                 

                    dateTimePicker1.Text = dr2[5].ToString();
               

                
                    maskedTextBox1.Text = dr2[6].ToString();
                 
            }
            baglanti.Close();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnguncel.Enabled=false;
            txtad.Enabled = true;
            txtsoyad.Enabled = true;
            txtsifre.Enabled = true;
            rBerkek.Enabled = true;
            rBkadin .Enabled = true;
            maskedTextBox1 .Enabled = true;
            dateTimePicker1.Enabled = true;

           

        }

        private void rBkadin_CheckedChanged(object sender, EventArgs e)
        {
            lblcins.Text = rBkadin.Text;
        }

        private void rBerkek_CheckedChanged(object sender, EventArgs e)
        {
            lblcins.Text = rBerkek.Text;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update doviz SET Ad = @p1 , Soyad = @p2 , Sifre = @p3, Cinsiyet = @p4 , Dogum =@p5 , Ceptel =@p6 where KullaniciAd =  @p7", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p4", lblcins.Text);
            cmd.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p7", lblkullanicibilgi.Text);
            cmd.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Bilgileriniz Başarı ile Güncellenmiştir.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);


             btnkaydet.Enabled = false;
            btnguncel.Enabled = true;
            txtad.Enabled = false;
            txtsoyad.Enabled = false;
            txtsifre.Enabled = false;
            rBerkek.Enabled = false;
            rBkadin.Enabled = false;
            maskedTextBox1.Enabled = false;
            dateTimePicker1.Enabled = false;



            baglanti.Open();

          
            
            SqlCommand cmd2 = new SqlCommand("Select * from doviz where KullaniciAd = @p1", baglanti);
            cmd2.Parameters.AddWithValue("@p1", lblkullanicibilgi.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr2.Read())
            {
               
                    lblkullanici.Text = dr2[0].ToString();
                

                    txtsifre.Text = dr2[1].ToString();
                 

                

                    txtad.Text = dr2[2].ToString();
                

                
                    txtsoyad.Text = dr2[3].ToString();
                

                
                    lblcins.Text = dr2[4].ToString();
               
                    dateTimePicker1.Text = dr2[5].ToString();
                

               
                    maskedTextBox1.Text = dr2[6].ToString();
                 
            }
            baglanti.Close();

           
  

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           

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

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete * from doviz where KullaniciAd = @p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", lblkullanicibilgi.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Hesap başarı ile silinmiştir." , "Hesap Silindi" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
