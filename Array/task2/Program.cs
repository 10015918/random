using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 1000;
            Random rand = new Random();
            Console.WriteLine("Random numbers being generated...");
            int[] array1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                array1[i] = rand.Next(1000, 9999);
            }

            int check;
            

            for (int j = 0; j < array1.Length; j++)
            {
                int total = 0;
                check = array1[j];
                for(int k = 0;k < array1.Length; k++)
                {
                    if (array1[k] == check)
                        total += 1;
                }
                Console.WriteLine($"array1 index {j+1} occured {total} times.");
            }
        }
    }
}
