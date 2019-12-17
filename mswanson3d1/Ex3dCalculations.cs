﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mswanson3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result
            StringBuilder sbResult = new StringBuilder(200);

            foreach (int number in values)
            {
                sbResult.Append(number.ToString());
                sbResult.Append(", ");
            }

            string result = sbResult.ToString();
            result = result.Remove(result.Length -2, 2);

            return result;
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter
            int count = 0;

            foreach (int number in values)
            {
                if (number == searchValue)
                count++;
            }

            return count;
        }

        internal static string ValueCount()
        {
            throw new NotImplementedException();
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;

            foreach (int number in values)
            {
                if (number >= searchMin && number <= searchMax)
                    count++;
            }

            return count;
        }
    }
}
