using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Ratingproblems
    {
        static void Main(string[] args)
        {
            double[] judges = Array.ConvertAll(Console.ReadLine().Split(), s => double.Parse(s));
            double rating = 0;
            for (int i = 0; i < judges[1]; i++)
            {
                rating += double.Parse(Console.ReadLine());
            }
            double min = (rating + (-3 * (judges[0] - judges[1]))) / judges[0];
            double max = (rating + (3 * (judges[0] - judges[1]))) / judges[0];
            Console.WriteLine(min + " " + max);
        }
    }
}