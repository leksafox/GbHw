/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
// res[i] = a[i] * a[N - 1 - i]

/* 1. Считывание данных от пользователя 
   Считать int число
   int <- string */
int InputInt(string? text)
{
    return Convert.ToInt32(text);
}

/* 2. Создать массив
   int-чисел
   int[] <- int */
int[] CreatArray(int numb)
{
    int[] array = new int[numb];
    return array;
}

/* 3. Заполнить массив
   с клавиатуры
   int[] <- (void)  */

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = InputInt(Console.ReadLine());
    }
}

/*4. Найти произведения
   int[] <- int[] */
int[] MultArray(int[] array)  //получает массив, и выдаёт новый массив
{
    // int[] mult = new int[array.Length/2];  так программа пропускает середину у нечётного массива
    int[] mult = new int[array.Length / 2 + array.Length % 2];
    if (array.Length % 2 > 0) { mult[mult.Length - 1] = array[mult.Length - 1]; };

    for (int i = 0; i < array.Length / 2; i++)
    {
        mult[i] = array[i] * array[array.Length - 1 - i];
    }
    return mult;
}

/* 5. Распечатать
   string <- int[] */
string PrintArray(int[] array)   //примает массив целых чисел, а выдаёт строку
{
    string output = String.Empty;
    for (int newIndex = 0; newIndex < array.Length; newIndex++)
    {
        output = output + " " + array[newIndex];
    }
    return output;
}

Console.WriteLine("Введите длину массива: ");
int[] array = CreatArray(InputInt(Console.ReadLine()));
Console.WriteLine("Введите числа массива: ");
FillArray(array);
Console.WriteLine("Исходный массив " + PrintArray(array));
int[] newArray;
newArray = MultArray(array);
Console.WriteLine("Результат произведения " + PrintArray(newArray));
