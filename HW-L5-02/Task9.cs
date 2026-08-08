using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task9
    {
        public static bool CheckRepeatedNumber(int[] numbers)
        {
            HashSet<int> result = new HashSet<int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                result.Add(numbers[i]);
            }

            if(result.Count < numbers.Length)
                return true;

            return false;
        }
    }
}
