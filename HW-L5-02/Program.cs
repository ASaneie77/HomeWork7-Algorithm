using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW_L5_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************************************************************************************************/
            Console.WriteLine("=======> Task1 , digits number of an integer,please enter your number (n >= 0) :");

            int in_num = int.Parse(Console.ReadLine());
            int digit_num = Task1.NumOfDigits(in_num);

            Console.WriteLine($"input : {in_num}, result : {digit_num}\n");

            /************************************************************************************************/
            Console.WriteLine("=======> Task2 , Check prime number, please input your number,(n > 0) :");

            in_num = int.Parse(Console.ReadLine());
            bool prime_result = Task2.CheckPrimeNumber(in_num);

            Console.WriteLine($"input : {in_num}, result : {prime_result}\n");

            /************************************************************************************************/
            Console.WriteLine("=======> Task3 , Sum digits : please input your number,(n > 0) :");

            in_num = int.Parse(Console.ReadLine());
            int sum_digits = Task3.SumDigits(in_num);

            Console.WriteLine($"input : {in_num}, result : {sum_digits}\n");


            /************************************************************************************************/
            Console.WriteLine("=======> Task4 , Palindrom number : please input your number,(n > 0) :");

            in_num = int.Parse(Console.ReadLine());
            bool is_palindrom = Task4.PalindromNumber(in_num);

            Console.WriteLine($"input : {in_num}, result : {is_palindrom}\n");

            /************************************************************************************************/
            Console.WriteLine("=======> Task5 , Find GDC, Pleas enter two number(n > 0)");

            int in_num1 = int.Parse(Console.ReadLine());
            int in_num2 = int.Parse(Console.ReadLine());

            int gdc = Task5.FindGdc(in_num1, in_num2);

            Console.WriteLine($"input1 : {in_num1}, input2 : {in_num2}, result : {gdc} ");


            /************************************************************************************************/
            Console.WriteLine("=======> Task6 , reverse integer number, please enter your number : ");

            in_num = int.Parse(Console.ReadLine());
            int reverse_num = Task6.ReverseNumber(in_num);

            Console.WriteLine($"input : {in_num}, result : {reverse_num} ");

            /************************************************************************************************/
            Console.WriteLine("=======> Task7 , convert integer number to binary, please enter your number : ");

            in_num = int.Parse(Console.ReadLine());
            string num_binary = Task7.ConvertToBin(in_num);

            Console.WriteLine($"input : {in_num}, result : {num_binary} ");

            /************************************************************************************************/
            Console.WriteLine("=======> Task8 , generate permutation of string, please enter your string : ");

            string in_text = Console.ReadLine();
            List<string> permute_text = Task8.PermutationThreeNum(in_text);

            Console.WriteLine($"input : {in_text} ");
            Console.Write($"result :");
            foreach (var text in permute_text)
                Console.Write($" {text},");

            Console.WriteLine("");
            /************************************************************************************************/
            Console.WriteLine("=======> Task9 , Check repeated number : ");

            int[] num_array = [1, 8, 15, 10, 6];

            bool is_repeated = Task9.CheckRepeatedNumber(num_array);

            Console.Write($"input :");
            for (int i = 0; i < num_array.Length; i++)
                Console.Write($" {num_array[i]},");

            Console.WriteLine($" result : {is_repeated} ");
        }
    }
}
