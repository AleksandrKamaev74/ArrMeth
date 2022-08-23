// Задача 56.Задайте прямоугольный двумерный массив.Напишите программу,которая будет находить строку
// с наименьшей суммой элементов.Программа считает сумму элементов в каждой строке и выдает номер 
//строки с наименьшей суммой элементов

int[,] matr = new int[3, 4];
FillArray(matr);
int[] C = new int[matr.GetLength(0)];//массив для хранения суммы строк
SumLine(matr);
MinSum(matr);

// заполнение матрицы случайными числами
void FillArray(int[,] matr)
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

//Сумма элементов каждой строки 
void SumLine(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        int S = matr[i, 0];//Первоначальный элемент 0-го столбца,i-ой строки
        for (int j = 1; j < matr.GetLength(1); j = j + 1)
        {
            S = S + matr[i, j];//Сумма элементов i-ой строки
        }
        Console.WriteLine($"Cтрокa {i} --Sum={S}");
        C[i] = S;// одномерный массив из сумм элементов i-ой строки
    }
}

//Номер строки с наименьшей суммой элементов
void MinSum(int[,] matr)
{
    int imin = 0;
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        int min = C[0];
        if (C[i] < C[0])
        {
            C[i] = min;
            imin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Индекс строки с наименьшей суммой=" + imin);
}












