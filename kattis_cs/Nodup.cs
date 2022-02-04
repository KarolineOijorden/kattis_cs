using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Nodup
    {
        static void Main(string [] args)
        {
            string [] words = Console.ReadLine().Split();
            string result = "yes";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        result = "no";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
