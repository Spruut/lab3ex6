using System;

namespace lab3ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            int i = array.Length - 1;
            int j = 0;
            RandomMatrix(array, random);
            int sumR = 0;
            int minR = (int)array.GetValue(0);

            WriteMatrix(array);

            Console.WriteLine($"sumIterative = {SumIterative(array, out int sum)}");
            Console.WriteLine($"sumRecursuve = {SumRecursive(array, sumR, i)}");
            Console.WriteLine($"minIterative = {MinIterative(array, out int min)}");
            Console.WriteLine($"minRecursive = {MinRecursive(array, j, minR)}");
            Console.ReadKey();
        }
        static int SumIterative(int[] array, out int sum)
        {
            sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int SumRecursive(int[] array, int sum, int i)
        {
            if (i == 0)
            {
                return array[0];
            }
            else
            {
                sum = array[i];
                i--;
            }
            return sum + SumRecursive(array, sum, i);
        }
        static int MinIterative(int[] array, out int min)
        {
            min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (min > array[i + 1])
                    min = array[i + 1];
            }
            return min;
        }
        static int MinRecursive(int[] array, int j, int min)
        {
            if (j == array.Length - 1)
                return min;
            if (min > array[j + 1])
            {
                min = array[j + 1];
            }
            return MinRecursive(array, j + 1, min);
        }
        static void RandomMatrix(int[] array, Random random)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(0, 9);
            }
        }
        static void WriteMatrix(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
