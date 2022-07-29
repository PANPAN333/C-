// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали ( с индексами(0,0) (1,1) и т.д)
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// сумма элементов главной диагонали: 1+9+2=12 

namespace Seminar007
{
    class program
    {
        public static void Main()
        {
            int[,] numbers = new int[2, 5];
            FillRandomArray(numbers);
            Console.WriteLine("Выводим на экран массив заполненный случайными числами");
            PrintRandomArray(numbers);
            int sum = ResultOfDiag(numbers);
            System.Console.WriteLine($"Сумма элементов главной диагонали = {sum} ");
        }

        public static void FillRandomArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(0,11);
                }
            }
        }

        public static int ResultOfDiag(int[,] arr)
        {
            int result = 0;
            int length = arr.GetLength(0);
            if (length > arr.GetLength(1)) { length = arr.GetLength(1);}
            for (int i = 0; i < length; i++)   // (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++ )
            {
                result += arr[i,i];
            }
            return result;
        }

        public static void PrintRandomArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}");
                }
                Console.WriteLine();
            }
        }




    }
}
