using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace mswanson2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            try
            {
                DateTime dateA = DateTime.Parse(strDateA);
                DateTime dateB = DateTime.Parse(strDateB);
                TimeSpan difference = dateA - dateB;
                result = difference.Days.ToString() + " days";
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";

            try
            {
                DateTime dateReceived = DateTime.Parse(strDateA);
                DateTime dateDue = DateTime.Parse(strDateB);
                TimeSpan difference = dateReceived - dateDue;
                result = difference.Days.ToString();

                if (dateReceived > dateDue)
                    result = difference.Days.ToString() + " days past due";
                else result = "On time";
            }
            catch { }

            return result;
        }

        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();
            try
            {
                charA = charA.Remove(0, 1);
                charA = charA.Insert(0, "cr");
                result = charA;
            }
            catch { }

            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();
            try
            {
                charA = charA.Remove(1, 1);
                charA = charA.Insert(1, "rit");
                result = charA;
            }
            catch { }

            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();

            try
            {
                charA = charA.Substring(2, 4).ToUpper();
                result = charA;
            }
            catch { }

            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();

            try
            {
                charA = charA.PadLeft(10, '*');
                result = charA;
            }
            catch { }

            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            StringBuilder charA = new StringBuilder(20);
            charA.Append(s);

            try
            {
                charA.Replace('(', ' ');
                charA.Replace(')', ' ');
                charA.Replace('-', ' ');
                charA.Replace(" ", String.Empty);
                result = charA.ToString();
            }
            catch { }

            return result;
        }

        public static string StringCalc06(string s)
        {
            string result = "Invalid input";

            StringBuilder charA = new StringBuilder(20);
            charA.Append(s);

            try
            {
                charA.Replace('(', ' ');
                charA.Replace(')', ' ');
                charA.Replace('-', ' ');
                charA.Replace(" ", String.Empty);


                if (charA.Length == 10)
                {
                    charA = charA.Insert(3, '.');
                    charA = charA.Insert(7, '.');
                    result = charA.ToString();
                }
                else if (charA.Length == 7)
                {
                    charA = charA.Insert(3, '.');
                    result = charA.ToString();
                }
                else
                {
                    
                }
            }
            catch { }

            return result;
        }

        public static string StringCalc07(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim().ToLower();

            try
            {
                int a = 1;
                string b = "b";

                if (charA.Contains('p'))
                {
                    a = charA.IndexOf("p");

                    if (charA.Contains("pioneer"))
                    {
                        b = charA.Substring(a, 7);
                    }
                }

                if (b == "pioneer")
                    result = "Found";
                else
                    result = "Not found";
            }
            catch { }

            return result;
        }

        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();

                try
            {
                int a = charA.IndexOf(", ");
                string d = charA.Substring(a, 2);

                if (d == ", ")
                    a = a + 2;
                    int c = charA.Length - a;
                    string b = charA.Substring(a, c);

                    result = b;
                }
                catch { }

            return result;
        }

        public static string StringCalc09(string s)
        {
            string result = "Invalid input";
            string charA = s.Trim();

            try
            {
                int a = charA.LastIndexOf(' ');
                int b = charA.Length - a;
                result = charA.Substring(a, b).Trim();
            }
            catch { }

            return result;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1).Append(", ").Append(s2).Append(", ").Append(s3);
            return sb.ToString();
        }
    }
}