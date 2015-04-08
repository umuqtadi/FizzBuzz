using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
         // if dvisible by 3 == fizz
        // if divisible by 5 == buzz
        // if divisible by both == fizzbuzz
        // if not divisible either return list of numbers that are not

            if (number%3 == 0 && number%5 == 0)
            {
                return "fizzbuzz";
            }
            else if (number%3 == 0)
            {
                return "fizz";
            }
            else if (number%5 == 0)
            {
                return "buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
