using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("no number provided!");
                return;
            }

            int number = 0;

            number = int.Parse(args[0]);
            Console.WriteLine($"the Number you gave is{number}");

            string result = Convert(number);
            Console.WriteLine(result); //console.WriteLine(Convert(number)) einai to idio 

            Console.WriteLine(Convert(2 * number));
            Console.ReadKey();
        }

        static string Convert(int number)
        {
            int[] digits = new int[32]; // me to new dhlwnoume mia metavliti autou tou tupou
            int i = 0;

            while (number / 2 >= 1)
            {
                int remainder = number % 2;
                digits[i] = remainder;
                number = number / 2;
                i = i + 1;
            }

            digits[i] = number;

            string result = "";

            while (i >= 0)
            {
                result = result + digits[i];
                i = i - 1; // einai san auto i--
            }

            return result;
        }

    }
}
