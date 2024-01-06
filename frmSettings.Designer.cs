namespace LPS_Utility
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.txtGoldWebsite = new System.Windows.Forms.TextBox();
            this.txtGoldNode = new System.Windows.Forms.TextBox();
            this.txtSilverWebsite = new System.Windows.Forms.TextBox();
            this.txtSilverNode = new System.Windows.Forms.TextBox();
            this.lblGoldWebsite = new System.Windows.Forms.Label();
            this.lblGoldNode = new System.Windows.Forms.Label();
            this.lblSilverNode = new System.Windows.Forms.Label();
            this.lblSilverWebsite = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGoldWebsite
            // 
            this.txtGoldWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoldWebsite.Location = new System.Drawing.Point(310, 36);
            this.txtGoldWebsite.Name = "txtGoldWebsite";
            this.txtGoldWebsite.Size = new System.Drawing.Size(740, 30);
            this.txtGoldWebsite.TabIndex = 0;
            // 
            // txtGoldNode
            // 
            this.txtGoldNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoldNode.Location = new System.Drawing.Point(310, 83);
            this.txtGoldNode.Name = "txtGoldNode";
            this.txtGoldNode.Size = new System.Drawing.Size(740, 30);
            this.txtGoldNode.TabIndex = 1;
            // 
            // txtSilverWebsite
            // 
            this.txtSilverWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSilverWebsite.Location = new System.Drawing.Point(310, 130);
            this.txtSilverWebsite.Name = "txtSilverWebsite";
            this.txtSilverWebsite.Size = new System.Drawing.Size(740, 30);
            this.txtSilverWebsite.TabIndex = 2;
            // 
            // txtSilverNode
            // 
            this.txtSilverNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSilverNode.Location = new System.Drawing.Point(310, 177);
            this.txtSilverNode.Name = "txtSilverNode";
            this.txtSilverNode.Size = new System.Drawing.Size(740, 30);
            this.txtSilverNode.TabIndex = 3;
            // 
            // lblGoldWebsite
            // 
            this.lblGoldWebsite.AutoSize = true;
            this.lblGoldWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldWebsite.Location = new System.Drawing.Point(43, 36);
            this.lblGoldWebsite.Name = "lblGoldWebsite";
            this.lblGoldWebsite.Size = new System.Drawing.Size(223, 25);
            this.lblGoldWebsite.TabIndex = 4;
            this.lblGoldWebsite.Text = "Gold Website Setting:";
            // 
            // lblGoldNode
            // 
            this.lblGoldNode.AutoSize = true;
            this.lblGoldNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldNode.Location = new System.Drawing.Point(21, 83);
            this.lblGoldNode.Name = "lblGoldNode";
            this.lblGoldNode.Size = new System.Drawing.Size(245, 25);
            this.lblGoldNode.TabIndex = 5;
            this.lblGoldNode.Text = "Gold Node Path Setting:";
            // 
            // lblSilverNode
            // 
            this.lblSilverNode.AutoSize = true;
            this.lblSilverNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilverNode.Location = new System.Drawing.Point(11, 177);
            this.lblSilverNode.Name = "lblSilverNode";
            this.lblSilverNode.Size = new System.Drawing.Size(255, 25);
            this.lblSilverNode.TabIndex = 6;
            this.lblSilverNode.Text = "Silver Node Path Setting:";
            this.lblSilverNode.Click += new System.EventHandler(this.lblSilverNode_Click);
            // 
            // lblSilverWebsite
            // 
            this.lblSilverWebsite.AutoSize = true;
            this.lblSilverWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilverWebsite.Location = new System.Drawing.Point(33, 130);
            this.lblSilverWebsite.Name = "lblSilverWebsite";
            this.lblSilverWebsite.Size = new System.Drawing.Size(233, 25);
            this.lblSilverWebsite.TabIndex = 7;
            this.lblSilverWebsite.Text = "Silver Website Setting:";
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(310, 222);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(263, 79);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 337);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblSilverWebsite);
            this.Controls.Add(this.lblSilverNode);
            this.Controls.Add(this.lblGoldNode);
            this.Controls.Add(this.lblGoldWebsite);
            this.Controls.Add(this.txtSilverNode);
            this.Controls.Add(this.txtSilverWebsite);
            this.Controls.Add(this.txtGoldNode);
            this.Controls.Add(this.txtGoldWebsite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoldWebsite;
        private System.Windows.Forms.TextBox txtGoldNode;
        private System.Windows.Forms.TextBox txtSilverWebsite;
        private System.Windows.Forms.TextBox txtSilverNode;
        private System.Windows.Forms.Label lblGoldWebsite;
        private System.Windows.Forms.Label lblGoldNode;
        private System.Windows.Forms.Label lblSilverNode;
        private System.Windows.Forms.Label lblSilverWebsite;
        private System.Windows.Forms.Button cmdSave;
    }
}