using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            while (number < 0)
            {
                Console.WriteLine("Please give a number >= 0");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number you gave is " + number); // grafetai kai alliws --> Console.WriteLine($"the Number you gave is{number}");

            string result = Convert(number);
            Console.WriteLine(result);

            Console.WriteLine(Convert(2 * number));

            Console.ReadKey();
        }

        static string Convert(int number) // allos tropos xrhsimopoiwntas sunarthsh 
        {
            int[] digits = new int[32]; // me to new dhlwnw metablhth autou tou tupou
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
                i = i - 1;
            }

            return result;
        }
    }
}