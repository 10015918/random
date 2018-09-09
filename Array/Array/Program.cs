using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Console.WriteLine("<--Arrays-->/nPlease enter 10 numbers.");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i+1}: ");
                int num = int.Parse(Console.ReadLine());
                array1[i] = num;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i + 1}: {array1[i]}");
            }
        }
    }
}
