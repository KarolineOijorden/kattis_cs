using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Sevenwonders
    {
        static void Main(String[] args)
        {
            string cards = Console.ReadLine();
            int t = cards.Count(s => s == 'T');
            int c = cards.Count(s => s == 'C');
            int g = cards.Count(s => s == 'G');
            int score = t * t + c * c + g * g;
            score += Math.Min(Math.Min(t, c), g) * 7;
            Console.WriteLine(score);
        }
    }
}
