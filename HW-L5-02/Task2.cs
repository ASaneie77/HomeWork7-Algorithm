using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task2
    {
        public static bool CheckPrimeNumber(int n)
        {
            if (n < 2) return false;

            if ((n == 2) || (n == 3)) return true;

            // don't check even numbers in loop
            if ((n % 2 == 0)) return false;

            // Check odd numbers only, except 1 and n.
            for (int i = 3; i < n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
