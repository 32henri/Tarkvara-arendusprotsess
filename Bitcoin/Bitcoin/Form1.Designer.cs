namespace Bitcoin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.amountofbtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyCombo.Location = new System.Drawing.Point(90, 42);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 21);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(281, 40);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            // 
            // amountofbtc
            // 
            this.amountofbtc.Location = new System.Drawing.Point(90, 109);
            this.amountofbtc.Name = "amountofbtc";
            this.amountofbtc.Size = new System.Drawing.Size(100, 20);
            this.amountofbtc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of Bitcoins";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultLabel.Location = new System.Drawing.Point(87, 162);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(45, 16);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.Visible = false;
            this.ResultLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(90, 181);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(100, 20);
            this.resulttextBox.TabIndex = 5;
            this.resulttextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountofbtc);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox amountofbtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox resulttextBox;
    }
}

