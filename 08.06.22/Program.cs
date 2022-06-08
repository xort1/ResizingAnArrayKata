using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Изменение размера массива. Все массивы заполняюся с помощью Random---\n\nВведите начальное количество элементов массива...");
            int count = int.Parse(Console.ReadLine());

            int[] Array = new int[count];

            Random random = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(10);
                Console.Write($"Array[{i}] = {Array[i]}\t");
            }

            Console.WriteLine("\n\nВведите конечное количество элементов массива...");
            int countEndl = int.Parse(Console.ReadLine());

            Resize(countEndl, ref Array);

            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
        }

        static void Resize(int count, ref int[] Array)
        {
            Array = new int[count];

            Random random = new Random();

            for (int i = 0; i < Array.Length; i++)
                Array[i] = random.Next(10);
        }
    }
}