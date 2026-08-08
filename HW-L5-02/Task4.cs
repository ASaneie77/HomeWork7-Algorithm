using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task4
    {
        public static bool PalindromNumber(int number)
        {
            List<int> digits = new List<int>();

            if (number < 0)
                throw new ArgumentException("Input nubmber is invalid!");

            for (int digit = number % 10; digit > 0; digit = number % 10)
            {
                digits.Add(digit);

                number = number / 10;
            }

            for(int i = 0; i < digits.Count / 2; i++)
            {
                if (digits[i] != digits[digits.Count - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
