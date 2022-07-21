//    ДВУМЕРНЫЕ МАССИВЫ
// string[,] table = new string[2,3]; 
// int[,] matrix = new int[5,8];  (5 строк(matrix.GetLength(0))), (8 столбцов (matrix.GetLength(1)))   

///
string[,] table = new string[2, 5];
// table[0,0]  table[0,1]  table[0,2] ... table[0,4]
// table[1,0]  table[1,1]  table[1,2] ... table[1,4]


//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++) // rows(строки)
//{
//    for (int columns = 0; columns < 5; columns++)
//   {
//       Console.WriteLine($"{table[rows, columns]}");
//    }
//}



void PrintArray(int[,] matr) // Метод для создания матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)  // Метод для заполнения матрицы случайными числами
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        matr[i, j] = new Random().Next(1,10); // [1; 10)
      }
   }
}



int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);