/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

// Создание массива
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];

// вызов методов
FillMatrix(array);
PrintMatrix(array);

//Ввод номера элемента
Console.Write("Введите позицию элемента: ");
int pos = Convert.ToInt32(Console.ReadLine());

int i = pos / colums;
int j = pos % colums;

if (i < array.GetLength(0) && j < array.GetLength(1))
{
    Console.WriteLine($"Значение элемента = {array[i, j]}");
}
else
{
    Console.WriteLine($"{pos} -> такого элемента в массиве нет");
}