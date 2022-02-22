using System;

namespace Ex2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a temperatura em graus celsius:");
            var c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A temperatura em graus Fahrenheit é {c * 1.8 + 32}");
        }
    }
}
