using System;

namespace Ex7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o número a ser invertido:");
            var num = Console.ReadLine();
            var invertido = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                invertido += num[i];
            }

            Console.WriteLine($"Valor invertido: {invertido}");
        }
    }
}
