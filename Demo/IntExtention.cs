using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal static class IntExtention
    {
        public static int Reverse(this int Number) // 1234
        {
            int ReversedNumber = 0;
            if (Number == 0) return 0;
            while (Number != 0)
            {
                ReversedNumber *= 10;
                ReversedNumber += Number % 10;
                Number = Number / 10;
            }

            return ReversedNumber;
        }
        public static long Reverse(this long Number) // 1234
        {
            long ReversedNumber = 0;
            if (Number == 0) return 0;
            while (Number != 0)
            {
                ReversedNumber *= 10;
                ReversedNumber += Number % 10;
                Number = Number / 10;
            }

            return ReversedNumber;
        }
        private static int GetLength(this int number)
        {
            int length = 0;
            if (number == 0) return length = 1;
            int temp = number;
            while (temp <= 0)
            {
                temp = temp / 10;
                length++;
            }
            return length;
        }
    }
}
