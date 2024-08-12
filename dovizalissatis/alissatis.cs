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
using System.Xml;

namespace dovizalissatis
{
    public partial class alissatis : Form
    {
        public alissatis()
        {
            InitializeComponent();
        }

        public string kullaniciad;
        SqlConnection baglanti = new SqlConnection(@"Data Source=Gozde_Huawei;Initial Catalog=dovizalissatis;Integrated Security=True");
        private void pbdolar_Click(object sender, EventArgs e)
        {


        }



        private void pbdolar_Click_1(object sender, EventArgs e)
        {
            btndoviz.Enabled = false;
            btnmiktar.Enabled = false;
            btnhesapla.Enabled = false;
            btnAl.Enabled = false;
            btnalis.Enabled = true;
            btnsatis.Enabled = true;
            txtdovizpara.Enabled = false;
            txtdovizpara.Text = "0 $";
            txtkalan.Text = string.Empty;
            txtsonuc.Text = string.Empty;
            txtkalan.Enabled = false;
            txtsonuc.Enabled = false;



            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmlDoc = new XmlDocument();

            // Load the XML from the URL
            xmlDoc.Load(url);

            // Select the nodes for USD and EUR
            XmlNode usdNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='USD']");


            // Extract the buy and sell rates for USD
            string usdBuyRate = usdNode.SelectSingleNode("BanknoteBuying").InnerText;
            lbldovizsatiskur.Text = usdBuyRate;
            string usdSellRate = usdNode.SelectSingleNode("BanknoteSelling").InnerText;
            lbldovizaliskur.Text = usdSellRate;


            gbdoviz.Text = "Güncel Dolar İşlemleri";
            lbldovizalis.Text = "Dolar Alış :";
            lbldovizsatis.Text = "Dolar Satış :";

        }

        private void pbeuro_Click(object sender, EventArgs e)
        {


            btndoviz.Enabled = false;
            btnmiktar.Enabled = false;
            btnhesapla.Enabled = false;
            btnAl.Enabled = false;
            btnalis.Enabled = true;
            btnsatis.Enabled = true;
            txtdovizpara.Enabled = false;
            txtdovizpara.Text = "0 €";
            txtkalan.Text = string.Empty;
            txtsonuc.Text = string.Empty;
            txtkalan.Enabled = false;
            txtsonuc.Enabled = false;

            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(url);

            XmlNode eurNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='EUR']");



            string eurBuyRate = eurNode.SelectSingleNode("BanknoteBuying").InnerText;
            lbldovizsatiskur.Text = eurBuyRate;
            string eurSellRate = eurNode.SelectSingleNode("BanknoteSelling").InnerText;
            lbldovizaliskur.Text = eurSellRate;

