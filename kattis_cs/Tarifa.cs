using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Tarifa
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int result = x * (n + 1);
            for (int i = 0; i < n; i++)
            {
                result -= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}