/*ДОПОЛНИТЕЛЬНАЯ (ПОЛНЫЙ ЦИКЛ РЕШЕНИЯ С РАЗБИВКОЙ НА МЕТОДЫ КАК В ПРЕДЫДУЩЕЙ ЗАДАЧЕ)
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

// Ввод числа
// int <- (string)
int InputNumber(string? text)  //принимает строковый параметр, а возвращает целое число 
{
    //int text = Convert.ToInt32(text);
    return Convert.ToInt32(text);
}

// Метод принимает целое и возвращает сумму его чисел
int DigitSum(int numb)
{
    int sum = 0;
    while (numb != 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int numb = InputNumber(Console.ReadLine());
Console.WriteLine("Сумма цифр числа = " + DigitSum(numb));