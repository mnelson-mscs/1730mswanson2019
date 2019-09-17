using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swanson1f1
{
    public partial class FormCurrency : Form
    {
        public FormCurrency()
        {
            InitializeComponent();
        }

        private void FormCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChina2.Image;
            btnKorea.BackgroundImage = picKorea2.Image;
            btnGermany.BackgroundImage = picGermany2.Image;

            txtInput.Select();
            txtRate.Text = 0.754662m.ToString();
            lblCurrency.Text = btnCanada.Text + ":";
        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChina2.Image;
            btnKorea.BackgroundImage = picKorea2.Image;
            btnGermany.BackgroundImage = picGermany2.Image;

            txtRate.Text = (0.754662m).ToString();

            lblCurrency.Text = btnCanada.Text + ":";

            txtInput.Focus();
        }

        private void BtnChina_Click(object sender, EventArgs e)
        {
            btnChina.BackgroundImage = picChina.Image;
            btnCanada.BackgroundImage = picCanada2.Image;
            btnKorea.BackgroundImage = picKorea2.Image;
            btnGermany.BackgroundImage = picGermany2.Image;

            txtRate.Text = (0.141307).ToString();

            lblCurrency.Text = btnChina.Text + ":";

            txtInput.Focus();
        }

        private void BtnKorea_Click(object sender, EventArgs e)
        {
            btnKorea.BackgroundImage = picKorea.Image;
            btnChina.BackgroundImage = picChina2.Image;
            btnCanada.BackgroundImage = picCanada2.Image;
            btnGermany.BackgroundImage = picGermany2.Image;

            txtRate.Text = (0.000841570).ToString();

            lblCurrency.Text = btnKorea.Text + ":";

            txtInput.Focus();
        }

        private void BtnGermany_Click(object sender, EventArgs e)
        {
            btnGermany.BackgroundImage = picGermany.Image;
            btnChina.BackgroundImage = picChina2.Image;
            btnKorea.BackgroundImage = picKorea2.Image;
            btnCanada.BackgroundImage = picCanada2.Image;

            txtRate.Text = (1.10122).ToString();

            lblCurrency.Text = btnGermany.Text + ":";

            txtInput.Focus();
        }

        private void txtChange(object sender, EventArgs e)
        {
            txtDollars.Text = (
                Convert.ToDecimal(txtInput.Text) * Convert.ToDecimal(txtRate.Text)
            ).ToString("0.00");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (
                Convert.ToDecimal(txtDollars.Text) + Convert.ToDecimal(txtTotal.Text)
            ).ToString("0.00");

            lblEquation.Text = lblEquation.Text + " + " + txtTotal.Text;

            txtInput.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0.00";
            txtDollars.Text = "0.00";
            txtTotal.Text = "0.00";

            btnCanada.BackgroundImage = picCanada.Image;
            btnChina.BackgroundImage = picChina2.Image;
            btnKorea.BackgroundImage = picKorea2.Image;
            btnGermany.BackgroundImage = picGermany2.Image;
            txtRate.Text = (0.754662m).ToString();

            lblCurrency.Text = btnCanada.Text + ":";

            lblEquation.Text = "";
            txtInput.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtInput_Enter(object sender, EventArgs e)
        {
            txtInput.SelectAll();
        }
    }
}
