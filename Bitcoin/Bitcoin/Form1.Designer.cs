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
            this.selectcurrency = new System.Windows.Forms.ComboBox();
            this.getratesnupp = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.amounttext = new System.Windows.Forms.Label();
            this.resulttext = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectcurrency
            // 
            this.selectcurrency.FormattingEnabled = true;
            this.selectcurrency.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.selectcurrency.Location = new System.Drawing.Point(90, 42);
            this.selectcurrency.Name = "selectcurrency";
            this.selectcurrency.Size = new System.Drawing.Size(121, 21);
            this.selectcurrency.TabIndex = 0;
            this.selectcurrency.Text = "Select Currency";
            // 
            // getratesnupp
            // 
            this.getratesnupp.Location = new System.Drawing.Point(281, 40);
            this.getratesnupp.Name = "getratesnupp";
            this.getratesnupp.Size = new System.Drawing.Size(75, 23);
            this.getratesnupp.TabIndex = 1;
            this.getratesnupp.Text = "Get Rates";
            this.getratesnupp.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(90, 109);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 2;
            // 
            // amounttext
            // 
            this.amounttext.AutoSize = true;
            this.amounttext.BackColor = System.Drawing.Color.Transparent;
            this.amounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.amounttext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amounttext.Location = new System.Drawing.Point(87, 90);
            this.amounttext.Name = "amounttext";
            this.amounttext.Size = new System.Drawing.Size(116, 16);
            this.amounttext.TabIndex = 3;
            this.amounttext.Text = "Amount of Bitcoins";
            // 
            // resulttext
            // 
            this.resulttext.AutoSize = true;
            this.resulttext.BackColor = System.Drawing.Color.Transparent;
            this.resulttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.resulttext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resulttext.Location = new System.Drawing.Point(87, 162);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(45, 16);
            this.resulttext.TabIndex = 4;
            this.resulttext.Text = "Result";
            this.resulttext.Click += new System.EventHandler(this.getratesnupp_Click_1);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(90, 181);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(100, 20);
            this.resultbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.amounttext);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getratesnupp);
            this.Controls.Add(this.selectcurrency);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectcurrency;
        private System.Windows.Forms.Button getratesnupp;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label amounttext;
        private System.Windows.Forms.Label resulttext;
        private System.Windows.Forms.TextBox resultbox;
    }
}

