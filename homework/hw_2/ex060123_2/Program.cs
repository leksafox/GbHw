// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (x >= 1000)
    {
        x = x / 10;
    }
    int b = x % 10;

    Console.WriteLine("Третья цифра числа = " + b);
}


