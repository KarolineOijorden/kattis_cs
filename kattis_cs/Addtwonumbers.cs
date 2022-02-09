using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Addtwonumbers
    {
        static void Main(String[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(numbers[0]) + int.Parse(numbers[1]));
        }
    }
}