// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 10000 && n <= 100000)
{
    int a = n / 10000;
    int b = n % 10000 / 1000;
// int c = n % 1000 / 100;
    int d = n % 100 / 10;
    int e = n % 10;
// Console.WriteLine(a+ " "+b+" "+c+" "+d+" "+e);
    if (a == e && b == d)
    Console.WriteLine("Палиндромом");
    else
    Console.WriteLine("Не палиндромом");
}
else
{
    Console.WriteLine("Число не пятизначное");
}



