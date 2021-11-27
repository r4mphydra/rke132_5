using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine("Sisesta number:");
                int un = Convert.ToInt32(Console.ReadLine());
                sum = sum + un; 
            }
            Console.WriteLine($"Your toteal is: {sum}");
        }
    }
}
