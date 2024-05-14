using HtmlAgilityPack;
using LPS_Utility;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;



namespace LPS_Utility
{
    public partial class PricingGuide : Form
    {
        public decimal GlobalSpot;
        
        public PricingGuide()
        {
            InitializeComponent();
            KitcoGoldSpot kitcoGoldSpot = new KitcoGoldSpot();
            GetAllPrinters();
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

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            // if txtGoldSpot is empty
            if (txtGoldSpot.Text == "")
            {
                MessageBox.Show("Please enter a Gold Spot value!", "ERROR");
                return;
            }


            //if cboMarkup.SelectedIndex value is greater -1
            if (cboMarkup.SelectedIndex == (-1))
            {
                MessageBox.Show("Please select a Markup value!", "ERROR");
                return;
            }

            //printer not selected
            if (cboPrinters.SelectedIndex == (-1))
            {
                MessageBox.Show("Please select a printer!", "ERROR");
                return;
            }
            else
            {

                // Create a new instance of the PrintDocument class
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                // Set the printer name
                pd.PrinterSettings.PrinterName = cboPrinters.Text;
                // Add an event handler that will be called when the document is printed
                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
                // Print the document
                pd.Print();



            }

  

                
     




        }
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create a font
            Font font = new Font("Arial", 12);
            // Create a solid brush
            SolidBrush brush = new SolidBrush(Color.Black);
            // Create a rectangle
            Rectangle rectangle = new Rectangle(0, 0, 100, 100);

            // Create a string to print
            decimal MarkupPercent = MarkupSelect();
            DateTime date = DateTime.Now; // will give the date for today
            string longDate = date.ToLongDateString();
            decimal GoldSpotGram = GlobalSpot / 31.1m;
            decimal db24k = Math.Round(GoldSpotGram * MarkupPercent, 2);
            decimal db22k = Math.Round((GoldSpotGram * (22 / 24m) * MarkupPercent), 2);
            decimal db18k = Math.Round((GoldSpotGram * (18 / 24m) * MarkupPercent), 2);
            decimal db14k = Math.Round((GoldSpotGram * (14 / 24m) * MarkupPercent), 2);
            decimal db12k = Math.Round((GoldSpotGram * (12 / 24m) * MarkupPercent), 2);
            decimal db10k = Math.Round((GoldSpotGram * (10 / 24m) * MarkupPercent), 2);
            decimal db8k = Math.Round((GoldSpotGram * (8 / 24m) * MarkupPercent), 2);


       
            // print date
            e.Graphics.DrawString("Date: " + Convert.ToString(longDate), font, brush, 100, 100);
            // print gold spot value
            e.Graphics.DrawString("Gold Spot: $" + GlobalSpot.ToString(), font, brush, 100, 120);
            // print 24k value
            e.Graphics.DrawString("24k: $" + Convert.ToString(db24k), font, brush, 100, 140);
            // print 22k value
            e.Graphics.DrawString("22k: $" + Convert.ToString(db22k), font, brush, 100, 160);
            // print 18k value
            e.Graphics.DrawString("18k: $" + Convert.ToString(db18k), font, brush, 100, 180);
            // print 14k value
            e.Graphics.DrawString("14k: $" + Convert.ToString(db14k), font, brush, 100, 200);
            // print 12k value
            e.Graphics.DrawString("12k: $" + Convert.ToString(db12k), font, brush, 100, 220);
            // print 10k value
            e.Graphics.DrawString("10k: $" + Convert.ToString(db10k), font, brush, 100, 240);
            // print 8k value
            e.Graphics.DrawString("8k: $" + Convert.ToString(db8k), font, brush, 100, 260);
            // print markup value
            e.Graphics.DrawString("Markup: " + Convert.ToString(MarkupPercent) + "%", font, brush, 100, 280);
            // print footer
            e.Graphics.DrawString("Printed by LPS Utility", font, brush, 100, 300);
           


        }
        //get all printers
        private void GetAllPrinters()
        {
            // Get all the installed printers
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                // Add the printer to the combo box
                cboPrinters.Items.Add(printer);
            }
        }
    }

}
