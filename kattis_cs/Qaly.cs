using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Qaly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                string[] lifeQuality = Console.ReadLine().Split();
                result += Convert.ToDouble(lifeQuality[0]) * Convert.ToDouble(lifeQuality[1]);
            }
            Console.WriteLine(result);
        }
    }
}