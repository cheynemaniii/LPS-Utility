
namespace LPS_GOLD
{
    partial class PricingGuide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PricingGuide));
            this.txtGoldSpot = new System.Windows.Forms.TextBox();
            this.lblGoldSpot = new System.Windows.Forms.Label();
            this.cboMarkup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl8k = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl24k = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl22k = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl18k = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl14k = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl12k = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl10k = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGoldSpot
            // 
            this.txtGoldSpot.Location = new System.Drawing.Point(32, 34);
            this.txtGoldSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoldSpot.Name = "txtGoldSpot";
            this.txtGoldSpot.Size = new System.Drawing.Size(149, 22);
            this.txtGoldSpot.TabIndex = 3;
            this.txtGoldSpot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoldSpot_KeyPress);
            // 
            // lblGoldSpot
            // 
            this.lblGoldSpot.AutoSize = true;
            this.lblGoldSpot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGoldSpot.Location = new System.Drawing.Point(32, 10);
            this.lblGoldSpot.Name = "lblGoldSpot";
            this.lblGoldSpot.Size = new System.Drawing.Size(163, 28);
            this.lblGoldSpot.TabIndex = 2;
            this.lblGoldSpot.Text = "Gold Spot Price:";
            // 
            // cboMarkup
            // 
            this.cboMarkup.FormattingEnabled = true;
            this.cboMarkup.Items.AddRange(new object[] {
            "200%",
            "300%",
            "400%",
            "500%",
            "600%",
            "700%",
            "800%"});
            this.cboMarkup.Location = new System.Drawing.Point(32, 85);
            this.cboMarkup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMarkup.Name = "cboMarkup";
            this.cboMarkup.Size = new System.Drawing.Size(149, 24);
            this.cboMarkup.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Markup %:";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(14, 419);
            this.cmdCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(85, 31);
            this.cmdCalculate.TabIndex = 7;
            this.cmdCalculate.Text = "&Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(115, 419);
            this.cmdPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(85, 31);
            this.cmdPrint.TabIndex = 8;
            this.cmdPrint.Text = "&Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl8k, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl24k, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl22k, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl18k, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl14k, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl12k, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl10k, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 299);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(26, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "8k";
            // 
            // lbl8k
            // 
            this.lbl8k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl8k.AutoSize = true;
            this.lbl8k.Location = new System.Drawing.Point(107, 271);
            this.lbl8k.Name = "lbl8k";
            this.lbl8k.Size = new System.Drawing.Size(51, 16);
            this.lbl8k.TabIndex = 15;
            this.lbl8k.Text = "label14";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "24k";
            // 
            // lbl24k
            // 
            this.lbl24k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl24k.AutoSize = true;
            this.lbl24k.Location = new System.Drawing.Point(110, 13);
            this.lbl24k.Name = "lbl24k";
            this.lbl24k.Size = new System.Drawing.Size(44, 16);
            this.lbl24k.TabIndex = 4;
            this.lbl24k.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "22k";
            // 
            // lbl22k
            // 
            this.lbl22k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl22k.AutoSize = true;
            this.lbl22k.Location = new System.Drawing.Point(110, 56);
            this.lbl22k.Name = "lbl22k";
            this.lbl22k.Size = new System.Drawing.Size(44, 16);
            this.lbl22k.TabIndex = 6;
            this.lbl22k.Text = "label5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "18k";
            // 
            // lbl18k
            // 
            this.lbl18k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl18k.AutoSize = true;
            this.lbl18k.Location = new System.Drawing.Point(110, 99);
            this.lbl18k.Name = "lbl18k";
            this.lbl18k.Size = new System.Drawing.Size(44, 16);
            this.lbl18k.TabIndex = 8;
            this.lbl18k.Text = "label7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "14k";
            // 
            // lbl14k
            // 
            this.lbl14k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl14k.AutoSize = true;
            this.lbl14k.Location = new System.Drawing.Point(110, 142);
            this.lbl14k.Name = "lbl14k";
            this.lbl14k.Size = new System.Drawing.Size(44, 16);
            this.lbl14k.TabIndex = 10;
            this.lbl14k.Text = "label9";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(22, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "12k";
            // 
            // lbl12k
            // 
            this.lbl12k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl12k.AutoSize = true;
            this.lbl12k.Location = new System.Drawing.Point(107, 185);
            this.lbl12k.Name = "lbl12k";
            this.lbl12k.Size = new System.Drawing.Size(51, 16);
            this.lbl12k.TabIndex = 12;
            this.lbl12k.Text = "label11";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(22, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "10k";
            // 
            // lbl10k
            // 
            this.lbl10k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl10k.AutoSize = true;
            this.lbl10k.Location = new System.Drawing.Point(107, 228);
            this.lbl10k.Name = "lbl10k";
            this.lbl10k.Size = new System.Drawing.Size(51, 16);
            this.lbl10k.TabIndex = 14;
            this.lbl10k.Text = "label13";
            // 
            // PricingGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMarkup);
            this.Controls.Add(this.txtGoldSpot);
            this.Controls.Add(this.lblGoldSpot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PricingGuide";
            this.Text = "PricingGuide";
            this.Load += new System.EventHandler(this.PricingGuide_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoldSpot;
        private System.Windows.Forms.Label lblGoldSpot;
        private System.Windows.Forms.ComboBox cboMarkup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdPrint;
      // private LPS_GOLD.dbGold dbGold1;
        //private System.Windows.Forms.BindingSource bindingSource1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dbDateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn goldSpotDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn goldSpotGramDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn kDataGridViewTextBoxColumn6;
        //private System.Windows.Forms.BindingSource goldPriceTableBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl8k;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl24k;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl22k;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl18k;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl14k;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl12k;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl10k;
    }
}