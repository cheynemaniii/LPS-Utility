using HtmlAgilityPack;

using System;

using System.Windows.Forms;

namespace LPS_Utility
{
    public partial class FrmMain : Form

    {
        public decimal KaratValue;
        public decimal PrecentageValue;
        public decimal GlobalSpot;
        public decimal SilverSpot;
        
    

        KitcoGoldSpot kitcoGoldSpot = new KitcoGoldSpot();
        KitcoSilverSpot kitcoSilverSpot = new KitcoSilverSpot();


        
        public FrmMain()
        {
            InitializeComponent();
            
            GlobalSpot = kitcoGoldSpot.SpotValue();
            SilverSpot = kitcoSilverSpot.SpotValue();
            txtGoldSpot.Text=GlobalSpot.ToString(); 
            txtSilverSpot.Text=SilverSpot.ToString();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            bool w = string.IsNullOrEmpty(txtWeight.Text);
            bool g = string.IsNullOrEmpty(txtGoldSpot.Text);
            bool s = optSelling.Checked;
            bool l = optLoanBuy.Checked;
            int p = cboPercentage.SelectedIndex;
            int k = cboKarat.SelectedIndex;

            if (w == false && g == false && k != -1)
            {
                if (l == true)
                {
                    OptionButton();
                }

                if (s == true)
                {
                    if (p != -1 && k != -1)
                    {
                        OptionButton();
                    }
                    else
                    {
                        cmdClear_Click(sender, e);
                        MessageBox.Show("Please select both Karat and Percentage!", "ERROR");
                    }
                }
            }
            else
            {
                cmdClear_Click(sender, e);
                MessageBox.Show("Please enter a GoldSpot, Weight and/or Karat value!", "ERROR");
            }
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

        private void optLoanBuy_CheckedChanged(object sender, EventArgs e)
        {
            // bool loanBuy = false;
            //check if option buttons are checked
            if (optLoanBuy.Checked)
            {
                // loanBuy = true;
                lblQuote.Text = "Loan Or Purchasing Quote!";
                cboPercentage.Visible = false;
                lblPercent.Visible = false;
                gboxResults.Visible = true;
                cboKarat.Visible = true;
                lblKarat.Visible = true;
            }
            else
            {
                cboPercentage.Visible = false;
                lblPercent.Visible = false;
                gboxResults.Visible = false;
                cboKarat.Visible = false;
                cboPercentage.Visible = false;
                lblKarat.Visible = false;
                lblPercent.Visible = false;
            }
        }

        private void optSelling_CheckedChanged(object sender, EventArgs e)
        {
            //bool selling = false;
            if (optSelling.Checked)
            {
                // selling = true;
                lblQuote.Text = "Selling Quote!";
                cboPercentage.Visible = true;
                lblPercent.Visible = true;
                gboxResults.Visible = true;
                cboKarat.Visible = true;
                cboPercentage.Visible = true;
                lblKarat.Visible = true;
                lblPercent.Visible = true;
            }
            else
            {
                // selling = false;
                cboPercentage.Visible = false;
                lblPercent.Visible = false;
                gboxResults.Visible = false;
                cboKarat.Visible = false;
                cboPercentage.Visible = false;
                lblKarat.Visible = false;
                lblPercent.Visible = false;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lblQuote.Text = "Loan Or Purchasing Quote!";
            lblTotal.Text = "TOTAL: $ ";
            lblAmountDiamonds.Text = "Diamonds: ";
            lblAmountGold.Text = "Gold: ";
            txtDiamonds.Text = "";
            txtGoldSpot.Text = "";
            txtSilverSpot.Text = "";
            txtWeight.Text = "";
            optLoanBuy.Checked = false;
            optSelling.Checked = false;
            cboKarat.SelectedIndex = -1;
            cboKarat.Text = "Karat Selection";
            cboPercentage.SelectedIndex = -1;
            cboPercentage.Text = "Sell Percentage Selection";
            cmdRefresh_Click(sender, e);
        }

        private decimal karatSelect()
        {
            decimal karat;
            //check if cboKarat.SelectedIndex value is greater -1
            if (cboKarat.SelectedIndex == (-1))
            {
                MessageBox.Show("Please select a Karat value!", "ERROR");
                return karat = 0;
            }
            else
            {
                switch (cboKarat.SelectedIndex)
                {
                    case 0: karat = 24; break;
                    case 1: karat = 22; break;
                    case 2: karat = 18; break;
                    case 3: karat = 14; break;
                    case 4: karat = 12; break;
                    case 5: karat = 10; break;
                    case 6: karat = 8; break;
                    default: karat = 0; break;
                }
                return karat / 24;
            }
        }

        private decimal PrecentageSelect()
        {
            //Check if cboPrecentage.SelectedIndex value is great than -1
            decimal percentage;
            if (cboPercentage.SelectedIndex == (-1))
            {
                if (optLoanBuy.Checked)
                {
                    //MessageBox.Show("Please select a Percentage value!", "ERROR");
                }
                else
                {
                    MessageBox.Show("Please select a Percentage value!", "ERROR");
                }
                return percentage = 0;
            }
            else
            {
                switch (cboPercentage.SelectedIndex)
                {
                    case 0: percentage = 1.10m; break;
                    case 1: percentage = 1.20m; break;
                    case 2: percentage = 1.30m; break;
                    case 3: percentage = 1.40m; break;
                    case 4: percentage = 1.50m; break;
                    case 5: percentage = 1.60m; break;
                    case 6: percentage = 1.70m; break;
                    case 7: percentage = 1.80m; break;
                    case 8: percentage = 1.90m; break;
                    case 9: percentage = 2m; break;
                    case 10: percentage = 2.5m; break;
                    case 11: percentage = 3m; break;
                    default: percentage = 0m; break;
                }
                return percentage;
            }
        }

        private decimal WeightSelect
        {
            get
            {
                //check to see if txtWeight is empty
                decimal weight;
                if (string.IsNullOrEmpty(txtWeight.Text))
                {
                    MessageBox.Show("Please enter a numeric value!", "ERROR");
                    return weight = 0;
                }
                else
                {
                    return weight = Convert.ToDecimal(txtWeight.Text);
                }
            }
        }

        private decimal goldSelect
        {
            get
            {
                decimal goldSpot;
                bool isDifferent;

                //check to see if txtGoldSpot is empty

                if (string.IsNullOrEmpty(txtGoldSpot.Text))
                {
                    MessageBox.Show("Please enter a numeric value!", "ERROR");
                    return goldSpot = 0m;
                }
                else
                {
                    isDifferent = GlobalSpot == (Convert.ToDecimal(txtGoldSpot.Text));

                    if (isDifferent)
                    {
                        return goldSpot = GlobalSpot / 31.1m;
                    }
                    else
                    {
                        return goldSpot = (Convert.ToDecimal(txtGoldSpot.Text)) / 31.1m;
                    }
                }
            }
        }

        private decimal diamondSelect()
        {
            //check to see if txtDiamonds is empty
            decimal diamondValue;
            if (string.IsNullOrEmpty(txtDiamonds.Text))
            {
                return diamondValue = 0;
            }
            else
            {
                return diamondValue = Convert.ToDecimal(txtDiamonds.Text);
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiamonds_KeyPress(object sender, KeyPressEventArgs e)
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

        private void OptionButton()
        {
            if (optLoanBuy.Checked || optSelling.Checked)
            {
                decimal goldSpot = Math.Round(goldSelect, 2);
                decimal weight = Math.Round(WeightSelect, 2);
                decimal diamond = Math.Round(diamondSelect(), 2);
                decimal decKarat = Math.Round(karatSelect(), 2);
                decimal decPrecentage = PrecentageSelect();
                decimal total;
                decimal taxes;

                if (optLoanBuy.Checked)
                {
                    total = Math.Round(((goldSpot * decKarat) * weight) / 2 + (diamond), 2);

                    lblAmountDiamonds.Text = "Diamonds: $" + diamond;
                    lblAmountGold.Text = "Gold: $" + Math.Round((((goldSpot * decKarat) * weight) / 2), 2);
                    lblTotal.Text = "TOTAL: $" + Math.Round((total), 2);
                    lblbreakDown.Text = "Scrap Value of Gold: $" + Math.Round(((goldSpot * decKarat) * weight), 2);
                }
                if (optSelling.Checked)
                {
                    total = Math.Round(((goldSpot * decKarat) * weight) * decPrecentage + diamond, 2);
                    taxes = Math.Round((total * .07m), 2);
                    lblAmountDiamonds.Text = "Diamonds: $" + diamond;
                    lblAmountGold.Text = "Gold: $" + Math.Round(((goldSpot * decKarat) * (weight) * decPrecentage), 2);
                    lblTotal.Text = "TOTAL: $" + Math.Round((total + taxes), 2);
                    lblbreakDown.Text = "Pre-Taxes: $" + total + " Taxes $" + taxes;
                }
            }
            else
            {
                MessageBox.Show("Please select a option: Loan/Buy or Selling!", "Error");
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            GlobalSpot = kitcoGoldSpot.SpotValue();
            SilverSpot = kitcoSilverSpot.SpotValue();

            txtGoldSpot.Text = GlobalSpot.ToString();
            txtSilverSpot.Text = SilverSpot.ToString();
        }





        private void silverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSilverSpot frmSilver = new frmSilverSpot();
            frmSilver.Show();
        }

        private void pricingGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PricingGuide pricingGuide = new PricingGuide();
            pricingGuide.Show();
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.Show();

        }
    }
}