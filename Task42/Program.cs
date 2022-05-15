using System;
using System.Linq;
Console.Clear();

/*
**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/

Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine());

string s = string.Empty;

while (numbers > 0)
{
    s = numbers % 2 + s;
    numbers = numbers / 2;
}
Console.WriteLine(s);