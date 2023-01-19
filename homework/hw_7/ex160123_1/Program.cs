// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// вводим размер массива
Console.WriteLine("Введите количество строк M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N: ");
int n = Convert.ToInt32(Console.ReadLine());

// создаём массив
double[,] matrix = new double[m, n];

// заполняем массив случайными
void FillMatrix(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().NextDouble() * 4;
        }
    }
}

// печатаем массив
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 2) + " ");
        }
        Console.WriteLine("");
    }
}

// вызов методов
FillMatrix(matrix);
PrintMatrix(matrix);