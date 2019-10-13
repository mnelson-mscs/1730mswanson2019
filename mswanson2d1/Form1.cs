using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSetPass_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5aInput.Text = "2";
            textBox5bInput.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8aInput.Text = "1";
            textBox8bInput.Text = "2";
            textBox9Input.Text = "500";
            textBox10aInput.Text = "3";
            textBox10bInput.Text = "3";
        }

        private void BtnSetFail_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5aInput.Text = "2";
            textBox5bInput.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8aInput.Text = "1";
            textBox8bInput.Text = "1";
            textBox9Input.Text = "499";
            textBox10aInput.Text = "4";
            textBox10bInput.Text = "3";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            textBox1aResult.Text = "Fail";
            textBox2aResult.Text = "Fail";
            textBox3aResult.Text = "Fail";
            textBox4aResult.Text = "Fail";
            textBox5aResult.Text = "Fail";
            textBox6aResult.Text = "Fail";
            textBox7aResult.Text = "Fail";
            textBox8aResult.Text = "Fail";
            textBox9aResult.Text = "Fail";
            textBox10aResult.Text = "Fail";

            textBox1bResult.Text = "Success";
            textBox2bResult.Text = "Success";
            textBox3bResult.Text = "Success";
            textBox4bResult.Text = "Success";
            textBox5bResult.Text = "Success";
            textBox6bResult.Text = "Success";
            textBox7bResult.Text = "Success";
            textBox8bResult.Text = "Success";
            textBox9bResult.Text = "Success";
            textBox10bResult.Text = "Success";

            if (textBox1Input.Text == "Frank")
                textBox1aResult.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1bResult.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2aResult.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2bResult.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3aResult.Text = "Success";
            if (val3 != 2.3m)
                textBox3bResult.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4aResult.Text = "Success";
            if (val4 != false)
                textBox4bResult.Text = "Fail";

            int val5a = Convert.ToInt32(textBox5aInput.Text);
            int val5b = Convert.ToInt32(textBox5bInput.Text);
            if (val5a == val5b)
                textBox5aResult.Text = "Success";
            if (val5a != val5b)
                textBox5bResult.Text = "Fail";

            if (textBox6Input.Text != "Jones")
                textBox6aResult.Text = "Success";
            if (textBox6Input.Text == "Jones")
                textBox6bResult.Text = "Fail";

            int val7 = Convert.ToInt32(textBox7Input.Text);
            if (val7 > 0)
                textBox7aResult.Text = "Success";
            if (val7 <= 0)
                textBox7bResult.Text = "Fail";

            int val8a = Convert.ToInt32(textBox8aInput.Text);
            int val8b = Convert.ToInt32(textBox8bInput.Text);
            if (val8a < val8b) 
                textBox8aResult.Text = "Success";
            if (val8a >= val8b)
                textBox8bResult.Text = "Fail";

            int val9 = Convert.ToInt32(textBox9Input.Text);
            if (val9 >= 500)
                textBox9aResult.Text = "Success";
            if (val9 < 500)
                textBox9bResult.Text = "Fail";

            int val10a = Convert.ToInt32(textBox10aInput.Text);
            int val10b = Convert.ToInt32(textBox10bInput.Text);
            if (val10a <= val10b)
                textBox10aResult.Text = "Success";
            if (val10a > val10b)
                textBox10bResult.Text = "Fail";
        }
    }
}
