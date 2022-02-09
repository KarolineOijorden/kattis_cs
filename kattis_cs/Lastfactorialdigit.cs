using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Lastfactorialdigit
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                int fractoral = 1;
                for (int j = 1; j <= value; j++)
                {
                    fractoral *= j;
                }
                Console.WriteLine(fractoral % 10);
            }
        }
    }
}
