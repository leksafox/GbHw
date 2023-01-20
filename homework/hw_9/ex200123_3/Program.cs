/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите неотрицательное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

//Метод вычисления функции Аккермана:
int AckerFunction(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else
    if (numM > 0 && numN == 0)
        return AckerFunction(numM - 1, 1);
    return AckerFunction(numM - 1, AckerFunction(numM, numN - 1));
}

Console.WriteLine($"M = {numM}, N = {numN} -> A(m,n) = {AckerFunction(numM, numN)}");
