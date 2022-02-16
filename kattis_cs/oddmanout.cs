using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class oddmanout
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int g = int.Parse(Console.ReadLine());
                string [] guests = Console.ReadLine().Split();
                HashSet<String> distinctGuests = new HashSet<String>();

                for (int j = 0; j < g; j++)
                {
                    if (!distinctGuests.Remove(guests[j]))
                    {
                        distinctGuests.Add(guests[j]);
                    }
                }
                distinctGuests.CopyTo(guests);
                Console.WriteLine("Case #{0}: {1}", i, guests[0]);
            }
        }
    }
}