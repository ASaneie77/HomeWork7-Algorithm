using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task1
    {
        public static int NumOfDigits(int number)
        {
            int digit = 1;

            if (number < 0)
                throw new ArgumentException("Input nubmber is invalid!");

            for (int i = number/10; i > 0; i = number / 10)
            {
                digit++;

                number = i;
            }

            return digit;

        }
    }
}
