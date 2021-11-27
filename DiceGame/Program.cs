using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int cr = rnd.Next(1, 7);
                int ur = rnd.Next(1, 7);
                int cs = 0;
                int us = 0;
                Console.WriteLine($"CPU got {cr}. User got {ur}.");

                if (cr < ur)
                {
                    Console.WriteLine("User won!");
                    us = us + 1;
                }
                else if (cr > ur)
                {
                    Console.WriteLine("CPU won!");
                    cs = cs + 1;
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
        }
    }
}
