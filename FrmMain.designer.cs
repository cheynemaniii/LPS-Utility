
namespace LPS_Utility
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblGoldSpot = new System.Windows.Forms.Label();
            this.gBoxVaribles = new System.Windows.Forms.GroupBox();
            this.txtDiamonds = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optLoanBuy = new System.Windows.Forms.RadioButton();
            this.optSelling = new System.Windows.Forms.RadioButton();
            this.cboKarat = new System.Windows.Forms.ComboBox();
            this.cboPercentage = new System.Windows.Forms.ComboBox();
            this.gboxResults = new System.Windows.Forms.GroupBox();
            this.lblbreakDown = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAmountDiamonds = new System.Windows.Forms.Label();
            this.lblAmountGold = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.silverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pricingGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGoldSpot = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblKarat = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtSilverSpot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBoxVaribles.SuspendLayout();
            this.gboxResults.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGoldSpot
            // 
            this.lblGoldSpot.AutoSize = true;
            this.lblGoldSpot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblGoldSpot.Location = new System.Drawing.Point(12, 34);
            this.lblGoldSpot.Name = "lblGoldSpot";
            this.lblGoldSpot.Size = new System.Drawing.Size(186, 31);
            this.lblGoldSpot.TabIndex = 0;
            this.lblGoldSpot.Text = "Gold Spot Price:";
            // 
            // gBoxVaribles
            // 
            this.gBoxVaribles.Controls.Add(this.txtDiamonds);
            this.gBoxVaribles.Controls.Add(this.txtWeight);
            this.gBoxVaribles.Controls.Add(this.label2);
            this.gBoxVaribles.Controls.Add(this.label1);
            this.gBoxVaribles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gBoxVaribles.Location = new System.Drawing.Point(39, 77);
            this.gBoxVaribles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxVaribles.Name = "gBoxVaribles";
            this.gBoxVaribles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxVaribles.Size = new System.Drawing.Size(385, 90);
            this.gBoxVaribles.TabIndex = 1;
            this.gBoxVaribles.TabStop = false;
            this.gBoxVaribles.Text = "Specs:";
            // 
            // txtDiamonds
            // 
            this.txtDiamonds.Location = new System.Drawing.Point(198, 50);
            this.txtDiamonds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiamonds.Name = "txtDiamonds";
            this.txtDiamonds.Size = new System.Drawing.Size(161, 27);
            this.txtDiamonds.TabIndex = 3;
            this.txtDiamonds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiamonds_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(198, 21);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(161, 27);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount fo Diamonds:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight of Piece:";
            // 
            // optLoanBuy
            // 
            this.optLoanBuy.AutoSize = true;
            this.optLoanBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.optLoanBuy.Location = new System.Drawing.Point(116, 175);
            this.optLoanBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optLoanBuy.Name = "optLoanBuy";
            this.optLoanBuy.Size = new System.Drawing.Size(98, 24);
            this.optLoanBuy.TabIndex = 4;
            this.optLoanBuy.TabStop = true;
            this.optLoanBuy.Text = "Loan/Buy";
            this.optLoanBuy.UseVisualStyleBackColor = true;
            this.optLoanBuy.CheckedChanged += new System.EventHandler(this.optLoanBuy_CheckedChanged);
            // 
            // optSelling
            // 
            this.optSelling.AutoSize = true;
            this.optSelling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.optSelling.Location = new System.Drawing.Point(262, 175);
            this.optSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optSelling.Name = "optSelling";
            this.optSelling.Size = new System.Drawing.Size(76, 24);
            this.optSelling.TabIndex = 5;
            this.optSelling.TabStop = true;
            this.optSelling.Text = "Selling";
            this.optSelling.UseVisualStyleBackColor = true;
            this.optSelling.CheckedChanged += new System.EventHandler(this.optSelling_CheckedChanged);
            // 
            // cboKarat
            // 
            this.cboKarat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKarat.FormattingEnabled = true;
            this.cboKarat.Items.AddRange(new object[] {
            "24k",
            "22k",
            "18k",
            "14k",
            "12k",
            "10k",
            "8k"});
            this.cboKarat.Location = new System.Drawing.Point(116, 230);
            this.cboKarat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboKarat.Name = "cboKarat";
            this.cboKarat.Size = new System.Drawing.Size(222, 24);
            this.cboKarat.TabIndex = 6;
            this.cboKarat.Visible = false;
            // 
            // cboPercentage
            // 
            this.cboPercentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPercentage.FormattingEnabled = true;
            this.cboPercentage.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%",
            "150%",
            "200%"});
            this.cboPercentage.Location = new System.Drawing.Point(116, 281);
            this.cboPercentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPercentage.Name = "cboPercentage";
            this.cboPercentage.Size = new System.Drawing.Size(222, 24);
            this.cboPercentage.TabIndex = 7;
            this.cboPercentage.Visible = false;
            // 
            // gboxResults
            // 
            this.gboxResults.Controls.Add(this.lblbreakDown);
            this.gboxResults.Controls.Add(this.lblTotal);
            this.gboxResults.Controls.Add(this.lblAmountDiamonds);
            this.gboxResults.Controls.Add(this.lblAmountGold);
            this.gboxResults.Controls.Add(this.lblQuote);
            this.gboxResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gboxResults.Location = new System.Drawing.Point(453, 77);
            this.gboxResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxResults.Name = "gboxResults";
            this.gboxResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxResults.Size = new System.Drawing.Size(305, 167);
            this.gboxResults.TabIndex = 10;
            this.gboxResults.TabStop = false;
            this.gboxResults.Text = "Results:";
            this.gboxResults.Visible = false;
            // 
            // lblbreakDown
            // 
            this.lblbreakDown.AutoSize = true;
            this.lblbreakDown.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblbreakDown.Location = new System.Drawing.Point(30, 138);
            this.lblbreakDown.Name = "lblbreakDown";
            this.lblbreakDown.Size = new System.Drawing.Size(104, 23);
            this.lblbreakDown.TabIndex = 14;
            this.lblbreakDown.Text = "(Breakdown)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(30, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 28);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL: $";
            // 
            // lblAmountDiamonds
            // 
            this.lblAmountDiamonds.AutoSize = true;
            this.lblAmountDiamonds.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAmountDiamonds.Location = new System.Drawing.Point(9, 53);
            this.lblAmountDiamonds.Name = "lblAmountDiamonds";
            this.lblAmountDiamonds.Size = new System.Drawing.Size(101, 23);
            this.lblAmountDiamonds.TabIndex = 12;
            this.lblAmountDiamonds.Text = "Diamonds: ";
            // 
            // lblAmountGold
            // 
            this.lblAmountGold.AutoSize = true;
            this.lblAmountGold.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAmountGold.Location = new System.Drawing.Point(52, 71);
            this.lblAmountGold.Name = "lblAmountGold";
            this.lblAmountGold.Size = new System.Drawing.Size(58, 23);
            this.lblAmountGold.TabIndex = 11;
            this.lblAmountGold.Text = "Gold: ";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQuote.Location = new System.Drawing.Point(18, 21);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(267, 28);
            this.lblQuote.TabIndex = 10;
            this.lblQuote.Text = "Loan Or Purchasing Quote!";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cmdClear.Location = new System.Drawing.Point(171, 325);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(104, 35);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "C&lear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cmdRefresh.Location = new System.Drawing.Point(295, 325);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(104, 35);
            this.cmdRefresh.TabIndex = 10;
            this.cmdRefresh.Text = "&Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuReport,
            this.silverReportToolStripMenuItem,
            this.pricingGuideToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(777, 28);
            this.mnuStrip.TabIndex = 14;
            this.mnuStrip.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.toolStripSeparator1,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(145, 26);
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(145, 26);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(68, 24);
            this.mnuReport.Text = "&Report";
            // 
            // silverReportToolStripMenuItem
            // 
            this.silverReportToolStripMenuItem.Name = "silverReportToolStripMenuItem";
            this.silverReportToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.silverReportToolStripMenuItem.Text = "&Silver Report";
            this.silverReportToolStripMenuItem.Click += new System.EventHandler(this.silverReportToolStripMenuItem_Click);
            // 
            // pricingGuideToolStripMenuItem
            // 
            this.pricingGuideToolStripMenuItem.Name = "pricingGuideToolStripMenuItem";
            this.pricingGuideToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.pricingGuideToolStripMenuItem.Text = "Pricing Guide";
            this.pricingGuideToolStripMenuItem.Click += new System.EventHandler(this.pricingGuideToolStripMenuItem_Click);
            // 
            // txtGoldSpot
            // 
            this.txtGoldSpot.Location = new System.Drawing.Point(212, 38);
            this.txtGoldSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoldSpot.Name = "txtGoldSpot";
            this.txtGoldSpot.Size = new System.Drawing.Size(212, 22);
            this.txtGoldSpot.TabIndex = 1;
            this.txtGoldSpot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoldSpot_KeyPress);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cmdCalculate.Location = new System.Drawing.Point(47, 325);
            this.cmdCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(104, 35);
            this.cmdCalculate.TabIndex = 8;
            this.cmdCalculate.Text = "&Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblKarat
            // 
            this.lblKarat.AutoSize = true;
            this.lblKarat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKarat.Location = new System.Drawing.Point(140, 207);
            this.lblKarat.Name = "lblKarat";
            this.lblKarat.Size = new System.Drawing.Size(174, 20);
            this.lblKarat.TabIndex = 15;
            this.lblKarat.Text = "Please Select The Karat:";
            this.lblKarat.Visible = false;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPercent.Location = new System.Drawing.Point(120, 258);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(214, 20);
            this.lblPercent.TabIndex = 16;
            this.lblPercent.Text = "Please Select The Precentage:";
            this.lblPercent.Visible = false;
            // 
            // txtSilverSpot
            // 
            this.txtSilverSpot.Location = new System.Drawing.Point(630, 38);
            this.txtSilverSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSilverSpot.Name = "txtSilverSpot";
            this.txtSilverSpot.Size = new System.Drawing.Size(128, 22);
            this.txtSilverSpot.TabIndex = 18;
            this.txtSilverSpot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSilverSpot_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(430, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Silver Spot Price:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 427);
            this.Controls.Add(this.txtSilverSpot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblKarat);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtGoldSpot);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.gboxResults);
            this.Controls.Add(this.cboPercentage);
            this.Controls.Add(this.cboKarat);
            this.Controls.Add(this.optSelling);
            this.Controls.Add(this.optLoanBuy);
            this.Controls.Add(this.gBoxVaribles);
            this.Controls.Add(this.lblGoldSpot);
            this.Controls.Add(this.mnuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gBoxVaribles.ResumeLayout(false);
            this.gBoxVaribles.PerformLayout();
            this.gboxResults.ResumeLayout(false);
            this.gboxResults.PerformLayout();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoldSpot;
        private System.Windows.Forms.GroupBox gBoxVaribles;
        private System.Windows.Forms.TextBox txtDiamonds;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optLoanBuy;
        private System.Windows.Forms.RadioButton optSelling;
        private System.Windows.Forms.ComboBox cboKarat;
        private System.Windows.Forms.ComboBox cboPercentage;
        private System.Windows.Forms.GroupBox gboxResults;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmountDiamonds;
        private System.Windows.Forms.Label lblAmountGold;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.TextBox txtGoldSpot;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label lblKarat;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblbreakDown;
        private System.Windows.Forms.TextBox txtSilverSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem silverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricingGuideToolStripMenuItem;
    }
}

