/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

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

// Функция вывода номера строки (не индекса) с наименьшей суммой элементов
int GetMinRow(int[,] array)
{
    int minRow = 0;
    int? minSum = null;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum == null || sum < minSum)
        {
            minRow = i;
            minSum = sum;
        }
    }
    return minRow;
}

// Создание массива
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];

// вызов методов
FillMatrix(array);
PrintMatrix(array);
GetMinRow(array);
Console.Write($"{GetMinRow(array) + 1} строка");
