// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еиницами в случайном порядке.
// [1,0,1,1,0,1,0,0]

namespace Task2_RandomMassiv_Variant2
{
    class Program
    {
        public static void Main()
        {
           int[] arrayNumbers = new int[8];
           Random(arrayNumbers);
           PrintArray(arrayNumbers);

        }

        public static void Random(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                array[i] = new Random().Next(0, 2);
            }
        }
        public static void PrintArray(int[] array)
        {
          int count = array.Length;
          for (int i = 0; i < count; i++)
          {
            Console.Write($"{array[i]} ");
          }
        }
    }
}