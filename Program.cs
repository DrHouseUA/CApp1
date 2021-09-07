using System;

namespace CApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}!");
            {
                Console.WriteLine("First block");
                {
                    Console.WriteLine("Second block");
                }
            }
            System.Console.ReadKey();
        }
    }
}
