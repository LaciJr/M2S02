using System;
using System.Collections.Generic;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tri = new List<int>();

            Console.WriteLine("Insira a medida dos lados do triangulo:");
            for (int i = 0; i < 3; i++)
            {
                tri.Add(Convert.ToInt32(Console.ReadLine()));
            }

            if ((tri[0]<tri[1]+tri[2]) && (tri[1]<tri[0]+tri[2]) && (tri[2]<tri[0]+tri[1]))
            {
                Console.WriteLine("Esse valores podem formar um triângulo! vamos ver qual...");

                if((tri[0] == tri[1]) && (tri[1] == tri[2]))
                {
                    Console.WriteLine("É um triângulo Equilátero!");
                }
                else if ((tri[0] == tri[1]) || (tri[0] == tri[2]) || (tri[1] == tri[2]))
                {
                    Console.WriteLine("É um triângulo Isósceles!");
                }
                else
                {
                    Console.WriteLine("É um triângulo Escaleno!");
                }
            }
            else
            {
                Console.WriteLine("Esses valores não formam um triângulo");
            }
        }
    }
}
