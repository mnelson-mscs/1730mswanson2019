using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mswanson2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                ethereum = Decimal.Parse(input) * 200;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal price = 0m;
            decimal quantity = 0m;
            decimal shipping = 5m;
            decimal subtotal = 0m;

            if (inputA != "" && inputB != "")
            {
                price = Decimal.Parse(inputA);
                quantity = Decimal.Parse(inputB);
                subtotal = price * quantity;

                if (subtotal >= 50)
                {
                    return subtotal.ToString("n2");
                }
                return (subtotal + shipping).ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            Int32 month1 = 0;
            Int32 month2 = 0;
            Int32 currentMonth = 0;
            decimal kWh = 0.1m;
            decimal subtotal = 0m;

            if (inputA != "" && inputB != "" && Decimal.Parse(inputB) >= Decimal.Parse(inputA))
            {
                month1 = Int32.Parse(inputA);
                month2 = Int32.Parse(inputB);

                currentMonth = month2 - month1;
                subtotal = currentMonth * kWh;

                return (subtotal).ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal a = 0m;
            decimal b = 0m;
            decimal result = 0m;

            if (inputA != "" && inputB != "" && Decimal.Parse(inputA) > 0 && Decimal.Parse(inputB) > 0)
            {
                a = Decimal.Parse(inputA);
                b = Decimal.Parse(inputB);
                if (a >= b)
                {
                    result = a / b;
                    return result.ToString("n2");
                }
                else if (a < b)
                {
                    result = b / a;
                    return result.ToString("n2");
                }
            }
            return "Invalid input";
        }
    }
}
