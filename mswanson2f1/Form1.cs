using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1: if
            //subtotal = Decimal.Parse(input1aTextBox.Text);
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //result1TextBox.Text = discountPercent.ToString("n2");
            result1TextBox.Text = Ex2fCalculations.Calc01(input1aTextBox.Text);

            // #2: if {block}
            //subtotal = Decimal.Parse(input2aTextBox.Text);
            //discountPercent = 0m;
            //string status = "Standard rate: ";
            //if (subtotal >= 100)
            //{
            //    discountPercent = 0.2m;
            //    status = "Bulk rate: ";
            //}
            //result2TextBox.Text = status + discountPercent.ToString("n2");
            result2TextBox.Text = Ex2fCalculations.Calc02(input2aTextBox.Text);

            // #3: if else
            //subtotal = Decimal.Parse(input3aTextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result3TextBox.Text = discountPercent.ToString("n2");
            result3TextBox.Text = Ex2fCalculations.Calc03(input3aTextBox.Text);

            // #4: if else if
            //subtotal = Decimal.Parse(input4aTextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 100m && subtotal < 200)
            //    discountPercent = 0.2m;
            //else if (subtotal >= 200m && subtotal < 300)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else
            //    discountPercent = 0.1m;
            //result4TextBox.Text = discountPercent.ToString("n2");
            result4TextBox.Text = Ex2fCalculations.Calc04(input4aTextBox.Text);

            // #5: Better range test
            //subtotal = Decimal.Parse(input5aTextBox.Text);
            //discountPercent = 0m;
            //if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else if (subtotal >= 200m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result5TextBox.Text = discountPercent.ToString("n2");
            result5TextBox.Text = Ex2fCalculations.Calc05(input5aTextBox.Text);

            // #6: Nested if statements
            //subtotal = Decimal.Parse(input6aTextBox.Text);
            //string customerType = input6bTextBox.Text;
            //discountPercent = 0m;
            //if (customerType == "R")
            //{
            //    if (subtotal >= 100m)
            //        discountPercent = 0.2m;
            //    else
            //        discountPercent = 0.1m;
            //}
            //else
            //    discountPercent = 0.4m;
            //result6TextBox.Text = discountPercent.ToString("n2");
            result6TextBox.Text = Ex2fCalculations.Calc06(input6aTextBox.Text, input6bTextBox.Text);

            // #7: Input Validation
            result7TextBox.Text = Ex2fCalculations.Calc07(input7aTextBox.Text);

            // #8: input validation, calculate total and shipping
            result8TextBox.Text = Ex2fCalculations.Calc08(input8aTextBox.Text, input8bTextBox.Text);

            // #9: input validation, result = 0.1 * difference
            result9TextBox.Text = Ex2fCalculations.Calc09(input9aTextBox.Text, input9bTextBox.Text);

            // #10 Validate input, divide large num by small
            result10TextBox.Text = Ex2fCalculations.Calc10(input10aTextBox.Text, input10bTextBox.Text);
        }
    }
}
