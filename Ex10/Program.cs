using System;

namespace Ex10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o salário do colaborador utilizando apenas números:");
            int salario = Convert.ToInt32(Console.ReadLine());
            double percentual = 0;

            switch (salario)
            {
                case < 280:
                    percentual = 0.2;
                    MostrarSalario(salario, percentual);
                    break;

                case < 700:
                    percentual = 0.15;
                    MostrarSalario(salario, percentual);
                    break;

                case < 1500:
                    percentual = 0.10;
                    MostrarSalario(salario, percentual);
                    break;

                case >= 1500:
                    percentual = 0.05;
                    MostrarSalario(salario, percentual);
                    break;

                default:
                    Console.WriteLine($"Salário inválido");
                    break;
            }

            static void MostrarSalario(int salario, double percentual)
            {
                Console.WriteLine($"Salário anterior: {salario}");
                Console.WriteLine($"Percentual de aumento aplicado: {percentual * 100}%");
                Console.WriteLine($"Valor do aumento: {salario * percentual}");
                Console.WriteLine($"Novo salário: {salario * (percentual + 1)}");
            }
        }
    }
}
