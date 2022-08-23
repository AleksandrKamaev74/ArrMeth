
// Задача 58.Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Первая матрица A:");
int[,] matr1 = new int[4, 4];
PrintArray(matr1);
Console.WriteLine("Вторая матрица B:");
int[,] matr2 = new int[4, 4];
PrintArray(matr2);
Console.WriteLine();
Console.WriteLine("Итоговая матрица C=A*B:");
MatrixMultiplication(matr1, matr2);

// Заполнение матрицы случайными числами
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 1)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Умножение двух матриц A и B
void MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] res = new int[4, 4];

    for (int i = 0; i < matr1.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr2.GetLength(1); j = j + 1)
        {
            res[i, j] = 0;
            for (int k = 0; k < matr2.GetLength(0); k = k + 1)
            {
                res[i, j] = res[i, j] + matr1[i, k] * matr2[k, j];
            }
            Console.Write($"{res[i, j]} ");
        }
        Console.WriteLine();
    }
}