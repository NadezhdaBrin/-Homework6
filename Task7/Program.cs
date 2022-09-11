// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
}
void Ordering(int[,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(1))
    {
        int[,] nums = new int[matr.GetLength(0), matr.GetLength(1)];
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                nums[m, n] = matr[m, n];
            }
        }
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                matr[m, n] = nums[n, m];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);
