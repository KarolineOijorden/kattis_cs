using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class apaxiaaans
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = name[0].ToString();
            for (int i = 1; i < name.Length; i++)
            {
                if (name[i] != name[i - 1])
                {
                    result = result + name[i].ToString();
                }
            }
            Console.Write(result);
        }
    }
}
