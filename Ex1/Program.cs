using System;

namespace Ex1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o raio do círculo:");
            var r = Console.ReadLine();
            int ra = Convert.ToInt32(r);
            Console.WriteLine($"A área do circulo é {ra*ra*Math.PI}");
        }
    }
}
