// Напишите программу которая в двумерном массиве меняет местами столбцы и строки.

namespace Seminar008
{
    class program
    {
        static int[,] A ={{1, 4, 7, 2},
                          {5, 9, 2, 3},
                          {8, 4, 2, 4},
                          {5, 2, 6, 7}};
        static bool CheckArrayParam(int[,] a) // проверка 
        {
            if(a.GetUpperBound(0) == a.GetUpperBound(1)) return true; // a.GetUpperBound(0) (rows) == a.GetUpperBound(1) (columns)
            else return false;
        }
        static int[,] TransponArray(int[,] a)  // функция которая занимается транспонированием матрицы
        {
            int[,] b = new int[a.GetUpperBound(0) + 1, a.GetUpperBound(1) + 1];
            for (int i = 0; i < a.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < a.GetUpperBound(1) + 1; j++)
                {
                    b[j, i] = a[i,j];
                }
            }
            return b;
        }                   
        
        static void ViewArray(int[,] a) // функция котрая выводит массив на экран
        {
            for (int i = 0; i < a.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < a.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(a[i, j]);
                }
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Например, задан массив");
            ViewArray(A);
            if (CheckArrayParam(A))
            {
                A = TransponArray(A);
                Console.WriteLine("В итоге получается такой массив: ");
                ViewArray(A);
            }
            else
            Console.WriteLine("Невозможно транспонировать ");
        }    
    }
}