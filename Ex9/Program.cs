using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\users\laci-\documents\github\m2s02\ex9\";
            string json = File.ReadAllText($"{path}notas.json");
            dynamic listaNotas = JsonConvert.DeserializeObject(json);
            var listaReprovados = new List<object>();

            foreach (var item in listaNotas)
            {
                if (item.Nota < 5)
                {
                    listaReprovados.Add(item);
                }
            }

            string jsonAluno = JsonConvert.SerializeObject(listaReprovados);
            if (listaReprovados.Count == 0)
            {
                Console.WriteLine("Nenhum aluno com nota menor que 5!");
            }
            else
            {
                using (StreamWriter sw = File.CreateText($"{path}reprovados.json"))
                {
                    sw.WriteLine(jsonAluno);
                }

                Console.WriteLine("Arquivo de alunos reprovados criado com sucesso!");
            }
        }
    }
}
