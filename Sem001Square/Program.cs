namespace Seminar001_Square
{
    class program
    {
        // Напишите программу, которая на вход принимает число и выдаёт
        // его квадрат (число умноженное на само себя.)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            //1. Получаем число
            int number = Convert.ToInt32(Console.ReadLine());
            //2. Умножаем и записываем в отдельную переменную
            int square = number * number;
            //ИДИ 2. Получаем квадрат в переменной number
            number*= number;

            //3. Вывод результата
            Console.WriteLine($"Квадрат числа: {square}");
        } 
    }
}