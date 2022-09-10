// Показать двумерный массив размером m×n заполненный вещественными числами

 void FillArray(double[,] array)                                          
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
       {
             array[i, j] = new Random().NextDouble();
         }
     }
 }

 void PrintArray(double[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write($"{array[i, j]} ");
         }
         Console.WriteLine();
    }
 }

 int m = 4;
 int n = 3;

 double[,] array = new double [m, n];

 FillArray(array);
 PrintArray(array);
