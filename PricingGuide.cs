using HtmlAgilityPack;
using LPS_Utility;
using System;
using System.Windows.Forms;



namespace LPS_GOLD
{
    public partial class PricingGuide : Form
    {
        public decimal GlobalSpot;
        
        public PricingGuide()
        {
            InitializeComponent();
            KitcoGoldSpot kitcoGoldSpot = new KitcoGoldSpot();
            GlobalSpot = kitcoGoldSpot.SpotValue();
            txtGoldSpot.Text=GlobalSpot.ToString();
            
     

        }

        private void txtGoldSpot_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PricingGuide_Load(object sender, EventArgs e)
        {
            cboMarkup.SelectedIndex = 0;
       
            cmdCalculate.PerformClick();

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            decimal MarkupPercent = MarkupSelect();
            DateTime date = DateTime.Now; // will give the date for today
            string longDate = date.ToLongDateString();
            decimal GoldSpotGram = GlobalSpot / 31.1m;
            decimal db24k = Math.Round(GoldSpotGram * MarkupPercent, 2);
            decimal db22k = Math.Round((GoldSpotGram * (22/24m) * MarkupPercent), 2);
            decimal db18k = Math.Round((GoldSpotGram * (18/24m) * MarkupPercent), 2);
            decimal db14k = Math.Round((GoldSpotGram * (14/24m) * MarkupPercent), 2);
            decimal db12k = Math.Round((GoldSpotGram * (12/24m) * MarkupPercent), 2);
            decimal db10k = Math.Round((GoldSpotGram * (10/24m) * MarkupPercent), 2);
            decimal db8k = Math.Round((GoldSpotGram * (8/24m) * MarkupPercent), 2);

            lbl24k.Text = "$" + Convert.ToString(db24k);
            lbl22k.Text = "$" + Convert.ToString(db22k);
            lbl18k.Text = "$" + Convert.ToString(db18k);
            lbl14k.Text = "$" + Convert.ToString(db14k);
            lbl12k.Text = "$" + Convert.ToString(db12k);
            lbl10k.Text = "$" + Convert.ToString(db10k);
            lbl8k.Text = "$" + Convert.ToString(db8k);



        }
        private decimal MarkupSelect()
        {
            decimal Markup;
            //check if cboMarkup.SelectedIndex value is greater -1
            if (cboMarkup.SelectedIndex == (-1))
            {
                MessageBox.Show("Please select a Markup value!", "ERROR");
                return Markup = 0;
            }
            else
            {
                switch (cboMarkup.SelectedIndex)
                {
                    case 0: Markup = 2; break;
                    case 1: Markup = 3; break;
                    case 2: Markup = 4; break;
                    case 3: Markup = 5; break;
                    case 4: Markup = 6; break;
                    case 5: Markup = 7; break;
                    case 6: Markup = 8; break;
                    default: Markup = 2; break;
                }
                return Markup;
            }
        }
    }

}
