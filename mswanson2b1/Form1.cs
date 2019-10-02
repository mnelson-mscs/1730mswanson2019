using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountKorea = Convert.ToDecimal(txtAmountKorea.Text);
            decimal rateKorea = Convert.ToDecimal(txtRateKorea.Text);
            decimal usdKorea = amountKorea * rateKorea;
            txtUSDKorea.Text = (usdKorea).ToString("n2");

            decimal amountChina = Convert.ToDecimal(txtAmountChina.Text);
            decimal rateChina = Convert.ToDecimal(txtRateChina.Text);
            decimal usdChina = amountChina * rateChina;
            txtUSDChina.Text = (usdChina).ToString("n2");

            decimal amountGermany = Convert.ToDecimal(txtAmountGermany.Text);
            decimal rateGermany = Convert.ToDecimal(txtRateGermany.Text);
            decimal usdGermany = amountGermany * rateGermany;
            txtUSDGermany.Text = (usdGermany).ToString("n2");

            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal usdCanada = amountCanada * rateCanada;
            txtUSDCanada.Text = (usdCanada).ToString("n2");

            decimal totalUSD = usdKorea + usdChina + usdGermany + usdCanada;
            txtTotalUSD.Text = (totalUSD).ToString("n2");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountKorea.Text = "0.00";
            txtRateKorea.Text = "0.000838265";

            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.140409";

            txtAmountGermany.Text = "0.00";
            txtRateGermany.Text = "1.10504";

            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.759905";

            txtAmountKorea.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
