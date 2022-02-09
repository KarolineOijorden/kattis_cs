using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Guess
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 1000;
            int guess = 500;
            string response;

            Console.WriteLine(guess);
            Console.Out.Flush();

            while ((response = Console.ReadLine()) != "correct")
            {
                if (response == "lower")
                {
                    max = guess;
                    guess = min + ((guess - min) / 2);
                }
                else
                {
                    min = guess;
                    guess = max - ((max - guess) / 2);
                }
                Console.WriteLine(guess);
                Console.Out.Flush();
            }
        }
    }
}