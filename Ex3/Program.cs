using System;

namespace Ex3
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = new int[5];
            int maior = int.MinValue;

            for (int i = 0; i < 5; i++)
            {   
                Console.WriteLine($"Digite o {i+1}º número");
                nums[i] = Convert.ToInt32(Console.ReadLine());

                if (nums[i] > maior)
                {
                    maior = nums[i];
                }
            }

            Console.WriteLine($"O maior número digitado foi {maior}");
        }
    }
}
