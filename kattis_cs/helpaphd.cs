using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class helpaphd
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input[0] == 'P')
                {
                    Console.WriteLine("skipped");
                } else
                {
                    string[] values = input.Split('+');
                    Console.WriteLine(int.Parse(values[0]) + int.Parse(values[1]));
                }
            }
        }
    }
}
