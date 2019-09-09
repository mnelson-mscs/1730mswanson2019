using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KoreaTextChanged(object sender, EventArgs e)
        {
            txtUSDKorea.Text = (
                Convert.ToDecimal(txtAmountKorea.Text) * Convert.ToDecimal(txtRateKorea.Text)
            ).ToString("0.00");
        }

        private void ChinaTextChange(object sender, EventArgs e)
        {
            txtUSDChina.Text = (
                Convert.ToDecimal(txtAmountChina.Text) * Convert.ToDecimal(txtRateChina.Text)
            ).ToString("0.00");
        }

        private void GermanyTextChange(object sender, EventArgs e)
        {
            txtUSDGermany.Text = (
                Convert.ToDecimal(txtAmountGermany.Text) * Convert.ToDecimal(txtRateGermany.Text)
            ).ToString("0.00");
        }

        private void CanadaTextChange(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
            ).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDKorea.Text) + Convert.ToDecimal(txtUSDChina.Text) + Convert.ToDecimal(txtUSDGermany.Text) + Convert.ToDecimal(txtUSDCanada.Text)
            ).ToString("0.00");
        }

        private void btnExitClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnResetClick(object sender, MouseEventArgs e)
        {
            txtAmountKorea.Text = "0.00";
            txtRateKorea.Text = "0.000838265";

            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.140409";

            txtAmountGermany.Text = "0.00";
            txtRateGermany.Text = "1.10504";

            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.759905";
        }
    }
}
