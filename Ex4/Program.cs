using System;

namespace Ex4
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = new int[7];
            int menor = int.MaxValue;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número");
                nums[i] = Convert.ToInt32(Console.ReadLine());

                if (nums[i] < menor)
                {
                    menor = nums[i];
                }
            }

            Console.WriteLine($"O menor número digitado foi {menor}");
        }
    }
}
