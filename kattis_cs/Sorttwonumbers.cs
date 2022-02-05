using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
    {
        class Sorttwonumbers
        {
            static void Main(string[] args)
            {
                string[] numbers = Console.ReadLine().Split();
                if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
                {
                    Console.WriteLine(numbers[1] + " " + numbers[0]);
                }
                else
                {
                    Console.WriteLine(numbers[0] + " " + numbers[1]);
                }
            }
        }
    }
