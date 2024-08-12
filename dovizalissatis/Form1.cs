using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dovizalissatis
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        

        private void pbdolar_MouseEnter(object sender, EventArgs e)
        {
            pbdolar.BackColor= SystemColors.ControlLight;
        }

        private void pbdolar_MouseLeave(object sender, EventArgs e)
        {
            pbdolar.BackColor = SystemColors.Window;
        }

        private void pbeuro_MouseEnter(object sender, EventArgs e)
        {
            pbeuro.BackColor = SystemColors.ControlLight;
        }

        private void pbeuro_MouseLeave(object sender, EventArgs e)
        {
            pbeuro.BackColor = SystemColors.Window;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void pbdolar_Click(object sender, EventArgs e)
        {
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


            gbdoviz.Text = "Güncel Dolar Kur";
            lbldovizalis.Text = "Dolar Alış :";
            lbldovizsatis.Text = "Dolar Satış :";

        }

        private void pbeuro_Click(object sender, EventArgs e)
        {
          
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(url);
          
            XmlNode eurNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='EUR']");

      
  
            string eurBuyRate = eurNode.SelectSingleNode("BanknoteBuying").InnerText;
            lbldovizsatiskur.Text = eurBuyRate;
            string eurSellRate = eurNode.SelectSingleNode("BanknoteSelling").InnerText;
            lbldovizaliskur.Text = eurSellRate;

            gbdoviz.Text = "Güncel Euro Kur";
            lbldovizalis.Text = "Euro Alış :";
            lbldovizsatis.Text = "Euro Satış :";

        }

        private void linkuye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
            
            
        }

        private void linkuye_Click(object sender, EventArgs e)
        {
            alissatis grs = new alissatis();
            grs.Show();
            this.Hide();
        }

        private void pbuser_Click(object sender, EventArgs e)
        {
            uyegiris grs = new uyegiris();
            grs.Show();
            this.Hide();
        }
    }
}
