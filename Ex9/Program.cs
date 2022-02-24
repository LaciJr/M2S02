using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex9
{
    internal class Program
    {
        static void Main()
        {
            List<Alunos> listaNotas = new List<Alunos>();


            string path = @"C:\Users\laci-\Documents\GitHub\M2S02\Ex9\";

            using (StreamReader sr = File.OpenText($"{path}notas.json"))
            {
                var s = sr.ReadToEnd();
                listaNotas = JsonSerializer.Deserialize<List<Alunos>>(s);
            }

            if (listaNotas.Any(e => e.Nota < 5))
            {
                var alunosReprovados = listaNotas.FindAll(e => e.Nota < 5);

                using (StreamWriter sw = File.CreateText($"{path}reprovados.json"))
                {
                    string jsonAluno = JsonSerializer.Serialize(alunosReprovados);
                    sw.WriteLine(jsonAluno);
                }

                Console.WriteLine("Arquivo de alunos reprovados criado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhum aluno reprovado!");
            }
        }

        public class Alunos
        {
            public string Nome { get; set; }
            public int Nota { get; set; }
        }
    }
}
