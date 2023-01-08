// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7)
{
    Console.WriteLine("Не является днём недели");
}
else if (n > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("НЕ выходной день");
}
