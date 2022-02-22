using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número");
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }

            List<int> numsOrd = nums.OrderByDescending(e => e).ToList();

            Console.WriteLine("Números digitados ordenados:");
            foreach (var num  in numsOrd)
            {
                Console.Write(num);
                Console.WriteLine();
            }

        }
    }
}
