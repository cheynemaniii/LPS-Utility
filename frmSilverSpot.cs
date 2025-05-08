using HtmlAgilityPack;
using LPS_Utility;
using System;
using System.Windows.Forms;

namespace LPS_Utility
{
    public partial class frmSilverSpot : Form
    {
        public decimal  SilverSpot;
        public decimal SilverSpotGram;

        public frmSilverSpot()
        {
            InitializeComponent();
            cmdSilverCalculate.Visible = false;
            KitcoSilverSpot kitcoSilverSpot = new KitcoSilverSpot();
           
            SilverSpot = kitcoSilverSpot.SpotValue();
           

            SilverFormLoad();
        }



        private void SilverFormLoad()
        {

            txtSilverSpot.Text = SilverSpot.ToString();
            SilverSpotGram = SilverSpot / 31.1m;


            //Display Spot Price Per Ounce @ Certain Percentages
            lbl35Ounce.Text = "$" + Math.Round(SilverSpot * .35m, 2).ToString();
            lbl40Ounce.Text = "$" + Math.Round(SilverSpot * .40m, 2).ToString();
            lbl50Ounce.Text = "$" + Math.Round(SilverSpot * .50m, 2).ToString();
            lbl80Ounce.Text = "$" + Math.Round(SilverSpot * .80m, 2).ToString();
            lbl90Ounce.Text = "$" + Math.Round(SilverSpot * .90m, 2).ToString();
            lbl925Ounce.Text = "$" + Math.Round(SilverSpot * .925m, 2).ToString();
            lbl999Ounce.Text = "$" + Math.Round(SilverSpot * .999m, 2).ToString();

            //Display Spot Price Per Gram @ Certain Percentages
            lbl35Gram.Text = "$" + Math.Round(SilverSpotGram * .35m, 2).ToString();
            lbl40Gram.Text = "$" + Math.Round(SilverSpotGram * .40m, 2).ToString();
            lbl50Gram.Text = "$" + Math.Round(SilverSpotGram * .50m, 2).ToString();
            lbl80Gram.Text = "$" + Math.Round(SilverSpotGram * .80m, 2).ToString();
            lbl90Gram.Text = "$" + Math.Round(SilverSpotGram * .90m, 2).ToString();
            lbl925Gram.Text = "$" + Math.Round(SilverSpotGram * .925m, 2).ToString();
            lbl999Gram.Text = "$" + Math.Round(SilverSpotGram * .999m, 2).ToString();

            //Display Sale Price Per Pure Ounce @ Certain Percentages
            lblSaleOunce10.Text = "$" + Math.Round(SilverSpot * 1.1m, 2).ToString();
            lblSaleOunce15.Text = "$" + Math.Round(SilverSpot * 1.15m, 2).ToString();
            lblSaleOunce20.Text = "$" + Math.Round(SilverSpot * 1.2m, 2).ToString();
            lblSaleOunce25.Text = "$" + Math.Round(SilverSpot * 1.25m, 2).ToString();
            lblSaleOunce30.Text = "$" + Math.Round(SilverSpot * 1.3m, 2).ToString();
            lblSaleOunce40.Text = "$" + Math.Round(SilverSpot * 1.4m, 2).ToString();
            lblSaleOunce50.Text = "$" + Math.Round(SilverSpot * 1.5m, 2).ToString();
            lblSaleOunce100.Text = "$" + Math.Round(SilverSpot * 2m, 2).ToString();
            lblSaleOunce200.Text = "$" + Math.Round(SilverSpot * 3m, 2).ToString();

            //Display Sale Price Per Pure Gram @ Certain Percentages
            lblSaleGram10.Text = "$" + Math.Round(SilverSpotGram * 1.1m, 2).ToString();
            lblSaleGram15.Text = "$" + Math.Round(SilverSpotGram * 1.15m, 2).ToString();    
            lblSaleGram20.Text = "$" + Math.Round(SilverSpotGram * 1.2m, 2).ToString();
            lblSaleGram25.Text = "$" + Math.Round(SilverSpotGram * 1.25m, 2).ToString();
            lblSaleGram30.Text = "$" + Math.Round(SilverSpotGram * 1.3m, 2).ToString();
            lblSaleGram40.Text = "$" + Math.Round(SilverSpotGram * 1.4m, 2).ToString();
            lblSaleGram50.Text = "$" + Math.Round(SilverSpotGram * 1.5m, 2).ToString();
            lblSaleGram100.Text = "$" + Math.Round(SilverSpotGram * 2m, 2).ToString();
            lblSaleGram200.Text = "$" + Math.Round(SilverSpotGram * 3m, 2).ToString();
        }

        private void txtSilverSpot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cmdSilverCalculate_Click(object sender, EventArgs e)
        {
            bool g = string.IsNullOrEmpty(txtSilverSpot.Text);

            if (g == true)
            {
                MessageBox.Show("Please enter a Silver Spot Value!", "ERROR");
            }
            else
            {
                
               
                SilverFormLoad();

                
            }

        }

        private void frmSilverSpot_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}