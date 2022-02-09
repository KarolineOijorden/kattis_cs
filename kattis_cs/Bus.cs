using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Bus
    {
        static void Main(string [] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int passengers = 0;
                for (int j = 0; j < k; j++)
                {
                    passengers = passengers * 2 + 1;
                }
                Console.WriteLine(passengers);
             }
        }
    }
}