            gbdoviz.Text = "Güncel Euro İşlemleri";
            lbldovizalis.Text = "Euro Alış :";
            lbldovizsatis.Text = "Euro Satış :";


        }

        private void pbdolar_MouseEnter(object sender, EventArgs e)
        {
            pbdolar.BackColor = SystemColors.ControlLight;
        }

        private void pbeuro_MouseEnter(object sender, EventArgs e)
        {
            pbeuro.BackColor = SystemColors.ControlLight;
        }

        private void pbdolar_MouseLeave(object sender, EventArgs e)
        {
            pbdolar.BackColor = SystemColors.Window;

        }

        private void pbeuro_MouseLeave(object sender, EventArgs e)
        {
            pbeuro.BackColor = SystemColors.Window;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdovizpara.Enabled = true;

            gbislem.Text = "Döviz Miktarı ile";
            lblkalan.Visible = false;
            txtkalan.Visible = false;

            if (lbldovizalis.Text.Contains("Euro"))
            {
                txtdovizpara.Text = "0 €";
            }
            else if (lbldovizalis.Text.Contains("Dolar"))
            {
                txtdovizpara.Text = "0 $";
            }

            txtsonuc.Text = string.Empty;
        }
        private void btnmiktar_Click(object sender, EventArgs e)
        {
            txtdovizpara.Enabled = true;
            lblkalan.Visible = true;
            txtkalan.Visible = true;
            gbislem.Text = "Para Miktarı ile";

            txtdovizpara.Text = "0 TL";

            txtsonuc.Text = string.Empty;
        }


        private void btnhesapla_Click(object sender, EventArgs e)
        {
            txtdovizpara.Enabled = true;
            btnAl.Enabled = true;

            if (gbdoviz.Text == "Güncel Alış İşlemleri")
            {
                if (gbislem.Text == "Döviz Miktarı ile")
                {

                    txtkalan.Visible = false;
                    if (lbldovizalis.Text.Contains("Euro"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("€", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));
                        double dovizsonuc = dovizmiktar * dovizalis;
                        txtsonuc.Text = dovizsonuc.ToString() + " TL";

                    }
                    else if (lbldovizalis.Text.Contains("Dolar"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("$", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));
                        double dovizsonuc = dovizmiktar * dovizalis;
                        txtsonuc.Text = dovizsonuc.ToString() + " TL";
                    }


                }

                if (gbislem.Text == "Para Miktarı ile")
                {
                    if (lbldovizalis.Text.Contains("Euro"))
                    {
                        double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));
                        double dovizmiktar = para / dovizalis;


                        int sonuc = (int)Math.Floor(dovizmiktar);
                        txtsonuc.Text = sonuc.ToString();
                        double kalan = para - (sonuc * dovizalis);
                        txtkalan.Text = kalan.ToString("F2") + " TL";

                    }
                    else if (lbldovizalis.Text.Contains("Dolar"))
                    {

                        double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));
                        double dovizmiktar = para / dovizalis;


                        int sonuc = (int)Math.Floor(dovizmiktar);
                        txtsonuc.Text = sonuc.ToString();
                        double kalan = para - (sonuc * dovizalis);
                        txtkalan.Text = kalan.ToString("F2") + " TL";
                    }

                }
            }

            if (gbdoviz.Text == "Güncel Satış İşlemleri")
            {
                if (gbislem.Text == "Döviz Miktarı ile")
                {
                    txtkalan.Visible = false;
                    if (lbldovizalis.Text.Contains("Euro"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("€", "").Trim());
                        double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                        double dovizsonuc = dovizmiktar * dovizsatis;
                        txtsonuc.Text = dovizsonuc.ToString() + " TL";

                    }
                    else if (lbldovizalis.Text.Contains("Dolar"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("$", "").Trim());
                        double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                        double dovizsonuc = dovizmiktar * dovizsatis;
                        txtsonuc.Text = dovizsonuc.ToString() + " TL";
                    }



                }
            }

            if (gbislem.Text == "Para Miktarı ile")
            {
                if (lbldovizalis.Text.Contains("Euro"))
                {
                    double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                    double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                    double dovizmiktar = para / dovizsatis;


                    int sonuc = (int)Math.Floor(dovizmiktar);
                    txtsonuc.Text = sonuc.ToString();
                    double kalan = para - (sonuc * dovizsatis);
                    txtkalan.Text = kalan.ToString("F2") + " TL";
                }
                else if (lbldovizalis.Text.Contains("Dolar"))
                {

                    double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                    double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                    double dovizmiktar = para / dovizsatis;


                    int sonuc = (int)Math.Floor(dovizmiktar);
                    txtsonuc.Text = sonuc.ToString();
                    double kalan = para - (sonuc * dovizsatis);
                    txtkalan.Text = kalan.ToString("F2") + " TL";


                }
            }
        }




        private void uyeolmadangiris_Load(object sender, EventArgs e)
        {


            btnalis.Enabled = false;
            btnsatis.Enabled = false;
            btndoviz.Enabled = false;
            btnmiktar.Enabled = false;
            txtdovizpara.Enabled = false;
            btnhesapla.Enabled = false;
            btnAl.Enabled = false;

            monthCalendar1.MaxDate = DateTime.Now.Date;

            lblkullanici.Text = kullaniciad;


            baglanti.Open();
            SqlCommand connect = new SqlCommand("Select  Ad , Soyad from doviz where KullaniciAd = @p1", baglanti);
            connect.Parameters.AddWithValue("@p1", lblkullanici.Text);
            SqlDataReader dr = connect.ExecuteReader();

            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString() + " " + dr[1].ToString();

            }

            baglanti.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            gbdoviz.Text = "Güncel Alış İşlemleri";
            btnAl.Text = "Al";
            btndoviz.Enabled = true;
            btnmiktar.Enabled = true;
            btnhesapla.Enabled = true;

            if (lbldovizalis.Text.Contains("Euro"))
            {
                txtdovizpara.Text = "0 €";
            }
            else if (lbldovizalis.Text.Contains("Dolar"))
            {
                txtdovizpara.Text = "0 $";
            }
            txtkalan.Text = string.Empty;
            txtsonuc.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            gbdoviz.Text = "Güncel Satış İşlemleri";
            btnAl.Text = "Sat";
            btndoviz.Enabled = true;
            btnmiktar.Enabled = true;
            btnhesapla.Enabled = true;
            if (lbldovizalis.Text.Contains("Euro"))
            {
                txtdovizpara.Text = "0 TL";
            }
            else if (lbldovizalis.Text.Contains("Dolar"))
            {
                txtdovizpara.Text = "0 $";
            }
            txtkalan.Text = string.Empty;
            txtsonuc.Text = string.Empty;
        }

        private void btnalis_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnsatis_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbuser_Click(object sender, EventArgs e)
        {
            uyegiris ug = new uyegiris();
            ug.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            if (gbdoviz.Text == "Güncel Alış İşlemleri")
            {
                btnAl.Text = "Al";

                if (gbislem.Text == "Döviz Miktarı ile")
                {

                    txtkalan.Visible = false;

                    if (lbldovizalis.Text.Contains("Euro"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("€", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));



                        baglanti.Open();

                        SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                        kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                        SqlDataReader dr = kullanici.ExecuteReader();
                        bool exists = dr.Read();
                        dr.Close(); // Close the reader before executing another command.

                        if (exists)
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Euro = Euro + @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                            cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (lbldovizalis.Text.Contains("Euro"))
                            {
                                txtdovizpara.Text = "0 €";
                            }
                            else if (lbldovizalis.Text.Contains("Dolar"))
                            {
                                txtdovizpara.Text = "0 $";
                            }
                            txtkalan.Text = string.Empty;
                            txtsonuc.Text = string.Empty;
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO dovizpara (Euro, Tarih, KullaniciAd) VALUES (@p1, @p2, @p3)", baglanti);
                            cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (lbldovizalis.Text.Contains("Euro"))
                            {
                                txtdovizpara.Text = "0 €";
                            }
                            else if (lbldovizalis.Text.Contains("Dolar"))
                            {
                                txtdovizpara.Text = "0 $";
                            }
                            txtkalan.Text = string.Empty;
                            txtsonuc.Text = string.Empty;
                        }

                        baglanti.Close();


                    }
                    else if (lbldovizalis.Text.Contains("Dolar"))
                    {
                        double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("$", "").Trim());
                        double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));

                        baglanti.Open();

                        SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                        kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                        SqlDataReader dr = kullanici.ExecuteReader();
                        bool exists = dr.Read();
                        dr.Close();

                        if (exists)
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Dolar = Dolar + @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                            cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (lbldovizalis.Text.Contains("Euro"))
                            {
                                txtdovizpara.Text = "0 €";
                            }
                            else if (lbldovizalis.Text.Contains("Dolar"))
                            {
                                txtdovizpara.Text = "0 $";
                            }
                            txtkalan.Text = string.Empty;
                            txtsonuc.Text = string.Empty;
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO dovizpara (Dolar, Tarih, KullaniciAd) VALUES (@p1, @p2, @p3)", baglanti);
                            cmd.Parameters.AddWithValue("@p1", dovizmiktar.ToString());
                            cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (lbldovizalis.Text.Contains("Euro"))
                            {
                                txtdovizpara.Text = "0 €";
                            }
                            else if (lbldovizalis.Text.Contains("Dolar"))
                            {
                                txtdovizpara.Text = "0 $";
                            }
                            txtkalan.Text = string.Empty;
                            txtsonuc.Text = string.Empty;
                        }

                        baglanti.Close();

                    }
                }

                    if (gbislem.Text == "Para Miktarı ile")
                    {
                        if (lbldovizalis.Text.Contains("Euro"))
                        {
                            double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                            double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                            double dovizmiktar = para / dovizsatis;


                            int sonuc = (int)Math.Floor(dovizmiktar);
                            txtsonuc.Text = sonuc.ToString();
                            double kalan = para - (sonuc * dovizsatis);
                            txtkalan.Text = kalan.ToString("F2");

                          

                            baglanti.Open();

                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close();

                            if (exists)
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Euro = Euro + @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (lbldovizalis.Text.Contains("Euro"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                else if (lbldovizalis.Text.Contains("Dolar"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                txtkalan.Enabled = false;
                                txtsonuc.Enabled = false;

                                txtkalan.Text = string.Empty;
                                txtsonuc.Text = string.Empty;
                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO dovizpara (Euro, Tarih, KullaniciAd) VALUES (@p1, @p2, @p3)", baglanti);
                                cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (lbldovizalis.Text.Contains("Euro"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                else if (lbldovizalis.Text.Contains("Dolar"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                txtkalan.Enabled = false;
                                txtsonuc.Enabled = false;
                                txtkalan.Text = string.Empty;
                                txtsonuc.Text = string.Empty;
                                cmd.ExecuteNonQuery();
                            }

                            baglanti.Close();



                        }
                        else if (lbldovizalis.Text.Contains("Dolar"))
                        {

                            double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                            double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                            double dovizmiktar = para / dovizsatis;


                            int sonuc = (int)Math.Floor(dovizmiktar);
                            txtsonuc.Text = sonuc.ToString();
                            double kalan = para - (sonuc * dovizsatis);
                            txtkalan.Text = kalan.ToString("F2");
                            double DolarTL = para - kalan;

                            baglanti.Open();

                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close(); 

                            if (exists)
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Dolar = Dolar + @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (lbldovizalis.Text.Contains("Euro"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                else if (lbldovizalis.Text.Contains("Dolar"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                txtkalan.Enabled = false;
                                txtsonuc.Enabled = false;

                                txtkalan.Text = string.Empty;
                                txtsonuc.Text = string.Empty;

                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO dovizpara (Dolar, Tarih, KullaniciAd) VALUES (@p1, @p2, @p3)", baglanti);
                                cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Alımınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (lbldovizalis.Text.Contains("Euro"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                else if (lbldovizalis.Text.Contains("Dolar"))
                                {
                                    txtdovizpara.Text = "0 TL";
                                }
                                txtkalan.Enabled = false;
                                txtsonuc.Enabled = false;

                                txtkalan.Text = string.Empty;
                                txtsonuc.Text = string.Empty;
                            }

                            baglanti.Close();




                        }








                        }
                    }
                

            if (gbdoviz.Text == "Güncel Satış İşlemleri")
            {

                if (gbislem.Text == "Döviz Miktarı ile")
                {

                    txtkalan.Visible = false;

                    baglanti.Open();

                    SqlCommand cm = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @p1", baglanti);
                    cm.Parameters.AddWithValue("@p1", lblkullanici.Text);
                    SqlDataReader reader = cm.ExecuteReader();
                    if (reader.Read())
                    {
                        lblkullanici.Text = reader[0].ToString();
                        reader.Close();

                        if (lbldovizalis.Text.Contains("Euro"))
                        {
                            double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("€", "").Trim());
                            double dovizalis = Convert.ToDouble(lbldovizaliskur.Text.Replace(".", ","));




                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close();




                            if (exists)
                            {
                                SqlCommand getBalanceCmd = new SqlCommand("SELECT ISNULL(Euro, 0) FROM dovizpara WHERE KullaniciAd = @p3;", baglanti);
                                getBalanceCmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                double currentBalance = Convert.ToDouble(getBalanceCmd.ExecuteScalar());

                                if (currentBalance >= dovizmiktar)
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Euro = Euro - @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                    cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                    cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Satışınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 €";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 $";
                                    }
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                                else
                                {

                                    MessageBox.Show("Yeterli bakiye yok. İşlem gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 €";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 $";
                                    }
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                            }


                            baglanti.Close();


                        }
                        else if (lbldovizalis.Text.Contains("Dolar"))
                        {
                            double dovizmiktar = Convert.ToDouble(txtdovizpara.Text.Replace("$", "").Trim());
                           
                           

                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close();

                            if (exists)
                            {

                                SqlCommand getBalanceCmd = new SqlCommand("SELECT ISNULL(Dolar, 0) FROM dovizpara WHERE KullaniciAd = @p3;", baglanti);
                                getBalanceCmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                double currentBalance = Convert.ToDouble(getBalanceCmd.ExecuteScalar());




                                if (currentBalance >= dovizmiktar)
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Dolar = Dolar - @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                    cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                    cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Satışınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 €";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 $";
                                    }
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                                else
                                {

                                    MessageBox.Show("Yeterli bakiye yok. İşlem gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 €";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 $";
                                    }
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                            }
                            baglanti.Close();

                        }

                    





                        }
                    else
                    {
                        MessageBox.Show("Bu kullancı önceden alım işlemi yapmadığı için satış yetkisi bulunmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (lbldovizalis.Text.Contains("Euro"))
                        {
                            txtdovizpara.Text = "0 €";
                        }
                        else if (lbldovizalis.Text.Contains("Dolar"))
                        {
                            txtdovizpara.Text = "0 $";
                        }
                        txtkalan.Text = string.Empty;
                        txtsonuc.Text = string.Empty;
                        reader.Close();
                    }
                }
                


                if (gbislem.Text == "Para Miktarı ile")
                {
                    baglanti.Open();

                    SqlCommand cm = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @p1", baglanti);
                    cm.Parameters.AddWithValue("@p1", lblkullanici.Text);
                    SqlDataReader reader = cm.ExecuteReader();

                    if (reader.Read())
                    {
                        lblkullanici.Text = reader[0].ToString();
                        reader.Close();


                        if (lbldovizalis.Text.Contains("Euro"))
                        {
                            double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                            double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                            double dovizmiktar = para / dovizsatis;


                            int sonuc = (int)Math.Floor(dovizmiktar);
                            txtsonuc.Text = sonuc.ToString();
                            double kalan = para - (sonuc * dovizsatis);
                            txtkalan.Text = kalan.ToString("F2");




                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close();

                            if (exists)
                            {

                                SqlCommand getBalanceCmd = new SqlCommand("SELECT ISNULL(Euro, 0) FROM dovizpara WHERE KullaniciAd = @p3;", baglanti);
                                getBalanceCmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                double currentBalance = Convert.ToDouble(getBalanceCmd.ExecuteScalar());

                                if (currentBalance >= dovizmiktar)
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Euro = Euro - @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                    cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                    cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Satışınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    txtkalan.Enabled = false;
                                    txtsonuc.Enabled = false;
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                                else
                                {

                                    MessageBox.Show("Yeterli bakiye yok. İşlem gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    txtkalan.Enabled = false;
                                    txtsonuc.Enabled = false; ;
                                    
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                            }



                        }
                        else if (lbldovizalis.Text.Contains("Dolar"))
                        {

                            double para = Convert.ToDouble(txtdovizpara.Text.Replace("TL", "").Trim());
                            double dovizsatis = Convert.ToDouble(lbldovizsatiskur.Text.Replace(".", ","));
                            double dovizmiktar = para / dovizsatis;


                            int sonuc = (int)Math.Floor(dovizmiktar);
                            txtsonuc.Text = sonuc.ToString();
                            double kalan = para - (sonuc * dovizsatis);
                            txtkalan.Text = kalan.ToString("F2");
                            


                            SqlCommand kullanici = new SqlCommand("Select KullaniciAd from dovizpara where KullaniciAd = @kullaniciAd", baglanti);
                            kullanici.Parameters.AddWithValue("@kullaniciAd", lblkullanici.Text);

                            SqlDataReader dr = kullanici.ExecuteReader();
                            bool exists = dr.Read();
                            dr.Close();

                            if (exists)
                            {

                                SqlCommand getBalanceCmd = new SqlCommand("SELECT ISNULL(Dolar, 0) FROM dovizpara WHERE KullaniciAd = @p3;", baglanti);
                                getBalanceCmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                double currentBalance = Convert.ToDouble(getBalanceCmd.ExecuteScalar());

                                if (currentBalance >= dovizmiktar)
                                {
                                    SqlCommand cmd = new SqlCommand("UPDATE dovizpara SET Dolar = Dolar - @p1, Tarih = @p2 WHERE KullaniciAd = @p3;", baglanti);
                                    cmd.Parameters.AddWithValue("@p1", dovizmiktar);
                                    cmd.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@p3", lblkullanici.Text);
                                    cmd.ExecuteNonQuery();


                                    MessageBox.Show("Satışınız başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    txtkalan.Enabled = false;
                                    txtsonuc.Enabled = false;
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                                else
                                {

                                    MessageBox.Show("Yeterli bakiye yok. İşlem gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (lbldovizalis.Text.Contains("Euro"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    else if (lbldovizalis.Text.Contains("Dolar"))
                                    {
                                        txtdovizpara.Text = "0 TL";
                                    }
                                    txtkalan.Enabled = false;
                                    txtsonuc.Enabled = false;
                                    txtkalan.Text = string.Empty;
                                    txtsonuc.Text = string.Empty;
                                }
                            }










                        }
                        
                        baglanti.Close();


                    }

                    else
                    {
                        MessageBox.Show("Bu kullancı önceden alım işlemi yapmadığı için satış yetkisi bulunmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (lbldovizalis.Text.Contains("Euro"))
                        {
                            txtdovizpara.Text = "0 €";
                        }
                        else if (lbldovizalis.Text.Contains("Dolar"))
                        {
                            txtdovizpara.Text = "0 $";
                        }
                        txtkalan.Text = string.Empty;
                        txtsonuc.Text = string.Empty;
                        reader.Close();
                    }

                    baglanti.Close();

                }






            }
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            uyesayfa us = new uyesayfa();
            us.bilgi = lblkullanici.Text;
            us.Show();
            this.Hide();
        }
    }
}
            
        
