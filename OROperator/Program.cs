using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kasutajatunnus:");
            string user = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string password = Console.ReadLine();
            if (user != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunus voi parool. Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
