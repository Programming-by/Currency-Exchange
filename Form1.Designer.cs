namespace Currency_Exchange
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbFirstCurrency = new System.Windows.Forms.ComboBox();
            this.lblMoneyAfterConvert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSecondCurrency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(361, 227);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 77);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(341, 159);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 39);
            this.txtAmount.TabIndex = 2;
            // 
            // cbFirstCurrency
            // 
            this.cbFirstCurrency.FormattingEnabled = true;
            this.cbFirstCurrency.Items.AddRange(new object[] {
            "US Dollar",
            "Egyption Pound",
            "Jordanian Dinar"});
            this.cbFirstCurrency.Location = new System.Drawing.Point(202, 89);
            this.cbFirstCurrency.Name = "cbFirstCurrency";
            this.cbFirstCurrency.Size = new System.Drawing.Size(147, 24);
            this.cbFirstCurrency.TabIndex = 4;
            // 
            // lblMoneyAfterConvert
            // 
            this.lblMoneyAfterConvert.AutoSize = true;
            this.lblMoneyAfterConvert.Location = new System.Drawing.Point(399, 354);
            this.lblMoneyAfterConvert.Name = "lblMoneyAfterConvert";
            this.lblMoneyAfterConvert.Size = new System.Drawing.Size(14, 16);
            this.lblMoneyAfterConvert.TabIndex = 5;
            this.lblMoneyAfterConvert.Text = "0";
            this.lblMoneyAfterConvert.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // cbSecondCurrency
            // 
            this.cbSecondCurrency.FormattingEnabled = true;
            this.cbSecondCurrency.Items.AddRange(new object[] {
            "US Dollar",
            "Egyption Pound",
            "Jordanian Dinar"});
            this.cbSecondCurrency.Location = new System.Drawing.Point(470, 89);
            this.cbSecondCurrency.Name = "cbSecondCurrency";
            this.cbSecondCurrency.Size = new System.Drawing.Size(147, 24);
            this.cbSecondCurrency.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSecondCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoneyAfterConvert);
            this.Controls.Add(this.cbFirstCurrency);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbFirstCurrency;
        private System.Windows.Forms.Label lblMoneyAfterConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSecondCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

