// Задача 54.Задайте двумерный массив.Напишите программу,которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

// Заполнение матрицы случайными числами
void FullArray()
{
    int[,] matr = new int[3, 4];
    Console.WriteLine("Массив до изменения:");
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 1)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    SortingArray(matr);
}

//Сортировка элементов по убыванию
void SortingArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j = j + 1)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k = k + 1)
            {

                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine("Массив упорядочен:");
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 1)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
FullArray();

