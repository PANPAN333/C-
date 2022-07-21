//Возводит все числа до N в квадрат
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Читаем число с консоли
            int a = Convert.ToInt32(Console.ReadLine());
            // Получаем результат функции  GetSquare
            int[] squares = GetSquare(a);

            // Перебор массива с помощью цикла 
            for (int i = 0; i < squares.Length; i++)
            {
                // Вывод чисел в консоль
                Console.WriteLine( squares[i] + " ");
            }
        }
        // Обьявление функции 
        public static int[] GetSquare( int n)
        {   
            // Создание массива с размерностью n
            int[] square = new int[n];
            // Обьявление цикла от 1 до n включительно
            for (int i = 1; i <= n; i++)
            {
                // Запись в i - 1 элемент массива (по индексу) квадрата числа i
                square[i-1] = i*i;
            }
            // Возвращение массива
            return square;
        }
    }
}