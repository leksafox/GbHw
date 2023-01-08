// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (numberA > numberB)
    {
        Console.Write("A > B максимум = ");
        Console.WriteLine(numberA);
    }
    else
    {
        Console.Write("A < B максимум = ");
        Console.WriteLine(numberB);
    }
}
