// Задача 1 Напишите программу, которая принимает на вход координаты точки(X и Y), причём X (неравен нулю) и Y (неравен нулю)
// и выдаёт номер четверти плоскости, в которой находится эта точка.  namespace Sem003_XY

namespace Sem003_XY
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberX = Convert.ToInt32(Console.ReadLine());
            int numberY = Convert.ToInt32(Console.ReadLine());

            if (numberX == 0 || numberY == 0)
            {
                System.Console.WriteLine("We don't know");
            }
            else
            {
                if (numberX > 0)
                {
                    if (numberY > 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(4);
                    }
                }
                else
                {
                    if (numberY > 0)
                    {
                        Console.WriteLine(2);
                    }
                    else
                    {
                        Console.WriteLine(3);
                    }
                }
            }


        }
    }
}