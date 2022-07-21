//Возводит все числа до N в квадрат
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Читаем число с консоли
            int a = Convert.ToInt32(Console.ReadLine());
            // Перебор массива с помощью цикла 
            for (int i = 1; i <= a; i++)
            {
                // Вывод чисел в консоль
                PrintSquare(i);
            }
        }
        // Обьявление функции 
        public static void PrintSquare(int n)
        {
            Console.WriteLine(n * n);
        }
    }
}