using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Reverse
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<String> numbers = new Stack<String>();
            for (int i = 0; i < n; i++)
            {
                numbers.Push(Console.ReadLine());
            }
            foreach (string i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}