using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Modulo
    {
        public static void Main(string [] args)
        {
            List<int> numbers = new List<int>(10);
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()) % 42);
            }
            Console.WriteLine(numbers.Distinct().Count());
        }
    }
}
