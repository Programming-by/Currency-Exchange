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

        decimal USDollarRate = 1.000000m;
        decimal EgyptianPoundRate = 24.591999m;
        decimal JordanianDinarRate = 0.708000m;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbFirstCurrency.SelectedIndex = 0;
            cbSecondCurrency.SelectedIndex = 1;
        }
        public decimal GetCurrencyRate(int CurrencyIndex)
        {
            decimal[] CurrencyRate = { USDollarRate , EgyptianPoundRate, JordanianDinarRate };
           
            return CurrencyRate[CurrencyIndex];
        }
        decimal ConvertToUSD(decimal Amount, decimal Rate)
        {
            return (Amount / Rate);
        }
        public decimal ConvertToOtherCurrency(decimal Amount)
        {
            decimal CurrencyRate = GetCurrencyRate(cbFirstCurrency.SelectedIndex);

            decimal AmountInUSD = ConvertToUSD(Amount,CurrencyRate);

            switch (cbSecondCurrency.Text)
            {
                case "US Dollar":
                    return Math.Round(AmountInUSD,2);
                case "Egyptian Pound":
                    return Math.Round(AmountInUSD * EgyptianPoundRate,2);
                case "Jordanian Dinar":
                    return Math.Round(AmountInUSD * JordanianDinarRate,2);
                default:
                    return AmountInUSD;
            }
        }
        public void SwitchCurrency()
        {
            string tmp = cbFirstCurrency.Text.ToString();
            cbFirstCurrency.Text = cbSecondCurrency.Text;
            cbSecondCurrency.Text = tmp;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please Enter Amount you want to exchange" , "Error Message" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbFirstCurrency.Text == cbSecondCurrency.Text)
            {
                MessageBox.Show("You can't enter the same Currency", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtAmount.Text.StartsWith("."))
            {
                MessageBox.Show("Please enter A Digit", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal Amount = Convert.ToDecimal(txtAmount.Text);
            lblMoneyAfterConvert.Text = ConvertToOtherCurrency(Amount) + " " + cbSecondCurrency.Text;
            lblMoneyAfterConvert.Visible = true;
        }
        private void btnSwitchCurrency_Click(object sender, EventArgs e)
        {
            SwitchCurrency();
            lblMoneyAfterConvert.Visible = false;
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
    }
}
