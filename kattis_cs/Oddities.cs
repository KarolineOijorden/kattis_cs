using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Oddities
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value % 2 == 0)
                {
                    Console.WriteLine(value + " is even");
                } else
                {
                    Console.WriteLine(value + " is odd");
                }
            }
        }
    }
}
