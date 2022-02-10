using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class hailstone2
    {
        static void Main(string [] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            List<long> sequence = new List<long>();
            sequence.Add(n);
            while (sequence.Last() != 1)
            {
                long a = sequence.Last();
                if (a % 2 == 0)
                {
                    sequence.Add(a/2);
                } else
                {
                    sequence.Add(3 * a + 1);
                }
            }
            Console.WriteLine(sequence.Count);
        }
    }
}
