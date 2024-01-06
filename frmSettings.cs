using LPS_Utility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPS_Utility
{
    public partial class frmSettings : Form
    {
        internal frmSettings()
        {
            InitializeComponent();
            getCurrentSettings();
        }

        private void lblSilverNode_Click(object sender, EventArgs e)
        {

        }

        internal void getCurrentSettings()
        {
            txtGoldNode.Text = Settings.Default.GoldPriceNode.ToString();
            txtGoldWebsite.Text=Settings.Default.GoldWebsite.ToString();
            txtSilverWebsite.Text=Settings.Default.SilverWebsite.ToString();
            txtSilverNode.Text=Settings.Default.SilverPriceNode.ToString();

        }

        internal void setNewSettings()
        {
            Settings.Default.GoldPriceNode = txtGoldNode.Text;
            Settings.Default.GoldWebsite = txtGoldWebsite.Text;
            Settings.Default.SilverPriceNode = txtSilverNode.Text;
            Settings.Default.SilverWebsite = txtSilverWebsite.Text;

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            setNewSettings();

            Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }
    }
}
