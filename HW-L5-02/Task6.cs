using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task6
    {
        public static int ReverseNumber(int in_num)
        {
            List<int> int_nums = new List<int>();
            int number = in_num;
            int reverse_number = 0;

            for (int div = number % 10; div > 0; div = number % 10)
            {
                int_nums.Add(div);

                number = number / 10;
            }

            for (int i = int_nums.Count(); i > 0; i--)
            {
                reverse_number += int_nums[int_nums.Count() - i] * (int)Math.Pow(10, i - 1);
            }

            return reverse_number;
        }
    }
}
