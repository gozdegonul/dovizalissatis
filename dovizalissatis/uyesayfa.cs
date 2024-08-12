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
    public partial class uyesayfa : Form
    {
        public uyesayfa()
        {
            InitializeComponent();
        }  
        public string kullan;
        public string bilgi;

        SqlConnection baglanti = new SqlConnection(@"Data Source=Gozde_Huawei;Initial Catalog=dovizalissatis;Integrated Security=True");

     
    
     
        private void label2_Click(object sender, EventArgs e)
        {
            alissatis asg = new alissatis();
            asg.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            alissatis asg = new alissatis();
            asg.kullaniciad = lblkullanici.Text;
            asg.Show();
            this.Hide();
        }

      
        private void uyesayfa_Load(object sender, EventArgs e)
        { 
            monthCalendar1.MaxDate = DateTime.Now.Date;
            lblalinan.Text = bilgi;


            if(lblalinan.Text == "Kullanici" || string.IsNullOrEmpty(lblalinan.Text))
            {
                lblkullanici.Text = kullan;

            }
            else
            {
                lblkullanici.Text = bilgi;
            }

            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(url);

           
            XmlNode usdNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='USD']");


            string usdBuyRate = usdNode.SelectSingleNode("BanknoteSelling").InnerText;
            lbldolar.Text = usdBuyRate;
            
          

            XmlNode eurNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='EUR']");

      
            string eurSellRate = eurNode.SelectSingleNode("BanknoteSelling").InnerText;
            lbleuro.Text = eurSellRate;



            baglanti.Open();
            SqlCommand connect = new SqlCommand("Select  Ad , Soyad from doviz where KullaniciAd = @p1", baglanti);
            connect.Parameters.AddWithValue("@p1", lblkullanici.Text);
            SqlDataReader dr = connect.ExecuteReader();

            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
                lblad.Text = dr[0].ToString() + " ,";
            }

            baglanti.Close();


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select  Euro , Dolar from dovizpara where KullaniciAd = @p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", lblkullanici.Text);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                chart1.Series["Euro - Dolar"].Points.AddXY("Euro", sdr[0]);
                chart1.Series["Euro - Dolar"].Points.AddXY("Dolar", sdr[1]);

                lbleuromiktar.Text = sdr[0].ToString().Replace(".", ",").Trim() + " €";
                lbldolarmiktar.Text = sdr[1].ToString().Replace(".", ",").Trim() + " $";

                if (sdr[0]!= DBNull.Value && sdr[1] != DBNull.Value)
                {
                    double euromiktar = Convert.ToDouble(lbleuromiktar.Text.Replace("€", " ").Trim());
                    double eurosatis = Convert.ToDouble(lbleuro.Text.Replace(".", ",").Trim());
                    double eurotl = euromiktar * eurosatis;
                    lbleurotl.Text = eurotl.ToString() + " TL";


                    double dolarmiktar = Convert.ToDouble(lbldolarmiktar.Text.Replace("$", " ").Trim());
                    double dolarsatis = Convert.ToDouble(lbldolar.Text.Replace(".", ",").Trim());
                    double dolartl = dolarmiktar * dolarsatis;
                    lbldolartl.Text = dolartl.ToString() + "TL";


                    double toplam = eurotl + dolartl;

                    chart2.Series["Euro - Dolar TL"].Points.AddXY("Euro TL", eurotl);
                    chart2.Series["Euro - Dolar TL"].Points.AddXY("Dolar TL", dolartl);

                    lbltoplampara.Text = toplam.ToString("N2") + " TL";
                }
                else if(sdr[0] == DBNull.Value)
                {
                    lbleuromiktar.Text = "0 €";
                    lbleurotl.Text = "0 TL";

                    double eurotl = 0;

                    double dolarmiktar = Convert.ToDouble(lbldolarmiktar.Text.Replace("$", " ").Trim());
                    double dolarsatis = Convert.ToDouble(lbldolar.Text.Replace(".", ",").Trim());
                    double dolartl = dolarmiktar * dolarsatis;
                    lbldolartl.Text = dolartl.ToString() + "TL";


                    double toplam = eurotl + dolartl;

                    
                    chart2.Series["Euro - Dolar TL"].Points.AddXY("Dolar TL", dolartl);

                    lbltoplampara.Text = toplam.ToString("N2") + " TL";

                }
                else if(sdr[1] == DBNull.Value)
                {
                    lbldolarmiktar.Text = "0 $";
                    lbldolartl.Text = "0 TL";

                    double dolartl = 0;

                    double euromiktar = Convert.ToDouble(lbleuromiktar.Text.Replace("€", " ").Trim());
                    double eurosatis = Convert.ToDouble(lbleuro.Text.Replace(".", ",").Trim());
                    double eurotl = euromiktar * eurosatis;
                    lbleurotl.Text = eurotl.ToString() + " TL";


                    double toplam = eurotl + dolartl;

                    chart2.Series["Euro - Dolar TL"].Points.AddXY("Euro TL", eurotl);
                   

                    lbltoplampara.Text = toplam.ToString("N2") + " TL";

                }
             
              


            }
            baglanti.Close();
        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {
            uyebilgi ubg = new uyebilgi();
            ubg.bilgi = lblkullanici.Text;
            ubg.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
