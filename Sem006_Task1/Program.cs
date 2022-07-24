// See https://aka.ms/new-console-template for more information


 // 1. Напишите программу, который перевернет одномерный массив (последний элемент будет на первом месте,а первый на последнем и т.д)

 // 2. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

 public class ProgrSeminar
 {
    public int[] GetArray()
    {
        Random random = new Random();
        int x = random.Next(5, 11);
        int[] arr = new int[x];
        Console.WriteLine("Выводим искомый массив");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 41);
            Console.Write(arr[i] + " ");
        }
        return arr;
    }

    public static void Main()
    {
        ProgrSeminar progrSeminar = new ProgrSeminar();
        int[] mass = progrSeminar.GetArray();
        for (int i = 0; i < mass.Length / 2; i++)
        {
            int a = mass[i];
            mass[i] = mass[mass.Length - 1 - i];
            mass[mass.Length - 1 - i] = a;

        }
        Console.WriteLine(" ");
        System.Console.WriteLine("Выводим получившийся массив");
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(mass[i] + " ");
        }
    }
 }