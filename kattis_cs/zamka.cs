using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class zamka
    {
        static void Main(string [] args)
        {
            int l = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int min = 0; 
            int max = 0;
            int i = l;
            int j = d;
            bool n = true;
            bool m = true;

            while (n)
            {
                int sum = 0;
                int c = i;
                while (c != 0)
                {
                    sum += c % 10;
                    c /= 10;
                }
                if (sum == x)
                {
                    min = i;
                    n = false;
                }
                i++;
            }

            while (m)
            {
                int sum = 0;
                int c = j;
                while (c != 0)
                {
                    sum += c % 10;
                    c /= 10;
                }
                if (sum == x)
                {
                    max = j;
                    m = false;
                }
                j--;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
