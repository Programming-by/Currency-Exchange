using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float USDollarRate = 1.000000f;
        float EgyptionPoundRate = 24.591999f;
        float JordainanDinarRate = 0.708000f;


        float ConvertToUSD(float Amount, float Rate)
        {
            return (float)(Amount / Rate);
        }

        public float GetCurrencyRate()
        {
            if (cbFirstCurrency.SelectedItem == "US Dollar")
            {
                return USDollarRate;
            }
          
            if (cbFirstCurrency.SelectedItem == "Egyption Pound")
            {
                return EgyptionPoundRate;
            }
            return JordainanDinarRate;
        }


        public float ConvertToOtherCurrency(float Amount)
        {

            float CurrencyRate = GetCurrencyRate();

            float AmountInUSD = ConvertToUSD(Amount,CurrencyRate);


            if (cbSecondCurrency.SelectedItem == "US Dollar") 
            {
                return AmountInUSD;
            }

            if (cbSecondCurrency.SelectedItem == "Egyption Pound")
            {
                return (float)(AmountInUSD * EgyptionPoundRate);

            }
            return (float)(AmountInUSD * JordainanDinarRate);

        }


   

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text ==  "")
            {
                MessageBox.Show("Please Enter Amount you want to exchange" , "Error Message" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (cbFirstCurrency.SelectedItem == cbSecondCurrency.SelectedItem)
            {
             
                MessageBox.Show("You can't enter the same Currency", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblMoneyAfterConvert.Text = ConvertToOtherCurrency(Convert.ToSingle(txtAmount.Text)) + " " + cbSecondCurrency.Text;
            lblMoneyAfterConvert.Visible = true;

        }
    }
}
