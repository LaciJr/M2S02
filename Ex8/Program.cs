using System;
using System.IO;
using Newtonsoft.Json;

namespace Ex8
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\laci-\Documents\GitHub\M2S02\Ex8\notas.json";
            string json = File.ReadAllText(path);
            dynamic listaNotas = JsonConvert.DeserializeObject(json);
            int alunos = 0;

            Console.WriteLine("Alunos com nota menor que 5:");
            foreach (var item in listaNotas)
            {
                if (item.Nota < 5)
                {
                    Console.WriteLine(item.Nome);
                    alunos++;
                }
            }

            if(alunos == 0) Console.WriteLine("Nenhum aluno com nota menor que 5!");
        }
    }
}