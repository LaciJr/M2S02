using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex8
{
    internal class Program
    {
        static void Main()
        {
            List<Alunos> listaNotas = new List<Alunos>();


            string path = @"C:\Users\laci-\Documents\GitHub\M2S02\Ex8\notas.json";

            using (StreamReader sr = File.OpenText(path))
            {
                var s = sr.ReadToEnd();
                listaNotas = JsonSerializer.Deserialize<List<Alunos>>(s);
            }

            if (listaNotas.Any(e => e.Nota < 5))
            {
                var AlunosReprovados = listaNotas.FindAll(e => e.Nota < 5);
                Console.WriteLine("Alunos com nota menor que 5:");
                AlunosReprovados.ForEach(a => Console.WriteLine(a.Nome));
            } 
            else
            {
                Console.WriteLine("Nenhum aluno com nota menor que 5!");
            }
        }

        public class Alunos
        {
            public string Nome { get; set; }
            public int Nota { get; set; }
        }
    }
}