using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mswanson3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string result = "";

            if (index == 1)
                result = days[0];
            else if (index == 2)
                result = days[1];
            else if (index == 3)
                result = days[2];
            else if (index == 4)
                result = days[3];
            else if (index == 5)
                result = days[4];
            else if (index == 6)
                result = days[5];
            else if (index == 7)
                result = days[6];
            else
                result = "Invalid index";

            return result;
        }

        public static string Calc1(string day)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            string result = "";
            int index = Array.IndexOf(days, day);
            if (index >= 0)
                result = hours[index];
            else
                result = "Invalid input";
            

            //for (int i = 0; i < days.Length; i++)
            //{
            //    if (day == days[i])
            //    {
            //        result = hours[i];
            //    }
            //}

            return result;
        }

        public static int Calc2(int[] x)
        {
            int sum = 0;
            foreach (int total in x)
                sum += total;
            int average = sum / x.Length;

            return sum;

        }
        public static double Calc3(double[] x, int y)
        {
            double result = 0.0;
            return result;
        }
        public static double Calc5(double[] x)
        {
            double result = 0.0;
            return result;
        }

        public static double[] Calc6(double[] x)
        {
            return new double[10];
        }
    }
}
