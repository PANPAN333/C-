// 1. Напишите программу замена элементов массива: положительные элементы заменить на соответствующие отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

namespace Seminar005
{
    class Task1
    {
        static void Main(string[] args)
        {
            int count = new Random().Next(5, 11);
            int[] arrayNumber = new int[count];
            Console.WriteLine("Первоначальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            Console.WriteLine("Перевернутый массив: ");
            PrintChangeArray(arrayNumber);
            Console.ReadKey();
        }
        // Заполнение и печать Массива
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int number = new Random().Next(-20, 20);
                array[i] = number;
                Console.Write($"{array[i]} ");
            }
        }
        // Замена элементов и печать массива
        public static void PrintChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * -1;
                Console.Write($"{array[i]} ");
            }
        }
    }
}