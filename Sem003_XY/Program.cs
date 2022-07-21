// Задача 1 Напишите программу, которая принимает на вход координаты точки(X и Y), причём X (неравен нулю) и Y (неравен нулю)
// и выдаёт номер четверти плоскости, в которой находится эта точка.  
// Задача 2 Напишите программу, которрая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

namespace seminar3
{


    class Program
    {
        static void Main(string[] args)
        {
            try // В ней мы оборачиваем определенный код и если в нём возкла какая-та ошибка
                //(например: попробуем перевести букву в число (ошибка) система скажет что она это сделать не может) она переводит её в CATCH.
            {
                int min = Int32.MinValue;
                int max = Int32.MaxValue;
                Console.WriteLine("Введите номер четверти: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine($" Диапазон 1 четверти: 0 < x < {max} и 0 < y < {max}");
                }
                else if (num == 2)
                {
                    Console.WriteLine($" Диапазон 2 четверти: {min} < x < 0 и 0 < y < {max}");
                }
                else if (num == 3)
                {
                    Console.WriteLine($" Диапазон 3 четверти: {min} < x < 0 и {min} < y < 0");
                }
                else if (num == 4)
                {
                    Console.WriteLine($" Диапазон 4 четверти: 0 < x < {max} и {min} < y < 0");
                }
                else
                {
                    Console.WriteLine(" Диапазона не существует ");
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine($"Введите нужное значение ");
            }


        }







    }
}
