using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Everywhere
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int nCities = int.Parse(Console.ReadLine());
                List<string> cities = new List<string>(nCities);
                for (int j = 0; j < nCities; j++)
                {
                    cities.Add(Console.ReadLine());
                }
                Console.WriteLine(cities.Distinct().Count());
            }
        }
    }
}