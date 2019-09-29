using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variableTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotDogsSubtotal.Text = (
            //        Convert.ToDecimal(txtHotDogs.Text) * 4.0m
            //    ).ToString("0.00");
            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.0m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotDogsSubtotal.Text = hotDogSubtotal.ToString("n2");

            //txtHamburgersSubtotal.Text = (
            //        Convert.ToDecimal(txtHamburgers.Text) * 5.0m
            //    ).ToString("0.00");
            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal hamburgerSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubtotal.Text = hamburgerSubtotal.ToString("n2");

            //txtPretaxTotal.Text = (
            //        Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //    ).ToString("0.00");
            decimal pretaxTotal = hotDogSubtotal + hamburgerSubtotal;
            txtPretaxTotal.Text = pretaxTotal.ToString("n2");

            //txtTax.Text = (
            //        Convert.ToDecimal(txtPretaxTotal.Text) * 0.06875m
            //    ).ToString("0.00");
            decimal tax = pretaxTotal * 0.06875m;
            txtTax.Text = tax.ToString("n2");

            //txtTotal.Text = (
            //        Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //    ).ToString("0.00");
            //btnClear.Focus();
            decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("n2");
            btnClear.Focus();
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
