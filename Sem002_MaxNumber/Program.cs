namespace HelloWorld
{ 
    // Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
    // 78 -> 8
    // 12 -> 2
    // 85 -> 8 
    class Program
    {
      public static void Main(string[] args)
      {
        // Вызов метода и получение результата от метода 
        int number = GetRandomNumber(10, 100);
        Console.WriteLine("Number: " + number);
        // Приведение number к строке (string)
        string str = number.ToString();
        // Записываю первую цифру числа
        int result = Convert.ToInt32(str[0].ToString());
        for (int i = 1; i < str.Length; i++)
        {
            if (result < Convert.ToInt32(str[i].ToString()))
            {
                result = Convert.ToInt32(str[i].ToString());
            }
        }
        Console.WriteLine("Result: " + result);
      }

      // Обьявляем функцию (метод)
      // <Тип данных возвращаемого значения> <имя функции> (<параметры>)
      
      public static int GetRandomNumber(int first, int second)
      {
           // Получаем случайное число от first включительно до second не включительно
           int number = new Random().Next(first, second);
           // Возвращаем значение
           return number; 
      } 
       


    }  
}
