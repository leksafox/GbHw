// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];

FillMatrix(array);
PrintMatrix(array);
Console.Write("Среднее арифметическое каждого столбца: ");
MiddleColums(array);


// Заполнение массива рандомными числами от 1 до 9
void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Печать массива в терминал
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// вычисление среднего арифметического столбцов
void MiddleColums(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
    Console.Write($"{Math.Round((double)sum / array.GetLength(0),2)}; ");
    }
}