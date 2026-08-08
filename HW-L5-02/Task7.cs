using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task7
    {
        public static string ConvertToBin(int in_num)
        {
            if (in_num < 0)
                throw new ArgumentException("Invalid Argument");

            if (in_num == 0)
                return "0";

            string binary = "";
            while (in_num > 0)
            {
                int remainder = in_num % 2;

                binary = remainder + binary;

                in_num /= 2;
            }
            return binary;
        }
    }
}
