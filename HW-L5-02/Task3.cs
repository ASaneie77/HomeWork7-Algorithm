using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_L5_02
{
    public class Task3
    {
        public static int SumDigits(int number)
        {
            int digit = 0;

            if (number < 0)
                throw new ArgumentException("Input nubmber is invalid!");

            for (int i = number % 10; i > 0; i = number % 10)
            {
                digit += i;

                number = number / 10;
            }

            return digit;
        }
    }
}
