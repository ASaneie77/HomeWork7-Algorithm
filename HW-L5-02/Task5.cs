using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task5
    {
        public static int FindGdc(int num1, int num2)
        {
            int gdc = 1;

            HashSet<int> divisor1 = new HashSet<int>();
            HashSet<int> divisor2 = new HashSet<int>();

            for (int i = 1; i < num1 / 2; i++)
            {
                if(num1 % i == 0)
                    divisor1.Add(i);
            }
            divisor1.Add(num1);

            for (int i = 1; i < num2 / 2; i++)
            {
                if (num2 % i == 0)
                    divisor2.Add(i);
            }
            divisor2.Add(num2);

            foreach( var d in divisor1)
            {
                if (divisor2.Contains(d) & (d > gdc) )
                    gdc = d;
            }

            return gdc;
        }
    }
}
