﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            result1TextBox.Text = "";
            result2TextBox.Text = "";
            result3aTextBox.Text = "";
            result3bTextBox.Text = "";
            result4aTextBox.Text = "";
            result4bTextBox.Text = "";
            result5aTextBox.Text = "";
            result5bTextBox.Text = "";
            result6aTextBox.Text = "";
            result6bTextBox.Text = "";
            result7aTextBox.Text = "";
            result8aTextBox.Text = "";
            result9aTextBox.Text = "";
            result9bTextBox.Text = "";
            result10aTextBox.Text = "";

            // 01
            decimal subtotal = Convert.ToDecimal(input1TextBox.Text);
            result1TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // 02
            int timeInService = Convert.ToInt32(input2TextBox.Text);
            result2TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            // 03 - 06 initialization
            bool isValid = Convert.ToBoolean(input3aTextBox.Text);
            int years = Convert.ToInt32(input3cTextBox.Text);

            // 03
            int counter = Convert.ToInt32(input3bTextBox.Text);
            result3aTextBox.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            result3bTextBox.Text = counter.ToString();

            // 04
            counter = Convert.ToInt32(input3bTextBox.Text);
            result4aTextBox.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            result4bTextBox.Text = counter.ToString();

            // 05
            counter = Convert.ToInt32(input3bTextBox.Text);
            result5aTextBox.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            result5bTextBox.Text = counter.ToString();

            // 06
            counter = Convert.ToInt32(input3bTextBox.Text);
            result6aTextBox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            result6bTextBox.Text = counter.ToString();

            // 07
            DateTime startDate = Convert.ToDateTime(input7aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input7bTextBox.Text);
            DateTime date = Convert.ToDateTime(input7cTextBox.Text);
            isValid = Convert.ToBoolean(input7dTextBox.Text);
            result7aTextBox.Text = (LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString();

            // 08
            decimal thisYTD = Convert.ToDecimal(input8aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input8bTextBox.Text);
            string empType = input8cTextBox.Text;
            int startYear = Convert.ToInt32(input8dTextBox.Text);
            int currentYear = Convert.ToInt32(input8eTextBox.Text);
            result8aTextBox.Text = (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)).ToString();

            // 09
            counter = Convert.ToInt32(input9aTextBox.Text);
            years = Convert.ToInt32(input9bTextBox.Text);
            result9aTextBox.Text = (LogicalOperations.q09(counter, years)).ToString();
            result9bTextBox.Text = counter.ToString();

            // 10
            int a = Convert.ToInt32(input10aTextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            result10aTextBox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();

            // 11
            bool member = Convert.ToBoolean(input11aTextBox.Text);
            decimal price = Convert.ToDecimal(input11bTextBox.Text);
            float weight = Convert.ToSingle(input11cTextBox.Text);
            result11TextBox.Text = (LogicalOperations.q11(member, price, weight)).ToString();

            // 12
            member = Convert.ToBoolean(input12aTextBox.Text);
            price = Convert.ToDecimal(input12bTextBox.Text);
            weight = Convert.ToSingle(input12cTextBox.Text);
            result12TextBox.Text = (LogicalOperations.q12(member, price, weight)).ToString();

            // 13
            string shipState = input13aTextBox.Text;
            string itemType = input13bTextBox.Text;
            result13TextBox.Text = (LogicalOperations.q13(shipState, itemType)).ToString();
        }
    }
}
