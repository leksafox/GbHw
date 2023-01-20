/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());

// Метод нахождения суммы натуральных элементов в промежутке от M до N
int FindSum(int numberM, int numberN)
{
    if (numberM <= numberN)
    {
        return numberM + FindSum(numberM + 1, numberN);
    }
    else
        return 0;
}

Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} равна {FindSum(numberM, numberN)}");