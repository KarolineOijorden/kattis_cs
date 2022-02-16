using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class jobexpenses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int expenses = 0;
            if (n > 0)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i][0] == '-')
                    {
                        expenses += int.Parse(numbers[i]);
                    }
                }
            }
            Console.Write(Math.Abs(expenses));
        }
    }
}