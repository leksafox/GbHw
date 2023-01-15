/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

// 1. Ввод числа
// int <- (string)
//принимает строковый параметр, а возвращает целое число
int InputInt(string? text)   
{
    //int text = Convert.ToInt32(text);
    return Convert.ToInt32(text);
}

// 2. Создание массива
// int[] <- (int)
//принимает число, а возвращает массив
int[] CreatArray(int length)  
{
    int[] array = new int[length];
    return array;
}

// 3. Заполнение массива
//принимает массив, но не выдаёт
void FillArray(int[] array) 
{
    for (int index = 0; index < array.Length; index++)
    {
       array[index] = InputInt(Console.ReadLine());
    }
}

// 4. Печать массива
//примает массив целых чисел, а выдаёт строку
string PrintArray(int[] array)   
{
    string output = String.Empty;
    for (int newIndex = 0; newIndex < array.Length; newIndex++)
    {
       output = output + " " + array[newIndex];
    }
    return output;
}

// 5. Подсчёт чисел
//принимает массив, возвращает количество элементов > 0
int CountNumb(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

/*1*/
Console.WriteLine("Введите длину массива: ");
int[] array = CreatArray(InputInt(Console.ReadLine()));
//int length = InputInt(Console.ReadLine());
/*2*/
//int[] array = new int[length];
/*3*/
Console.WriteLine("Введите элементы массива: " );
FillArray(array);
/*4*/
Console.WriteLine(PrintArray(array));
/*5*/
//int count = CountNumb(array);
/*6*/
Console.WriteLine("Количество элементов больше ноля: " + CountNumb(array));