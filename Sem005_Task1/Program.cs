// 1. Напишите программу замена элементов массива: положительные элементы заменить на соответствующие отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 5, -10, -20, 20
// массив [6, 7, 19, 345, 3] -> нет

namespace Seminar005
{
    class Task2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = new Random().Next(5, 11);
            int[] array = new int[a];
            ArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            if (Valid(array, b)) 
            {
                Console.WriteLine();
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }


        public static bool Valid(int[] arr, int с)
        {
            bool b = false;
            for (int i = 0; i < arr.Length; i++)
            {

                if (с == arr[i])
                b = true;
                break;
            }
            return b;
        }
        public static void ArrayRandom(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-20, 21);

            }

        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

    }
}
