using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Меня зовут Денис.");
            Console.WriteLine("А как зовут тебя?");
            string name = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться {name}");
        }
    }
}
