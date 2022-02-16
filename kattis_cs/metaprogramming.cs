using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class metaprogramming
    {
        static void Main(string [] args)
        {
            Dictionary<string, int> definitions = new Dictionary<string, int>();
            string input;
            string[] command;
            int y;
            int z;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                command = input.Split();
                if (command[0] == "define")
                {
                    definitions[command[2]] = int.Parse(command[1]);
                } 
                else
                {
                    if (definitions.TryGetValue(command[1], out y) && definitions.TryGetValue(command[3], out z))
                    {
                        if (command[2] == "<")
                        {
                            Console.WriteLine(y < z);
                        }
                        else if (command[2] == ">")
                        {
                            Console.WriteLine(y > z);
                        }
                        else
                        {
                            Console.WriteLine(y == z);
                        }
                    }
                    else
                    {
                        Console.WriteLine("undefined");
                    }
                }
            }
        }
    }
}
