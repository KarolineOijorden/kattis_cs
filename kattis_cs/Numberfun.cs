using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Numberfun
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                int number1 = numbers[0];
                int number2 = numbers[1];
                int number3 = numbers[2];
                double n1 = Convert.ToDouble(number1);
                double n2 = Convert.ToDouble(number2);
                if (number1 + number2 == number3 || number1 - number2 == number3
                    || number2 - number1 == number3 || number1 * number2 == number3
                    || n1 / n2 == number3 || n2 / n1 == number3)
                {
                    Console.WriteLine("Possible");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}
