/*Напишите программу, которая выводит массив из N элементов,
заполненный нулями и единицами в случайном порядке.
Самое левое число != 0
Данный массив есть двоичное представление десятичного числа
[1,0,1,1,0,1,0,0]
Реализовать перевод двоичного числа в десятичное*/

// 1. Ввод N
// int <- (string) 

int InputLength(string? text)  //принимает строковый параметр, а возвращает целое число 
{
    return Convert.ToInt32(text);
}

// 2. Создание массива
// int[] <- (int)

int[] CreatArray(int length)  //принимает строковый параметр, а возвращает целое число
{
    int[] array = new int[length];
    return array;
}

// 3. Заполнение массива 0 и 1
// void <- (int[])

void FillArray(int[] array) //принимает массив, но не выдаёт
{
    array[0] = 1;
    for (int index = 1; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 2);  //Shared
    }
}

// 4. Печать массива
// string <- (int[])

string PrintArray(int[] array)   //примает массив целых чисел, а выдаёт строку
{
    string output = String.Empty;
    for (int newIndex = 0; newIndex < array.Length; newIndex++)
    {
        output = output + array[newIndex];
    }
    return output;
}

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

int ConvertDec(int[] array)    //принимает массив, а возвращает целое число
{
    int dec = 0;
    for (int i = 0; i < array.Length; i++)
    {
        dec = dec + (int)(array[i]*Math.Pow(2, array.Length-1-i)); 
    }
return dec;
}

// 6. 10110100 >> 180
// string <- (int[] , int)

string GoodPrint(int[] array, int dec)   //принимает массив, возвращает строку
{
    return $"{String.Join("", array)} >> {dec}";
}

Console.WriteLine("Введите длину массива: ");
int length = InputLength(Console.ReadLine());
int[] numbers = CreatArray(length);
FillArray(numbers);
Console.WriteLine(PrintArray(numbers));
int dec = ConvertDec(numbers);
Console.WriteLine(GoodPrint(numbers, dec));
