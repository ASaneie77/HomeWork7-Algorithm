using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_02
{
    public class Task8
    {
        public static List<string> PermutationThreeNum(string in_text)
        {
            int permute_num = 1;
            int cntr = 0;

            string copy_text = "FGH";

            //for (int j = 0; j < in_text.Length; j++)
            //    copy_text += ' ';


            permute_num = GetPermuteNum(in_text);

            List<string> permut_list = new List<string>(permute_num);

            for (int i = 0; i < permute_num; i++)
                permut_list.Add(copy_text);

            List<int> checkCntrs = new List<int>();

            for (int cS = 0; cS < in_text.Length; cS++)
            {

                checkCntrs.Clear();
                foreach (var c in in_text)
                {
                    cntr = 0;
                    for (int i = 0; i < permute_num; i++)
                    {
                        if (!permut_list[i].Contains(c) && (cntr < (permute_num/in_text.Length) ) && (!checkCntrs.Contains(i)) )
                        {
                            permut_list[i] = permut_list[i].Replace(permut_list[i][cS], c);
                            checkCntrs.Add(i);
                            cntr++;
                        }
                    }
                }
            }

            return permut_list;

        }

        private static int GetPermuteNum(string in_text)
        {
            int permute_num = 1;

            for (int i = in_text.Length; i > 0; i--)
                permute_num *= i;

            return permute_num;
        }
    }
}
