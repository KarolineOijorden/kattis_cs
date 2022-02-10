using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class cinema
    {
        static void Main(string [] args)
        {
            string[] input = Console.ReadLine().Split();
            int seats = int.Parse(input[0]);
            int groups = int.Parse(input[1]);
            int result = 0;
            int[] visitors = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

            for (int i = 0; i < groups; i++)
            {
                int availableSeats = seats - visitors[i];
                if (availableSeats >= 0)
                {
                    seats = availableSeats;
                } else
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
