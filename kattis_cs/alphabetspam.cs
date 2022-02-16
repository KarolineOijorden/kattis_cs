using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class alphabetspam
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int whitespace = 0;
            int lowerCase = 0;
            int upperCase = 0;
            int symbol = 0;

            for (int i = 0; i < length; i++)
            {
                if (input[i] == '_')
                {
                    whitespace++;
                }
                else if (Char.IsLower(input[i]))
                {
                    lowerCase++;
                }
                else if (Char.IsUpper(input[i]))
                {
                    upperCase++;
                }
                else
                {
                    symbol++;
                }
            }
            Console.WriteLine((double)whitespace / length);
            Console.WriteLine((double)lowerCase / length);
            Console.WriteLine((double)upperCase / length);
            Console.WriteLine((double)symbol / length);
        }
    }
}