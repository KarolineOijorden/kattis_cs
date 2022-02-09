using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Reverse
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            for (int j = n - 1; j >= 0; j--)
            {
                Console.WriteLine(numbers[j]);
            }
        }
    }
}