using System;

namespace _3tries
{
    class Program
    {
        static void Main(string[] args)
        {
            int loginAttempts = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string username = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string password = Console.ReadLine();

                if (username != "admin" || password != "admin1234")
                    loginAttempts++;
                else
                    break;
            }

            if (loginAttempts > 2)
                Console.WriteLine("Proovi uuesti!");
            else
                Console.WriteLine("Tere tulemast!");

            Console.ReadKey();
        }
        }
    }
