using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Numberfun
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), s => double.Parse(s));
                if (numbers[0] + numbers[1] == numbers[2] || numbers[0] - numbers[1] == numbers[2]
                    || numbers[1] - numbers[0] == numbers[2] || numbers[0] * numbers[1] == numbers[2]
                    || numbers[0] / numbers[1] == numbers[2] || numbers[1] / numbers[0] == numbers[2])
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
